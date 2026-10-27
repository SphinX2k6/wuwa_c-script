using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu
{
	// Token: 0x020047E6 RID: 18406
	[NullableContext(1)]
	public interface ITrackMenuItemData
	{
		// Token: 0x170078C1 RID: 30913
		// (get) Token: 0x0603035D RID: 197469
		// (set) Token: 0x0603035E RID: 197470
		string Icon { get; set; }

		// Token: 0x170078C2 RID: 30914
		// (get) Token: 0x0603035F RID: 197471
		// (set) Token: 0x06030360 RID: 197472
		string Title { get; set; }

		// Token: 0x170078C3 RID: 30915
		// (get) Token: 0x06030361 RID: 197473
		// (set) Token: 0x06030362 RID: 197474
		string StateIcon { get; set; }

		// Token: 0x170078C4 RID: 30916
		// (get) Token: 0x06030363 RID: 197475
		// (set) Token: 0x06030364 RID: 197476
		bool IsPlayerSelf { get; set; }

		// Token: 0x170078C5 RID: 30917
		// (get) Token: 0x06030365 RID: 197477
		// (set) Token: 0x06030366 RID: 197478
		MarkItem MarkItem { get; set; }
	}
}
