using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002986 RID: 10630
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayDynamicSettlement : ActionParams
	{
		// Token: 0x0600EB72 RID: 60274 RVA: 0x00227066 File Offset: 0x00225266
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

		// Token: 0x17004A28 RID: 18984
		// (get) Token: 0x0600EB73 RID: 60275 RVA: 0x00227085 File Offset: 0x00225285
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

		// Token: 0x040081AA RID: 33194
		private IPlayDynamicSettlement Instance;

		// Token: 0x040081AB RID: 33195
		private IDynamicSettlementConfig _DynamicSettlementConfigCache;

		// Token: 0x040081AC RID: 33196
		private bool _DynamicSettlementConfigInited;
	}
}
