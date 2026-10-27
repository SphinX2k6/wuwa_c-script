using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C2 RID: 21698
	public class ILevelAIBehaviourBase_UnionUnion
	{
		// Token: 0x17009FE1 RID: 40929
		// (get) Token: 0x06023C0A RID: 146442 RVA: 0x004F1789 File Offset: 0x004EF989
		// (set) Token: 0x06023C0B RID: 146443 RVA: 0x004F1791 File Offset: 0x004EF991
		public ILevelAIBehaviourBase_Union Type { get; set; }

		// Token: 0x17009FE2 RID: 40930
		// (get) Token: 0x06023C0C RID: 146444 RVA: 0x004F179A File Offset: 0x004EF99A
		// (set) Token: 0x06023C0D RID: 146445 RVA: 0x004F17A2 File Offset: 0x004EF9A2
		public object Value { get; set; }

		// Token: 0x06023C0E RID: 146446 RVA: 0x004F17AB File Offset: 0x004EF9AB
		public ILevelAIBehaviourBase_UnionUnion()
		{
			this.Type = ILevelAIBehaviourBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023C0F RID: 146447 RVA: 0x004F17C1 File Offset: 0x004EF9C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023C10 RID: 146448 RVA: 0x004F17D3 File Offset: 0x004EF9D3
		public ILevelAIBehaviourBaseT AsILevelAIBehaviourBase()
		{
			return this.As<ILevelAIBehaviourBaseT>();
		}

		// Token: 0x06023C11 RID: 146449 RVA: 0x004F17DB File Offset: 0x004EF9DB
		public static ILevelAIBehaviourBase_UnionUnion FromILevelAIBehaviourBase(ILevelAIBehaviourBaseT _ilevelaibehaviourbase)
		{
			return new ILevelAIBehaviourBase_UnionUnion
			{
				Type = ILevelAIBehaviourBase_Union.ILevelAIBehaviourBase,
				Value = _ilevelaibehaviourbase
			};
		}

		// Token: 0x06023C12 RID: 146450 RVA: 0x004F17F0 File Offset: 0x004EF9F0
		public ILevelAIBehaviourSplineT AsILevelAIBehaviourSpline()
		{
			return this.As<ILevelAIBehaviourSplineT>();
		}

		// Token: 0x06023C13 RID: 146451 RVA: 0x004F17F8 File Offset: 0x004EF9F8
		public static ILevelAIBehaviourBase_UnionUnion FromILevelAIBehaviourSpline(ILevelAIBehaviourSplineT _ilevelaibehaviourspline)
		{
			return new ILevelAIBehaviourBase_UnionUnion
			{
				Type = ILevelAIBehaviourBase_Union.ILevelAIBehaviourSpline,
				Value = _ilevelaibehaviourspline
			};
		}

		// Token: 0x06023C14 RID: 146452 RVA: 0x004F180D File Offset: 0x004EFA0D
		public IInteractBehaviourActionsT AsIInteractBehaviourActions()
		{
			return this.As<IInteractBehaviourActionsT>();
		}

		// Token: 0x06023C15 RID: 146453 RVA: 0x004F1815 File Offset: 0x004EFA15
		public static ILevelAIBehaviourBase_UnionUnion FromIInteractBehaviourActions(IInteractBehaviourActionsT _iinteractbehaviouractions)
		{
			return new ILevelAIBehaviourBase_UnionUnion
			{
				Type = ILevelAIBehaviourBase_Union.IInteractBehaviourActions,
				Value = _iinteractbehaviouractions
			};
		}

		// Token: 0x06023C16 RID: 146454 RVA: 0x004F182C File Offset: 0x004EFA2C
		public static int Pack(FlatBufferBuilder builder, ILevelAIBehaviourBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILevelAIBehaviourBase_Union.ILevelAIBehaviourBase:
				return ILevelAIBehaviourBase.Pack(builder, _o.AsILevelAIBehaviourBase()).Value;
			case ILevelAIBehaviourBase_Union.ILevelAIBehaviourSpline:
				return ILevelAIBehaviourSpline.Pack(builder, _o.AsILevelAIBehaviourSpline()).Value;
			case ILevelAIBehaviourBase_Union.IInteractBehaviourActions:
				return IInteractBehaviourActions.Pack(builder, _o.AsIInteractBehaviourActions()).Value;
			default:
				return 0;
			}
		}
	}
}
