using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C20 RID: 19488
	public class IExploreLevelCondtionT
	{
		// Token: 0x17008D91 RID: 36241
		// (get) Token: 0x0601EDFF RID: 126463 RVA: 0x0045255C File Offset: 0x0045075C
		// (set) Token: 0x0601EE00 RID: 126464 RVA: 0x00452564 File Offset: 0x00450764
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008D92 RID: 36242
		// (get) Token: 0x0601EE01 RID: 126465 RVA: 0x0045256D File Offset: 0x0045076D
		// (set) Token: 0x0601EE02 RID: 126466 RVA: 0x00452575 File Offset: 0x00450775
		public int ExploreLevel { get; set; }

		// Token: 0x0601EE03 RID: 126467 RVA: 0x0045257E File Offset: 0x0045077E
		public IExploreLevelCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.ExploreLevel = 0;
		}
	}
}
