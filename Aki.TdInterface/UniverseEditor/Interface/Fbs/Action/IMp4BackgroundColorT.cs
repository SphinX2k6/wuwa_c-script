using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C1 RID: 29377
	public class IMp4BackgroundColorT
	{
		// Token: 0x1700D769 RID: 55145
		// (get) Token: 0x0603336A RID: 209770 RVA: 0x006E8F88 File Offset: 0x006E7188
		// (set) Token: 0x0603336B RID: 209771 RVA: 0x006E8F90 File Offset: 0x006E7190
		public EMp4BackgroundColor FadeIn { get; set; }

		// Token: 0x1700D76A RID: 55146
		// (get) Token: 0x0603336C RID: 209772 RVA: 0x006E8F99 File Offset: 0x006E7199
		// (set) Token: 0x0603336D RID: 209773 RVA: 0x006E8FA1 File Offset: 0x006E71A1
		public EMp4BackgroundColor FadeOut { get; set; }

		// Token: 0x0603336E RID: 209774 RVA: 0x006E8FAA File Offset: 0x006E71AA
		public IMp4BackgroundColorT()
		{
			this.FadeIn = EMp4BackgroundColor.Black;
			this.FadeOut = EMp4BackgroundColor.Black;
		}
	}
}
