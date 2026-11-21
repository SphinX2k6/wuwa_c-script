using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062B9 RID: 25273
	public class TPortalConfigUnion
	{
		// Token: 0x1700BB92 RID: 48018
		// (get) Token: 0x0602AF81 RID: 176001 RVA: 0x005DC8A8 File Offset: 0x005DAAA8
		// (set) Token: 0x0602AF82 RID: 176002 RVA: 0x005DC8B0 File Offset: 0x005DAAB0
		public TPortalConfig Type { get; set; }

		// Token: 0x1700BB93 RID: 48019
		// (get) Token: 0x0602AF83 RID: 176003 RVA: 0x005DC8B9 File Offset: 0x005DAAB9
		// (set) Token: 0x0602AF84 RID: 176004 RVA: 0x005DC8C1 File Offset: 0x005DAAC1
		public object Value { get; set; }

		// Token: 0x0602AF85 RID: 176005 RVA: 0x005DC8CA File Offset: 0x005DAACA
		public TPortalConfigUnion()
		{
			this.Type = TPortalConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602AF86 RID: 176006 RVA: 0x005DC8E0 File Offset: 0x005DAAE0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AF87 RID: 176007 RVA: 0x005DC8F2 File Offset: 0x005DAAF2
		public IDynamicPortalT AsIDynamicPortal()
		{
			return this.As<IDynamicPortalT>();
		}

		// Token: 0x0602AF88 RID: 176008 RVA: 0x005DC8FA File Offset: 0x005DAAFA
		public static TPortalConfigUnion FromIDynamicPortal(IDynamicPortalT _idynamicportal)
		{
			return new TPortalConfigUnion
			{
				Type = TPortalConfig.IDynamicPortal,
				Value = _idynamicportal
			};
		}

		// Token: 0x0602AF89 RID: 176009 RVA: 0x005DC90F File Offset: 0x005DAB0F
		public IStaticPortalT AsIStaticPortal()
		{
			return this.As<IStaticPortalT>();
		}

		// Token: 0x0602AF8A RID: 176010 RVA: 0x005DC917 File Offset: 0x005DAB17
		public static TPortalConfigUnion FromIStaticPortal(IStaticPortalT _istaticportal)
		{
			return new TPortalConfigUnion
			{
				Type = TPortalConfig.IStaticPortal,
				Value = _istaticportal
			};
		}

		// Token: 0x0602AF8B RID: 176011 RVA: 0x005DC92C File Offset: 0x005DAB2C
		public static int Pack(FlatBufferBuilder builder, TPortalConfigUnion _o)
		{
			TPortalConfig type = _o.Type;
			if (type == TPortalConfig.IDynamicPortal)
			{
				return IDynamicPortal.Pack(builder, _o.AsIDynamicPortal()).Value;
			}
			if (type != TPortalConfig.IStaticPortal)
			{
				return 0;
			}
			return IStaticPortal.Pack(builder, _o.AsIStaticPortal()).Value;
		}
	}
}
