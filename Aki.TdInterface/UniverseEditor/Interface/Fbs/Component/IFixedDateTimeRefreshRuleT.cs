using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D6 RID: 22486
	public class IFixedDateTimeRefreshRuleT
	{
		// Token: 0x1700A291 RID: 41617
		// (get) Token: 0x060244F9 RID: 148729 RVA: 0x004FD319 File Offset: 0x004FB519
		// (set) Token: 0x060244FA RID: 148730 RVA: 0x004FD321 File Offset: 0x004FB521
		public ERefreshRule Type { get; set; }

		// Token: 0x1700A292 RID: 41618
		// (get) Token: 0x060244FB RID: 148731 RVA: 0x004FD32A File Offset: 0x004FB52A
		// (set) Token: 0x060244FC RID: 148732 RVA: 0x004FD332 File Offset: 0x004FB532
		public int Hours { get; set; }

		// Token: 0x1700A293 RID: 41619
		// (get) Token: 0x060244FD RID: 148733 RVA: 0x004FD33B File Offset: 0x004FB53B
		// (set) Token: 0x060244FE RID: 148734 RVA: 0x004FD343 File Offset: 0x004FB543
		public int Minutes { get; set; }

		// Token: 0x1700A294 RID: 41620
		// (get) Token: 0x060244FF RID: 148735 RVA: 0x004FD34C File Offset: 0x004FB54C
		// (set) Token: 0x06024500 RID: 148736 RVA: 0x004FD354 File Offset: 0x004FB554
		public int Seconds { get; set; }

		// Token: 0x1700A295 RID: 41621
		// (get) Token: 0x06024501 RID: 148737 RVA: 0x004FD35D File Offset: 0x004FB55D
		// (set) Token: 0x06024502 RID: 148738 RVA: 0x004FD365 File Offset: 0x004FB565
		public int RefreshRate { get; set; }

		// Token: 0x1700A296 RID: 41622
		// (get) Token: 0x06024503 RID: 148739 RVA: 0x004FD36E File Offset: 0x004FB56E
		// (set) Token: 0x06024504 RID: 148740 RVA: 0x004FD376 File Offset: 0x004FB576
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A297 RID: 41623
		// (get) Token: 0x06024505 RID: 148741 RVA: 0x004FD37F File Offset: 0x004FB57F
		// (set) Token: 0x06024506 RID: 148742 RVA: 0x004FD387 File Offset: 0x004FB587
		public byte NullMask { get; set; }

		// Token: 0x06024507 RID: 148743 RVA: 0x004FD390 File Offset: 0x004FB590
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
