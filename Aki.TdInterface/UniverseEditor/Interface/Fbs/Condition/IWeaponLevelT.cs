using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D1C RID: 19740
	public class IWeaponLevelT
	{
		// Token: 0x17008F23 RID: 36643
		// (get) Token: 0x0601F558 RID: 128344 RVA: 0x0045E837 File Offset: 0x0045CA37
		// (set) Token: 0x0601F559 RID: 128345 RVA: 0x0045E83F File Offset: 0x0045CA3F
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x17008F24 RID: 36644
		// (get) Token: 0x0601F55A RID: 128346 RVA: 0x0045E848 File Offset: 0x0045CA48
		// (set) Token: 0x0601F55B RID: 128347 RVA: 0x0045E850 File Offset: 0x0045CA50
		public ISpecifyRoleWeaponLevelT Option { get; set; }

		// Token: 0x0601F55C RID: 128348 RVA: 0x0045E859 File Offset: 0x0045CA59
		public IWeaponLevelT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
			this.Option = null;
		}
	}
}
