using System;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02004637 RID: 17975
	public class IStructureData : IBaseItemData
	{
		// Token: 0x17005B25 RID: 23333
		// (get) Token: 0x0602D312 RID: 185106 RVA: 0x00CA361C File Offset: 0x00CA181C
		// (set) Token: 0x0602D313 RID: 185107 RVA: 0x00CA3624 File Offset: 0x00CA1824
		public ESubStructureDataType SubType { get; set; }

		// Token: 0x17005B26 RID: 23334
		// (get) Token: 0x0602D314 RID: 185108 RVA: 0x00CA362D File Offset: 0x00CA182D
		// (set) Token: 0x0602D315 RID: 185109 RVA: 0x00CA3635 File Offset: 0x00CA1835
		public int StructureCount { get; set; }

		// Token: 0x17005B27 RID: 23335
		// (get) Token: 0x0602D316 RID: 185110 RVA: 0x00CA363E File Offset: 0x00CA183E
		// (set) Token: 0x0602D317 RID: 185111 RVA: 0x00CA3646 File Offset: 0x00CA1846
		public int LastRoleId { get; set; }
	}
}
