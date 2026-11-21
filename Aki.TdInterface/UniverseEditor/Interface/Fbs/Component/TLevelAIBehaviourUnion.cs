using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200627A RID: 25210
	public class TLevelAIBehaviourUnion
	{
		// Token: 0x1700BB68 RID: 47976
		// (get) Token: 0x0602AE53 RID: 175699 RVA: 0x005DAD16 File Offset: 0x005D8F16
		// (set) Token: 0x0602AE54 RID: 175700 RVA: 0x005DAD1E File Offset: 0x005D8F1E
		public TLevelAIBehaviour Type { get; set; }

		// Token: 0x1700BB69 RID: 47977
		// (get) Token: 0x0602AE55 RID: 175701 RVA: 0x005DAD27 File Offset: 0x005D8F27
		// (set) Token: 0x0602AE56 RID: 175702 RVA: 0x005DAD2F File Offset: 0x005D8F2F
		public object Value { get; set; }

		// Token: 0x0602AE57 RID: 175703 RVA: 0x005DAD38 File Offset: 0x005D8F38
		public TLevelAIBehaviourUnion()
		{
			this.Type = TLevelAIBehaviour.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE58 RID: 175704 RVA: 0x005DAD4E File Offset: 0x005D8F4E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE59 RID: 175705 RVA: 0x005DAD60 File Offset: 0x005D8F60
		public IInteractBehaviourActionsT AsIInteractBehaviourActions()
		{
			return this.As<IInteractBehaviourActionsT>();
		}

		// Token: 0x0602AE5A RID: 175706 RVA: 0x005DAD68 File Offset: 0x005D8F68
		public static TLevelAIBehaviourUnion FromIInteractBehaviourActions(IInteractBehaviourActionsT _iinteractbehaviouractions)
		{
			return new TLevelAIBehaviourUnion
			{
				Type = TLevelAIBehaviour.IInteractBehaviourActions,
				Value = _iinteractbehaviouractions
			};
		}

		// Token: 0x0602AE5B RID: 175707 RVA: 0x005DAD7D File Offset: 0x005D8F7D
		public ILevelAIBehaviourSplineT AsILevelAIBehaviourSpline()
		{
			return this.As<ILevelAIBehaviourSplineT>();
		}

		// Token: 0x0602AE5C RID: 175708 RVA: 0x005DAD85 File Offset: 0x005D8F85
		public static TLevelAIBehaviourUnion FromILevelAIBehaviourSpline(ILevelAIBehaviourSplineT _ilevelaibehaviourspline)
		{
			return new TLevelAIBehaviourUnion
			{
				Type = TLevelAIBehaviour.ILevelAIBehaviourSpline,
				Value = _ilevelaibehaviourspline
			};
		}

		// Token: 0x0602AE5D RID: 175709 RVA: 0x005DAD9C File Offset: 0x005D8F9C
		public static int Pack(FlatBufferBuilder builder, TLevelAIBehaviourUnion _o)
		{
			TLevelAIBehaviour type = _o.Type;
			if (type == TLevelAIBehaviour.IInteractBehaviourActions)
			{
				return IInteractBehaviourActions.Pack(builder, _o.AsIInteractBehaviourActions()).Value;
			}
			if (type != TLevelAIBehaviour.ILevelAIBehaviourSpline)
			{
				return 0;
			}
			return ILevelAIBehaviourSpline.Pack(builder, _o.AsILevelAIBehaviourSpline()).Value;
		}
	}
}
