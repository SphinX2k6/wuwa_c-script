using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200447F RID: 17535
	public class IQuestScheduleTimeLeftT
	{
		// Token: 0x170079C6 RID: 31174
		// (get) Token: 0x0601938F RID: 103311 RVA: 0x00399678 File Offset: 0x00397878
		// (set) Token: 0x06019390 RID: 103312 RVA: 0x00399680 File Offset: 0x00397880
		public EQuestScheduleType Type { get; set; }

		// Token: 0x170079C7 RID: 31175
		// (get) Token: 0x06019391 RID: 103313 RVA: 0x00399689 File Offset: 0x00397889
		// (set) Token: 0x06019392 RID: 103314 RVA: 0x00399691 File Offset: 0x00397891
		public ETimerType TimerType { get; set; }

		// Token: 0x170079C8 RID: 31176
		// (get) Token: 0x06019393 RID: 103315 RVA: 0x0039969A File Offset: 0x0039789A
		// (set) Token: 0x06019394 RID: 103316 RVA: 0x003996A2 File Offset: 0x003978A2
		public int TimeLeft { get; set; }

		// Token: 0x170079C9 RID: 31177
		// (get) Token: 0x06019395 RID: 103317 RVA: 0x003996AB File Offset: 0x003978AB
		// (set) Token: 0x06019396 RID: 103318 RVA: 0x003996B3 File Offset: 0x003978B3
		public ETimeLeftIconType IconType { get; set; }

		// Token: 0x170079CA RID: 31178
		// (get) Token: 0x06019397 RID: 103319 RVA: 0x003996BC File Offset: 0x003978BC
		// (set) Token: 0x06019398 RID: 103320 RVA: 0x003996C4 File Offset: 0x003978C4
		public bool ShowTime { get; set; }

		// Token: 0x170079CB RID: 31179
		// (get) Token: 0x06019399 RID: 103321 RVA: 0x003996CD File Offset: 0x003978CD
		// (set) Token: 0x0601939A RID: 103322 RVA: 0x003996D5 File Offset: 0x003978D5
		public byte NullMask { get; set; }

		// Token: 0x0601939B RID: 103323 RVA: 0x003996DE File Offset: 0x003978DE
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
