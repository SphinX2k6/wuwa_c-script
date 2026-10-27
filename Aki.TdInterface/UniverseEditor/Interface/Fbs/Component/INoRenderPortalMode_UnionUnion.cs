using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005615 RID: 22037
	public class INoRenderPortalMode_UnionUnion
	{
		// Token: 0x1700A311 RID: 41745
		// (get) Token: 0x06024927 RID: 149799 RVA: 0x0050BDDE File Offset: 0x00509FDE
		// (set) Token: 0x06024928 RID: 149800 RVA: 0x0050BDE6 File Offset: 0x00509FE6
		public INoRenderPortalMode_Union Type { get; set; }

		// Token: 0x1700A312 RID: 41746
		// (get) Token: 0x06024929 RID: 149801 RVA: 0x0050BDEF File Offset: 0x00509FEF
		// (set) Token: 0x0602492A RID: 149802 RVA: 0x0050BDF7 File Offset: 0x00509FF7
		public object Value { get; set; }

		// Token: 0x0602492B RID: 149803 RVA: 0x0050BE00 File Offset: 0x0050A000
		public INoRenderPortalMode_UnionUnion()
		{
			this.Type = INoRenderPortalMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602492C RID: 149804 RVA: 0x0050BE16 File Offset: 0x0050A016
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602492D RID: 149805 RVA: 0x0050BE28 File Offset: 0x0050A028
		public INoRenderPortalModeT AsINoRenderPortalMode()
		{
			return this.As<INoRenderPortalModeT>();
		}

		// Token: 0x0602492E RID: 149806 RVA: 0x0050BE30 File Offset: 0x0050A030
		public static INoRenderPortalMode_UnionUnion FromINoRenderPortalMode(INoRenderPortalModeT _inorenderportalmode)
		{
			return new INoRenderPortalMode_UnionUnion
			{
				Type = INoRenderPortalMode_Union.INoRenderPortalMode,
				Value = _inorenderportalmode
			};
		}

		// Token: 0x0602492F RID: 149807 RVA: 0x0050BE45 File Offset: 0x0050A045
		public IStaticNoRenderPortalT AsIStaticNoRenderPortal()
		{
			return this.As<IStaticNoRenderPortalT>();
		}

		// Token: 0x06024930 RID: 149808 RVA: 0x0050BE4D File Offset: 0x0050A04D
		public static INoRenderPortalMode_UnionUnion FromIStaticNoRenderPortal(IStaticNoRenderPortalT _istaticnorenderportal)
		{
			return new INoRenderPortalMode_UnionUnion
			{
				Type = INoRenderPortalMode_Union.IStaticNoRenderPortal,
				Value = _istaticnorenderportal
			};
		}

		// Token: 0x06024931 RID: 149809 RVA: 0x0050BE64 File Offset: 0x0050A064
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
