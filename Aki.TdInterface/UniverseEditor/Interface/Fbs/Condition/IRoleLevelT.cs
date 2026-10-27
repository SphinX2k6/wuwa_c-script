using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CB3 RID: 19635
	public class IRoleLevelT
	{
		// Token: 0x17008E95 RID: 36501
		// (get) Token: 0x0601F285 RID: 127621 RVA: 0x00459FAF File Offset: 0x004581AF
		// (set) Token: 0x0601F286 RID: 127622 RVA: 0x00459FB7 File Offset: 0x004581B7
		public EFormationRoleInfoType Type { get; set; }

		// Token: 0x17008E96 RID: 36502
		// (get) Token: 0x0601F287 RID: 127623 RVA: 0x00459FC0 File Offset: 0x004581C0
		// (set) Token: 0x0601F288 RID: 127624 RVA: 0x00459FC8 File Offset: 0x004581C8
		public ISpecifyRoleLevelT Option { get; set; }

		// Token: 0x0601F289 RID: 127625 RVA: 0x00459FD1 File Offset: 0x004581D1
		public IRoleLevelT()
		{
			this.Type = EFormationRoleInfoType.RoleLevel;
			this.Option = null;
		}
	}
}
