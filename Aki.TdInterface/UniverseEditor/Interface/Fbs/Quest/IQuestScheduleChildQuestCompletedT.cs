using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004017 RID: 16407
	public class IQuestScheduleChildQuestCompletedT
	{
		// Token: 0x17007358 RID: 29528
		// (get) Token: 0x06017B25 RID: 97061 RVA: 0x0036B285 File Offset: 0x00369485
		// (set) Token: 0x06017B26 RID: 97062 RVA: 0x0036B28D File Offset: 0x0036948D
		public EQuestScheduleType Type { get; set; }

		// Token: 0x17007359 RID: 29529
		// (get) Token: 0x06017B27 RID: 97063 RVA: 0x0036B296 File Offset: 0x00369496
		// (set) Token: 0x06017B28 RID: 97064 RVA: 0x0036B29E File Offset: 0x0036949E
		public int ChildQuestId { get; set; }

		// Token: 0x1700735A RID: 29530
		// (get) Token: 0x06017B29 RID: 97065 RVA: 0x0036B2A7 File Offset: 0x003694A7
		// (set) Token: 0x06017B2A RID: 97066 RVA: 0x0036B2AF File Offset: 0x003694AF
		public bool ShowTracking { get; set; }

		// Token: 0x1700735B RID: 29531
		// (get) Token: 0x06017B2B RID: 97067 RVA: 0x0036B2B8 File Offset: 0x003694B8
		// (set) Token: 0x06017B2C RID: 97068 RVA: 0x0036B2C0 File Offset: 0x003694C0
		public bool ShowComplete { get; set; }

		// Token: 0x1700735C RID: 29532
		// (get) Token: 0x06017B2D RID: 97069 RVA: 0x0036B2C9 File Offset: 0x003694C9
		// (set) Token: 0x06017B2E RID: 97070 RVA: 0x0036B2D1 File Offset: 0x003694D1
		public bool OnlyShowWhileRunning { get; set; }

		// Token: 0x1700735D RID: 29533
		// (get) Token: 0x06017B2F RID: 97071 RVA: 0x0036B2DA File Offset: 0x003694DA
		// (set) Token: 0x06017B30 RID: 97072 RVA: 0x0036B2E2 File Offset: 0x003694E2
		public List<TVarRefUnion> Vars { get; set; }

		// Token: 0x1700735E RID: 29534
		// (get) Token: 0x06017B31 RID: 97073 RVA: 0x0036B2EB File Offset: 0x003694EB
		// (set) Token: 0x06017B32 RID: 97074 RVA: 0x0036B2F3 File Offset: 0x003694F3
		public int CustomIcon { get; set; }

		// Token: 0x1700735F RID: 29535
		// (get) Token: 0x06017B33 RID: 97075 RVA: 0x0036B2FC File Offset: 0x003694FC
		// (set) Token: 0x06017B34 RID: 97076 RVA: 0x0036B304 File Offset: 0x00369504
		public ITitlePreStateT TitlePreState { get; set; }

		// Token: 0x17007360 RID: 29536
		// (get) Token: 0x06017B35 RID: 97077 RVA: 0x0036B30D File Offset: 0x0036950D
		// (set) Token: 0x06017B36 RID: 97078 RVA: 0x0036B315 File Offset: 0x00369515
		public byte NullMask { get; set; }

		// Token: 0x06017B37 RID: 97079 RVA: 0x0036B320 File Offset: 0x00369520
		public IQuestScheduleChildQuestCompletedT()
		{
			this.Type = EQuestScheduleType.None;
			this.ChildQuestId = 0;
			this.ShowTracking = false;
			this.ShowComplete = false;
			this.OnlyShowWhileRunning = false;
			this.Vars = null;
			this.CustomIcon = 0;
			this.TitlePreState = null;
			this.NullMask = 0;
		}
	}
}
