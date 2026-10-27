using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061DC RID: 25052
	public struct IBadBuKingChallengeTip : IFlatbufferObject
	{
		// Token: 0x1700BACA RID: 47818
		// (get) Token: 0x0602B2DB RID: 176859 RVA: 0x005F3998 File Offset: 0x005F1B98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B2DC RID: 176860 RVA: 0x005F39A5 File Offset: 0x005F1BA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B2DD RID: 176861 RVA: 0x005F39AC File Offset: 0x005F1BAC
		public static IBadBuKingChallengeTip GetRootAsIBadBuKingChallengeTip(ByteBuffer _bb)
		{
			return IBadBuKingChallengeTip.GetRootAsIBadBuKingChallengeTip(_bb, default(IBadBuKingChallengeTip));
		}

		// Token: 0x0602B2DE RID: 176862 RVA: 0x005F39C8 File Offset: 0x005F1BC8
		public static IBadBuKingChallengeTip GetRootAsIBadBuKingChallengeTip(ByteBuffer _bb, IBadBuKingChallengeTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B2DF RID: 176863 RVA: 0x005F39E5 File Offset: 0x005F1BE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B2E0 RID: 176864 RVA: 0x005F39F4 File Offset: 0x005F1BF4
		public IBadBuKingChallengeTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BACB RID: 47819
		// (get) Token: 0x0602B2E1 RID: 176865 RVA: 0x005F3A04 File Offset: 0x005F1C04
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

		// Token: 0x1700BACC RID: 47820
		// (get) Token: 0x0602B2E2 RID: 176866 RVA: 0x005F3A40 File Offset: 0x005F1C40
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

		// Token: 0x0602B2E3 RID: 176867 RVA: 0x005F3A77 File Offset: 0x005F1C77
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B2E4 RID: 176868 RVA: 0x005F3A86 File Offset: 0x005F1C86
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602B2E5 RID: 176869 RVA: 0x005F3A94 File Offset: 0x005F1C94
		public static Offset<IBadBuKingChallengeTip> CreateIBadBuKingChallengeTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IBadBuKingChallengeTip.AddWarningText(builder, WarningTextOffset);
			IBadBuKingChallengeTip.AddType(builder, Type);
			return IBadBuKingChallengeTip.EndIBadBuKingChallengeTip(builder);
		}

		// Token: 0x0602B2E6 RID: 176870 RVA: 0x005F3AB1 File Offset: 0x005F1CB1
		public static void StartIBadBuKingChallengeTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B2E7 RID: 176871 RVA: 0x005F3ABA File Offset: 0x005F1CBA
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B2E8 RID: 176872 RVA: 0x005F3AC5 File Offset: 0x005F1CC5
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x0602B2E9 RID: 176873 RVA: 0x005F3AD5 File Offset: 0x005F1CD5
		public static Offset<IBadBuKingChallengeTip> EndIBadBuKingChallengeTip(FlatBufferBuilder builder)
		{
			return new Offset<IBadBuKingChallengeTip>(builder.EndTable());
		}

		// Token: 0x0602B2EA RID: 176874 RVA: 0x005F3AE4 File Offset: 0x005F1CE4
		public IBadBuKingChallengeTipT UnPack()
		{
			IBadBuKingChallengeTipT badBuKingChallengeTipT = new IBadBuKingChallengeTipT();
			this.UnPackTo(badBuKingChallengeTipT);
			return badBuKingChallengeTipT;
		}

		// Token: 0x0602B2EB RID: 176875 RVA: 0x005F3AFF File Offset: 0x005F1CFF
		public void UnPackTo(IBadBuKingChallengeTipT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x0602B2EC RID: 176876 RVA: 0x005F3B1C File Offset: 0x005F1D1C
		public static Offset<IBadBuKingChallengeTip> Pack(FlatBufferBuilder builder, IBadBuKingChallengeTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBadBuKingChallengeTip>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return IBadBuKingChallengeTip.CreateIBadBuKingChallengeTip(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x04010708 RID: 67336
		private Table __p;
	}
}
