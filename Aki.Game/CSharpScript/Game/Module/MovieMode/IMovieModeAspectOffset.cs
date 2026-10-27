using System;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02005383 RID: 21379
	public interface IMovieModeAspectOffset
	{
		// Token: 0x17008381 RID: 33665
		// (get) Token: 0x060369F7 RID: 223735
		// (set) Token: 0x060369F8 RID: 223736
		bool IsFadeIn { get; set; }

		// Token: 0x17008382 RID: 33666
		// (get) Token: 0x060369F9 RID: 223737
		// (set) Token: 0x060369FA RID: 223738
		bool IsWidthBlend { get; set; }

		// Token: 0x17008383 RID: 33667
		// (get) Token: 0x060369FB RID: 223739
		// (set) Token: 0x060369FC RID: 223740
		float Offset { get; set; }

		// Token: 0x17008384 RID: 33668
		// (get) Token: 0x060369FD RID: 223741
		// (set) Token: 0x060369FE RID: 223742
		float Progress { get; set; }
	}
}
