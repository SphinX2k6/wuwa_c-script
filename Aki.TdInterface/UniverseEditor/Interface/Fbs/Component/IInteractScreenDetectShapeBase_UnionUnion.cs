using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F4 RID: 23028
	public class IInteractScreenDetectShapeBase_UnionUnion
	{
		// Token: 0x1700A754 RID: 42836
		// (get) Token: 0x06025995 RID: 154005 RVA: 0x00527E35 File Offset: 0x00526035
		// (set) Token: 0x06025996 RID: 154006 RVA: 0x00527E3D File Offset: 0x0052603D
		public IInteractScreenDetectShapeBase_Union Type { get; set; }

		// Token: 0x1700A755 RID: 42837
		// (get) Token: 0x06025997 RID: 154007 RVA: 0x00527E46 File Offset: 0x00526046
		// (set) Token: 0x06025998 RID: 154008 RVA: 0x00527E4E File Offset: 0x0052604E
		public object Value { get; set; }

		// Token: 0x06025999 RID: 154009 RVA: 0x00527E57 File Offset: 0x00526057
		public IInteractScreenDetectShapeBase_UnionUnion()
		{
			this.Type = IInteractScreenDetectShapeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602599A RID: 154010 RVA: 0x00527E6D File Offset: 0x0052606D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602599B RID: 154011 RVA: 0x00527E7F File Offset: 0x0052607F
		public IInteractScreenDetectShapeBaseT AsIInteractScreenDetectShapeBase()
		{
			return this.As<IInteractScreenDetectShapeBaseT>();
		}

		// Token: 0x0602599C RID: 154012 RVA: 0x00527E87 File Offset: 0x00526087
		public static IInteractScreenDetectShapeBase_UnionUnion FromIInteractScreenDetectShapeBase(IInteractScreenDetectShapeBaseT _iinteractscreendetectshapebase)
		{
			return new IInteractScreenDetectShapeBase_UnionUnion
			{
				Type = IInteractScreenDetectShapeBase_Union.IInteractScreenDetectShapeBase,
				Value = _iinteractscreendetectshapebase
			};
		}

		// Token: 0x0602599D RID: 154013 RVA: 0x00527E9C File Offset: 0x0052609C
		public IInteractScreenDetectShapeCircleT AsIInteractScreenDetectShapeCircle()
		{
			return this.As<IInteractScreenDetectShapeCircleT>();
		}

		// Token: 0x0602599E RID: 154014 RVA: 0x00527EA4 File Offset: 0x005260A4
		public static IInteractScreenDetectShapeBase_UnionUnion FromIInteractScreenDetectShapeCircle(IInteractScreenDetectShapeCircleT _iinteractscreendetectshapecircle)
		{
			return new IInteractScreenDetectShapeBase_UnionUnion
			{
				Type = IInteractScreenDetectShapeBase_Union.IInteractScreenDetectShapeCircle,
				Value = _iinteractscreendetectshapecircle
			};
		}

		// Token: 0x0602599F RID: 154015 RVA: 0x00527EBC File Offset: 0x005260BC
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
