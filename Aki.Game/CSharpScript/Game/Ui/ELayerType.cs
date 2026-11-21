using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003599 RID: 13721
	[Flags]
	public enum ELayerType
	{
		// Token: 0x04013B60 RID: 80736
		HUD = 1,
		// Token: 0x04013B61 RID: 80737
		Normal = 2,
		// Token: 0x04013B62 RID: 80738
		Plot = 4,
		// Token: 0x04013B63 RID: 80739
		ScreenEffect = 8,
		// Token: 0x04013B64 RID: 80740
		NormalMask = 16,
		// Token: 0x04013B65 RID: 80741
		BattleFloat = 32,
		// Token: 0x04013B66 RID: 80742
		Pop = 64,
		// Token: 0x04013B67 RID: 80743
		Float = 128,
		// Token: 0x04013B68 RID: 80744
		Guide = 256,
		// Token: 0x04013B69 RID: 80745
		Loading = 512,
		// Token: 0x04013B6A RID: 80746
		MovieBlack = 1024,
		// Token: 0x04013B6B RID: 80747
		NetWork = 2048,
		// Token: 0x04013B6C RID: 80748
		CG = 4096,
		// Token: 0x04013B6D RID: 80749
		Mask = 8192,
		// Token: 0x04013B6E RID: 80750
		WaterMask = 16384,
		// Token: 0x04013B6F RID: 80751
		Pool = 32768,
		// Token: 0x04013B70 RID: 80752
		Debug = 65536
	}
}
