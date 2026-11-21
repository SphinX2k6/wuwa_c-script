using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C7D RID: 27773
	public struct IDreamlessWarning : IFlatbufferObject
	{
		// Token: 0x1700CBB8 RID: 52152
		// (get) Token: 0x0602FD90 RID: 195984 RVA: 0x00684078 File Offset: 0x00682278
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD91 RID: 195985 RVA: 0x00684085 File Offset: 0x00682285
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD92 RID: 195986 RVA: 0x0068408C File Offset: 0x0068228C
		public static IDreamlessWarning GetRootAsIDreamlessWarning(ByteBuffer _bb)
		{
			return IDreamlessWarning.GetRootAsIDreamlessWarning(_bb, default(IDreamlessWarning));
		}

		// Token: 0x0602FD93 RID: 195987 RVA: 0x006840A8 File Offset: 0x006822A8
		public static IDreamlessWarning GetRootAsIDreamlessWarning(ByteBuffer _bb, IDreamlessWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD94 RID: 195988 RVA: 0x006840C5 File Offset: 0x006822C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD95 RID: 195989 RVA: 0x006840D4 File Offset: 0x006822D4
		public IDreamlessWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBB9 RID: 52153
		// (get) Token: 0x0602FD96 RID: 195990 RVA: 0x006840E4 File Offset: 0x006822E4
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBBA RID: 52154
		// (get) Token: 0x0602FD97 RID: 195991 RVA: 0x00684120 File Offset: 0x00682320
		public string WarningText
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FD98 RID: 195992 RVA: 0x00684157 File Offset: 0x00682357
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602FD99 RID: 195993 RVA: 0x00684166 File Offset: 0x00682366
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602FD9A RID: 195994 RVA: 0x00684174 File Offset: 0x00682374
		public static Offset<IDreamlessWarning> CreateIDreamlessWarning(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDreamlessWarning.AddWarningText(builder, WarningTextOffset);
			IDreamlessWarning.AddType(builder, Type);
			return IDreamlessWarning.EndIDreamlessWarning(builder);
		}

		// Token: 0x0602FD9B RID: 195995 RVA: 0x00684191 File Offset: 0x00682391
		public static void StartIDreamlessWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FD9C RID: 195996 RVA: 0x0068419A File Offset: 0x0068239A
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD9D RID: 195997 RVA: 0x006841A5 File Offset: 0x006823A5
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x0602FD9E RID: 195998 RVA: 0x006841B5 File Offset: 0x006823B5
		public static Offset<IDreamlessWarning> EndIDreamlessWarning(FlatBufferBuilder builder)
		{
			return new Offset<IDreamlessWarning>(builder.EndTable());
		}

		// Token: 0x0602FD9F RID: 195999 RVA: 0x006841C4 File Offset: 0x006823C4
		public IDreamlessWarningT UnPack()
		{
			IDreamlessWarningT dreamlessWarningT = new IDreamlessWarningT();
			this.UnPackTo(dreamlessWarningT);
			return dreamlessWarningT;
		}

		// Token: 0x0602FDA0 RID: 196000 RVA: 0x006841DF File Offset: 0x006823DF
		public void UnPackTo(IDreamlessWarningT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x0602FDA1 RID: 196001 RVA: 0x006841FC File Offset: 0x006823FC
		public static Offset<IDreamlessWarning> Pack(FlatBufferBuilder builder, IDreamlessWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDreamlessWarning>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return IDreamlessWarning.CreateIDreamlessWarning(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x04011AAD RID: 72365
		private Table __p;
	}
}
