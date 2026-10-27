using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200276D RID: 10093
	[NullableContext(1)]
	[Nullable(0)]
	public class ServerForceEnableLevelPlay : ActionParams
	{
		// Token: 0x0600E0C8 RID: 57544 RVA: 0x002137C6 File Offset: 0x002119C6
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

		// Token: 0x170043B0 RID: 17328
		// (get) Token: 0x0600E0C9 RID: 57545 RVA: 0x002137E8 File Offset: 0x002119E8
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

		// Token: 0x04007C77 RID: 31863
		private IServerForceEnableLevelPlay Instance;

		// Token: 0x04007C78 RID: 31864
		private List<IEnableLevelPlayConfig> _ConfigsCache;

		// Token: 0x04007C79 RID: 31865
		private bool _ConfigsInited;
	}
}
