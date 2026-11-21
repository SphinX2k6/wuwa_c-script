using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D68 RID: 32104
	public class IVisualNovelCgLoadPrefabT
	{
		// Token: 0x1700F02E RID: 61486
		// (get) Token: 0x06039F36 RID: 237366 RVA: 0x007D0799 File Offset: 0x007CE999
		// (set) Token: 0x06039F37 RID: 237367 RVA: 0x007D07A1 File Offset: 0x007CE9A1
		public EVisualNovelCgType Type { get; set; }

		// Token: 0x1700F02F RID: 61487
		// (get) Token: 0x06039F38 RID: 237368 RVA: 0x007D07AA File Offset: 0x007CE9AA
		// (set) Token: 0x06039F39 RID: 237369 RVA: 0x007D07B2 File Offset: 0x007CE9B2
		public int PrefabId { get; set; }

		// Token: 0x1700F030 RID: 61488
		// (get) Token: 0x06039F3A RID: 237370 RVA: 0x007D07BB File Offset: 0x007CE9BB
		// (set) Token: 0x06039F3B RID: 237371 RVA: 0x007D07C3 File Offset: 0x007CE9C3
		public string AnimationName { get; set; }

		// Token: 0x06039F3C RID: 237372 RVA: 0x007D07CC File Offset: 0x007CE9CC
		public IVisualNovelCgLoadPrefabT()
		{
			this.Type = EVisualNovelCgType.LoadPrefab;
			this.PrefabId = 0;
			this.AnimationName = null;
		}
	}
}
