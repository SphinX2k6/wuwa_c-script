using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051AC RID: 20908
	public class IRoleLevelT
	{
		// Token: 0x170095C3 RID: 38339
		// (get) Token: 0x06020EA7 RID: 134823 RVA: 0x0048DAFF File Offset: 0x0048BCFF
		// (set) Token: 0x06020EA8 RID: 134824 RVA: 0x0048DB07 File Offset: 0x0048BD07
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x170095C4 RID: 38340
		// (get) Token: 0x06020EA9 RID: 134825 RVA: 0x0048DB10 File Offset: 0x0048BD10
		// (set) Token: 0x06020EAA RID: 134826 RVA: 0x0048DB18 File Offset: 0x0048BD18
		public ISpecifyRoleLevelT Option { get; set; }

		// Token: 0x06020EAB RID: 134827 RVA: 0x0048DB21 File Offset: 0x0048BD21
		public IRoleLevelT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
			this.Option = null;
		}
	}
}
