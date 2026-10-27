using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064B4 RID: 25780
	public class ICommonTipType_UnionUnion
	{
		// Token: 0x1700BFD2 RID: 49106
		// (get) Token: 0x0602CAF0 RID: 183024 RVA: 0x00622041 File Offset: 0x00620241
		// (set) Token: 0x0602CAF1 RID: 183025 RVA: 0x00622049 File Offset: 0x00620249
		public ICommonTipType_Union Type { get; set; }

		// Token: 0x1700BFD3 RID: 49107
		// (get) Token: 0x0602CAF2 RID: 183026 RVA: 0x00622052 File Offset: 0x00620252
		// (set) Token: 0x0602CAF3 RID: 183027 RVA: 0x0062205A File Offset: 0x0062025A
		public object Value { get; set; }

		// Token: 0x0602CAF4 RID: 183028 RVA: 0x00622063 File Offset: 0x00620263
		public ICommonTipType_UnionUnion()
		{
			this.Type = ICommonTipType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CAF5 RID: 183029 RVA: 0x00622079 File Offset: 0x00620279
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CAF6 RID: 183030 RVA: 0x0062208B File Offset: 0x0062028B
		public ICommonTipTypeT AsICommonTipType()
		{
			return this.As<ICommonTipTypeT>();
		}

		// Token: 0x0602CAF7 RID: 183031 RVA: 0x00622093 File Offset: 0x00620293
		public static ICommonTipType_UnionUnion FromICommonTipType(ICommonTipTypeT _icommontiptype)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipType,
				Value = _icommontiptype
			};
		}

		// Token: 0x0602CAF8 RID: 183032 RVA: 0x006220A8 File Offset: 0x006202A8
		public ICommonTipChallengeConditionT AsICommonTipChallengeCondition()
		{
			return this.As<ICommonTipChallengeConditionT>();
		}

		// Token: 0x0602CAF9 RID: 183033 RVA: 0x006220B0 File Offset: 0x006202B0
		public static ICommonTipType_UnionUnion FromICommonTipChallengeCondition(ICommonTipChallengeConditionT _icommontipchallengecondition)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipChallengeCondition,
				Value = _icommontipchallengecondition
			};
		}

		// Token: 0x0602CAFA RID: 183034 RVA: 0x006220C5 File Offset: 0x006202C5
		public ICommonTipChallengeSuccessT AsICommonTipChallengeSuccess()
		{
			return this.As<ICommonTipChallengeSuccessT>();
		}

		// Token: 0x0602CAFB RID: 183035 RVA: 0x006220CD File Offset: 0x006202CD
		public static ICommonTipType_UnionUnion FromICommonTipChallengeSuccess(ICommonTipChallengeSuccessT _icommontipchallengesuccess)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipChallengeSuccess,
				Value = _icommontipchallengesuccess
			};
		}

		// Token: 0x0602CAFC RID: 183036 RVA: 0x006220E2 File Offset: 0x006202E2
		public ICommonTipChallengeFailT AsICommonTipChallengeFail()
		{
			return this.As<ICommonTipChallengeFailT>();
		}

		// Token: 0x0602CAFD RID: 183037 RVA: 0x006220EA File Offset: 0x006202EA
		public static ICommonTipType_UnionUnion FromICommonTipChallengeFail(ICommonTipChallengeFailT _icommontipchallengefail)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipChallengeFail,
				Value = _icommontipchallengefail
			};
		}

		// Token: 0x0602CAFE RID: 183038 RVA: 0x006220FF File Offset: 0x006202FF
		public ICommonTipReachChallengeT AsICommonTipReachChallenge()
		{
			return this.As<ICommonTipReachChallengeT>();
		}

		// Token: 0x0602CAFF RID: 183039 RVA: 0x00622107 File Offset: 0x00620307
		public static ICommonTipType_UnionUnion FromICommonTipReachChallenge(ICommonTipReachChallengeT _icommontipreachchallenge)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipReachChallenge,
				Value = _icommontipreachchallenge
			};
		}

		// Token: 0x0602CB00 RID: 183040 RVA: 0x0062211C File Offset: 0x0062031C
		public ICommonTipTriggerDelegationT AsICommonTipTriggerDelegation()
		{
			return this.As<ICommonTipTriggerDelegationT>();
		}

		// Token: 0x0602CB01 RID: 183041 RVA: 0x00622124 File Offset: 0x00620324
		public static ICommonTipType_UnionUnion FromICommonTipTriggerDelegation(ICommonTipTriggerDelegationT _icommontiptriggerdelegation)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipTriggerDelegation,
				Value = _icommontiptriggerdelegation
			};
		}

		// Token: 0x0602CB02 RID: 183042 RVA: 0x00622139 File Offset: 0x00620339
		public ICommonTipMissionCompleteT AsICommonTipMissionComplete()
		{
			return this.As<ICommonTipMissionCompleteT>();
		}

		// Token: 0x0602CB03 RID: 183043 RVA: 0x00622141 File Offset: 0x00620341
		public static ICommonTipType_UnionUnion FromICommonTipMissionComplete(ICommonTipMissionCompleteT _icommontipmissioncomplete)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipMissionComplete,
				Value = _icommontipmissioncomplete
			};
		}

		// Token: 0x0602CB04 RID: 183044 RVA: 0x00622156 File Offset: 0x00620356
		public ICommonTipMissionCompleteNewT AsICommonTipMissionCompleteNew()
		{
			return this.As<ICommonTipMissionCompleteNewT>();
		}

		// Token: 0x0602CB05 RID: 183045 RVA: 0x0062215E File Offset: 0x0062035E
		public static ICommonTipType_UnionUnion FromICommonTipMissionCompleteNew(ICommonTipMissionCompleteNewT _icommontipmissioncompletenew)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipMissionCompleteNew,
				Value = _icommontipmissioncompletenew
			};
		}

		// Token: 0x0602CB06 RID: 183046 RVA: 0x00622173 File Offset: 0x00620373
		public ICommonTipGeneralFloatingTipT AsICommonTipGeneralFloatingTip()
		{
			return this.As<ICommonTipGeneralFloatingTipT>();
		}

		// Token: 0x0602CB07 RID: 183047 RVA: 0x0062217B File Offset: 0x0062037B
		public static ICommonTipType_UnionUnion FromICommonTipGeneralFloatingTip(ICommonTipGeneralFloatingTipT _icommontipgeneralfloatingtip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipGeneralFloatingTip,
				Value = _icommontipgeneralfloatingtip
			};
		}

		// Token: 0x0602CB08 RID: 183048 RVA: 0x00622191 File Offset: 0x00620391
		public ICommonTipIdT AsICommonTipId()
		{
			return this.As<ICommonTipIdT>();
		}

		// Token: 0x0602CB09 RID: 183049 RVA: 0x00622199 File Offset: 0x00620399
		public static ICommonTipType_UnionUnion FromICommonTipId(ICommonTipIdT _icommontipid)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipId,
				Value = _icommontipid
			};
		}

		// Token: 0x0602CB0A RID: 183050 RVA: 0x006221AF File Offset: 0x006203AF
		public ICommonTipPrepareCountdownT AsICommonTipPrepareCountdown()
		{
			return this.As<ICommonTipPrepareCountdownT>();
		}

		// Token: 0x0602CB0B RID: 183051 RVA: 0x006221B7 File Offset: 0x006203B7
		public static ICommonTipType_UnionUnion FromICommonTipPrepareCountdown(ICommonTipPrepareCountdownT _icommontippreparecountdown)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipPrepareCountdown,
				Value = _icommontippreparecountdown
			};
		}

		// Token: 0x0602CB0C RID: 183052 RVA: 0x006221CD File Offset: 0x006203CD
		public ICommonTipEnterInRangeT AsICommonTipEnterInRange()
		{
			return this.As<ICommonTipEnterInRangeT>();
		}

		// Token: 0x0602CB0D RID: 183053 RVA: 0x006221D5 File Offset: 0x006203D5
		public static ICommonTipType_UnionUnion FromICommonTipEnterInRange(ICommonTipEnterInRangeT _icommontipenterinrange)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipEnterInRange,
				Value = _icommontipenterinrange
			};
		}

		// Token: 0x0602CB0E RID: 183054 RVA: 0x006221EB File Offset: 0x006203EB
		public ICommonTipFirstCompleteT AsICommonTipFirstComplete()
		{
			return this.As<ICommonTipFirstCompleteT>();
		}

		// Token: 0x0602CB0F RID: 183055 RVA: 0x006221F3 File Offset: 0x006203F3
		public static ICommonTipType_UnionUnion FromICommonTipFirstComplete(ICommonTipFirstCompleteT _icommontipfirstcomplete)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipFirstComplete,
				Value = _icommontipfirstcomplete
			};
		}

		// Token: 0x0602CB10 RID: 183056 RVA: 0x00622209 File Offset: 0x00620409
		public IRemainStarWarningT AsIRemainStarWarning()
		{
			return this.As<IRemainStarWarningT>();
		}

		// Token: 0x0602CB11 RID: 183057 RVA: 0x00622211 File Offset: 0x00620411
		public static ICommonTipType_UnionUnion FromIRemainStarWarning(IRemainStarWarningT _iremainstarwarning)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IRemainStarWarning,
				Value = _iremainstarwarning
			};
		}

		// Token: 0x0602CB12 RID: 183058 RVA: 0x00622227 File Offset: 0x00620427
		public ISlashAndTowerTipT AsISlashAndTowerTip()
		{
			return this.As<ISlashAndTowerTipT>();
		}

		// Token: 0x0602CB13 RID: 183059 RVA: 0x0062222F File Offset: 0x0062042F
		public static ICommonTipType_UnionUnion FromISlashAndTowerTip(ISlashAndTowerTipT _islashandtowertip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ISlashAndTowerTip,
				Value = _islashandtowertip
			};
		}

		// Token: 0x0602CB14 RID: 183060 RVA: 0x00622245 File Offset: 0x00620445
		public IDreamlessWarningT AsIDreamlessWarning()
		{
			return this.As<IDreamlessWarningT>();
		}

		// Token: 0x0602CB15 RID: 183061 RVA: 0x0062224D File Offset: 0x0062044D
		public static ICommonTipType_UnionUnion FromIDreamlessWarning(IDreamlessWarningT _idreamlesswarning)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IDreamlessWarning,
				Value = _idreamlesswarning
			};
		}

		// Token: 0x0602CB16 RID: 183062 RVA: 0x00622263 File Offset: 0x00620463
		public IBlackCatWarningT AsIBlackCatWarning()
		{
			return this.As<IBlackCatWarningT>();
		}

		// Token: 0x0602CB17 RID: 183063 RVA: 0x0062226B File Offset: 0x0062046B
		public static ICommonTipType_UnionUnion FromIBlackCatWarning(IBlackCatWarningT _iblackcatwarning)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IBlackCatWarning,
				Value = _iblackcatwarning
			};
		}

		// Token: 0x0602CB18 RID: 183064 RVA: 0x00622281 File Offset: 0x00620481
		public IWhiteCatWarningT AsIWhiteCatWarning()
		{
			return this.As<IWhiteCatWarningT>();
		}

		// Token: 0x0602CB19 RID: 183065 RVA: 0x00622289 File Offset: 0x00620489
		public static ICommonTipType_UnionUnion FromIWhiteCatWarning(IWhiteCatWarningT _iwhitecatwarning)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IWhiteCatWarning,
				Value = _iwhitecatwarning
			};
		}

		// Token: 0x0602CB1A RID: 183066 RVA: 0x0062229F File Offset: 0x0062049F
		public IBadBuKingChallengeTipT AsIBadBuKingChallengeTip()
		{
			return this.As<IBadBuKingChallengeTipT>();
		}

		// Token: 0x0602CB1B RID: 183067 RVA: 0x006222A7 File Offset: 0x006204A7
		public static ICommonTipType_UnionUnion FromIBadBuKingChallengeTip(IBadBuKingChallengeTipT _ibadbukingchallengetip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IBadBuKingChallengeTip,
				Value = _ibadbukingchallengetip
			};
		}

		// Token: 0x0602CB1C RID: 183068 RVA: 0x006222BD File Offset: 0x006204BD
		public IPunishReportT AsIPunishReport()
		{
			return this.As<IPunishReportT>();
		}

		// Token: 0x0602CB1D RID: 183069 RVA: 0x006222C5 File Offset: 0x006204C5
		public static ICommonTipType_UnionUnion FromIPunishReport(IPunishReportT _ipunishreport)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IPunishReport,
				Value = _ipunishreport
			};
		}

		// Token: 0x0602CB1E RID: 183070 RVA: 0x006222DB File Offset: 0x006204DB
		public IMoraleAreaTipT AsIMoraleAreaTip()
		{
			return this.As<IMoraleAreaTipT>();
		}

		// Token: 0x0602CB1F RID: 183071 RVA: 0x006222E3 File Offset: 0x006204E3
		public static ICommonTipType_UnionUnion FromIMoraleAreaTip(IMoraleAreaTipT _imoraleareatip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IMoraleAreaTip,
				Value = _imoraleareatip
			};
		}

		// Token: 0x0602CB20 RID: 183072 RVA: 0x006222F9 File Offset: 0x006204F9
		public INightmareLordTipT AsINightmareLordTip()
		{
			return this.As<INightmareLordTipT>();
		}

		// Token: 0x0602CB21 RID: 183073 RVA: 0x00622301 File Offset: 0x00620501
		public static ICommonTipType_UnionUnion FromINightmareLordTip(INightmareLordTipT _inightmarelordtip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.INightmareLordTip,
				Value = _inightmarelordtip
			};
		}

		// Token: 0x0602CB22 RID: 183074 RVA: 0x00622317 File Offset: 0x00620517
		public INightmareSpawnPointTipT AsINightmareSpawnPointTip()
		{
			return this.As<INightmareSpawnPointTipT>();
		}

		// Token: 0x0602CB23 RID: 183075 RVA: 0x0062231F File Offset: 0x0062051F
		public static ICommonTipType_UnionUnion FromINightmareSpawnPointTip(INightmareSpawnPointTipT _inightmarespawnpointtip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.INightmareSpawnPointTip,
				Value = _inightmarespawnpointtip
			};
		}

		// Token: 0x0602CB24 RID: 183076 RVA: 0x00622335 File Offset: 0x00620535
		public IGreatSwordChallengeT AsIGreatSwordChallenge()
		{
			return this.As<IGreatSwordChallengeT>();
		}

		// Token: 0x0602CB25 RID: 183077 RVA: 0x0062233D File Offset: 0x0062053D
		public static ICommonTipType_UnionUnion FromIGreatSwordChallenge(IGreatSwordChallengeT _igreatswordchallenge)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IGreatSwordChallenge,
				Value = _igreatswordchallenge
			};
		}

		// Token: 0x0602CB26 RID: 183078 RVA: 0x00622353 File Offset: 0x00620553
		public ITrapDefenseTipT AsITrapDefenseTip()
		{
			return this.As<ITrapDefenseTipT>();
		}

		// Token: 0x0602CB27 RID: 183079 RVA: 0x0062235B File Offset: 0x0062055B
		public static ICommonTipType_UnionUnion FromITrapDefenseTip(ITrapDefenseTipT _itrapdefensetip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ITrapDefenseTip,
				Value = _itrapdefensetip
			};
		}

		// Token: 0x0602CB28 RID: 183080 RVA: 0x00622371 File Offset: 0x00620571
		public IPhotographicTipT AsIPhotographicTip()
		{
			return this.As<IPhotographicTipT>();
		}

		// Token: 0x0602CB29 RID: 183081 RVA: 0x00622379 File Offset: 0x00620579
		public static ICommonTipType_UnionUnion FromIPhotographicTip(IPhotographicTipT _iphotographictip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IPhotographicTip,
				Value = _iphotographictip
			};
		}

		// Token: 0x0602CB2A RID: 183082 RVA: 0x0062238F File Offset: 0x0062058F
		public IVisionSettlementTipT AsIVisionSettlementTip()
		{
			return this.As<IVisionSettlementTipT>();
		}

		// Token: 0x0602CB2B RID: 183083 RVA: 0x00622397 File Offset: 0x00620597
		public static ICommonTipType_UnionUnion FromIVisionSettlementTip(IVisionSettlementTipT _ivisionsettlementtip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IVisionSettlementTip,
				Value = _ivisionsettlementtip
			};
		}

		// Token: 0x0602CB2C RID: 183084 RVA: 0x006223AD File Offset: 0x006205AD
		public IVisionSettlementHardTipT AsIVisionSettlementHardTip()
		{
			return this.As<IVisionSettlementHardTipT>();
		}

		// Token: 0x0602CB2D RID: 183085 RVA: 0x006223B5 File Offset: 0x006205B5
		public static ICommonTipType_UnionUnion FromIVisionSettlementHardTip(IVisionSettlementHardTipT _ivisionsettlementhardtip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IVisionSettlementHardTip,
				Value = _ivisionsettlementhardtip
			};
		}

		// Token: 0x0602CB2E RID: 183086 RVA: 0x006223CB File Offset: 0x006205CB
		public IFlipperTipT AsIFlipperTip()
		{
			return this.As<IFlipperTipT>();
		}

		// Token: 0x0602CB2F RID: 183087 RVA: 0x006223D3 File Offset: 0x006205D3
		public static ICommonTipType_UnionUnion FromIFlipperTip(IFlipperTipT _iflippertip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IFlipperTip,
				Value = _iflippertip
			};
		}

		// Token: 0x0602CB30 RID: 183088 RVA: 0x006223E9 File Offset: 0x006205E9
		public ISheriffStartTrackT AsISheriffStartTrack()
		{
			return this.As<ISheriffStartTrackT>();
		}

		// Token: 0x0602CB31 RID: 183089 RVA: 0x006223F1 File Offset: 0x006205F1
		public static ICommonTipType_UnionUnion FromISheriffStartTrack(ISheriffStartTrackT _isheriffstarttrack)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ISheriffStartTrack,
				Value = _isheriffstarttrack
			};
		}

		// Token: 0x0602CB32 RID: 183090 RVA: 0x00622407 File Offset: 0x00620607
		public ISheriffCriminalArrestedT AsISheriffCriminalArrested()
		{
			return this.As<ISheriffCriminalArrestedT>();
		}

		// Token: 0x0602CB33 RID: 183091 RVA: 0x0062240F File Offset: 0x0062060F
		public static ICommonTipType_UnionUnion FromISheriffCriminalArrested(ISheriffCriminalArrestedT _isheriffcriminalarrested)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ISheriffCriminalArrested,
				Value = _isheriffcriminalarrested
			};
		}

		// Token: 0x0602CB34 RID: 183092 RVA: 0x00622425 File Offset: 0x00620625
		public ISheriffCashSettlementT AsISheriffCashSettlement()
		{
			return this.As<ISheriffCashSettlementT>();
		}

		// Token: 0x0602CB35 RID: 183093 RVA: 0x0062242D File Offset: 0x0062062D
		public static ICommonTipType_UnionUnion FromISheriffCashSettlement(ISheriffCashSettlementT _isheriffcashsettlement)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ISheriffCashSettlement,
				Value = _isheriffcashsettlement
			};
		}

		// Token: 0x0602CB36 RID: 183094 RVA: 0x00622443 File Offset: 0x00620643
		public ISwordIntentTipT AsISwordIntentTip()
		{
			return this.As<ISwordIntentTipT>();
		}

		// Token: 0x0602CB37 RID: 183095 RVA: 0x0062244B File Offset: 0x0062064B
		public static ICommonTipType_UnionUnion FromISwordIntentTip(ISwordIntentTipT _iswordintenttip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ISwordIntentTip,
				Value = _iswordintenttip
			};
		}

		// Token: 0x0602CB38 RID: 183096 RVA: 0x00622464 File Offset: 0x00620664
		public static int Pack(FlatBufferBuilder builder, ICommonTipType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICommonTipType_Union.ICommonTipType:
				return ICommonTipType.Pack(builder, _o.AsICommonTipType()).Value;
			case ICommonTipType_Union.ICommonTipChallengeCondition:
				return ICommonTipChallengeCondition.Pack(builder, _o.AsICommonTipChallengeCondition()).Value;
			case ICommonTipType_Union.ICommonTipChallengeSuccess:
				return ICommonTipChallengeSuccess.Pack(builder, _o.AsICommonTipChallengeSuccess()).Value;
			case ICommonTipType_Union.ICommonTipChallengeFail:
				return ICommonTipChallengeFail.Pack(builder, _o.AsICommonTipChallengeFail()).Value;
			case ICommonTipType_Union.ICommonTipReachChallenge:
				return ICommonTipReachChallenge.Pack(builder, _o.AsICommonTipReachChallenge()).Value;
			case ICommonTipType_Union.ICommonTipTriggerDelegation:
				return ICommonTipTriggerDelegation.Pack(builder, _o.AsICommonTipTriggerDelegation()).Value;
			case ICommonTipType_Union.ICommonTipMissionComplete:
				return ICommonTipMissionComplete.Pack(builder, _o.AsICommonTipMissionComplete()).Value;
			case ICommonTipType_Union.ICommonTipMissionCompleteNew:
				return ICommonTipMissionCompleteNew.Pack(builder, _o.AsICommonTipMissionCompleteNew()).Value;
			case ICommonTipType_Union.ICommonTipGeneralFloatingTip:
				return ICommonTipGeneralFloatingTip.Pack(builder, _o.AsICommonTipGeneralFloatingTip()).Value;
			case ICommonTipType_Union.ICommonTipId:
				return ICommonTipId.Pack(builder, _o.AsICommonTipId()).Value;
			case ICommonTipType_Union.ICommonTipPrepareCountdown:
				return ICommonTipPrepareCountdown.Pack(builder, _o.AsICommonTipPrepareCountdown()).Value;
			case ICommonTipType_Union.ICommonTipEnterInRange:
				return ICommonTipEnterInRange.Pack(builder, _o.AsICommonTipEnterInRange()).Value;
			case ICommonTipType_Union.ICommonTipFirstComplete:
				return ICommonTipFirstComplete.Pack(builder, _o.AsICommonTipFirstComplete()).Value;
			case ICommonTipType_Union.IRemainStarWarning:
				return IRemainStarWarning.Pack(builder, _o.AsIRemainStarWarning()).Value;
			case ICommonTipType_Union.ISlashAndTowerTip:
				return ISlashAndTowerTip.Pack(builder, _o.AsISlashAndTowerTip()).Value;
			case ICommonTipType_Union.IDreamlessWarning:
				return IDreamlessWarning.Pack(builder, _o.AsIDreamlessWarning()).Value;
			case ICommonTipType_Union.IBlackCatWarning:
				return IBlackCatWarning.Pack(builder, _o.AsIBlackCatWarning()).Value;
			case ICommonTipType_Union.IWhiteCatWarning:
				return IWhiteCatWarning.Pack(builder, _o.AsIWhiteCatWarning()).Value;
			case ICommonTipType_Union.IBadBuKingChallengeTip:
				return IBadBuKingChallengeTip.Pack(builder, _o.AsIBadBuKingChallengeTip()).Value;
			case ICommonTipType_Union.IPunishReport:
				return IPunishReport.Pack(builder, _o.AsIPunishReport()).Value;
			case ICommonTipType_Union.IMoraleAreaTip:
				return IMoraleAreaTip.Pack(builder, _o.AsIMoraleAreaTip()).Value;
			case ICommonTipType_Union.INightmareLordTip:
				return INightmareLordTip.Pack(builder, _o.AsINightmareLordTip()).Value;
			case ICommonTipType_Union.INightmareSpawnPointTip:
				return INightmareSpawnPointTip.Pack(builder, _o.AsINightmareSpawnPointTip()).Value;
			case ICommonTipType_Union.IGreatSwordChallenge:
				return IGreatSwordChallenge.Pack(builder, _o.AsIGreatSwordChallenge()).Value;
			case ICommonTipType_Union.ITrapDefenseTip:
				return ITrapDefenseTip.Pack(builder, _o.AsITrapDefenseTip()).Value;
			case ICommonTipType_Union.IPhotographicTip:
				return IPhotographicTip.Pack(builder, _o.AsIPhotographicTip()).Value;
			case ICommonTipType_Union.IVisionSettlementTip:
				return IVisionSettlementTip.Pack(builder, _o.AsIVisionSettlementTip()).Value;
			case ICommonTipType_Union.IVisionSettlementHardTip:
				return IVisionSettlementHardTip.Pack(builder, _o.AsIVisionSettlementHardTip()).Value;
			case ICommonTipType_Union.IFlipperTip:
				return IFlipperTip.Pack(builder, _o.AsIFlipperTip()).Value;
			case ICommonTipType_Union.ISheriffStartTrack:
				return ISheriffStartTrack.Pack(builder, _o.AsISheriffStartTrack()).Value;
			case ICommonTipType_Union.ISheriffCriminalArrested:
				return ISheriffCriminalArrested.Pack(builder, _o.AsISheriffCriminalArrested()).Value;
			case ICommonTipType_Union.ISheriffCashSettlement:
				return ISheriffCashSettlement.Pack(builder, _o.AsISheriffCashSettlement()).Value;
			case ICommonTipType_Union.ISwordIntentTip:
				return ISwordIntentTip.Pack(builder, _o.AsISwordIntentTip()).Value;
			default:
				return 0;
			}
		}
	}
}
