using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABE RID: 23230
	public class ITowardEntityConfigT
	{
		// Token: 0x1700AEF3 RID: 44787
		// (get) Token: 0x0602795A RID: 162138 RVA: 0x00571BD7 File Offset: 0x0056FDD7
		// (set) Token: 0x0602795B RID: 162139 RVA: 0x00571BDF File Offset: 0x0056FDDF
		public string ReferenceActorKey { get; set; }

		// Token: 0x1700AEF4 RID: 44788
		// (get) Token: 0x0602795C RID: 162140 RVA: 0x00571BE8 File Offset: 0x0056FDE8
		// (set) Token: 0x0602795D RID: 162141 RVA: 0x00571BF0 File Offset: 0x0056FDF0
		public int TargetEntityId { get; set; }

		// Token: 0x0602795E RID: 162142 RVA: 0x00571BF9 File Offset: 0x0056FDF9
		public ITowardEntityConfigT()
		{
			this.ReferenceActorKey = null;
			this.TargetEntityId = 0;
		}
	}
}
