using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078AC RID: 30892
	public class IShowHighlightExploreSkillIconT
	{
		// Token: 0x1700E29A RID: 58010
		// (get) Token: 0x060365BD RID: 222653 RVA: 0x00747324 File Offset: 0x00745524
		// (set) Token: 0x060365BE RID: 222654 RVA: 0x0074732C File Offset: 0x0074552C
		public EHighlightExploreSkillIconType Type { get; set; }

		// Token: 0x1700E29B RID: 58011
		// (get) Token: 0x060365BF RID: 222655 RVA: 0x00747335 File Offset: 0x00745535
		// (set) Token: 0x060365C0 RID: 222656 RVA: 0x0074733D File Offset: 0x0074553D
		public EHighlightType HighlightType { get; set; }

		// Token: 0x1700E29C RID: 58012
		// (get) Token: 0x060365C1 RID: 222657 RVA: 0x00747346 File Offset: 0x00745546
		// (set) Token: 0x060365C2 RID: 222658 RVA: 0x0074734E File Offset: 0x0074554E
		public int SkillType { get; set; }

		// Token: 0x1700E29D RID: 58013
		// (get) Token: 0x060365C3 RID: 222659 RVA: 0x00747357 File Offset: 0x00745557
		// (set) Token: 0x060365C4 RID: 222660 RVA: 0x0074735F File Offset: 0x0074555F
		public float Duration { get; set; }

		// Token: 0x1700E29E RID: 58014
		// (get) Token: 0x060365C5 RID: 222661 RVA: 0x00747368 File Offset: 0x00745568
		// (set) Token: 0x060365C6 RID: 222662 RVA: 0x00747370 File Offset: 0x00745570
		public bool IsSwitchBack { get; set; }

		// Token: 0x1700E29F RID: 58015
		// (get) Token: 0x060365C7 RID: 222663 RVA: 0x00747379 File Offset: 0x00745579
		// (set) Token: 0x060365C8 RID: 222664 RVA: 0x00747381 File Offset: 0x00745581
		public byte NullMask { get; set; }

		// Token: 0x060365C9 RID: 222665 RVA: 0x0074738A File Offset: 0x0074558A
		public IShowHighlightExploreSkillIconT()
		{
			this.Type = EHighlightExploreSkillIconType.Show;
			this.HighlightType = EHighlightType.CommonWhite;
			this.SkillType = 0;
			this.Duration = 0f;
			this.IsSwitchBack = false;
			this.NullMask = 0;
		}
	}
}
