using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DC RID: 10716
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenQteAction : ActionParams
	{
		// Token: 0x0600ECC1 RID: 60609 RVA: 0x00228F74 File Offset: 0x00227174
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

		// Token: 0x17004ACB RID: 19147
		// (get) Token: 0x0600ECC2 RID: 60610 RVA: 0x00228F93 File Offset: 0x00227193
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

		// Token: 0x04008262 RID: 33378
		private IOpenQteAction Instance;

		// Token: 0x04008263 RID: 33379
		private IOpenQteConfig _ConfigCache;

		// Token: 0x04008264 RID: 33380
		private bool _ConfigInited;
	}
}
