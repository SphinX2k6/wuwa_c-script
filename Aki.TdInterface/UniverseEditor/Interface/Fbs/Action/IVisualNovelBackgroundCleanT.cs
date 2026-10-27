using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007560 RID: 30048
	public class IVisualNovelBackgroundCleanT
	{
		// Token: 0x1700E3ED RID: 58349
		// (get) Token: 0x06036AA8 RID: 223912 RVA: 0x0076CA06 File Offset: 0x0076AC06
		// (set) Token: 0x06036AA9 RID: 223913 RVA: 0x0076CA0E File Offset: 0x0076AC0E
		public EVisualNovelBackgroundType Type { get; set; }

		// Token: 0x06036AAA RID: 223914 RVA: 0x0076CA17 File Offset: 0x0076AC17
		public IVisualNovelBackgroundCleanT()
		{
			this.Type = EVisualNovelBackgroundType.Load;
		}
	}
}
