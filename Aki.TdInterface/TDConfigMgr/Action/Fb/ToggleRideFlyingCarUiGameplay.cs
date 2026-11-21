using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B58 RID: 11096
	public class ToggleRideFlyingCarUiGameplay : ActionParams
	{
		// Token: 0x0600F3E7 RID: 62439 RVA: 0x002392FE File Offset: 0x002374FE
		public static ToggleRideFlyingCarUiGameplay Create(IToggleRideFlyingCarUiGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleRideFlyingCarUiGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E5 RID: 18917
		// (get) Token: 0x0600F3E8 RID: 62440 RVA: 0x0023931D File Offset: 0x0023751D
		public virtual IToggleRideFlyingCarUiGameplayConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadToggleRideFlyingCarUiGameplay_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x040085C4 RID: 34244
		private IToggleRideFlyingCarUiGameplay Instance;

		// Token: 0x040085C5 RID: 34245
		private IToggleRideFlyingCarUiGameplayConfig _ConfigCache;

		// Token: 0x040085C6 RID: 34246
		private bool _ConfigInited;
	}
}
