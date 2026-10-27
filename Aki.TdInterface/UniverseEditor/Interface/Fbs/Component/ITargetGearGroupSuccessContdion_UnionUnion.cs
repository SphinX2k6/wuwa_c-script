using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A38 RID: 23096
	public class ITargetGearGroupSuccessContdion_UnionUnion
	{
		// Token: 0x1700ADB1 RID: 44465
		// (get) Token: 0x06027422 RID: 160802 RVA: 0x00566E05 File Offset: 0x00565005
		// (set) Token: 0x06027423 RID: 160803 RVA: 0x00566E0D File Offset: 0x0056500D
		public ITargetGearGroupSuccessContdion_Union Type { get; set; }

		// Token: 0x1700ADB2 RID: 44466
		// (get) Token: 0x06027424 RID: 160804 RVA: 0x00566E16 File Offset: 0x00565016
		// (set) Token: 0x06027425 RID: 160805 RVA: 0x00566E1E File Offset: 0x0056501E
		public object Value { get; set; }

		// Token: 0x06027426 RID: 160806 RVA: 0x00566E27 File Offset: 0x00565027
		public ITargetGearGroupSuccessContdion_UnionUnion()
		{
			this.Type = ITargetGearGroupSuccessContdion_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027427 RID: 160807 RVA: 0x00566E3D File Offset: 0x0056503D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027428 RID: 160808 RVA: 0x00566E4F File Offset: 0x0056504F
		public ITargetGearGroupSuccessContdionT AsITargetGearGroupSuccessContdion()
		{
			return this.As<ITargetGearGroupSuccessContdionT>();
		}

		// Token: 0x06027429 RID: 160809 RVA: 0x00566E57 File Offset: 0x00565057
		public static ITargetGearGroupSuccessContdion_UnionUnion FromITargetGearGroupSuccessContdion(ITargetGearGroupSuccessContdionT _itargetgeargroupsuccesscontdion)
		{
			return new ITargetGearGroupSuccessContdion_UnionUnion
			{
				Type = ITargetGearGroupSuccessContdion_Union.ITargetGearGroupSuccessContdion,
				Value = _itargetgeargroupsuccesscontdion
			};
		}

		// Token: 0x0602742A RID: 160810 RVA: 0x00566E6C File Offset: 0x0056506C
		public ISuccessConditionSameSpecificStateT AsISuccessConditionSameSpecificState()
		{
			return this.As<ISuccessConditionSameSpecificStateT>();
		}

		// Token: 0x0602742B RID: 160811 RVA: 0x00566E74 File Offset: 0x00565074
		public static ITargetGearGroupSuccessContdion_UnionUnion FromISuccessConditionSameSpecificState(ISuccessConditionSameSpecificStateT _isuccessconditionsamespecificstate)
		{
			return new ITargetGearGroupSuccessContdion_UnionUnion
			{
				Type = ITargetGearGroupSuccessContdion_Union.ISuccessConditionSameSpecificState,
				Value = _isuccessconditionsamespecificstate
			};
		}

		// Token: 0x0602742C RID: 160812 RVA: 0x00566E89 File Offset: 0x00565089
		public ISuccessConditionSameArbitraryStateT AsISuccessConditionSameArbitraryState()
		{
			return this.As<ISuccessConditionSameArbitraryStateT>();
		}

		// Token: 0x0602742D RID: 160813 RVA: 0x00566E91 File Offset: 0x00565091
		public static ITargetGearGroupSuccessContdion_UnionUnion FromISuccessConditionSameArbitraryState(ISuccessConditionSameArbitraryStateT _isuccessconditionsamearbitrarystate)
		{
			return new ITargetGearGroupSuccessContdion_UnionUnion
			{
				Type = ITargetGearGroupSuccessContdion_Union.ISuccessConditionSameArbitraryState,
				Value = _isuccessconditionsamearbitrarystate
			};
		}

		// Token: 0x0602742E RID: 160814 RVA: 0x00566EA6 File Offset: 0x005650A6
		public ISuccessConditionCountDownStateT AsISuccessConditionCountDownState()
		{
			return this.As<ISuccessConditionCountDownStateT>();
		}

		// Token: 0x0602742F RID: 160815 RVA: 0x00566EAE File Offset: 0x005650AE
		public static ITargetGearGroupSuccessContdion_UnionUnion FromISuccessConditionCountDownState(ISuccessConditionCountDownStateT _isuccessconditioncountdownstate)
		{
			return new ITargetGearGroupSuccessContdion_UnionUnion
			{
				Type = ITargetGearGroupSuccessContdion_Union.ISuccessConditionCountDownState,
				Value = _isuccessconditioncountdownstate
			};
		}

		// Token: 0x06027430 RID: 160816 RVA: 0x00566EC3 File Offset: 0x005650C3
		public ISuccessConditionSpecificTargetStateT AsISuccessConditionSpecificTargetState()
		{
			return this.As<ISuccessConditionSpecificTargetStateT>();
		}

		// Token: 0x06027431 RID: 160817 RVA: 0x00566ECB File Offset: 0x005650CB
		public static ITargetGearGroupSuccessContdion_UnionUnion FromISuccessConditionSpecificTargetState(ISuccessConditionSpecificTargetStateT _isuccessconditionspecifictargetstate)
		{
			return new ITargetGearGroupSuccessContdion_UnionUnion
			{
				Type = ITargetGearGroupSuccessContdion_Union.ISuccessConditionSpecificTargetState,
				Value = _isuccessconditionspecifictargetstate
			};
		}

		// Token: 0x06027432 RID: 160818 RVA: 0x00566EE0 File Offset: 0x005650E0
		public static int Pack(FlatBufferBuilder builder, ITargetGearGroupSuccessContdion_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITargetGearGroupSuccessContdion_Union.ITargetGearGroupSuccessContdion:
				return ITargetGearGroupSuccessContdion.Pack(builder, _o.AsITargetGearGroupSuccessContdion()).Value;
			case ITargetGearGroupSuccessContdion_Union.ISuccessConditionSameSpecificState:
				return ISuccessConditionSameSpecificState.Pack(builder, _o.AsISuccessConditionSameSpecificState()).Value;
			case ITargetGearGroupSuccessContdion_Union.ISuccessConditionSameArbitraryState:
				return ISuccessConditionSameArbitraryState.Pack(builder, _o.AsISuccessConditionSameArbitraryState()).Value;
			case ITargetGearGroupSuccessContdion_Union.ISuccessConditionCountDownState:
				return ISuccessConditionCountDownState.Pack(builder, _o.AsISuccessConditionCountDownState()).Value;
			case ITargetGearGroupSuccessContdion_Union.ISuccessConditionSpecificTargetState:
				return ISuccessConditionSpecificTargetState.Pack(builder, _o.AsISuccessConditionSpecificTargetState()).Value;
			default:
				return 0;
			}
		}
	}
}
