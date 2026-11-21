using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200510B RID: 20747
	public class RoverlikeRogueLevelLineData : IRoverlikeRogueLevelLineData
	{
		// Token: 0x17006542 RID: 25922
		// (get) Token: 0x06033E68 RID: 212584 RVA: 0x00E8606E File Offset: 0x00E8426E
		// (set) Token: 0x06033E69 RID: 212585 RVA: 0x00E86076 File Offset: 0x00E84276
		public ERoverlikeRoadLayerType LayerType { get; set; } = ERoverlikeRoadLayerType.Normal;

		// Token: 0x17006543 RID: 25923
		// (get) Token: 0x06033E6A RID: 212586 RVA: 0x00E8607F File Offset: 0x00E8427F
		// (set) Token: 0x06033E6B RID: 212587 RVA: 0x00E86087 File Offset: 0x00E84287
		public bool IsCurrent { get; set; }

		// Token: 0x17006544 RID: 25924
		// (get) Token: 0x06033E6C RID: 212588 RVA: 0x00E86090 File Offset: 0x00E84290
		// (set) Token: 0x06033E6D RID: 212589 RVA: 0x00E86098 File Offset: 0x00E84298
		public bool IsPassed { get; set; }

		// Token: 0x17006545 RID: 25925
		// (get) Token: 0x06033E6E RID: 212590 RVA: 0x00E860A1 File Offset: 0x00E842A1
		// (set) Token: 0x06033E6F RID: 212591 RVA: 0x00E860A9 File Offset: 0x00E842A9
		public bool ShowCurrent { get; set; }
	}
}
