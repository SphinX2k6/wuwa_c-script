using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3F RID: 10815
	public class ServerForceEnableLevelPlay : ActionParams
	{
		// Token: 0x0600EEE6 RID: 61158 RVA: 0x0023055A File Offset: 0x0022E75A
		public static ServerForceEnableLevelPlay Create(IServerForceEnableLevelPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ServerForceEnableLevelPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004716 RID: 18198
		// (get) Token: 0x0600EEE7 RID: 61159 RVA: 0x0023057C File Offset: 0x0022E77C
		public virtual List<IEnableLevelPlayConfig> Configs
		{
			get
			{
				if (this._ConfigsInited)
				{
					return this._ConfigsCache;
				}
				this._ConfigsInited = true;
				int configsLength = this.Instance.ConfigsLength;
				this._ConfigsCache = new List<IEnableLevelPlayConfig>(configsLength);
				for (int i = 0; i < configsLength; i++)
				{
					this._ConfigsCache.Add(IEnableLevelPlayConfig.Create(this.Instance.Configs(i)));
				}
				return this._ConfigsCache;
			}
		}

		// Token: 0x0400832D RID: 33581
		private IServerForceEnableLevelPlay Instance;

		// Token: 0x0400832E RID: 33582
		private List<IEnableLevelPlayConfig> _ConfigsCache;

		// Token: 0x0400832F RID: 33583
		private bool _ConfigsInited;
	}
}
