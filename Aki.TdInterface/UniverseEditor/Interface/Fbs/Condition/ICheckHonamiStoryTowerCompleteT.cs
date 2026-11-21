using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F2D RID: 20269
	public class ICheckHonamiStoryTowerCompleteT
	{
		// Token: 0x170090C6 RID: 37062
		// (get) Token: 0x0601F813 RID: 129043 RVA: 0x004626B6 File Offset: 0x004608B6
		// (set) Token: 0x0601F814 RID: 129044 RVA: 0x004626BE File Offset: 0x004608BE
		public ECondition Type { get; set; }

		// Token: 0x170090C7 RID: 37063
		// (get) Token: 0x0601F815 RID: 129045 RVA: 0x004626C7 File Offset: 0x004608C7
		// (set) Token: 0x0601F816 RID: 129046 RVA: 0x004626CF File Offset: 0x004608CF
		public int ActivityId { get; set; }

		// Token: 0x170090C8 RID: 37064
		// (get) Token: 0x0601F817 RID: 129047 RVA: 0x004626D8 File Offset: 0x004608D8
		// (set) Token: 0x0601F818 RID: 129048 RVA: 0x004626E0 File Offset: 0x004608E0
		public int Floor { get; set; }

		// Token: 0x0601F819 RID: 129049 RVA: 0x004626E9 File Offset: 0x004608E9
		public ICheckHonamiStoryTowerCompleteT()
		{
			this.Type = ECondition.CompareVar;
			this.ActivityId = 0;
			this.Floor = 0;
		}
	}
}
