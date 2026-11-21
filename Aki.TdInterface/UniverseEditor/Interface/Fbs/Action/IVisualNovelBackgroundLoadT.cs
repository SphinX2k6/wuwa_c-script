using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D59 RID: 32089
	public class IVisualNovelBackgroundLoadT
	{
		// Token: 0x1700F01B RID: 61467
		// (get) Token: 0x06039ED2 RID: 237266 RVA: 0x007CFE88 File Offset: 0x007CE088
		// (set) Token: 0x06039ED3 RID: 237267 RVA: 0x007CFE90 File Offset: 0x007CE090
		public EVisualNovelBackgroundType Type { get; set; }

		// Token: 0x1700F01C RID: 61468
		// (get) Token: 0x06039ED4 RID: 237268 RVA: 0x007CFE99 File Offset: 0x007CE099
		// (set) Token: 0x06039ED5 RID: 237269 RVA: 0x007CFEA1 File Offset: 0x007CE0A1
		public int BackgroundId { get; set; }

		// Token: 0x06039ED6 RID: 237270 RVA: 0x007CFEAA File Offset: 0x007CE0AA
		public IVisualNovelBackgroundLoadT()
		{
			this.Type = EVisualNovelBackgroundType.Load;
			this.BackgroundId = 0;
		}
	}
}
