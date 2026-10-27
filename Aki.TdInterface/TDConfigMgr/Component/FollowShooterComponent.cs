using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000179 RID: 377
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowShooterComponent : IComponentBase
	{
		// Token: 0x06000510 RID: 1296 RVA: 0x0001FA54 File Offset: 0x0001DC54
		private FollowShooterComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FollowShooterComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FollowShooterComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FollowShooterComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001FA8C File Offset: 0x0001DC8C
		public static FollowShooterComponent Create([Nullable(2)] FollowShooterComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FollowShooterComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001FA9F File Offset: 0x0001DC9F
		public static FollowShooterComponent CreateFromSetValue([Nullable(2)] FollowShooterComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FollowShooterComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001FAB4 File Offset: 0x0001DCB4
		public new FollowShooterComponent_SetValue ToSetValue()
		{
			return new FollowShooterComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config,
				TypeConfig = this.TypeConfig,
				LockableCategories = this.LockableCategories
			};
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0001FB04 File Offset: 0x0001DD04
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x0001FB3E File Offset: 0x0001DD3E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				FollowShooterComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001FB4C File Offset: 0x0001DD4C
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x0001FB76 File Offset: 0x0001DD76
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

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0001FB84 File Offset: 0x0001DD84
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x0001FBAF File Offset: 0x0001DDAF
		public virtual string Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0001FBC0 File Offset: 0x0001DDC0
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x0001FC21 File Offset: 0x0001DE21
		[Nullable(2)]
		public virtual IFollowShooterJellyFishConfig TypeConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._TypeConfigInited)
				{
					return this._TypeConfigCache;
				}
				this._TypeConfigInited = true;
				if (this.FbInstance != null)
				{
					this._TypeConfigCache = IFollowShooterJellyFishConfig.Create(this.FbInstance.TypeConfig);
				}
				else
				{
					FollowShooterComponent_SetValue pocoInterface = this.PocoInterface;
					this._TypeConfigCache = ((pocoInterface != null) ? pocoInterface.TypeConfig : null);
				}
				return this._TypeConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TypeConfig = value;
				this._TypeConfigInited = false;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0001FC38 File Offset: 0x0001DE38
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x0001FCCB File Offset: 0x0001DECB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IEntityCategory> LockableCategories
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._LockableCategoriesInited)
				{
					return this._LockableCategoriesCache;
				}
				this._LockableCategoriesInited = true;
				if (this.FbInstance != null)
				{
					List<IEntityCategory> lockableCategories = this.FbInstance.LockableCategories;
					if (lockableCategories != null)
					{
						this._LockableCategoriesCache = new List<IEntityCategory>(lockableCategories.Count);
						for (int i = 0; i < lockableCategories.Count; i++)
						{
							this._LockableCategoriesCache.Add(IEntityCategory.Create(lockableCategories[i]));
						}
					}
				}
				else
				{
					FollowShooterComponent_SetValue pocoInterface = this.PocoInterface;
					this._LockableCategoriesCache = ((pocoInterface != null) ? pocoInterface.LockableCategories : null);
				}
				return this._LockableCategoriesCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().LockableCategories = value;
				this._LockableCategoriesInited = false;
			}
		}

		// Token: 0x04000734 RID: 1844
		[Nullable(2)]
		protected new FollowShooterComponent FbInstance;

		// Token: 0x04000735 RID: 1845
		[Nullable(2)]
		protected new FollowShooterComponent_SetValue PocoInterface;

		// Token: 0x04000736 RID: 1846
		private IFollowShooterJellyFishConfig _TypeConfigCache;

		// Token: 0x04000737 RID: 1847
		private bool _TypeConfigInited;

		// Token: 0x04000738 RID: 1848
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IEntityCategory> _LockableCategoriesCache;

		// Token: 0x04000739 RID: 1849
		private bool _LockableCategoriesInited;
	}
}
