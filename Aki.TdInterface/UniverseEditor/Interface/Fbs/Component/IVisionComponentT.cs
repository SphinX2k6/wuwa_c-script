using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B3F RID: 23359
	public class IVisionComponentT
	{
		// Token: 0x1700B04C RID: 45132
		// (get) Token: 0x06027EDA RID: 163546 RVA: 0x0057D706 File Offset: 0x0057B906
		// (set) Token: 0x06027EDB RID: 163547 RVA: 0x0057D70E File Offset: 0x0057B90E
		public bool Disabled { get; set; }

		// Token: 0x1700B04D RID: 45133
		// (get) Token: 0x06027EDC RID: 163548 RVA: 0x0057D717 File Offset: 0x0057B917
		// (set) Token: 0x06027EDD RID: 163549 RVA: 0x0057D71F File Offset: 0x0057B91F
		public int VisionId { get; set; }

		// Token: 0x1700B04E RID: 45134
		// (get) Token: 0x06027EDE RID: 163550 RVA: 0x0057D728 File Offset: 0x0057B928
		// (set) Token: 0x06027EDF RID: 163551 RVA: 0x0057D730 File Offset: 0x0057B930
		public byte NullMask { get; set; }

		// Token: 0x06027EE0 RID: 163552 RVA: 0x0057D739 File Offset: 0x0057B939
		public IVisionComponentT()
		{
			this.Disabled = false;
			this.VisionId = 0;
			this.NullMask = 0;
		}
	}
}
