using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007434 RID: 29748
	public class IPhotographCameraTransformBase_UnionUnion
	{
		// Token: 0x1700DA7A RID: 55930
		// (get) Token: 0x060340BC RID: 213180 RVA: 0x0070385D File Offset: 0x00701A5D
		// (set) Token: 0x060340BD RID: 213181 RVA: 0x00703865 File Offset: 0x00701A65
		public IPhotographCameraTransformBase_Union Type { get; set; }

		// Token: 0x1700DA7B RID: 55931
		// (get) Token: 0x060340BE RID: 213182 RVA: 0x0070386E File Offset: 0x00701A6E
		// (set) Token: 0x060340BF RID: 213183 RVA: 0x00703876 File Offset: 0x00701A76
		public object Value { get; set; }

		// Token: 0x060340C0 RID: 213184 RVA: 0x0070387F File Offset: 0x00701A7F
		public IPhotographCameraTransformBase_UnionUnion()
		{
			this.Type = IPhotographCameraTransformBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060340C1 RID: 213185 RVA: 0x00703895 File Offset: 0x00701A95
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060340C2 RID: 213186 RVA: 0x007038A7 File Offset: 0x00701AA7
		public IPhotographCameraTransformBaseT AsIPhotographCameraTransformBase()
		{
			return this.As<IPhotographCameraTransformBaseT>();
		}

		// Token: 0x060340C3 RID: 213187 RVA: 0x007038AF File Offset: 0x00701AAF
		public static IPhotographCameraTransformBase_UnionUnion FromIPhotographCameraTransformBase(IPhotographCameraTransformBaseT _iphotographcameratransformbase)
		{
			return new IPhotographCameraTransformBase_UnionUnion
			{
				Type = IPhotographCameraTransformBase_Union.IPhotographCameraTransformBase,
				Value = _iphotographcameratransformbase
			};
		}

		// Token: 0x060340C4 RID: 213188 RVA: 0x007038C4 File Offset: 0x00701AC4
		public IPhotographCameraTransformAbsoluteT AsIPhotographCameraTransformAbsolute()
		{
			return this.As<IPhotographCameraTransformAbsoluteT>();
		}

		// Token: 0x060340C5 RID: 213189 RVA: 0x007038CC File Offset: 0x00701ACC
		public static IPhotographCameraTransformBase_UnionUnion FromIPhotographCameraTransformAbsolute(IPhotographCameraTransformAbsoluteT _iphotographcameratransformabsolute)
		{
			return new IPhotographCameraTransformBase_UnionUnion
			{
				Type = IPhotographCameraTransformBase_Union.IPhotographCameraTransformAbsolute,
				Value = _iphotographcameratransformabsolute
			};
		}

		// Token: 0x060340C6 RID: 213190 RVA: 0x007038E4 File Offset: 0x00701AE4
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
