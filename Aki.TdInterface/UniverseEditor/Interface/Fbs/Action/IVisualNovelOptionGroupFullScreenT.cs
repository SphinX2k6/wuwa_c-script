using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D89 RID: 32137
	public class IVisualNovelOptionGroupFullScreenT
	{
		// Token: 0x1700F065 RID: 61541
		// (get) Token: 0x0603A02C RID: 237612 RVA: 0x007D1FE6 File Offset: 0x007D01E6
		// (set) Token: 0x0603A02D RID: 237613 RVA: 0x007D1FEE File Offset: 0x007D01EE
		public EVisualNovelOptionGroupType Type { get; set; }

		// Token: 0x0603A02E RID: 237614 RVA: 0x007D1FF7 File Offset: 0x007D01F7
		public IVisualNovelOptionGroupFullScreenT()
		{
			this.Type = EVisualNovelOptionGroupType.Normal;
		}
	}
}
