using System;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200362F RID: 13871
	public interface IWallFrame
	{
		// Token: 0x1700494A RID: 18762
		// (get) Token: 0x06023FE9 RID: 147433
		// (set) Token: 0x06023FEA RID: 147434
		int WallNormalX { get; set; }

		// Token: 0x1700494B RID: 18763
		// (get) Token: 0x06023FEB RID: 147435
		// (set) Token: 0x06023FEC RID: 147436
		int WallNormalY { get; set; }

		// Token: 0x1700494C RID: 18764
		// (get) Token: 0x06023FED RID: 147437
		// (set) Token: 0x06023FEE RID: 147438
		int WallTangentX { get; set; }

		// Token: 0x1700494D RID: 18765
		// (get) Token: 0x06023FEF RID: 147439
		// (set) Token: 0x06023FF0 RID: 147440
		int WallTangentY { get; set; }

		// Token: 0x1700494E RID: 18766
		// (get) Token: 0x06023FF1 RID: 147441
		// (set) Token: 0x06023FF2 RID: 147442
		int OwnerSign { get; set; }

		// Token: 0x1700494F RID: 18767
		// (get) Token: 0x06023FF3 RID: 147443
		// (set) Token: 0x06023FF4 RID: 147444
		float OwnerOffsetX { get; set; }

		// Token: 0x17004950 RID: 18768
		// (get) Token: 0x06023FF5 RID: 147445
		// (set) Token: 0x06023FF6 RID: 147446
		float OwnerOffsetY { get; set; }
	}
}
