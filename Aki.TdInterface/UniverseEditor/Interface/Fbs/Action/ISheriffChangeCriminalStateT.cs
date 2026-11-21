using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200788B RID: 30859
	public class ISheriffChangeCriminalStateT
	{
		// Token: 0x1700E24F RID: 57935
		// (get) Token: 0x0603649A RID: 222362 RVA: 0x00745490 File Offset: 0x00743690
		// (set) Token: 0x0603649B RID: 222363 RVA: 0x00745498 File Offset: 0x00743698
		public int CriminalId { get; set; }

		// Token: 0x1700E250 RID: 57936
		// (get) Token: 0x0603649C RID: 222364 RVA: 0x007454A1 File Offset: 0x007436A1
		// (set) Token: 0x0603649D RID: 222365 RVA: 0x007454A9 File Offset: 0x007436A9
		public ESheriffCriminalState CriminalState { get; set; }

		// Token: 0x0603649E RID: 222366 RVA: 0x007454B2 File Offset: 0x007436B2
		public ISheriffChangeCriminalStateT()
		{
			this.CriminalId = 0;
			this.CriminalState = ESheriffCriminalState.None;
		}
	}
}
