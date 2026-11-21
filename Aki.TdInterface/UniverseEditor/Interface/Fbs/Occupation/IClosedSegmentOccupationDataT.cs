using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047F8 RID: 18424
	public class IClosedSegmentOccupationDataT
	{
		// Token: 0x17008082 RID: 32898
		// (get) Token: 0x0601B37D RID: 111485 RVA: 0x003DB4EA File Offset: 0x003D96EA
		// (set) Token: 0x0601B37E RID: 111486 RVA: 0x003DB4F2 File Offset: 0x003D96F2
		public EOccupationType Type { get; set; }

		// Token: 0x0601B37F RID: 111487 RVA: 0x003DB4FB File Offset: 0x003D96FB
		public IClosedSegmentOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
