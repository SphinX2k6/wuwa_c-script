using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BCA RID: 11210
	public class ISkiConfig : ISportConfig
	{
		// Token: 0x0600F71B RID: 63259 RVA: 0x0023FB7A File Offset: 0x0023DD7A
		public static ISkiConfig Create(ISkiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C35 RID: 19509
		// (get) Token: 0x0600F71C RID: 63260 RVA: 0x0023FB99 File Offset: 0x0023DD99
		public override ESportStateType Type
		{
			get
			{
				return (ESportStateType)this.Instance.Type;
			}
		}

		// Token: 0x17004C36 RID: 19510
		// (get) Token: 0x0600F71D RID: 63261 RVA: 0x0023FBA6 File Offset: 0x0023DDA6
		public virtual ISkiConfigType Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadISkiConfig_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008750 RID: 34640
		private ISkiConfig Instance;

		// Token: 0x04008751 RID: 34641
		private ISkiConfigType _ConfigCache;

		// Token: 0x04008752 RID: 34642
		private bool _ConfigInited;
	}
}
