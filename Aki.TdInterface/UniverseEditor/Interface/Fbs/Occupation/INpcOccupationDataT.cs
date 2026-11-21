using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200480D RID: 18445
	public class INpcOccupationDataT
	{
		// Token: 0x170080A9 RID: 32937
		// (get) Token: 0x0601B444 RID: 111684 RVA: 0x003DCE82 File Offset: 0x003DB082
		// (set) Token: 0x0601B445 RID: 111685 RVA: 0x003DCE8A File Offset: 0x003DB08A
		public EOccupationType Type { get; set; }

		// Token: 0x0601B446 RID: 111686 RVA: 0x003DCE93 File Offset: 0x003DB093
		public INpcOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
