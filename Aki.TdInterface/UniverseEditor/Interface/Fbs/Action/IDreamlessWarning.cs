using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200660C RID: 26124
	public struct IDreamlessWarning : IFlatbufferObject
	{
		// Token: 0x1700C21A RID: 49690
		// (get) Token: 0x0602D5BF RID: 185791 RVA: 0x00637510 File Offset: 0x00635710
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D5C0 RID: 185792 RVA: 0x0063751D File Offset: 0x0063571D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D5C1 RID: 185793 RVA: 0x00637524 File Offset: 0x00635724
		public static IDreamlessWarning GetRootAsIDreamlessWarning(ByteBuffer _bb)
		{
			return IDreamlessWarning.GetRootAsIDreamlessWarning(_bb, default(IDreamlessWarning));
		}

		// Token: 0x0602D5C2 RID: 185794 RVA: 0x00637540 File Offset: 0x00635740
		public static IDreamlessWarning GetRootAsIDreamlessWarning(ByteBuffer _bb, IDreamlessWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D5C3 RID: 185795 RVA: 0x0063755D File Offset: 0x0063575D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D5C4 RID: 185796 RVA: 0x0063756C File Offset: 0x0063576C
		public IDreamlessWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C21B RID: 49691
		// (get) Token: 0x0602D5C5 RID: 185797 RVA: 0x0063757C File Offset: 0x0063577C
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

		// Token: 0x1700C21C RID: 49692
		// (get) Token: 0x0602D5C6 RID: 185798 RVA: 0x006375B8 File Offset: 0x006357B8
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

		// Token: 0x0602D5C7 RID: 185799 RVA: 0x006375EF File Offset: 0x006357EF
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602D5C8 RID: 185800 RVA: 0x006375FE File Offset: 0x006357FE
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602D5C9 RID: 185801 RVA: 0x0063760C File Offset: 0x0063580C
		public static Offset<IDreamlessWarning> CreateIDreamlessWarning(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDreamlessWarning.AddWarningText(builder, WarningTextOffset);
			IDreamlessWarning.AddType(builder, Type);
			return IDreamlessWarning.EndIDreamlessWarning(builder);
		}

		// Token: 0x0602D5CA RID: 185802 RVA: 0x00637629 File Offset: 0x00635829
		public static void StartIDreamlessWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D5CB RID: 185803 RVA: 0x00637632 File Offset: 0x00635832
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D5CC RID: 185804 RVA: 0x0063763D File Offset: 0x0063583D
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x0602D5CD RID: 185805 RVA: 0x0063764D File Offset: 0x0063584D
		public static Offset<IDreamlessWarning> EndIDreamlessWarning(FlatBufferBuilder builder)
		{
			return new Offset<IDreamlessWarning>(builder.EndTable());
		}

		// Token: 0x0602D5CE RID: 185806 RVA: 0x0063765C File Offset: 0x0063585C
		public IDreamlessWarningT UnPack()
		{
			IDreamlessWarningT dreamlessWarningT = new IDreamlessWarningT();
			this.UnPackTo(dreamlessWarningT);
			return dreamlessWarningT;
		}

		// Token: 0x0602D5CF RID: 185807 RVA: 0x00637677 File Offset: 0x00635877
		public void UnPackTo(IDreamlessWarningT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x0602D5D0 RID: 185808 RVA: 0x00637694 File Offset: 0x00635894
		public static Offset<IDreamlessWarning> Pack(FlatBufferBuilder builder, IDreamlessWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDreamlessWarning>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return IDreamlessWarning.CreateIDreamlessWarning(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x04010C92 RID: 68754
		private Table __p;
	}
}
