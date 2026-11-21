using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3E RID: 10814
	public class EnableLevelPlay : ActionParams
	{
		// Token: 0x0600EEE2 RID: 61154 RVA: 0x00230490 File Offset: 0x0022E690
		public static EnableLevelPlay Create(IEnableLevelPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableLevelPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004714 RID: 18196
		// (get) Token: 0x0600EEE3 RID: 61155 RVA: 0x002304B0 File Offset: 0x0022E6B0
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

		// Token: 0x17004715 RID: 18197
		// (get) Token: 0x0600EEE4 RID: 61156 RVA: 0x0023051C File Offset: 0x0022E71C
		public virtual EPlayerType? TargetPlayer
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EPlayerType?((EPlayerType)this.Instance.TargetPlayer);
			}
		}

		// Token: 0x0400832A RID: 33578
		private IEnableLevelPlay Instance;

		// Token: 0x0400832B RID: 33579
		private List<IEnableLevelPlayConfig> _ConfigsCache;

		// Token: 0x0400832C RID: 33580
		private bool _ConfigsInited;
	}
}
