using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D65 RID: 32101
	public class IVisualNovelCgLoadImageT
	{
		// Token: 0x1700F028 RID: 61480
		// (get) Token: 0x06039F1C RID: 237340 RVA: 0x007D0504 File Offset: 0x007CE704
		// (set) Token: 0x06039F1D RID: 237341 RVA: 0x007D050C File Offset: 0x007CE70C
		public EVisualNovelCgType Type { get; set; }

		// Token: 0x1700F029 RID: 61481
		// (get) Token: 0x06039F1E RID: 237342 RVA: 0x007D0515 File Offset: 0x007CE715
		// (set) Token: 0x06039F1F RID: 237343 RVA: 0x007D051D File Offset: 0x007CE71D
		public int ImageId { get; set; }

		// Token: 0x06039F20 RID: 237344 RVA: 0x007D0526 File Offset: 0x007CE726
		public IVisualNovelCgLoadImageT()
		{
			this.Type = EVisualNovelCgType.LoadPrefab;
			this.ImageId = 0;
		}
	}
}
