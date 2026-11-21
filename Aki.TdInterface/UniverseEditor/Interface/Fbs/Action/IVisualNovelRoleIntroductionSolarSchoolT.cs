using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DE3 RID: 32227
	public class IVisualNovelRoleIntroductionSolarSchoolT
	{
		// Token: 0x1700F171 RID: 61809
		// (get) Token: 0x0603A3E3 RID: 238563 RVA: 0x007D95AC File Offset: 0x007D77AC
		// (set) Token: 0x0603A3E4 RID: 238564 RVA: 0x007D95B4 File Offset: 0x007D77B4
		public EVisualNovelSubType Type { get; set; }

		// Token: 0x1700F172 RID: 61810
		// (get) Token: 0x0603A3E5 RID: 238565 RVA: 0x007D95BD File Offset: 0x007D77BD
		// (set) Token: 0x0603A3E6 RID: 238566 RVA: 0x007D95C5 File Offset: 0x007D77C5
		public int IntroductionId { get; set; }

		// Token: 0x1700F173 RID: 61811
		// (get) Token: 0x0603A3E7 RID: 238567 RVA: 0x007D95CE File Offset: 0x007D77CE
		// (set) Token: 0x0603A3E8 RID: 238568 RVA: 0x007D95D6 File Offset: 0x007D77D6
		public float Duration { get; set; }

		// Token: 0x1700F174 RID: 61812
		// (get) Token: 0x0603A3E9 RID: 238569 RVA: 0x007D95DF File Offset: 0x007D77DF
		// (set) Token: 0x0603A3EA RID: 238570 RVA: 0x007D95E7 File Offset: 0x007D77E7
		public byte NullMask { get; set; }

		// Token: 0x0603A3EB RID: 238571 RVA: 0x007D95F0 File Offset: 0x007D77F0
		public IVisualNovelRoleIntroductionSolarSchoolT()
		{
			this.Type = EVisualNovelSubType.SolarSchool;
			this.IntroductionId = 0;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
