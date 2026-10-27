using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060B4 RID: 24756
	[NullableContext(2)]
	public interface ISolarSpeedTabCellPanelData
	{
		// Token: 0x170090C7 RID: 37063
		// (get) Token: 0x0603E96E RID: 256366
		// (set) Token: 0x0603E96F RID: 256367
		int LevelId { get; set; }

		// Token: 0x170090C8 RID: 37064
		// (get) Token: 0x0603E970 RID: 256368
		// (set) Token: 0x0603E971 RID: 256369
		string RomeNumberPath { get; set; }

		// Token: 0x170090C9 RID: 37065
		// (get) Token: 0x0603E972 RID: 256370
		// (set) Token: 0x0603E973 RID: 256371
		string TitleTextId { get; set; }

		// Token: 0x170090CA RID: 37066
		// (get) Token: 0x0603E974 RID: 256372
		// (set) Token: 0x0603E975 RID: 256373
		bool IsChosen { get; set; }

		// Token: 0x170090CB RID: 37067
		// (get) Token: 0x0603E976 RID: 256374
		// (set) Token: 0x0603E977 RID: 256375
		bool IsRedDot { get; set; }
	}
}
