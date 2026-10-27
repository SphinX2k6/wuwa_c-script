using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BB4 RID: 15284
	public class IShowTimelineCheckpointT
	{
		// Token: 0x170068C9 RID: 26825
		// (get) Token: 0x06014F75 RID: 85877 RVA: 0x0030A72C File Offset: 0x0030892C
		// (set) Token: 0x06014F76 RID: 85878 RVA: 0x0030A734 File Offset: 0x00308934
		public EShowTimelineType Type { get; set; }

		// Token: 0x170068CA RID: 26826
		// (get) Token: 0x06014F77 RID: 85879 RVA: 0x0030A73D File Offset: 0x0030893D
		// (set) Token: 0x06014F78 RID: 85880 RVA: 0x0030A745 File Offset: 0x00308945
		public bool IsEnabled { get; set; }

		// Token: 0x170068CB RID: 26827
		// (get) Token: 0x06014F79 RID: 85881 RVA: 0x0030A74E File Offset: 0x0030894E
		// (set) Token: 0x06014F7A RID: 85882 RVA: 0x0030A756 File Offset: 0x00308956
		public int CheckpointId { get; set; }

		// Token: 0x170068CC RID: 26828
		// (get) Token: 0x06014F7B RID: 85883 RVA: 0x0030A75F File Offset: 0x0030895F
		// (set) Token: 0x06014F7C RID: 85884 RVA: 0x0030A767 File Offset: 0x00308967
		public int ActiveRoleId { get; set; }

		// Token: 0x170068CD RID: 26829
		// (get) Token: 0x06014F7D RID: 85885 RVA: 0x0030A770 File Offset: 0x00308970
		// (set) Token: 0x06014F7E RID: 85886 RVA: 0x0030A778 File Offset: 0x00308978
		public List<IShowTimelineRoleStateT> RoleStates { get; set; }

		// Token: 0x170068CE RID: 26830
		// (get) Token: 0x06014F7F RID: 85887 RVA: 0x0030A781 File Offset: 0x00308981
		// (set) Token: 0x06014F80 RID: 85888 RVA: 0x0030A789 File Offset: 0x00308989
		public List<IShowTimelineMonsterStateT> MonsterStates { get; set; }

		// Token: 0x170068CF RID: 26831
		// (get) Token: 0x06014F81 RID: 85889 RVA: 0x0030A792 File Offset: 0x00308992
		// (set) Token: 0x06014F82 RID: 85890 RVA: 0x0030A79A File Offset: 0x0030899A
		public ICheckpointDisplay_UnionUnion DisplayConfig { get; set; }

		// Token: 0x170068D0 RID: 26832
		// (get) Token: 0x06014F83 RID: 85891 RVA: 0x0030A7A3 File Offset: 0x003089A3
		// (set) Token: 0x06014F84 RID: 85892 RVA: 0x0030A7AB File Offset: 0x003089AB
		public string CustomName { get; set; }

		// Token: 0x170068D1 RID: 26833
		// (get) Token: 0x06014F85 RID: 85893 RVA: 0x0030A7B4 File Offset: 0x003089B4
		// (set) Token: 0x06014F86 RID: 85894 RVA: 0x0030A7BC File Offset: 0x003089BC
		public IPosAT PlayerPosition { get; set; }

		// Token: 0x170068D2 RID: 26834
		// (get) Token: 0x06014F87 RID: 85895 RVA: 0x0030A7C5 File Offset: 0x003089C5
		// (set) Token: 0x06014F88 RID: 85896 RVA: 0x0030A7CD File Offset: 0x003089CD
		public IPosAT MonsterPosition { get; set; }

		// Token: 0x06014F89 RID: 85897 RVA: 0x0030A7D8 File Offset: 0x003089D8
		public IShowTimelineCheckpointT()
		{
			this.Type = EShowTimelineType.Checkpoint;
			this.IsEnabled = false;
			this.CheckpointId = 0;
			this.ActiveRoleId = 0;
			this.RoleStates = null;
			this.MonsterStates = null;
			this.DisplayConfig = null;
			this.CustomName = null;
			this.PlayerPosition = null;
			this.MonsterPosition = null;
		}
	}
}
