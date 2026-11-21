using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB3 RID: 23475
	public class INoRenderPortalMode_UnionUnion
	{
		// Token: 0x1700AB99 RID: 43929
		// (get) Token: 0x06026B37 RID: 158519 RVA: 0x0054C3F6 File Offset: 0x0054A5F6
		// (set) Token: 0x06026B38 RID: 158520 RVA: 0x0054C3FE File Offset: 0x0054A5FE
		public INoRenderPortalMode_Union Type { get; set; }

		// Token: 0x1700AB9A RID: 43930
		// (get) Token: 0x06026B39 RID: 158521 RVA: 0x0054C407 File Offset: 0x0054A607
		// (set) Token: 0x06026B3A RID: 158522 RVA: 0x0054C40F File Offset: 0x0054A60F
		public object Value { get; set; }

		// Token: 0x06026B3B RID: 158523 RVA: 0x0054C418 File Offset: 0x0054A618
		public INoRenderPortalMode_UnionUnion()
		{
			this.Type = INoRenderPortalMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026B3C RID: 158524 RVA: 0x0054C42E File Offset: 0x0054A62E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026B3D RID: 158525 RVA: 0x0054C440 File Offset: 0x0054A640
		public INoRenderPortalModeT AsINoRenderPortalMode()
		{
			return this.As<INoRenderPortalModeT>();
		}

		// Token: 0x06026B3E RID: 158526 RVA: 0x0054C448 File Offset: 0x0054A648
		public static INoRenderPortalMode_UnionUnion FromINoRenderPortalMode(INoRenderPortalModeT _inorenderportalmode)
		{
			return new INoRenderPortalMode_UnionUnion
			{
				Type = INoRenderPortalMode_Union.INoRenderPortalMode,
				Value = _inorenderportalmode
			};
		}

		// Token: 0x06026B3F RID: 158527 RVA: 0x0054C45D File Offset: 0x0054A65D
		public IStaticNoRenderPortalT AsIStaticNoRenderPortal()
		{
			return this.As<IStaticNoRenderPortalT>();
		}

		// Token: 0x06026B40 RID: 158528 RVA: 0x0054C465 File Offset: 0x0054A665
		public static INoRenderPortalMode_UnionUnion FromIStaticNoRenderPortal(IStaticNoRenderPortalT _istaticnorenderportal)
		{
			return new INoRenderPortalMode_UnionUnion
			{
				Type = INoRenderPortalMode_Union.IStaticNoRenderPortal,
				Value = _istaticnorenderportal
			};
		}

		// Token: 0x06026B41 RID: 158529 RVA: 0x0054C47C File Offset: 0x0054A67C
		public static int Pack(FlatBufferBuilder builder, INoRenderPortalMode_UnionUnion _o)
		{
			INoRenderPortalMode_Union type = _o.Type;
			if (type == INoRenderPortalMode_Union.INoRenderPortalMode)
			{
				return INoRenderPortalMode.Pack(builder, _o.AsINoRenderPortalMode()).Value;
			}
			if (type != INoRenderPortalMode_Union.IStaticNoRenderPortal)
			{
				return 0;
			}
			return IStaticNoRenderPortal.Pack(builder, _o.AsIStaticNoRenderPortal()).Value;
		}
	}
}
