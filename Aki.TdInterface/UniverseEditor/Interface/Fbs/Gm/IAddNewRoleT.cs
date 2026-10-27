using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200463A RID: 17978
	public class IAddNewRoleT
	{
		// Token: 0x17007F94 RID: 32660
		// (get) Token: 0x0601B3B1 RID: 111537 RVA: 0x003E0494 File Offset: 0x003DE694
		// (set) Token: 0x0601B3B2 RID: 111538 RVA: 0x003E049C File Offset: 0x003DE69C
		public EGmCommand Type { get; set; }

		// Token: 0x17007F95 RID: 32661
		// (get) Token: 0x0601B3B3 RID: 111539 RVA: 0x003E04A5 File Offset: 0x003DE6A5
		// (set) Token: 0x0601B3B4 RID: 111540 RVA: 0x003E04AD File Offset: 0x003DE6AD
		public int RoleId { get; set; }

		// Token: 0x0601B3B5 RID: 111541 RVA: 0x003E04B6 File Offset: 0x003DE6B6
		public IAddNewRoleT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.RoleId = 0;
		}
	}
}
