using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043CC RID: 17356
	public class ISilentAreaOccupationDataT
	{
		// Token: 0x17007ABD RID: 31421
		// (get) Token: 0x06019E38 RID: 106040 RVA: 0x003B475A File Offset: 0x003B295A
		// (set) Token: 0x06019E39 RID: 106041 RVA: 0x003B4762 File Offset: 0x003B2962
		public EOccupationType Type { get; set; }

		// Token: 0x17007ABE RID: 31422
		// (get) Token: 0x06019E3A RID: 106042 RVA: 0x003B476B File Offset: 0x003B296B
		// (set) Token: 0x06019E3B RID: 106043 RVA: 0x003B4773 File Offset: 0x003B2973
		public List<int> LevelPlayIds { get; set; }

		// Token: 0x17007ABF RID: 31423
		// (get) Token: 0x06019E3C RID: 106044 RVA: 0x003B477C File Offset: 0x003B297C
		// (set) Token: 0x06019E3D RID: 106045 RVA: 0x003B4784 File Offset: 0x003B2984
		public List<int> AssociatedEntities { get; set; }

		// Token: 0x06019E3E RID: 106046 RVA: 0x003B478D File Offset: 0x003B298D
		public ISilentAreaOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
			this.LevelPlayIds = null;
			this.AssociatedEntities = null;
		}
	}
}
