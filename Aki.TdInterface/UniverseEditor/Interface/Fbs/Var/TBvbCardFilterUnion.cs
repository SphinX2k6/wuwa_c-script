using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F50 RID: 16208
	public class TBvbCardFilterUnion
	{
		// Token: 0x17006DB8 RID: 28088
		// (get) Token: 0x060160B9 RID: 90297 RVA: 0x0032A58C File Offset: 0x0032878C
		// (set) Token: 0x060160BA RID: 90298 RVA: 0x0032A594 File Offset: 0x00328794
		public TBvbCardFilter Type { get; set; }

		// Token: 0x17006DB9 RID: 28089
		// (get) Token: 0x060160BB RID: 90299 RVA: 0x0032A59D File Offset: 0x0032879D
		// (set) Token: 0x060160BC RID: 90300 RVA: 0x0032A5A5 File Offset: 0x003287A5
		public object Value { get; set; }

		// Token: 0x060160BD RID: 90301 RVA: 0x0032A5AE File Offset: 0x003287AE
		public TBvbCardFilterUnion()
		{
			this.Type = TBvbCardFilter.NONE;
			this.Value = null;
		}

		// Token: 0x060160BE RID: 90302 RVA: 0x0032A5C4 File Offset: 0x003287C4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060160BF RID: 90303 RVA: 0x0032A5D6 File Offset: 0x003287D6
		public IBvbCardFilterCheckHasBattleFactorT AsIBvbCardFilterCheckHasBattleFactor()
		{
			return this.As<IBvbCardFilterCheckHasBattleFactorT>();
		}

		// Token: 0x060160C0 RID: 90304 RVA: 0x0032A5DE File Offset: 0x003287DE
		public static TBvbCardFilterUnion FromIBvbCardFilterCheckHasBattleFactor(IBvbCardFilterCheckHasBattleFactorT _ibvbcardfiltercheckhasbattlefactor)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCheckHasBattleFactor,
				Value = _ibvbcardfiltercheckhasbattlefactor
			};
		}

		// Token: 0x060160C1 RID: 90305 RVA: 0x0032A5F3 File Offset: 0x003287F3
		public IBvbCardFilterCheckHasOptimalFactorT AsIBvbCardFilterCheckHasOptimalFactor()
		{
			return this.As<IBvbCardFilterCheckHasOptimalFactorT>();
		}

		// Token: 0x060160C2 RID: 90306 RVA: 0x0032A5FB File Offset: 0x003287FB
		public static TBvbCardFilterUnion FromIBvbCardFilterCheckHasOptimalFactor(IBvbCardFilterCheckHasOptimalFactorT _ibvbcardfiltercheckhasoptimalfactor)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCheckHasOptimalFactor,
				Value = _ibvbcardfiltercheckhasoptimalfactor
			};
		}

		// Token: 0x060160C3 RID: 90307 RVA: 0x0032A610 File Offset: 0x00328810
		public IBvbCardFilterCheckIsCapableToEvolveT AsIBvbCardFilterCheckIsCapableToEvolve()
		{
			return this.As<IBvbCardFilterCheckIsCapableToEvolveT>();
		}

		// Token: 0x060160C4 RID: 90308 RVA: 0x0032A618 File Offset: 0x00328818
		public static TBvbCardFilterUnion FromIBvbCardFilterCheckIsCapableToEvolve(IBvbCardFilterCheckIsCapableToEvolveT _ibvbcardfiltercheckiscapabletoevolve)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCheckIsCapableToEvolve,
				Value = _ibvbcardfiltercheckiscapabletoevolve
			};
		}

		// Token: 0x060160C5 RID: 90309 RVA: 0x0032A62D File Offset: 0x0032882D
		public IBvbCardFilterCheckIsCoreT AsIBvbCardFilterCheckIsCore()
		{
			return this.As<IBvbCardFilterCheckIsCoreT>();
		}

		// Token: 0x060160C6 RID: 90310 RVA: 0x0032A635 File Offset: 0x00328835
		public static TBvbCardFilterUnion FromIBvbCardFilterCheckIsCore(IBvbCardFilterCheckIsCoreT _ibvbcardfiltercheckiscore)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCheckIsCore,
				Value = _ibvbcardfiltercheckiscore
			};
		}

		// Token: 0x060160C7 RID: 90311 RVA: 0x0032A64A File Offset: 0x0032884A
		public IBvbCardFilterCompareActiveSkillTagT AsIBvbCardFilterCompareActiveSkillTag()
		{
			return this.As<IBvbCardFilterCompareActiveSkillTagT>();
		}

		// Token: 0x060160C8 RID: 90312 RVA: 0x0032A652 File Offset: 0x00328852
		public static TBvbCardFilterUnion FromIBvbCardFilterCompareActiveSkillTag(IBvbCardFilterCompareActiveSkillTagT _ibvbcardfiltercompareactiveskilltag)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCompareActiveSkillTag,
				Value = _ibvbcardfiltercompareactiveskilltag
			};
		}

		// Token: 0x060160C9 RID: 90313 RVA: 0x0032A667 File Offset: 0x00328867
		public IBvbCardFilterCompareCardTypeT AsIBvbCardFilterCompareCardType()
		{
			return this.As<IBvbCardFilterCompareCardTypeT>();
		}

		// Token: 0x060160CA RID: 90314 RVA: 0x0032A66F File Offset: 0x0032886F
		public static TBvbCardFilterUnion FromIBvbCardFilterCompareCardType(IBvbCardFilterCompareCardTypeT _ibvbcardfiltercomparecardtype)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCompareCardType,
				Value = _ibvbcardfiltercomparecardtype
			};
		}

		// Token: 0x060160CB RID: 90315 RVA: 0x0032A684 File Offset: 0x00328884
		public IBvbCardFilterCompareCostT AsIBvbCardFilterCompareCost()
		{
			return this.As<IBvbCardFilterCompareCostT>();
		}

		// Token: 0x060160CC RID: 90316 RVA: 0x0032A68C File Offset: 0x0032888C
		public static TBvbCardFilterUnion FromIBvbCardFilterCompareCost(IBvbCardFilterCompareCostT _ibvbcardfiltercomparecost)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCompareCost,
				Value = _ibvbcardfiltercomparecost
			};
		}

		// Token: 0x060160CD RID: 90317 RVA: 0x0032A6A4 File Offset: 0x003288A4
		public static int Pack(FlatBufferBuilder builder, TBvbCardFilterUnion _o)
		{
			switch (_o.Type)
			{
			case TBvbCardFilter.IBvbCardFilterCheckHasBattleFactor:
				return IBvbCardFilterCheckHasBattleFactor.Pack(builder, _o.AsIBvbCardFilterCheckHasBattleFactor()).Value;
			case TBvbCardFilter.IBvbCardFilterCheckHasOptimalFactor:
				return IBvbCardFilterCheckHasOptimalFactor.Pack(builder, _o.AsIBvbCardFilterCheckHasOptimalFactor()).Value;
			case TBvbCardFilter.IBvbCardFilterCheckIsCapableToEvolve:
				return IBvbCardFilterCheckIsCapableToEvolve.Pack(builder, _o.AsIBvbCardFilterCheckIsCapableToEvolve()).Value;
			case TBvbCardFilter.IBvbCardFilterCheckIsCore:
				return IBvbCardFilterCheckIsCore.Pack(builder, _o.AsIBvbCardFilterCheckIsCore()).Value;
			case TBvbCardFilter.IBvbCardFilterCompareActiveSkillTag:
				return IBvbCardFilterCompareActiveSkillTag.Pack(builder, _o.AsIBvbCardFilterCompareActiveSkillTag()).Value;
			case TBvbCardFilter.IBvbCardFilterCompareCardType:
				return IBvbCardFilterCompareCardType.Pack(builder, _o.AsIBvbCardFilterCompareCardType()).Value;
			case TBvbCardFilter.IBvbCardFilterCompareCost:
				return IBvbCardFilterCompareCost.Pack(builder, _o.AsIBvbCardFilterCompareCost()).Value;
			default:
				return 0;
			}
		}
	}
}
