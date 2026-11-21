using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F78 RID: 28536
	public class IHandInItemViewStyleT
	{
		// Token: 0x1700D107 RID: 53511
		// (get) Token: 0x0603164A RID: 202314 RVA: 0x006B2B93 File Offset: 0x006B0D93
		// (set) Token: 0x0603164B RID: 202315 RVA: 0x006B2B9B File Offset: 0x006B0D9B
		public EDeliverItemProbeCollectibleViewStyle Type { get; set; }

		// Token: 0x1700D108 RID: 53512
		// (get) Token: 0x0603164C RID: 202316 RVA: 0x006B2BA4 File Offset: 0x006B0DA4
		// (set) Token: 0x0603164D RID: 202317 RVA: 0x006B2BAC File Offset: 0x006B0DAC
		public string TidDescText { get; set; }

		// Token: 0x0603164E RID: 202318 RVA: 0x006B2BB5 File Offset: 0x006B0DB5
		public IHandInItemViewStyleT()
		{
			this.Type = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
			this.TidDescText = null;
		}
	}
}
