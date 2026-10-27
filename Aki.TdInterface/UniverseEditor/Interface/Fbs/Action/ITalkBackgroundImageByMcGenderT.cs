using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200729F RID: 29343
	public class ITalkBackgroundImageByMcGenderT
	{
		// Token: 0x1700D9A1 RID: 55713
		// (get) Token: 0x060340FD RID: 213245 RVA: 0x006FFA68 File Offset: 0x006FDC68
		// (set) Token: 0x060340FE RID: 213246 RVA: 0x006FFA70 File Offset: 0x006FDC70
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x1700D9A2 RID: 55714
		// (get) Token: 0x060340FF RID: 213247 RVA: 0x006FFA79 File Offset: 0x006FDC79
		// (set) Token: 0x06034100 RID: 213248 RVA: 0x006FFA81 File Offset: 0x006FDC81
		public string ImageAssetMale { get; set; }

		// Token: 0x1700D9A3 RID: 55715
		// (get) Token: 0x06034101 RID: 213249 RVA: 0x006FFA8A File Offset: 0x006FDC8A
		// (set) Token: 0x06034102 RID: 213250 RVA: 0x006FFA92 File Offset: 0x006FDC92
		public string ImageAssetFemale { get; set; }

		// Token: 0x06034103 RID: 213251 RVA: 0x006FFA9B File Offset: 0x006FDC9B
		public ITalkBackgroundImageByMcGenderT()
		{
			this.Type = ETalkBackgroundType.Clean;
			this.ImageAssetMale = null;
			this.ImageAssetFemale = null;
		}
	}
}
