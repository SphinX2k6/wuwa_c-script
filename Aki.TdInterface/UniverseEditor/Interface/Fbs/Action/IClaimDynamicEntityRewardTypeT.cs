using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006377 RID: 25463
	public class IClaimDynamicEntityRewardTypeT
	{
		// Token: 0x1700BDE9 RID: 48617
		// (get) Token: 0x0602C0C4 RID: 180420 RVA: 0x0060D26A File Offset: 0x0060B46A
		// (set) Token: 0x0602C0C5 RID: 180421 RVA: 0x0060D272 File Offset: 0x0060B472
		public EDynamicEntityRewardType Type { get; set; }

		// Token: 0x0602C0C6 RID: 180422 RVA: 0x0060D27B File Offset: 0x0060B47B
		public IClaimDynamicEntityRewardTypeT()
		{
			this.Type = EDynamicEntityRewardType.Traffic;
		}
	}
}
