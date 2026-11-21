using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0D RID: 3085
	public class IBulletCfg
	{
		// Token: 0x060046C0 RID: 18112 RVA: 0x000B3EDA File Offset: 0x000B20DA
		public static IBulletCfg Create(IBulletCfg? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBulletCfg
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x060046C1 RID: 18113 RVA: 0x000B3EF9 File Offset: 0x000B20F9
		public virtual List<IBulletCreateCondition> CreateConditions
		{
			get
			{
				if (this._CreateConditionsInited)
				{
					return this._CreateConditionsCache;
				}
				this._CreateConditionsInited = true;
				this._CreateConditionsCache = ComponentReadHelper.ReadIBulletCfg_CreateConditions(this.Instance);
				return this._CreateConditionsCache;
			}
		}

		// Token: 0x040027B2 RID: 10162
		private IBulletCfg Instance;

		// Token: 0x040027B3 RID: 10163
		private List<IBulletCreateCondition> _CreateConditionsCache;

		// Token: 0x040027B4 RID: 10164
		private bool _CreateConditionsInited;
	}
}
