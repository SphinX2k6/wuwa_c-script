using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200741C RID: 29724
	public class IToggleTimerPauseStateT
	{
		// Token: 0x1700E1B3 RID: 57779
		// (get) Token: 0x06035FED RID: 221165 RVA: 0x0075879C File Offset: 0x0075699C
		// (set) Token: 0x06035FEE RID: 221166 RVA: 0x007587A4 File Offset: 0x007569A4
		public ETimerType TimerType { get; set; }

		// Token: 0x1700E1B4 RID: 57780
		// (get) Token: 0x06035FEF RID: 221167 RVA: 0x007587AD File Offset: 0x007569AD
		// (set) Token: 0x06035FF0 RID: 221168 RVA: 0x007587B5 File Offset: 0x007569B5
		public bool IsPause { get; set; }

		// Token: 0x06035FF1 RID: 221169 RVA: 0x007587BE File Offset: 0x007569BE
		public IToggleTimerPauseStateT()
		{
			this.TimerType = ETimerType.CountDownChallenge;
			this.IsPause = false;
		}
	}
}
