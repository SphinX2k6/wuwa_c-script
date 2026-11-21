using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D8C RID: 32140
	public class IVisualNovelOptionGroupNormalT
	{
		// Token: 0x1700F068 RID: 61544
		// (get) Token: 0x0603A03E RID: 237630 RVA: 0x007D215E File Offset: 0x007D035E
		// (set) Token: 0x0603A03F RID: 237631 RVA: 0x007D2166 File Offset: 0x007D0366
		public EVisualNovelOptionGroupType Type { get; set; }

		// Token: 0x0603A040 RID: 237632 RVA: 0x007D216F File Offset: 0x007D036F
		public IVisualNovelOptionGroupNormalT()
		{
			this.Type = EVisualNovelOptionGroupType.Normal;
		}
	}
}
