using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200546E RID: 21614
	public class IInteractScreenDetectShapeBase_UnionUnion
	{
		// Token: 0x17009F1A RID: 40730
		// (get) Token: 0x060238DD RID: 145629 RVA: 0x004EADC1 File Offset: 0x004E8FC1
		// (set) Token: 0x060238DE RID: 145630 RVA: 0x004EADC9 File Offset: 0x004E8FC9
		public IInteractScreenDetectShapeBase_Union Type { get; set; }

		// Token: 0x17009F1B RID: 40731
		// (get) Token: 0x060238DF RID: 145631 RVA: 0x004EADD2 File Offset: 0x004E8FD2
		// (set) Token: 0x060238E0 RID: 145632 RVA: 0x004EADDA File Offset: 0x004E8FDA
		public object Value { get; set; }

		// Token: 0x060238E1 RID: 145633 RVA: 0x004EADE3 File Offset: 0x004E8FE3
		public IInteractScreenDetectShapeBase_UnionUnion()
		{
			this.Type = IInteractScreenDetectShapeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060238E2 RID: 145634 RVA: 0x004EADF9 File Offset: 0x004E8FF9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060238E3 RID: 145635 RVA: 0x004EAE0B File Offset: 0x004E900B
		public IInteractScreenDetectShapeBaseT AsIInteractScreenDetectShapeBase()
		{
			return this.As<IInteractScreenDetectShapeBaseT>();
		}

		// Token: 0x060238E4 RID: 145636 RVA: 0x004EAE13 File Offset: 0x004E9013
		public static IInteractScreenDetectShapeBase_UnionUnion FromIInteractScreenDetectShapeBase(IInteractScreenDetectShapeBaseT _iinteractscreendetectshapebase)
		{
			return new IInteractScreenDetectShapeBase_UnionUnion
			{
				Type = IInteractScreenDetectShapeBase_Union.IInteractScreenDetectShapeBase,
				Value = _iinteractscreendetectshapebase
			};
		}

		// Token: 0x060238E5 RID: 145637 RVA: 0x004EAE28 File Offset: 0x004E9028
		public IInteractScreenDetectShapeCircleT AsIInteractScreenDetectShapeCircle()
		{
			return this.As<IInteractScreenDetectShapeCircleT>();
		}

		// Token: 0x060238E6 RID: 145638 RVA: 0x004EAE30 File Offset: 0x004E9030
		public static IInteractScreenDetectShapeBase_UnionUnion FromIInteractScreenDetectShapeCircle(IInteractScreenDetectShapeCircleT _iinteractscreendetectshapecircle)
		{
			return new IInteractScreenDetectShapeBase_UnionUnion
			{
				Type = IInteractScreenDetectShapeBase_Union.IInteractScreenDetectShapeCircle,
				Value = _iinteractscreendetectshapecircle
			};
		}

		// Token: 0x060238E7 RID: 145639 RVA: 0x004EAE48 File Offset: 0x004E9048
		public static int Pack(FlatBufferBuilder builder, IInteractScreenDetectShapeBase_UnionUnion _o)
		{
			IInteractScreenDetectShapeBase_Union type = _o.Type;
			if (type == IInteractScreenDetectShapeBase_Union.IInteractScreenDetectShapeBase)
			{
				return IInteractScreenDetectShapeBase.Pack(builder, _o.AsIInteractScreenDetectShapeBase()).Value;
			}
			if (type != IInteractScreenDetectShapeBase_Union.IInteractScreenDetectShapeCircle)
			{
				return 0;
			}
			return IInteractScreenDetectShapeCircle.Pack(builder, _o.AsIInteractScreenDetectShapeCircle()).Value;
		}
	}
}
