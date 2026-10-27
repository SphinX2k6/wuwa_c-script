using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004396 RID: 17302
	public class IClosedSegmentOccupationDataT
	{
		// Token: 0x17007A4D RID: 31309
		// (get) Token: 0x06019BEF RID: 105455 RVA: 0x003AFAC2 File Offset: 0x003ADCC2
		// (set) Token: 0x06019BF0 RID: 105456 RVA: 0x003AFACA File Offset: 0x003ADCCA
		public EOccupationType Type { get; set; }

		// Token: 0x06019BF1 RID: 105457 RVA: 0x003AFAD3 File Offset: 0x003ADCD3
		public IClosedSegmentOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
		}
	}
}
