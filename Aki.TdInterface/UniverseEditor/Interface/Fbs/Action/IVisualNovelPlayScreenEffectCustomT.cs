using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DCB RID: 32203
	public class IVisualNovelPlayScreenEffectCustomT
	{
		// Token: 0x1700F13E RID: 61758
		// (get) Token: 0x0603A31B RID: 238363 RVA: 0x007D81E0 File Offset: 0x007D63E0
		// (set) Token: 0x0603A31C RID: 238364 RVA: 0x007D81E8 File Offset: 0x007D63E8
		public EVisualNovelScreenEffectType Type { get; set; }

		// Token: 0x1700F13F RID: 61759
		// (get) Token: 0x0603A31D RID: 238365 RVA: 0x007D81F1 File Offset: 0x007D63F1
		// (set) Token: 0x0603A31E RID: 238366 RVA: 0x007D81F9 File Offset: 0x007D63F9
		public EVisualNovelScreenEffectCustomType CustomType { get; set; }

		// Token: 0x0603A31F RID: 238367 RVA: 0x007D8202 File Offset: 0x007D6402
		public IVisualNovelPlayScreenEffectCustomT()
		{
			this.Type = EVisualNovelScreenEffectType.OneShot;
			this.CustomType = EVisualNovelScreenEffectCustomType.BurstEye;
		}
	}
}
