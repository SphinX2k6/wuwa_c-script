using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BCE RID: 11214
	public class SetSportsState : ActionParams
	{
		// Token: 0x0600F72A RID: 63274 RVA: 0x0023FC93 File Offset: 0x0023DE93
		public static SetSportsState Create(ISetSportsState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSportsState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C3C RID: 19516
		// (get) Token: 0x0600F72B RID: 63275 RVA: 0x0023FCB2 File Offset: 0x0023DEB2
		public virtual ISportConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadSetSportsState_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008756 RID: 34646
		private ISetSportsState Instance;

		// Token: 0x04008757 RID: 34647
		private ISportConfig _ConfigCache;

		// Token: 0x04008758 RID: 34648
		private bool _ConfigInited;
	}
}
