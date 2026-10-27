using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048D4 RID: 18644
	public struct Record_Int_Int : IFlatbufferObject
	{
		// Token: 0x1700875A RID: 34650
		// (get) Token: 0x0601D27C RID: 119420 RVA: 0x0041DA80 File Offset: 0x0041BC80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D27D RID: 119421 RVA: 0x0041DA8D File Offset: 0x0041BC8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D27E RID: 119422 RVA: 0x0041DA94 File Offset: 0x0041BC94
		public static Record_Int_Int GetRootAsRecord_Int_Int(ByteBuffer _bb)
		{
			return Record_Int_Int.GetRootAsRecord_Int_Int(_bb, default(Record_Int_Int));
		}

		// Token: 0x0601D27F RID: 119423 RVA: 0x0041DAB0 File Offset: 0x0041BCB0
		public static Record_Int_Int GetRootAsRecord_Int_Int(ByteBuffer _bb, Record_Int_Int obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D280 RID: 119424 RVA: 0x0041DACD File Offset: 0x0041BCCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D281 RID: 119425 RVA: 0x0041DADC File Offset: 0x0041BCDC
		public Record_Int_Int __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700875B RID: 34651
		// (get) Token: 0x0601D282 RID: 119426 RVA: 0x0041DAEC File Offset: 0x0041BCEC
		public int Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700875C RID: 34652
		// (get) Token: 0x0601D283 RID: 119427 RVA: 0x0041DB28 File Offset: 0x0041BD28
		public int Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D284 RID: 119428 RVA: 0x0041DB64 File Offset: 0x0041BD64
		public static Offset<Record_Int_Int> CreateRecord_Int_Int(FlatBufferBuilder builder, int Key = 0, int Value = 0)
		{
			builder.StartTable(2);
			Record_Int_Int.AddValue(builder, Value);
			Record_Int_Int.AddKey(builder, Key);
			return Record_Int_Int.EndRecord_Int_Int(builder);
		}

		// Token: 0x0601D285 RID: 119429 RVA: 0x0041DB81 File Offset: 0x0041BD81
		public static void StartRecord_Int_Int(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D286 RID: 119430 RVA: 0x0041DB8A File Offset: 0x0041BD8A
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601D287 RID: 119431 RVA: 0x0041DB95 File Offset: 0x0041BD95
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(1, value, 0);
		}

		// Token: 0x0601D288 RID: 119432 RVA: 0x0041DBA0 File Offset: 0x0041BDA0
		public static Offset<Record_Int_Int> EndRecord_Int_Int(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_Int>(builder.EndTable());
		}

		// Token: 0x0601D289 RID: 119433 RVA: 0x0041DBB0 File Offset: 0x0041BDB0
		public Record_Int_IntT UnPack()
		{
			Record_Int_IntT record_Int_IntT = new Record_Int_IntT();
			this.UnPackTo(record_Int_IntT);
			return record_Int_IntT;
		}

		// Token: 0x0601D28A RID: 119434 RVA: 0x0041DBCB File Offset: 0x0041BDCB
		public void UnPackTo(Record_Int_IntT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601D28B RID: 119435 RVA: 0x0041DBE8 File Offset: 0x0041BDE8
		public static Offset<Record_Int_Int> Pack(FlatBufferBuilder builder, Record_Int_IntT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_Int>);
			}
			return Record_Int_Int.CreateRecord_Int_Int(builder, _o.Key, _o.Value);
		}

		// Token: 0x0400CEDE RID: 52958
		private Table __p;
	}
}
