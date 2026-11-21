using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BDF RID: 31711
	public class IToggleAndHighlightItemT
	{
		// Token: 0x1700ED8A RID: 60810
		// (get) Token: 0x06039282 RID: 234114 RVA: 0x007B929A File Offset: 0x007B749A
		// (set) Token: 0x06039283 RID: 234115 RVA: 0x007B92A2 File Offset: 0x007B74A2
		public EHighlightExploreSkillIconType Type { get; set; }

		// Token: 0x1700ED8B RID: 60811
		// (get) Token: 0x06039284 RID: 234116 RVA: 0x007B92AB File Offset: 0x007B74AB
		// (set) Token: 0x06039285 RID: 234117 RVA: 0x007B92B3 File Offset: 0x007B74B3
		public EHighlightType HighlightType { get; set; }

		// Token: 0x1700ED8C RID: 60812
		// (get) Token: 0x06039286 RID: 234118 RVA: 0x007B92BC File Offset: 0x007B74BC
		// (set) Token: 0x06039287 RID: 234119 RVA: 0x007B92C4 File Offset: 0x007B74C4
		public int ItemId { get; set; }

		// Token: 0x1700ED8D RID: 60813
		// (get) Token: 0x06039288 RID: 234120 RVA: 0x007B92CD File Offset: 0x007B74CD
		// (set) Token: 0x06039289 RID: 234121 RVA: 0x007B92D5 File Offset: 0x007B74D5
		public int SkillType { get; set; }

		// Token: 0x1700ED8E RID: 60814
		// (get) Token: 0x0603928A RID: 234122 RVA: 0x007B92DE File Offset: 0x007B74DE
		// (set) Token: 0x0603928B RID: 234123 RVA: 0x007B92E6 File Offset: 0x007B74E6
		public bool IsShowTips { get; set; }

		// Token: 0x1700ED8F RID: 60815
		// (get) Token: 0x0603928C RID: 234124 RVA: 0x007B92EF File Offset: 0x007B74EF
		// (set) Token: 0x0603928D RID: 234125 RVA: 0x007B92F7 File Offset: 0x007B74F7
		public bool IsSwitchBack { get; set; }

		// Token: 0x1700ED90 RID: 60816
		// (get) Token: 0x0603928E RID: 234126 RVA: 0x007B9300 File Offset: 0x007B7500
		// (set) Token: 0x0603928F RID: 234127 RVA: 0x007B9308 File Offset: 0x007B7508
		public byte NullMask { get; set; }

		// Token: 0x06039290 RID: 234128 RVA: 0x007B9311 File Offset: 0x007B7511
		public IToggleAndHighlightItemT()
		{
			this.Type = EHighlightExploreSkillIconType.Show;
			this.HighlightType = EHighlightType.CommonWhite;
			this.ItemId = 0;
			this.SkillType = 0;
			this.IsShowTips = false;
			this.IsSwitchBack = false;
			this.NullMask = 0;
		}
	}
}
