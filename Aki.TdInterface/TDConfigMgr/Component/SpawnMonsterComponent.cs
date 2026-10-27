using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200089F RID: 2207
	[NullableContext(1)]
	[Nullable(0)]
	public class SpawnMonsterComponent : IComponentBase
	{
		// Token: 0x0600315F RID: 12639 RVA: 0x0007ED84 File Offset: 0x0007CF84
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

		// Token: 0x06003160 RID: 12640 RVA: 0x0007EDBC File Offset: 0x0007CFBC
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

		// Token: 0x06003161 RID: 12641 RVA: 0x0007EDCF File Offset: 0x0007CFCF
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

		// Token: 0x06003162 RID: 12642 RVA: 0x0007EDE4 File Offset: 0x0007CFE4
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

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06003163 RID: 12643 RVA: 0x0007EE40 File Offset: 0x0007D040
		// (set) Token: 0x06003164 RID: 12644 RVA: 0x0007EE7A File Offset: 0x0007D07A
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

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06003165 RID: 12645 RVA: 0x0007EE88 File Offset: 0x0007D088
		// (set) Token: 0x06003166 RID: 12646 RVA: 0x0007EEB2 File Offset: 0x0007D0B2
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

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06003167 RID: 12647 RVA: 0x0007EEC0 File Offset: 0x0007D0C0
		// (set) Token: 0x06003168 RID: 12648 RVA: 0x0007EEE7 File Offset: 0x0007D0E7
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

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x0007EEF8 File Offset: 0x0007D0F8
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x0007EF8B File Offset: 0x0007D18B
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

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x0007EFA0 File Offset: 0x0007D1A0
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x0007EFDA File Offset: 0x0007D1DA
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

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x0007EFE8 File Offset: 0x0007D1E8
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x0007F049 File Offset: 0x0007D249
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

		// Token: 0x0400206E RID: 8302
		[Nullable(2)]
		protected new SpawnMonsterComponent FbInstance;

		// Token: 0x0400206F RID: 8303
		[Nullable(2)]
		protected new SpawnMonsterComponent_SetValue PocoInterface;

		// Token: 0x04002070 RID: 8304
		private List<ISpawnMonsterConfig> _SpawnMonsterConfigsCache;

		// Token: 0x04002071 RID: 8305
		private bool _SpawnMonsterConfigsInited;

		// Token: 0x04002072 RID: 8306
		private ISpawnMonsterConstraintAnnularSector _SpawnMonsterConstraintTypeCache;

		// Token: 0x04002073 RID: 8307
		private bool _SpawnMonsterConstraintTypeInited;
	}
}
