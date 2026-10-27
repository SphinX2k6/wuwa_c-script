using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CBE RID: 27838
	public class IPhotographCameraTransformBase_UnionUnion
	{
		// Token: 0x1700CF3D RID: 53053
		// (get) Token: 0x060310E5 RID: 200933 RVA: 0x006A8629 File Offset: 0x006A6829
		// (set) Token: 0x060310E6 RID: 200934 RVA: 0x006A8631 File Offset: 0x006A6831
		public IPhotographCameraTransformBase_Union Type { get; set; }

		// Token: 0x1700CF3E RID: 53054
		// (get) Token: 0x060310E7 RID: 200935 RVA: 0x006A863A File Offset: 0x006A683A
		// (set) Token: 0x060310E8 RID: 200936 RVA: 0x006A8642 File Offset: 0x006A6842
		public object Value { get; set; }

		// Token: 0x060310E9 RID: 200937 RVA: 0x006A864B File Offset: 0x006A684B
		public IPhotographCameraTransformBase_UnionUnion()
		{
			this.Type = IPhotographCameraTransformBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060310EA RID: 200938 RVA: 0x006A8661 File Offset: 0x006A6861
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060310EB RID: 200939 RVA: 0x006A8673 File Offset: 0x006A6873
		public IPhotographCameraTransformBaseT AsIPhotographCameraTransformBase()
		{
			return this.As<IPhotographCameraTransformBaseT>();
		}

		// Token: 0x060310EC RID: 200940 RVA: 0x006A867B File Offset: 0x006A687B
		public static IPhotographCameraTransformBase_UnionUnion FromIPhotographCameraTransformBase(IPhotographCameraTransformBaseT _iphotographcameratransformbase)
		{
			return new IPhotographCameraTransformBase_UnionUnion
			{
				Type = IPhotographCameraTransformBase_Union.IPhotographCameraTransformBase,
				Value = _iphotographcameratransformbase
			};
		}

		// Token: 0x060310ED RID: 200941 RVA: 0x006A8690 File Offset: 0x006A6890
		public IPhotographCameraTransformAbsoluteT AsIPhotographCameraTransformAbsolute()
		{
			return this.As<IPhotographCameraTransformAbsoluteT>();
		}

		// Token: 0x060310EE RID: 200942 RVA: 0x006A8698 File Offset: 0x006A6898
		public static IPhotographCameraTransformBase_UnionUnion FromIPhotographCameraTransformAbsolute(IPhotographCameraTransformAbsoluteT _iphotographcameratransformabsolute)
		{
			return new IPhotographCameraTransformBase_UnionUnion
			{
				Type = IPhotographCameraTransformBase_Union.IPhotographCameraTransformAbsolute,
				Value = _iphotographcameratransformabsolute
			};
		}

		// Token: 0x060310EF RID: 200943 RVA: 0x006A86B0 File Offset: 0x006A68B0
		public static int Pack(FlatBufferBuilder builder, IPhotographCameraTransformBase_UnionUnion _o)
		{
			IPhotographCameraTransformBase_Union type = _o.Type;
			if (type == IPhotographCameraTransformBase_Union.IPhotographCameraTransformBase)
			{
				return IPhotographCameraTransformBase.Pack(builder, _o.AsIPhotographCameraTransformBase()).Value;
			}
			if (type != IPhotographCameraTransformBase_Union.IPhotographCameraTransformAbsolute)
			{
				return 0;
			}
			return IPhotographCameraTransformAbsolute.Pack(builder, _o.AsIPhotographCameraTransformAbsolute()).Value;
		}
	}
}
