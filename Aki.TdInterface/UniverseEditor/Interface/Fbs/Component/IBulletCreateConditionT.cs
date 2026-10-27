using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F3B RID: 20283
	public class IBulletCreateConditionT
	{
		// Token: 0x17009232 RID: 37426
		// (get) Token: 0x060201C9 RID: 131529 RVA: 0x00477B70 File Offset: 0x00475D70
		// (set) Token: 0x060201CA RID: 131530 RVA: 0x00477B78 File Offset: 0x00475D78
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x17009233 RID: 37427
		// (get) Token: 0x060201CB RID: 131531 RVA: 0x00477B81 File Offset: 0x00475D81
		// (set) Token: 0x060201CC RID: 131532 RVA: 0x00477B89 File Offset: 0x00475D89
		public long BulletId { get; set; }

		// Token: 0x060201CD RID: 131533 RVA: 0x00477B92 File Offset: 0x00475D92
		public IBulletCreateConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
		}
	}
}
