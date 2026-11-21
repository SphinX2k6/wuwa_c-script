using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A74 RID: 31348
	public class ITalkBackgroundImageByMcGenderT
	{
		// Token: 0x1700E59A RID: 58778
		// (get) Token: 0x06037401 RID: 226305 RVA: 0x00760E04 File Offset: 0x0075F004
		// (set) Token: 0x06037402 RID: 226306 RVA: 0x00760E0C File Offset: 0x0075F00C
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x1700E59B RID: 58779
		// (get) Token: 0x06037403 RID: 226307 RVA: 0x00760E15 File Offset: 0x0075F015
		// (set) Token: 0x06037404 RID: 226308 RVA: 0x00760E1D File Offset: 0x0075F01D
		public string ImageAssetMale { get; set; }

		// Token: 0x1700E59C RID: 58780
		// (get) Token: 0x06037405 RID: 226309 RVA: 0x00760E26 File Offset: 0x0075F026
		// (set) Token: 0x06037406 RID: 226310 RVA: 0x00760E2E File Offset: 0x0075F02E
		public string ImageAssetFemale { get; set; }

		// Token: 0x06037407 RID: 226311 RVA: 0x00760E37 File Offset: 0x0075F037
		public ITalkBackgroundImageByMcGenderT()
		{
			this.Type = ETalkBackgroundType.Clean;
			this.ImageAssetMale = null;
			this.ImageAssetFemale = null;
		}
	}
}
