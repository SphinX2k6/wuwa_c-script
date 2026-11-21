using System;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004366 RID: 17254
	public interface IMovieModeAspectOffset
	{
		// Token: 0x1700574D RID: 22349
		// (get) Token: 0x0602B93D RID: 178493
		// (set) Token: 0x0602B93E RID: 178494
		bool IsFadeIn { get; set; }

		// Token: 0x1700574E RID: 22350
		// (get) Token: 0x0602B93F RID: 178495
		// (set) Token: 0x0602B940 RID: 178496
		bool IsWidthBlend { get; set; }

		// Token: 0x1700574F RID: 22351
		// (get) Token: 0x0602B941 RID: 178497
		// (set) Token: 0x0602B942 RID: 178498
		float Offset { get; set; }

		// Token: 0x17005750 RID: 22352
		// (get) Token: 0x0602B943 RID: 178499
		// (set) Token: 0x0602B944 RID: 178500
		float Progress { get; set; }
	}
}
