using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C9F RID: 11423
	public class SetTeleControl : ActionParams
	{
		// Token: 0x0600FAB9 RID: 64185 RVA: 0x002458F4 File Offset: 0x00243AF4
		public static SetTeleControl Create(ISetTeleControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetTeleControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E29 RID: 20009
		// (get) Token: 0x0600FABA RID: 64186 RVA: 0x00245913 File Offset: 0x00243B13
		public virtual ISetTeleControlConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadSetTeleControl_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x040088F5 RID: 35061
		private ISetTeleControl Instance;

		// Token: 0x040088F6 RID: 35062
		private ISetTeleControlConfig _ConfigCache;

		// Token: 0x040088F7 RID: 35063
		private bool _ConfigInited;
	}
}
