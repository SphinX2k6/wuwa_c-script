using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005032 RID: 20530
	[NullableContext(2)]
	public interface ISolarSpeedTabCellPanelData
	{
		// Token: 0x17006429 RID: 25641
		// (get) Token: 0x06033632 RID: 210482
		// (set) Token: 0x06033633 RID: 210483
		int LevelId { get; set; }

		// Token: 0x1700642A RID: 25642
		// (get) Token: 0x06033634 RID: 210484
		// (set) Token: 0x06033635 RID: 210485
		string RomeNumberPath { get; set; }

		// Token: 0x1700642B RID: 25643
		// (get) Token: 0x06033636 RID: 210486
		// (set) Token: 0x06033637 RID: 210487
		string TitleTextId { get; set; }

		// Token: 0x1700642C RID: 25644
		// (get) Token: 0x06033638 RID: 210488
		// (set) Token: 0x06033639 RID: 210489
		bool IsChosen { get; set; }

		// Token: 0x1700642D RID: 25645
		// (get) Token: 0x0603363A RID: 210490
		// (set) Token: 0x0603363B RID: 210491
		bool IsRedDot { get; set; }
	}
}
