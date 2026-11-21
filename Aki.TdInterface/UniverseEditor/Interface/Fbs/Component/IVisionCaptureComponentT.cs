using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006152 RID: 24914
	public class IVisionCaptureComponentT
	{
		// Token: 0x1700B98C RID: 47500
		// (get) Token: 0x0602A482 RID: 173186 RVA: 0x005C4EDC File Offset: 0x005C30DC
		// (set) Token: 0x0602A483 RID: 173187 RVA: 0x005C4EE4 File Offset: 0x005C30E4
		public bool Disabled { get; set; }

		// Token: 0x1700B98D RID: 47501
		// (get) Token: 0x0602A484 RID: 173188 RVA: 0x005C4EED File Offset: 0x005C30ED
		// (set) Token: 0x0602A485 RID: 173189 RVA: 0x005C4EF5 File Offset: 0x005C30F5
		public int VisionCaptureId { get; set; }

		// Token: 0x1700B98E RID: 47502
		// (get) Token: 0x0602A486 RID: 173190 RVA: 0x005C4EFE File Offset: 0x005C30FE
		// (set) Token: 0x0602A487 RID: 173191 RVA: 0x005C4F06 File Offset: 0x005C3106
		public int VisionCaptureProb { get; set; }

		// Token: 0x1700B98F RID: 47503
		// (get) Token: 0x0602A488 RID: 173192 RVA: 0x005C4F0F File Offset: 0x005C310F
		// (set) Token: 0x0602A489 RID: 173193 RVA: 0x005C4F17 File Offset: 0x005C3117
		public byte NullMask { get; set; }

		// Token: 0x0602A48A RID: 173194 RVA: 0x005C4F20 File Offset: 0x005C3120
		public IVisionCaptureComponentT()
		{
			this.Disabled = false;
			this.VisionCaptureId = 0;
			this.VisionCaptureProb = 0;
			this.NullMask = 0;
		}
	}
}
