using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C81 RID: 27777
	public class IDrinksRollRoleRequirementT
	{
		// Token: 0x1700CBC1 RID: 52161
		// (get) Token: 0x0602FDBA RID: 196026 RVA: 0x0068449E File Offset: 0x0068269E
		// (set) Token: 0x0602FDBB RID: 196027 RVA: 0x006844A6 File Offset: 0x006826A6
		public int RoleId { get; set; }

		// Token: 0x1700CBC2 RID: 52162
		// (get) Token: 0x0602FDBC RID: 196028 RVA: 0x006844AF File Offset: 0x006826AF
		// (set) Token: 0x0602FDBD RID: 196029 RVA: 0x006844B7 File Offset: 0x006826B7
		public int RequirementId { get; set; }

		// Token: 0x1700CBC3 RID: 52163
		// (get) Token: 0x0602FDBE RID: 196030 RVA: 0x006844C0 File Offset: 0x006826C0
		// (set) Token: 0x0602FDBF RID: 196031 RVA: 0x006844C8 File Offset: 0x006826C8
		public byte NullMask { get; set; }

		// Token: 0x0602FDC0 RID: 196032 RVA: 0x006844D1 File Offset: 0x006826D1
		public IDrinksRollRoleRequirementT()
		{
			this.RoleId = 0;
			this.RequirementId = 0;
			this.NullMask = 0;
		}
	}
}
