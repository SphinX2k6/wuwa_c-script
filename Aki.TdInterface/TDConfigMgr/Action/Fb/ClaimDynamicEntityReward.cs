using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002681 RID: 9857
	[NullableContext(1)]
	[Nullable(0)]
	public class ClaimDynamicEntityReward : ActionParams
	{
		// Token: 0x0600DCCF RID: 56527 RVA: 0x0020D565 File Offset: 0x0020B765
		public static ClaimDynamicEntityReward Create(IClaimDynamicEntityReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClaimDynamicEntityReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700418F RID: 16783
		// (get) Token: 0x0600DCD0 RID: 56528 RVA: 0x0020D584 File Offset: 0x0020B784
		public virtual IClaimDynamicTrafficReward RewardType
		{
			get
			{
				if (this._RewardTypeInited)
				{
					return this._RewardTypeCache;
				}
				this._RewardTypeInited = true;
				this._RewardTypeCache = IClaimDynamicTrafficReward.Create(this.Instance.RewardType);
				return this._RewardTypeCache;
			}
		}

		// Token: 0x04007AB1 RID: 31409
		private IClaimDynamicEntityReward Instance;

		// Token: 0x04007AB2 RID: 31410
		[Nullable(2)]
		private IClaimDynamicTrafficReward _RewardTypeCache;

		// Token: 0x04007AB3 RID: 31411
		private bool _RewardTypeInited;
	}
}
