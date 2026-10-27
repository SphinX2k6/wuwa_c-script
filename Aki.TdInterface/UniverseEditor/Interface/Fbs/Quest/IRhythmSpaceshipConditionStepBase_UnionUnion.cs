using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040AA RID: 16554
	public class IRhythmSpaceshipConditionStepBase_UnionUnion
	{
		// Token: 0x170074D8 RID: 29912
		// (get) Token: 0x060181C7 RID: 98759 RVA: 0x00379FF9 File Offset: 0x003781F9
		// (set) Token: 0x060181C8 RID: 98760 RVA: 0x0037A001 File Offset: 0x00378201
		public IRhythmSpaceshipConditionStepBase_Union Type { get; set; }

		// Token: 0x170074D9 RID: 29913
		// (get) Token: 0x060181C9 RID: 98761 RVA: 0x0037A00A File Offset: 0x0037820A
		// (set) Token: 0x060181CA RID: 98762 RVA: 0x0037A012 File Offset: 0x00378212
		public object Value { get; set; }

		// Token: 0x060181CB RID: 98763 RVA: 0x0037A01B File Offset: 0x0037821B
		public IRhythmSpaceshipConditionStepBase_UnionUnion()
		{
			this.Type = IRhythmSpaceshipConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060181CC RID: 98764 RVA: 0x0037A031 File Offset: 0x00378231
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060181CD RID: 98765 RVA: 0x0037A043 File Offset: 0x00378243
		public IRhythmSpaceshipConditionStepBaseT AsIRhythmSpaceshipConditionStepBase()
		{
			return this.As<IRhythmSpaceshipConditionStepBaseT>();
		}

		// Token: 0x060181CE RID: 98766 RVA: 0x0037A04B File Offset: 0x0037824B
		public static IRhythmSpaceshipConditionStepBase_UnionUnion FromIRhythmSpaceshipConditionStepBase(IRhythmSpaceshipConditionStepBaseT _irhythmspaceshipconditionstepbase)
		{
			return new IRhythmSpaceshipConditionStepBase_UnionUnion
			{
				Type = IRhythmSpaceshipConditionStepBase_Union.IRhythmSpaceshipConditionStepBase,
				Value = _irhythmspaceshipconditionstepbase
			};
		}

		// Token: 0x060181CF RID: 98767 RVA: 0x0037A060 File Offset: 0x00378260
		public IRhythmSpaceshipConditionStepInteractT AsIRhythmSpaceshipConditionStepInteract()
		{
			return this.As<IRhythmSpaceshipConditionStepInteractT>();
		}

		// Token: 0x060181D0 RID: 98768 RVA: 0x0037A068 File Offset: 0x00378268
		public static IRhythmSpaceshipConditionStepBase_UnionUnion FromIRhythmSpaceshipConditionStepInteract(IRhythmSpaceshipConditionStepInteractT _irhythmspaceshipconditionstepinteract)
		{
			return new IRhythmSpaceshipConditionStepBase_UnionUnion
			{
				Type = IRhythmSpaceshipConditionStepBase_Union.IRhythmSpaceshipConditionStepInteract,
				Value = _irhythmspaceshipconditionstepinteract
			};
		}

		// Token: 0x060181D1 RID: 98769 RVA: 0x0037A080 File Offset: 0x00378280
		public static int Pack(FlatBufferBuilder builder, IRhythmSpaceshipConditionStepBase_UnionUnion _o)
		{
			IRhythmSpaceshipConditionStepBase_Union type = _o.Type;
			if (type == IRhythmSpaceshipConditionStepBase_Union.IRhythmSpaceshipConditionStepBase)
			{
				return IRhythmSpaceshipConditionStepBase.Pack(builder, _o.AsIRhythmSpaceshipConditionStepBase()).Value;
			}
			if (type != IRhythmSpaceshipConditionStepBase_Union.IRhythmSpaceshipConditionStepInteract)
			{
				return 0;
			}
			return IRhythmSpaceshipConditionStepInteract.Pack(builder, _o.AsIRhythmSpaceshipConditionStepInteract()).Value;
		}
	}
}
