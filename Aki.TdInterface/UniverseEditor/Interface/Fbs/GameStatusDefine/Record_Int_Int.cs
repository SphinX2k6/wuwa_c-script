using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B7D RID: 19325
	public struct Record_Int_Int : IFlatbufferObject
	{
		// Token: 0x170088A2 RID: 34978
		// (get) Token: 0x0601D6D2 RID: 120530 RVA: 0x00421FDA File Offset: 0x004201DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D6D3 RID: 120531 RVA: 0x00421FE7 File Offset: 0x004201E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D6D4 RID: 120532 RVA: 0x00421FF0 File Offset: 0x004201F0
		public static Record_Int_Int GetRootAsRecord_Int_Int(ByteBuffer _bb)
		{
			return Record_Int_Int.GetRootAsRecord_Int_Int(_bb, default(Record_Int_Int));
		}

		// Token: 0x0601D6D5 RID: 120533 RVA: 0x0042200C File Offset: 0x0042020C
		public static Record_Int_Int GetRootAsRecord_Int_Int(ByteBuffer _bb, Record_Int_Int obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D6D6 RID: 120534 RVA: 0x00422029 File Offset: 0x00420229
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D6D7 RID: 120535 RVA: 0x00422038 File Offset: 0x00420238
		public Record_Int_Int __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088A3 RID: 34979
		// (get) Token: 0x0601D6D8 RID: 120536 RVA: 0x00422048 File Offset: 0x00420248
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

		// Token: 0x170088A4 RID: 34980
		// (get) Token: 0x0601D6D9 RID: 120537 RVA: 0x00422084 File Offset: 0x00420284
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

		// Token: 0x0601D6DA RID: 120538 RVA: 0x004220C0 File Offset: 0x004202C0
		public static Offset<Record_Int_Int> CreateRecord_Int_Int(FlatBufferBuilder builder, int Key = 0, int Value = 0)
		{
			builder.StartTable(2);
			Record_Int_Int.AddValue(builder, Value);
			Record_Int_Int.AddKey(builder, Key);
			return Record_Int_Int.EndRecord_Int_Int(builder);
		}

		// Token: 0x0601D6DB RID: 120539 RVA: 0x004220DD File Offset: 0x004202DD
		public static void StartRecord_Int_Int(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D6DC RID: 120540 RVA: 0x004220E6 File Offset: 0x004202E6
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601D6DD RID: 120541 RVA: 0x004220F1 File Offset: 0x004202F1
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(1, value, 0);
		}

		// Token: 0x0601D6DE RID: 120542 RVA: 0x004220FC File Offset: 0x004202FC
		public static Offset<Record_Int_Int> EndRecord_Int_Int(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_Int>(builder.EndTable());
		}

		// Token: 0x0601D6DF RID: 120543 RVA: 0x0042210C File Offset: 0x0042030C
		public Record_Int_IntT UnPack()
		{
			Record_Int_IntT record_Int_IntT = new Record_Int_IntT();
			this.UnPackTo(record_Int_IntT);
			return record_Int_IntT;
		}

		// Token: 0x0601D6E0 RID: 120544 RVA: 0x00422127 File Offset: 0x00420327
		public void UnPackTo(Record_Int_IntT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601D6E1 RID: 120545 RVA: 0x00422144 File Offset: 0x00420344
		public static Offset<Record_Int_Int> Pack(FlatBufferBuilder builder, Record_Int_IntT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_Int>);
			}
			return Record_Int_Int.CreateRecord_Int_Int(builder, _o.Key, _o.Value);
		}

		// Token: 0x0400D416 RID: 54294
		private Table __p;
	}
}
