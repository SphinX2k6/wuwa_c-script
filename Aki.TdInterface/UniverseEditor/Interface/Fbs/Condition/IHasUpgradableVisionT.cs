using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C38 RID: 19512
	public class IHasUpgradableVisionT
	{
		// Token: 0x17008DC0 RID: 36288
		// (get) Token: 0x0601EECD RID: 126669 RVA: 0x00453AE0 File Offset: 0x00451CE0
		// (set) Token: 0x0601EECE RID: 126670 RVA: 0x00453AE8 File Offset: 0x00451CE8
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x17008DC1 RID: 36289
		// (get) Token: 0x0601EECF RID: 126671 RVA: 0x00453AF1 File Offset: 0x00451CF1
		// (set) Token: 0x0601EED0 RID: 126672 RVA: 0x00453AF9 File Offset: 0x00451CF9
		public EHasUpgradableVisionType Option { get; set; }

		// Token: 0x0601EED1 RID: 126673 RVA: 0x00453B02 File Offset: 0x00451D02
		public IHasUpgradableVisionT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
			this.Option = EHasUpgradableVisionType.AnyRole;
		}
	}
}
