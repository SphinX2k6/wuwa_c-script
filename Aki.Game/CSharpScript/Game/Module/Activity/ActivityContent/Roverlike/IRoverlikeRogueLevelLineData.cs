using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200510A RID: 20746
	public interface IRoverlikeRogueLevelLineData
	{
		// Token: 0x1700653E RID: 25918
		// (get) Token: 0x06033E60 RID: 212576
		// (set) Token: 0x06033E61 RID: 212577
		ERoverlikeRoadLayerType LayerType { get; set; }

		// Token: 0x1700653F RID: 25919
		// (get) Token: 0x06033E62 RID: 212578
		// (set) Token: 0x06033E63 RID: 212579
		bool IsCurrent { get; set; }

		// Token: 0x17006540 RID: 25920
		// (get) Token: 0x06033E64 RID: 212580
		// (set) Token: 0x06033E65 RID: 212581
		bool IsPassed { get; set; }

		// Token: 0x17006541 RID: 25921
		// (get) Token: 0x06033E66 RID: 212582
		// (set) Token: 0x06033E67 RID: 212583
		bool ShowCurrent { get; set; }
	}
}
