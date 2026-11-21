using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200684A RID: 26698
	public struct IBadBuKingChallengeTip : IFlatbufferObject
	{
		// Token: 0x1700C44D RID: 50253
		// (get) Token: 0x0602DA22 RID: 186914 RVA: 0x0063E40C File Offset: 0x0063C60C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA23 RID: 186915 RVA: 0x0063E419 File Offset: 0x0063C619
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA24 RID: 186916 RVA: 0x0063E420 File Offset: 0x0063C620
		public static IBadBuKingChallengeTip GetRootAsIBadBuKingChallengeTip(ByteBuffer _bb)
		{
			return IBadBuKingChallengeTip.GetRootAsIBadBuKingChallengeTip(_bb, default(IBadBuKingChallengeTip));
		}

		// Token: 0x0602DA25 RID: 186917 RVA: 0x0063E43C File Offset: 0x0063C63C
		public static IBadBuKingChallengeTip GetRootAsIBadBuKingChallengeTip(ByteBuffer _bb, IBadBuKingChallengeTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA26 RID: 186918 RVA: 0x0063E459 File Offset: 0x0063C659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA27 RID: 186919 RVA: 0x0063E468 File Offset: 0x0063C668
		public IBadBuKingChallengeTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C44E RID: 50254
		// (get) Token: 0x0602DA28 RID: 186920 RVA: 0x0063E478 File Offset: 0x0063C678
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

		// Token: 0x1700C44F RID: 50255
		// (get) Token: 0x0602DA29 RID: 186921 RVA: 0x0063E4B4 File Offset: 0x0063C6B4
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

		// Token: 0x0602DA2A RID: 186922 RVA: 0x0063E4EB File Offset: 0x0063C6EB
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602DA2B RID: 186923 RVA: 0x0063E4FA File Offset: 0x0063C6FA
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602DA2C RID: 186924 RVA: 0x0063E508 File Offset: 0x0063C708
		public static Offset<IBadBuKingChallengeTip> CreateIBadBuKingChallengeTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IBadBuKingChallengeTip.AddWarningText(builder, WarningTextOffset);
			IBadBuKingChallengeTip.AddType(builder, Type);
			return IBadBuKingChallengeTip.EndIBadBuKingChallengeTip(builder);
		}

		// Token: 0x0602DA2D RID: 186925 RVA: 0x0063E525 File Offset: 0x0063C725
		public static void StartIBadBuKingChallengeTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DA2E RID: 186926 RVA: 0x0063E52E File Offset: 0x0063C72E
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DA2F RID: 186927 RVA: 0x0063E539 File Offset: 0x0063C739
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x0602DA30 RID: 186928 RVA: 0x0063E549 File Offset: 0x0063C749
		public static Offset<IBadBuKingChallengeTip> EndIBadBuKingChallengeTip(FlatBufferBuilder builder)
		{
			return new Offset<IBadBuKingChallengeTip>(builder.EndTable());
		}

		// Token: 0x0602DA31 RID: 186929 RVA: 0x0063E558 File Offset: 0x0063C758
		public IBadBuKingChallengeTipT UnPack()
		{
			IBadBuKingChallengeTipT badBuKingChallengeTipT = new IBadBuKingChallengeTipT();
			this.UnPackTo(badBuKingChallengeTipT);
			return badBuKingChallengeTipT;
		}

		// Token: 0x0602DA32 RID: 186930 RVA: 0x0063E573 File Offset: 0x0063C773
		public void UnPackTo(IBadBuKingChallengeTipT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x0602DA33 RID: 186931 RVA: 0x0063E590 File Offset: 0x0063C790
		public static Offset<IBadBuKingChallengeTip> Pack(FlatBufferBuilder builder, IBadBuKingChallengeTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBadBuKingChallengeTip>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return IBadBuKingChallengeTip.CreateIBadBuKingChallengeTip(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x0401151A RID: 70938
		private Table __p;
	}
}
