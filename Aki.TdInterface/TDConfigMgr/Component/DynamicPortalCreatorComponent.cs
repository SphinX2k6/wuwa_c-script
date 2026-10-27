using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000060 RID: 96
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicPortalCreatorComponent : IComponentBase
	{
		// Token: 0x06000322 RID: 802 RVA: 0x0001B29C File Offset: 0x0001949C
		private DynamicPortalCreatorComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DynamicPortalCreatorComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DynamicPortalCreatorComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DynamicPortalCreatorComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0001B2D4 File Offset: 0x000194D4
		public static DynamicPortalCreatorComponent Create([Nullable(2)] DynamicPortalCreatorComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicPortalCreatorComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0001B2E7 File Offset: 0x000194E7
		public static DynamicPortalCreatorComponent CreateFromSetValue([Nullable(2)] DynamicPortalCreatorComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DynamicPortalCreatorComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0001B2FA File Offset: 0x000194FA
		public new DynamicPortalCreatorComponent_SetValue ToSetValue()
		{
			return new DynamicPortalCreatorComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Model = this.Model
			};
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0001B328 File Offset: 0x00019528
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0001B362 File Offset: 0x00019562
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DynamicPortalCreatorComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0001B370 File Offset: 0x00019570
		// (set) Token: 0x06000329 RID: 809 RVA: 0x0001B39A File Offset: 0x0001959A
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001B3A8 File Offset: 0x000195A8
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0001B409 File Offset: 0x00019609
		public virtual IDynamicPortalByBullet Model
		{
			get
			{
				if (this._ModelInited)
				{
					return this._ModelCache;
				}
				this._ModelInited = true;
				if (this.FbInstance != null)
				{
					this._ModelCache = IDynamicPortalByBullet.Create(this.FbInstance.Model);
				}
				else
				{
					DynamicPortalCreatorComponent_SetValue pocoInterface = this.PocoInterface;
					this._ModelCache = ((pocoInterface != null) ? pocoInterface.Model : null);
				}
				return this._ModelCache;
			}
			set
			{
				this.GetOrCreatePoco().Model = value;
				this._ModelInited = false;
			}
		}

		// Token: 0x040001FC RID: 508
		[Nullable(2)]
		protected new DynamicPortalCreatorComponent FbInstance;

		// Token: 0x040001FD RID: 509
		[Nullable(2)]
		protected new DynamicPortalCreatorComponent_SetValue PocoInterface;

		// Token: 0x040001FE RID: 510
		private IDynamicPortalByBullet _ModelCache;

		// Token: 0x040001FF RID: 511
		private bool _ModelInited;
	}
}
