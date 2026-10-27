using System;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02005661 RID: 22113
	public class IStructureData : IBaseItemData
	{
		// Token: 0x1700875E RID: 34654
		// (get) Token: 0x06038414 RID: 230420 RVA: 0x00D5569C File Offset: 0x00D5389C
		// (set) Token: 0x06038415 RID: 230421 RVA: 0x00D556A4 File Offset: 0x00D538A4
		public ESubStructureDataType SubType { get; set; }

		// Token: 0x1700875F RID: 34655
		// (get) Token: 0x06038416 RID: 230422 RVA: 0x00D556AD File Offset: 0x00D538AD
		// (set) Token: 0x06038417 RID: 230423 RVA: 0x00D556B5 File Offset: 0x00D538B5
		public int StructureCount { get; set; }

		// Token: 0x17008760 RID: 34656
		// (get) Token: 0x06038418 RID: 230424 RVA: 0x00D556BE File Offset: 0x00D538BE
		// (set) Token: 0x06038419 RID: 230425 RVA: 0x00D556C6 File Offset: 0x00D538C6
		public int LastRoleId { get; set; }
	}
}
