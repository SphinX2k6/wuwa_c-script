using System;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x020046FF RID: 18175
	public interface IWallFrame
	{
		// Token: 0x1700768E RID: 30350
		// (get) Token: 0x0602F823 RID: 194595
		// (set) Token: 0x0602F824 RID: 194596
		int WallNormalX { get; set; }

		// Token: 0x1700768F RID: 30351
		// (get) Token: 0x0602F825 RID: 194597
		// (set) Token: 0x0602F826 RID: 194598
		int WallNormalY { get; set; }

		// Token: 0x17007690 RID: 30352
		// (get) Token: 0x0602F827 RID: 194599
		// (set) Token: 0x0602F828 RID: 194600
		int WallTangentX { get; set; }

		// Token: 0x17007691 RID: 30353
		// (get) Token: 0x0602F829 RID: 194601
		// (set) Token: 0x0602F82A RID: 194602
		int WallTangentY { get; set; }

		// Token: 0x17007692 RID: 30354
		// (get) Token: 0x0602F82B RID: 194603
		// (set) Token: 0x0602F82C RID: 194604
		int OwnerSign { get; set; }

		// Token: 0x17007693 RID: 30355
		// (get) Token: 0x0602F82D RID: 194605
		// (set) Token: 0x0602F82E RID: 194606
		float OwnerOffsetX { get; set; }

		// Token: 0x17007694 RID: 30356
		// (get) Token: 0x0602F82F RID: 194607
		// (set) Token: 0x0602F830 RID: 194608
		float OwnerOffsetY { get; set; }
	}
}
