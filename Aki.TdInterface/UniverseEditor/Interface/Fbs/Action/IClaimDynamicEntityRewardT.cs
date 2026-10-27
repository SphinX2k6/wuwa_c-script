using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006374 RID: 25460
	public class IClaimDynamicEntityRewardT
	{
		// Token: 0x1700BDE6 RID: 48614
		// (get) Token: 0x0602C0B2 RID: 180402 RVA: 0x0060D0DD File Offset: 0x0060B2DD
		// (set) Token: 0x0602C0B3 RID: 180403 RVA: 0x0060D0E5 File Offset: 0x0060B2E5
		public IClaimDynamicTrafficRewardT RewardType { get; set; }

		// Token: 0x0602C0B4 RID: 180404 RVA: 0x0060D0EE File Offset: 0x0060B2EE
		public IClaimDynamicEntityRewardT()
		{
			this.RewardType = null;
		}
	}
}
