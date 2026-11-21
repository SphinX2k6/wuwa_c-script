using System;

namespace CSharpScript.Game.LevelFlow
{
	// Token: 0x020060EA RID: 24810
	public class LevelFlowTransitionToSplineParam
	{
		// Token: 0x170070A2 RID: 28834
		// (get) Token: 0x0603B7BC RID: 243644 RVA: 0x010D6B4C File Offset: 0x010D4D4C
		// (set) Token: 0x0603B7BD RID: 243645 RVA: 0x010D6B54 File Offset: 0x010D4D54
		public int EntityId { get; set; }

		// Token: 0x170070A3 RID: 28835
		// (get) Token: 0x0603B7BE RID: 243646 RVA: 0x010D6B5D File Offset: 0x010D4D5D
		// (set) Token: 0x0603B7BF RID: 243647 RVA: 0x010D6B65 File Offset: 0x010D4D65
		public int SplineId { get; set; }

		// Token: 0x170070A4 RID: 28836
		// (get) Token: 0x0603B7C0 RID: 243648 RVA: 0x010D6B6E File Offset: 0x010D4D6E
		// (set) Token: 0x0603B7C1 RID: 243649 RVA: 0x010D6B76 File Offset: 0x010D4D76
		public bool SnapToWall { get; set; }

		// Token: 0x170070A5 RID: 28837
		// (get) Token: 0x0603B7C2 RID: 243650 RVA: 0x010D6B7F File Offset: 0x010D4D7F
		// (set) Token: 0x0603B7C3 RID: 243651 RVA: 0x010D6B87 File Offset: 0x010D4D87
		public bool NeedSync { get; set; }

		// Token: 0x170070A6 RID: 28838
		// (get) Token: 0x0603B7C4 RID: 243652 RVA: 0x010D6B90 File Offset: 0x010D4D90
		// (set) Token: 0x0603B7C5 RID: 243653 RVA: 0x010D6B98 File Offset: 0x010D4D98
		public bool SimulateRotation { get; set; }

		// Token: 0x170070A7 RID: 28839
		// (get) Token: 0x0603B7C6 RID: 243654 RVA: 0x010D6BA1 File Offset: 0x010D4DA1
		// (set) Token: 0x0603B7C7 RID: 243655 RVA: 0x010D6BA9 File Offset: 0x010D4DA9
		public bool KeepForward { get; set; }

		// Token: 0x170070A8 RID: 28840
		// (get) Token: 0x0603B7C8 RID: 243656 RVA: 0x010D6BB2 File Offset: 0x010D4DB2
		// (set) Token: 0x0603B7C9 RID: 243657 RVA: 0x010D6BBA File Offset: 0x010D4DBA
		public float Speed { get; set; }
	}
}
