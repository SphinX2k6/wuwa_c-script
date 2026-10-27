using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000839 RID: 2105
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterGachaBaseComponent : IComponentBase
	{
		// Token: 0x06002E19 RID: 11801 RVA: 0x00077458 File Offset: 0x00075658
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

		// Token: 0x06002E1A RID: 11802 RVA: 0x00077490 File Offset: 0x00075690
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

		// Token: 0x06002E1B RID: 11803 RVA: 0x000774A3 File Offset: 0x000756A3
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

		// Token: 0x06002E1C RID: 11804 RVA: 0x000774B8 File Offset: 0x000756B8
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

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x00077508 File Offset: 0x00075708
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x00077542 File Offset: 0x00075742
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

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x00077550 File Offset: 0x00075750
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x0007757A File Offset: 0x0007577A
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

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x00077588 File Offset: 0x00075788
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x000775AF File Offset: 0x000757AF
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

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x000775C0 File Offset: 0x000757C0
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x00077653 File Offset: 0x00075853
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

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x00077668 File Offset: 0x00075868
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x000776FB File Offset: 0x000758FB
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

		// Token: 0x04001E78 RID: 7800
		[Nullable(2)]
		protected new MonsterGachaBaseComponent FbInstance;

		// Token: 0x04001E79 RID: 7801
		[Nullable(2)]
		protected new MonsterGachaBaseComponent_SetValue PocoInterface;

		// Token: 0x04001E7A RID: 7802
		private List<IMonsterGachaSlot> _ConfigCache;

		// Token: 0x04001E7B RID: 7803
		private bool _ConfigInited;

		// Token: 0x04001E7C RID: 7804
		private List<IMonsterFormation> _FormationCache;

		// Token: 0x04001E7D RID: 7805
		private bool _FormationInited;
	}
}
