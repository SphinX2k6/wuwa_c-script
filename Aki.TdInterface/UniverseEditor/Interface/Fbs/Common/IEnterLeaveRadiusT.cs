using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DA4 RID: 23972
	public class IEnterLeaveRadiusT
	{
		// Token: 0x1700B38B RID: 45963
		// (get) Token: 0x0602907E RID: 168062 RVA: 0x005A2660 File Offset: 0x005A0860
		// (set) Token: 0x0602907F RID: 168063 RVA: 0x005A2668 File Offset: 0x005A0868
		public int EnterRadius { get; set; }

		// Token: 0x1700B38C RID: 45964
		// (get) Token: 0x06029080 RID: 168064 RVA: 0x005A2671 File Offset: 0x005A0871
		// (set) Token: 0x06029081 RID: 168065 RVA: 0x005A2679 File Offset: 0x005A0879
		public int LeaveRadius { get; set; }

		// Token: 0x06029082 RID: 168066 RVA: 0x005A2682 File Offset: 0x005A0882
		public IEnterLeaveRadiusT()
		{
			this.EnterRadius = 0;
			this.LeaveRadius = 0;
		}
	}
}
