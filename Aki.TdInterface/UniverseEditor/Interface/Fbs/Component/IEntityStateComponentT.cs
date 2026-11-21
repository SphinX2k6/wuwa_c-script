using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200571F RID: 22303
	public class IEntityStateComponentT
	{
		// Token: 0x1700A0EE RID: 41198
		// (get) Token: 0x06023DA2 RID: 146850 RVA: 0x004EDB56 File Offset: 0x004EBD56
		// (set) Token: 0x06023DA3 RID: 146851 RVA: 0x004EDB5E File Offset: 0x004EBD5E
		public string Type { get; set; }

		// Token: 0x1700A0EF RID: 41199
		// (get) Token: 0x06023DA4 RID: 146852 RVA: 0x004EDB67 File Offset: 0x004EBD67
		// (set) Token: 0x06023DA5 RID: 146853 RVA: 0x004EDB6F File Offset: 0x004EBD6F
		public string State { get; set; }

		// Token: 0x1700A0F0 RID: 41200
		// (get) Token: 0x06023DA6 RID: 146854 RVA: 0x004EDB78 File Offset: 0x004EBD78
		// (set) Token: 0x06023DA7 RID: 146855 RVA: 0x004EDB80 File Offset: 0x004EBD80
		public bool Disabled { get; set; }

		// Token: 0x1700A0F1 RID: 41201
		// (get) Token: 0x06023DA8 RID: 146856 RVA: 0x004EDB89 File Offset: 0x004EBD89
		// (set) Token: 0x06023DA9 RID: 146857 RVA: 0x004EDB91 File Offset: 0x004EBD91
		public IConditionGroupT StateChangeCondition { get; set; }

		// Token: 0x1700A0F2 RID: 41202
		// (get) Token: 0x06023DAA RID: 146858 RVA: 0x004EDB9A File Offset: 0x004EBD9A
		// (set) Token: 0x06023DAB RID: 146859 RVA: 0x004EDBA2 File Offset: 0x004EBDA2
		public List<IStateChangeBehaviorT> StateChangeBehaviors { get; set; }

		// Token: 0x1700A0F3 RID: 41203
		// (get) Token: 0x06023DAC RID: 146860 RVA: 0x004EDBAB File Offset: 0x004EBDAB
		// (set) Token: 0x06023DAD RID: 146861 RVA: 0x004EDBB3 File Offset: 0x004EBDB3
		public bool InstantActionsOnStateChange { get; set; }

		// Token: 0x1700A0F4 RID: 41204
		// (get) Token: 0x06023DAE RID: 146862 RVA: 0x004EDBBC File Offset: 0x004EBDBC
		// (set) Token: 0x06023DAF RID: 146863 RVA: 0x004EDBC4 File Offset: 0x004EBDC4
		public ILockConfigT LockConfig { get; set; }

		// Token: 0x1700A0F5 RID: 41205
		// (get) Token: 0x06023DB0 RID: 146864 RVA: 0x004EDBCD File Offset: 0x004EBDCD
		// (set) Token: 0x06023DB1 RID: 146865 RVA: 0x004EDBD5 File Offset: 0x004EBDD5
		public List<IStateConfigT> StateConfigs { get; set; }

		// Token: 0x1700A0F6 RID: 41206
		// (get) Token: 0x06023DB2 RID: 146866 RVA: 0x004EDBDE File Offset: 0x004EBDDE
		// (set) Token: 0x06023DB3 RID: 146867 RVA: 0x004EDBE6 File Offset: 0x004EBDE6
		public List<string> CycleStates { get; set; }

		// Token: 0x1700A0F7 RID: 41207
		// (get) Token: 0x06023DB4 RID: 146868 RVA: 0x004EDBEF File Offset: 0x004EBDEF
		// (set) Token: 0x06023DB5 RID: 146869 RVA: 0x004EDBF7 File Offset: 0x004EBDF7
		public string PrefabPerformanceType { get; set; }

		// Token: 0x1700A0F8 RID: 41208
		// (get) Token: 0x06023DB6 RID: 146870 RVA: 0x004EDC00 File Offset: 0x004EBE00
		// (set) Token: 0x06023DB7 RID: 146871 RVA: 0x004EDC08 File Offset: 0x004EBE08
		public byte NullMask { get; set; }

		// Token: 0x06023DB8 RID: 146872 RVA: 0x004EDC14 File Offset: 0x004EBE14
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
