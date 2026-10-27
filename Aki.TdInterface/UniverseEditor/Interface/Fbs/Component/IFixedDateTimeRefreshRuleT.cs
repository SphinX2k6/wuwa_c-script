using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200526E RID: 21102
	public class IFixedDateTimeRefreshRuleT
	{
		// Token: 0x17009A95 RID: 39573
		// (get) Token: 0x06022563 RID: 140643 RVA: 0x004C2855 File Offset: 0x004C0A55
		// (set) Token: 0x06022564 RID: 140644 RVA: 0x004C285D File Offset: 0x004C0A5D
		public ERefreshRule Type { get; set; }

		// Token: 0x17009A96 RID: 39574
		// (get) Token: 0x06022565 RID: 140645 RVA: 0x004C2866 File Offset: 0x004C0A66
		// (set) Token: 0x06022566 RID: 140646 RVA: 0x004C286E File Offset: 0x004C0A6E
		public int Hours { get; set; }

		// Token: 0x17009A97 RID: 39575
		// (get) Token: 0x06022567 RID: 140647 RVA: 0x004C2877 File Offset: 0x004C0A77
		// (set) Token: 0x06022568 RID: 140648 RVA: 0x004C287F File Offset: 0x004C0A7F
		public int Minutes { get; set; }

		// Token: 0x17009A98 RID: 39576
		// (get) Token: 0x06022569 RID: 140649 RVA: 0x004C2888 File Offset: 0x004C0A88
		// (set) Token: 0x0602256A RID: 140650 RVA: 0x004C2890 File Offset: 0x004C0A90
		public int Seconds { get; set; }

		// Token: 0x17009A99 RID: 39577
		// (get) Token: 0x0602256B RID: 140651 RVA: 0x004C2899 File Offset: 0x004C0A99
		// (set) Token: 0x0602256C RID: 140652 RVA: 0x004C28A1 File Offset: 0x004C0AA1
		public int RefreshRate { get; set; }

		// Token: 0x17009A9A RID: 39578
		// (get) Token: 0x0602256D RID: 140653 RVA: 0x004C28AA File Offset: 0x004C0AAA
		// (set) Token: 0x0602256E RID: 140654 RVA: 0x004C28B2 File Offset: 0x004C0AB2
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009A9B RID: 39579
		// (get) Token: 0x0602256F RID: 140655 RVA: 0x004C28BB File Offset: 0x004C0ABB
		// (set) Token: 0x06022570 RID: 140656 RVA: 0x004C28C3 File Offset: 0x004C0AC3
		public byte NullMask { get; set; }

		// Token: 0x06022571 RID: 140657 RVA: 0x004C28CC File Offset: 0x004C0ACC
		public IFixedDateTimeRefreshRuleT()
		{
			this.Type = ERefreshRule.CD;
			this.Hours = 0;
			this.Minutes = 0;
			this.Seconds = 0;
			this.RefreshRate = 0;
			this.Condition = null;
			this.NullMask = 0;
		}
	}
}
