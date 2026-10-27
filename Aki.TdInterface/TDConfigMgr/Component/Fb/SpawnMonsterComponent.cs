using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B83 RID: 2947
	[NullableContext(1)]
	[Nullable(0)]
	public class SpawnMonsterComponent : IComponentBase
	{
		// Token: 0x060043D2 RID: 17362 RVA: 0x000AC993 File Offset: 0x000AAB93
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

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x000AC9B4 File Offset: 0x000AABB4
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

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x060043D4 RID: 17364 RVA: 0x000AC9EC File Offset: 0x000AABEC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x000ACA02 File Offset: 0x000AAC02
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

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x060043D6 RID: 17366 RVA: 0x000ACA34 File Offset: 0x000AAC34
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

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x000ACAA0 File Offset: 0x000AACA0
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

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x060043D8 RID: 17368 RVA: 0x000ACAD6 File Offset: 0x000AACD6
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

		// Token: 0x0400263C RID: 9788
		private ISpawnMonsterComponent Instance;

		// Token: 0x0400263D RID: 9789
		private ISpawnMonsterStartCondition _ActiveTypeCache;

		// Token: 0x0400263E RID: 9790
		private bool _ActiveTypeInited;

		// Token: 0x0400263F RID: 9791
		private List<ISpawnMonsterConfig> _SpawnMonsterConfigsCache;

		// Token: 0x04002640 RID: 9792
		private bool _SpawnMonsterConfigsInited;

		// Token: 0x04002641 RID: 9793
		[Nullable(2)]
		private ISpawnMonsterConstraintAnnularSector _SpawnMonsterConstraintTypeCache;

		// Token: 0x04002642 RID: 9794
		private bool _SpawnMonsterConstraintTypeInited;
	}
}
