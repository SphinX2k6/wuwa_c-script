using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C51 RID: 3153
	public class SpawnMonsterComponent : IComponentBase
	{
		// Token: 0x0600482B RID: 18475 RVA: 0x000B6A57 File Offset: 0x000B4C57
		public static SpawnMonsterComponent Create(ISpawnMonsterComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SpawnMonsterComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x0600482C RID: 18476 RVA: 0x000B6A78 File Offset: 0x000B4C78
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

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x000B6AB0 File Offset: 0x000B4CB0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x0600482E RID: 18478 RVA: 0x000B6AC6 File Offset: 0x000B4CC6
		public virtual ISpawnMonsterStartCondition ActiveType
		{
			get
			{
				if (this._ActiveTypeInited)
				{
					return this._ActiveTypeCache;
				}
				this._ActiveTypeInited = true;
				this._ActiveTypeCache = ComponentReadHelper.ReadSpawnMonsterComponent_ActiveType(this.Instance);
				return this._ActiveTypeCache;
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x000B6AF8 File Offset: 0x000B4CF8
		public virtual List<ISpawnMonsterConfig> SpawnMonsterConfigs
		{
			get
			{
				if (this._SpawnMonsterConfigsInited)
				{
					return this._SpawnMonsterConfigsCache;
				}
				this._SpawnMonsterConfigsInited = true;
				int spawnMonsterConfigsLength = this.Instance.SpawnMonsterConfigsLength;
				this._SpawnMonsterConfigsCache = new List<ISpawnMonsterConfig>(spawnMonsterConfigsLength);
				for (int i = 0; i < spawnMonsterConfigsLength; i++)
				{
					this._SpawnMonsterConfigsCache.Add(ISpawnMonsterConfig.Create(this.Instance.SpawnMonsterConfigs(i)));
				}
				return this._SpawnMonsterConfigsCache;
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06004830 RID: 18480 RVA: 0x000B6B64 File Offset: 0x000B4D64
		public virtual bool? IssharedHatred
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IssharedHatred);
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x000B6B9A File Offset: 0x000B4D9A
		[Nullable(2)]
		public virtual ISpawnMonsterConstraintAnnularSector SpawnMonsterConstraintType
		{
			[NullableContext(2)]
			get
			{
				if (this._SpawnMonsterConstraintTypeInited)
				{
					return this._SpawnMonsterConstraintTypeCache;
				}
				this._SpawnMonsterConstraintTypeInited = true;
				this._SpawnMonsterConstraintTypeCache = ISpawnMonsterConstraintAnnularSector.Create(this.Instance.SpawnMonsterConstraintType);
				return this._SpawnMonsterConstraintTypeCache;
			}
		}

		// Token: 0x04002884 RID: 10372
		private ISpawnMonsterComponent Instance;

		// Token: 0x04002885 RID: 10373
		private ISpawnMonsterStartCondition _ActiveTypeCache;

		// Token: 0x04002886 RID: 10374
		private bool _ActiveTypeInited;

		// Token: 0x04002887 RID: 10375
		private List<ISpawnMonsterConfig> _SpawnMonsterConfigsCache;

		// Token: 0x04002888 RID: 10376
		private bool _SpawnMonsterConfigsInited;

		// Token: 0x04002889 RID: 10377
		[Nullable(2)]
		private ISpawnMonsterConstraintAnnularSector _SpawnMonsterConstraintTypeCache;

		// Token: 0x0400288A RID: 10378
		private bool _SpawnMonsterConstraintTypeInited;
	}
}
