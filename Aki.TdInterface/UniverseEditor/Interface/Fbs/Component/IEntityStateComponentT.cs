using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051BA RID: 20922
	public class IEntityStateComponentT
	{
		// Token: 0x170098FF RID: 39167
		// (get) Token: 0x06021E4A RID: 138826 RVA: 0x004B3AEE File Offset: 0x004B1CEE
		// (set) Token: 0x06021E4B RID: 138827 RVA: 0x004B3AF6 File Offset: 0x004B1CF6
		public string Type { get; set; }

		// Token: 0x17009900 RID: 39168
		// (get) Token: 0x06021E4C RID: 138828 RVA: 0x004B3AFF File Offset: 0x004B1CFF
		// (set) Token: 0x06021E4D RID: 138829 RVA: 0x004B3B07 File Offset: 0x004B1D07
		public string State { get; set; }

		// Token: 0x17009901 RID: 39169
		// (get) Token: 0x06021E4E RID: 138830 RVA: 0x004B3B10 File Offset: 0x004B1D10
		// (set) Token: 0x06021E4F RID: 138831 RVA: 0x004B3B18 File Offset: 0x004B1D18
		public bool Disabled { get; set; }

		// Token: 0x17009902 RID: 39170
		// (get) Token: 0x06021E50 RID: 138832 RVA: 0x004B3B21 File Offset: 0x004B1D21
		// (set) Token: 0x06021E51 RID: 138833 RVA: 0x004B3B29 File Offset: 0x004B1D29
		public IConditionGroupT StateChangeCondition { get; set; }

		// Token: 0x17009903 RID: 39171
		// (get) Token: 0x06021E52 RID: 138834 RVA: 0x004B3B32 File Offset: 0x004B1D32
		// (set) Token: 0x06021E53 RID: 138835 RVA: 0x004B3B3A File Offset: 0x004B1D3A
		public List<IStateChangeBehaviorT> StateChangeBehaviors { get; set; }

		// Token: 0x17009904 RID: 39172
		// (get) Token: 0x06021E54 RID: 138836 RVA: 0x004B3B43 File Offset: 0x004B1D43
		// (set) Token: 0x06021E55 RID: 138837 RVA: 0x004B3B4B File Offset: 0x004B1D4B
		public bool InstantActionsOnStateChange { get; set; }

		// Token: 0x17009905 RID: 39173
		// (get) Token: 0x06021E56 RID: 138838 RVA: 0x004B3B54 File Offset: 0x004B1D54
		// (set) Token: 0x06021E57 RID: 138839 RVA: 0x004B3B5C File Offset: 0x004B1D5C
		public ILockConfigT LockConfig { get; set; }

		// Token: 0x17009906 RID: 39174
		// (get) Token: 0x06021E58 RID: 138840 RVA: 0x004B3B65 File Offset: 0x004B1D65
		// (set) Token: 0x06021E59 RID: 138841 RVA: 0x004B3B6D File Offset: 0x004B1D6D
		public List<IStateConfigT> StateConfigs { get; set; }

		// Token: 0x17009907 RID: 39175
		// (get) Token: 0x06021E5A RID: 138842 RVA: 0x004B3B76 File Offset: 0x004B1D76
		// (set) Token: 0x06021E5B RID: 138843 RVA: 0x004B3B7E File Offset: 0x004B1D7E
		public List<string> CycleStates { get; set; }

		// Token: 0x17009908 RID: 39176
		// (get) Token: 0x06021E5C RID: 138844 RVA: 0x004B3B87 File Offset: 0x004B1D87
		// (set) Token: 0x06021E5D RID: 138845 RVA: 0x004B3B8F File Offset: 0x004B1D8F
		public string PrefabPerformanceType { get; set; }

		// Token: 0x17009909 RID: 39177
		// (get) Token: 0x06021E5E RID: 138846 RVA: 0x004B3B98 File Offset: 0x004B1D98
		// (set) Token: 0x06021E5F RID: 138847 RVA: 0x004B3BA0 File Offset: 0x004B1DA0
		public byte NullMask { get; set; }

		// Token: 0x06021E60 RID: 138848 RVA: 0x004B3BAC File Offset: 0x004B1DAC
		public IEntityStateComponentT()
		{
			this.Type = null;
			this.State = null;
			this.Disabled = false;
			this.StateChangeCondition = null;
			this.StateChangeBehaviors = null;
			this.InstantActionsOnStateChange = false;
			this.LockConfig = null;
			this.StateConfigs = null;
			this.CycleStates = null;
			this.PrefabPerformanceType = null;
			this.NullMask = 0;
		}
	}
}
