using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B3C RID: 23356
	public class IVisionCaptureComponentT
	{
		// Token: 0x1700B044 RID: 45124
		// (get) Token: 0x06027EBE RID: 163518 RVA: 0x0057D44C File Offset: 0x0057B64C
		// (set) Token: 0x06027EBF RID: 163519 RVA: 0x0057D454 File Offset: 0x0057B654
		public bool Disabled { get; set; }

		// Token: 0x1700B045 RID: 45125
		// (get) Token: 0x06027EC0 RID: 163520 RVA: 0x0057D45D File Offset: 0x0057B65D
		// (set) Token: 0x06027EC1 RID: 163521 RVA: 0x0057D465 File Offset: 0x0057B665
		public int VisionCaptureId { get; set; }

		// Token: 0x1700B046 RID: 45126
		// (get) Token: 0x06027EC2 RID: 163522 RVA: 0x0057D46E File Offset: 0x0057B66E
		// (set) Token: 0x06027EC3 RID: 163523 RVA: 0x0057D476 File Offset: 0x0057B676
		public int VisionCaptureProb { get; set; }

		// Token: 0x1700B047 RID: 45127
		// (get) Token: 0x06027EC4 RID: 163524 RVA: 0x0057D47F File Offset: 0x0057B67F
		// (set) Token: 0x06027EC5 RID: 163525 RVA: 0x0057D487 File Offset: 0x0057B687
		public byte NullMask { get; set; }

		// Token: 0x06027EC6 RID: 163526 RVA: 0x0057D490 File Offset: 0x0057B690
		public IVisionCaptureComponentT()
		{
			this.Disabled = false;
			this.VisionCaptureId = 0;
			this.VisionCaptureProb = 0;
			this.NullMask = 0;
		}
	}
}
