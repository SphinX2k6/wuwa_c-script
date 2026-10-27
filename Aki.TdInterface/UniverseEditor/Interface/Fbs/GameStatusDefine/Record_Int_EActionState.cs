using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004712 RID: 18194
	public struct Record_Int_EActionState : IFlatbufferObject
	{
		// Token: 0x1700825C RID: 33372
		// (get) Token: 0x0601BEE7 RID: 114407 RVA: 0x003F5B3E File Offset: 0x003F3D3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BEE8 RID: 114408 RVA: 0x003F5B4B File Offset: 0x003F3D4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BEE9 RID: 114409 RVA: 0x003F5B54 File Offset: 0x003F3D54
		public static Record_Int_EActionState GetRootAsRecord_Int_EActionState(ByteBuffer _bb)
		{
			return Record_Int_EActionState.GetRootAsRecord_Int_EActionState(_bb, default(Record_Int_EActionState));
		}

		// Token: 0x0601BEEA RID: 114410 RVA: 0x003F5B70 File Offset: 0x003F3D70
		public static Record_Int_EActionState GetRootAsRecord_Int_EActionState(ByteBuffer _bb, Record_Int_EActionState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BEEB RID: 114411 RVA: 0x003F5B8D File Offset: 0x003F3D8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BEEC RID: 114412 RVA: 0x003F5B9C File Offset: 0x003F3D9C
		public Record_Int_EActionState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700825D RID: 33373
		// (get) Token: 0x0601BEED RID: 114413 RVA: 0x003F5BAC File Offset: 0x003F3DAC
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

		// Token: 0x1700825E RID: 33374
		// (get) Token: 0x0601BEEE RID: 114414 RVA: 0x003F5BE8 File Offset: 0x003F3DE8
		public EActionState Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EActionState.Inactive;
				}
				return (EActionState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BEEF RID: 114415 RVA: 0x003F5C24 File Offset: 0x003F3E24
		public static Offset<Record_Int_EActionState> CreateRecord_Int_EActionState(FlatBufferBuilder builder, int Key = 0, EActionState Value = EActionState.Inactive)
		{
			builder.StartTable(2);
			Record_Int_EActionState.AddKey(builder, Key);
			Record_Int_EActionState.AddValue(builder, Value);
			return Record_Int_EActionState.EndRecord_Int_EActionState(builder);
		}

		// Token: 0x0601BEF0 RID: 114416 RVA: 0x003F5C41 File Offset: 0x003F3E41
		public static void StartRecord_Int_EActionState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BEF1 RID: 114417 RVA: 0x003F5C4A File Offset: 0x003F3E4A
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601BEF2 RID: 114418 RVA: 0x003F5C55 File Offset: 0x003F3E55
		public static void AddValue(FlatBufferBuilder builder, EActionState value)
		{
			builder.AddByte(1, (byte)value, 0);
		}

		// Token: 0x0601BEF3 RID: 114419 RVA: 0x003F5C60 File Offset: 0x003F3E60
		public static Offset<Record_Int_EActionState> EndRecord_Int_EActionState(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_EActionState>(builder.EndTable());
		}

		// Token: 0x0601BEF4 RID: 114420 RVA: 0x003F5C70 File Offset: 0x003F3E70
		public Record_Int_EActionStateT UnPack()
		{
			Record_Int_EActionStateT record_Int_EActionStateT = new Record_Int_EActionStateT();
			this.UnPackTo(record_Int_EActionStateT);
			return record_Int_EActionStateT;
		}

		// Token: 0x0601BEF5 RID: 114421 RVA: 0x003F5C8B File Offset: 0x003F3E8B
		public void UnPackTo(Record_Int_EActionStateT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601BEF6 RID: 114422 RVA: 0x003F5CA8 File Offset: 0x003F3EA8
		public static Offset<Record_Int_EActionState> Pack(FlatBufferBuilder builder, Record_Int_EActionStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_EActionState>);
			}
			return Record_Int_EActionState.CreateRecord_Int_EActionState(builder, _o.Key, _o.Value);
		}

		// Token: 0x0400C9E4 RID: 51684
		private Table __p;
	}
}
