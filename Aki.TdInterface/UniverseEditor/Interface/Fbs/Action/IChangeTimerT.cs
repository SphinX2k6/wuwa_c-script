using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200632D RID: 25389
	public class IChangeTimerT
	{
		// Token: 0x1700BD84 RID: 48516
		// (get) Token: 0x0602BEBA RID: 179898 RVA: 0x00609A5F File Offset: 0x00607C5F
		// (set) Token: 0x0602BEBB RID: 179899 RVA: 0x00609A67 File Offset: 0x00607C67
		public ETimerType TimerType { get; set; }

		// Token: 0x1700BD85 RID: 48517
		// (get) Token: 0x0602BEBC RID: 179900 RVA: 0x00609A70 File Offset: 0x00607C70
		// (set) Token: 0x0602BEBD RID: 179901 RVA: 0x00609A78 File Offset: 0x00607C78
		public TChangeTimerUnion ChangeType { get; set; }

		// Token: 0x0602BEBE RID: 179902 RVA: 0x00609A81 File Offset: 0x00607C81
		public IChangeTimerT()
		{
			this.TimerType = ETimerType.CountDownChallenge;
			this.ChangeType = null;
		}
	}
}
