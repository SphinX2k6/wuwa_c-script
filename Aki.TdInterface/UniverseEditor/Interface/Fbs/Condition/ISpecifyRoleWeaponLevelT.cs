using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CD7 RID: 19671
	public class ISpecifyRoleWeaponLevelT
	{
		// Token: 0x17008EC6 RID: 36550
		// (get) Token: 0x0601F36F RID: 127855 RVA: 0x0045B514 File Offset: 0x00459714
		// (set) Token: 0x0601F370 RID: 127856 RVA: 0x0045B51C File Offset: 0x0045971C
		public EWeaponLevelType Type { get; set; }

		// Token: 0x17008EC7 RID: 36551
		// (get) Token: 0x0601F371 RID: 127857 RVA: 0x0045B525 File Offset: 0x00459725
		// (set) Token: 0x0601F372 RID: 127858 RVA: 0x0045B52D File Offset: 0x0045972D
		public int Index { get; set; }

		// Token: 0x17008EC8 RID: 36552
		// (get) Token: 0x0601F373 RID: 127859 RVA: 0x0045B536 File Offset: 0x00459736
		// (set) Token: 0x0601F374 RID: 127860 RVA: 0x0045B53E File Offset: 0x0045973E
		public ECompare Compare { get; set; }

		// Token: 0x17008EC9 RID: 36553
		// (get) Token: 0x0601F375 RID: 127861 RVA: 0x0045B547 File Offset: 0x00459747
		// (set) Token: 0x0601F376 RID: 127862 RVA: 0x0045B54F File Offset: 0x0045974F
		public int Level { get; set; }

		// Token: 0x0601F377 RID: 127863 RVA: 0x0045B558 File Offset: 0x00459758
		public ISpecifyRoleWeaponLevelT()
		{
			this.Type = EWeaponLevelType.SpecifyRole;
			this.Index = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
