using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004715 RID: 18197
	public struct Record_Int_Int : IFlatbufferObject
	{
		// Token: 0x17008261 RID: 33377
		// (get) Token: 0x0601BEFD RID: 114429 RVA: 0x003F5D3E File Offset: 0x003F3F3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BEFE RID: 114430 RVA: 0x003F5D4B File Offset: 0x003F3F4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BEFF RID: 114431 RVA: 0x003F5D54 File Offset: 0x003F3F54
		public static Record_Int_Int GetRootAsRecord_Int_Int(ByteBuffer _bb)
		{
			return Record_Int_Int.GetRootAsRecord_Int_Int(_bb, default(Record_Int_Int));
		}

		// Token: 0x0601BF00 RID: 114432 RVA: 0x003F5D70 File Offset: 0x003F3F70
		public static Record_Int_Int GetRootAsRecord_Int_Int(ByteBuffer _bb, Record_Int_Int obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BF01 RID: 114433 RVA: 0x003F5D8D File Offset: 0x003F3F8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BF02 RID: 114434 RVA: 0x003F5D9C File Offset: 0x003F3F9C
		public Record_Int_Int __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008262 RID: 33378
		// (get) Token: 0x0601BF03 RID: 114435 RVA: 0x003F5DAC File Offset: 0x003F3FAC
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

		// Token: 0x17008263 RID: 33379
		// (get) Token: 0x0601BF04 RID: 114436 RVA: 0x003F5DE8 File Offset: 0x003F3FE8
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

		// Token: 0x0601BF05 RID: 114437 RVA: 0x003F5E24 File Offset: 0x003F4024
		public static Offset<Record_Int_Int> CreateRecord_Int_Int(FlatBufferBuilder builder, int Key = 0, int Value = 0)
		{
			builder.StartTable(2);
			Record_Int_Int.AddValue(builder, Value);
			Record_Int_Int.AddKey(builder, Key);
			return Record_Int_Int.EndRecord_Int_Int(builder);
		}

		// Token: 0x0601BF06 RID: 114438 RVA: 0x003F5E41 File Offset: 0x003F4041
		public static void StartRecord_Int_Int(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BF07 RID: 114439 RVA: 0x003F5E4A File Offset: 0x003F404A
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601BF08 RID: 114440 RVA: 0x003F5E55 File Offset: 0x003F4055
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(1, value, 0);
		}

		// Token: 0x0601BF09 RID: 114441 RVA: 0x003F5E60 File Offset: 0x003F4060
		public static Offset<Record_Int_Int> EndRecord_Int_Int(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_Int>(builder.EndTable());
		}

		// Token: 0x0601BF0A RID: 114442 RVA: 0x003F5E70 File Offset: 0x003F4070
		public Record_Int_IntT UnPack()
		{
			Record_Int_IntT record_Int_IntT = new Record_Int_IntT();
			this.UnPackTo(record_Int_IntT);
			return record_Int_IntT;
		}

		// Token: 0x0601BF0B RID: 114443 RVA: 0x003F5E8B File Offset: 0x003F408B
		public void UnPackTo(Record_Int_IntT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601BF0C RID: 114444 RVA: 0x003F5EA8 File Offset: 0x003F40A8
		public static Offset<Record_Int_Int> Pack(FlatBufferBuilder builder, Record_Int_IntT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_Int>);
			}
			return Record_Int_Int.CreateRecord_Int_Int(builder, _o.Key, _o.Value);
		}

		// Token: 0x0400C9E7 RID: 51687
		private Table __p;
	}
}
