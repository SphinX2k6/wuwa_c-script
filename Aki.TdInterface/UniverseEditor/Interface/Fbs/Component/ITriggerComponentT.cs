using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ADF RID: 23263
	public class ITriggerComponentT
	{
		// Token: 0x1700AF60 RID: 44896
		// (get) Token: 0x06027B06 RID: 162566 RVA: 0x00575C67 File Offset: 0x00573E67
		// (set) Token: 0x06027B07 RID: 162567 RVA: 0x00575C6F File Offset: 0x00573E6F
		public bool Disabled { get; set; }

		// Token: 0x1700AF61 RID: 44897
		// (get) Token: 0x06027B08 RID: 162568 RVA: 0x00575C78 File Offset: 0x00573E78
		// (set) Token: 0x06027B09 RID: 162569 RVA: 0x00575C80 File Offset: 0x00573E80
		public IEntityMatchT Match { get; set; }

		// Token: 0x1700AF62 RID: 44898
		// (get) Token: 0x06027B0A RID: 162570 RVA: 0x00575C89 File Offset: 0x00573E89
		// (set) Token: 0x06027B0B RID: 162571 RVA: 0x00575C91 File Offset: 0x00573E91
		public int MaxTriggerTimes { get; set; }

		// Token: 0x1700AF63 RID: 44899
		// (get) Token: 0x06027B0C RID: 162572 RVA: 0x00575C9A File Offset: 0x00573E9A
		// (set) Token: 0x06027B0D RID: 162573 RVA: 0x00575CA2 File Offset: 0x00573EA2
		public int MatchTypeCount { get; set; }

		// Token: 0x1700AF64 RID: 44900
		// (get) Token: 0x06027B0E RID: 162574 RVA: 0x00575CAB File Offset: 0x00573EAB
		// (set) Token: 0x06027B0F RID: 162575 RVA: 0x00575CB3 File Offset: 0x00573EB3
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700AF65 RID: 44901
		// (get) Token: 0x06027B10 RID: 162576 RVA: 0x00575CBC File Offset: 0x00573EBC
		// (set) Token: 0x06027B11 RID: 162577 RVA: 0x00575CC4 File Offset: 0x00573EC4
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700AF66 RID: 44902
		// (get) Token: 0x06027B12 RID: 162578 RVA: 0x00575CCD File Offset: 0x00573ECD
		// (set) Token: 0x06027B13 RID: 162579 RVA: 0x00575CD5 File Offset: 0x00573ED5
		public ITriggerExitConfigT ExitConfig { get; set; }

		// Token: 0x1700AF67 RID: 44903
		// (get) Token: 0x06027B14 RID: 162580 RVA: 0x00575CDE File Offset: 0x00573EDE
		// (set) Token: 0x06027B15 RID: 162581 RVA: 0x00575CE6 File Offset: 0x00573EE6
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700AF68 RID: 44904
		// (get) Token: 0x06027B16 RID: 162582 RVA: 0x00575CEF File Offset: 0x00573EEF
		// (set) Token: 0x06027B17 RID: 162583 RVA: 0x00575CF7 File Offset: 0x00573EF7
		public bool ChangeRoleTrigger { get; set; }

		// Token: 0x1700AF69 RID: 44905
		// (get) Token: 0x06027B18 RID: 162584 RVA: 0x00575D00 File Offset: 0x00573F00
		// (set) Token: 0x06027B19 RID: 162585 RVA: 0x00575D08 File Offset: 0x00573F08
		public bool ClientPrePerformance { get; set; }

		// Token: 0x1700AF6A RID: 44906
		// (get) Token: 0x06027B1A RID: 162586 RVA: 0x00575D11 File Offset: 0x00573F11
		// (set) Token: 0x06027B1B RID: 162587 RVA: 0x00575D19 File Offset: 0x00573F19
		public bool OnlineDisableTip { get; set; }

		// Token: 0x1700AF6B RID: 44907
		// (get) Token: 0x06027B1C RID: 162588 RVA: 0x00575D22 File Offset: 0x00573F22
		// (set) Token: 0x06027B1D RID: 162589 RVA: 0x00575D2A File Offset: 0x00573F2A
		public bool OnlineAutoExit { get; set; }

		// Token: 0x1700AF6C RID: 44908
		// (get) Token: 0x06027B1E RID: 162590 RVA: 0x00575D33 File Offset: 0x00573F33
		// (set) Token: 0x06027B1F RID: 162591 RVA: 0x00575D3B File Offset: 0x00573F3B
		public byte NullMask { get; set; }

		// Token: 0x06027B20 RID: 162592 RVA: 0x00575D44 File Offset: 0x00573F44
		public ITriggerComponentT()
		{
			this.Disabled = false;
			this.Match = null;
			this.MaxTriggerTimes = 0;
			this.MatchTypeCount = 0;
			this.Condition = null;
			this.Actions = null;
			this.ExitConfig = null;
			this.MatchRoleOption = null;
			this.ChangeRoleTrigger = false;
			this.ClientPrePerformance = false;
			this.OnlineDisableTip = false;
			this.OnlineAutoExit = false;
			this.NullMask = 0;
		}
	}
}
