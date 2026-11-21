using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050FE RID: 20734
	public class IEllipseConeRangeT
	{
		// Token: 0x17009494 RID: 38036
		// (get) Token: 0x0602095D RID: 133469 RVA: 0x00484D74 File Offset: 0x00482F74
		// (set) Token: 0x0602095E RID: 133470 RVA: 0x00484D7C File Offset: 0x00482F7C
		public float HorizontalAngle { get; set; }

		// Token: 0x17009495 RID: 38037
		// (get) Token: 0x0602095F RID: 133471 RVA: 0x00484D85 File Offset: 0x00482F85
		// (set) Token: 0x06020960 RID: 133472 RVA: 0x00484D8D File Offset: 0x00482F8D
		public float VerticalAngle { get; set; }

		// Token: 0x06020961 RID: 133473 RVA: 0x00484D96 File Offset: 0x00482F96
		public IEllipseConeRangeT()
		{
			this.HorizontalAngle = 0f;
			this.VerticalAngle = 0f;
		}
	}
}
