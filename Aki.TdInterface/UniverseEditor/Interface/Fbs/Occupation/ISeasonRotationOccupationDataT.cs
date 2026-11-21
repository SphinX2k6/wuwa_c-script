using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200482B RID: 18475
	public class ISeasonRotationOccupationDataT
	{
		// Token: 0x170080E9 RID: 33001
		// (get) Token: 0x0601B59B RID: 112027 RVA: 0x003DFC9A File Offset: 0x003DDE9A
		// (set) Token: 0x0601B59C RID: 112028 RVA: 0x003DFCA2 File Offset: 0x003DDEA2
		public EOccupationType Type { get; set; }

		// Token: 0x0601B59D RID: 112029 RVA: 0x003DFCAB File Offset: 0x003DDEAB
		public ISeasonRotationOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
