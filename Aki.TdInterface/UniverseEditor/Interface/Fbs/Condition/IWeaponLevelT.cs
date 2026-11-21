using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005218 RID: 21016
	public class IWeaponLevelT
	{
		// Token: 0x1700965C RID: 38492
		// (get) Token: 0x0602119F RID: 135583 RVA: 0x004927C7 File Offset: 0x004909C7
		// (set) Token: 0x060211A0 RID: 135584 RVA: 0x004927CF File Offset: 0x004909CF
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x1700965D RID: 38493
		// (get) Token: 0x060211A1 RID: 135585 RVA: 0x004927D8 File Offset: 0x004909D8
		// (set) Token: 0x060211A2 RID: 135586 RVA: 0x004927E0 File Offset: 0x004909E0
		public ISpecifyRoleWeaponLevelT Option { get; set; }

		// Token: 0x060211A3 RID: 135587 RVA: 0x004927E9 File Offset: 0x004909E9
		public IWeaponLevelT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
			this.Option = null;
		}
	}
}
