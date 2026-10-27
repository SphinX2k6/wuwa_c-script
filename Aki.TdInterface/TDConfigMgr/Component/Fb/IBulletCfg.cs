using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3F RID: 2879
	[NullableContext(1)]
	[Nullable(0)]
	public class IBulletCfg
	{
		// Token: 0x06004267 RID: 16999 RVA: 0x000A9E16 File Offset: 0x000A8016
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

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06004268 RID: 17000 RVA: 0x000A9E35 File Offset: 0x000A8035
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

		// Token: 0x0400256A RID: 9578
		private IBulletCfg Instance;

		// Token: 0x0400256B RID: 9579
		private List<IBulletCreateCondition> _CreateConditionsCache;

		// Token: 0x0400256C RID: 9580
		private bool _CreateConditionsInited;
	}
}
