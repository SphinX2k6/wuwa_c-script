using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200618C RID: 24972
	public interface IRoverlikeRogueLevelLineData
	{
		// Token: 0x170091DC RID: 37340
		// (get) Token: 0x0603F1A0 RID: 258464
		// (set) Token: 0x0603F1A1 RID: 258465
		ERoverlikeRoadLayerType LayerType { get; set; }

		// Token: 0x170091DD RID: 37341
		// (get) Token: 0x0603F1A2 RID: 258466
		// (set) Token: 0x0603F1A3 RID: 258467
		bool IsCurrent { get; set; }

		// Token: 0x170091DE RID: 37342
		// (get) Token: 0x0603F1A4 RID: 258468
		// (set) Token: 0x0603F1A5 RID: 258469
		bool IsPassed { get; set; }

		// Token: 0x170091DF RID: 37343
		// (get) Token: 0x0603F1A6 RID: 258470
		// (set) Token: 0x0603F1A7 RID: 258471
		bool ShowCurrent { get; set; }
	}
}
