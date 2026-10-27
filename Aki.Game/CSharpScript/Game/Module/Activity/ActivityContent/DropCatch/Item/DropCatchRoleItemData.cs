using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066EC RID: 26348
	public class DropCatchRoleItemData : IDropCatchRoleItemData
	{
		// Token: 0x17009654 RID: 38484
		// (get) Token: 0x06041D64 RID: 269668 RVA: 0x00FF74ED File Offset: 0x00FF56ED
		// (set) Token: 0x06041D65 RID: 269669 RVA: 0x00FF74F5 File Offset: 0x00FF56F5
		public int RoleCfgId { get; set; }

		// Token: 0x17009655 RID: 38485
		// (get) Token: 0x06041D66 RID: 269670 RVA: 0x00FF74FE File Offset: 0x00FF56FE
		// (set) Token: 0x06041D67 RID: 269671 RVA: 0x00FF7506 File Offset: 0x00FF5706
		public int BookCfgId { get; set; }

		// Token: 0x17009656 RID: 38486
		// (get) Token: 0x06041D68 RID: 269672 RVA: 0x00FF750F File Offset: 0x00FF570F
		// (set) Token: 0x06041D69 RID: 269673 RVA: 0x00FF7517 File Offset: 0x00FF5717
		public bool IsUnlock { get; set; }
	}
}
