using System;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D89 RID: 15753
	public interface IBossChallengeStateVisibility
	{
		// Token: 0x17005263 RID: 21091
		// (get) Token: 0x06028490 RID: 165008
		// (set) Token: 0x06028491 RID: 165009
		bool ShowUnlock { get; set; }

		// Token: 0x17005264 RID: 21092
		// (get) Token: 0x06028492 RID: 165010
		// (set) Token: 0x06028493 RID: 165011
		bool ShowEmptyIcon { get; set; }

		// Token: 0x17005265 RID: 21093
		// (get) Token: 0x06028494 RID: 165012
		// (set) Token: 0x06028495 RID: 165013
		bool ShowFinished { get; set; }
	}
}
