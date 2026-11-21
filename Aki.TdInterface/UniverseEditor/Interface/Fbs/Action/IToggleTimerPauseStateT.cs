using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C0F RID: 31759
	public class IToggleTimerPauseStateT
	{
		// Token: 0x1700EDD0 RID: 60880
		// (get) Token: 0x060393D6 RID: 234454 RVA: 0x007BB4C8 File Offset: 0x007B96C8
		// (set) Token: 0x060393D7 RID: 234455 RVA: 0x007BB4D0 File Offset: 0x007B96D0
		public ETimerType TimerType { get; set; }

		// Token: 0x1700EDD1 RID: 60881
		// (get) Token: 0x060393D8 RID: 234456 RVA: 0x007BB4D9 File Offset: 0x007B96D9
		// (set) Token: 0x060393D9 RID: 234457 RVA: 0x007BB4E1 File Offset: 0x007B96E1
		public bool IsPause { get; set; }

		// Token: 0x060393DA RID: 234458 RVA: 0x007BB4EA File Offset: 0x007B96EA
		public IToggleTimerPauseStateT()
		{
			this.TimerType = ETimerType.CountDownChallenge;
			this.IsPause = false;
		}
	}
}
