using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E5 RID: 27109
	public class IClaimDynamicEntityRewardT
	{
		// Token: 0x1700C76E RID: 51054
		// (get) Token: 0x0602E81C RID: 190492 RVA: 0x00658231 File Offset: 0x00656431
		// (set) Token: 0x0602E81D RID: 190493 RVA: 0x00658239 File Offset: 0x00656439
		public IClaimDynamicTrafficRewardT RewardType { get; set; }

		// Token: 0x0602E81E RID: 190494 RVA: 0x00658242 File Offset: 0x00656442
		public IClaimDynamicEntityRewardT()
		{
			this.RewardType = null;
		}
	}
}
