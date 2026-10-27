using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007690 RID: 30352
	public class TCommonTipOptionUnion
	{
		// Token: 0x1700E5F3 RID: 58867
		// (get) Token: 0x06037378 RID: 226168 RVA: 0x0077BBF6 File Offset: 0x00779DF6
		// (set) Token: 0x06037379 RID: 226169 RVA: 0x0077BBFE File Offset: 0x00779DFE
		public TCommonTipOption Type { get; set; }

		// Token: 0x1700E5F4 RID: 58868
		// (get) Token: 0x0603737A RID: 226170 RVA: 0x0077BC07 File Offset: 0x00779E07
		// (set) Token: 0x0603737B RID: 226171 RVA: 0x0077BC0F File Offset: 0x00779E0F
		public object Value { get; set; }

		// Token: 0x0603737C RID: 226172 RVA: 0x0077BC18 File Offset: 0x00779E18
		public TCommonTipOptionUnion()
		{
			this.Type = TCommonTipOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603737D RID: 226173 RVA: 0x0077BC2E File Offset: 0x00779E2E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603737E RID: 226174 RVA: 0x0077BC40 File Offset: 0x00779E40
		public IBadBuKingChallengeTipT AsIBadBuKingChallengeTip()
		{
			return this.As<IBadBuKingChallengeTipT>();
		}

		// Token: 0x0603737F RID: 226175 RVA: 0x0077BC48 File Offset: 0x00779E48
		public static TCommonTipOptionUnion FromIBadBuKingChallengeTip(IBadBuKingChallengeTipT _ibadbukingchallengetip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IBadBuKingChallengeTip,
				Value = _ibadbukingchallengetip
			};
		}

		// Token: 0x06037380 RID: 226176 RVA: 0x0077BC5D File Offset: 0x00779E5D
		public IBlackCatWarningT AsIBlackCatWarning()
		{
			return this.As<IBlackCatWarningT>();
		}

		// Token: 0x06037381 RID: 226177 RVA: 0x0077BC65 File Offset: 0x00779E65
		public static TCommonTipOptionUnion FromIBlackCatWarning(IBlackCatWarningT _iblackcatwarning)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IBlackCatWarning,
				Value = _iblackcatwarning
			};
		}

		// Token: 0x06037382 RID: 226178 RVA: 0x0077BC7A File Offset: 0x00779E7A
		public ICommonTipChallengeConditionT AsICommonTipChallengeCondition()
		{
			return this.As<ICommonTipChallengeConditionT>();
		}

		// Token: 0x06037383 RID: 226179 RVA: 0x0077BC82 File Offset: 0x00779E82
		public static TCommonTipOptionUnion FromICommonTipChallengeCondition(ICommonTipChallengeConditionT _icommontipchallengecondition)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipChallengeCondition,
				Value = _icommontipchallengecondition
			};
		}

		// Token: 0x06037384 RID: 226180 RVA: 0x0077BC97 File Offset: 0x00779E97
		public ICommonTipChallengeFailT AsICommonTipChallengeFail()
		{
			return this.As<ICommonTipChallengeFailT>();
		}

		// Token: 0x06037385 RID: 226181 RVA: 0x0077BC9F File Offset: 0x00779E9F
		public static TCommonTipOptionUnion FromICommonTipChallengeFail(ICommonTipChallengeFailT _icommontipchallengefail)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipChallengeFail,
				Value = _icommontipchallengefail
			};
		}

		// Token: 0x06037386 RID: 226182 RVA: 0x0077BCB4 File Offset: 0x00779EB4
		public ICommonTipChallengeSuccessT AsICommonTipChallengeSuccess()
		{
			return this.As<ICommonTipChallengeSuccessT>();
		}

		// Token: 0x06037387 RID: 226183 RVA: 0x0077BCBC File Offset: 0x00779EBC
		public static TCommonTipOptionUnion FromICommonTipChallengeSuccess(ICommonTipChallengeSuccessT _icommontipchallengesuccess)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipChallengeSuccess,
				Value = _icommontipchallengesuccess
			};
		}

		// Token: 0x06037388 RID: 226184 RVA: 0x0077BCD1 File Offset: 0x00779ED1
		public ICommonTipEnterInRangeT AsICommonTipEnterInRange()
		{
			return this.As<ICommonTipEnterInRangeT>();
		}

		// Token: 0x06037389 RID: 226185 RVA: 0x0077BCD9 File Offset: 0x00779ED9
		public static TCommonTipOptionUnion FromICommonTipEnterInRange(ICommonTipEnterInRangeT _icommontipenterinrange)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipEnterInRange,
				Value = _icommontipenterinrange
			};
		}

		// Token: 0x0603738A RID: 226186 RVA: 0x0077BCEE File Offset: 0x00779EEE
		public ICommonTipFirstCompleteT AsICommonTipFirstComplete()
		{
			return this.As<ICommonTipFirstCompleteT>();
		}

		// Token: 0x0603738B RID: 226187 RVA: 0x0077BCF6 File Offset: 0x00779EF6
		public static TCommonTipOptionUnion FromICommonTipFirstComplete(ICommonTipFirstCompleteT _icommontipfirstcomplete)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipFirstComplete,
				Value = _icommontipfirstcomplete
			};
		}

		// Token: 0x0603738C RID: 226188 RVA: 0x0077BD0B File Offset: 0x00779F0B
		public ICommonTipGeneralFloatingTipT AsICommonTipGeneralFloatingTip()
		{
			return this.As<ICommonTipGeneralFloatingTipT>();
		}

		// Token: 0x0603738D RID: 226189 RVA: 0x0077BD13 File Offset: 0x00779F13
		public static TCommonTipOptionUnion FromICommonTipGeneralFloatingTip(ICommonTipGeneralFloatingTipT _icommontipgeneralfloatingtip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipGeneralFloatingTip,
				Value = _icommontipgeneralfloatingtip
			};
		}

		// Token: 0x0603738E RID: 226190 RVA: 0x0077BD28 File Offset: 0x00779F28
		public ICommonTipIdT AsICommonTipId()
		{
			return this.As<ICommonTipIdT>();
		}

		// Token: 0x0603738F RID: 226191 RVA: 0x0077BD30 File Offset: 0x00779F30
		public static TCommonTipOptionUnion FromICommonTipId(ICommonTipIdT _icommontipid)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipId,
				Value = _icommontipid
			};
		}

		// Token: 0x06037390 RID: 226192 RVA: 0x0077BD46 File Offset: 0x00779F46
		public ICommonTipMissionCompleteT AsICommonTipMissionComplete()
		{
			return this.As<ICommonTipMissionCompleteT>();
		}

		// Token: 0x06037391 RID: 226193 RVA: 0x0077BD4E File Offset: 0x00779F4E
		public static TCommonTipOptionUnion FromICommonTipMissionComplete(ICommonTipMissionCompleteT _icommontipmissioncomplete)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipMissionComplete,
				Value = _icommontipmissioncomplete
			};
		}

		// Token: 0x06037392 RID: 226194 RVA: 0x0077BD64 File Offset: 0x00779F64
		public ICommonTipMissionCompleteNewT AsICommonTipMissionCompleteNew()
		{
			return this.As<ICommonTipMissionCompleteNewT>();
		}

		// Token: 0x06037393 RID: 226195 RVA: 0x0077BD6C File Offset: 0x00779F6C
		public static TCommonTipOptionUnion FromICommonTipMissionCompleteNew(ICommonTipMissionCompleteNewT _icommontipmissioncompletenew)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipMissionCompleteNew,
				Value = _icommontipmissioncompletenew
			};
		}

		// Token: 0x06037394 RID: 226196 RVA: 0x0077BD82 File Offset: 0x00779F82
		public ICommonTipPrepareCountdownT AsICommonTipPrepareCountdown()
		{
			return this.As<ICommonTipPrepareCountdownT>();
		}

		// Token: 0x06037395 RID: 226197 RVA: 0x0077BD8A File Offset: 0x00779F8A
		public static TCommonTipOptionUnion FromICommonTipPrepareCountdown(ICommonTipPrepareCountdownT _icommontippreparecountdown)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipPrepareCountdown,
				Value = _icommontippreparecountdown
			};
		}

		// Token: 0x06037396 RID: 226198 RVA: 0x0077BDA0 File Offset: 0x00779FA0
		public ICommonTipReachChallengeT AsICommonTipReachChallenge()
		{
			return this.As<ICommonTipReachChallengeT>();
		}

		// Token: 0x06037397 RID: 226199 RVA: 0x0077BDA8 File Offset: 0x00779FA8
		public static TCommonTipOptionUnion FromICommonTipReachChallenge(ICommonTipReachChallengeT _icommontipreachchallenge)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipReachChallenge,
				Value = _icommontipreachchallenge
			};
		}

		// Token: 0x06037398 RID: 226200 RVA: 0x0077BDBE File Offset: 0x00779FBE
		public ICommonTipTriggerDelegationT AsICommonTipTriggerDelegation()
		{
			return this.As<ICommonTipTriggerDelegationT>();
		}

		// Token: 0x06037399 RID: 226201 RVA: 0x0077BDC6 File Offset: 0x00779FC6
		public static TCommonTipOptionUnion FromICommonTipTriggerDelegation(ICommonTipTriggerDelegationT _icommontiptriggerdelegation)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ICommonTipTriggerDelegation,
				Value = _icommontiptriggerdelegation
			};
		}

		// Token: 0x0603739A RID: 226202 RVA: 0x0077BDDC File Offset: 0x00779FDC
		public IDreamlessWarningT AsIDreamlessWarning()
		{
			return this.As<IDreamlessWarningT>();
		}

		// Token: 0x0603739B RID: 226203 RVA: 0x0077BDE4 File Offset: 0x00779FE4
		public static TCommonTipOptionUnion FromIDreamlessWarning(IDreamlessWarningT _idreamlesswarning)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IDreamlessWarning,
				Value = _idreamlesswarning
			};
		}

		// Token: 0x0603739C RID: 226204 RVA: 0x0077BDFA File Offset: 0x00779FFA
		public IFlipperTipT AsIFlipperTip()
		{
			return this.As<IFlipperTipT>();
		}

		// Token: 0x0603739D RID: 226205 RVA: 0x0077BE02 File Offset: 0x0077A002
		public static TCommonTipOptionUnion FromIFlipperTip(IFlipperTipT _iflippertip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IFlipperTip,
				Value = _iflippertip
			};
		}

		// Token: 0x0603739E RID: 226206 RVA: 0x0077BE18 File Offset: 0x0077A018
		public IGreatSwordChallengeT AsIGreatSwordChallenge()
		{
			return this.As<IGreatSwordChallengeT>();
		}

		// Token: 0x0603739F RID: 226207 RVA: 0x0077BE20 File Offset: 0x0077A020
		public static TCommonTipOptionUnion FromIGreatSwordChallenge(IGreatSwordChallengeT _igreatswordchallenge)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IGreatSwordChallenge,
				Value = _igreatswordchallenge
			};
		}

		// Token: 0x060373A0 RID: 226208 RVA: 0x0077BE36 File Offset: 0x0077A036
		public IMoraleAreaTipT AsIMoraleAreaTip()
		{
			return this.As<IMoraleAreaTipT>();
		}

		// Token: 0x060373A1 RID: 226209 RVA: 0x0077BE3E File Offset: 0x0077A03E
		public static TCommonTipOptionUnion FromIMoraleAreaTip(IMoraleAreaTipT _imoraleareatip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IMoraleAreaTip,
				Value = _imoraleareatip
			};
		}

		// Token: 0x060373A2 RID: 226210 RVA: 0x0077BE54 File Offset: 0x0077A054
		public INightmareLordTipT AsINightmareLordTip()
		{
			return this.As<INightmareLordTipT>();
		}

		// Token: 0x060373A3 RID: 226211 RVA: 0x0077BE5C File Offset: 0x0077A05C
		public static TCommonTipOptionUnion FromINightmareLordTip(INightmareLordTipT _inightmarelordtip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.INightmareLordTip,
				Value = _inightmarelordtip
			};
		}

		// Token: 0x060373A4 RID: 226212 RVA: 0x0077BE72 File Offset: 0x0077A072
		public INightmareSpawnPointTipT AsINightmareSpawnPointTip()
		{
			return this.As<INightmareSpawnPointTipT>();
		}

		// Token: 0x060373A5 RID: 226213 RVA: 0x0077BE7A File Offset: 0x0077A07A
		public static TCommonTipOptionUnion FromINightmareSpawnPointTip(INightmareSpawnPointTipT _inightmarespawnpointtip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.INightmareSpawnPointTip,
				Value = _inightmarespawnpointtip
			};
		}

		// Token: 0x060373A6 RID: 226214 RVA: 0x0077BE90 File Offset: 0x0077A090
		public IPhotographicTipT AsIPhotographicTip()
		{
			return this.As<IPhotographicTipT>();
		}

		// Token: 0x060373A7 RID: 226215 RVA: 0x0077BE98 File Offset: 0x0077A098
		public static TCommonTipOptionUnion FromIPhotographicTip(IPhotographicTipT _iphotographictip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IPhotographicTip,
				Value = _iphotographictip
			};
		}

		// Token: 0x060373A8 RID: 226216 RVA: 0x0077BEAE File Offset: 0x0077A0AE
		public IPunishReportT AsIPunishReport()
		{
			return this.As<IPunishReportT>();
		}

		// Token: 0x060373A9 RID: 226217 RVA: 0x0077BEB6 File Offset: 0x0077A0B6
		public static TCommonTipOptionUnion FromIPunishReport(IPunishReportT _ipunishreport)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IPunishReport,
				Value = _ipunishreport
			};
		}

		// Token: 0x060373AA RID: 226218 RVA: 0x0077BECC File Offset: 0x0077A0CC
		public IRemainStarWarningT AsIRemainStarWarning()
		{
			return this.As<IRemainStarWarningT>();
		}

		// Token: 0x060373AB RID: 226219 RVA: 0x0077BED4 File Offset: 0x0077A0D4
		public static TCommonTipOptionUnion FromIRemainStarWarning(IRemainStarWarningT _iremainstarwarning)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IRemainStarWarning,
				Value = _iremainstarwarning
			};
		}

		// Token: 0x060373AC RID: 226220 RVA: 0x0077BEEA File Offset: 0x0077A0EA
		public ISheriffCashSettlementT AsISheriffCashSettlement()
		{
			return this.As<ISheriffCashSettlementT>();
		}

		// Token: 0x060373AD RID: 226221 RVA: 0x0077BEF2 File Offset: 0x0077A0F2
		public static TCommonTipOptionUnion FromISheriffCashSettlement(ISheriffCashSettlementT _isheriffcashsettlement)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ISheriffCashSettlement,
				Value = _isheriffcashsettlement
			};
		}

		// Token: 0x060373AE RID: 226222 RVA: 0x0077BF08 File Offset: 0x0077A108
		public ISheriffCriminalArrestedT AsISheriffCriminalArrested()
		{
			return this.As<ISheriffCriminalArrestedT>();
		}

		// Token: 0x060373AF RID: 226223 RVA: 0x0077BF10 File Offset: 0x0077A110
		public static TCommonTipOptionUnion FromISheriffCriminalArrested(ISheriffCriminalArrestedT _isheriffcriminalarrested)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ISheriffCriminalArrested,
				Value = _isheriffcriminalarrested
			};
		}

		// Token: 0x060373B0 RID: 226224 RVA: 0x0077BF26 File Offset: 0x0077A126
		public ISheriffStartTrackT AsISheriffStartTrack()
		{
			return this.As<ISheriffStartTrackT>();
		}

		// Token: 0x060373B1 RID: 226225 RVA: 0x0077BF2E File Offset: 0x0077A12E
		public static TCommonTipOptionUnion FromISheriffStartTrack(ISheriffStartTrackT _isheriffstarttrack)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ISheriffStartTrack,
				Value = _isheriffstarttrack
			};
		}

		// Token: 0x060373B2 RID: 226226 RVA: 0x0077BF44 File Offset: 0x0077A144
		public ISlashAndTowerTipT AsISlashAndTowerTip()
		{
			return this.As<ISlashAndTowerTipT>();
		}

		// Token: 0x060373B3 RID: 226227 RVA: 0x0077BF4C File Offset: 0x0077A14C
		public static TCommonTipOptionUnion FromISlashAndTowerTip(ISlashAndTowerTipT _islashandtowertip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ISlashAndTowerTip,
				Value = _islashandtowertip
			};
		}

		// Token: 0x060373B4 RID: 226228 RVA: 0x0077BF62 File Offset: 0x0077A162
		public ISwordIntentTipT AsISwordIntentTip()
		{
			return this.As<ISwordIntentTipT>();
		}

		// Token: 0x060373B5 RID: 226229 RVA: 0x0077BF6A File Offset: 0x0077A16A
		public static TCommonTipOptionUnion FromISwordIntentTip(ISwordIntentTipT _iswordintenttip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ISwordIntentTip,
				Value = _iswordintenttip
			};
		}

		// Token: 0x060373B6 RID: 226230 RVA: 0x0077BF80 File Offset: 0x0077A180
		public ITrapDefenseTipT AsITrapDefenseTip()
		{
			return this.As<ITrapDefenseTipT>();
		}

		// Token: 0x060373B7 RID: 226231 RVA: 0x0077BF88 File Offset: 0x0077A188
		public static TCommonTipOptionUnion FromITrapDefenseTip(ITrapDefenseTipT _itrapdefensetip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.ITrapDefenseTip,
				Value = _itrapdefensetip
			};
		}

		// Token: 0x060373B8 RID: 226232 RVA: 0x0077BF9E File Offset: 0x0077A19E
		public IVisionSettlementHardTipT AsIVisionSettlementHardTip()
		{
			return this.As<IVisionSettlementHardTipT>();
		}

		// Token: 0x060373B9 RID: 226233 RVA: 0x0077BFA6 File Offset: 0x0077A1A6
		public static TCommonTipOptionUnion FromIVisionSettlementHardTip(IVisionSettlementHardTipT _ivisionsettlementhardtip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IVisionSettlementHardTip,
				Value = _ivisionsettlementhardtip
			};
		}

		// Token: 0x060373BA RID: 226234 RVA: 0x0077BFBC File Offset: 0x0077A1BC
		public IVisionSettlementTipT AsIVisionSettlementTip()
		{
			return this.As<IVisionSettlementTipT>();
		}

		// Token: 0x060373BB RID: 226235 RVA: 0x0077BFC4 File Offset: 0x0077A1C4
		public static TCommonTipOptionUnion FromIVisionSettlementTip(IVisionSettlementTipT _ivisionsettlementtip)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IVisionSettlementTip,
				Value = _ivisionsettlementtip
			};
		}

		// Token: 0x060373BC RID: 226236 RVA: 0x0077BFDA File Offset: 0x0077A1DA
		public IWhiteCatWarningT AsIWhiteCatWarning()
		{
			return this.As<IWhiteCatWarningT>();
		}

		// Token: 0x060373BD RID: 226237 RVA: 0x0077BFE2 File Offset: 0x0077A1E2
		public static TCommonTipOptionUnion FromIWhiteCatWarning(IWhiteCatWarningT _iwhitecatwarning)
		{
			return new TCommonTipOptionUnion
			{
				Type = TCommonTipOption.IWhiteCatWarning,
				Value = _iwhitecatwarning
			};
		}

		// Token: 0x060373BE RID: 226238 RVA: 0x0077BFF8 File Offset: 0x0077A1F8
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
			case TCommonTipOption.IRemainStarWarning:
				return IRemainStarWarning.Pack(builder, _o.AsIRemainStarWarning()).Value;
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
