using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A5 RID: 30117
	public class IVisualNovelPerformanceEnterT
	{
		// Token: 0x1700E474 RID: 58484
		// (get) Token: 0x06036CEC RID: 224492 RVA: 0x00770AE5 File Offset: 0x0076ECE5
		// (set) Token: 0x06036CED RID: 224493 RVA: 0x00770AED File Offset: 0x0076ECED
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E475 RID: 58485
		// (get) Token: 0x06036CEE RID: 224494 RVA: 0x00770AF6 File Offset: 0x0076ECF6
		// (set) Token: 0x06036CEF RID: 224495 RVA: 0x00770AFE File Offset: 0x0076ECFE
		public float StartTime { get; set; }

		// Token: 0x1700E476 RID: 58486
		// (get) Token: 0x06036CF0 RID: 224496 RVA: 0x00770B07 File Offset: 0x0076ED07
		// (set) Token: 0x06036CF1 RID: 224497 RVA: 0x00770B0F File Offset: 0x0076ED0F
		public int WhoId { get; set; }

		// Token: 0x1700E477 RID: 58487
		// (get) Token: 0x06036CF2 RID: 224498 RVA: 0x00770B18 File Offset: 0x0076ED18
		// (set) Token: 0x06036CF3 RID: 224499 RVA: 0x00770B20 File Offset: 0x0076ED20
		public IVisualNovelPortraitTransformT Transform { get; set; }

		// Token: 0x1700E478 RID: 58488
		// (get) Token: 0x06036CF4 RID: 224500 RVA: 0x00770B29 File Offset: 0x0076ED29
		// (set) Token: 0x06036CF5 RID: 224501 RVA: 0x00770B31 File Offset: 0x0076ED31
		public float FadeInTime { get; set; }

		// Token: 0x1700E479 RID: 58489
		// (get) Token: 0x06036CF6 RID: 224502 RVA: 0x00770B3A File Offset: 0x0076ED3A
		// (set) Token: 0x06036CF7 RID: 224503 RVA: 0x00770B42 File Offset: 0x0076ED42
		public IVisualNovelRoleConfigT RoleConfig { get; set; }

		// Token: 0x1700E47A RID: 58490
		// (get) Token: 0x06036CF8 RID: 224504 RVA: 0x00770B4B File Offset: 0x0076ED4B
		// (set) Token: 0x06036CF9 RID: 224505 RVA: 0x00770B53 File Offset: 0x0076ED53
		public byte NullMask { get; set; }

		// Token: 0x06036CFA RID: 224506 RVA: 0x00770B5C File Offset: 0x0076ED5C
		public IVisualNovelPerformanceEnterT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.WhoId = 0;
			this.Transform = null;
			this.FadeInTime = 0f;
			this.RoleConfig = null;
			this.NullMask = 0;
		}
	}
}
