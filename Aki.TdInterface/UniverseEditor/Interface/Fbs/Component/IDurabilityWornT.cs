using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050CD RID: 20685
	public class IDurabilityWornT
	{
		// Token: 0x17009689 RID: 38537
		// (get) Token: 0x0602146F RID: 136303 RVA: 0x0049F4EA File Offset: 0x0049D6EA
		// (set) Token: 0x06021470 RID: 136304 RVA: 0x0049F4F2 File Offset: 0x0049D6F2
		public int SlightWear { get; set; }

		// Token: 0x1700968A RID: 38538
		// (get) Token: 0x06021471 RID: 136305 RVA: 0x0049F4FB File Offset: 0x0049D6FB
		// (set) Token: 0x06021472 RID: 136306 RVA: 0x0049F503 File Offset: 0x0049D703
		public int SevereWear { get; set; }

		// Token: 0x1700968B RID: 38539
		// (get) Token: 0x06021473 RID: 136307 RVA: 0x0049F50C File Offset: 0x0049D70C
		// (set) Token: 0x06021474 RID: 136308 RVA: 0x0049F514 File Offset: 0x0049D714
		public byte NullMask { get; set; }

		// Token: 0x06021475 RID: 136309 RVA: 0x0049F51D File Offset: 0x0049D71D
		public IDurabilityWornT()
		{
			this.SlightWear = 0;
			this.SevereWear = 0;
			this.NullMask = 0;
		}
	}
}
