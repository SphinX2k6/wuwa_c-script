using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006045 RID: 24645
	public class ITargetGearGroupSuccessContdion_UnionUnion
	{
		// Token: 0x1700B6E9 RID: 46825
		// (get) Token: 0x0602999A RID: 170394 RVA: 0x005ADDC9 File Offset: 0x005ABFC9
		// (set) Token: 0x0602999B RID: 170395 RVA: 0x005ADDD1 File Offset: 0x005ABFD1
		public ITargetGearGroupSuccessContdion_Union Type { get; set; }

		// Token: 0x1700B6EA RID: 46826
		// (get) Token: 0x0602999C RID: 170396 RVA: 0x005ADDDA File Offset: 0x005ABFDA
		// (set) Token: 0x0602999D RID: 170397 RVA: 0x005ADDE2 File Offset: 0x005ABFE2
		public object Value { get; set; }

		// Token: 0x0602999E RID: 170398 RVA: 0x005ADDEB File Offset: 0x005ABFEB
		public ITargetGearGroupSuccessContdion_UnionUnion()
		{
			this.Type = ITargetGearGroupSuccessContdion_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602999F RID: 170399 RVA: 0x005ADE01 File Offset: 0x005AC001
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060299A0 RID: 170400 RVA: 0x005ADE13 File Offset: 0x005AC013
		public ITargetGearGroupSuccessContdionT AsITargetGearGroupSuccessContdion()
		{
			return this.As<ITargetGearGroupSuccessContdionT>();
		}

		// Token: 0x060299A1 RID: 170401 RVA: 0x005ADE1B File Offset: 0x005AC01B
		public static ITargetGearGroupSuccessContdion_UnionUnion FromITargetGearGroupSuccessContdion(ITargetGearGroupSuccessContdionT _itargetgeargroupsuccesscontdion)
		{
			return new ITargetGearGroupSuccessContdion_UnionUnion
			{
				Type = ITargetGearGroupSuccessContdion_Union.ITargetGearGroupSuccessContdion,
				Value = _itargetgeargroupsuccesscontdion
			};
		}

		// Token: 0x060299A2 RID: 170402 RVA: 0x005ADE30 File Offset: 0x005AC030
		public ISuccessConditionSameSpecificStateT AsISuccessConditionSameSpecificState()
		{
			return this.As<ISuccessConditionSameSpecificStateT>();
		}

		// Token: 0x060299A3 RID: 170403 RVA: 0x005ADE38 File Offset: 0x005AC038
		public static ITargetGearGroupSuccessContdion_UnionUnion FromISuccessConditionSameSpecificState(ISuccessConditionSameSpecificStateT _isuccessconditionsamespecificstate)
		{
			return new ITargetGearGroupSuccessContdion_UnionUnion
			{
				Type = ITargetGearGroupSuccessContdion_Union.ISuccessConditionSameSpecificState,
				Value = _isuccessconditionsamespecificstate
			};
		}

		// Token: 0x060299A4 RID: 170404 RVA: 0x005ADE4D File Offset: 0x005AC04D
		public ISuccessConditionSameArbitraryStateT AsISuccessConditionSameArbitraryState()
		{
			return this.As<ISuccessConditionSameArbitraryStateT>();
		}

		// Token: 0x060299A5 RID: 170405 RVA: 0x005ADE55 File Offset: 0x005AC055
		public static ITargetGearGroupSuccessContdion_UnionUnion FromISuccessConditionSameArbitraryState(ISuccessConditionSameArbitraryStateT _isuccessconditionsamearbitrarystate)
		{
			return new ITargetGearGroupSuccessContdion_UnionUnion
			{
				Type = ITargetGearGroupSuccessContdion_Union.ISuccessConditionSameArbitraryState,
				Value = _isuccessconditionsamearbitrarystate
			};
		}

		// Token: 0x060299A6 RID: 170406 RVA: 0x005ADE6A File Offset: 0x005AC06A
		public ISuccessConditionCountDownStateT AsISuccessConditionCountDownState()
		{
			return this.As<ISuccessConditionCountDownStateT>();
		}

		// Token: 0x060299A7 RID: 170407 RVA: 0x005ADE72 File Offset: 0x005AC072
		public static ITargetGearGroupSuccessContdion_UnionUnion FromISuccessConditionCountDownState(ISuccessConditionCountDownStateT _isuccessconditioncountdownstate)
		{
			return new ITargetGearGroupSuccessContdion_UnionUnion
			{
				Type = ITargetGearGroupSuccessContdion_Union.ISuccessConditionCountDownState,
				Value = _isuccessconditioncountdownstate
			};
		}

		// Token: 0x060299A8 RID: 170408 RVA: 0x005ADE87 File Offset: 0x005AC087
		public ISuccessConditionSpecificTargetStateT AsISuccessConditionSpecificTargetState()
		{
			return this.As<ISuccessConditionSpecificTargetStateT>();
		}

		// Token: 0x060299A9 RID: 170409 RVA: 0x005ADE8F File Offset: 0x005AC08F
		public static ITargetGearGroupSuccessContdion_UnionUnion FromISuccessConditionSpecificTargetState(ISuccessConditionSpecificTargetStateT _isuccessconditionspecifictargetstate)
		{
			return new ITargetGearGroupSuccessContdion_UnionUnion
			{
				Type = ITargetGearGroupSuccessContdion_Union.ISuccessConditionSpecificTargetState,
				Value = _isuccessconditionspecifictargetstate
			};
		}

		// Token: 0x060299AA RID: 170410 RVA: 0x005ADEA4 File Offset: 0x005AC0A4
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
