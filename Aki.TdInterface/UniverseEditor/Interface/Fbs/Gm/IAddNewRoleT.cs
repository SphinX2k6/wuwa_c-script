using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AA2 RID: 19106
	public class IAddNewRoleT
	{
		// Token: 0x170085D5 RID: 34261
		// (get) Token: 0x0601CB86 RID: 117638 RVA: 0x0040C730 File Offset: 0x0040A930
		// (set) Token: 0x0601CB87 RID: 117639 RVA: 0x0040C738 File Offset: 0x0040A938
		public EGmCommand Type { get; set; }

		// Token: 0x170085D6 RID: 34262
		// (get) Token: 0x0601CB88 RID: 117640 RVA: 0x0040C741 File Offset: 0x0040A941
		// (set) Token: 0x0601CB89 RID: 117641 RVA: 0x0040C749 File Offset: 0x0040A949
		public int RoleId { get; set; }

		// Token: 0x0601CB8A RID: 117642 RVA: 0x0040C752 File Offset: 0x0040A952
		public IAddNewRoleT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.RoleId = 0;
		}
	}
}
