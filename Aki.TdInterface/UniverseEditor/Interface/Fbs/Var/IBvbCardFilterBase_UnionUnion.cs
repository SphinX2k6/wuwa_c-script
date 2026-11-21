using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E06 RID: 15878
	public class IBvbCardFilterBase_UnionUnion
	{
		// Token: 0x17006B3C RID: 27452
		// (get) Token: 0x06015551 RID: 87377 RVA: 0x00315229 File Offset: 0x00313429
		// (set) Token: 0x06015552 RID: 87378 RVA: 0x00315231 File Offset: 0x00313431
		public IBvbCardFilterBase_Union Type { get; set; }

		// Token: 0x17006B3D RID: 27453
		// (get) Token: 0x06015553 RID: 87379 RVA: 0x0031523A File Offset: 0x0031343A
		// (set) Token: 0x06015554 RID: 87380 RVA: 0x00315242 File Offset: 0x00313442
		public object Value { get; set; }

		// Token: 0x06015555 RID: 87381 RVA: 0x0031524B File Offset: 0x0031344B
		public IBvbCardFilterBase_UnionUnion()
		{
			this.Type = IBvbCardFilterBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015556 RID: 87382 RVA: 0x00315261 File Offset: 0x00313461
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015557 RID: 87383 RVA: 0x00315273 File Offset: 0x00313473
		public IBvbCardFilterBaseT AsIBvbCardFilterBase()
		{
			return this.As<IBvbCardFilterBaseT>();
		}

		// Token: 0x06015558 RID: 87384 RVA: 0x0031527B File Offset: 0x0031347B
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterBase(IBvbCardFilterBaseT _ibvbcardfilterbase)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterBase,
				Value = _ibvbcardfilterbase
			};
		}

		// Token: 0x06015559 RID: 87385 RVA: 0x00315290 File Offset: 0x00313490
		public IBvbCardFilterCompareCostT AsIBvbCardFilterCompareCost()
		{
			return this.As<IBvbCardFilterCompareCostT>();
		}

		// Token: 0x0601555A RID: 87386 RVA: 0x00315298 File Offset: 0x00313498
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCompareCost(IBvbCardFilterCompareCostT _ibvbcardfiltercomparecost)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCompareCost,
				Value = _ibvbcardfiltercomparecost
			};
		}

		// Token: 0x0601555B RID: 87387 RVA: 0x003152AD File Offset: 0x003134AD
		public IBvbCardFilterCompareCardTypeT AsIBvbCardFilterCompareCardType()
		{
			return this.As<IBvbCardFilterCompareCardTypeT>();
		}

		// Token: 0x0601555C RID: 87388 RVA: 0x003152B5 File Offset: 0x003134B5
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCompareCardType(IBvbCardFilterCompareCardTypeT _ibvbcardfiltercomparecardtype)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCompareCardType,
				Value = _ibvbcardfiltercomparecardtype
			};
		}

		// Token: 0x0601555D RID: 87389 RVA: 0x003152CA File Offset: 0x003134CA
		public IBvbCardFilterCheckIsCoreT AsIBvbCardFilterCheckIsCore()
		{
			return this.As<IBvbCardFilterCheckIsCoreT>();
		}

		// Token: 0x0601555E RID: 87390 RVA: 0x003152D2 File Offset: 0x003134D2
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCheckIsCore(IBvbCardFilterCheckIsCoreT _ibvbcardfiltercheckiscore)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCheckIsCore,
				Value = _ibvbcardfiltercheckiscore
			};
		}

		// Token: 0x0601555F RID: 87391 RVA: 0x003152E7 File Offset: 0x003134E7
		public IBvbCardFilterCompareActiveSkillTagT AsIBvbCardFilterCompareActiveSkillTag()
		{
			return this.As<IBvbCardFilterCompareActiveSkillTagT>();
		}

		// Token: 0x06015560 RID: 87392 RVA: 0x003152EF File Offset: 0x003134EF
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCompareActiveSkillTag(IBvbCardFilterCompareActiveSkillTagT _ibvbcardfiltercompareactiveskilltag)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCompareActiveSkillTag,
				Value = _ibvbcardfiltercompareactiveskilltag
			};
		}

		// Token: 0x06015561 RID: 87393 RVA: 0x00315304 File Offset: 0x00313504
		public IBvbCardFilterCheckHasBattleFactorT AsIBvbCardFilterCheckHasBattleFactor()
		{
			return this.As<IBvbCardFilterCheckHasBattleFactorT>();
		}

		// Token: 0x06015562 RID: 87394 RVA: 0x0031530C File Offset: 0x0031350C
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCheckHasBattleFactor(IBvbCardFilterCheckHasBattleFactorT _ibvbcardfiltercheckhasbattlefactor)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCheckHasBattleFactor,
				Value = _ibvbcardfiltercheckhasbattlefactor
			};
		}

		// Token: 0x06015563 RID: 87395 RVA: 0x00315321 File Offset: 0x00313521
		public IBvbCardFilterCheckHasOptimalFactorT AsIBvbCardFilterCheckHasOptimalFactor()
		{
			return this.As<IBvbCardFilterCheckHasOptimalFactorT>();
		}

		// Token: 0x06015564 RID: 87396 RVA: 0x00315329 File Offset: 0x00313529
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCheckHasOptimalFactor(IBvbCardFilterCheckHasOptimalFactorT _ibvbcardfiltercheckhasoptimalfactor)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCheckHasOptimalFactor,
				Value = _ibvbcardfiltercheckhasoptimalfactor
			};
		}

		// Token: 0x06015565 RID: 87397 RVA: 0x0031533E File Offset: 0x0031353E
		public IBvbCardFilterCheckIsCapableToEvolveT AsIBvbCardFilterCheckIsCapableToEvolve()
		{
			return this.As<IBvbCardFilterCheckIsCapableToEvolveT>();
		}

		// Token: 0x06015566 RID: 87398 RVA: 0x00315346 File Offset: 0x00313546
		public static IBvbCardFilterBase_UnionUnion FromIBvbCardFilterCheckIsCapableToEvolve(IBvbCardFilterCheckIsCapableToEvolveT _ibvbcardfiltercheckiscapabletoevolve)
		{
			return new IBvbCardFilterBase_UnionUnion
			{
				Type = IBvbCardFilterBase_Union.IBvbCardFilterCheckIsCapableToEvolve,
				Value = _ibvbcardfiltercheckiscapabletoevolve
			};
		}

		// Token: 0x06015567 RID: 87399 RVA: 0x0031535C File Offset: 0x0031355C
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
