using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002942 RID: 10562
	public class IClaimDynamicEntityRewardType
	{
		// Token: 0x0600EAA0 RID: 60064 RVA: 0x00229C9B File Offset: 0x00227E9B
		public static IClaimDynamicEntityRewardType Create(IClaimDynamicEntityRewardType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClaimDynamicEntityRewardType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044CA RID: 17610
		// (get) Token: 0x0600EAA1 RID: 60065 RVA: 0x00229CBA File Offset: 0x00227EBA
		public virtual EDynamicEntityRewardType Type
		{
			get
			{
				return (EDynamicEntityRewardType)this.Instance.Type;
			}
		}

		// Token: 0x0400814C RID: 33100
		private IClaimDynamicEntityRewardType Instance;
	}
}
