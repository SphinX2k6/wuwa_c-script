using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200018C RID: 396
	public class FollowDecorationComponent : IComponentBase
	{
		// Token: 0x06000508 RID: 1288 RVA: 0x00020234 File Offset: 0x0001E434
		private FollowDecorationComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FollowDecorationComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FollowDecorationComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FollowDecorationComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0002026C File Offset: 0x0001E46C
		public static FollowDecorationComponent Create([Nullable(2)] FollowDecorationComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FollowDecorationComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0002027F File Offset: 0x0001E47F
		public static FollowDecorationComponent CreateFromSetValue([Nullable(2)] FollowDecorationComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FollowDecorationComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00020292 File Offset: 0x0001E492
		public new FollowDecorationComponent_SetValue ToSetValue()
		{
			return new FollowDecorationComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				DecorationConfig = this.DecorationConfig
			};
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x000202C0 File Offset: 0x0001E4C0
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x000202FA File Offset: 0x0001E4FA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				FollowDecorationComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00020308 File Offset: 0x0001E508
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00020332 File Offset: 0x0001E532
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00020340 File Offset: 0x0001E540
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x000203A1 File Offset: 0x0001E5A1
		public virtual IFollowDecorationChairConfig DecorationConfig
		{
			get
			{
				if (this._DecorationConfigInited)
				{
					return this._DecorationConfigCache;
				}
				this._DecorationConfigInited = true;
				if (this.FbInstance != null)
				{
					this._DecorationConfigCache = IFollowDecorationChairConfig.Create(this.FbInstance.DecorationConfig);
				}
				else
				{
					FollowDecorationComponent_SetValue pocoInterface = this.PocoInterface;
					this._DecorationConfigCache = ((pocoInterface != null) ? pocoInterface.DecorationConfig : null);
				}
				return this._DecorationConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().DecorationConfig = value;
				this._DecorationConfigInited = false;
			}
		}

		// Token: 0x0400077A RID: 1914
		[Nullable(2)]
		protected new FollowDecorationComponent FbInstance;

		// Token: 0x0400077B RID: 1915
		[Nullable(2)]
		protected new FollowDecorationComponent_SetValue PocoInterface;

		// Token: 0x0400077C RID: 1916
		private IFollowDecorationChairConfig _DecorationConfigCache;

		// Token: 0x0400077D RID: 1917
		private bool _DecorationConfigInited;
	}
}
