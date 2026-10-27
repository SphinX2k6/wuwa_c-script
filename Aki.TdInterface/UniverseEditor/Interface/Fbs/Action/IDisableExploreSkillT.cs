using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065E3 RID: 26083
	public class IDisableExploreSkillT
	{
		// Token: 0x1700C1A7 RID: 49575
		// (get) Token: 0x0602D40A RID: 185354 RVA: 0x00633AE3 File Offset: 0x00631CE3
		// (set) Token: 0x0602D40B RID: 185355 RVA: 0x00633AEB File Offset: 0x00631CEB
		public bool PlaceTemporaryTeleport { get; set; }

		// Token: 0x1700C1A8 RID: 49576
		// (get) Token: 0x0602D40C RID: 185356 RVA: 0x00633AF4 File Offset: 0x00631CF4
		// (set) Token: 0x0602D40D RID: 185357 RVA: 0x00633AFC File Offset: 0x00631CFC
		public bool IsComplementary { get; set; }

		// Token: 0x1700C1A9 RID: 49577
		// (get) Token: 0x0602D40E RID: 185358 RVA: 0x00633B05 File Offset: 0x00631D05
		// (set) Token: 0x0602D40F RID: 185359 RVA: 0x00633B0D File Offset: 0x00631D0D
		public List<EExploreSkillType> ExploreSkillList { get; set; }

		// Token: 0x1700C1AA RID: 49578
		// (get) Token: 0x0602D410 RID: 185360 RVA: 0x00633B16 File Offset: 0x00631D16
		// (set) Token: 0x0602D411 RID: 185361 RVA: 0x00633B1E File Offset: 0x00631D1E
		public byte NullMask { get; set; }

		// Token: 0x0602D412 RID: 185362 RVA: 0x00633B27 File Offset: 0x00631D27
		public IDisableExploreSkillT()
		{
			this.PlaceTemporaryTeleport = false;
			this.IsComplementary = false;
			this.ExploreSkillList = null;
			this.NullMask = 0;
		}
	}
}
