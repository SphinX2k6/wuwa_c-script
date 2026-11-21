using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004954 RID: 18772
	public class ILevelPlayActiveT
	{
		// Token: 0x17008346 RID: 33606
		// (get) Token: 0x0601BF72 RID: 114546 RVA: 0x003F47E7 File Offset: 0x003F29E7
		// (set) Token: 0x0601BF73 RID: 114547 RVA: 0x003F47EF File Offset: 0x003F29EF
		public ELevelPlayActiveType ActiveType { get; set; }

		// Token: 0x17008347 RID: 33607
		// (get) Token: 0x0601BF74 RID: 114548 RVA: 0x003F47F8 File Offset: 0x003F29F8
		// (set) Token: 0x0601BF75 RID: 114549 RVA: 0x003F4800 File Offset: 0x003F2A00
		public IConditionGroupT ActiveCondition { get; set; }

		// Token: 0x0601BF76 RID: 114550 RVA: 0x003F4809 File Offset: 0x003F2A09
		public ILevelPlayActiveT()
		{
			this.ActiveType = ELevelPlayActiveType.Default;
			this.ActiveCondition = null;
		}
	}
}
