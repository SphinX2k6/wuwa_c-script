using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044EB RID: 17643
	public class IRhythmSpaceshipConditionStepBase_UnionUnion
	{
		// Token: 0x17007ADE RID: 31454
		// (get) Token: 0x06019868 RID: 104552 RVA: 0x003A3F49 File Offset: 0x003A2149
		// (set) Token: 0x06019869 RID: 104553 RVA: 0x003A3F51 File Offset: 0x003A2151
		public IRhythmSpaceshipConditionStepBase_Union Type { get; set; }

		// Token: 0x17007ADF RID: 31455
		// (get) Token: 0x0601986A RID: 104554 RVA: 0x003A3F5A File Offset: 0x003A215A
		// (set) Token: 0x0601986B RID: 104555 RVA: 0x003A3F62 File Offset: 0x003A2162
		public object Value { get; set; }

		// Token: 0x0601986C RID: 104556 RVA: 0x003A3F6B File Offset: 0x003A216B
		public IRhythmSpaceshipConditionStepBase_UnionUnion()
		{
			this.Type = IRhythmSpaceshipConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601986D RID: 104557 RVA: 0x003A3F81 File Offset: 0x003A2181
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601986E RID: 104558 RVA: 0x003A3F93 File Offset: 0x003A2193
		public IRhythmSpaceshipConditionStepBaseT AsIRhythmSpaceshipConditionStepBase()
		{
			return this.As<IRhythmSpaceshipConditionStepBaseT>();
		}

		// Token: 0x0601986F RID: 104559 RVA: 0x003A3F9B File Offset: 0x003A219B
		public static IRhythmSpaceshipConditionStepBase_UnionUnion FromIRhythmSpaceshipConditionStepBase(IRhythmSpaceshipConditionStepBaseT _irhythmspaceshipconditionstepbase)
		{
			return new IRhythmSpaceshipConditionStepBase_UnionUnion
			{
				Type = IRhythmSpaceshipConditionStepBase_Union.IRhythmSpaceshipConditionStepBase,
				Value = _irhythmspaceshipconditionstepbase
			};
		}

		// Token: 0x06019870 RID: 104560 RVA: 0x003A3FB0 File Offset: 0x003A21B0
		public IRhythmSpaceshipConditionStepInteractT AsIRhythmSpaceshipConditionStepInteract()
		{
			return this.As<IRhythmSpaceshipConditionStepInteractT>();
		}

		// Token: 0x06019871 RID: 104561 RVA: 0x003A3FB8 File Offset: 0x003A21B8
		public static IRhythmSpaceshipConditionStepBase_UnionUnion FromIRhythmSpaceshipConditionStepInteract(IRhythmSpaceshipConditionStepInteractT _irhythmspaceshipconditionstepinteract)
		{
			return new IRhythmSpaceshipConditionStepBase_UnionUnion
			{
				Type = IRhythmSpaceshipConditionStepBase_Union.IRhythmSpaceshipConditionStepInteract,
				Value = _irhythmspaceshipconditionstepinteract
			};
		}

		// Token: 0x06019872 RID: 104562 RVA: 0x003A3FD0 File Offset: 0x003A21D0
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
