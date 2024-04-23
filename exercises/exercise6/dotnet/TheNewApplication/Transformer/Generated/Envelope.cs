// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.11.3
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace cdc.@public.customers
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("avrogen", "1.11.3")]
	public partial class Envelope : global::Avro.Specific.ISpecificRecord
	{
		public static global::Avro.Schema _SCHEMA = global::Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Envelope\",\"namespace\":\"cdc.public.customers\",\"fields\":[{" +
				"\"name\":\"before\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Value\",\"n" +
				"amespace\":\"cdc.public.customers\",\"fields\":[{\"name\":\"customer_id\",\"type\":{\"type\":" +
				"\"string\",\"connect.version\":1,\"connect.name\":\"io.debezium.data.Uuid\"}},{\"name\":\"s" +
				"sn\",\"type\":\"string\"},{\"name\":\"email\",\"type\":\"string\"},{\"name\":\"user_name\",\"type\"" +
				":\"string\"},{\"name\":\"full_name\",\"type\":\"string\"},{\"name\":\"delivery_address\",\"type" +
				"\":\"string\"},{\"name\":\"delivery_zipcode\",\"type\":\"string\"},{\"name\":\"delivery_city\"," +
				"\"type\":\"string\"},{\"name\":\"billing_address\",\"default\":null,\"type\":[\"null\",\"string" +
				"\"]},{\"name\":\"billing_zipcode\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"" +
				"billing_city\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"ts\",\"default\":0," +
				"\"type\":{\"type\":\"long\",\"connect.version\":1,\"connect.default\":0,\"connect.name\":\"io" +
				".debezium.time.MicroTimestamp\"}}],\"connect.name\":\"cdc.public.customers.Value\"}]}" +
				",{\"name\":\"after\",\"default\":null,\"type\":[\"null\",\"Value\"]},{\"name\":\"source\",\"type\"" +
				":{\"type\":\"record\",\"name\":\"Source\",\"namespace\":\"io.debezium.connector.postgresql\"" +
				",\"fields\":[{\"name\":\"version\",\"type\":\"string\"},{\"name\":\"connector\",\"type\":\"string" +
				"\"},{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"ts_ms\",\"type\":\"long\"},{\"name\":\"snaps" +
				"hot\",\"default\":\"false\",\"type\":[{\"type\":\"string\",\"connect.version\":1,\"connect.par" +
				"ameters\":{\"allowed\":\"true,last,false,incremental\"},\"connect.default\":\"false\",\"co" +
				"nnect.name\":\"io.debezium.data.Enum\"},\"null\"]},{\"name\":\"db\",\"type\":\"string\"},{\"na" +
				"me\":\"sequence\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"schema\",\"type\":" +
				"\"string\"},{\"name\":\"table\",\"type\":\"string\"},{\"name\":\"txId\",\"default\":null,\"type\":" +
				"[\"null\",\"long\"]},{\"name\":\"lsn\",\"default\":null,\"type\":[\"null\",\"long\"]},{\"name\":\"x" +
				"min\",\"default\":null,\"type\":[\"null\",\"long\"]}],\"connect.name\":\"io.debezium.connect" +
				"or.postgresql.Source\"}},{\"name\":\"op\",\"type\":\"string\"},{\"name\":\"ts_ms\",\"default\":" +
				"null,\"type\":[\"null\",\"long\"]},{\"name\":\"transaction\",\"default\":null,\"type\":[\"null\"" +
				",{\"type\":\"record\",\"name\":\"block\",\"namespace\":\"event\",\"fields\":[{\"name\":\"id\",\"typ" +
				"e\":\"string\"},{\"name\":\"total_order\",\"type\":\"long\"},{\"name\":\"data_collection_order" +
				"\",\"type\":\"long\"}],\"connect.version\":1,\"connect.name\":\"event.block\"}]}],\"connect." +
				"version\":1,\"connect.name\":\"cdc.public.customers.Envelope\"}");
		private cdc.@public.customers.Value _before;
		private cdc.@public.customers.Value _after;
		private io.debezium.connector.postgresql.Source _source;
		private string _op;
		private System.Nullable<System.Int64> _ts_ms;
		private @event.block _transaction;
		public virtual global::Avro.Schema Schema
		{
			get
			{
				return Envelope._SCHEMA;
			}
		}
		public cdc.@public.customers.Value before
		{
			get
			{
				return this._before;
			}
			set
			{
				this._before = value;
			}
		}
		public cdc.@public.customers.Value after
		{
			get
			{
				return this._after;
			}
			set
			{
				this._after = value;
			}
		}
		public io.debezium.connector.postgresql.Source source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
		public string op
		{
			get
			{
				return this._op;
			}
			set
			{
				this._op = value;
			}
		}
		public System.Nullable<System.Int64> ts_ms
		{
			get
			{
				return this._ts_ms;
			}
			set
			{
				this._ts_ms = value;
			}
		}
		public @event.block transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				this._transaction = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.before;
			case 1: return this.after;
			case 2: return this.source;
			case 3: return this.op;
			case 4: return this.ts_ms;
			case 5: return this.transaction;
			default: throw new global::Avro.AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.before = (cdc.@public.customers.Value)fieldValue; break;
			case 1: this.after = (cdc.@public.customers.Value)fieldValue; break;
			case 2: this.source = (io.debezium.connector.postgresql.Source)fieldValue; break;
			case 3: this.op = (System.String)fieldValue; break;
			case 4: this.ts_ms = (System.Nullable<System.Int64>)fieldValue; break;
			case 5: this.transaction = (@event.block)fieldValue; break;
			default: throw new global::Avro.AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
