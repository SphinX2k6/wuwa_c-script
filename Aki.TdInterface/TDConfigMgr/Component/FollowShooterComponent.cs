using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200018E RID: 398
	public class FollowShooterComponent : IComponentBase
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x000203C8 File Offset: 0x0001E5C8
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

		// Token: 0x06000515 RID: 1301 RVA: 0x00020400 File Offset: 0x0001E600
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

		// Token: 0x06000516 RID: 1302 RVA: 0x00020413 File Offset: 0x0001E613
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

		// Token: 0x06000517 RID: 1303 RVA: 0x00020428 File Offset: 0x0001E628
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

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00020478 File Offset: 0x0001E678
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x000204B2 File Offset: 0x0001E6B2
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x000204C0 File Offset: 0x0001E6C0
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x000204EA File Offset: 0x0001E6EA
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000204F8 File Offset: 0x0001E6F8
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00020523 File Offset: 0x0001E723
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

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00020534 File Offset: 0x0001E734
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00020595 File Offset: 0x0001E795
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x000205AC File Offset: 0x0001E7AC
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x0002063F File Offset: 0x0001E83F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IEntityCategory> LockableCategories
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().LockableCategories = value;
				this._LockableCategoriesInited = false;
			}
		}

		// Token: 0x04000781 RID: 1921
		[Nullable(2)]
		protected new FollowShooterComponent FbInstance;

		// Token: 0x04000782 RID: 1922
		[Nullable(2)]
		protected new FollowShooterComponent_SetValue PocoInterface;

		// Token: 0x04000783 RID: 1923
		private IFollowShooterJellyFishConfig _TypeConfigCache;

		// Token: 0x04000784 RID: 1924
		private bool _TypeConfigInited;

		// Token: 0x04000785 RID: 1925
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IEntityCategory> _LockableCategoriesCache;

		// Token: 0x04000786 RID: 1926
		private bool _LockableCategoriesInited;
	}
}
