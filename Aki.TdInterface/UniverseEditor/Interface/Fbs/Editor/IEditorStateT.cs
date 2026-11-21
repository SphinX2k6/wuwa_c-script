using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CD7 RID: 19671
	public class IEditorStateT
	{
		// Token: 0x17008C74 RID: 35956
		// (get) Token: 0x0601E5EF RID: 124399 RVA: 0x004416BF File Offset: 0x0043F8BF
		// (set) Token: 0x0601E5F0 RID: 124400 RVA: 0x004416C7 File Offset: 0x0043F8C7
		public bool IsNewJsonNameMode { get; set; }

		// Token: 0x17008C75 RID: 35957
		// (get) Token: 0x0601E5F1 RID: 124401 RVA: 0x004416D0 File Offset: 0x0043F8D0
		// (set) Token: 0x0601E5F2 RID: 124402 RVA: 0x004416D8 File Offset: 0x0043F8D8
		public long LastWorkSpaceCheckTimestamp { get; set; }

		// Token: 0x17008C76 RID: 35958
		// (get) Token: 0x0601E5F3 RID: 124403 RVA: 0x004416E1 File Offset: 0x0043F8E1
		// (set) Token: 0x0601E5F4 RID: 124404 RVA: 0x004416E9 File Offset: 0x0043F8E9
		public bool IsLoadingArchive { get; set; }

		// Token: 0x17008C77 RID: 35959
		// (get) Token: 0x0601E5F5 RID: 124405 RVA: 0x004416F2 File Offset: 0x0043F8F2
		// (set) Token: 0x0601E5F6 RID: 124406 RVA: 0x004416FA File Offset: 0x0043F8FA
		public bool IsEnableBreakPoint { get; set; }

		// Token: 0x17008C78 RID: 35960
		// (get) Token: 0x0601E5F7 RID: 124407 RVA: 0x00441703 File Offset: 0x0043F903
		// (set) Token: 0x0601E5F8 RID: 124408 RVA: 0x0044170B File Offset: 0x0043F90B
		public string PlannedBranch { get; set; }

		// Token: 0x17008C79 RID: 35961
		// (get) Token: 0x0601E5F9 RID: 124409 RVA: 0x00441714 File Offset: 0x0043F914
		// (set) Token: 0x0601E5FA RID: 124410 RVA: 0x0044171C File Offset: 0x0043F91C
		public List<string> AutoCaptureTree { get; set; }

		// Token: 0x17008C7A RID: 35962
		// (get) Token: 0x0601E5FB RID: 124411 RVA: 0x00441725 File Offset: 0x0043F925
		// (set) Token: 0x0601E5FC RID: 124412 RVA: 0x0044172D File Offset: 0x0043F92D
		public bool IsShowIndividualOwner { get; set; }

		// Token: 0x17008C7B RID: 35963
		// (get) Token: 0x0601E5FD RID: 124413 RVA: 0x00441736 File Offset: 0x0043F936
		// (set) Token: 0x0601E5FE RID: 124414 RVA: 0x0044173E File Offset: 0x0043F93E
		public bool IsEnableFlowEditorTreeView { get; set; }

		// Token: 0x17008C7C RID: 35964
		// (get) Token: 0x0601E5FF RID: 124415 RVA: 0x00441747 File Offset: 0x0043F947
		// (set) Token: 0x0601E600 RID: 124416 RVA: 0x0044174F File Offset: 0x0043F94F
		public bool HideMachineNotRegistedTip { get; set; }

		// Token: 0x17008C7D RID: 35965
		// (get) Token: 0x0601E601 RID: 124417 RVA: 0x00441758 File Offset: 0x0043F958
		// (set) Token: 0x0601E602 RID: 124418 RVA: 0x00441760 File Offset: 0x0043F960
		public bool IsDefaultAddPlotConfig { get; set; }

		// Token: 0x17008C7E RID: 35966
		// (get) Token: 0x0601E603 RID: 124419 RVA: 0x00441769 File Offset: 0x0043F969
		// (set) Token: 0x0601E604 RID: 124420 RVA: 0x00441771 File Offset: 0x0043F971
		public IEditorRestartInfoT EditorRestartInfo { get; set; }

		// Token: 0x0601E605 RID: 124421 RVA: 0x0044177C File Offset: 0x0043F97C
		public IEditorStateT()
		{
			this.IsNewJsonNameMode = false;
			this.LastWorkSpaceCheckTimestamp = 0L;
			this.IsLoadingArchive = false;
			this.IsEnableBreakPoint = false;
			this.PlannedBranch = null;
			this.AutoCaptureTree = null;
			this.IsShowIndividualOwner = false;
			this.IsEnableFlowEditorTreeView = false;
			this.HideMachineNotRegistedTip = false;
			this.IsDefaultAddPlotConfig = false;
			this.EditorRestartInfo = null;
		}
	}
}
