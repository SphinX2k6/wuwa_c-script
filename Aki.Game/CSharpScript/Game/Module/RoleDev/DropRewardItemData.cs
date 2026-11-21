using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C74 RID: 15476
	public class DropRewardItemData : IDropRewardItemData
	{
		// Token: 0x170050E2 RID: 20706
		// (get) Token: 0x0602796B RID: 162155 RVA: 0x00B19F75 File Offset: 0x00B18175
		// (set) Token: 0x0602796C RID: 162156 RVA: 0x00B19F7D File Offset: 0x00B1817D
		public int ItemId { get; set; }

		// Token: 0x170050E3 RID: 20707
		// (get) Token: 0x0602796D RID: 162157 RVA: 0x00B19F86 File Offset: 0x00B18186
		// (set) Token: 0x0602796E RID: 162158 RVA: 0x00B19F8E File Offset: 0x00B1818E
		public int Count { get; set; }

		// Token: 0x170050E4 RID: 20708
		// (get) Token: 0x0602796F RID: 162159 RVA: 0x00B19F97 File Offset: 0x00B18197
		// (set) Token: 0x06027970 RID: 162160 RVA: 0x00B19F9F File Offset: 0x00B1819F
		public bool HaveFinish { get; set; }
	}
}
