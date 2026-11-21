using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D39 RID: 19769
	public struct Record_Int_Int : IFlatbufferObject
	{
		// Token: 0x17008DA2 RID: 36258
		// (get) Token: 0x0601EA69 RID: 125545 RVA: 0x0044A21C File Offset: 0x0044841C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA6A RID: 125546 RVA: 0x0044A229 File Offset: 0x00448429
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA6B RID: 125547 RVA: 0x0044A230 File Offset: 0x00448430
		public static Record_Int_Int GetRootAsRecord_Int_Int(ByteBuffer _bb)
		{
			return Record_Int_Int.GetRootAsRecord_Int_Int(_bb, default(Record_Int_Int));
		}

		// Token: 0x0601EA6C RID: 125548 RVA: 0x0044A24C File Offset: 0x0044844C
		public static Record_Int_Int GetRootAsRecord_Int_Int(ByteBuffer _bb, Record_Int_Int obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA6D RID: 125549 RVA: 0x0044A269 File Offset: 0x00448469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA6E RID: 125550 RVA: 0x0044A278 File Offset: 0x00448478
		public Record_Int_Int __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DA3 RID: 36259
		// (get) Token: 0x0601EA6F RID: 125551 RVA: 0x0044A288 File Offset: 0x00448488
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

		// Token: 0x17008DA4 RID: 36260
		// (get) Token: 0x0601EA70 RID: 125552 RVA: 0x0044A2C4 File Offset: 0x004484C4
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

		// Token: 0x0601EA71 RID: 125553 RVA: 0x0044A300 File Offset: 0x00448500
		public static Offset<Record_Int_Int> CreateRecord_Int_Int(FlatBufferBuilder builder, int Key = 0, int Value = 0)
		{
			builder.StartTable(2);
			Record_Int_Int.AddValue(builder, Value);
			Record_Int_Int.AddKey(builder, Key);
			return Record_Int_Int.EndRecord_Int_Int(builder);
		}

		// Token: 0x0601EA72 RID: 125554 RVA: 0x0044A31D File Offset: 0x0044851D
		public static void StartRecord_Int_Int(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EA73 RID: 125555 RVA: 0x0044A326 File Offset: 0x00448526
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601EA74 RID: 125556 RVA: 0x0044A331 File Offset: 0x00448531
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(1, value, 0);
		}

		// Token: 0x0601EA75 RID: 125557 RVA: 0x0044A33C File Offset: 0x0044853C
		public static Offset<Record_Int_Int> EndRecord_Int_Int(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_Int>(builder.EndTable());
		}

		// Token: 0x0601EA76 RID: 125558 RVA: 0x0044A34C File Offset: 0x0044854C
		public Record_Int_IntT UnPack()
		{
			Record_Int_IntT record_Int_IntT = new Record_Int_IntT();
			this.UnPackTo(record_Int_IntT);
			return record_Int_IntT;
		}

		// Token: 0x0601EA77 RID: 125559 RVA: 0x0044A367 File Offset: 0x00448567
		public void UnPackTo(Record_Int_IntT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601EA78 RID: 125560 RVA: 0x0044A384 File Offset: 0x00448584
		public static Offset<Record_Int_Int> Pack(FlatBufferBuilder builder, Record_Int_IntT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_Int>);
			}
			return Record_Int_Int.CreateRecord_Int_Int(builder, _o.Key, _o.Value);
		}

		// Token: 0x0400D917 RID: 55575
		private Table __p;
	}
}
