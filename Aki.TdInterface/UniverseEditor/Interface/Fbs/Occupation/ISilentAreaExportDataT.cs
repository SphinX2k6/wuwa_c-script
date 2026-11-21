using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200482E RID: 18478
	public class ISilentAreaExportDataT
	{
		// Token: 0x170080EF RID: 33007
		// (get) Token: 0x0601B5B9 RID: 112057 RVA: 0x003E004D File Offset: 0x003DE24D
		// (set) Token: 0x0601B5BA RID: 112058 RVA: 0x003E0055 File Offset: 0x003DE255
		public string Id { get; set; }

		// Token: 0x170080F0 RID: 33008
		// (get) Token: 0x0601B5BB RID: 112059 RVA: 0x003E005E File Offset: 0x003DE25E
		// (set) Token: 0x0601B5BC RID: 112060 RVA: 0x003E0066 File Offset: 0x003DE266
		public string NameStringKey { get; set; }

		// Token: 0x170080F1 RID: 33009
		// (get) Token: 0x0601B5BD RID: 112061 RVA: 0x003E006F File Offset: 0x003DE26F
		// (set) Token: 0x0601B5BE RID: 112062 RVA: 0x003E0077 File Offset: 0x003DE277
		public string Name { get; set; }

		// Token: 0x170080F2 RID: 33010
		// (get) Token: 0x0601B5BF RID: 112063 RVA: 0x003E0080 File Offset: 0x003DE280
		// (set) Token: 0x0601B5C0 RID: 112064 RVA: 0x003E0088 File Offset: 0x003DE288
		public ISilentAreaOccupationDataT Data { get; set; }

		// Token: 0x0601B5C1 RID: 112065 RVA: 0x003E0091 File Offset: 0x003DE291
		public ISilentAreaExportDataT()
		{
			this.Id = null;
			this.NameStringKey = null;
			this.Name = null;
			this.Data = null;
		}
	}
}
