using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200637D RID: 25469
	public class IClaimDynamicTrafficRewardT
	{
		// Token: 0x1700BDEE RID: 48622
		// (get) Token: 0x0602C0E2 RID: 180450 RVA: 0x0060D4DE File Offset: 0x0060B6DE
		// (set) Token: 0x0602C0E3 RID: 180451 RVA: 0x0060D4E6 File Offset: 0x0060B6E6
		public EDynamicEntityRewardType Type { get; set; }

		// Token: 0x0602C0E4 RID: 180452 RVA: 0x0060D4EF File Offset: 0x0060B6EF
		public IClaimDynamicTrafficRewardT()
		{
			this.Type = EDynamicEntityRewardType.Traffic;
		}
	}
}
