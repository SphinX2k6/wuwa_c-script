using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200729C RID: 29340
	public class ITalkBackgroundImageT
	{
		// Token: 0x1700D99B RID: 55707
		// (get) Token: 0x060340E1 RID: 213217 RVA: 0x006FF79B File Offset: 0x006FD99B
		// (set) Token: 0x060340E2 RID: 213218 RVA: 0x006FF7A3 File Offset: 0x006FD9A3
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x1700D99C RID: 55708
		// (get) Token: 0x060340E3 RID: 213219 RVA: 0x006FF7AC File Offset: 0x006FD9AC
		// (set) Token: 0x060340E4 RID: 213220 RVA: 0x006FF7B4 File Offset: 0x006FD9B4
		public string ImageAsset { get; set; }

		// Token: 0x060340E5 RID: 213221 RVA: 0x006FF7BD File Offset: 0x006FD9BD
		public ITalkBackgroundImageT()
		{
			this.Type = ETalkBackgroundType.Clean;
			this.ImageAsset = null;
		}
	}
}
