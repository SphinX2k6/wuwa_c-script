using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E8 RID: 27112
	public class IClaimDynamicEntityRewardTypeT
	{
		// Token: 0x1700C771 RID: 51057
		// (get) Token: 0x0602E82E RID: 190510 RVA: 0x006583BE File Offset: 0x006565BE
		// (set) Token: 0x0602E82F RID: 190511 RVA: 0x006583C6 File Offset: 0x006565C6
		public EDynamicEntityRewardType Type { get; set; }

		// Token: 0x0602E830 RID: 190512 RVA: 0x006583CF File Offset: 0x006565CF
		public IClaimDynamicEntityRewardTypeT()
		{
			this.Type = EDynamicEntityRewardType.Traffic;
		}
	}
}
