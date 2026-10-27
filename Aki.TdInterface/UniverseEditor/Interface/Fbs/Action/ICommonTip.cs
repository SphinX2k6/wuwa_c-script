using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200647D RID: 25725
	public struct ICommonTip : IFlatbufferObject
	{
		// Token: 0x1700BF6F RID: 49007
		// (get) Token: 0x0602C916 RID: 182550 RVA: 0x0061EA12 File Offset: 0x0061CC12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C917 RID: 182551 RVA: 0x0061EA1F File Offset: 0x0061CC1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C918 RID: 182552 RVA: 0x0061EA28 File Offset: 0x0061CC28
		public static ICommonTip GetRootAsICommonTip(ByteBuffer _bb)
		{
			return ICommonTip.GetRootAsICommonTip(_bb, default(ICommonTip));
		}

		// Token: 0x0602C919 RID: 182553 RVA: 0x0061EA44 File Offset: 0x0061CC44
		public static ICommonTip GetRootAsICommonTip(ByteBuffer _bb, ICommonTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C91A RID: 182554 RVA: 0x0061EA61 File Offset: 0x0061CC61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C91B RID: 182555 RVA: 0x0061EA70 File Offset: 0x0061CC70
		public ICommonTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF70 RID: 49008
		// (get) Token: 0x0602C91C RID: 182556 RVA: 0x0061EA80 File Offset: 0x0061CC80
		public TCommonTipOption TipOptionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TCommonTipOption.NONE;
				}
				return (TCommonTipOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C91D RID: 182557 RVA: 0x0061EABC File Offset: 0x0061CCBC
		public TTable? TipOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C91E RID: 182558 RVA: 0x0061EB00 File Offset: 0x0061CD00
		public IBadBuKingChallengeTip TipOptionAsIBadBuKingChallengeTip()
		{
			return this.TipOption<IBadBuKingChallengeTip>().Value;
		}

		// Token: 0x0602C91F RID: 182559 RVA: 0x0061EB1C File Offset: 0x0061CD1C
		public IBlackCatWarning TipOptionAsIBlackCatWarning()
		{
			return this.TipOption<IBlackCatWarning>().Value;
		}

		// Token: 0x0602C920 RID: 182560 RVA: 0x0061EB38 File Offset: 0x0061CD38
		public ICommonTipChallengeCondition TipOptionAsICommonTipChallengeCondition()
		{
			return this.TipOption<ICommonTipChallengeCondition>().Value;
		}

		// Token: 0x0602C921 RID: 182561 RVA: 0x0061EB54 File Offset: 0x0061CD54
		public ICommonTipChallengeFail TipOptionAsICommonTipChallengeFail()
		{
			return this.TipOption<ICommonTipChallengeFail>().Value;
		}

		// Token: 0x0602C922 RID: 182562 RVA: 0x0061EB70 File Offset: 0x0061CD70
		public ICommonTipChallengeSuccess TipOptionAsICommonTipChallengeSuccess()
		{
			return this.TipOption<ICommonTipChallengeSuccess>().Value;
		}

		// Token: 0x0602C923 RID: 182563 RVA: 0x0061EB8C File Offset: 0x0061CD8C
		public ICommonTipEnterInRange TipOptionAsICommonTipEnterInRange()
		{
			return this.TipOption<ICommonTipEnterInRange>().Value;
		}

		// Token: 0x0602C924 RID: 182564 RVA: 0x0061EBA8 File Offset: 0x0061CDA8
		public ICommonTipFirstComplete TipOptionAsICommonTipFirstComplete()
		{
			return this.TipOption<ICommonTipFirstComplete>().Value;
		}

		// Token: 0x0602C925 RID: 182565 RVA: 0x0061EBC4 File Offset: 0x0061CDC4
		public ICommonTipGeneralFloatingTip TipOptionAsICommonTipGeneralFloatingTip()
		{
			return this.TipOption<ICommonTipGeneralFloatingTip>().Value;
		}

		// Token: 0x0602C926 RID: 182566 RVA: 0x0061EBE0 File Offset: 0x0061CDE0
		public ICommonTipId TipOptionAsICommonTipId()
		{
			return this.TipOption<ICommonTipId>().Value;
		}

		// Token: 0x0602C927 RID: 182567 RVA: 0x0061EBFC File Offset: 0x0061CDFC
		public ICommonTipMissionComplete TipOptionAsICommonTipMissionComplete()
		{
			return this.TipOption<ICommonTipMissionComplete>().Value;
		}

		// Token: 0x0602C928 RID: 182568 RVA: 0x0061EC18 File Offset: 0x0061CE18
		public ICommonTipMissionCompleteNew TipOptionAsICommonTipMissionCompleteNew()
		{
			return this.TipOption<ICommonTipMissionCompleteNew>().Value;
		}

		// Token: 0x0602C929 RID: 182569 RVA: 0x0061EC34 File Offset: 0x0061CE34
		public ICommonTipPrepareCountdown TipOptionAsICommonTipPrepareCountdown()
		{
			return this.TipOption<ICommonTipPrepareCountdown>().Value;
		}

		// Token: 0x0602C92A RID: 182570 RVA: 0x0061EC50 File Offset: 0x0061CE50
		public ICommonTipReachChallenge TipOptionAsICommonTipReachChallenge()
		{
			return this.TipOption<ICommonTipReachChallenge>().Value;
		}

		// Token: 0x0602C92B RID: 182571 RVA: 0x0061EC6C File Offset: 0x0061CE6C
		public ICommonTipTriggerDelegation TipOptionAsICommonTipTriggerDelegation()
		{
			return this.TipOption<ICommonTipTriggerDelegation>().Value;
		}

		// Token: 0x0602C92C RID: 182572 RVA: 0x0061EC88 File Offset: 0x0061CE88
		public IDreamlessWarning TipOptionAsIDreamlessWarning()
		{
			return this.TipOption<IDreamlessWarning>().Value;
		}

		// Token: 0x0602C92D RID: 182573 RVA: 0x0061ECA4 File Offset: 0x0061CEA4
		public IFlipperTip TipOptionAsIFlipperTip()
		{
			return this.TipOption<IFlipperTip>().Value;
		}

		// Token: 0x0602C92E RID: 182574 RVA: 0x0061ECC0 File Offset: 0x0061CEC0
		public IGreatSwordChallenge TipOptionAsIGreatSwordChallenge()
		{
			return this.TipOption<IGreatSwordChallenge>().Value;
		}

		// Token: 0x0602C92F RID: 182575 RVA: 0x0061ECDC File Offset: 0x0061CEDC
		public IMoraleAreaTip TipOptionAsIMoraleAreaTip()
		{
			return this.TipOption<IMoraleAreaTip>().Value;
		}

		// Token: 0x0602C930 RID: 182576 RVA: 0x0061ECF8 File Offset: 0x0061CEF8
		public INightmareLordTip TipOptionAsINightmareLordTip()
		{
			return this.TipOption<INightmareLordTip>().Value;
		}

		// Token: 0x0602C931 RID: 182577 RVA: 0x0061ED14 File Offset: 0x0061CF14
		public INightmareSpawnPointTip TipOptionAsINightmareSpawnPointTip()
		{
			return this.TipOption<INightmareSpawnPointTip>().Value;
		}

		// Token: 0x0602C932 RID: 182578 RVA: 0x0061ED30 File Offset: 0x0061CF30
		public IPhotographicTip TipOptionAsIPhotographicTip()
		{
			return this.TipOption<IPhotographicTip>().Value;
		}

		// Token: 0x0602C933 RID: 182579 RVA: 0x0061ED4C File Offset: 0x0061CF4C
		public IPunishReport TipOptionAsIPunishReport()
		{
			return this.TipOption<IPunishReport>().Value;
		}

		// Token: 0x0602C934 RID: 182580 RVA: 0x0061ED68 File Offset: 0x0061CF68
		public IRemainStarWarning TipOptionAsIRemainStarWarning()
		{
			return this.TipOption<IRemainStarWarning>().Value;
		}

		// Token: 0x0602C935 RID: 182581 RVA: 0x0061ED84 File Offset: 0x0061CF84
		public ISheriffCashSettlement TipOptionAsISheriffCashSettlement()
		{
			return this.TipOption<ISheriffCashSettlement>().Value;
		}

		// Token: 0x0602C936 RID: 182582 RVA: 0x0061EDA0 File Offset: 0x0061CFA0
		public ISheriffCriminalArrested TipOptionAsISheriffCriminalArrested()
		{
			return this.TipOption<ISheriffCriminalArrested>().Value;
		}

		// Token: 0x0602C937 RID: 182583 RVA: 0x0061EDBC File Offset: 0x0061CFBC
		public ISheriffStartTrack TipOptionAsISheriffStartTrack()
		{
			return this.TipOption<ISheriffStartTrack>().Value;
		}

		// Token: 0x0602C938 RID: 182584 RVA: 0x0061EDD8 File Offset: 0x0061CFD8
		public ISlashAndTowerTip TipOptionAsISlashAndTowerTip()
		{
			return this.TipOption<ISlashAndTowerTip>().Value;
		}

		// Token: 0x0602C939 RID: 182585 RVA: 0x0061EDF4 File Offset: 0x0061CFF4
		public ISwordIntentTip TipOptionAsISwordIntentTip()
		{
			return this.TipOption<ISwordIntentTip>().Value;
		}

		// Token: 0x0602C93A RID: 182586 RVA: 0x0061EE10 File Offset: 0x0061D010
		public ITrapDefenseTip TipOptionAsITrapDefenseTip()
		{
			return this.TipOption<ITrapDefenseTip>().Value;
		}

		// Token: 0x0602C93B RID: 182587 RVA: 0x0061EE2C File Offset: 0x0061D02C
		public IVisionSettlementHardTip TipOptionAsIVisionSettlementHardTip()
		{
			return this.TipOption<IVisionSettlementHardTip>().Value;
		}

		// Token: 0x0602C93C RID: 182588 RVA: 0x0061EE48 File Offset: 0x0061D048
		public IVisionSettlementTip TipOptionAsIVisionSettlementTip()
		{
			return this.TipOption<IVisionSettlementTip>().Value;
		}

		// Token: 0x0602C93D RID: 182589 RVA: 0x0061EE64 File Offset: 0x0061D064
		public IWhiteCatWarning TipOptionAsIWhiteCatWarning()
		{
			return this.TipOption<IWhiteCatWarning>().Value;
		}

		// Token: 0x1700BF71 RID: 49009
		// (get) Token: 0x0602C93E RID: 182590 RVA: 0x0061EE80 File Offset: 0x0061D080
		public int Duration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF72 RID: 49010
		// (get) Token: 0x0602C93F RID: 182591 RVA: 0x0061EEBC File Offset: 0x0061D0BC
		public string Token
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C940 RID: 182592 RVA: 0x0061EEF4 File Offset: 0x0061D0F4
		public Span<byte> GetTokenBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602C941 RID: 182593 RVA: 0x0061EF04 File Offset: 0x0061D104
		public byte[] GetTokenArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700BF73 RID: 49011
		// (get) Token: 0x0602C942 RID: 182594 RVA: 0x0061EF14 File Offset: 0x0061D114
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C943 RID: 182595 RVA: 0x0061EF51 File Offset: 0x0061D151
		public static Offset<ICommonTip> CreateICommonTip(FlatBufferBuilder builder, TCommonTipOption TipOption_type = TCommonTipOption.NONE, int TipOptionOffset = 0, int Duration = 0, StringOffset TokenOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ICommonTip.AddToken(builder, TokenOffset);
			ICommonTip.AddDuration(builder, Duration);
			ICommonTip.AddTipOption(builder, TipOptionOffset);
			ICommonTip.AddNullMask(builder, NullMask);
			ICommonTip.AddTipOptionType(builder, TipOption_type);
			return ICommonTip.EndICommonTip(builder);
		}

		// Token: 0x0602C944 RID: 182596 RVA: 0x0061EF85 File Offset: 0x0061D185
		public static void StartICommonTip(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602C945 RID: 182597 RVA: 0x0061EF8E File Offset: 0x0061D18E
		public static void AddTipOptionType(FlatBufferBuilder builder, TCommonTipOption tipOptionType)
		{
			builder.AddByte(0, (byte)tipOptionType, 0);
		}

		// Token: 0x0602C946 RID: 182598 RVA: 0x0061EF99 File Offset: 0x0061D199
		public static void AddTipOption(FlatBufferBuilder builder, int tipOptionOffset)
		{
			builder.AddOffset(1, tipOptionOffset, 0);
		}

		// Token: 0x0602C947 RID: 182599 RVA: 0x0061EFA4 File Offset: 0x0061D1A4
		public static void AddDuration(FlatBufferBuilder builder, int duration)
		{
			builder.AddInt(2, duration, 0);
		}

		// Token: 0x0602C948 RID: 182600 RVA: 0x0061EFAF File Offset: 0x0061D1AF
		public static void AddToken(FlatBufferBuilder builder, StringOffset tokenOffset)
		{
			builder.AddOffset(3, tokenOffset.Value, 0);
		}

		// Token: 0x0602C949 RID: 182601 RVA: 0x0061EFBF File Offset: 0x0061D1BF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602C94A RID: 182602 RVA: 0x0061EFCA File Offset: 0x0061D1CA
		public static Offset<ICommonTip> EndICommonTip(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTip>(builder.EndTable());
		}

		// Token: 0x0602C94B RID: 182603 RVA: 0x0061EFD8 File Offset: 0x0061D1D8
		public ICommonTipT UnPack()
		{
			ICommonTipT commonTipT = new ICommonTipT();
			this.UnPackTo(commonTipT);
			return commonTipT;
		}

		// Token: 0x0602C94C RID: 182604 RVA: 0x0061EFF4 File Offset: 0x0061D1F4
		public void UnPackTo(ICommonTipT _o)
		{
			_o.TipOption = new TCommonTipOptionUnion();
			_o.TipOption.Type = this.TipOptionType;
			switch (this.TipOptionType)
			{
			case TCommonTipOption.IBadBuKingChallengeTip:
				_o.TipOption.Value = ((this.TipOption<IBadBuKingChallengeTip>() != null) ? this.TipOption<IBadBuKingChallengeTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IBlackCatWarning:
				_o.TipOption.Value = ((this.TipOption<IBlackCatWarning>() != null) ? this.TipOption<IBlackCatWarning>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipChallengeCondition:
				_o.TipOption.Value = ((this.TipOption<ICommonTipChallengeCondition>() != null) ? this.TipOption<ICommonTipChallengeCondition>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipChallengeFail:
				_o.TipOption.Value = ((this.TipOption<ICommonTipChallengeFail>() != null) ? this.TipOption<ICommonTipChallengeFail>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipChallengeSuccess:
				_o.TipOption.Value = ((this.TipOption<ICommonTipChallengeSuccess>() != null) ? this.TipOption<ICommonTipChallengeSuccess>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipEnterInRange:
				_o.TipOption.Value = ((this.TipOption<ICommonTipEnterInRange>() != null) ? this.TipOption<ICommonTipEnterInRange>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipFirstComplete:
				_o.TipOption.Value = ((this.TipOption<ICommonTipFirstComplete>() != null) ? this.TipOption<ICommonTipFirstComplete>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipGeneralFloatingTip:
				_o.TipOption.Value = ((this.TipOption<ICommonTipGeneralFloatingTip>() != null) ? this.TipOption<ICommonTipGeneralFloatingTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipId:
				_o.TipOption.Value = ((this.TipOption<ICommonTipId>() != null) ? this.TipOption<ICommonTipId>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipMissionComplete:
				_o.TipOption.Value = ((this.TipOption<ICommonTipMissionComplete>() != null) ? this.TipOption<ICommonTipMissionComplete>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipMissionCompleteNew:
				_o.TipOption.Value = ((this.TipOption<ICommonTipMissionCompleteNew>() != null) ? this.TipOption<ICommonTipMissionCompleteNew>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipPrepareCountdown:
				_o.TipOption.Value = ((this.TipOption<ICommonTipPrepareCountdown>() != null) ? this.TipOption<ICommonTipPrepareCountdown>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipReachChallenge:
				_o.TipOption.Value = ((this.TipOption<ICommonTipReachChallenge>() != null) ? this.TipOption<ICommonTipReachChallenge>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ICommonTipTriggerDelegation:
				_o.TipOption.Value = ((this.TipOption<ICommonTipTriggerDelegation>() != null) ? this.TipOption<ICommonTipTriggerDelegation>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IDreamlessWarning:
				_o.TipOption.Value = ((this.TipOption<IDreamlessWarning>() != null) ? this.TipOption<IDreamlessWarning>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IFlipperTip:
				_o.TipOption.Value = ((this.TipOption<IFlipperTip>() != null) ? this.TipOption<IFlipperTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IGreatSwordChallenge:
				_o.TipOption.Value = ((this.TipOption<IGreatSwordChallenge>() != null) ? this.TipOption<IGreatSwordChallenge>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IMoraleAreaTip:
				_o.TipOption.Value = ((this.TipOption<IMoraleAreaTip>() != null) ? this.TipOption<IMoraleAreaTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.INightmareLordTip:
				_o.TipOption.Value = ((this.TipOption<INightmareLordTip>() != null) ? this.TipOption<INightmareLordTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.INightmareSpawnPointTip:
				_o.TipOption.Value = ((this.TipOption<INightmareSpawnPointTip>() != null) ? this.TipOption<INightmareSpawnPointTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IPhotographicTip:
				_o.TipOption.Value = ((this.TipOption<IPhotographicTip>() != null) ? this.TipOption<IPhotographicTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IPunishReport:
				_o.TipOption.Value = ((this.TipOption<IPunishReport>() != null) ? this.TipOption<IPunishReport>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IRemainStarWarning:
				_o.TipOption.Value = ((this.TipOption<IRemainStarWarning>() != null) ? this.TipOption<IRemainStarWarning>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ISheriffCashSettlement:
				_o.TipOption.Value = ((this.TipOption<ISheriffCashSettlement>() != null) ? this.TipOption<ISheriffCashSettlement>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ISheriffCriminalArrested:
				_o.TipOption.Value = ((this.TipOption<ISheriffCriminalArrested>() != null) ? this.TipOption<ISheriffCriminalArrested>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ISheriffStartTrack:
				_o.TipOption.Value = ((this.TipOption<ISheriffStartTrack>() != null) ? this.TipOption<ISheriffStartTrack>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ISlashAndTowerTip:
				_o.TipOption.Value = ((this.TipOption<ISlashAndTowerTip>() != null) ? this.TipOption<ISlashAndTowerTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ISwordIntentTip:
				_o.TipOption.Value = ((this.TipOption<ISwordIntentTip>() != null) ? this.TipOption<ISwordIntentTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ITrapDefenseTip:
				_o.TipOption.Value = ((this.TipOption<ITrapDefenseTip>() != null) ? this.TipOption<ITrapDefenseTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IVisionSettlementHardTip:
				_o.TipOption.Value = ((this.TipOption<IVisionSettlementHardTip>() != null) ? this.TipOption<IVisionSettlementHardTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IVisionSettlementTip:
				_o.TipOption.Value = ((this.TipOption<IVisionSettlementTip>() != null) ? this.TipOption<IVisionSettlementTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IWhiteCatWarning:
				_o.TipOption.Value = ((this.TipOption<IWhiteCatWarning>() != null) ? this.TipOption<IWhiteCatWarning>().Value.UnPack() : null);
				break;
			}
			_o.Duration = this.Duration;
			_o.Token = this.Token;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C94D RID: 182605 RVA: 0x0061F848 File Offset: 0x0061DA48
		public static Offset<ICommonTip> Pack(FlatBufferBuilder builder, ICommonTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTip>);
			}
			TCommonTipOption tipOption_type = (_o.TipOption == null) ? TCommonTipOption.NONE : _o.TipOption.Type;
			int tipOptionOffset = (_o.TipOption == null) ? 0 : TCommonTipOptionUnion.Pack(builder, _o.TipOption);
			StringOffset tokenOffset = (_o.Token == null) ? default(StringOffset) : builder.CreateString(_o.Token);
			return ICommonTip.CreateICommonTip(builder, tipOption_type, tipOptionOffset, _o.Duration, tokenOffset, _o.NullMask);
		}

		// Token: 0x04010A82 RID: 68226
		private Table __p;
	}
}
