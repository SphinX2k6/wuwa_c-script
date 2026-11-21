using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000942 RID: 2370
	public class SpawnMonsterComponent : IComponentBase
	{
		// Token: 0x0600349B RID: 13467 RVA: 0x0008626C File Offset: 0x0008446C
		private SpawnMonsterComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SpawnMonsterComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SpawnMonsterComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SpawnMonsterComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x000862A4 File Offset: 0x000844A4
		public static SpawnMonsterComponent Create([Nullable(2)] SpawnMonsterComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SpawnMonsterComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x000862B7 File Offset: 0x000844B7
		public static SpawnMonsterComponent CreateFromSetValue([Nullable(2)] SpawnMonsterComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SpawnMonsterComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x000862CC File Offset: 0x000844CC
		public new SpawnMonsterComponent_SetValue ToSetValue()
		{
			return new SpawnMonsterComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ActiveType = this.ActiveType,
				SpawnMonsterConfigs = this.SpawnMonsterConfigs,
				IssharedHatred = this.IssharedHatred,
				SpawnMonsterConstraintType = this.SpawnMonsterConstraintType
			};
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x0600349F RID: 13471 RVA: 0x00086328 File Offset: 0x00084528
		// (set) Token: 0x060034A0 RID: 13472 RVA: 0x00086362 File Offset: 0x00084562
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SpawnMonsterComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060034A1 RID: 13473 RVA: 0x00086370 File Offset: 0x00084570
		// (set) Token: 0x060034A2 RID: 13474 RVA: 0x0008639A File Offset: 0x0008459A
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

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060034A3 RID: 13475 RVA: 0x000863A8 File Offset: 0x000845A8
		// (set) Token: 0x060034A4 RID: 13476 RVA: 0x000863CF File Offset: 0x000845CF
		public virtual ISpawnMonsterStartCondition ActiveType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActiveType;
				}
				SpawnMonsterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ActiveType;
			}
			set
			{
				this.GetOrCreatePoco().ActiveType = value;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060034A5 RID: 13477 RVA: 0x000863E0 File Offset: 0x000845E0
		// (set) Token: 0x060034A6 RID: 13478 RVA: 0x00086473 File Offset: 0x00084673
		public virtual List<ISpawnMonsterConfig> SpawnMonsterConfigs
		{
			get
			{
				if (this._SpawnMonsterConfigsInited)
				{
					return this._SpawnMonsterConfigsCache;
				}
				this._SpawnMonsterConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ISpawnMonsterConfig> spawnMonsterConfigs = this.FbInstance.SpawnMonsterConfigs;
					if (spawnMonsterConfigs != null)
					{
						this._SpawnMonsterConfigsCache = new List<ISpawnMonsterConfig>(spawnMonsterConfigs.Count);
						for (int i = 0; i < spawnMonsterConfigs.Count; i++)
						{
							this._SpawnMonsterConfigsCache.Add(ISpawnMonsterConfig.Create(spawnMonsterConfigs[i]));
						}
					}
				}
				else
				{
					SpawnMonsterComponent_SetValue pocoInterface = this.PocoInterface;
					this._SpawnMonsterConfigsCache = ((pocoInterface != null) ? pocoInterface.SpawnMonsterConfigs : null);
				}
				return this._SpawnMonsterConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().SpawnMonsterConfigs = value;
				this._SpawnMonsterConfigsInited = false;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060034A7 RID: 13479 RVA: 0x00086488 File Offset: 0x00084688
		// (set) Token: 0x060034A8 RID: 13480 RVA: 0x000864C2 File Offset: 0x000846C2
		public virtual bool? IssharedHatred
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IssharedHatred;
				}
				SpawnMonsterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IssharedHatred;
			}
			set
			{
				this.GetOrCreatePoco().IssharedHatred = value;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060034A9 RID: 13481 RVA: 0x000864D0 File Offset: 0x000846D0
		// (set) Token: 0x060034AA RID: 13482 RVA: 0x00086531 File Offset: 0x00084731
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
				if (this.FbInstance != null)
				{
					this._SpawnMonsterConstraintTypeCache = ISpawnMonsterConstraintAnnularSector.Create(this.FbInstance.SpawnMonsterConstraintType);
				}
				else
				{
					SpawnMonsterComponent_SetValue pocoInterface = this.PocoInterface;
					this._SpawnMonsterConstraintTypeCache = ((pocoInterface != null) ? pocoInterface.SpawnMonsterConstraintType : null);
				}
				return this._SpawnMonsterConstraintTypeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SpawnMonsterConstraintType = value;
				this._SpawnMonsterConstraintTypeInited = false;
			}
		}

		// Token: 0x04002280 RID: 8832
		[Nullable(2)]
		protected new SpawnMonsterComponent FbInstance;

		// Token: 0x04002281 RID: 8833
		[Nullable(2)]
		protected new SpawnMonsterComponent_SetValue PocoInterface;

		// Token: 0x04002282 RID: 8834
		private List<ISpawnMonsterConfig> _SpawnMonsterConfigsCache;

		// Token: 0x04002283 RID: 8835
		private bool _SpawnMonsterConfigsInited;

		// Token: 0x04002284 RID: 8836
		private ISpawnMonsterConstraintAnnularSector _SpawnMonsterConstraintTypeCache;

		// Token: 0x04002285 RID: 8837
		private bool _SpawnMonsterConstraintTypeInited;
	}
}
