using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200439F RID: 17311
	public class ILevelPlayAllRefOccupationsT
	{
		// Token: 0x17007A5C RID: 31324
		// (get) Token: 0x06019C49 RID: 105545 RVA: 0x003B0778 File Offset: 0x003AE978
		// (set) Token: 0x06019C4A RID: 105546 RVA: 0x003B0780 File Offset: 0x003AE980
		public int LevelPlayId { get; set; }

		// Token: 0x17007A5D RID: 31325
		// (get) Token: 0x06019C4B RID: 105547 RVA: 0x003B0789 File Offset: 0x003AE989
		// (set) Token: 0x06019C4C RID: 105548 RVA: 0x003B0791 File Offset: 0x003AE991
		public List<INodeRefOccupationDataT> LevelPlayOpenOccupations { get; set; }

		// Token: 0x17007A5E RID: 31326
		// (get) Token: 0x06019C4D RID: 105549 RVA: 0x003B079A File Offset: 0x003AE99A
		// (set) Token: 0x06019C4E RID: 105550 RVA: 0x003B07A2 File Offset: 0x003AE9A2
		public List<INodeRefOccupationsT> NodeOccupations { get; set; }

		// Token: 0x06019C4F RID: 105551 RVA: 0x003B07AB File Offset: 0x003AE9AB
		public ILevelPlayAllRefOccupationsT()
		{
			this.LevelPlayId = 0;
			this.LevelPlayOpenOccupations = null;
			this.NodeOccupations = null;
		}
	}
}
