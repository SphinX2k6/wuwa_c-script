using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B2E RID: 31534
	public class ITalkOptionVisualNovelT
	{
		// Token: 0x1700EC37 RID: 60471
		// (get) Token: 0x06038CA7 RID: 232615 RVA: 0x007AE5E1 File Offset: 0x007AC7E1
		// (set) Token: 0x06038CA8 RID: 232616 RVA: 0x007AE5E9 File Offset: 0x007AC7E9
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x1700EC38 RID: 60472
		// (get) Token: 0x06038CA9 RID: 232617 RVA: 0x007AE5F2 File Offset: 0x007AC7F2
		// (set) Token: 0x06038CAA RID: 232618 RVA: 0x007AE5FA File Offset: 0x007AC7FA
		public int PlotOptionId { get; set; }

		// Token: 0x1700EC39 RID: 60473
		// (get) Token: 0x06038CAB RID: 232619 RVA: 0x007AE603 File Offset: 0x007AC803
		// (set) Token: 0x06038CAC RID: 232620 RVA: 0x007AE60B File Offset: 0x007AC80B
		public List<TVisualNovelPerformanceUnion> OptionPerformances { get; set; }

		// Token: 0x1700EC3A RID: 60474
		// (get) Token: 0x06038CAD RID: 232621 RVA: 0x007AE614 File Offset: 0x007AC814
		// (set) Token: 0x06038CAE RID: 232622 RVA: 0x007AE61C File Offset: 0x007AC81C
		public ITalkOptionVisualNovelDoubleConfirmT DoubleConfirm { get; set; }

		// Token: 0x1700EC3B RID: 60475
		// (get) Token: 0x06038CAF RID: 232623 RVA: 0x007AE625 File Offset: 0x007AC825
		// (set) Token: 0x06038CB0 RID: 232624 RVA: 0x007AE62D File Offset: 0x007AC82D
		public byte NullMask { get; set; }

		// Token: 0x06038CB1 RID: 232625 RVA: 0x007AE636 File Offset: 0x007AC836
		public ITalkOptionVisualNovelT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
			this.PlotOptionId = 0;
			this.OptionPerformances = null;
			this.DoubleConfirm = null;
			this.NullMask = 0;
		}
	}
}
