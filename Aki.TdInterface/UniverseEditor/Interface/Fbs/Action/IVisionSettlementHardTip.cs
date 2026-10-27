using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200754A RID: 30026
	public struct IVisionSettlementHardTip : IFlatbufferObject
	{
		// Token: 0x1700E3CE RID: 58318
		// (get) Token: 0x06036A0A RID: 223754 RVA: 0x0076BBBE File Offset: 0x00769DBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A0B RID: 223755 RVA: 0x0076BBCB File Offset: 0x00769DCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A0C RID: 223756 RVA: 0x0076BBD4 File Offset: 0x00769DD4
		public static IVisionSettlementHardTip GetRootAsIVisionSettlementHardTip(ByteBuffer _bb)
		{
			return IVisionSettlementHardTip.GetRootAsIVisionSettlementHardTip(_bb, default(IVisionSettlementHardTip));
		}

		// Token: 0x06036A0D RID: 223757 RVA: 0x0076BBF0 File Offset: 0x00769DF0
		public static IVisionSettlementHardTip GetRootAsIVisionSettlementHardTip(ByteBuffer _bb, IVisionSettlementHardTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A0E RID: 223758 RVA: 0x0076BC0D File Offset: 0x00769E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A0F RID: 223759 RVA: 0x0076BC1C File Offset: 0x00769E1C
		public IVisionSettlementHardTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3CF RID: 58319
		// (get) Token: 0x06036A10 RID: 223760 RVA: 0x0076BC2C File Offset: 0x00769E2C
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

		// Token: 0x1700E3D0 RID: 58320
		// (get) Token: 0x06036A11 RID: 223761 RVA: 0x0076BC68 File Offset: 0x00769E68
		public string TidMainText
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

		// Token: 0x06036A12 RID: 223762 RVA: 0x0076BC9F File Offset: 0x00769E9F
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036A13 RID: 223763 RVA: 0x0076BCAE File Offset: 0x00769EAE
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E3D1 RID: 58321
		// (get) Token: 0x06036A14 RID: 223764 RVA: 0x0076BCBC File Offset: 0x00769EBC
		public string TidSubText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036A15 RID: 223765 RVA: 0x0076BCF3 File Offset: 0x00769EF3
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06036A16 RID: 223766 RVA: 0x0076BD02 File Offset: 0x00769F02
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06036A17 RID: 223767 RVA: 0x0076BD10 File Offset: 0x00769F10
		public static Offset<IVisionSettlementHardTip> CreateIVisionSettlementHardTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IVisionSettlementHardTip.AddTidSubText(builder, TidSubTextOffset);
			IVisionSettlementHardTip.AddTidMainText(builder, TidMainTextOffset);
			IVisionSettlementHardTip.AddType(builder, Type);
			return IVisionSettlementHardTip.EndIVisionSettlementHardTip(builder);
		}

		// Token: 0x06036A18 RID: 223768 RVA: 0x0076BD34 File Offset: 0x00769F34
		public static void StartIVisionSettlementHardTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036A19 RID: 223769 RVA: 0x0076BD3D File Offset: 0x00769F3D
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036A1A RID: 223770 RVA: 0x0076BD48 File Offset: 0x00769F48
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06036A1B RID: 223771 RVA: 0x0076BD58 File Offset: 0x00769F58
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x06036A1C RID: 223772 RVA: 0x0076BD68 File Offset: 0x00769F68
		public static Offset<IVisionSettlementHardTip> EndIVisionSettlementHardTip(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSettlementHardTip>(builder.EndTable());
		}

		// Token: 0x06036A1D RID: 223773 RVA: 0x0076BD78 File Offset: 0x00769F78
		public IVisionSettlementHardTipT UnPack()
		{
			IVisionSettlementHardTipT visionSettlementHardTipT = new IVisionSettlementHardTipT();
			this.UnPackTo(visionSettlementHardTipT);
			return visionSettlementHardTipT;
		}

		// Token: 0x06036A1E RID: 223774 RVA: 0x0076BD93 File Offset: 0x00769F93
		public void UnPackTo(IVisionSettlementHardTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x06036A1F RID: 223775 RVA: 0x0076BDBC File Offset: 0x00769FBC
		public static Offset<IVisionSettlementHardTip> Pack(FlatBufferBuilder builder, IVisionSettlementHardTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSettlementHardTip>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return IVisionSettlementHardTip.CreateIVisionSettlementHardTip(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x04012440 RID: 74816
		private Table __p;
	}
}
