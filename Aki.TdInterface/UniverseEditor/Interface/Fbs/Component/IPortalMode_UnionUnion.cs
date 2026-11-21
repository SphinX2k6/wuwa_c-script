using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D77 RID: 23927
	public class IPortalMode_UnionUnion
	{
		// Token: 0x1700B017 RID: 45079
		// (get) Token: 0x06027D53 RID: 163155 RVA: 0x00572DF3 File Offset: 0x00570FF3
		// (set) Token: 0x06027D54 RID: 163156 RVA: 0x00572DFB File Offset: 0x00570FFB
		public IPortalMode_Union Type { get; set; }

		// Token: 0x1700B018 RID: 45080
		// (get) Token: 0x06027D55 RID: 163157 RVA: 0x00572E04 File Offset: 0x00571004
		// (set) Token: 0x06027D56 RID: 163158 RVA: 0x00572E0C File Offset: 0x0057100C
		public object Value { get; set; }

		// Token: 0x06027D57 RID: 163159 RVA: 0x00572E15 File Offset: 0x00571015
		public IPortalMode_UnionUnion()
		{
			this.Type = IPortalMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027D58 RID: 163160 RVA: 0x00572E2B File Offset: 0x0057102B
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027D59 RID: 163161 RVA: 0x00572E3D File Offset: 0x0057103D
		public IPortalModeT AsIPortalMode()
		{
			return this.As<IPortalModeT>();
		}

		// Token: 0x06027D5A RID: 163162 RVA: 0x00572E45 File Offset: 0x00571045
		public static IPortalMode_UnionUnion FromIPortalMode(IPortalModeT _iportalmode)
		{
			return new IPortalMode_UnionUnion
			{
				Type = IPortalMode_Union.IPortalMode,
				Value = _iportalmode
			};
		}

		// Token: 0x06027D5B RID: 163163 RVA: 0x00572E5A File Offset: 0x0057105A
		public IStaticPortalT AsIStaticPortal()
		{
			return this.As<IStaticPortalT>();
		}

		// Token: 0x06027D5C RID: 163164 RVA: 0x00572E62 File Offset: 0x00571062
		public static IPortalMode_UnionUnion FromIStaticPortal(IStaticPortalT _istaticportal)
		{
			return new IPortalMode_UnionUnion
			{
				Type = IPortalMode_Union.IStaticPortal,
				Value = _istaticportal
			};
		}

		// Token: 0x06027D5D RID: 163165 RVA: 0x00572E77 File Offset: 0x00571077
		public IDynamicPortalT AsIDynamicPortal()
		{
			return this.As<IDynamicPortalT>();
		}

		// Token: 0x06027D5E RID: 163166 RVA: 0x00572E7F File Offset: 0x0057107F
		public static IPortalMode_UnionUnion FromIDynamicPortal(IDynamicPortalT _idynamicportal)
		{
			return new IPortalMode_UnionUnion
			{
				Type = IPortalMode_Union.IDynamicPortal,
				Value = _idynamicportal
			};
		}

		// Token: 0x06027D5F RID: 163167 RVA: 0x00572E94 File Offset: 0x00571094
		public static int Pack(FlatBufferBuilder builder, IPortalMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPortalMode_Union.IPortalMode:
				return IPortalMode.Pack(builder, _o.AsIPortalMode()).Value;
			case IPortalMode_Union.IStaticPortal:
				return IStaticPortal.Pack(builder, _o.AsIStaticPortal()).Value;
			case IPortalMode_Union.IDynamicPortal:
				return IDynamicPortal.Pack(builder, _o.AsIDynamicPortal()).Value;
			default:
				return 0;
			}
		}
	}
}
