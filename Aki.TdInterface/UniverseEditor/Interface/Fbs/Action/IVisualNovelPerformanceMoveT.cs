using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B4 RID: 30132
	public class IVisualNovelPerformanceMoveT
	{
		// Token: 0x1700E4B8 RID: 58552
		// (get) Token: 0x06036DBC RID: 224700 RVA: 0x00772894 File Offset: 0x00770A94
		// (set) Token: 0x06036DBD RID: 224701 RVA: 0x0077289C File Offset: 0x00770A9C
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E4B9 RID: 58553
		// (get) Token: 0x06036DBE RID: 224702 RVA: 0x007728A5 File Offset: 0x00770AA5
		// (set) Token: 0x06036DBF RID: 224703 RVA: 0x007728AD File Offset: 0x00770AAD
		public float StartTime { get; set; }

		// Token: 0x1700E4BA RID: 58554
		// (get) Token: 0x06036DC0 RID: 224704 RVA: 0x007728B6 File Offset: 0x00770AB6
		// (set) Token: 0x06036DC1 RID: 224705 RVA: 0x007728BE File Offset: 0x00770ABE
		public int WhoId { get; set; }

		// Token: 0x1700E4BB RID: 58555
		// (get) Token: 0x06036DC2 RID: 224706 RVA: 0x007728C7 File Offset: 0x00770AC7
		// (set) Token: 0x06036DC3 RID: 224707 RVA: 0x007728CF File Offset: 0x00770ACF
		public IVisualNovelPortraitTransformT Transform { get; set; }

		// Token: 0x1700E4BC RID: 58556
		// (get) Token: 0x06036DC4 RID: 224708 RVA: 0x007728D8 File Offset: 0x00770AD8
		// (set) Token: 0x06036DC5 RID: 224709 RVA: 0x007728E0 File Offset: 0x00770AE0
		public TEaseCurveTypeUnion EaseCurve { get; set; }

		// Token: 0x1700E4BD RID: 58557
		// (get) Token: 0x06036DC6 RID: 224710 RVA: 0x007728E9 File Offset: 0x00770AE9
		// (set) Token: 0x06036DC7 RID: 224711 RVA: 0x007728F1 File Offset: 0x00770AF1
		public float Duration { get; set; }

		// Token: 0x1700E4BE RID: 58558
		// (get) Token: 0x06036DC8 RID: 224712 RVA: 0x007728FA File Offset: 0x00770AFA
		// (set) Token: 0x06036DC9 RID: 224713 RVA: 0x00772902 File Offset: 0x00770B02
		public IVisualNovelRoleConfigT RoleConfig { get; set; }

		// Token: 0x1700E4BF RID: 58559
		// (get) Token: 0x06036DCA RID: 224714 RVA: 0x0077290B File Offset: 0x00770B0B
		// (set) Token: 0x06036DCB RID: 224715 RVA: 0x00772913 File Offset: 0x00770B13
		public byte NullMask { get; set; }

		// Token: 0x06036DCC RID: 224716 RVA: 0x0077291C File Offset: 0x00770B1C
		public IVisualNovelPerformanceMoveT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.WhoId = 0;
			this.Transform = null;
			this.EaseCurve = null;
			this.Duration = 0f;
			this.RoleConfig = null;
			this.NullMask = 0;
		}
	}
}
