using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BD1 RID: 11217
	public class SetExploreState : ActionParams
	{
		// Token: 0x0600F734 RID: 63284 RVA: 0x0023FD5E File Offset: 0x0023DF5E
		public static SetExploreState Create(ISetExploreState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetExploreState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C40 RID: 19520
		// (get) Token: 0x0600F735 RID: 63285 RVA: 0x0023FD7D File Offset: 0x0023DF7D
		public virtual ITeleControlConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ITeleControlConfig.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x0400875B RID: 34651
		private ISetExploreState Instance;

		// Token: 0x0400875C RID: 34652
		[Nullable(2)]
		private ITeleControlConfig _ConfigCache;

		// Token: 0x0400875D RID: 34653
		private bool _ConfigInited;
	}
}
