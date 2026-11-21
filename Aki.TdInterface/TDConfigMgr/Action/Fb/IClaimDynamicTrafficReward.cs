using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002943 RID: 10563
	public class IClaimDynamicTrafficReward : IClaimDynamicEntityRewardType
	{
		// Token: 0x0600EAA3 RID: 60067 RVA: 0x00229CCF File Offset: 0x00227ECF
		public static IClaimDynamicTrafficReward Create(IClaimDynamicTrafficReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClaimDynamicTrafficReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044CB RID: 17611
		// (get) Token: 0x0600EAA4 RID: 60068 RVA: 0x00229CEE File Offset: 0x00227EEE
		public override EDynamicEntityRewardType Type
		{
			get
			{
				return (EDynamicEntityRewardType)this.Instance.Type;
			}
		}

		// Token: 0x0400814D RID: 33101
		private IClaimDynamicTrafficReward Instance;
	}
}
