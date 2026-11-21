using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004834 RID: 18484
	public class ITimeOccupationDataT
	{
		// Token: 0x170080FC RID: 33020
		// (get) Token: 0x0601B5FB RID: 112123 RVA: 0x003E072A File Offset: 0x003DE92A
		// (set) Token: 0x0601B5FC RID: 112124 RVA: 0x003E0732 File Offset: 0x003DE932
		public EOccupationType Type { get; set; }

		// Token: 0x0601B5FD RID: 112125 RVA: 0x003E073B File Offset: 0x003DE93B
		public ITimeOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
