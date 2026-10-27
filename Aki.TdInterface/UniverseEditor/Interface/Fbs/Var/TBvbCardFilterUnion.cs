using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B4E RID: 15182
	public class TBvbCardFilterUnion
	{
		// Token: 0x1700681D RID: 26653
		// (get) Token: 0x06014C0F RID: 85007 RVA: 0x003042FC File Offset: 0x003024FC
		// (set) Token: 0x06014C10 RID: 85008 RVA: 0x00304304 File Offset: 0x00302504
		public TBvbCardFilter Type { get; set; }

		// Token: 0x1700681E RID: 26654
		// (get) Token: 0x06014C11 RID: 85009 RVA: 0x0030430D File Offset: 0x0030250D
		// (set) Token: 0x06014C12 RID: 85010 RVA: 0x00304315 File Offset: 0x00302515
		public object Value { get; set; }

		// Token: 0x06014C13 RID: 85011 RVA: 0x0030431E File Offset: 0x0030251E
		public TBvbCardFilterUnion()
		{
			this.Type = TBvbCardFilter.NONE;
			this.Value = null;
		}

		// Token: 0x06014C14 RID: 85012 RVA: 0x00304334 File Offset: 0x00302534
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014C15 RID: 85013 RVA: 0x00304346 File Offset: 0x00302546
		public IBvbCardFilterCheckHasBattleFactorT AsIBvbCardFilterCheckHasBattleFactor()
		{
			return this.As<IBvbCardFilterCheckHasBattleFactorT>();
		}

		// Token: 0x06014C16 RID: 85014 RVA: 0x0030434E File Offset: 0x0030254E
		public static TBvbCardFilterUnion FromIBvbCardFilterCheckHasBattleFactor(IBvbCardFilterCheckHasBattleFactorT _ibvbcardfiltercheckhasbattlefactor)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCheckHasBattleFactor,
				Value = _ibvbcardfiltercheckhasbattlefactor
			};
		}

		// Token: 0x06014C17 RID: 85015 RVA: 0x00304363 File Offset: 0x00302563
		public IBvbCardFilterCheckHasOptimalFactorT AsIBvbCardFilterCheckHasOptimalFactor()
		{
			return this.As<IBvbCardFilterCheckHasOptimalFactorT>();
		}

		// Token: 0x06014C18 RID: 85016 RVA: 0x0030436B File Offset: 0x0030256B
		public static TBvbCardFilterUnion FromIBvbCardFilterCheckHasOptimalFactor(IBvbCardFilterCheckHasOptimalFactorT _ibvbcardfiltercheckhasoptimalfactor)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCheckHasOptimalFactor,
				Value = _ibvbcardfiltercheckhasoptimalfactor
			};
		}

		// Token: 0x06014C19 RID: 85017 RVA: 0x00304380 File Offset: 0x00302580
		public IBvbCardFilterCheckIsCapableToEvolveT AsIBvbCardFilterCheckIsCapableToEvolve()
		{
			return this.As<IBvbCardFilterCheckIsCapableToEvolveT>();
		}

		// Token: 0x06014C1A RID: 85018 RVA: 0x00304388 File Offset: 0x00302588
		public static TBvbCardFilterUnion FromIBvbCardFilterCheckIsCapableToEvolve(IBvbCardFilterCheckIsCapableToEvolveT _ibvbcardfiltercheckiscapabletoevolve)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCheckIsCapableToEvolve,
				Value = _ibvbcardfiltercheckiscapabletoevolve
			};
		}

		// Token: 0x06014C1B RID: 85019 RVA: 0x0030439D File Offset: 0x0030259D
		public IBvbCardFilterCheckIsCoreT AsIBvbCardFilterCheckIsCore()
		{
			return this.As<IBvbCardFilterCheckIsCoreT>();
		}

		// Token: 0x06014C1C RID: 85020 RVA: 0x003043A5 File Offset: 0x003025A5
		public static TBvbCardFilterUnion FromIBvbCardFilterCheckIsCore(IBvbCardFilterCheckIsCoreT _ibvbcardfiltercheckiscore)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCheckIsCore,
				Value = _ibvbcardfiltercheckiscore
			};
		}

		// Token: 0x06014C1D RID: 85021 RVA: 0x003043BA File Offset: 0x003025BA
		public IBvbCardFilterCompareActiveSkillTagT AsIBvbCardFilterCompareActiveSkillTag()
		{
			return this.As<IBvbCardFilterCompareActiveSkillTagT>();
		}

		// Token: 0x06014C1E RID: 85022 RVA: 0x003043C2 File Offset: 0x003025C2
		public static TBvbCardFilterUnion FromIBvbCardFilterCompareActiveSkillTag(IBvbCardFilterCompareActiveSkillTagT _ibvbcardfiltercompareactiveskilltag)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCompareActiveSkillTag,
				Value = _ibvbcardfiltercompareactiveskilltag
			};
		}

		// Token: 0x06014C1F RID: 85023 RVA: 0x003043D7 File Offset: 0x003025D7
		public IBvbCardFilterCompareCardTypeT AsIBvbCardFilterCompareCardType()
		{
			return this.As<IBvbCardFilterCompareCardTypeT>();
		}

		// Token: 0x06014C20 RID: 85024 RVA: 0x003043DF File Offset: 0x003025DF
		public static TBvbCardFilterUnion FromIBvbCardFilterCompareCardType(IBvbCardFilterCompareCardTypeT _ibvbcardfiltercomparecardtype)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCompareCardType,
				Value = _ibvbcardfiltercomparecardtype
			};
		}

		// Token: 0x06014C21 RID: 85025 RVA: 0x003043F4 File Offset: 0x003025F4
		public IBvbCardFilterCompareCostT AsIBvbCardFilterCompareCost()
		{
			return this.As<IBvbCardFilterCompareCostT>();
		}

		// Token: 0x06014C22 RID: 85026 RVA: 0x003043FC File Offset: 0x003025FC
		public static TBvbCardFilterUnion FromIBvbCardFilterCompareCost(IBvbCardFilterCompareCostT _ibvbcardfiltercomparecost)
		{
			return new TBvbCardFilterUnion
			{
				Type = TBvbCardFilter.IBvbCardFilterCompareCost,
				Value = _ibvbcardfiltercomparecost
			};
		}

		// Token: 0x06014C23 RID: 85027 RVA: 0x00304414 File Offset: 0x00302614
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
