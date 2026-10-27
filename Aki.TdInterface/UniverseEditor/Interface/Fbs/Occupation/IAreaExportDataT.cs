using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200438D RID: 17293
	public class IAreaExportDataT
	{
		// Token: 0x17007A3B RID: 31291
		// (get) Token: 0x06019BA7 RID: 105383 RVA: 0x003AF42D File Offset: 0x003AD62D
		// (set) Token: 0x06019BA8 RID: 105384 RVA: 0x003AF435 File Offset: 0x003AD635
		public string Id { get; set; }

		// Token: 0x17007A3C RID: 31292
		// (get) Token: 0x06019BA9 RID: 105385 RVA: 0x003AF43E File Offset: 0x003AD63E
		// (set) Token: 0x06019BAA RID: 105386 RVA: 0x003AF446 File Offset: 0x003AD646
		public string NameStringKey { get; set; }

		// Token: 0x17007A3D RID: 31293
		// (get) Token: 0x06019BAB RID: 105387 RVA: 0x003AF44F File Offset: 0x003AD64F
		// (set) Token: 0x06019BAC RID: 105388 RVA: 0x003AF457 File Offset: 0x003AD657
		public string Name { get; set; }

		// Token: 0x17007A3E RID: 31294
		// (get) Token: 0x06019BAD RID: 105389 RVA: 0x003AF460 File Offset: 0x003AD660
		// (set) Token: 0x06019BAE RID: 105390 RVA: 0x003AF468 File Offset: 0x003AD668
		public IAreaOccupationDataT Data { get; set; }

		// Token: 0x06019BAF RID: 105391 RVA: 0x003AF471 File Offset: 0x003AD671
		public IAreaExportDataT()
		{
			this.Id = null;
			this.NameStringKey = null;
			this.Name = null;
			this.Data = null;
		}
	}
}
