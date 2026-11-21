using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C6C RID: 11372
	public class PlayDynamicSettlement : ActionParams
	{
		// Token: 0x0600F9ED RID: 63981 RVA: 0x002447BE File Offset: 0x002429BE
		public static PlayDynamicSettlement Create(IPlayDynamicSettlement? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayDynamicSettlement
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DC3 RID: 19907
		// (get) Token: 0x0600F9EE RID: 63982 RVA: 0x002447DD File Offset: 0x002429DD
		public virtual IDynamicSettlementConfig DynamicSettlementConfig
		{
			get
			{
				if (this._DynamicSettlementConfigInited)
				{
					return this._DynamicSettlementConfigCache;
				}
				this._DynamicSettlementConfigInited = true;
				this._DynamicSettlementConfigCache = ActionReadHelper.ReadPlayDynamicSettlement_DynamicSettlementConfig(this.Instance);
				return this._DynamicSettlementConfigCache;
			}
		}

		// Token: 0x0400888E RID: 34958
		private IPlayDynamicSettlement Instance;

		// Token: 0x0400888F RID: 34959
		private IDynamicSettlementConfig _DynamicSettlementConfigCache;

		// Token: 0x04008890 RID: 34960
		private bool _DynamicSettlementConfigInited;
	}
}
