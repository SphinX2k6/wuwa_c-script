using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200403E RID: 16446
	public class IQuestScheduleTimeLeftT
	{
		// Token: 0x170073C4 RID: 29636
		// (get) Token: 0x06017CF6 RID: 97526 RVA: 0x0036F884 File Offset: 0x0036DA84
		// (set) Token: 0x06017CF7 RID: 97527 RVA: 0x0036F88C File Offset: 0x0036DA8C
		public EQuestScheduleType Type { get; set; }

		// Token: 0x170073C5 RID: 29637
		// (get) Token: 0x06017CF8 RID: 97528 RVA: 0x0036F895 File Offset: 0x0036DA95
		// (set) Token: 0x06017CF9 RID: 97529 RVA: 0x0036F89D File Offset: 0x0036DA9D
		public ETimerType TimerType { get; set; }

		// Token: 0x170073C6 RID: 29638
		// (get) Token: 0x06017CFA RID: 97530 RVA: 0x0036F8A6 File Offset: 0x0036DAA6
		// (set) Token: 0x06017CFB RID: 97531 RVA: 0x0036F8AE File Offset: 0x0036DAAE
		public int TimeLeft { get; set; }

		// Token: 0x170073C7 RID: 29639
		// (get) Token: 0x06017CFC RID: 97532 RVA: 0x0036F8B7 File Offset: 0x0036DAB7
		// (set) Token: 0x06017CFD RID: 97533 RVA: 0x0036F8BF File Offset: 0x0036DABF
		public ETimeLeftIconType IconType { get; set; }

		// Token: 0x170073C8 RID: 29640
		// (get) Token: 0x06017CFE RID: 97534 RVA: 0x0036F8C8 File Offset: 0x0036DAC8
		// (set) Token: 0x06017CFF RID: 97535 RVA: 0x0036F8D0 File Offset: 0x0036DAD0
		public bool ShowTime { get; set; }

		// Token: 0x170073C9 RID: 29641
		// (get) Token: 0x06017D00 RID: 97536 RVA: 0x0036F8D9 File Offset: 0x0036DAD9
		// (set) Token: 0x06017D01 RID: 97537 RVA: 0x0036F8E1 File Offset: 0x0036DAE1
		public byte NullMask { get; set; }

		// Token: 0x06017D02 RID: 97538 RVA: 0x0036F8EA File Offset: 0x0036DAEA
		public IQuestScheduleTimeLeftT()
		{
			this.Type = EQuestScheduleType.None;
			this.TimerType = ETimerType.CountDownChallenge;
			this.TimeLeft = 0;
			this.IconType = ETimeLeftIconType.AkiWorld;
			this.ShowTime = false;
			this.NullMask = 0;
		}
	}
}
