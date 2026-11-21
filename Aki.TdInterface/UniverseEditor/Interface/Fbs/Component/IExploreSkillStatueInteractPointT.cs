using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005776 RID: 22390
	public class IExploreSkillStatueInteractPointT
	{
		// Token: 0x1700A1D6 RID: 41430
		// (get) Token: 0x060241B4 RID: 147892 RVA: 0x004F71E1 File Offset: 0x004F53E1
		// (set) Token: 0x060241B5 RID: 147893 RVA: 0x004F71E9 File Offset: 0x004F53E9
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A1D7 RID: 41431
		// (get) Token: 0x060241B6 RID: 147894 RVA: 0x004F71F2 File Offset: 0x004F53F2
		// (set) Token: 0x060241B7 RID: 147895 RVA: 0x004F71FA File Offset: 0x004F53FA
		public float PullTime { get; set; }

		// Token: 0x1700A1D8 RID: 41432
		// (get) Token: 0x060241B8 RID: 147896 RVA: 0x004F7203 File Offset: 0x004F5403
		// (set) Token: 0x060241B9 RID: 147897 RVA: 0x004F720B File Offset: 0x004F540B
		public List<string> HangingPointList { get; set; }

		// Token: 0x060241BA RID: 147898 RVA: 0x004F7214 File Offset: 0x004F5414
		public IExploreSkillStatueInteractPointT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.PullTime = 0f;
			this.HangingPointList = null;
		}
	}
}
