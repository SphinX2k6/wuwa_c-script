using System;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02004635 RID: 17973
	public class IBaseItemData
	{
		// Token: 0x17005B13 RID: 23315
		// (get) Token: 0x0602D2EC RID: 185068 RVA: 0x00CA34DA File Offset: 0x00CA16DA
		// (set) Token: 0x0602D2ED RID: 185069 RVA: 0x00CA34E2 File Offset: 0x00CA16E2
		public EComposeListType MainType { get; set; }

		// Token: 0x17005B14 RID: 23316
		// (get) Token: 0x0602D2EE RID: 185070 RVA: 0x00CA34EB File Offset: 0x00CA16EB
		// (set) Token: 0x0602D2EF RID: 185071 RVA: 0x00CA34F3 File Offset: 0x00CA16F3
		public int ConfigId { get; set; }

		// Token: 0x17005B15 RID: 23317
		// (get) Token: 0x0602D2F0 RID: 185072 RVA: 0x00CA34FC File Offset: 0x00CA16FC
		// (set) Token: 0x0602D2F1 RID: 185073 RVA: 0x00CA3504 File Offset: 0x00CA1704
		public bool IsNew { get; set; }

		// Token: 0x17005B16 RID: 23318
		// (get) Token: 0x0602D2F2 RID: 185074 RVA: 0x00CA350D File Offset: 0x00CA170D
		// (set) Token: 0x0602D2F3 RID: 185075 RVA: 0x00CA3515 File Offset: 0x00CA1715
		public int Quality { get; set; }

		// Token: 0x17005B17 RID: 23319
		// (get) Token: 0x0602D2F4 RID: 185076 RVA: 0x00CA351E File Offset: 0x00CA171E
		// (set) Token: 0x0602D2F5 RID: 185077 RVA: 0x00CA3526 File Offset: 0x00CA1726
		public double ExistStartTime { get; set; }

		// Token: 0x17005B18 RID: 23320
		// (get) Token: 0x0602D2F6 RID: 185078 RVA: 0x00CA352F File Offset: 0x00CA172F
		// (set) Token: 0x0602D2F7 RID: 185079 RVA: 0x00CA3537 File Offset: 0x00CA1737
		public double ExistEndTime { get; set; }

		// Token: 0x17005B19 RID: 23321
		// (get) Token: 0x0602D2F8 RID: 185080 RVA: 0x00CA3540 File Offset: 0x00CA1740
		// (set) Token: 0x0602D2F9 RID: 185081 RVA: 0x00CA3548 File Offset: 0x00CA1748
		public int MadeCountInLimitTime { get; set; }

		// Token: 0x17005B1A RID: 23322
		// (get) Token: 0x0602D2FA RID: 185082 RVA: 0x00CA3551 File Offset: 0x00CA1751
		// (set) Token: 0x0602D2FB RID: 185083 RVA: 0x00CA3559 File Offset: 0x00CA1759
		public int TotalMakeCountInLimitTime { get; set; }

		// Token: 0x17005B1B RID: 23323
		// (get) Token: 0x0602D2FC RID: 185084 RVA: 0x00CA3562 File Offset: 0x00CA1762
		// (set) Token: 0x0602D2FD RID: 185085 RVA: 0x00CA356A File Offset: 0x00CA176A
		public bool IsLimitForever { get; set; }

		// Token: 0x17005B1C RID: 23324
		// (get) Token: 0x0602D2FE RID: 185086 RVA: 0x00CA3573 File Offset: 0x00CA1773
		// (set) Token: 0x0602D2FF RID: 185087 RVA: 0x00CA357B File Offset: 0x00CA177B
		public int IsUnlock { get; set; }

		// Token: 0x17005B1D RID: 23325
		// (get) Token: 0x0602D300 RID: 185088 RVA: 0x00CA3584 File Offset: 0x00CA1784
		// (set) Token: 0x0602D301 RID: 185089 RVA: 0x00CA358C File Offset: 0x00CA178C
		public int GroupId { get; set; }

		// Token: 0x17005B1E RID: 23326
		// (get) Token: 0x0602D302 RID: 185090 RVA: 0x00CA3595 File Offset: 0x00CA1795
		// (set) Token: 0x0602D303 RID: 185091 RVA: 0x00CA359D File Offset: 0x00CA179D
		public int SortId { get; set; }

		// Token: 0x17005B1F RID: 23327
		// (get) Token: 0x0602D304 RID: 185092 RVA: 0x00CA35A6 File Offset: 0x00CA17A6
		// (set) Token: 0x0602D305 RID: 185093 RVA: 0x00CA35AE File Offset: 0x00CA17AE
		public int ExchangeParam { get; set; }
	}
}
