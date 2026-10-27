using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043B4 RID: 17332
	public class IOccupationExportConfigT
	{
		// Token: 0x17007A97 RID: 31383
		// (get) Token: 0x06019D5E RID: 105822 RVA: 0x003B2DEE File Offset: 0x003B0FEE
		// (set) Token: 0x06019D5F RID: 105823 RVA: 0x003B2DF6 File Offset: 0x003B0FF6
		public string Id { get; set; }

		// Token: 0x17007A98 RID: 31384
		// (get) Token: 0x06019D60 RID: 105824 RVA: 0x003B2DFF File Offset: 0x003B0FFF
		// (set) Token: 0x06019D61 RID: 105825 RVA: 0x003B2E07 File Offset: 0x003B1007
		public string NameStringKey { get; set; }

		// Token: 0x17007A99 RID: 31385
		// (get) Token: 0x06019D62 RID: 105826 RVA: 0x003B2E10 File Offset: 0x003B1010
		// (set) Token: 0x06019D63 RID: 105827 RVA: 0x003B2E18 File Offset: 0x003B1018
		public string Name { get; set; }

		// Token: 0x06019D64 RID: 105828 RVA: 0x003B2E21 File Offset: 0x003B1021
		public IOccupationExportConfigT()
		{
			this.Id = null;
			this.NameStringKey = null;
			this.Name = null;
		}
	}
}
