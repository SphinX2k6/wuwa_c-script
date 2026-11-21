using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004972 RID: 18802
	public class ILevelPlayOpenConditionT
	{
		// Token: 0x17008392 RID: 33682
		// (get) Token: 0x0601C0C0 RID: 114880 RVA: 0x003F73E3 File Offset: 0x003F55E3
		// (set) Token: 0x0601C0C1 RID: 114881 RVA: 0x003F73EB File Offset: 0x003F55EB
		public EConditionCount Type { get; set; }

		// Token: 0x17008393 RID: 33683
		// (get) Token: 0x0601C0C2 RID: 114882 RVA: 0x003F73F4 File Offset: 0x003F55F4
		// (set) Token: 0x0601C0C3 RID: 114883 RVA: 0x003F73FC File Offset: 0x003F55FC
		public List<TAccessQuestConditionUnion> Conditions { get; set; }

		// Token: 0x17008394 RID: 33684
		// (get) Token: 0x0601C0C4 RID: 114884 RVA: 0x003F7405 File Offset: 0x003F5605
		// (set) Token: 0x0601C0C5 RID: 114885 RVA: 0x003F740D File Offset: 0x003F560D
		public bool DelayRefresh { get; set; }

		// Token: 0x17008395 RID: 33685
		// (get) Token: 0x0601C0C6 RID: 114886 RVA: 0x003F7416 File Offset: 0x003F5616
		// (set) Token: 0x0601C0C7 RID: 114887 RVA: 0x003F741E File Offset: 0x003F561E
		public byte NullMask { get; set; }

		// Token: 0x0601C0C8 RID: 114888 RVA: 0x003F7427 File Offset: 0x003F5627
		public ILevelPlayOpenConditionT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
			this.DelayRefresh = false;
			this.NullMask = 0;
		}
	}
}
