using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008DC RID: 2268
	public class MonsterGachaBaseComponent : IComponentBase
	{
		// Token: 0x0600314F RID: 12623 RVA: 0x0007E87C File Offset: 0x0007CA7C
		private MonsterGachaBaseComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("MonsterGachaBaseComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			MonsterGachaBaseComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new MonsterGachaBaseComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x0007E8B4 File Offset: 0x0007CAB4
		public static MonsterGachaBaseComponent Create([Nullable(2)] MonsterGachaBaseComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MonsterGachaBaseComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x0007E8C7 File Offset: 0x0007CAC7
		public static MonsterGachaBaseComponent CreateFromSetValue([Nullable(2)] MonsterGachaBaseComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new MonsterGachaBaseComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x0007E8DC File Offset: 0x0007CADC
		public new MonsterGachaBaseComponent_SetValue ToSetValue()
		{
			return new MonsterGachaBaseComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				MonsterEntityIds = this.MonsterEntityIds,
				Config = this.Config,
				Formation = this.Formation
			};
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06003153 RID: 12627 RVA: 0x0007E92C File Offset: 0x0007CB2C
		// (set) Token: 0x06003154 RID: 12628 RVA: 0x0007E966 File Offset: 0x0007CB66
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				MonsterGachaBaseComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06003155 RID: 12629 RVA: 0x0007E974 File Offset: 0x0007CB74
		// (set) Token: 0x06003156 RID: 12630 RVA: 0x0007E99E File Offset: 0x0007CB9E
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

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x0007E9AC File Offset: 0x0007CBAC
		// (set) Token: 0x06003158 RID: 12632 RVA: 0x0007E9D3 File Offset: 0x0007CBD3
		public virtual List<int> MonsterEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MonsterEntityIds;
				}
				MonsterGachaBaseComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MonsterEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().MonsterEntityIds = value;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06003159 RID: 12633 RVA: 0x0007E9E4 File Offset: 0x0007CBE4
		// (set) Token: 0x0600315A RID: 12634 RVA: 0x0007EA77 File Offset: 0x0007CC77
		public virtual List<IMonsterGachaSlot> Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IMonsterGachaSlot> config = this.FbInstance.Config;
					if (config != null)
					{
						this._ConfigCache = new List<IMonsterGachaSlot>(config.Count);
						for (int i = 0; i < config.Count; i++)
						{
							this._ConfigCache.Add(IMonsterGachaSlot.Create(config[i]));
						}
					}
				}
				else
				{
					MonsterGachaBaseComponent_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x0600315B RID: 12635 RVA: 0x0007EA8C File Offset: 0x0007CC8C
		// (set) Token: 0x0600315C RID: 12636 RVA: 0x0007EB1F File Offset: 0x0007CD1F
		public virtual List<IMonsterFormation> Formation
		{
			get
			{
				if (this._FormationInited)
				{
					return this._FormationCache;
				}
				this._FormationInited = true;
				if (this.FbInstance != null)
				{
					List<IMonsterFormation> formation = this.FbInstance.Formation;
					if (formation != null)
					{
						this._FormationCache = new List<IMonsterFormation>(formation.Count);
						for (int i = 0; i < formation.Count; i++)
						{
							this._FormationCache.Add(IMonsterFormation.Create(formation[i]));
						}
					}
				}
				else
				{
					MonsterGachaBaseComponent_SetValue pocoInterface = this.PocoInterface;
					this._FormationCache = ((pocoInterface != null) ? pocoInterface.Formation : null);
				}
				return this._FormationCache;
			}
			set
			{
				this.GetOrCreatePoco().Formation = value;
				this._FormationInited = false;
			}
		}

		// Token: 0x04002087 RID: 8327
		[Nullable(2)]
		protected new MonsterGachaBaseComponent FbInstance;

		// Token: 0x04002088 RID: 8328
		[Nullable(2)]
		protected new MonsterGachaBaseComponent_SetValue PocoInterface;

		// Token: 0x04002089 RID: 8329
		private List<IMonsterGachaSlot> _ConfigCache;

		// Token: 0x0400208A RID: 8330
		private bool _ConfigInited;

		// Token: 0x0400208B RID: 8331
		private List<IMonsterFormation> _FormationCache;

		// Token: 0x0400208C RID: 8332
		private bool _FormationInited;
	}
}
