using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E69 RID: 24169
	public class IRenjuStrategyT
	{
		// Token: 0x1700B243 RID: 45635
		// (get) Token: 0x060286B7 RID: 165559 RVA: 0x00586CCD File Offset: 0x00584ECD
		// (set) Token: 0x060286B8 RID: 165560 RVA: 0x00586CD5 File Offset: 0x00584ED5
		public EAiGearStrategy Type { get; set; }

		// Token: 0x1700B244 RID: 45636
		// (get) Token: 0x060286B9 RID: 165561 RVA: 0x00586CDE File Offset: 0x00584EDE
		// (set) Token: 0x060286BA RID: 165562 RVA: 0x00586CE6 File Offset: 0x00584EE6
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B245 RID: 45637
		// (get) Token: 0x060286BB RID: 165563 RVA: 0x00586CEF File Offset: 0x00584EEF
		// (set) Token: 0x060286BC RID: 165564 RVA: 0x00586CF7 File Offset: 0x00584EF7
		public int Chessboard { get; set; }

		// Token: 0x1700B246 RID: 45638
		// (get) Token: 0x060286BD RID: 165565 RVA: 0x00586D00 File Offset: 0x00584F00
		// (set) Token: 0x060286BE RID: 165566 RVA: 0x00586D08 File Offset: 0x00584F08
		public string CommonConfig { get; set; }

		// Token: 0x1700B247 RID: 45639
		// (get) Token: 0x060286BF RID: 165567 RVA: 0x00586D11 File Offset: 0x00584F11
		// (set) Token: 0x060286C0 RID: 165568 RVA: 0x00586D19 File Offset: 0x00584F19
		public byte NullMask { get; set; }

		// Token: 0x060286C1 RID: 165569 RVA: 0x00586D22 File Offset: 0x00584F22
		public IRenjuStrategyT()
		{
			this.Type = EAiGearStrategy.RenjuStrategy;
			this.Condition = null;
			this.Chessboard = 0;
			this.CommonConfig = null;
			this.NullMask = 0;
		}
	}
}
