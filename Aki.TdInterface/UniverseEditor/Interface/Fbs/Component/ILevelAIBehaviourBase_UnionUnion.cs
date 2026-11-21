using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A48 RID: 23112
	public class ILevelAIBehaviourBase_UnionUnion
	{
		// Token: 0x1700A81B RID: 43035
		// (get) Token: 0x06025CC2 RID: 154818 RVA: 0x0052E7FD File Offset: 0x0052C9FD
		// (set) Token: 0x06025CC3 RID: 154819 RVA: 0x0052E805 File Offset: 0x0052CA05
		public ILevelAIBehaviourBase_Union Type { get; set; }

		// Token: 0x1700A81C RID: 43036
		// (get) Token: 0x06025CC4 RID: 154820 RVA: 0x0052E80E File Offset: 0x0052CA0E
		// (set) Token: 0x06025CC5 RID: 154821 RVA: 0x0052E816 File Offset: 0x0052CA16
		public object Value { get; set; }

		// Token: 0x06025CC6 RID: 154822 RVA: 0x0052E81F File Offset: 0x0052CA1F
		public ILevelAIBehaviourBase_UnionUnion()
		{
			this.Type = ILevelAIBehaviourBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025CC7 RID: 154823 RVA: 0x0052E835 File Offset: 0x0052CA35
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025CC8 RID: 154824 RVA: 0x0052E847 File Offset: 0x0052CA47
		public ILevelAIBehaviourBaseT AsILevelAIBehaviourBase()
		{
			return this.As<ILevelAIBehaviourBaseT>();
		}

		// Token: 0x06025CC9 RID: 154825 RVA: 0x0052E84F File Offset: 0x0052CA4F
		public static ILevelAIBehaviourBase_UnionUnion FromILevelAIBehaviourBase(ILevelAIBehaviourBaseT _ilevelaibehaviourbase)
		{
			return new ILevelAIBehaviourBase_UnionUnion
			{
				Type = ILevelAIBehaviourBase_Union.ILevelAIBehaviourBase,
				Value = _ilevelaibehaviourbase
			};
		}

		// Token: 0x06025CCA RID: 154826 RVA: 0x0052E864 File Offset: 0x0052CA64
		public ILevelAIBehaviourSplineT AsILevelAIBehaviourSpline()
		{
			return this.As<ILevelAIBehaviourSplineT>();
		}

		// Token: 0x06025CCB RID: 154827 RVA: 0x0052E86C File Offset: 0x0052CA6C
		public static ILevelAIBehaviourBase_UnionUnion FromILevelAIBehaviourSpline(ILevelAIBehaviourSplineT _ilevelaibehaviourspline)
		{
			return new ILevelAIBehaviourBase_UnionUnion
			{
				Type = ILevelAIBehaviourBase_Union.ILevelAIBehaviourSpline,
				Value = _ilevelaibehaviourspline
			};
		}

		// Token: 0x06025CCC RID: 154828 RVA: 0x0052E881 File Offset: 0x0052CA81
		public IInteractBehaviourActionsT AsIInteractBehaviourActions()
		{
			return this.As<IInteractBehaviourActionsT>();
		}

		// Token: 0x06025CCD RID: 154829 RVA: 0x0052E889 File Offset: 0x0052CA89
		public static ILevelAIBehaviourBase_UnionUnion FromIInteractBehaviourActions(IInteractBehaviourActionsT _iinteractbehaviouractions)
		{
			return new ILevelAIBehaviourBase_UnionUnion
			{
				Type = ILevelAIBehaviourBase_Union.IInteractBehaviourActions,
				Value = _iinteractbehaviouractions
			};
		}

		// Token: 0x06025CCE RID: 154830 RVA: 0x0052E8A0 File Offset: 0x0052CAA0
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
