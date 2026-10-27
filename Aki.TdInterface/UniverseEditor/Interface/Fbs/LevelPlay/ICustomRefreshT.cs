using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004450 RID: 17488
	public class ICustomRefreshT
	{
		// Token: 0x17007B40 RID: 31552
		// (get) Token: 0x0601A074 RID: 106612 RVA: 0x003B8513 File Offset: 0x003B6713
		// (set) Token: 0x0601A075 RID: 106613 RVA: 0x003B851B File Offset: 0x003B671B
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17007B41 RID: 31553
		// (get) Token: 0x0601A076 RID: 106614 RVA: 0x003B8524 File Offset: 0x003B6724
		// (set) Token: 0x0601A077 RID: 106615 RVA: 0x003B852C File Offset: 0x003B672C
		public IConditionGroupT PreCondition { get; set; }

		// Token: 0x17007B42 RID: 31554
		// (get) Token: 0x0601A078 RID: 106616 RVA: 0x003B8535 File Offset: 0x003B6735
		// (set) Token: 0x0601A079 RID: 106617 RVA: 0x003B853D File Offset: 0x003B673D
		public int CompletedRefreshTime { get; set; }

		// Token: 0x17007B43 RID: 31555
		// (get) Token: 0x0601A07A RID: 106618 RVA: 0x003B8546 File Offset: 0x003B6746
		// (set) Token: 0x0601A07B RID: 106619 RVA: 0x003B854E File Offset: 0x003B674E
		public int ChildDestroyRefreshTime { get; set; }

		// Token: 0x17007B44 RID: 31556
		// (get) Token: 0x0601A07C RID: 106620 RVA: 0x003B8557 File Offset: 0x003B6757
		// (set) Token: 0x0601A07D RID: 106621 RVA: 0x003B855F File Offset: 0x003B675F
		public int AwardedRefreshTime { get; set; }

		// Token: 0x17007B45 RID: 31557
		// (get) Token: 0x0601A07E RID: 106622 RVA: 0x003B8568 File Offset: 0x003B6768
		// (set) Token: 0x0601A07F RID: 106623 RVA: 0x003B8570 File Offset: 0x003B6770
		public byte NullMask { get; set; }

		// Token: 0x0601A080 RID: 106624 RVA: 0x003B8579 File Offset: 0x003B6779
		public ICustomRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.PreCondition = null;
			this.CompletedRefreshTime = 0;
			this.ChildDestroyRefreshTime = 0;
			this.AwardedRefreshTime = 0;
			this.NullMask = 0;
		}
	}
}
