using System;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x0200565F RID: 22111
	public class IBaseItemData
	{
		// Token: 0x1700874C RID: 34636
		// (get) Token: 0x060383EE RID: 230382 RVA: 0x00D5555A File Offset: 0x00D5375A
		// (set) Token: 0x060383EF RID: 230383 RVA: 0x00D55562 File Offset: 0x00D53762
		public EComposeListType MainType { get; set; }

		// Token: 0x1700874D RID: 34637
		// (get) Token: 0x060383F0 RID: 230384 RVA: 0x00D5556B File Offset: 0x00D5376B
		// (set) Token: 0x060383F1 RID: 230385 RVA: 0x00D55573 File Offset: 0x00D53773
		public int ConfigId { get; set; }

		// Token: 0x1700874E RID: 34638
		// (get) Token: 0x060383F2 RID: 230386 RVA: 0x00D5557C File Offset: 0x00D5377C
		// (set) Token: 0x060383F3 RID: 230387 RVA: 0x00D55584 File Offset: 0x00D53784
		public bool IsNew { get; set; }

		// Token: 0x1700874F RID: 34639
		// (get) Token: 0x060383F4 RID: 230388 RVA: 0x00D5558D File Offset: 0x00D5378D
		// (set) Token: 0x060383F5 RID: 230389 RVA: 0x00D55595 File Offset: 0x00D53795
		public int Quality { get; set; }

		// Token: 0x17008750 RID: 34640
		// (get) Token: 0x060383F6 RID: 230390 RVA: 0x00D5559E File Offset: 0x00D5379E
		// (set) Token: 0x060383F7 RID: 230391 RVA: 0x00D555A6 File Offset: 0x00D537A6
		public double ExistStartTime { get; set; }

		// Token: 0x17008751 RID: 34641
		// (get) Token: 0x060383F8 RID: 230392 RVA: 0x00D555AF File Offset: 0x00D537AF
		// (set) Token: 0x060383F9 RID: 230393 RVA: 0x00D555B7 File Offset: 0x00D537B7
		public double ExistEndTime { get; set; }

		// Token: 0x17008752 RID: 34642
		// (get) Token: 0x060383FA RID: 230394 RVA: 0x00D555C0 File Offset: 0x00D537C0
		// (set) Token: 0x060383FB RID: 230395 RVA: 0x00D555C8 File Offset: 0x00D537C8
		public int MadeCountInLimitTime { get; set; }

		// Token: 0x17008753 RID: 34643
		// (get) Token: 0x060383FC RID: 230396 RVA: 0x00D555D1 File Offset: 0x00D537D1
		// (set) Token: 0x060383FD RID: 230397 RVA: 0x00D555D9 File Offset: 0x00D537D9
		public int TotalMakeCountInLimitTime { get; set; }

		// Token: 0x17008754 RID: 34644
		// (get) Token: 0x060383FE RID: 230398 RVA: 0x00D555E2 File Offset: 0x00D537E2
		// (set) Token: 0x060383FF RID: 230399 RVA: 0x00D555EA File Offset: 0x00D537EA
		public bool IsLimitForever { get; set; }

		// Token: 0x17008755 RID: 34645
		// (get) Token: 0x06038400 RID: 230400 RVA: 0x00D555F3 File Offset: 0x00D537F3
		// (set) Token: 0x06038401 RID: 230401 RVA: 0x00D555FB File Offset: 0x00D537FB
		public int IsUnlock { get; set; }

		// Token: 0x17008756 RID: 34646
		// (get) Token: 0x06038402 RID: 230402 RVA: 0x00D55604 File Offset: 0x00D53804
		// (set) Token: 0x06038403 RID: 230403 RVA: 0x00D5560C File Offset: 0x00D5380C
		public int GroupId { get; set; }

		// Token: 0x17008757 RID: 34647
		// (get) Token: 0x06038404 RID: 230404 RVA: 0x00D55615 File Offset: 0x00D53815
		// (set) Token: 0x06038405 RID: 230405 RVA: 0x00D5561D File Offset: 0x00D5381D
		public int SortId { get; set; }

		// Token: 0x17008758 RID: 34648
		// (get) Token: 0x06038406 RID: 230406 RVA: 0x00D55626 File Offset: 0x00D53826
		// (set) Token: 0x06038407 RID: 230407 RVA: 0x00D5562E File Offset: 0x00D5382E
		public int ExchangeParam { get; set; }
	}
}
