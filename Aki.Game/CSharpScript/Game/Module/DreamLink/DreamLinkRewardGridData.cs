using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AA0 RID: 23200
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkRewardGridData : IDreamLinkRewardGridData
	{
		// Token: 0x17008C10 RID: 35856
		// (get) Token: 0x0603AC39 RID: 240697 RVA: 0x00DFF16E File Offset: 0x00DFD36E
		// (set) Token: 0x0603AC3A RID: 240698 RVA: 0x00DFF176 File Offset: 0x00DFD376
		public int RewardId { get; set; }

		// Token: 0x17008C11 RID: 35857
		// (get) Token: 0x0603AC3B RID: 240699 RVA: 0x00DFF17F File Offset: 0x00DFD37F
		// (set) Token: 0x0603AC3C RID: 240700 RVA: 0x00DFF187 File Offset: 0x00DFD387
		public TItem Item { get; set; }

		// Token: 0x17008C12 RID: 35858
		// (get) Token: 0x0603AC3D RID: 240701 RVA: 0x00DFF190 File Offset: 0x00DFD390
		// (set) Token: 0x0603AC3E RID: 240702 RVA: 0x00DFF198 File Offset: 0x00DFD398
		public EActivityTaskState Status { get; set; }

		// Token: 0x17008C13 RID: 35859
		// (get) Token: 0x0603AC3F RID: 240703 RVA: 0x00DFF1A1 File Offset: 0x00DFD3A1
		// (set) Token: 0x0603AC40 RID: 240704 RVA: 0x00DFF1A9 File Offset: 0x00DFD3A9
		public Action ReceiveDelegate { get; set; }
	}
}
