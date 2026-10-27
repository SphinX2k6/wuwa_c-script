using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200618D RID: 24973
	public class RoverlikeRogueLevelLineData : IRoverlikeRogueLevelLineData
	{
		// Token: 0x170091E0 RID: 37344
		// (get) Token: 0x0603F1A8 RID: 258472 RVA: 0x00F3F1A6 File Offset: 0x00F3D3A6
		// (set) Token: 0x0603F1A9 RID: 258473 RVA: 0x00F3F1AE File Offset: 0x00F3D3AE
		public ERoverlikeRoadLayerType LayerType { get; set; } = ERoverlikeRoadLayerType.Normal;

		// Token: 0x170091E1 RID: 37345
		// (get) Token: 0x0603F1AA RID: 258474 RVA: 0x00F3F1B7 File Offset: 0x00F3D3B7
		// (set) Token: 0x0603F1AB RID: 258475 RVA: 0x00F3F1BF File Offset: 0x00F3D3BF
		public bool IsCurrent { get; set; }

		// Token: 0x170091E2 RID: 37346
		// (get) Token: 0x0603F1AC RID: 258476 RVA: 0x00F3F1C8 File Offset: 0x00F3D3C8
		// (set) Token: 0x0603F1AD RID: 258477 RVA: 0x00F3F1D0 File Offset: 0x00F3D3D0
		public bool IsPassed { get; set; }

		// Token: 0x170091E3 RID: 37347
		// (get) Token: 0x0603F1AE RID: 258478 RVA: 0x00F3F1D9 File Offset: 0x00F3D3D9
		// (set) Token: 0x0603F1AF RID: 258479 RVA: 0x00F3F1E1 File Offset: 0x00F3D3E1
		public bool ShowCurrent { get; set; }
	}
}
