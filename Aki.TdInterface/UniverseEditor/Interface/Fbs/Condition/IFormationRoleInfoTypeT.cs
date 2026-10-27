using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C29 RID: 19497
	public class IFormationRoleInfoTypeT
	{
		// Token: 0x17008DA7 RID: 36263
		// (get) Token: 0x0601EE4F RID: 126543 RVA: 0x00452D2A File Offset: 0x00450F2A
		// (set) Token: 0x0601EE50 RID: 126544 RVA: 0x00452D32 File Offset: 0x00450F32
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x0601EE51 RID: 126545 RVA: 0x00452D3B File Offset: 0x00450F3B
		public IFormationRoleInfoTypeT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
		}
	}
}
