using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B1F RID: 27423
	public class ICommonTipType_UnionUnion
	{
		// Token: 0x1700C95F RID: 51551
		// (get) Token: 0x0602F26A RID: 193130 RVA: 0x0066DC15 File Offset: 0x0066BE15
		// (set) Token: 0x0602F26B RID: 193131 RVA: 0x0066DC1D File Offset: 0x0066BE1D
		public ICommonTipType_Union Type { get; set; }

		// Token: 0x1700C960 RID: 51552
		// (get) Token: 0x0602F26C RID: 193132 RVA: 0x0066DC26 File Offset: 0x0066BE26
		// (set) Token: 0x0602F26D RID: 193133 RVA: 0x0066DC2E File Offset: 0x0066BE2E
		public object Value { get; set; }

		// Token: 0x0602F26E RID: 193134 RVA: 0x0066DC37 File Offset: 0x0066BE37
		public ICommonTipType_UnionUnion()
		{
			this.Type = ICommonTipType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F26F RID: 193135 RVA: 0x0066DC4D File Offset: 0x0066BE4D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F270 RID: 193136 RVA: 0x0066DC5F File Offset: 0x0066BE5F
		public ICommonTipTypeT AsICommonTipType()
		{
			return this.As<ICommonTipTypeT>();
		}

		// Token: 0x0602F271 RID: 193137 RVA: 0x0066DC67 File Offset: 0x0066BE67
		public static ICommonTipType_UnionUnion FromICommonTipType(ICommonTipTypeT _icommontiptype)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipType,
				Value = _icommontiptype
			};
		}

		// Token: 0x0602F272 RID: 193138 RVA: 0x0066DC7C File Offset: 0x0066BE7C
		public ICommonTipChallengeConditionT AsICommonTipChallengeCondition()
		{
			return this.As<ICommonTipChallengeConditionT>();
		}

		// Token: 0x0602F273 RID: 193139 RVA: 0x0066DC84 File Offset: 0x0066BE84
		public static ICommonTipType_UnionUnion FromICommonTipChallengeCondition(ICommonTipChallengeConditionT _icommontipchallengecondition)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipChallengeCondition,
				Value = _icommontipchallengecondition
			};
		}

		// Token: 0x0602F274 RID: 193140 RVA: 0x0066DC99 File Offset: 0x0066BE99
		public ICommonTipChallengeSuccessT AsICommonTipChallengeSuccess()
		{
			return this.As<ICommonTipChallengeSuccessT>();
		}

		// Token: 0x0602F275 RID: 193141 RVA: 0x0066DCA1 File Offset: 0x0066BEA1
		public static ICommonTipType_UnionUnion FromICommonTipChallengeSuccess(ICommonTipChallengeSuccessT _icommontipchallengesuccess)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipChallengeSuccess,
				Value = _icommontipchallengesuccess
			};
		}

		// Token: 0x0602F276 RID: 193142 RVA: 0x0066DCB6 File Offset: 0x0066BEB6
		public ICommonTipChallengeFailT AsICommonTipChallengeFail()
		{
			return this.As<ICommonTipChallengeFailT>();
		}

		// Token: 0x0602F277 RID: 193143 RVA: 0x0066DCBE File Offset: 0x0066BEBE
		public static ICommonTipType_UnionUnion FromICommonTipChallengeFail(ICommonTipChallengeFailT _icommontipchallengefail)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipChallengeFail,
				Value = _icommontipchallengefail
			};
		}

		// Token: 0x0602F278 RID: 193144 RVA: 0x0066DCD3 File Offset: 0x0066BED3
		public ICommonTipReachChallengeT AsICommonTipReachChallenge()
		{
			return this.As<ICommonTipReachChallengeT>();
		}

		// Token: 0x0602F279 RID: 193145 RVA: 0x0066DCDB File Offset: 0x0066BEDB
		public static ICommonTipType_UnionUnion FromICommonTipReachChallenge(ICommonTipReachChallengeT _icommontipreachchallenge)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipReachChallenge,
				Value = _icommontipreachchallenge
			};
		}

		// Token: 0x0602F27A RID: 193146 RVA: 0x0066DCF0 File Offset: 0x0066BEF0
		public ICommonTipTriggerDelegationT AsICommonTipTriggerDelegation()
		{
			return this.As<ICommonTipTriggerDelegationT>();
		}

		// Token: 0x0602F27B RID: 193147 RVA: 0x0066DCF8 File Offset: 0x0066BEF8
		public static ICommonTipType_UnionUnion FromICommonTipTriggerDelegation(ICommonTipTriggerDelegationT _icommontiptriggerdelegation)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipTriggerDelegation,
				Value = _icommontiptriggerdelegation
			};
		}

		// Token: 0x0602F27C RID: 193148 RVA: 0x0066DD0D File Offset: 0x0066BF0D
		public ICommonTipMissionCompleteT AsICommonTipMissionComplete()
		{
			return this.As<ICommonTipMissionCompleteT>();
		}

		// Token: 0x0602F27D RID: 193149 RVA: 0x0066DD15 File Offset: 0x0066BF15
		public static ICommonTipType_UnionUnion FromICommonTipMissionComplete(ICommonTipMissionCompleteT _icommontipmissioncomplete)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipMissionComplete,
				Value = _icommontipmissioncomplete
			};
		}

		// Token: 0x0602F27E RID: 193150 RVA: 0x0066DD2A File Offset: 0x0066BF2A
		public ICommonTipMissionCompleteNewT AsICommonTipMissionCompleteNew()
		{
			return this.As<ICommonTipMissionCompleteNewT>();
		}

		// Token: 0x0602F27F RID: 193151 RVA: 0x0066DD32 File Offset: 0x0066BF32
		public static ICommonTipType_UnionUnion FromICommonTipMissionCompleteNew(ICommonTipMissionCompleteNewT _icommontipmissioncompletenew)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipMissionCompleteNew,
				Value = _icommontipmissioncompletenew
			};
		}

		// Token: 0x0602F280 RID: 193152 RVA: 0x0066DD47 File Offset: 0x0066BF47
		public ICommonTipGeneralFloatingTipT AsICommonTipGeneralFloatingTip()
		{
			return this.As<ICommonTipGeneralFloatingTipT>();
		}

		// Token: 0x0602F281 RID: 193153 RVA: 0x0066DD4F File Offset: 0x0066BF4F
		public static ICommonTipType_UnionUnion FromICommonTipGeneralFloatingTip(ICommonTipGeneralFloatingTipT _icommontipgeneralfloatingtip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipGeneralFloatingTip,
				Value = _icommontipgeneralfloatingtip
			};
		}

		// Token: 0x0602F282 RID: 193154 RVA: 0x0066DD65 File Offset: 0x0066BF65
		public ICommonTipIdT AsICommonTipId()
		{
			return this.As<ICommonTipIdT>();
		}

		// Token: 0x0602F283 RID: 193155 RVA: 0x0066DD6D File Offset: 0x0066BF6D
		public static ICommonTipType_UnionUnion FromICommonTipId(ICommonTipIdT _icommontipid)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipId,
				Value = _icommontipid
			};
		}

		// Token: 0x0602F284 RID: 193156 RVA: 0x0066DD83 File Offset: 0x0066BF83
		public ICommonTipPrepareCountdownT AsICommonTipPrepareCountdown()
		{
			return this.As<ICommonTipPrepareCountdownT>();
		}

		// Token: 0x0602F285 RID: 193157 RVA: 0x0066DD8B File Offset: 0x0066BF8B
		public static ICommonTipType_UnionUnion FromICommonTipPrepareCountdown(ICommonTipPrepareCountdownT _icommontippreparecountdown)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipPrepareCountdown,
				Value = _icommontippreparecountdown
			};
		}

		// Token: 0x0602F286 RID: 193158 RVA: 0x0066DDA1 File Offset: 0x0066BFA1
		public ICommonTipEnterInRangeT AsICommonTipEnterInRange()
		{
			return this.As<ICommonTipEnterInRangeT>();
		}

		// Token: 0x0602F287 RID: 193159 RVA: 0x0066DDA9 File Offset: 0x0066BFA9
		public static ICommonTipType_UnionUnion FromICommonTipEnterInRange(ICommonTipEnterInRangeT _icommontipenterinrange)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipEnterInRange,
				Value = _icommontipenterinrange
			};
		}

		// Token: 0x0602F288 RID: 193160 RVA: 0x0066DDBF File Offset: 0x0066BFBF
		public ICommonTipFirstCompleteT AsICommonTipFirstComplete()
		{
			return this.As<ICommonTipFirstCompleteT>();
		}

		// Token: 0x0602F289 RID: 193161 RVA: 0x0066DDC7 File Offset: 0x0066BFC7
		public static ICommonTipType_UnionUnion FromICommonTipFirstComplete(ICommonTipFirstCompleteT _icommontipfirstcomplete)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ICommonTipFirstComplete,
				Value = _icommontipfirstcomplete
			};
		}

		// Token: 0x0602F28A RID: 193162 RVA: 0x0066DDDD File Offset: 0x0066BFDD
		public IRemainStarWarningT AsIRemainStarWarning()
		{
			return this.As<IRemainStarWarningT>();
		}

		// Token: 0x0602F28B RID: 193163 RVA: 0x0066DDE5 File Offset: 0x0066BFE5
		public static ICommonTipType_UnionUnion FromIRemainStarWarning(IRemainStarWarningT _iremainstarwarning)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IRemainStarWarning,
				Value = _iremainstarwarning
			};
		}

		// Token: 0x0602F28C RID: 193164 RVA: 0x0066DDFB File Offset: 0x0066BFFB
		public ISlashAndTowerTipT AsISlashAndTowerTip()
		{
			return this.As<ISlashAndTowerTipT>();
		}

		// Token: 0x0602F28D RID: 193165 RVA: 0x0066DE03 File Offset: 0x0066C003
		public static ICommonTipType_UnionUnion FromISlashAndTowerTip(ISlashAndTowerTipT _islashandtowertip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ISlashAndTowerTip,
				Value = _islashandtowertip
			};
		}

		// Token: 0x0602F28E RID: 193166 RVA: 0x0066DE19 File Offset: 0x0066C019
		public IDreamlessWarningT AsIDreamlessWarning()
		{
			return this.As<IDreamlessWarningT>();
		}

		// Token: 0x0602F28F RID: 193167 RVA: 0x0066DE21 File Offset: 0x0066C021
		public static ICommonTipType_UnionUnion FromIDreamlessWarning(IDreamlessWarningT _idreamlesswarning)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IDreamlessWarning,
				Value = _idreamlesswarning
			};
		}

		// Token: 0x0602F290 RID: 193168 RVA: 0x0066DE37 File Offset: 0x0066C037
		public IBlackCatWarningT AsIBlackCatWarning()
		{
			return this.As<IBlackCatWarningT>();
		}

		// Token: 0x0602F291 RID: 193169 RVA: 0x0066DE3F File Offset: 0x0066C03F
		public static ICommonTipType_UnionUnion FromIBlackCatWarning(IBlackCatWarningT _iblackcatwarning)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IBlackCatWarning,
				Value = _iblackcatwarning
			};
		}

		// Token: 0x0602F292 RID: 193170 RVA: 0x0066DE55 File Offset: 0x0066C055
		public IWhiteCatWarningT AsIWhiteCatWarning()
		{
			return this.As<IWhiteCatWarningT>();
		}

		// Token: 0x0602F293 RID: 193171 RVA: 0x0066DE5D File Offset: 0x0066C05D
		public static ICommonTipType_UnionUnion FromIWhiteCatWarning(IWhiteCatWarningT _iwhitecatwarning)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IWhiteCatWarning,
				Value = _iwhitecatwarning
			};
		}

		// Token: 0x0602F294 RID: 193172 RVA: 0x0066DE73 File Offset: 0x0066C073
		public IBadBuKingChallengeTipT AsIBadBuKingChallengeTip()
		{
			return this.As<IBadBuKingChallengeTipT>();
		}

		// Token: 0x0602F295 RID: 193173 RVA: 0x0066DE7B File Offset: 0x0066C07B
		public static ICommonTipType_UnionUnion FromIBadBuKingChallengeTip(IBadBuKingChallengeTipT _ibadbukingchallengetip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IBadBuKingChallengeTip,
				Value = _ibadbukingchallengetip
			};
		}

		// Token: 0x0602F296 RID: 193174 RVA: 0x0066DE91 File Offset: 0x0066C091
		public IPunishReportT AsIPunishReport()
		{
			return this.As<IPunishReportT>();
		}

		// Token: 0x0602F297 RID: 193175 RVA: 0x0066DE99 File Offset: 0x0066C099
		public static ICommonTipType_UnionUnion FromIPunishReport(IPunishReportT _ipunishreport)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IPunishReport,
				Value = _ipunishreport
			};
		}

		// Token: 0x0602F298 RID: 193176 RVA: 0x0066DEAF File Offset: 0x0066C0AF
		public IMoraleAreaTipT AsIMoraleAreaTip()
		{
			return this.As<IMoraleAreaTipT>();
		}

		// Token: 0x0602F299 RID: 193177 RVA: 0x0066DEB7 File Offset: 0x0066C0B7
		public static ICommonTipType_UnionUnion FromIMoraleAreaTip(IMoraleAreaTipT _imoraleareatip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IMoraleAreaTip,
				Value = _imoraleareatip
			};
		}

		// Token: 0x0602F29A RID: 193178 RVA: 0x0066DECD File Offset: 0x0066C0CD
		public INightmareLordTipT AsINightmareLordTip()
		{
			return this.As<INightmareLordTipT>();
		}

		// Token: 0x0602F29B RID: 193179 RVA: 0x0066DED5 File Offset: 0x0066C0D5
		public static ICommonTipType_UnionUnion FromINightmareLordTip(INightmareLordTipT _inightmarelordtip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.INightmareLordTip,
				Value = _inightmarelordtip
			};
		}

		// Token: 0x0602F29C RID: 193180 RVA: 0x0066DEEB File Offset: 0x0066C0EB
		public INightmareSpawnPointTipT AsINightmareSpawnPointTip()
		{
			return this.As<INightmareSpawnPointTipT>();
		}

		// Token: 0x0602F29D RID: 193181 RVA: 0x0066DEF3 File Offset: 0x0066C0F3
		public static ICommonTipType_UnionUnion FromINightmareSpawnPointTip(INightmareSpawnPointTipT _inightmarespawnpointtip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.INightmareSpawnPointTip,
				Value = _inightmarespawnpointtip
			};
		}

		// Token: 0x0602F29E RID: 193182 RVA: 0x0066DF09 File Offset: 0x0066C109
		public IGreatSwordChallengeT AsIGreatSwordChallenge()
		{
			return this.As<IGreatSwordChallengeT>();
		}

		// Token: 0x0602F29F RID: 193183 RVA: 0x0066DF11 File Offset: 0x0066C111
		public static ICommonTipType_UnionUnion FromIGreatSwordChallenge(IGreatSwordChallengeT _igreatswordchallenge)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IGreatSwordChallenge,
				Value = _igreatswordchallenge
			};
		}

		// Token: 0x0602F2A0 RID: 193184 RVA: 0x0066DF27 File Offset: 0x0066C127
		public ITrapDefenseTipT AsITrapDefenseTip()
		{
			return this.As<ITrapDefenseTipT>();
		}

		// Token: 0x0602F2A1 RID: 193185 RVA: 0x0066DF2F File Offset: 0x0066C12F
		public static ICommonTipType_UnionUnion FromITrapDefenseTip(ITrapDefenseTipT _itrapdefensetip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ITrapDefenseTip,
				Value = _itrapdefensetip
			};
		}

		// Token: 0x0602F2A2 RID: 193186 RVA: 0x0066DF45 File Offset: 0x0066C145
		public IPhotographicTipT AsIPhotographicTip()
		{
			return this.As<IPhotographicTipT>();
		}

		// Token: 0x0602F2A3 RID: 193187 RVA: 0x0066DF4D File Offset: 0x0066C14D
		public static ICommonTipType_UnionUnion FromIPhotographicTip(IPhotographicTipT _iphotographictip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IPhotographicTip,
				Value = _iphotographictip
			};
		}

		// Token: 0x0602F2A4 RID: 193188 RVA: 0x0066DF63 File Offset: 0x0066C163
		public IVisionSettlementTipT AsIVisionSettlementTip()
		{
			return this.As<IVisionSettlementTipT>();
		}

		// Token: 0x0602F2A5 RID: 193189 RVA: 0x0066DF6B File Offset: 0x0066C16B
		public static ICommonTipType_UnionUnion FromIVisionSettlementTip(IVisionSettlementTipT _ivisionsettlementtip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IVisionSettlementTip,
				Value = _ivisionsettlementtip
			};
		}

		// Token: 0x0602F2A6 RID: 193190 RVA: 0x0066DF81 File Offset: 0x0066C181
		public IVisionSettlementHardTipT AsIVisionSettlementHardTip()
		{
			return this.As<IVisionSettlementHardTipT>();
		}

		// Token: 0x0602F2A7 RID: 193191 RVA: 0x0066DF89 File Offset: 0x0066C189
		public static ICommonTipType_UnionUnion FromIVisionSettlementHardTip(IVisionSettlementHardTipT _ivisionsettlementhardtip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IVisionSettlementHardTip,
				Value = _ivisionsettlementhardtip
			};
		}

		// Token: 0x0602F2A8 RID: 193192 RVA: 0x0066DF9F File Offset: 0x0066C19F
		public IFlipperTipT AsIFlipperTip()
		{
			return this.As<IFlipperTipT>();
		}

		// Token: 0x0602F2A9 RID: 193193 RVA: 0x0066DFA7 File Offset: 0x0066C1A7
		public static ICommonTipType_UnionUnion FromIFlipperTip(IFlipperTipT _iflippertip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IFlipperTip,
				Value = _iflippertip
			};
		}

		// Token: 0x0602F2AA RID: 193194 RVA: 0x0066DFBD File Offset: 0x0066C1BD
		public ISheriffStartTrackT AsISheriffStartTrack()
		{
			return this.As<ISheriffStartTrackT>();
		}

		// Token: 0x0602F2AB RID: 193195 RVA: 0x0066DFC5 File Offset: 0x0066C1C5
		public static ICommonTipType_UnionUnion FromISheriffStartTrack(ISheriffStartTrackT _isheriffstarttrack)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ISheriffStartTrack,
				Value = _isheriffstarttrack
			};
		}

		// Token: 0x0602F2AC RID: 193196 RVA: 0x0066DFDB File Offset: 0x0066C1DB
		public ISheriffCriminalArrestedT AsISheriffCriminalArrested()
		{
			return this.As<ISheriffCriminalArrestedT>();
		}

		// Token: 0x0602F2AD RID: 193197 RVA: 0x0066DFE3 File Offset: 0x0066C1E3
		public static ICommonTipType_UnionUnion FromISheriffCriminalArrested(ISheriffCriminalArrestedT _isheriffcriminalarrested)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ISheriffCriminalArrested,
				Value = _isheriffcriminalarrested
			};
		}

		// Token: 0x0602F2AE RID: 193198 RVA: 0x0066DFF9 File Offset: 0x0066C1F9
		public ISheriffCashSettlementT AsISheriffCashSettlement()
		{
			return this.As<ISheriffCashSettlementT>();
		}

		// Token: 0x0602F2AF RID: 193199 RVA: 0x0066E001 File Offset: 0x0066C201
		public static ICommonTipType_UnionUnion FromISheriffCashSettlement(ISheriffCashSettlementT _isheriffcashsettlement)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ISheriffCashSettlement,
				Value = _isheriffcashsettlement
			};
		}

		// Token: 0x0602F2B0 RID: 193200 RVA: 0x0066E017 File Offset: 0x0066C217
		public ISwordIntentTipT AsISwordIntentTip()
		{
			return this.As<ISwordIntentTipT>();
		}

		// Token: 0x0602F2B1 RID: 193201 RVA: 0x0066E01F File Offset: 0x0066C21F
		public static ICommonTipType_UnionUnion FromISwordIntentTip(ISwordIntentTipT _iswordintenttip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ISwordIntentTip,
				Value = _iswordintenttip
			};
		}

		// Token: 0x0602F2B2 RID: 193202 RVA: 0x0066E035 File Offset: 0x0066C235
		public IRedNameMonsterTipT AsIRedNameMonsterTip()
		{
			return this.As<IRedNameMonsterTipT>();
		}

		// Token: 0x0602F2B3 RID: 193203 RVA: 0x0066E03D File Offset: 0x0066C23D
		public static ICommonTipType_UnionUnion FromIRedNameMonsterTip(IRedNameMonsterTipT _irednamemonstertip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IRedNameMonsterTip,
				Value = _irednamemonstertip
			};
		}

		// Token: 0x0602F2B4 RID: 193204 RVA: 0x0066E053 File Offset: 0x0066C253
		public IRoleTowerStrongEnemyWarningT AsIRoleTowerStrongEnemyWarning()
		{
			return this.As<IRoleTowerStrongEnemyWarningT>();
		}

		// Token: 0x0602F2B5 RID: 193205 RVA: 0x0066E05B File Offset: 0x0066C25B
		public static ICommonTipType_UnionUnion FromIRoleTowerStrongEnemyWarning(IRoleTowerStrongEnemyWarningT _iroletowerstrongenemywarning)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IRoleTowerStrongEnemyWarning,
				Value = _iroletowerstrongenemywarning
			};
		}

		// Token: 0x0602F2B6 RID: 193206 RVA: 0x0066E071 File Offset: 0x0066C271
		public ITeachAutoShowStartT AsITeachAutoShowStart()
		{
			return this.As<ITeachAutoShowStartT>();
		}

		// Token: 0x0602F2B7 RID: 193207 RVA: 0x0066E079 File Offset: 0x0066C279
		public static ICommonTipType_UnionUnion FromITeachAutoShowStart(ITeachAutoShowStartT _iteachautoshowstart)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ITeachAutoShowStart,
				Value = _iteachautoshowstart
			};
		}

		// Token: 0x0602F2B8 RID: 193208 RVA: 0x0066E08F File Offset: 0x0066C28F
		public ITeachAutoShowEndT AsITeachAutoShowEnd()
		{
			return this.As<ITeachAutoShowEndT>();
		}

		// Token: 0x0602F2B9 RID: 193209 RVA: 0x0066E097 File Offset: 0x0066C297
		public static ICommonTipType_UnionUnion FromITeachAutoShowEnd(ITeachAutoShowEndT _iteachautoshowend)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.ITeachAutoShowEnd,
				Value = _iteachautoshowend
			};
		}

		// Token: 0x0602F2BA RID: 193210 RVA: 0x0066E0AD File Offset: 0x0066C2AD
		public IFrequencyDetectionTipT AsIFrequencyDetectionTip()
		{
			return this.As<IFrequencyDetectionTipT>();
		}

		// Token: 0x0602F2BB RID: 193211 RVA: 0x0066E0B5 File Offset: 0x0066C2B5
		public static ICommonTipType_UnionUnion FromIFrequencyDetectionTip(IFrequencyDetectionTipT _ifrequencydetectiontip)
		{
			return new ICommonTipType_UnionUnion
			{
				Type = ICommonTipType_Union.IFrequencyDetectionTip,
				Value = _ifrequencydetectiontip
			};
		}

		// Token: 0x0602F2BC RID: 193212 RVA: 0x0066E0CC File Offset: 0x0066C2CC
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
			case ICommonTipType_Union.IRedNameMonsterTip:
				return IRedNameMonsterTip.Pack(builder, _o.AsIRedNameMonsterTip()).Value;
			case ICommonTipType_Union.IRoleTowerStrongEnemyWarning:
				return IRoleTowerStrongEnemyWarning.Pack(builder, _o.AsIRoleTowerStrongEnemyWarning()).Value;
			case ICommonTipType_Union.ITeachAutoShowStart:
				return ITeachAutoShowStart.Pack(builder, _o.AsITeachAutoShowStart()).Value;
			case ICommonTipType_Union.ITeachAutoShowEnd:
				return ITeachAutoShowEnd.Pack(builder, _o.AsITeachAutoShowEnd()).Value;
			case ICommonTipType_Union.IFrequencyDetectionTip:
				return IFrequencyDetectionTip.Pack(builder, _o.AsIFrequencyDetectionTip()).Value;
			default:
				return 0;
			}
		}
	}
}
