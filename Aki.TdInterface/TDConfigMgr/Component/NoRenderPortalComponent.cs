using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008EA RID: 2282
	public class NoRenderPortalComponent : IComponentBase
	{
		// Token: 0x060031BB RID: 12731 RVA: 0x0007F750 File Offset: 0x0007D950
		private NoRenderPortalComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("NoRenderPortalComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			NoRenderPortalComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new NoRenderPortalComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x0007F788 File Offset: 0x0007D988
		public static NoRenderPortalComponent Create([Nullable(2)] NoRenderPortalComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NoRenderPortalComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x0007F79B File Offset: 0x0007D99B
		public static NoRenderPortalComponent CreateFromSetValue([Nullable(2)] NoRenderPortalComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new NoRenderPortalComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x0007F7AE File Offset: 0x0007D9AE
		public new NoRenderPortalComponent_SetValue ToSetValue()
		{
			return new NoRenderPortalComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x0007F7DC File Offset: 0x0007D9DC
		// (set) Token: 0x060031C0 RID: 12736 RVA: 0x0007F816 File Offset: 0x0007DA16
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				NoRenderPortalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x0007F824 File Offset: 0x0007DA24
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x0007F84E File Offset: 0x0007DA4E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x0007F85C File Offset: 0x0007DA5C
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x0007F8BD File Offset: 0x0007DABD
		public virtual IStaticNoRenderPortal Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = IStaticNoRenderPortal.Create(this.FbInstance.Config);
				}
				else
				{
					NoRenderPortalComponent_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x040020C0 RID: 8384
		[Nullable(2)]
		protected new NoRenderPortalComponent FbInstance;

		// Token: 0x040020C1 RID: 8385
		[Nullable(2)]
		protected new NoRenderPortalComponent_SetValue PocoInterface;

		// Token: 0x040020C2 RID: 8386
		private IStaticNoRenderPortal _ConfigCache;

		// Token: 0x040020C3 RID: 8387
		private bool _ConfigInited;
	}
}
