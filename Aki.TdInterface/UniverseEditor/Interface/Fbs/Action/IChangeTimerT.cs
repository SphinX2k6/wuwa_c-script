using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699E RID: 27038
	public class IChangeTimerT
	{
		// Token: 0x1700C70C RID: 50956
		// (get) Token: 0x0602E624 RID: 189988 RVA: 0x00654BB3 File Offset: 0x00652DB3
		// (set) Token: 0x0602E625 RID: 189989 RVA: 0x00654BBB File Offset: 0x00652DBB
		public ETimerType TimerType { get; set; }

		// Token: 0x1700C70D RID: 50957
		// (get) Token: 0x0602E626 RID: 189990 RVA: 0x00654BC4 File Offset: 0x00652DC4
		// (set) Token: 0x0602E627 RID: 189991 RVA: 0x00654BCC File Offset: 0x00652DCC
		public TChangeTimerUnion ChangeType { get; set; }

		// Token: 0x0602E628 RID: 189992 RVA: 0x00654BD5 File Offset: 0x00652DD5
		public IChangeTimerT()
		{
			this.TimerType = ETimerType.CountDownChallenge;
			this.ChangeType = null;
		}
	}
}
