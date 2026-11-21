using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049AE RID: 18862
	public class IRewardConfigT
	{
		// Token: 0x1700840A RID: 33802
		// (get) Token: 0x0601C2CA RID: 115402 RVA: 0x003FA9EB File Offset: 0x003F8BEB
		// (set) Token: 0x0601C2CB RID: 115403 RVA: 0x003FA9F3 File Offset: 0x003F8BF3
		public List<int> RewardNodeIds { get; set; }

		// Token: 0x1700840B RID: 33803
		// (get) Token: 0x0601C2CC RID: 115404 RVA: 0x003FA9FC File Offset: 0x003F8BFC
		// (set) Token: 0x0601C2CD RID: 115405 RVA: 0x003FAA04 File Offset: 0x003F8C04
		public List<int> TreasureBoxIds { get; set; }

		// Token: 0x1700840C RID: 33804
		// (get) Token: 0x0601C2CE RID: 115406 RVA: 0x003FAA0D File Offset: 0x003F8C0D
		// (set) Token: 0x0601C2CF RID: 115407 RVA: 0x003FAA15 File Offset: 0x003F8C15
		public List<int> CompleteRewardIds { get; set; }

		// Token: 0x1700840D RID: 33805
		// (get) Token: 0x0601C2D0 RID: 115408 RVA: 0x003FAA1E File Offset: 0x003F8C1E
		// (set) Token: 0x0601C2D1 RID: 115409 RVA: 0x003FAA26 File Offset: 0x003F8C26
		public byte NullMask { get; set; }

		// Token: 0x0601C2D2 RID: 115410 RVA: 0x003FAA2F File Offset: 0x003F8C2F
		public IRewardConfigT()
		{
			this.RewardNodeIds = null;
			this.TreasureBoxIds = null;
			this.CompleteRewardIds = null;
			this.NullMask = 0;
		}
	}
}
