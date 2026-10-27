using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004872 RID: 18546
	public class IEditorStateT
	{
		// Token: 0x1700862B RID: 34347
		// (get) Token: 0x0601CE00 RID: 118272 RVA: 0x00414EE2 File Offset: 0x004130E2
		// (set) Token: 0x0601CE01 RID: 118273 RVA: 0x00414EEA File Offset: 0x004130EA
		public bool IsNewJsonNameMode { get; set; }

		// Token: 0x1700862C RID: 34348
		// (get) Token: 0x0601CE02 RID: 118274 RVA: 0x00414EF3 File Offset: 0x004130F3
		// (set) Token: 0x0601CE03 RID: 118275 RVA: 0x00414EFB File Offset: 0x004130FB
		public long LastWorkSpaceCheckTimestamp { get; set; }

		// Token: 0x1700862D RID: 34349
		// (get) Token: 0x0601CE04 RID: 118276 RVA: 0x00414F04 File Offset: 0x00413104
		// (set) Token: 0x0601CE05 RID: 118277 RVA: 0x00414F0C File Offset: 0x0041310C
		public bool IsLoadingArchive { get; set; }

		// Token: 0x1700862E RID: 34350
		// (get) Token: 0x0601CE06 RID: 118278 RVA: 0x00414F15 File Offset: 0x00413115
		// (set) Token: 0x0601CE07 RID: 118279 RVA: 0x00414F1D File Offset: 0x0041311D
		public bool IsEnableBreakPoint { get; set; }

		// Token: 0x1700862F RID: 34351
		// (get) Token: 0x0601CE08 RID: 118280 RVA: 0x00414F26 File Offset: 0x00413126
		// (set) Token: 0x0601CE09 RID: 118281 RVA: 0x00414F2E File Offset: 0x0041312E
		public string PlannedBranch { get; set; }

		// Token: 0x17008630 RID: 34352
		// (get) Token: 0x0601CE0A RID: 118282 RVA: 0x00414F37 File Offset: 0x00413137
		// (set) Token: 0x0601CE0B RID: 118283 RVA: 0x00414F3F File Offset: 0x0041313F
		public List<string> AutoCaptureTree { get; set; }

		// Token: 0x17008631 RID: 34353
		// (get) Token: 0x0601CE0C RID: 118284 RVA: 0x00414F48 File Offset: 0x00413148
		// (set) Token: 0x0601CE0D RID: 118285 RVA: 0x00414F50 File Offset: 0x00413150
		public IEditorObjectCacheInfoT EditorObjectCacheInfo { get; set; }

		// Token: 0x17008632 RID: 34354
		// (get) Token: 0x0601CE0E RID: 118286 RVA: 0x00414F59 File Offset: 0x00413159
		// (set) Token: 0x0601CE0F RID: 118287 RVA: 0x00414F61 File Offset: 0x00413161
		public bool IsShowIndividualOwner { get; set; }

		// Token: 0x17008633 RID: 34355
		// (get) Token: 0x0601CE10 RID: 118288 RVA: 0x00414F6A File Offset: 0x0041316A
		// (set) Token: 0x0601CE11 RID: 118289 RVA: 0x00414F72 File Offset: 0x00413172
		public bool IsEnableFlowEditorTreeView { get; set; }

		// Token: 0x17008634 RID: 34356
		// (get) Token: 0x0601CE12 RID: 118290 RVA: 0x00414F7B File Offset: 0x0041317B
		// (set) Token: 0x0601CE13 RID: 118291 RVA: 0x00414F83 File Offset: 0x00413183
		public bool HideMachineNotRegistedTip { get; set; }

		// Token: 0x17008635 RID: 34357
		// (get) Token: 0x0601CE14 RID: 118292 RVA: 0x00414F8C File Offset: 0x0041318C
		// (set) Token: 0x0601CE15 RID: 118293 RVA: 0x00414F94 File Offset: 0x00413194
		public bool IsDefaultAddPlotConfig { get; set; }

		// Token: 0x17008636 RID: 34358
		// (get) Token: 0x0601CE16 RID: 118294 RVA: 0x00414F9D File Offset: 0x0041319D
		// (set) Token: 0x0601CE17 RID: 118295 RVA: 0x00414FA5 File Offset: 0x004131A5
		public IEditorRestartInfoT EditorRestartInfo { get; set; }

		// Token: 0x0601CE18 RID: 118296 RVA: 0x00414FB0 File Offset: 0x004131B0
		public IEditorStateT()
		{
			this.IsNewJsonNameMode = false;
			this.LastWorkSpaceCheckTimestamp = 0L;
			this.IsLoadingArchive = false;
			this.IsEnableBreakPoint = false;
			this.PlannedBranch = null;
			this.AutoCaptureTree = null;
			this.EditorObjectCacheInfo = null;
			this.IsShowIndividualOwner = false;
			this.IsEnableFlowEditorTreeView = false;
			this.HideMachineNotRegistedTip = false;
			this.IsDefaultAddPlotConfig = false;
			this.EditorRestartInfo = null;
		}
	}
}
