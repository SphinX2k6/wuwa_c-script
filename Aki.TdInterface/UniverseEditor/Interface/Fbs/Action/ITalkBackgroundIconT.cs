using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A6E RID: 31342
	public class ITalkBackgroundIconT
	{
		// Token: 0x1700E58F RID: 58767
		// (get) Token: 0x060373CD RID: 226253 RVA: 0x00760903 File Offset: 0x0075EB03
		// (set) Token: 0x060373CE RID: 226254 RVA: 0x0076090B File Offset: 0x0075EB0B
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x1700E590 RID: 58768
		// (get) Token: 0x060373CF RID: 226255 RVA: 0x00760914 File Offset: 0x0075EB14
		// (set) Token: 0x060373D0 RID: 226256 RVA: 0x0076091C File Offset: 0x0075EB1C
		public string ImageAsset { get; set; }

		// Token: 0x060373D1 RID: 226257 RVA: 0x00760925 File Offset: 0x0075EB25
		public ITalkBackgroundIconT()
		{
			this.Type = ETalkBackgroundType.Clean;
			this.ImageAsset = null;
		}
	}
}
