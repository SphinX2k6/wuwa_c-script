using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061C8 RID: 25032
	public class IAvgPlayRoleActionItemT
	{
		// Token: 0x1700BAA4 RID: 47780
		// (get) Token: 0x0602B23A RID: 176698 RVA: 0x005F27CA File Offset: 0x005F09CA
		// (set) Token: 0x0602B23B RID: 176699 RVA: 0x005F27D2 File Offset: 0x005F09D2
		public EAvgPlayRoleActionType ActionType { get; set; }

		// Token: 0x1700BAA5 RID: 47781
		// (get) Token: 0x0602B23C RID: 176700 RVA: 0x005F27DB File Offset: 0x005F09DB
		// (set) Token: 0x0602B23D RID: 176701 RVA: 0x005F27E3 File Offset: 0x005F09E3
		public int RoleId { get; set; }

		// Token: 0x1700BAA6 RID: 47782
		// (get) Token: 0x0602B23E RID: 176702 RVA: 0x005F27EC File Offset: 0x005F09EC
		// (set) Token: 0x0602B23F RID: 176703 RVA: 0x005F27F4 File Offset: 0x005F09F4
		public EAvgRolePosition PositionConfig { get; set; }

		// Token: 0x1700BAA7 RID: 47783
		// (get) Token: 0x0602B240 RID: 176704 RVA: 0x005F27FD File Offset: 0x005F09FD
		// (set) Token: 0x0602B241 RID: 176705 RVA: 0x005F2805 File Offset: 0x005F0A05
		public EAvgRoleAnimationType AnimationType { get; set; }

		// Token: 0x1700BAA8 RID: 47784
		// (get) Token: 0x0602B242 RID: 176706 RVA: 0x005F280E File Offset: 0x005F0A0E
		// (set) Token: 0x0602B243 RID: 176707 RVA: 0x005F2816 File Offset: 0x005F0A16
		public bool IsAnimationLoop { get; set; }

		// Token: 0x1700BAA9 RID: 47785
		// (get) Token: 0x0602B244 RID: 176708 RVA: 0x005F281F File Offset: 0x005F0A1F
		// (set) Token: 0x0602B245 RID: 176709 RVA: 0x005F2827 File Offset: 0x005F0A27
		public EAvgVisualEffect VisualEffect { get; set; }

		// Token: 0x1700BAAA RID: 47786
		// (get) Token: 0x0602B246 RID: 176710 RVA: 0x005F2830 File Offset: 0x005F0A30
		// (set) Token: 0x0602B247 RID: 176711 RVA: 0x005F2838 File Offset: 0x005F0A38
		public byte NullMask { get; set; }

		// Token: 0x0602B248 RID: 176712 RVA: 0x005F2841 File Offset: 0x005F0A41
		public IAvgPlayRoleActionItemT()
		{
			this.ActionType = EAvgPlayRoleActionType.Enter;
			this.RoleId = 0;
			this.PositionConfig = EAvgRolePosition.Center;
			this.AnimationType = EAvgRoleAnimationType.Idle;
			this.IsAnimationLoop = false;
			this.VisualEffect = EAvgVisualEffect.Default;
			this.NullMask = 0;
		}
	}
}
