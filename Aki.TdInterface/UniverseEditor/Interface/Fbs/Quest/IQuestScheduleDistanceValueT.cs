using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004461 RID: 17505
	public class IQuestScheduleDistanceValueT
	{
		// Token: 0x17007977 RID: 31095
		// (get) Token: 0x0601922A RID: 102954 RVA: 0x00395E9D File Offset: 0x0039409D
		// (set) Token: 0x0601922B RID: 102955 RVA: 0x00395EA5 File Offset: 0x003940A5
		public EQuestScheduleType Type { get; set; }

		// Token: 0x17007978 RID: 31096
		// (get) Token: 0x0601922C RID: 102956 RVA: 0x00395EAE File Offset: 0x003940AE
		// (set) Token: 0x0601922D RID: 102957 RVA: 0x00395EB6 File Offset: 0x003940B6
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosAT Pos { get; set; }

		// Token: 0x17007979 RID: 31097
		// (get) Token: 0x0601922E RID: 102958 RVA: 0x00395EBF File Offset: 0x003940BF
		// (set) Token: 0x0601922F RID: 102959 RVA: 0x00395EC7 File Offset: 0x003940C7
		public EDistanceMeasureMode DistanceMeasureMode { get; set; }

		// Token: 0x06019230 RID: 102960 RVA: 0x00395ED0 File Offset: 0x003940D0
		public IQuestScheduleDistanceValueT()
		{
			this.Type = EQuestScheduleType.None;
			this.Pos = null;
			this.DistanceMeasureMode = EDistanceMeasureMode.Horizontal;
		}
	}
}
