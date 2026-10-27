using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043CF RID: 17359
	public class ITimeOccupationDataT
	{
		// Token: 0x17007AC2 RID: 31426
		// (get) Token: 0x06019E4E RID: 106062 RVA: 0x003B491A File Offset: 0x003B2B1A
		// (set) Token: 0x06019E4F RID: 106063 RVA: 0x003B4922 File Offset: 0x003B2B22
		public EOccupationType Type { get; set; }

		// Token: 0x06019E50 RID: 106064 RVA: 0x003B492B File Offset: 0x003B2B2B
		public ITimeOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
