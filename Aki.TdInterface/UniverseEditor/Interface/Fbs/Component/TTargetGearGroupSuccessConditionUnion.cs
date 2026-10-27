using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CBB RID: 23739
	public class TTargetGearGroupSuccessConditionUnion
	{
		// Token: 0x1700B25A RID: 45658
		// (get) Token: 0x06028A33 RID: 166451 RVA: 0x00595830 File Offset: 0x00593A30
		// (set) Token: 0x06028A34 RID: 166452 RVA: 0x00595838 File Offset: 0x00593A38
		public TTargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x1700B25B RID: 45659
		// (get) Token: 0x06028A35 RID: 166453 RVA: 0x00595841 File Offset: 0x00593A41
		// (set) Token: 0x06028A36 RID: 166454 RVA: 0x00595849 File Offset: 0x00593A49
		public object Value { get; set; }

		// Token: 0x06028A37 RID: 166455 RVA: 0x00595852 File Offset: 0x00593A52
		public TTargetGearGroupSuccessConditionUnion()
		{
			this.Type = TTargetGearGroupSuccessCondition.NONE;
			this.Value = null;
		}

		// Token: 0x06028A38 RID: 166456 RVA: 0x00595868 File Offset: 0x00593A68
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A39 RID: 166457 RVA: 0x0059587A File Offset: 0x00593A7A
		public ISuccessConditionCountDownStateT AsISuccessConditionCountDownState()
		{
			return this.As<ISuccessConditionCountDownStateT>();
		}

		// Token: 0x06028A3A RID: 166458 RVA: 0x00595882 File Offset: 0x00593A82
		public static TTargetGearGroupSuccessConditionUnion FromISuccessConditionCountDownState(ISuccessConditionCountDownStateT _isuccessconditioncountdownstate)
		{
			return new TTargetGearGroupSuccessConditionUnion
			{
				Type = TTargetGearGroupSuccessCondition.ISuccessConditionCountDownState,
				Value = _isuccessconditioncountdownstate
			};
		}

		// Token: 0x06028A3B RID: 166459 RVA: 0x00595897 File Offset: 0x00593A97
		public ISuccessConditionSameArbitraryStateT AsISuccessConditionSameArbitraryState()
		{
			return this.As<ISuccessConditionSameArbitraryStateT>();
		}

		// Token: 0x06028A3C RID: 166460 RVA: 0x0059589F File Offset: 0x00593A9F
		public static TTargetGearGroupSuccessConditionUnion FromISuccessConditionSameArbitraryState(ISuccessConditionSameArbitraryStateT _isuccessconditionsamearbitrarystate)
		{
			return new TTargetGearGroupSuccessConditionUnion
			{
				Type = TTargetGearGroupSuccessCondition.ISuccessConditionSameArbitraryState,
				Value = _isuccessconditionsamearbitrarystate
			};
		}

		// Token: 0x06028A3D RID: 166461 RVA: 0x005958B4 File Offset: 0x00593AB4
		public ISuccessConditionSameSpecificStateT AsISuccessConditionSameSpecificState()
		{
			return this.As<ISuccessConditionSameSpecificStateT>();
		}

		// Token: 0x06028A3E RID: 166462 RVA: 0x005958BC File Offset: 0x00593ABC
		public static TTargetGearGroupSuccessConditionUnion FromISuccessConditionSameSpecificState(ISuccessConditionSameSpecificStateT _isuccessconditionsamespecificstate)
		{
			return new TTargetGearGroupSuccessConditionUnion
			{
				Type = TTargetGearGroupSuccessCondition.ISuccessConditionSameSpecificState,
				Value = _isuccessconditionsamespecificstate
			};
		}

		// Token: 0x06028A3F RID: 166463 RVA: 0x005958D1 File Offset: 0x00593AD1
		public ISuccessConditionSpecificTargetStateT AsISuccessConditionSpecificTargetState()
		{
			return this.As<ISuccessConditionSpecificTargetStateT>();
		}

		// Token: 0x06028A40 RID: 166464 RVA: 0x005958D9 File Offset: 0x00593AD9
		public static TTargetGearGroupSuccessConditionUnion FromISuccessConditionSpecificTargetState(ISuccessConditionSpecificTargetStateT _isuccessconditionspecifictargetstate)
		{
			return new TTargetGearGroupSuccessConditionUnion
			{
				Type = TTargetGearGroupSuccessCondition.ISuccessConditionSpecificTargetState,
				Value = _isuccessconditionspecifictargetstate
			};
		}

		// Token: 0x06028A41 RID: 166465 RVA: 0x005958F0 File Offset: 0x00593AF0
		public static int Pack(FlatBufferBuilder builder, TTargetGearGroupSuccessConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TTargetGearGroupSuccessCondition.ISuccessConditionCountDownState:
				return ISuccessConditionCountDownState.Pack(builder, _o.AsISuccessConditionCountDownState()).Value;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSameArbitraryState:
				return ISuccessConditionSameArbitraryState.Pack(builder, _o.AsISuccessConditionSameArbitraryState()).Value;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSameSpecificState:
				return ISuccessConditionSameSpecificState.Pack(builder, _o.AsISuccessConditionSameSpecificState()).Value;
			case TTargetGearGroupSuccessCondition.ISuccessConditionSpecificTargetState:
				return ISuccessConditionSpecificTargetState.Pack(builder, _o.AsISuccessConditionSpecificTargetState()).Value;
			default:
				return 0;
			}
		}
	}
}
