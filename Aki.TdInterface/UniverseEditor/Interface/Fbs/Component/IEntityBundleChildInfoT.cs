using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056CE RID: 22222
	public class IEntityBundleChildInfoT
	{
		// Token: 0x17009FF0 RID: 40944
		// (get) Token: 0x060239C0 RID: 145856 RVA: 0x004E5722 File Offset: 0x004E3922
		// (set) Token: 0x060239C1 RID: 145857 RVA: 0x004E572A File Offset: 0x004E392A
		public bool IsDisable { get; set; }

		// Token: 0x17009FF1 RID: 40945
		// (get) Token: 0x060239C2 RID: 145858 RVA: 0x004E5733 File Offset: 0x004E3933
		// (set) Token: 0x060239C3 RID: 145859 RVA: 0x004E573B File Offset: 0x004E393B
		public int ChildId { get; set; }

		// Token: 0x17009FF2 RID: 40946
		// (get) Token: 0x060239C4 RID: 145860 RVA: 0x004E5744 File Offset: 0x004E3944
		// (set) Token: 0x060239C5 RID: 145861 RVA: 0x004E574C File Offset: 0x004E394C
		public int EntityId { get; set; }

		// Token: 0x060239C6 RID: 145862 RVA: 0x004E5755 File Offset: 0x004E3955
		public IEntityBundleChildInfoT()
		{
			this.IsDisable = false;
			this.ChildId = 0;
			this.EntityId = 0;
		}
	}
}
