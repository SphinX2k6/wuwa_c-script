using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002680 RID: 9856
	public class IClaimDynamicTrafficReward : IClaimDynamicEntityRewardType
	{
		// Token: 0x0600DCCC RID: 56524 RVA: 0x0020D531 File Offset: 0x0020B731
		[NullableContext(1)]
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

		// Token: 0x1700418E RID: 16782
		// (get) Token: 0x0600DCCD RID: 56525 RVA: 0x0020D550 File Offset: 0x0020B750
		public override EDynamicEntityRewardType Type
		{
			get
			{
				return (EDynamicEntityRewardType)this.Instance.Type;
			}
		}

		// Token: 0x04007AB0 RID: 31408
		private IClaimDynamicTrafficReward Instance;
	}
}
