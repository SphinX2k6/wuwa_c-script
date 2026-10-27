using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B93 RID: 19347
	public class ICompareDungeonIdT
	{
		// Token: 0x17008C65 RID: 35941
		// (get) Token: 0x0601E7F4 RID: 124916 RVA: 0x00444C62 File Offset: 0x00442E62
		// (set) Token: 0x0601E7F5 RID: 124917 RVA: 0x00444C6A File Offset: 0x00442E6A
		public ECondition Type { get; set; }

		// Token: 0x17008C66 RID: 35942
		// (get) Token: 0x0601E7F6 RID: 124918 RVA: 0x00444C73 File Offset: 0x00442E73
		// (set) Token: 0x0601E7F7 RID: 124919 RVA: 0x00444C7B File Offset: 0x00442E7B
		public int DungeonId { get; set; }

		// Token: 0x17008C67 RID: 35943
		// (get) Token: 0x0601E7F8 RID: 124920 RVA: 0x00444C84 File Offset: 0x00442E84
		// (set) Token: 0x0601E7F9 RID: 124921 RVA: 0x00444C8C File Offset: 0x00442E8C
		public ECompare Compare { get; set; }

		// Token: 0x0601E7FA RID: 124922 RVA: 0x00444C95 File Offset: 0x00442E95
		public ICompareDungeonIdT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.Compare = ECompare.Eq;
		}
	}
}
