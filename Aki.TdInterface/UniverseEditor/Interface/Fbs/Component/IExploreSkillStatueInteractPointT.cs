using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200520E RID: 21006
	public class IExploreSkillStatueInteractPointT
	{
		// Token: 0x170099DA RID: 39386
		// (get) Token: 0x0602221E RID: 139806 RVA: 0x004BC71D File Offset: 0x004BA91D
		// (set) Token: 0x0602221F RID: 139807 RVA: 0x004BC725 File Offset: 0x004BA925
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x170099DB RID: 39387
		// (get) Token: 0x06022220 RID: 139808 RVA: 0x004BC72E File Offset: 0x004BA92E
		// (set) Token: 0x06022221 RID: 139809 RVA: 0x004BC736 File Offset: 0x004BA936
		public float PullTime { get; set; }

		// Token: 0x170099DC RID: 39388
		// (get) Token: 0x06022222 RID: 139810 RVA: 0x004BC73F File Offset: 0x004BA93F
		// (set) Token: 0x06022223 RID: 139811 RVA: 0x004BC747 File Offset: 0x004BA947
		public List<string> HangingPointList { get; set; }

		// Token: 0x06022224 RID: 139812 RVA: 0x004BC750 File Offset: 0x004BA950
		public IExploreSkillStatueInteractPointT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.PullTime = 0f;
			this.HangingPointList = null;
		}
	}
}
