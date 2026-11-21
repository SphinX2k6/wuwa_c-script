using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006836 RID: 26678
	public class IAvgPlayRoleActionItemT
	{
		// Token: 0x1700C427 RID: 50215
		// (get) Token: 0x0602D981 RID: 186753 RVA: 0x0063D23E File Offset: 0x0063B43E
		// (set) Token: 0x0602D982 RID: 186754 RVA: 0x0063D246 File Offset: 0x0063B446
		public EAvgPlayRoleActionType ActionType { get; set; }

		// Token: 0x1700C428 RID: 50216
		// (get) Token: 0x0602D983 RID: 186755 RVA: 0x0063D24F File Offset: 0x0063B44F
		// (set) Token: 0x0602D984 RID: 186756 RVA: 0x0063D257 File Offset: 0x0063B457
		public int RoleId { get; set; }

		// Token: 0x1700C429 RID: 50217
		// (get) Token: 0x0602D985 RID: 186757 RVA: 0x0063D260 File Offset: 0x0063B460
		// (set) Token: 0x0602D986 RID: 186758 RVA: 0x0063D268 File Offset: 0x0063B468
		public EAvgRolePosition PositionConfig { get; set; }

		// Token: 0x1700C42A RID: 50218
		// (get) Token: 0x0602D987 RID: 186759 RVA: 0x0063D271 File Offset: 0x0063B471
		// (set) Token: 0x0602D988 RID: 186760 RVA: 0x0063D279 File Offset: 0x0063B479
		public EAvgRoleAnimationType AnimationType { get; set; }

		// Token: 0x1700C42B RID: 50219
		// (get) Token: 0x0602D989 RID: 186761 RVA: 0x0063D282 File Offset: 0x0063B482
		// (set) Token: 0x0602D98A RID: 186762 RVA: 0x0063D28A File Offset: 0x0063B48A
		public bool IsAnimationLoop { get; set; }

		// Token: 0x1700C42C RID: 50220
		// (get) Token: 0x0602D98B RID: 186763 RVA: 0x0063D293 File Offset: 0x0063B493
		// (set) Token: 0x0602D98C RID: 186764 RVA: 0x0063D29B File Offset: 0x0063B49B
		public EAvgVisualEffect VisualEffect { get; set; }

		// Token: 0x1700C42D RID: 50221
		// (get) Token: 0x0602D98D RID: 186765 RVA: 0x0063D2A4 File Offset: 0x0063B4A4
		// (set) Token: 0x0602D98E RID: 186766 RVA: 0x0063D2AC File Offset: 0x0063B4AC
		public byte NullMask { get; set; }

		// Token: 0x0602D98F RID: 186767 RVA: 0x0063D2B5 File Offset: 0x0063B4B5
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
