using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CC9 RID: 11465
	public class OpenQteAction : ActionParams
	{
		// Token: 0x0600FB58 RID: 64344 RVA: 0x002468F8 File Offset: 0x00244AF8
		public static OpenQteAction Create(IOpenQteAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenQteAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E74 RID: 20084
		// (get) Token: 0x0600FB59 RID: 64345 RVA: 0x00246917 File Offset: 0x00244B17
		public virtual IOpenQteConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadOpenQteAction_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008953 RID: 35155
		private IOpenQteAction Instance;

		// Token: 0x04008954 RID: 35156
		private IOpenQteConfig _ConfigCache;

		// Token: 0x04008955 RID: 35157
		private bool _ConfigInited;
	}
}
