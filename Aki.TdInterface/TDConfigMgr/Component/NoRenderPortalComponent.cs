using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000847 RID: 2119
	[NullableContext(1)]
	[Nullable(0)]
	public class NoRenderPortalComponent : IComponentBase
	{
		// Token: 0x06002E85 RID: 11909 RVA: 0x0007832C File Offset: 0x0007652C
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

		// Token: 0x06002E86 RID: 11910 RVA: 0x00078364 File Offset: 0x00076564
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

		// Token: 0x06002E87 RID: 11911 RVA: 0x00078377 File Offset: 0x00076577
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

		// Token: 0x06002E88 RID: 11912 RVA: 0x0007838A File Offset: 0x0007658A
		public new NoRenderPortalComponent_SetValue ToSetValue()
		{
			return new NoRenderPortalComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002E89 RID: 11913 RVA: 0x000783B8 File Offset: 0x000765B8
		// (set) Token: 0x06002E8A RID: 11914 RVA: 0x000783F2 File Offset: 0x000765F2
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

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002E8B RID: 11915 RVA: 0x00078400 File Offset: 0x00076600
		// (set) Token: 0x06002E8C RID: 11916 RVA: 0x0007842A File Offset: 0x0007662A
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

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002E8D RID: 11917 RVA: 0x00078438 File Offset: 0x00076638
		// (set) Token: 0x06002E8E RID: 11918 RVA: 0x00078499 File Offset: 0x00076699
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

		// Token: 0x04001EB1 RID: 7857
		[Nullable(2)]
		protected new NoRenderPortalComponent FbInstance;

		// Token: 0x04001EB2 RID: 7858
		[Nullable(2)]
		protected new NoRenderPortalComponent_SetValue PocoInterface;

		// Token: 0x04001EB3 RID: 7859
		private IStaticNoRenderPortal _ConfigCache;

		// Token: 0x04001EB4 RID: 7860
		private bool _ConfigInited;
	}
}
