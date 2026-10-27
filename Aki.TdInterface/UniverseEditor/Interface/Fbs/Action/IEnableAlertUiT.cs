using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006646 RID: 26182
	public class IEnableAlertUiT
	{
		// Token: 0x1700C28C RID: 49804
		// (get) Token: 0x0602D7AF RID: 186287 RVA: 0x0063AB72 File Offset: 0x00638D72
		// (set) Token: 0x0602D7B0 RID: 186288 RVA: 0x0063AB7A File Offset: 0x00638D7A
		public EAlertSystemOption Type { get; set; }

		// Token: 0x1700C28D RID: 49805
		// (get) Token: 0x0602D7B1 RID: 186289 RVA: 0x0063AB83 File Offset: 0x00638D83
		// (set) Token: 0x0602D7B2 RID: 186290 RVA: 0x0063AB8B File Offset: 0x00638D8B
		public int AreaId { get; set; }

		// Token: 0x1700C28E RID: 49806
		// (get) Token: 0x0602D7B3 RID: 186291 RVA: 0x0063AB94 File Offset: 0x00638D94
		// (set) Token: 0x0602D7B4 RID: 186292 RVA: 0x0063AB9C File Offset: 0x00638D9C
		public bool IsEnable { get; set; }

		// Token: 0x0602D7B5 RID: 186293 RVA: 0x0063ABA5 File Offset: 0x00638DA5
		public IEnableAlertUiT()
		{
			this.Type = EAlertSystemOption.EnableAlertArea;
			this.AreaId = 0;
			this.IsEnable = false;
		}
	}
}
