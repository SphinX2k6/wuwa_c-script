using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005265 RID: 21093
	public class IFixedAngleItemT
	{
		// Token: 0x17009A7C RID: 39548
		// (get) Token: 0x06022507 RID: 140551 RVA: 0x004C1CF2 File Offset: 0x004BFEF2
		// (set) Token: 0x06022508 RID: 140552 RVA: 0x004C1CFA File Offset: 0x004BFEFA
		public int InitAngle { get; set; }

		// Token: 0x17009A7D RID: 39549
		// (get) Token: 0x06022509 RID: 140553 RVA: 0x004C1D03 File Offset: 0x004BFF03
		// (set) Token: 0x0602250A RID: 140554 RVA: 0x004C1D0B File Offset: 0x004BFF0B
		public int TargetAngle { get; set; }

		// Token: 0x17009A7E RID: 39550
		// (get) Token: 0x0602250B RID: 140555 RVA: 0x004C1D14 File Offset: 0x004BFF14
		// (set) Token: 0x0602250C RID: 140556 RVA: 0x004C1D1C File Offset: 0x004BFF1C
		public int RotateAngle { get; set; }

		// Token: 0x0602250D RID: 140557 RVA: 0x004C1D25 File Offset: 0x004BFF25
		public IFixedAngleItemT()
		{
			this.InitAngle = 0;
			this.TargetAngle = 0;
			this.RotateAngle = 0;
		}
	}
}
