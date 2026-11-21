using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007440 RID: 29760
	public class IPictureCaptionConfigT
	{
		// Token: 0x1700DA96 RID: 55958
		// (get) Token: 0x06034138 RID: 213304 RVA: 0x007046AC File Offset: 0x007028AC
		// (set) Token: 0x06034139 RID: 213305 RVA: 0x007046B4 File Offset: 0x007028B4
		public string PictureCaption { get; set; }

		// Token: 0x1700DA97 RID: 55959
		// (get) Token: 0x0603413A RID: 213306 RVA: 0x007046BD File Offset: 0x007028BD
		// (set) Token: 0x0603413B RID: 213307 RVA: 0x007046C5 File Offset: 0x007028C5
		public string UiPrefabId { get; set; }

		// Token: 0x1700DA98 RID: 55960
		// (get) Token: 0x0603413C RID: 213308 RVA: 0x007046CE File Offset: 0x007028CE
		// (set) Token: 0x0603413D RID: 213309 RVA: 0x007046D6 File Offset: 0x007028D6
		public float Duration { get; set; }

		// Token: 0x1700DA99 RID: 55961
		// (get) Token: 0x0603413E RID: 213310 RVA: 0x007046DF File Offset: 0x007028DF
		// (set) Token: 0x0603413F RID: 213311 RVA: 0x007046E7 File Offset: 0x007028E7
		public IUiAnimConfigT UiAnimConfig { get; set; }

		// Token: 0x06034140 RID: 213312 RVA: 0x007046F0 File Offset: 0x007028F0
		public IPictureCaptionConfigT()
		{
			this.PictureCaption = null;
			this.UiPrefabId = null;
			this.Duration = 0f;
			this.UiAnimConfig = null;
		}
	}
}
