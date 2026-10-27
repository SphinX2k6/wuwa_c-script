using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004668 RID: 18024
	[Flags]
	public enum ELayerType
	{
		// Token: 0x040194B9 RID: 103609
		HUD = 1,
		// Token: 0x040194BA RID: 103610
		Normal = 2,
		// Token: 0x040194BB RID: 103611
		Plot = 4,
		// Token: 0x040194BC RID: 103612
		ScreenEffect = 8,
		// Token: 0x040194BD RID: 103613
		NormalMask = 16,
		// Token: 0x040194BE RID: 103614
		BattleFloat = 32,
		// Token: 0x040194BF RID: 103615
		Pop = 64,
		// Token: 0x040194C0 RID: 103616
		Float = 128,
		// Token: 0x040194C1 RID: 103617
		Guide = 256,
		// Token: 0x040194C2 RID: 103618
		Loading = 512,
		// Token: 0x040194C3 RID: 103619
		MovieBlack = 1024,
		// Token: 0x040194C4 RID: 103620
		NetWork = 2048,
		// Token: 0x040194C5 RID: 103621
		CG = 4096,
		// Token: 0x040194C6 RID: 103622
		Mask = 8192,
		// Token: 0x040194C7 RID: 103623
		WaterMask = 16384,
		// Token: 0x040194C8 RID: 103624
		Pool = 32768,
		// Token: 0x040194C9 RID: 103625
		Debug = 65536
	}
}
