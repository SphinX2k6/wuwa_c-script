using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE8 RID: 27368
	public struct ICommonTip : IFlatbufferObject
	{
		// Token: 0x1700C8FC RID: 51452
		// (get) Token: 0x0602F08B RID: 192651 RVA: 0x0066A41C File Offset: 0x0066861C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F08C RID: 192652 RVA: 0x0066A429 File Offset: 0x00668629
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F08D RID: 192653 RVA: 0x0066A430 File Offset: 0x00668630
		public static ICommonTip GetRootAsICommonTip(ByteBuffer _bb)
		{
			return ICommonTip.GetRootAsICommonTip(_bb, default(ICommonTip));
		}

		// Token: 0x0602F08E RID: 192654 RVA: 0x0066A44C File Offset: 0x0066864C
		public static ICommonTip GetRootAsICommonTip(ByteBuffer _bb, ICommonTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F08F RID: 192655 RVA: 0x0066A469 File Offset: 0x00668669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F090 RID: 192656 RVA: 0x0066A478 File Offset: 0x00668678
		public ICommonTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8FD RID: 51453
		// (get) Token: 0x0602F091 RID: 192657 RVA: 0x0066A488 File Offset: 0x00668688
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

		// Token: 0x0602F092 RID: 192658 RVA: 0x0066A4C4 File Offset: 0x006686C4
		public TTable? TipOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F093 RID: 192659 RVA: 0x0066A508 File Offset: 0x00668708
		public IBadBuKingChallengeTip TipOptionAsIBadBuKingChallengeTip()
		{
			return this.TipOption<IBadBuKingChallengeTip>().Value;
		}

		// Token: 0x0602F094 RID: 192660 RVA: 0x0066A524 File Offset: 0x00668724
		public IBlackCatWarning TipOptionAsIBlackCatWarning()
		{
			return this.TipOption<IBlackCatWarning>().Value;
		}

		// Token: 0x0602F095 RID: 192661 RVA: 0x0066A540 File Offset: 0x00668740
		public ICommonTipChallengeCondition TipOptionAsICommonTipChallengeCondition()
		{
			return this.TipOption<ICommonTipChallengeCondition>().Value;
		}

		// Token: 0x0602F096 RID: 192662 RVA: 0x0066A55C File Offset: 0x0066875C
		public ICommonTipChallengeFail TipOptionAsICommonTipChallengeFail()
		{
			return this.TipOption<ICommonTipChallengeFail>().Value;
		}

		// Token: 0x0602F097 RID: 192663 RVA: 0x0066A578 File Offset: 0x00668778
		public ICommonTipChallengeSuccess TipOptionAsICommonTipChallengeSuccess()
		{
			return this.TipOption<ICommonTipChallengeSuccess>().Value;
		}

		// Token: 0x0602F098 RID: 192664 RVA: 0x0066A594 File Offset: 0x00668794
		public ICommonTipEnterInRange TipOptionAsICommonTipEnterInRange()
		{
			return this.TipOption<ICommonTipEnterInRange>().Value;
		}

		// Token: 0x0602F099 RID: 192665 RVA: 0x0066A5B0 File Offset: 0x006687B0
		public ICommonTipFirstComplete TipOptionAsICommonTipFirstComplete()
		{
			return this.TipOption<ICommonTipFirstComplete>().Value;
		}

		// Token: 0x0602F09A RID: 192666 RVA: 0x0066A5CC File Offset: 0x006687CC
		public ICommonTipGeneralFloatingTip TipOptionAsICommonTipGeneralFloatingTip()
		{
			return this.TipOption<ICommonTipGeneralFloatingTip>().Value;
		}

		// Token: 0x0602F09B RID: 192667 RVA: 0x0066A5E8 File Offset: 0x006687E8
		public ICommonTipId TipOptionAsICommonTipId()
		{
			return this.TipOption<ICommonTipId>().Value;
		}

		// Token: 0x0602F09C RID: 192668 RVA: 0x0066A604 File Offset: 0x00668804
		public ICommonTipMissionComplete TipOptionAsICommonTipMissionComplete()
		{
			return this.TipOption<ICommonTipMissionComplete>().Value;
		}

		// Token: 0x0602F09D RID: 192669 RVA: 0x0066A620 File Offset: 0x00668820
		public ICommonTipMissionCompleteNew TipOptionAsICommonTipMissionCompleteNew()
		{
			return this.TipOption<ICommonTipMissionCompleteNew>().Value;
		}

		// Token: 0x0602F09E RID: 192670 RVA: 0x0066A63C File Offset: 0x0066883C
		public ICommonTipPrepareCountdown TipOptionAsICommonTipPrepareCountdown()
		{
			return this.TipOption<ICommonTipPrepareCountdown>().Value;
		}

		// Token: 0x0602F09F RID: 192671 RVA: 0x0066A658 File Offset: 0x00668858
		public ICommonTipReachChallenge TipOptionAsICommonTipReachChallenge()
		{
			return this.TipOption<ICommonTipReachChallenge>().Value;
		}

		// Token: 0x0602F0A0 RID: 192672 RVA: 0x0066A674 File Offset: 0x00668874
		public ICommonTipTriggerDelegation TipOptionAsICommonTipTriggerDelegation()
		{
			return this.TipOption<ICommonTipTriggerDelegation>().Value;
		}

		// Token: 0x0602F0A1 RID: 192673 RVA: 0x0066A690 File Offset: 0x00668890
		public IDreamlessWarning TipOptionAsIDreamlessWarning()
		{
			return this.TipOption<IDreamlessWarning>().Value;
		}

		// Token: 0x0602F0A2 RID: 192674 RVA: 0x0066A6AC File Offset: 0x006688AC
		public IFlipperTip TipOptionAsIFlipperTip()
		{
			return this.TipOption<IFlipperTip>().Value;
		}

		// Token: 0x0602F0A3 RID: 192675 RVA: 0x0066A6C8 File Offset: 0x006688C8
		public IFrequencyDetectionTip TipOptionAsIFrequencyDetectionTip()
		{
			return this.TipOption<IFrequencyDetectionTip>().Value;
		}

		// Token: 0x0602F0A4 RID: 192676 RVA: 0x0066A6E4 File Offset: 0x006688E4
		public IGreatSwordChallenge TipOptionAsIGreatSwordChallenge()
		{
			return this.TipOption<IGreatSwordChallenge>().Value;
		}

		// Token: 0x0602F0A5 RID: 192677 RVA: 0x0066A700 File Offset: 0x00668900
		public IMoraleAreaTip TipOptionAsIMoraleAreaTip()
		{
			return this.TipOption<IMoraleAreaTip>().Value;
		}

		// Token: 0x0602F0A6 RID: 192678 RVA: 0x0066A71C File Offset: 0x0066891C
		public INightmareLordTip TipOptionAsINightmareLordTip()
		{
			return this.TipOption<INightmareLordTip>().Value;
		}

		// Token: 0x0602F0A7 RID: 192679 RVA: 0x0066A738 File Offset: 0x00668938
		public INightmareSpawnPointTip TipOptionAsINightmareSpawnPointTip()
		{
			return this.TipOption<INightmareSpawnPointTip>().Value;
		}

		// Token: 0x0602F0A8 RID: 192680 RVA: 0x0066A754 File Offset: 0x00668954
		public IPhotographicTip TipOptionAsIPhotographicTip()
		{
			return this.TipOption<IPhotographicTip>().Value;
		}

		// Token: 0x0602F0A9 RID: 192681 RVA: 0x0066A770 File Offset: 0x00668970
		public IPunishReport TipOptionAsIPunishReport()
		{
			return this.TipOption<IPunishReport>().Value;
		}

		// Token: 0x0602F0AA RID: 192682 RVA: 0x0066A78C File Offset: 0x0066898C
		public IRedNameMonsterTip TipOptionAsIRedNameMonsterTip()
		{
			return this.TipOption<IRedNameMonsterTip>().Value;
		}

		// Token: 0x0602F0AB RID: 192683 RVA: 0x0066A7A8 File Offset: 0x006689A8
		public IRemainStarWarning TipOptionAsIRemainStarWarning()
		{
			return this.TipOption<IRemainStarWarning>().Value;
		}

		// Token: 0x0602F0AC RID: 192684 RVA: 0x0066A7C4 File Offset: 0x006689C4
		public IRoleTowerStrongEnemyWarning TipOptionAsIRoleTowerStrongEnemyWarning()
		{
			return this.TipOption<IRoleTowerStrongEnemyWarning>().Value;
		}

		// Token: 0x0602F0AD RID: 192685 RVA: 0x0066A7E0 File Offset: 0x006689E0
		public ISheriffCashSettlement TipOptionAsISheriffCashSettlement()
		{
			return this.TipOption<ISheriffCashSettlement>().Value;
		}

		// Token: 0x0602F0AE RID: 192686 RVA: 0x0066A7FC File Offset: 0x006689FC
		public ISheriffCriminalArrested TipOptionAsISheriffCriminalArrested()
		{
			return this.TipOption<ISheriffCriminalArrested>().Value;
		}

		// Token: 0x0602F0AF RID: 192687 RVA: 0x0066A818 File Offset: 0x00668A18
		public ISheriffStartTrack TipOptionAsISheriffStartTrack()
		{
			return this.TipOption<ISheriffStartTrack>().Value;
		}

		// Token: 0x0602F0B0 RID: 192688 RVA: 0x0066A834 File Offset: 0x00668A34
		public ISlashAndTowerTip TipOptionAsISlashAndTowerTip()
		{
			return this.TipOption<ISlashAndTowerTip>().Value;
		}

		// Token: 0x0602F0B1 RID: 192689 RVA: 0x0066A850 File Offset: 0x00668A50
		public ISwordIntentTip TipOptionAsISwordIntentTip()
		{
			return this.TipOption<ISwordIntentTip>().Value;
		}

		// Token: 0x0602F0B2 RID: 192690 RVA: 0x0066A86C File Offset: 0x00668A6C
		public ITeachAutoShowEnd TipOptionAsITeachAutoShowEnd()
		{
			return this.TipOption<ITeachAutoShowEnd>().Value;
		}

		// Token: 0x0602F0B3 RID: 192691 RVA: 0x0066A888 File Offset: 0x00668A88
		public ITeachAutoShowStart TipOptionAsITeachAutoShowStart()
		{
			return this.TipOption<ITeachAutoShowStart>().Value;
		}

		// Token: 0x0602F0B4 RID: 192692 RVA: 0x0066A8A4 File Offset: 0x00668AA4
		public ITrapDefenseTip TipOptionAsITrapDefenseTip()
		{
			return this.TipOption<ITrapDefenseTip>().Value;
		}

		// Token: 0x0602F0B5 RID: 192693 RVA: 0x0066A8C0 File Offset: 0x00668AC0
		public IVisionSettlementHardTip TipOptionAsIVisionSettlementHardTip()
		{
			return this.TipOption<IVisionSettlementHardTip>().Value;
		}

		// Token: 0x0602F0B6 RID: 192694 RVA: 0x0066A8DC File Offset: 0x00668ADC
		public IVisionSettlementTip TipOptionAsIVisionSettlementTip()
		{
			return this.TipOption<IVisionSettlementTip>().Value;
		}

		// Token: 0x0602F0B7 RID: 192695 RVA: 0x0066A8F8 File Offset: 0x00668AF8
		public IWhiteCatWarning TipOptionAsIWhiteCatWarning()
		{
			return this.TipOption<IWhiteCatWarning>().Value;
		}

		// Token: 0x1700C8FE RID: 51454
		// (get) Token: 0x0602F0B8 RID: 192696 RVA: 0x0066A914 File Offset: 0x00668B14
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

		// Token: 0x1700C8FF RID: 51455
		// (get) Token: 0x0602F0B9 RID: 192697 RVA: 0x0066A950 File Offset: 0x00668B50
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

		// Token: 0x0602F0BA RID: 192698 RVA: 0x0066A988 File Offset: 0x00668B88
		public Span<byte> GetTokenBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602F0BB RID: 192699 RVA: 0x0066A998 File Offset: 0x00668B98
		public byte[] GetTokenArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700C900 RID: 51456
		// (get) Token: 0x0602F0BC RID: 192700 RVA: 0x0066A9A8 File Offset: 0x00668BA8
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

		// Token: 0x0602F0BD RID: 192701 RVA: 0x0066A9E5 File Offset: 0x00668BE5
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

		// Token: 0x0602F0BE RID: 192702 RVA: 0x0066AA19 File Offset: 0x00668C19
		public static void StartICommonTip(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602F0BF RID: 192703 RVA: 0x0066AA22 File Offset: 0x00668C22
		public static void AddTipOptionType(FlatBufferBuilder builder, TCommonTipOption tipOptionType)
		{
			builder.AddByte(0, (byte)tipOptionType, 0);
		}

		// Token: 0x0602F0C0 RID: 192704 RVA: 0x0066AA2D File Offset: 0x00668C2D
		public static void AddTipOption(FlatBufferBuilder builder, int tipOptionOffset)
		{
			builder.AddOffset(1, tipOptionOffset, 0);
		}

		// Token: 0x0602F0C1 RID: 192705 RVA: 0x0066AA38 File Offset: 0x00668C38
		public static void AddDuration(FlatBufferBuilder builder, int duration)
		{
			builder.AddInt(2, duration, 0);
		}

		// Token: 0x0602F0C2 RID: 192706 RVA: 0x0066AA43 File Offset: 0x00668C43
		public static void AddToken(FlatBufferBuilder builder, StringOffset tokenOffset)
		{
			builder.AddOffset(3, tokenOffset.Value, 0);
		}

		// Token: 0x0602F0C3 RID: 192707 RVA: 0x0066AA53 File Offset: 0x00668C53
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602F0C4 RID: 192708 RVA: 0x0066AA5E File Offset: 0x00668C5E
		public static Offset<ICommonTip> EndICommonTip(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTip>(builder.EndTable());
		}

		// Token: 0x0602F0C5 RID: 192709 RVA: 0x0066AA6C File Offset: 0x00668C6C
		public ICommonTipT UnPack()
		{
			ICommonTipT commonTipT = new ICommonTipT();
			this.UnPackTo(commonTipT);
			return commonTipT;
		}

		// Token: 0x0602F0C6 RID: 192710 RVA: 0x0066AA88 File Offset: 0x00668C88
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
			case TCommonTipOption.IFrequencyDetectionTip:
				_o.TipOption.Value = ((this.TipOption<IFrequencyDetectionTip>() != null) ? this.TipOption<IFrequencyDetectionTip>().Value.UnPack() : null);
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
			case TCommonTipOption.IRedNameMonsterTip:
				_o.TipOption.Value = ((this.TipOption<IRedNameMonsterTip>() != null) ? this.TipOption<IRedNameMonsterTip>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IRemainStarWarning:
				_o.TipOption.Value = ((this.TipOption<IRemainStarWarning>() != null) ? this.TipOption<IRemainStarWarning>().Value.UnPack() : null);
				break;
			case TCommonTipOption.IRoleTowerStrongEnemyWarning:
				_o.TipOption.Value = ((this.TipOption<IRoleTowerStrongEnemyWarning>() != null) ? this.TipOption<IRoleTowerStrongEnemyWarning>().Value.UnPack() : null);
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
			case TCommonTipOption.ITeachAutoShowEnd:
				_o.TipOption.Value = ((this.TipOption<ITeachAutoShowEnd>() != null) ? this.TipOption<ITeachAutoShowEnd>().Value.UnPack() : null);
				break;
			case TCommonTipOption.ITeachAutoShowStart:
				_o.TipOption.Value = ((this.TipOption<ITeachAutoShowStart>() != null) ? this.TipOption<ITeachAutoShowStart>().Value.UnPack() : null);
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

		// Token: 0x0602F0C7 RID: 192711 RVA: 0x0066B41C File Offset: 0x0066961C
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

		// Token: 0x04011893 RID: 71827
		private Table __p;
	}
}
