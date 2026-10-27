using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007299 RID: 29337
	public class ITalkBackgroundIconT
	{
		// Token: 0x1700D996 RID: 55702
		// (get) Token: 0x060340C9 RID: 213193 RVA: 0x006FF567 File Offset: 0x006FD767
		// (set) Token: 0x060340CA RID: 213194 RVA: 0x006FF56F File Offset: 0x006FD76F
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x1700D997 RID: 55703
		// (get) Token: 0x060340CB RID: 213195 RVA: 0x006FF578 File Offset: 0x006FD778
		// (set) Token: 0x060340CC RID: 213196 RVA: 0x006FF580 File Offset: 0x006FD780
		public string ImageAsset { get; set; }

		// Token: 0x060340CD RID: 213197 RVA: 0x006FF589 File Offset: 0x006FD789
		public ITalkBackgroundIconT()
		{
			this.Type = ETalkBackgroundType.Clean;
			this.ImageAsset = null;
		}
	}
}
