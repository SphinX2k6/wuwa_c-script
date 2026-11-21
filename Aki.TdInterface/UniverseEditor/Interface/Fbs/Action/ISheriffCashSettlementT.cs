using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007885 RID: 30853
	public class ISheriffCashSettlementT
	{
		// Token: 0x1700E243 RID: 57923
		// (get) Token: 0x0603646A RID: 222314 RVA: 0x00745014 File Offset: 0x00743214
		// (set) Token: 0x0603646B RID: 222315 RVA: 0x0074501C File Offset: 0x0074321C
		public ECommonTipType Type { get; set; }

		// Token: 0x1700E244 RID: 57924
		// (get) Token: 0x0603646C RID: 222316 RVA: 0x00745025 File Offset: 0x00743225
		// (set) Token: 0x0603646D RID: 222317 RVA: 0x0074502D File Offset: 0x0074322D
		public string TidMainText { get; set; }

		// Token: 0x1700E245 RID: 57925
		// (get) Token: 0x0603646E RID: 222318 RVA: 0x00745036 File Offset: 0x00743236
		// (set) Token: 0x0603646F RID: 222319 RVA: 0x0074503E File Offset: 0x0074323E
		public string TidSubText { get; set; }

		// Token: 0x1700E246 RID: 57926
		// (get) Token: 0x06036470 RID: 222320 RVA: 0x00745047 File Offset: 0x00743247
		// (set) Token: 0x06036471 RID: 222321 RVA: 0x0074504F File Offset: 0x0074324F
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x06036472 RID: 222322 RVA: 0x00745058 File Offset: 0x00743258
		public ISheriffCashSettlementT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
			this.VarRef = null;
		}
	}
}
