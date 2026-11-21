using System;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200436E RID: 17262
	public interface IUiLayerSafeZone
	{
		// Token: 0x17005763 RID: 22371
		// (get) Token: 0x0602B96C RID: 178540
		// (set) Token: 0x0602B96D RID: 178541
		float StretchLeft { get; set; }

		// Token: 0x17005764 RID: 22372
		// (get) Token: 0x0602B96E RID: 178542
		// (set) Token: 0x0602B96F RID: 178543
		float StretchRight { get; set; }

		// Token: 0x17005765 RID: 22373
		// (get) Token: 0x0602B970 RID: 178544
		// (set) Token: 0x0602B971 RID: 178545
		float StretchTop { get; set; }

		// Token: 0x17005766 RID: 22374
		// (get) Token: 0x0602B972 RID: 178546
		// (set) Token: 0x0602B973 RID: 178547
		float StretchBottom { get; set; }
	}
}
