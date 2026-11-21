using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004831 RID: 18481
	public class ISilentAreaOccupationDataT
	{
		// Token: 0x170080F7 RID: 33015
		// (get) Token: 0x0601B5E5 RID: 112101 RVA: 0x003E056A File Offset: 0x003DE76A
		// (set) Token: 0x0601B5E6 RID: 112102 RVA: 0x003E0572 File Offset: 0x003DE772
		public EOccupationType Type { get; set; }

		// Token: 0x170080F8 RID: 33016
		// (get) Token: 0x0601B5E7 RID: 112103 RVA: 0x003E057B File Offset: 0x003DE77B
		// (set) Token: 0x0601B5E8 RID: 112104 RVA: 0x003E0583 File Offset: 0x003DE783
		public List<int> LevelPlayIds { get; set; }

		// Token: 0x170080F9 RID: 33017
		// (get) Token: 0x0601B5E9 RID: 112105 RVA: 0x003E058C File Offset: 0x003DE78C
		// (set) Token: 0x0601B5EA RID: 112106 RVA: 0x003E0594 File Offset: 0x003DE794
		public List<int> AssociatedEntities { get; set; }

		// Token: 0x0601B5EB RID: 112107 RVA: 0x003E059D File Offset: 0x003DE79D
		public ISilentAreaOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
			this.LevelPlayIds = null;
			this.AssociatedEntities = null;
		}
	}
}
