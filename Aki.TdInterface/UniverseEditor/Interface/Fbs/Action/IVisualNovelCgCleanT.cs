using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D62 RID: 32098
	public class IVisualNovelCgCleanT
	{
		// Token: 0x1700F024 RID: 61476
		// (get) Token: 0x06039F08 RID: 237320 RVA: 0x007D032A File Offset: 0x007CE52A
		// (set) Token: 0x06039F09 RID: 237321 RVA: 0x007D0332 File Offset: 0x007CE532
		public EVisualNovelCgType Type { get; set; }

		// Token: 0x06039F0A RID: 237322 RVA: 0x007D033B File Offset: 0x007CE53B
		public IVisualNovelCgCleanT()
		{
			this.Type = EVisualNovelCgType.LoadPrefab;
		}
	}
}
