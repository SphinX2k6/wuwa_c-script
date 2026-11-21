using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AD RID: 10669
	public class ISendBattleEventsForMonsterSummon : IExecBattleActionType
	{
		// Token: 0x0600EC5A RID: 60506 RVA: 0x0022CA52 File Offset: 0x0022AC52
		public static ISendBattleEventsForMonsterSummon Create(ISendBattleEventsForMonsterSummon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleEventsForMonsterSummon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045AE RID: 17838
		// (get) Token: 0x0600EC5B RID: 60507 RVA: 0x0022CA71 File Offset: 0x0022AC71
		public override EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045AF RID: 17839
		// (get) Token: 0x0600EC5C RID: 60508 RVA: 0x0022CA80 File Offset: 0x0022AC80
		public virtual List<ISendBattleEventsForMonsterSummonConfig> Configs
		{
			get
			{
				if (this._ConfigsInited)
				{
					return this._ConfigsCache;
				}
				this._ConfigsInited = true;
				int configsLength = this.Instance.ConfigsLength;
				this._ConfigsCache = new List<ISendBattleEventsForMonsterSummonConfig>(configsLength);
				for (int i = 0; i < configsLength; i++)
				{
					this._ConfigsCache.Add(ISendBattleEventsForMonsterSummonConfig.Create(this.Instance.Configs(i)));
				}
				return this._ConfigsCache;
			}
		}

		// Token: 0x0400821F RID: 33311
		private ISendBattleEventsForMonsterSummon Instance;

		// Token: 0x04008220 RID: 33312
		private List<ISendBattleEventsForMonsterSummonConfig> _ConfigsCache;

		// Token: 0x04008221 RID: 33313
		private bool _ConfigsInited;
	}
}
