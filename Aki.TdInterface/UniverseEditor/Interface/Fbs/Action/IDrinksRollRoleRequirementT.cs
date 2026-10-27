using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006610 RID: 26128
	public class IDrinksRollRoleRequirementT
	{
		// Token: 0x1700C223 RID: 49699
		// (get) Token: 0x0602D5E9 RID: 185833 RVA: 0x00637936 File Offset: 0x00635B36
		// (set) Token: 0x0602D5EA RID: 185834 RVA: 0x0063793E File Offset: 0x00635B3E
		public int RoleId { get; set; }

		// Token: 0x1700C224 RID: 49700
		// (get) Token: 0x0602D5EB RID: 185835 RVA: 0x00637947 File Offset: 0x00635B47
		// (set) Token: 0x0602D5EC RID: 185836 RVA: 0x0063794F File Offset: 0x00635B4F
		public int RequirementId { get; set; }

		// Token: 0x1700C225 RID: 49701
		// (get) Token: 0x0602D5ED RID: 185837 RVA: 0x00637958 File Offset: 0x00635B58
		// (set) Token: 0x0602D5EE RID: 185838 RVA: 0x00637960 File Offset: 0x00635B60
		public byte NullMask { get; set; }

		// Token: 0x0602D5EF RID: 185839 RVA: 0x00637969 File Offset: 0x00635B69
		public IDrinksRollRoleRequirementT()
		{
			this.RoleId = 0;
			this.RequirementId = 0;
			this.NullMask = 0;
		}
	}
}
