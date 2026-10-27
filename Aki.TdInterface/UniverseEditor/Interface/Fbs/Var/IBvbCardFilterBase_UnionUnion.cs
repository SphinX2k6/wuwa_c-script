using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A2B RID: 14891
	public class IBvbCardFilterBase_UnionUnion
	{
		// Token: 0x1700660C RID: 26124
		// (get) Token: 0x06014235 RID: 82485 RVA: 0x002F203D File Offset: 0x002F023D
		// (set) Token: 0x06014236 RID: 82486 RVA: 0x002F2045 File Offset: 0x002F0245
		public IBvbCardFilterBase_Union Type { get; set; }

		// Token: 0x1700660D RID: 26125
		// (get) Token: 0x06014237 RID: 82487 RVA: 0x002F204E File Offset: 0x002F024E
		// (set) Token: 0x06014238 RID: 82488 RVA: 0x002F2056 File Offset: 0x002F0256
		public object Value { get; set; }

		// Token: 0x06014239 RID: 82489 RVA: 0x002F205F File Offset: 0x002F025F
		public IBvbCardFilterBase_UnionUnion()
		{
			this.Type = IBvbCardFilterBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601423A RID: 82490 RVA: 0x002F2075 File Offset: 0x002F0275
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601423B RID: 82491 RVA: 0x002F2087 File Offset: 0x002F0287
		public IBvbCardFilterBaseT AsIBvbCardFilterBase()
		{
			return this.As<IBvbCardFilterBaseT>();
		}

		// Token: 0x0601423C RID: 82492 RVA: 0x002F208F File Offset: 0x002F028F
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterBase(IBvbCardFilterBaseT _ibvbcardfilterbase)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterBase,
				Value = _ibvbcardfilterbase
			};
		}

		// Token: 0x0601423D RID: 82493 RVA: 0x002F20A4 File Offset: 0x002F02A4
		public IBvbCardFilterCompareCostT AsIBvbCardFilterCompareCost()
		{
			return this.As<IBvbCardFilterCompareCostT>();
		}

		// Token: 0x0601423E RID: 82494 RVA: 0x002F20AC File Offset: 0x002F02AC
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCompareCost(IBvbCardFilterCompareCostT _ibvbcardfiltercomparecost)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCompareCost,
				Value = _ibvbcardfiltercomparecost
			};
		}

		// Token: 0x0601423F RID: 82495 RVA: 0x002F20C1 File Offset: 0x002F02C1
		public IBvbCardFilterCompareCardTypeT AsIBvbCardFilterCompareCardType()
		{
			return this.As<IBvbCardFilterCompareCardTypeT>();
		}

		// Token: 0x06014240 RID: 82496 RVA: 0x002F20C9 File Offset: 0x002F02C9
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCompareCardType(IBvbCardFilterCompareCardTypeT _ibvbcardfiltercomparecardtype)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCompareCardType,
				Value = _ibvbcardfiltercomparecardtype
			};
		}

		// Token: 0x06014241 RID: 82497 RVA: 0x002F20DE File Offset: 0x002F02DE
		public IBvbCardFilterCheckIsCoreT AsIBvbCardFilterCheckIsCore()
		{
			return this.As<IBvbCardFilterCheckIsCoreT>();
		}

		// Token: 0x06014242 RID: 82498 RVA: 0x002F20E6 File Offset: 0x002F02E6
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCheckIsCore(IBvbCardFilterCheckIsCoreT _ibvbcardfiltercheckiscore)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCheckIsCore,
				Value = _ibvbcardfiltercheckiscore
			};
		}

		// Token: 0x06014243 RID: 82499 RVA: 0x002F20FB File Offset: 0x002F02FB
		public IBvbCardFilterCompareActiveSkillTagT AsIBvbCardFilterCompareActiveSkillTag()
		{
			return this.As<IBvbCardFilterCompareActiveSkillTagT>();
		}

		// Token: 0x06014244 RID: 82500 RVA: 0x002F2103 File Offset: 0x002F0303
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCompareActiveSkillTag(IBvbCardFilterCompareActiveSkillTagT _ibvbcardfiltercompareactiveskilltag)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCompareActiveSkillTag,
				Value = _ibvbcardfiltercompareactiveskilltag
			};
		}

		// Token: 0x06014245 RID: 82501 RVA: 0x002F2118 File Offset: 0x002F0318
		public IBvbCardFilterCheckHasBattleFactorT AsIBvbCardFilterCheckHasBattleFactor()
		{
			return this.As<IBvbCardFilterCheckHasBattleFactorT>();
		}

		// Token: 0x06014246 RID: 82502 RVA: 0x002F2120 File Offset: 0x002F0320
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCheckHasBattleFactor(IBvbCardFilterCheckHasBattleFactorT _ibvbcardfiltercheckhasbattlefactor)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCheckHasBattleFactor,
				Value = _ibvbcardfiltercheckhasbattlefactor
			};
		}

		// Token: 0x06014247 RID: 82503 RVA: 0x002F2135 File Offset: 0x002F0335
		public IBvbCardFilterCheckHasOptimalFactorT AsIBvbCardFilterCheckHasOptimalFactor()
		{
			return this.As<IBvbCardFilterCheckHasOptimalFactorT>();
		}

		// Token: 0x06014248 RID: 82504 RVA: 0x002F213D File Offset: 0x002F033D
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCheckHasOptimalFactor(IBvbCardFilterCheckHasOptimalFactorT _ibvbcardfiltercheckhasoptimalfactor)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCheckHasOptimalFactor,
				Value = _ibvbcardfiltercheckhasoptimalfactor
			};
		}

		// Token: 0x06014249 RID: 82505 RVA: 0x002F2152 File Offset: 0x002F0352
		public IBvbCardFilterCheckIsCapableToEvolveT AsIBvbCardFilterCheckIsCapableToEvolve()
		{
			return this.As<IBvbCardFilterCheckIsCapableToEvolveT>();
		}

		// Token: 0x0601424A RID: 82506 RVA: 0x002F215A File Offset: 0x002F035A
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCheckIsCapableToEvolve(IBvbCardFilterCheckIsCapableToEvolveT _ibvbcardfiltercheckiscapabletoevolve)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCheckIsCapableToEvolve,
				Value = _ibvbcardfiltercheckiscapabletoevolve
			};
		}

		// Token: 0x0601424B RID: 82507 RVA: 0x002F2170 File Offset: 0x002F0370
		public static int Pack(FlatBufferBuilder builder, IBvbCardFilterBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBvbCardFilterBase_Union.IBvbCardFilterBase:
				return IBvbCardFilterBase.Pack(builder, _o.AsIBvbCardFilterBase()).Value;
			case IBvbCardFilterBase_Union.IBvbCardFilterCompareCost:
				return IBvbCardFilterCompareCost.Pack(builder, _o.AsIBvbCardFilterCompareCost()).Value;
			case IBvbCardFilterBase_Union.IBvbCardFilterCompareCardType:
				return IBvbCardFilterCompareCardType.Pack(builder, _o.AsIBvbCardFilterCompareCardType()).Value;
			case IBvbCardFilterBase_Union.IBvbCardFilterCheckIsCore:
				return IBvbCardFilterCheckIsCore.Pack(builder, _o.AsIBvbCardFilterCheckIsCore()).Value;
			case IBvbCardFilterBase_Union.IBvbCardFilterCompareActiveSkillTag:
				return IBvbCardFilterCompareActiveSkillTag.Pack(builder, _o.AsIBvbCardFilterCompareActiveSkillTag()).Value;
			case IBvbCardFilterBase_Union.IBvbCardFilterCheckHasBattleFactor:
				return IBvbCardFilterCheckHasBattleFactor.Pack(builder, _o.AsIBvbCardFilterCheckHasBattleFactor()).Value;
			case IBvbCardFilterBase_Union.IBvbCardFilterCheckHasOptimalFactor:
				return IBvbCardFilterCheckHasOptimalFactor.Pack(builder, _o.AsIBvbCardFilterCheckHasOptimalFactor()).Value;
			case IBvbCardFilterBase_Union.IBvbCardFilterCheckIsCapableToEvolve:
				return IBvbCardFilterCheckIsCapableToEvolve.Pack(builder, _o.AsIBvbCardFilterCheckIsCapableToEvolve()).Value;
			default:
				return 0;
			}
		}
	}
}
