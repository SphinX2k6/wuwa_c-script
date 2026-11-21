using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A71 RID: 31345
	public class ITalkBackgroundImageT
	{
		// Token: 0x1700E594 RID: 58772
		// (get) Token: 0x060373E5 RID: 226277 RVA: 0x00760B37 File Offset: 0x0075ED37
		// (set) Token: 0x060373E6 RID: 226278 RVA: 0x00760B3F File Offset: 0x0075ED3F
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x1700E595 RID: 58773
		// (get) Token: 0x060373E7 RID: 226279 RVA: 0x00760B48 File Offset: 0x0075ED48
		// (set) Token: 0x060373E8 RID: 226280 RVA: 0x00760B50 File Offset: 0x0075ED50
		public string ImageAsset { get; set; }

		// Token: 0x060373E9 RID: 226281 RVA: 0x00760B59 File Offset: 0x0075ED59
		public ITalkBackgroundImageT()
		{
			this.Type = ETalkBackgroundType.Clean;
			this.ImageAsset = null;
		}
	}
}
