using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A80 RID: 27264
	public class IMechEscortFlyT
	{
		// Token: 0x1700CA64 RID: 51812
		// (get) Token: 0x0602FC5F RID: 195679 RVA: 0x006803C7 File Offset: 0x0067E5C7
		// (set) Token: 0x0602FC60 RID: 195680 RVA: 0x006803CF File Offset: 0x0067E5CF
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700CA65 RID: 51813
		// (get) Token: 0x0602FC61 RID: 195681 RVA: 0x006803D8 File Offset: 0x0067E5D8
		// (set) Token: 0x0602FC62 RID: 195682 RVA: 0x006803E0 File Offset: 0x0067E5E0
		public int TargetEntity { get; set; }

		// Token: 0x1700CA66 RID: 51814
		// (get) Token: 0x0602FC63 RID: 195683 RVA: 0x006803E9 File Offset: 0x0067E5E9
		// (set) Token: 0x0602FC64 RID: 195684 RVA: 0x006803F1 File Offset: 0x0067E5F1
		public int TargetSpline { get; set; }

		// Token: 0x1700CA67 RID: 51815
		// (get) Token: 0x0602FC65 RID: 195685 RVA: 0x006803FA File Offset: 0x0067E5FA
		// (set) Token: 0x0602FC66 RID: 195686 RVA: 0x00680402 File Offset: 0x0067E602
		public List<IMechEscortPointT> EscortPoints { get; set; }

		// Token: 0x0602FC67 RID: 195687 RVA: 0x0068040B File Offset: 0x0067E60B
		public IMechEscortFlyT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.TargetEntity = 0;
			this.TargetSpline = 0;
			this.EscortPoints = null;
		}
	}
}
