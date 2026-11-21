using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E0F RID: 3599
	public class FollowShooterComponent : IComponentBase
	{
		// Token: 0x06005186 RID: 20870 RVA: 0x000C9D66 File Offset: 0x000C7F66
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

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06005187 RID: 20871 RVA: 0x000C9D88 File Offset: 0x000C7F88
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

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06005188 RID: 20872 RVA: 0x000C9DC0 File Offset: 0x000C7FC0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06005189 RID: 20873 RVA: 0x000C9DD6 File Offset: 0x000C7FD6
		public virtual string Config
		{
			get
			{
				return this.Instance.Config;
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x0600518A RID: 20874 RVA: 0x000C9DE3 File Offset: 0x000C7FE3
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

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x0600518B RID: 20875 RVA: 0x000C9E18 File Offset: 0x000C8018
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

		// Token: 0x04002E7E RID: 11902
		private IFollowShooterComponent Instance;

		// Token: 0x04002E7F RID: 11903
		[Nullable(2)]
		private IFollowShooterJellyFishConfig _TypeConfigCache;

		// Token: 0x04002E80 RID: 11904
		private bool _TypeConfigInited;

		// Token: 0x04002E81 RID: 11905
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IEntityCategory> _LockableCategoriesCache;

		// Token: 0x04002E82 RID: 11906
		private bool _LockableCategoriesInited;
	}
}
