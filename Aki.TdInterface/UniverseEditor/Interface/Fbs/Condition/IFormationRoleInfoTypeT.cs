using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200511C RID: 20764
	public class IFormationRoleInfoTypeT
	{
		// Token: 0x170094D0 RID: 38096
		// (get) Token: 0x06020A53 RID: 133715 RVA: 0x00486606 File Offset: 0x00484806
		// (set) Token: 0x06020A54 RID: 133716 RVA: 0x0048660E File Offset: 0x0048480E
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x06020A55 RID: 133717 RVA: 0x00486617 File Offset: 0x00484817
		public IFormationRoleInfoTypeT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
		}
	}
}
