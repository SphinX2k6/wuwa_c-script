using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C55 RID: 23637
	public class TLevelAIBehaviourUnion
	{
		// Token: 0x1700B216 RID: 45590
		// (get) Token: 0x06028845 RID: 165957 RVA: 0x00592AFE File Offset: 0x00590CFE
		// (set) Token: 0x06028846 RID: 165958 RVA: 0x00592B06 File Offset: 0x00590D06
		public TLevelAIBehaviour Type { get; set; }

		// Token: 0x1700B217 RID: 45591
		// (get) Token: 0x06028847 RID: 165959 RVA: 0x00592B0F File Offset: 0x00590D0F
		// (set) Token: 0x06028848 RID: 165960 RVA: 0x00592B17 File Offset: 0x00590D17
		public object Value { get; set; }

		// Token: 0x06028849 RID: 165961 RVA: 0x00592B20 File Offset: 0x00590D20
		public TLevelAIBehaviourUnion()
		{
			this.Type = TLevelAIBehaviour.NONE;
			this.Value = null;
		}

		// Token: 0x0602884A RID: 165962 RVA: 0x00592B36 File Offset: 0x00590D36
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602884B RID: 165963 RVA: 0x00592B48 File Offset: 0x00590D48
		public IInteractBehaviourActionsT AsIInteractBehaviourActions()
		{
			return this.As<IInteractBehaviourActionsT>();
		}

		// Token: 0x0602884C RID: 165964 RVA: 0x00592B50 File Offset: 0x00590D50
		public static TLevelAIBehaviourUnion FromIInteractBehaviourActions(IInteractBehaviourActionsT _iinteractbehaviouractions)
		{
			return new TLevelAIBehaviourUnion
			{
				Type = TLevelAIBehaviour.IInteractBehaviourActions,
				Value = _iinteractbehaviouractions
			};
		}

		// Token: 0x0602884D RID: 165965 RVA: 0x00592B65 File Offset: 0x00590D65
		public ILevelAIBehaviourSplineT AsILevelAIBehaviourSpline()
		{
			return this.As<ILevelAIBehaviourSplineT>();
		}

		// Token: 0x0602884E RID: 165966 RVA: 0x00592B6D File Offset: 0x00590D6D
		public static TLevelAIBehaviourUnion FromILevelAIBehaviourSpline(ILevelAIBehaviourSplineT _ilevelaibehaviourspline)
		{
			return new TLevelAIBehaviourUnion
			{
				Type = TLevelAIBehaviour.ILevelAIBehaviourSpline,
				Value = _ilevelaibehaviourspline
			};
		}

		// Token: 0x0602884F RID: 165967 RVA: 0x00592B84 File Offset: 0x00590D84
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
