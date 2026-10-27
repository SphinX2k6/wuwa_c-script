using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043AE RID: 17326
	public class IOccupationConfigT
	{
		// Token: 0x17007A7B RID: 31355
		// (get) Token: 0x06019CDE RID: 105694 RVA: 0x003B1AC4 File Offset: 0x003AFCC4
		// (set) Token: 0x06019CDF RID: 105695 RVA: 0x003B1ACC File Offset: 0x003AFCCC
		public string Id { get; set; }

		// Token: 0x17007A7C RID: 31356
		// (get) Token: 0x06019CE0 RID: 105696 RVA: 0x003B1AD5 File Offset: 0x003AFCD5
		// (set) Token: 0x06019CE1 RID: 105697 RVA: 0x003B1ADD File Offset: 0x003AFCDD
		public EOccupationType OccupationType { get; set; }

		// Token: 0x17007A7D RID: 31357
		// (get) Token: 0x06019CE2 RID: 105698 RVA: 0x003B1AE6 File Offset: 0x003AFCE6
		// (set) Token: 0x06019CE3 RID: 105699 RVA: 0x003B1AEE File Offset: 0x003AFCEE
		public string NameStringKey { get; set; }

		// Token: 0x17007A7E RID: 31358
		// (get) Token: 0x06019CE4 RID: 105700 RVA: 0x003B1AF7 File Offset: 0x003AFCF7
		// (set) Token: 0x06019CE5 RID: 105701 RVA: 0x003B1AFF File Offset: 0x003AFCFF
		public string Name { get; set; }

		// Token: 0x17007A7F RID: 31359
		// (get) Token: 0x06019CE6 RID: 105702 RVA: 0x003B1B08 File Offset: 0x003AFD08
		// (set) Token: 0x06019CE7 RID: 105703 RVA: 0x003B1B10 File Offset: 0x003AFD10
		public TOccupationDataUnion OccupationData { get; set; }

		// Token: 0x06019CE8 RID: 105704 RVA: 0x003B1B19 File Offset: 0x003AFD19
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
