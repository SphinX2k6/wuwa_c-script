using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050A0 RID: 20640
	public class IDollGrabItemT
	{
		// Token: 0x170095EF RID: 38383
		// (get) Token: 0x0602124B RID: 135755 RVA: 0x0049AED4 File Offset: 0x004990D4
		// (set) Token: 0x0602124C RID: 135756 RVA: 0x0049AEDC File Offset: 0x004990DC
		public int Id { get; set; }

		// Token: 0x170095F0 RID: 38384
		// (get) Token: 0x0602124D RID: 135757 RVA: 0x0049AEE5 File Offset: 0x004990E5
		// (set) Token: 0x0602124E RID: 135758 RVA: 0x0049AEED File Offset: 0x004990ED
		public int ItemId { get; set; }

		// Token: 0x0602124F RID: 135759 RVA: 0x0049AEF6 File Offset: 0x004990F6
		public IDollGrabItemT()
		{
			this.Id = 0;
			this.ItemId = 0;
		}
	}
}
