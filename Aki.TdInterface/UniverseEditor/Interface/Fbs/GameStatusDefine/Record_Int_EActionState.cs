using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B7A RID: 19322
	public struct Record_Int_EActionState : IFlatbufferObject
	{
		// Token: 0x1700889D RID: 34973
		// (get) Token: 0x0601D6BC RID: 120508 RVA: 0x00421DDA File Offset: 0x0041FFDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D6BD RID: 120509 RVA: 0x00421DE7 File Offset: 0x0041FFE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D6BE RID: 120510 RVA: 0x00421DF0 File Offset: 0x0041FFF0
		public static Record_Int_EActionState GetRootAsRecord_Int_EActionState(ByteBuffer _bb)
		{
			return Record_Int_EActionState.GetRootAsRecord_Int_EActionState(_bb, default(Record_Int_EActionState));
		}

		// Token: 0x0601D6BF RID: 120511 RVA: 0x00421E0C File Offset: 0x0042000C
		public static Record_Int_EActionState GetRootAsRecord_Int_EActionState(ByteBuffer _bb, Record_Int_EActionState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D6C0 RID: 120512 RVA: 0x00421E29 File Offset: 0x00420029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D6C1 RID: 120513 RVA: 0x00421E38 File Offset: 0x00420038
		public Record_Int_EActionState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700889E RID: 34974
		// (get) Token: 0x0601D6C2 RID: 120514 RVA: 0x00421E48 File Offset: 0x00420048
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

		// Token: 0x1700889F RID: 34975
		// (get) Token: 0x0601D6C3 RID: 120515 RVA: 0x00421E84 File Offset: 0x00420084
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

		// Token: 0x0601D6C4 RID: 120516 RVA: 0x00421EC0 File Offset: 0x004200C0
		public static Offset<Record_Int_EActionState> CreateRecord_Int_EActionState(FlatBufferBuilder builder, int Key = 0, EActionState Value = EActionState.Inactive)
		{
			builder.StartTable(2);
			Record_Int_EActionState.AddKey(builder, Key);
			Record_Int_EActionState.AddValue(builder, Value);
			return Record_Int_EActionState.EndRecord_Int_EActionState(builder);
		}

		// Token: 0x0601D6C5 RID: 120517 RVA: 0x00421EDD File Offset: 0x004200DD
		public static void StartRecord_Int_EActionState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D6C6 RID: 120518 RVA: 0x00421EE6 File Offset: 0x004200E6
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601D6C7 RID: 120519 RVA: 0x00421EF1 File Offset: 0x004200F1
		public static void AddValue(FlatBufferBuilder builder, EActionState value)
		{
			builder.AddByte(1, (byte)value, 0);
		}

		// Token: 0x0601D6C8 RID: 120520 RVA: 0x00421EFC File Offset: 0x004200FC
		public static Offset<Record_Int_EActionState> EndRecord_Int_EActionState(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_EActionState>(builder.EndTable());
		}

		// Token: 0x0601D6C9 RID: 120521 RVA: 0x00421F0C File Offset: 0x0042010C
		public Record_Int_EActionStateT UnPack()
		{
			Record_Int_EActionStateT record_Int_EActionStateT = new Record_Int_EActionStateT();
			this.UnPackTo(record_Int_EActionStateT);
			return record_Int_EActionStateT;
		}

		// Token: 0x0601D6CA RID: 120522 RVA: 0x00421F27 File Offset: 0x00420127
		public void UnPackTo(Record_Int_EActionStateT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601D6CB RID: 120523 RVA: 0x00421F44 File Offset: 0x00420144
		public static Offset<Record_Int_EActionState> Pack(FlatBufferBuilder builder, Record_Int_EActionStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_EActionState>);
			}
			return Record_Int_EActionState.CreateRecord_Int_EActionState(builder, _o.Key, _o.Value);
		}

		// Token: 0x0400D413 RID: 54291
		private Table __p;
	}
}
