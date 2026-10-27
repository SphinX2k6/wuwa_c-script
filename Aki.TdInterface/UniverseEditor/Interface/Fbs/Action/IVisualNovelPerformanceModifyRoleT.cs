using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B1 RID: 30129
	public class IVisualNovelPerformanceModifyRoleT
	{
		// Token: 0x1700E4A9 RID: 58537
		// (get) Token: 0x06036D8E RID: 224654 RVA: 0x00772113 File Offset: 0x00770313
		// (set) Token: 0x06036D8F RID: 224655 RVA: 0x0077211B File Offset: 0x0077031B
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E4AA RID: 58538
		// (get) Token: 0x06036D90 RID: 224656 RVA: 0x00772124 File Offset: 0x00770324
		// (set) Token: 0x06036D91 RID: 224657 RVA: 0x0077212C File Offset: 0x0077032C
		public float StartTime { get; set; }

		// Token: 0x1700E4AB RID: 58539
		// (get) Token: 0x06036D92 RID: 224658 RVA: 0x00772135 File Offset: 0x00770335
		// (set) Token: 0x06036D93 RID: 224659 RVA: 0x0077213D File Offset: 0x0077033D
		public int WhoId { get; set; }

		// Token: 0x1700E4AC RID: 58540
		// (get) Token: 0x06036D94 RID: 224660 RVA: 0x00772146 File Offset: 0x00770346
		// (set) Token: 0x06036D95 RID: 224661 RVA: 0x0077214E File Offset: 0x0077034E
		public IVisualNovelPortraitTransformT Transform { get; set; }

		// Token: 0x1700E4AD RID: 58541
		// (get) Token: 0x06036D96 RID: 224662 RVA: 0x00772157 File Offset: 0x00770357
		// (set) Token: 0x06036D97 RID: 224663 RVA: 0x0077215F File Offset: 0x0077035F
		public IVisualNovelRoleConfigT RoleConfig { get; set; }

		// Token: 0x1700E4AE RID: 58542
		// (get) Token: 0x06036D98 RID: 224664 RVA: 0x00772168 File Offset: 0x00770368
		// (set) Token: 0x06036D99 RID: 224665 RVA: 0x00772170 File Offset: 0x00770370
		public byte NullMask { get; set; }

		// Token: 0x06036D9A RID: 224666 RVA: 0x00772179 File Offset: 0x00770379
		public IVisualNovelPerformanceModifyRoleT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.WhoId = 0;
			this.Transform = null;
			this.RoleConfig = null;
			this.NullMask = 0;
		}
	}
}
