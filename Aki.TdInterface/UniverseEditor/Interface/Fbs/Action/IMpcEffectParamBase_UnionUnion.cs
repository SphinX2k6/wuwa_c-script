using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B8F RID: 27535
	public class IMpcEffectParamBase_UnionUnion
	{
		// Token: 0x1700CCAC RID: 52396
		// (get) Token: 0x060305B3 RID: 198067 RVA: 0x00691B09 File Offset: 0x0068FD09
		// (set) Token: 0x060305B4 RID: 198068 RVA: 0x00691B11 File Offset: 0x0068FD11
		public IMpcEffectParamBase_Union Type { get; set; }

		// Token: 0x1700CCAD RID: 52397
		// (get) Token: 0x060305B5 RID: 198069 RVA: 0x00691B1A File Offset: 0x0068FD1A
		// (set) Token: 0x060305B6 RID: 198070 RVA: 0x00691B22 File Offset: 0x0068FD22
		public object Value { get; set; }

		// Token: 0x060305B7 RID: 198071 RVA: 0x00691B2B File Offset: 0x0068FD2B
		public IMpcEffectParamBase_UnionUnion()
		{
			this.Type = IMpcEffectParamBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060305B8 RID: 198072 RVA: 0x00691B41 File Offset: 0x0068FD41
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060305B9 RID: 198073 RVA: 0x00691B53 File Offset: 0x0068FD53
		public IMpcEffectParamBaseT AsIMpcEffectParamBase()
		{
			return this.As<IMpcEffectParamBaseT>();
		}

		// Token: 0x060305BA RID: 198074 RVA: 0x00691B5B File Offset: 0x0068FD5B
		public static IMpcEffectParamBase_UnionUnion FromIMpcEffectParamBase(IMpcEffectParamBaseT _impceffectparambase)
		{
			return new IMpcEffectParamBase_UnionUnion
			{
				Type = IMpcEffectParamBase_Union.IMpcEffectParamBase,
				Value = _impceffectparambase
			};
		}

		// Token: 0x060305BB RID: 198075 RVA: 0x00691B70 File Offset: 0x0068FD70
		public IPostProcessVolumeCenterPositionT AsIPostProcessVolumeCenterPosition()
		{
			return this.As<IPostProcessVolumeCenterPositionT>();
		}

		// Token: 0x060305BC RID: 198076 RVA: 0x00691B78 File Offset: 0x0068FD78
		public static IMpcEffectParamBase_UnionUnion FromIPostProcessVolumeCenterPosition(IPostProcessVolumeCenterPositionT _ipostprocessvolumecenterposition)
		{
			return new IMpcEffectParamBase_UnionUnion
			{
				Type = IMpcEffectParamBase_Union.IPostProcessVolumeCenterPosition,
				Value = _ipostprocessvolumecenterposition
			};
		}

		// Token: 0x060305BD RID: 198077 RVA: 0x00691B90 File Offset: 0x0068FD90
		public static int Pack(FlatBufferBuilder builder, IMpcEffectParamBase_UnionUnion _o)
		{
			IMpcEffectParamBase_Union type = _o.Type;
			if (type == IMpcEffectParamBase_Union.IMpcEffectParamBase)
			{
				return IMpcEffectParamBase.Pack(builder, _o.AsIMpcEffectParamBase()).Value;
			}
			if (type != IMpcEffectParamBase_Union.IPostProcessVolumeCenterPosition)
			{
				return 0;
			}
			return IPostProcessVolumeCenterPosition.Pack(builder, _o.AsIPostProcessVolumeCenterPosition()).Value;
		}
	}
}
