using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200401D RID: 16413
	public class IQuestScheduleConfigT
	{
		// Token: 0x1700736C RID: 29548
		// (get) Token: 0x06017B73 RID: 97139 RVA: 0x0036BCF8 File Offset: 0x00369EF8
		// (set) Token: 0x06017B74 RID: 97140 RVA: 0x0036BD00 File Offset: 0x00369F00
		public EQuestScheduleUiType UiType { get; set; }

		// Token: 0x1700736D RID: 29549
		// (get) Token: 0x06017B75 RID: 97141 RVA: 0x0036BD09 File Offset: 0x00369F09
		// (set) Token: 0x06017B76 RID: 97142 RVA: 0x0036BD11 File Offset: 0x00369F11
		public IQuestScheduleMainTitleT MainTitle { get; set; }

		// Token: 0x1700736E RID: 29550
		// (get) Token: 0x06017B77 RID: 97143 RVA: 0x0036BD1A File Offset: 0x00369F1A
		// (set) Token: 0x06017B78 RID: 97144 RVA: 0x0036BD22 File Offset: 0x00369F22
		public List<IQuestScheduleSubTitleT> SubTitles { get; set; }

		// Token: 0x1700736F RID: 29551
		// (get) Token: 0x06017B79 RID: 97145 RVA: 0x0036BD2B File Offset: 0x00369F2B
		// (set) Token: 0x06017B7A RID: 97146 RVA: 0x0036BD33 File Offset: 0x00369F33
		public ITrackTargetT TrackTarget { get; set; }

		// Token: 0x17007370 RID: 29552
		// (get) Token: 0x06017B7B RID: 97147 RVA: 0x0036BD3C File Offset: 0x00369F3C
		// (set) Token: 0x06017B7C RID: 97148 RVA: 0x0036BD44 File Offset: 0x00369F44
		public ILevelPlayTrackRadiusT TrackRadius { get; set; }

		// Token: 0x06017B7D RID: 97149 RVA: 0x0036BD4D File Offset: 0x00369F4D
		public IQuestScheduleConfigT()
		{
			this.UiType = EQuestScheduleUiType.Task;
			this.MainTitle = null;
			this.SubTitles = null;
			this.TrackTarget = null;
			this.TrackRadius = null;
		}
	}
}
