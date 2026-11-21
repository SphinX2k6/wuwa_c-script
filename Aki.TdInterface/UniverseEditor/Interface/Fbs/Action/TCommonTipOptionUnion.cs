using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E9B RID: 32411
	public class TCommonTipOptionUnion
	{
		// Token: 0x1700F22F RID: 61999
		// (get) Token: 0x0603A811 RID: 239633 RVA: 0x007DFBF2 File Offset: 0x007DDDF2
		// (set) Token: 0x0603A812 RID: 239634 RVA: 0x007DFBFA File Offset: 0x007DDDFA
		public TCommonTipOption Type { get; set; }

		// Token: 0x1700F230 RID: 62000
		// (get) Token: 0x0603A813 RID: 239635 RVA: 0x007DFC03 File Offset: 0x007DDE03
		// (set) Token: 0x0603A814 RID: 239636 RVA: 0x007DFC0B File Offset: 0x007DDE0B
		public object Value { get; set; }

		// Token: 0x0603A815 RID: 239637 RVA: 0x007DFC14 File Offset: 0x007DDE14
		public TCommonTipOptionUnion()
		{
			this.Type = TCommonTipOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603A816 RID: 239638 RVA: 0x007DFC2A File Offset: 0x007DDE2A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A817 RID: 239639 RVA: 0x007DFC3C File Offset: 0x007DDE3C
		public IBadBuKingChallengeTipT AsIBadBuKingChallengeTip()
		{
			return this.As<IBadBuKingChallengeTipT>();
		}

		// Token: 0x0603A818 RID: 239640 RVA: 0x007DFC44 File Offset: 0x007DDE44
		public static TCommonTipOptionUnion FromIBadBuKingChallengeTip(IBadBuKingChallengeTipT _ibadbukingchallengetip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IBadBuKingChallengeTip,
				Value = _ibadbukingchallengetip
			};
		}

		// Token: 0x0603A819 RID: 239641 RVA: 0x007DFC59 File Offset: 0x007DDE59
		public IBlackCatWarningT AsIBlackCatWarning()
		{
			return this.As<IBlackCatWarningT>();
		}

		// Token: 0x0603A81A RID: 239642 RVA: 0x007DFC61 File Offset: 0x007DDE61
		public static TCommonTipOptionUnion FromIBlackCatWarning(IBlackCatWarningT _iblackcatwarning)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IBlackCatWarning,
				Value = _iblackcatwarning
			};
		}

		// Token: 0x0603A81B RID: 239643 RVA: 0x007DFC76 File Offset: 0x007DDE76
		public ICommonTipChallengeConditionT AsICommonTipChallengeCondition()
		{
			return this.As<ICommonTipChallengeConditionT>();
		}

		// Token: 0x0603A81C RID: 239644 RVA: 0x007DFC7E File Offset: 0x007DDE7E
		public static TCommonTipOptionUnion FromICommonTipChallengeCondition(ICommonTipChallengeConditionT _icommontipchallengecondition)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipChallengeCondition,
				Value = _icommontipchallengecondition
			};
		}

		// Token: 0x0603A81D RID: 239645 RVA: 0x007DFC93 File Offset: 0x007DDE93
		public ICommonTipChallengeFailT AsICommonTipChallengeFail()
		{
			return this.As<ICommonTipChallengeFailT>();
		}

		// Token: 0x0603A81E RID: 239646 RVA: 0x007DFC9B File Offset: 0x007DDE9B
		public static TCommonTipOptionUnion FromICommonTipChallengeFail(ICommonTipChallengeFailT _icommontipchallengefail)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipChallengeFail,
				Value = _icommontipchallengefail
			};
		}

		// Token: 0x0603A81F RID: 239647 RVA: 0x007DFCB0 File Offset: 0x007DDEB0
		public ICommonTipChallengeSuccessT AsICommonTipChallengeSuccess()
		{
			return this.As<ICommonTipChallengeSuccessT>();
		}

		// Token: 0x0603A820 RID: 239648 RVA: 0x007DFCB8 File Offset: 0x007DDEB8
		public static TCommonTipOptionUnion FromICommonTipChallengeSuccess(ICommonTipChallengeSuccessT _icommontipchallengesuccess)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipChallengeSuccess,
				Value = _icommontipchallengesuccess
			};
		}

		// Token: 0x0603A821 RID: 239649 RVA: 0x007DFCCD File Offset: 0x007DDECD
		public ICommonTipEnterInRangeT AsICommonTipEnterInRange()
		{
			return this.As<ICommonTipEnterInRangeT>();
		}

		// Token: 0x0603A822 RID: 239650 RVA: 0x007DFCD5 File Offset: 0x007DDED5
		public static TCommonTipOptionUnion FromICommonTipEnterInRange(ICommonTipEnterInRangeT _icommontipenterinrange)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipEnterInRange,
				Value = _icommontipenterinrange
			};
		}

		// Token: 0x0603A823 RID: 239651 RVA: 0x007DFCEA File Offset: 0x007DDEEA
		public ICommonTipFirstCompleteT AsICommonTipFirstComplete()
		{
			return this.As<ICommonTipFirstCompleteT>();
		}

		// Token: 0x0603A824 RID: 239652 RVA: 0x007DFCF2 File Offset: 0x007DDEF2
		public static TCommonTipOptionUnion FromICommonTipFirstComplete(ICommonTipFirstCompleteT _icommontipfirstcomplete)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipFirstComplete,
				Value = _icommontipfirstcomplete
			};
		}

		// Token: 0x0603A825 RID: 239653 RVA: 0x007DFD07 File Offset: 0x007DDF07
		public ICommonTipGeneralFloatingTipT AsICommonTipGeneralFloatingTip()
		{
			return this.As<ICommonTipGeneralFloatingTipT>();
		}

		// Token: 0x0603A826 RID: 239654 RVA: 0x007DFD0F File Offset: 0x007DDF0F
		public static TCommonTipOptionUnion FromICommonTipGeneralFloatingTip(ICommonTipGeneralFloatingTipT _icommontipgeneralfloatingtip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipGeneralFloatingTip,
				Value = _icommontipgeneralfloatingtip
			};
		}

		// Token: 0x0603A827 RID: 239655 RVA: 0x007DFD24 File Offset: 0x007DDF24
		public ICommonTipIdT AsICommonTipId()
		{
			return this.As<ICommonTipIdT>();
		}

		// Token: 0x0603A828 RID: 239656 RVA: 0x007DFD2C File Offset: 0x007DDF2C
		public static TCommonTipOptionUnion FromICommonTipId(ICommonTipIdT _icommontipid)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipId,
				Value = _icommontipid
			};
		}

		// Token: 0x0603A829 RID: 239657 RVA: 0x007DFD42 File Offset: 0x007DDF42
		public ICommonTipMissionCompleteT AsICommonTipMissionComplete()
		{
			return this.As<ICommonTipMissionCompleteT>();
		}

		// Token: 0x0603A82A RID: 239658 RVA: 0x007DFD4A File Offset: 0x007DDF4A
		public static TCommonTipOptionUnion FromICommonTipMissionComplete(ICommonTipMissionCompleteT _icommontipmissioncomplete)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipMissionComplete,
				Value = _icommontipmissioncomplete
			};
		}

		// Token: 0x0603A82B RID: 239659 RVA: 0x007DFD60 File Offset: 0x007DDF60
		public ICommonTipMissionCompleteNewT AsICommonTipMissionCompleteNew()
		{
			return this.As<ICommonTipMissionCompleteNewT>();
		}

		// Token: 0x0603A82C RID: 239660 RVA: 0x007DFD68 File Offset: 0x007DDF68
		public static TCommonTipOptionUnion FromICommonTipMissionCompleteNew(ICommonTipMissionCompleteNewT _icommontipmissioncompletenew)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipMissionCompleteNew,
				Value = _icommontipmissioncompletenew
			};
		}

		// Token: 0x0603A82D RID: 239661 RVA: 0x007DFD7E File Offset: 0x007DDF7E
		public ICommonTipPrepareCountdownT AsICommonTipPrepareCountdown()
		{
			return this.As<ICommonTipPrepareCountdownT>();
		}

		// Token: 0x0603A82E RID: 239662 RVA: 0x007DFD86 File Offset: 0x007DDF86
		public static TCommonTipOptionUnion FromICommonTipPrepareCountdown(ICommonTipPrepareCountdownT _icommontippreparecountdown)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipPrepareCountdown,
				Value = _icommontippreparecountdown
			};
		}

		// Token: 0x0603A82F RID: 239663 RVA: 0x007DFD9C File Offset: 0x007DDF9C
		public ICommonTipReachChallengeT AsICommonTipReachChallenge()
		{
			return this.As<ICommonTipReachChallengeT>();
		}

		// Token: 0x0603A830 RID: 239664 RVA: 0x007DFDA4 File Offset: 0x007DDFA4
		public static TCommonTipOptionUnion FromICommonTipReachChallenge(ICommonTipReachChallengeT _icommontipreachchallenge)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipReachChallenge,
				Value = _icommontipreachchallenge
			};
		}

		// Token: 0x0603A831 RID: 239665 RVA: 0x007DFDBA File Offset: 0x007DDFBA
		public ICommonTipTriggerDelegationT AsICommonTipTriggerDelegation()
		{
			return this.As<ICommonTipTriggerDelegationT>();
		}

		// Token: 0x0603A832 RID: 239666 RVA: 0x007DFDC2 File Offset: 0x007DDFC2
		public static TCommonTipOptionUnion FromICommonTipTriggerDelegation(ICommonTipTriggerDelegationT _icommontiptriggerdelegation)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipTriggerDelegation,
				Value = _icommontiptriggerdelegation
			};
		}

		// Token: 0x0603A833 RID: 239667 RVA: 0x007DFDD8 File Offset: 0x007DDFD8
		public IDreamlessWarningT AsIDreamlessWarning()
		{
			return this.As<IDreamlessWarningT>();
		}

		// Token: 0x0603A834 RID: 239668 RVA: 0x007DFDE0 File Offset: 0x007DDFE0
		public static TCommonTipOptionUnion FromIDreamlessWarning(IDreamlessWarningT _idreamlesswarning)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IDreamlessWarning,
				Value = _idreamlesswarning
			};
		}

		// Token: 0x0603A835 RID: 239669 RVA: 0x007DFDF6 File Offset: 0x007DDFF6
		public IFlipperTipT AsIFlipperTip()
		{
			return this.As<IFlipperTipT>();
		}

		// Token: 0x0603A836 RID: 239670 RVA: 0x007DFDFE File Offset: 0x007DDFFE
		public static TCommonTipOptionUnion FromIFlipperTip(IFlipperTipT _iflippertip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IFlipperTip,
				Value = _iflippertip
			};
		}

		// Token: 0x0603A837 RID: 239671 RVA: 0x007DFE14 File Offset: 0x007DE014
		public IFrequencyDetectionTipT AsIFrequencyDetectionTip()
		{
			return this.As<IFrequencyDetectionTipT>();
		}

		// Token: 0x0603A838 RID: 239672 RVA: 0x007DFE1C File Offset: 0x007DE01C
		public static TCommonTipOptionUnion FromIFrequencyDetectionTip(IFrequencyDetectionTipT _ifrequencydetectiontip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IFrequencyDetectionTip,
				Value = _ifrequencydetectiontip
			};
		}

		// Token: 0x0603A839 RID: 239673 RVA: 0x007DFE32 File Offset: 0x007DE032
		public IGreatSwordChallengeT AsIGreatSwordChallenge()
		{
			return this.As<IGreatSwordChallengeT>();
		}

		// Token: 0x0603A83A RID: 239674 RVA: 0x007DFE3A File Offset: 0x007DE03A
		public static TCommonTipOptionUnion FromIGreatSwordChallenge(IGreatSwordChallengeT _igreatswordchallenge)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IGreatSwordChallenge,
				Value = _igreatswordchallenge
			};
		}

		// Token: 0x0603A83B RID: 239675 RVA: 0x007DFE50 File Offset: 0x007DE050
		public IMoraleAreaTipT AsIMoraleAreaTip()
		{
			return this.As<IMoraleAreaTipT>();
		}

		// Token: 0x0603A83C RID: 239676 RVA: 0x007DFE58 File Offset: 0x007DE058
		public static TCommonTipOptionUnion FromIMoraleAreaTip(IMoraleAreaTipT _imoraleareatip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IMoraleAreaTip,
				Value = _imoraleareatip
			};
		}

		// Token: 0x0603A83D RID: 239677 RVA: 0x007DFE6E File Offset: 0x007DE06E
		public INightmareLordTipT AsINightmareLordTip()
		{
			return this.As<INightmareLordTipT>();
		}

		// Token: 0x0603A83E RID: 239678 RVA: 0x007DFE76 File Offset: 0x007DE076
		public static TCommonTipOptionUnion FromINightmareLordTip(INightmareLordTipT _inightmarelordtip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.INightmareLordTip,
				Value = _inightmarelordtip
			};
		}

		// Token: 0x0603A83F RID: 239679 RVA: 0x007DFE8C File Offset: 0x007DE08C
		public INightmareSpawnPointTipT AsINightmareSpawnPointTip()
		{
			return this.As<INightmareSpawnPointTipT>();
		}

		// Token: 0x0603A840 RID: 239680 RVA: 0x007DFE94 File Offset: 0x007DE094
		public static TCommonTipOptionUnion FromINightmareSpawnPointTip(INightmareSpawnPointTipT _inightmarespawnpointtip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.INightmareSpawnPointTip,
				Value = _inightmarespawnpointtip
			};
		}

		// Token: 0x0603A841 RID: 239681 RVA: 0x007DFEAA File Offset: 0x007DE0AA
		public IPhotographicTipT AsIPhotographicTip()
		{
			return this.As<IPhotographicTipT>();
		}

		// Token: 0x0603A842 RID: 239682 RVA: 0x007DFEB2 File Offset: 0x007DE0B2
		public static TCommonTipOptionUnion FromIPhotographicTip(IPhotographicTipT _iphotographictip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IPhotographicTip,
				Value = _iphotographictip
			};
		}

		// Token: 0x0603A843 RID: 239683 RVA: 0x007DFEC8 File Offset: 0x007DE0C8
		public IPunishReportT AsIPunishReport()
		{
			return this.As<IPunishReportT>();
		}

		// Token: 0x0603A844 RID: 239684 RVA: 0x007DFED0 File Offset: 0x007DE0D0
		public static TCommonTipOptionUnion FromIPunishReport(IPunishReportT _ipunishreport)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IPunishReport,
				Value = _ipunishreport
			};
		}

		// Token: 0x0603A845 RID: 239685 RVA: 0x007DFEE6 File Offset: 0x007DE0E6
		public IRedNameMonsterTipT AsIRedNameMonsterTip()
		{
			return this.As<IRedNameMonsterTipT>();
		}

		// Token: 0x0603A846 RID: 239686 RVA: 0x007DFEEE File Offset: 0x007DE0EE
		public static TCommonTipOptionUnion FromIRedNameMonsterTip(IRedNameMonsterTipT _irednamemonstertip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IRedNameMonsterTip,
				Value = _irednamemonstertip
			};
		}

		// Token: 0x0603A847 RID: 239687 RVA: 0x007DFF04 File Offset: 0x007DE104
		public IRemainStarWarningT AsIRemainStarWarning()
		{
			return this.As<IRemainStarWarningT>();
		}

		// Token: 0x0603A848 RID: 239688 RVA: 0x007DFF0C File Offset: 0x007DE10C
		public static TCommonTipOptionUnion FromIRemainStarWarning(IRemainStarWarningT _iremainstarwarning)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IRemainStarWarning,
				Value = _iremainstarwarning
			};
		}

		// Token: 0x0603A849 RID: 239689 RVA: 0x007DFF22 File Offset: 0x007DE122
		public IRoleTowerStrongEnemyWarningT AsIRoleTowerStrongEnemyWarning()
		{
			return this.As<IRoleTowerStrongEnemyWarningT>();
		}

		// Token: 0x0603A84A RID: 239690 RVA: 0x007DFF2A File Offset: 0x007DE12A
		public static TCommonTipOptionUnion FromIRoleTowerStrongEnemyWarning(IRoleTowerStrongEnemyWarningT _iroletowerstrongenemywarning)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IRoleTowerStrongEnemyWarning,
				Value = _iroletowerstrongenemywarning
			};
		}

		// Token: 0x0603A84B RID: 239691 RVA: 0x007DFF40 File Offset: 0x007DE140
		public ISheriffCashSettlementT AsISheriffCashSettlement()
		{
			return this.As<ISheriffCashSettlementT>();
		}

		// Token: 0x0603A84C RID: 239692 RVA: 0x007DFF48 File Offset: 0x007DE148
		public static TCommonTipOptionUnion FromISheriffCashSettlement(ISheriffCashSettlementT _isheriffcashsettlement)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ISheriffCashSettlement,
				Value = _isheriffcashsettlement
			};
		}

		// Token: 0x0603A84D RID: 239693 RVA: 0x007DFF5E File Offset: 0x007DE15E
		public ISheriffCriminalArrestedT AsISheriffCriminalArrested()
		{
			return this.As<ISheriffCriminalArrestedT>();
		}

		// Token: 0x0603A84E RID: 239694 RVA: 0x007DFF66 File Offset: 0x007DE166
		public static TCommonTipOptionUnion FromISheriffCriminalArrested(ISheriffCriminalArrestedT _isheriffcriminalarrested)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ISheriffCriminalArrested,
				Value = _isheriffcriminalarrested
			};
		}

		// Token: 0x0603A84F RID: 239695 RVA: 0x007DFF7C File Offset: 0x007DE17C
		public ISheriffStartTrackT AsISheriffStartTrack()
		{
			return this.As<ISheriffStartTrackT>();
		}

		// Token: 0x0603A850 RID: 239696 RVA: 0x007DFF84 File Offset: 0x007DE184
		public static TCommonTipOptionUnion FromISheriffStartTrack(ISheriffStartTrackT _isheriffstarttrack)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ISheriffStartTrack,
				Value = _isheriffstarttrack
			};
		}

		// Token: 0x0603A851 RID: 239697 RVA: 0x007DFF9A File Offset: 0x007DE19A
		public ISlashAndTowerTipT AsISlashAndTowerTip()
		{
			return this.As<ISlashAndTowerTipT>();
		}

		// Token: 0x0603A852 RID: 239698 RVA: 0x007DFFA2 File Offset: 0x007DE1A2
		public static TCommonTipOptionUnion FromISlashAndTowerTip(ISlashAndTowerTipT _islashandtowertip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ISlashAndTowerTip,
				Value = _islashandtowertip
			};
		}

		// Token: 0x0603A853 RID: 239699 RVA: 0x007DFFB8 File Offset: 0x007DE1B8
		public ISwordIntentTipT AsISwordIntentTip()
		{
			return this.As<ISwordIntentTipT>();
		}

		// Token: 0x0603A854 RID: 239700 RVA: 0x007DFFC0 File Offset: 0x007DE1C0
		public static TCommonTipOptionUnion FromISwordIntentTip(ISwordIntentTipT _iswordintenttip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ISwordIntentTip,
				Value = _iswordintenttip
			};
		}

		// Token: 0x0603A855 RID: 239701 RVA: 0x007DFFD6 File Offset: 0x007DE1D6
		public ITeachAutoShowEndT AsITeachAutoShowEnd()
		{
			return this.As<ITeachAutoShowEndT>();
		}

		// Token: 0x0603A856 RID: 239702 RVA: 0x007DFFDE File Offset: 0x007DE1DE
		public static TCommonTipOptionUnion FromITeachAutoShowEnd(ITeachAutoShowEndT _iteachautoshowend)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ITeachAutoShowEnd,
				Value = _iteachautoshowend
			};
		}

		// Token: 0x0603A857 RID: 239703 RVA: 0x007DFFF4 File Offset: 0x007DE1F4
		public ITeachAutoShowStartT AsITeachAutoShowStart()
		{
			return this.As<ITeachAutoShowStartT>();
		}

		// Token: 0x0603A858 RID: 239704 RVA: 0x007DFFFC File Offset: 0x007DE1FC
		public static TCommonTipOptionUnion FromITeachAutoShowStart(ITeachAutoShowStartT _iteachautoshowstart)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ITeachAutoShowStart,
				Value = _iteachautoshowstart
			};
		}

		// Token: 0x0603A859 RID: 239705 RVA: 0x007E0012 File Offset: 0x007DE212
		public ITrapDefenseTipT AsITrapDefenseTip()
		{
			return this.As<ITrapDefenseTipT>();
		}

		// Token: 0x0603A85A RID: 239706 RVA: 0x007E001A File Offset: 0x007DE21A
		public static TCommonTipOptionUnion FromITrapDefenseTip(ITrapDefenseTipT _itrapdefensetip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ITrapDefenseTip,
				Value = _itrapdefensetip
			};
		}

		// Token: 0x0603A85B RID: 239707 RVA: 0x007E0030 File Offset: 0x007DE230
		public IVisionSettlementHardTipT AsIVisionSettlementHardTip()
		{
			return this.As<IVisionSettlementHardTipT>();
		}

		// Token: 0x0603A85C RID: 239708 RVA: 0x007E0038 File Offset: 0x007DE238
		public static TCommonTipOptionUnion FromIVisionSettlementHardTip(IVisionSettlementHardTipT _ivisionsettlementhardtip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IVisionSettlementHardTip,
				Value = _ivisionsettlementhardtip
			};
		}

		// Token: 0x0603A85D RID: 239709 RVA: 0x007E004E File Offset: 0x007DE24E
		public IVisionSettlementTipT AsIVisionSettlementTip()
		{
			return this.As<IVisionSettlementTipT>();
		}

		// Token: 0x0603A85E RID: 239710 RVA: 0x007E0056 File Offset: 0x007DE256
		public static TCommonTipOptionUnion FromIVisionSettlementTip(IVisionSettlementTipT _ivisionsettlementtip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IVisionSettlementTip,
				Value = _ivisionsettlementtip
			};
		}

		// Token: 0x0603A85F RID: 239711 RVA: 0x007E006C File Offset: 0x007DE26C
		public IWhiteCatWarningT AsIWhiteCatWarning()
		{
			return this.As<IWhiteCatWarningT>();
		}

		// Token: 0x0603A860 RID: 239712 RVA: 0x007E0074 File Offset: 0x007DE274
		public static TCommonTipOptionUnion FromIWhiteCatWarning(IWhiteCatWarningT _iwhitecatwarning)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IWhiteCatWarning,
				Value = _iwhitecatwarning
			};
		}

		// Token: 0x0603A861 RID: 239713 RVA: 0x007E008C File Offset: 0x007DE28C
		public static int Pack(FlatBufferBuilder builder, TCommonTipOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TCommonTipOption.IBadBuKingChallengeTip:
				return IBadBuKingChallengeTip.Pack(builder, _o.AsIBadBuKingChallengeTip()).Value;
			case TCommonTipOption.IBlackCatWarning:
				return IBlackCatWarning.Pack(builder, _o.AsIBlackCatWarning()).Value;
			case TCommonTipOption.ICommonTipChallengeCondition:
				return ICommonTipChallengeCondition.Pack(builder, _o.AsICommonTipChallengeCondition()).Value;
			case TCommonTipOption.ICommonTipChallengeFail:
				return ICommonTipChallengeFail.Pack(builder, _o.AsICommonTipChallengeFail()).Value;
			case TCommonTipOption.ICommonTipChallengeSuccess:
				return ICommonTipChallengeSuccess.Pack(builder, _o.AsICommonTipChallengeSuccess()).Value;
			case TCommonTipOption.ICommonTipEnterInRange:
				return ICommonTipEnterInRange.Pack(builder, _o.AsICommonTipEnterInRange()).Value;
			case TCommonTipOption.ICommonTipFirstComplete:
				return ICommonTipFirstComplete.Pack(builder, _o.AsICommonTipFirstComplete()).Value;
			case TCommonTipOption.ICommonTipGeneralFloatingTip:
				return ICommonTipGeneralFloatingTip.Pack(builder, _o.AsICommonTipGeneralFloatingTip()).Value;
			case TCommonTipOption.ICommonTipId:
				return ICommonTipId.Pack(builder, _o.AsICommonTipId()).Value;
			case TCommonTipOption.ICommonTipMissionComplete:
				return ICommonTipMissionComplete.Pack(builder, _o.AsICommonTipMissionComplete()).Value;
			case TCommonTipOption.ICommonTipMissionCompleteNew:
				return ICommonTipMissionCompleteNew.Pack(builder, _o.AsICommonTipMissionCompleteNew()).Value;
			case TCommonTipOption.ICommonTipPrepareCountdown:
				return ICommonTipPrepareCountdown.Pack(builder, _o.AsICommonTipPrepareCountdown()).Value;
			case TCommonTipOption.ICommonTipReachChallenge:
				return ICommonTipReachChallenge.Pack(builder, _o.AsICommonTipReachChallenge()).Value;
			case TCommonTipOption.ICommonTipTriggerDelegation:
				return ICommonTipTriggerDelegation.Pack(builder, _o.AsICommonTipTriggerDelegation()).Value;
			case TCommonTipOption.IDreamlessWarning:
				return IDreamlessWarning.Pack(builder, _o.AsIDreamlessWarning()).Value;
			case TCommonTipOption.IFlipperTip:
				return IFlipperTip.Pack(builder, _o.AsIFlipperTip()).Value;
			case TCommonTipOption.IFrequencyDetectionTip:
				return IFrequencyDetectionTip.Pack(builder, _o.AsIFrequencyDetectionTip()).Value;
			case TCommonTipOption.IGreatSwordChallenge:
				return IGreatSwordChallenge.Pack(builder, _o.AsIGreatSwordChallenge()).Value;
			case TCommonTipOption.IMoraleAreaTip:
				return IMoraleAreaTip.Pack(builder, _o.AsIMoraleAreaTip()).Value;
			case TCommonTipOption.INightmareLordTip:
				return INightmareLordTip.Pack(builder, _o.AsINightmareLordTip()).Value;
			case TCommonTipOption.INightmareSpawnPointTip:
				return INightmareSpawnPointTip.Pack(builder, _o.AsINightmareSpawnPointTip()).Value;
			case TCommonTipOption.IPhotographicTip:
				return IPhotographicTip.Pack(builder, _o.AsIPhotographicTip()).Value;
			case TCommonTipOption.IPunishReport:
				return IPunishReport.Pack(builder, _o.AsIPunishReport()).Value;
			case TCommonTipOption.IRedNameMonsterTip:
				return IRedNameMonsterTip.Pack(builder, _o.AsIRedNameMonsterTip()).Value;
			case TCommonTipOption.IRemainStarWarning:
				return IRemainStarWarning.Pack(builder, _o.AsIRemainStarWarning()).Value;
			case TCommonTipOption.IRoleTowerStrongEnemyWarning:
				return IRoleTowerStrongEnemyWarning.Pack(builder, _o.AsIRoleTowerStrongEnemyWarning()).Value;
			case TCommonTipOption.ISheriffCashSettlement:
				return ISheriffCashSettlement.Pack(builder, _o.AsISheriffCashSettlement()).Value;
			case TCommonTipOption.ISheriffCriminalArrested:
				return ISheriffCriminalArrested.Pack(builder, _o.AsISheriffCriminalArrested()).Value;
			case TCommonTipOption.ISheriffStartTrack:
				return ISheriffStartTrack.Pack(builder, _o.AsISheriffStartTrack()).Value;
			case TCommonTipOption.ISlashAndTowerTip:
				return ISlashAndTowerTip.Pack(builder, _o.AsISlashAndTowerTip()).Value;
			case TCommonTipOption.ISwordIntentTip:
				return ISwordIntentTip.Pack(builder, _o.AsISwordIntentTip()).Value;
			case TCommonTipOption.ITeachAutoShowEnd:
				return ITeachAutoShowEnd.Pack(builder, _o.AsITeachAutoShowEnd()).Value;
			case TCommonTipOption.ITeachAutoShowStart:
				return ITeachAutoShowStart.Pack(builder, _o.AsITeachAutoShowStart()).Value;
			case TCommonTipOption.ITrapDefenseTip:
				return ITrapDefenseTip.Pack(builder, _o.AsITrapDefenseTip()).Value;
			case TCommonTipOption.IVisionSettlementHardTip:
				return IVisionSettlementHardTip.Pack(builder, _o.AsIVisionSettlementHardTip()).Value;
			case TCommonTipOption.IVisionSettlementTip:
				return IVisionSettlementTip.Pack(builder, _o.AsIVisionSettlementTip()).Value;
			case TCommonTipOption.IWhiteCatWarning:
				return IWhiteCatWarning.Pack(builder, _o.AsIWhiteCatWarning()).Value;
			default:
				return 0;
			}
		}
	}
}
