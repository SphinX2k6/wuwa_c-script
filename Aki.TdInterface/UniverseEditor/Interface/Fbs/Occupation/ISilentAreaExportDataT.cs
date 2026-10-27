using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043C9 RID: 17353
	public class ISilentAreaExportDataT
	{
		// Token: 0x17007AB5 RID: 31413
		// (get) Token: 0x06019E0C RID: 105996 RVA: 0x003B423D File Offset: 0x003B243D
		// (set) Token: 0x06019E0D RID: 105997 RVA: 0x003B4245 File Offset: 0x003B2445
		public string Id { get; set; }

		// Token: 0x17007AB6 RID: 31414
		// (get) Token: 0x06019E0E RID: 105998 RVA: 0x003B424E File Offset: 0x003B244E
		// (set) Token: 0x06019E0F RID: 105999 RVA: 0x003B4256 File Offset: 0x003B2456
		public string NameStringKey { get; set; }

		// Token: 0x17007AB7 RID: 31415
		// (get) Token: 0x06019E10 RID: 106000 RVA: 0x003B425F File Offset: 0x003B245F
		// (set) Token: 0x06019E11 RID: 106001 RVA: 0x003B4267 File Offset: 0x003B2467
		public string Name { get; set; }

		// Token: 0x17007AB8 RID: 31416
		// (get) Token: 0x06019E12 RID: 106002 RVA: 0x003B4270 File Offset: 0x003B2470
		// (set) Token: 0x06019E13 RID: 106003 RVA: 0x003B4278 File Offset: 0x003B2478
		public ISilentAreaOccupationDataT Data { get; set; }

		// Token: 0x06019E14 RID: 106004 RVA: 0x003B4281 File Offset: 0x003B2481
		public ISilentAreaExportDataT()
		{
			this.Id = null;
			this.NameStringKey = null;
			this.Name = null;
			this.Data = null;
		}
	}
}
