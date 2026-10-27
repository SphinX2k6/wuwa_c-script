using System;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DC0 RID: 19904
	public interface IBossChallengeStateVisibility
	{
		// Token: 0x17007EB3 RID: 32435
		// (get) Token: 0x06033623 RID: 210467
		// (set) Token: 0x06033624 RID: 210468
		bool ShowUnlock { get; set; }

		// Token: 0x17007EB4 RID: 32436
		// (get) Token: 0x06033625 RID: 210469
		// (set) Token: 0x06033626 RID: 210470
		bool ShowEmptyIcon { get; set; }

		// Token: 0x17007EB5 RID: 32437
		// (get) Token: 0x06033627 RID: 210471
		// (set) Token: 0x06033628 RID: 210472
		bool ShowFinished { get; set; }
	}
}
