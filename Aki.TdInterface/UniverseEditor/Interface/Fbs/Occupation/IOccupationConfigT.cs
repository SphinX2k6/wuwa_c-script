using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004810 RID: 18448
	public class IOccupationConfigT
	{
		// Token: 0x170080B0 RID: 32944
		// (get) Token: 0x0601B46D RID: 111725 RVA: 0x003DD544 File Offset: 0x003DB744
		// (set) Token: 0x0601B46E RID: 111726 RVA: 0x003DD54C File Offset: 0x003DB74C
		public string Id { get; set; }

		// Token: 0x170080B1 RID: 32945
		// (get) Token: 0x0601B46F RID: 111727 RVA: 0x003DD555 File Offset: 0x003DB755
		// (set) Token: 0x0601B470 RID: 111728 RVA: 0x003DD55D File Offset: 0x003DB75D
		public EOccupationType OccupationType { get; set; }

		// Token: 0x170080B2 RID: 32946
		// (get) Token: 0x0601B471 RID: 111729 RVA: 0x003DD566 File Offset: 0x003DB766
		// (set) Token: 0x0601B472 RID: 111730 RVA: 0x003DD56E File Offset: 0x003DB76E
		public string NameStringKey { get; set; }

		// Token: 0x170080B3 RID: 32947
		// (get) Token: 0x0601B473 RID: 111731 RVA: 0x003DD577 File Offset: 0x003DB777
		// (set) Token: 0x0601B474 RID: 111732 RVA: 0x003DD57F File Offset: 0x003DB77F
		public string Name { get; set; }

		// Token: 0x170080B4 RID: 32948
		// (get) Token: 0x0601B475 RID: 111733 RVA: 0x003DD588 File Offset: 0x003DB788
		// (set) Token: 0x0601B476 RID: 111734 RVA: 0x003DD590 File Offset: 0x003DB790
		public TOccupationDataUnion OccupationData { get; set; }

		// Token: 0x0601B477 RID: 111735 RVA: 0x003DD599 File Offset: 0x003DB799
		public IOccupationConfigT()
		{
			this.Id = null;
			this.OccupationType = EOccupationType.Npc;
			this.NameStringKey = null;
			this.Name = null;
			this.OccupationData = null;
		}
	}
}
