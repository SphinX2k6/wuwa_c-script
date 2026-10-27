using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B7B RID: 27515
	public class IMp4BackgroundColorT
	{
		// Token: 0x1700CC84 RID: 52356
		// (get) Token: 0x06030512 RID: 197906 RVA: 0x00690968 File Offset: 0x0068EB68
		// (set) Token: 0x06030513 RID: 197907 RVA: 0x00690970 File Offset: 0x0068EB70
		public EMp4BackgroundColor FadeIn { get; set; }

		// Token: 0x1700CC85 RID: 52357
		// (get) Token: 0x06030514 RID: 197908 RVA: 0x00690979 File Offset: 0x0068EB79
		// (set) Token: 0x06030515 RID: 197909 RVA: 0x00690981 File Offset: 0x0068EB81
		public EMp4BackgroundColor FadeOut { get; set; }

		// Token: 0x06030516 RID: 197910 RVA: 0x0069098A File Offset: 0x0068EB8A
		public IMp4BackgroundColorT()
		{
			this.FadeIn = EMp4BackgroundColor.Black;
			this.FadeOut = EMp4BackgroundColor.Black;
		}
	}
}
