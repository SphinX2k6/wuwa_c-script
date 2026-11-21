using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BAA RID: 11178
	public class EnableSplineMoveModel : ActionParams
	{
		// Token: 0x0600F652 RID: 63058 RVA: 0x0023E1AD File Offset: 0x0023C3AD
		public static EnableSplineMoveModel Create(IEnableSplineMoveModel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableSplineMoveModel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BAC RID: 19372
		// (get) Token: 0x0600F653 RID: 63059 RVA: 0x0023E1CC File Offset: 0x0023C3CC
		public virtual ISplineMoveConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadEnableSplineMoveModel_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008710 RID: 34576
		private IEnableSplineMoveModel Instance;

		// Token: 0x04008711 RID: 34577
		private ISplineMoveConfig _ConfigCache;

		// Token: 0x04008712 RID: 34578
		private bool _ConfigInited;
	}
}
