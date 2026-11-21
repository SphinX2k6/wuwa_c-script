using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E15 RID: 11797
	public class LiveSetUi : ActionParams
	{
		// Token: 0x06010047 RID: 65607 RVA: 0x0024E11F File Offset: 0x0024C31F
		public static LiveSetUi Create(ILiveSetUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LiveSetUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050CB RID: 20683
		// (get) Token: 0x06010048 RID: 65608 RVA: 0x0024E13E File Offset: 0x0024C33E
		public virtual ILiveUiConfig UiConfig
		{
			get
			{
				if (this._UiConfigInited)
				{
					return this._UiConfigCache;
				}
				this._UiConfigInited = true;
				this._UiConfigCache = ActionReadHelper.ReadLiveSetUi_UiConfig(this.Instance);
				return this._UiConfigCache;
			}
		}

		// Token: 0x04008BD9 RID: 35801
		private ILiveSetUi Instance;

		// Token: 0x04008BDA RID: 35802
		private ILiveUiConfig _UiConfigCache;

		// Token: 0x04008BDB RID: 35803
		private bool _UiConfigInited;
	}
}
