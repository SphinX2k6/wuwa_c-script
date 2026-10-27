using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583C RID: 22588
	public class IRefreshSingleComponentT
	{
		// Token: 0x1700A8BB RID: 43195
		// (get) Token: 0x06025FEF RID: 155631 RVA: 0x0053CE35 File Offset: 0x0053B035
		// (set) Token: 0x06025FF0 RID: 155632 RVA: 0x0053CE3D File Offset: 0x0053B03D
		public bool Disabled { get; set; }

		// Token: 0x1700A8BC RID: 43196
		// (get) Token: 0x06025FF1 RID: 155633 RVA: 0x0053CE46 File Offset: 0x0053B046
		// (set) Token: 0x06025FF2 RID: 155634 RVA: 0x0053CE4E File Offset: 0x0053B04E
		public int RefreshInterval { get; set; }

		// Token: 0x1700A8BD RID: 43197
		// (get) Token: 0x06025FF3 RID: 155635 RVA: 0x0053CE57 File Offset: 0x0053B057
		// (set) Token: 0x06025FF4 RID: 155636 RVA: 0x0053CE5F File Offset: 0x0053B05F
		public bool DelayRefresh { get; set; }

		// Token: 0x1700A8BE RID: 43198
		// (get) Token: 0x06025FF5 RID: 155637 RVA: 0x0053CE68 File Offset: 0x0053B068
		// (set) Token: 0x06025FF6 RID: 155638 RVA: 0x0053CE70 File Offset: 0x0053B070
		public string TemplateGuid { get; set; }

		// Token: 0x1700A8BF RID: 43199
		// (get) Token: 0x06025FF7 RID: 155639 RVA: 0x0053CE79 File Offset: 0x0053B079
		// (set) Token: 0x06025FF8 RID: 155640 RVA: 0x0053CE81 File Offset: 0x0053B081
		public byte NullMask { get; set; }

		// Token: 0x06025FF9 RID: 155641 RVA: 0x0053CE8A File Offset: 0x0053B08A
		public IRefreshSingleComponentT()
		{
			this.Disabled = false;
			this.RefreshInterval = 0;
			this.DelayRefresh = false;
			this.TemplateGuid = null;
			this.NullMask = 0;
		}
	}
}
