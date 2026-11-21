using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005836 RID: 22582
	public class IFoxJumpPositionOnPathDrivenSpawnedActorT
	{
		// Token: 0x1700A380 RID: 41856
		// (get) Token: 0x060248F9 RID: 149753 RVA: 0x005060BF File Offset: 0x005042BF
		// (set) Token: 0x060248FA RID: 149754 RVA: 0x005060C7 File Offset: 0x005042C7
		public EFoxJumpInteractPointRelationType Type { get; set; }

		// Token: 0x1700A381 RID: 41857
		// (get) Token: 0x060248FB RID: 149755 RVA: 0x005060D0 File Offset: 0x005042D0
		// (set) Token: 0x060248FC RID: 149756 RVA: 0x005060D8 File Offset: 0x005042D8
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700A382 RID: 41858
		// (get) Token: 0x060248FD RID: 149757 RVA: 0x005060E1 File Offset: 0x005042E1
		// (set) Token: 0x060248FE RID: 149758 RVA: 0x005060E9 File Offset: 0x005042E9
		public IVectorInfoT RaycastDestOffset { get; set; }

		// Token: 0x1700A383 RID: 41859
		// (get) Token: 0x060248FF RID: 149759 RVA: 0x005060F2 File Offset: 0x005042F2
		// (set) Token: 0x06024900 RID: 149760 RVA: 0x005060FA File Offset: 0x005042FA
		public IFoxJumpShapeAndPointsParamsT BottomParams { get; set; }

		// Token: 0x1700A384 RID: 41860
		// (get) Token: 0x06024901 RID: 149761 RVA: 0x00506103 File Offset: 0x00504303
		// (set) Token: 0x06024902 RID: 149762 RVA: 0x0050610B File Offset: 0x0050430B
		public int BottomRangeSplineEntityId { get; set; }

		// Token: 0x1700A385 RID: 41861
		// (get) Token: 0x06024903 RID: 149763 RVA: 0x00506114 File Offset: 0x00504314
		// (set) Token: 0x06024904 RID: 149764 RVA: 0x0050611C File Offset: 0x0050431C
		public IFoxJumpShapeAndPointsParamsT TopParams { get; set; }

		// Token: 0x1700A386 RID: 41862
		// (get) Token: 0x06024905 RID: 149765 RVA: 0x00506125 File Offset: 0x00504325
		// (set) Token: 0x06024906 RID: 149766 RVA: 0x0050612D File Offset: 0x0050432D
		public IBoxTriggerShapeT HollowShape { get; set; }

		// Token: 0x1700A387 RID: 41863
		// (get) Token: 0x06024907 RID: 149767 RVA: 0x00506136 File Offset: 0x00504336
		// (set) Token: 0x06024908 RID: 149768 RVA: 0x0050613E File Offset: 0x0050433E
		public byte NullMask { get; set; }

		// Token: 0x06024909 RID: 149769 RVA: 0x00506147 File Offset: 0x00504347
		public IFoxJumpPositionOnPathDrivenSpawnedActorT()
		{
			this.Type = EFoxJumpInteractPointRelationType.ThisEntity;
			this.Offset = null;
			this.RaycastDestOffset = null;
			this.BottomParams = null;
			this.BottomRangeSplineEntityId = 0;
			this.TopParams = null;
			this.HollowShape = null;
			this.NullMask = 0;
		}
	}
}
