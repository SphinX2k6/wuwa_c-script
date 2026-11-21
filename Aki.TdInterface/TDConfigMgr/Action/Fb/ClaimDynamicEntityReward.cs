using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002944 RID: 10564
	public class ClaimDynamicEntityReward : ActionParams
	{
		// Token: 0x0600EAA6 RID: 60070 RVA: 0x00229D03 File Offset: 0x00227F03
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

		// Token: 0x170044CC RID: 17612
		// (get) Token: 0x0600EAA7 RID: 60071 RVA: 0x00229D22 File Offset: 0x00227F22
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

		// Token: 0x0400814E RID: 33102
		private IClaimDynamicEntityReward Instance;

		// Token: 0x0400814F RID: 33103
		[Nullable(2)]
		private IClaimDynamicTrafficReward _RewardTypeCache;

		// Token: 0x04008150 RID: 33104
		private bool _RewardTypeInited;
	}
}
