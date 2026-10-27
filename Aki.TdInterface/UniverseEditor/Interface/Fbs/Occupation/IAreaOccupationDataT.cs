using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004390 RID: 17296
	public class IAreaOccupationDataT
	{
		// Token: 0x17007A43 RID: 31299
		// (get) Token: 0x06019BC3 RID: 105411 RVA: 0x003AF6F2 File Offset: 0x003AD8F2
		// (set) Token: 0x06019BC4 RID: 105412 RVA: 0x003AF6FA File Offset: 0x003AD8FA
		public EOccupationType Type { get; set; }

		// Token: 0x17007A44 RID: 31300
		// (get) Token: 0x06019BC5 RID: 105413 RVA: 0x003AF703 File Offset: 0x003AD903
		// (set) Token: 0x06019BC6 RID: 105414 RVA: 0x003AF70B File Offset: 0x003AD90B
		public int LevelId { get; set; }

		// Token: 0x17007A45 RID: 31301
		// (get) Token: 0x06019BC7 RID: 105415 RVA: 0x003AF714 File Offset: 0x003AD914
		// (set) Token: 0x06019BC8 RID: 105416 RVA: 0x003AF71C File Offset: 0x003AD91C
		public int IdentifyEntityId { get; set; }

		// Token: 0x06019BC9 RID: 105417 RVA: 0x003AF725 File Offset: 0x003AD925
		public IAreaOccupationDataT()
		{
			this.Type = EOccupationType.Npc;
			this.LevelId = 0;
			this.IdentifyEntityId = 0;
		}
	}
}
