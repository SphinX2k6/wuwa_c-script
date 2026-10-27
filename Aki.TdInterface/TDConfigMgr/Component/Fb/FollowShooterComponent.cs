using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D15 RID: 3349
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowShooterComponent : IComponentBase
	{
		// Token: 0x06004C6C RID: 19564 RVA: 0x000BE692 File Offset: 0x000BC892
		public static FollowShooterComponent Create(IFollowShooterComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FollowShooterComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06004C6D RID: 19565 RVA: 0x000BE6B4 File Offset: 0x000BC8B4
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06004C6E RID: 19566 RVA: 0x000BE6EC File Offset: 0x000BC8EC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06004C6F RID: 19567 RVA: 0x000BE702 File Offset: 0x000BC902
		public virtual string Config
		{
			get
			{
				return this.Instance.Config;
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06004C70 RID: 19568 RVA: 0x000BE70F File Offset: 0x000BC90F
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
				this._TypeConfigCache = IFollowShooterJellyFishConfig.Create(this.Instance.TypeConfig);
				return this._TypeConfigCache;
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06004C71 RID: 19569 RVA: 0x000BE744 File Offset: 0x000BC944
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
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int lockableCategoriesLength = this.Instance.LockableCategoriesLength;
				this._LockableCategoriesCache = new List<IEntityCategory>(lockableCategoriesLength);
				for (int i = 0; i < lockableCategoriesLength; i++)
				{
					this._LockableCategoriesCache.Add(IEntityCategory.Create(this.Instance.LockableCategories(i)));
				}
				return this._LockableCategoriesCache;
			}
		}

		// Token: 0x04002BBE RID: 11198
		private IFollowShooterComponent Instance;

		// Token: 0x04002BBF RID: 11199
		[Nullable(2)]
		private IFollowShooterJellyFishConfig _TypeConfigCache;

		// Token: 0x04002BC0 RID: 11200
		private bool _TypeConfigInited;

		// Token: 0x04002BC1 RID: 11201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IEntityCategory> _LockableCategoriesCache;

		// Token: 0x04002BC2 RID: 11202
		private bool _LockableCategoriesInited;
	}
}
