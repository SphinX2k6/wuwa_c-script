using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200445E RID: 17502
	public class IQuestScheduleConfigT
	{
		// Token: 0x1700796E RID: 31086
		// (get) Token: 0x0601920C RID: 102924 RVA: 0x00395AEC File Offset: 0x00393CEC
		// (set) Token: 0x0601920D RID: 102925 RVA: 0x00395AF4 File Offset: 0x00393CF4
		public EQuestScheduleUiType UiType { get; set; }

		// Token: 0x1700796F RID: 31087
		// (get) Token: 0x0601920E RID: 102926 RVA: 0x00395AFD File Offset: 0x00393CFD
		// (set) Token: 0x0601920F RID: 102927 RVA: 0x00395B05 File Offset: 0x00393D05
		public IQuestScheduleMainTitleT MainTitle { get; set; }

		// Token: 0x17007970 RID: 31088
		// (get) Token: 0x06019210 RID: 102928 RVA: 0x00395B0E File Offset: 0x00393D0E
		// (set) Token: 0x06019211 RID: 102929 RVA: 0x00395B16 File Offset: 0x00393D16
		public List<IQuestScheduleSubTitleT> SubTitles { get; set; }

		// Token: 0x17007971 RID: 31089
		// (get) Token: 0x06019212 RID: 102930 RVA: 0x00395B1F File Offset: 0x00393D1F
		// (set) Token: 0x06019213 RID: 102931 RVA: 0x00395B27 File Offset: 0x00393D27
		public ITrackTargetT TrackTarget { get; set; }

		// Token: 0x17007972 RID: 31090
		// (get) Token: 0x06019214 RID: 102932 RVA: 0x00395B30 File Offset: 0x00393D30
		// (set) Token: 0x06019215 RID: 102933 RVA: 0x00395B38 File Offset: 0x00393D38
		public ILevelPlayTrackRadiusT TrackRadius { get; set; }

		// Token: 0x06019216 RID: 102934 RVA: 0x00395B41 File Offset: 0x00393D41
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
