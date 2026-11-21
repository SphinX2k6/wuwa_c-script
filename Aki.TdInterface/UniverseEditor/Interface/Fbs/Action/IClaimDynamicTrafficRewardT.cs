using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069EE RID: 27118
	public class IClaimDynamicTrafficRewardT
	{
		// Token: 0x1700C776 RID: 51062
		// (get) Token: 0x0602E84C RID: 190540 RVA: 0x00658632 File Offset: 0x00656832
		// (set) Token: 0x0602E84D RID: 190541 RVA: 0x0065863A File Offset: 0x0065683A
		public EDynamicEntityRewardType Type { get; set; }

		// Token: 0x0602E84E RID: 190542 RVA: 0x00658643 File Offset: 0x00656843
		public IClaimDynamicTrafficRewardT()
		{
			this.Type = EDynamicEntityRewardType.Traffic;
		}
	}
}
