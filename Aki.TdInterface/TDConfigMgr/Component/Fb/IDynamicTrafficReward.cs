using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B79 RID: 2937
	public class IDynamicTrafficReward : IDynamicEntityRewardType
	{
		// Token: 0x0600433C RID: 17212 RVA: 0x000AAB01 File Offset: 0x000A8D01
		public static IDynamicTrafficReward Create(IDynamicTrafficReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicTrafficReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x0600433D RID: 17213 RVA: 0x000AAB20 File Offset: 0x000A8D20
		public override EDynamicEntityRewardType Type
		{
			get
			{
				return (EDynamicEntityRewardType)this.Instance.Type;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x000AAB2D File Offset: 0x000A8D2D
		public virtual int RewardId
		{
			get
			{
				return this.Instance.RewardId;
			}
		}

		// Token: 0x04002524 RID: 9508
		private IDynamicTrafficReward Instance;
	}
}
