using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051D3 RID: 20947
	public class ISpecifyRoleWeaponLevelT
	{
		// Token: 0x170095FF RID: 38399
		// (get) Token: 0x06020FB3 RID: 135091 RVA: 0x0048F40C File Offset: 0x0048D60C
		// (set) Token: 0x06020FB4 RID: 135092 RVA: 0x0048F414 File Offset: 0x0048D614
		public EWeaponLevelType Type { get; set; }

		// Token: 0x17009600 RID: 38400
		// (get) Token: 0x06020FB5 RID: 135093 RVA: 0x0048F41D File Offset: 0x0048D61D
		// (set) Token: 0x06020FB6 RID: 135094 RVA: 0x0048F425 File Offset: 0x0048D625
		public int Index { get; set; }

		// Token: 0x17009601 RID: 38401
		// (get) Token: 0x06020FB7 RID: 135095 RVA: 0x0048F42E File Offset: 0x0048D62E
		// (set) Token: 0x06020FB8 RID: 135096 RVA: 0x0048F436 File Offset: 0x0048D636
		public ECompare Compare { get; set; }

		// Token: 0x17009602 RID: 38402
		// (get) Token: 0x06020FB9 RID: 135097 RVA: 0x0048F43F File Offset: 0x0048D63F
		// (set) Token: 0x06020FBA RID: 135098 RVA: 0x0048F447 File Offset: 0x0048D647
		public int Level { get; set; }

		// Token: 0x06020FBB RID: 135099 RVA: 0x0048F450 File Offset: 0x0048D650
		public ISpecifyRoleWeaponLevelT()
		{
			this.Type = EWeaponLevelType.SpecifyRole;
			this.Index = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
