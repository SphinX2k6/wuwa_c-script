using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AE1 RID: 19169
	public class CookingData : ICookingData, ICookItemData
	{
		// Token: 0x1700602A RID: 24618
		// (get) Token: 0x0602FF30 RID: 196400 RVA: 0x00D61C41 File Offset: 0x00D5FE41
		// (set) Token: 0x0602FF31 RID: 196401 RVA: 0x00D61C49 File Offset: 0x00D5FE49
		public ECookListType MainType { get; set; }

		// Token: 0x1700602B RID: 24619
		// (get) Token: 0x0602FF32 RID: 196402 RVA: 0x00D61C52 File Offset: 0x00D5FE52
		// (set) Token: 0x0602FF33 RID: 196403 RVA: 0x00D61C5A File Offset: 0x00D5FE5A
		public int ItemId { get; set; }

		// Token: 0x1700602C RID: 24620
		// (get) Token: 0x0602FF34 RID: 196404 RVA: 0x00D61C63 File Offset: 0x00D5FE63
		// (set) Token: 0x0602FF35 RID: 196405 RVA: 0x00D61C6B File Offset: 0x00D5FE6B
		public bool IsNew { get; set; }

		// Token: 0x1700602D RID: 24621
		// (get) Token: 0x0602FF36 RID: 196406 RVA: 0x00D61C74 File Offset: 0x00D5FE74
		// (set) Token: 0x0602FF37 RID: 196407 RVA: 0x00D61C7C File Offset: 0x00D5FE7C
		public int Quality { get; set; }

		// Token: 0x1700602E RID: 24622
		// (get) Token: 0x0602FF38 RID: 196408 RVA: 0x00D61C85 File Offset: 0x00D5FE85
		// (set) Token: 0x0602FF39 RID: 196409 RVA: 0x00D61C8D File Offset: 0x00D5FE8D
		public bool IsUnLock { get; set; }

		// Token: 0x1700602F RID: 24623
		// (get) Token: 0x0602FF3A RID: 196410 RVA: 0x00D61C96 File Offset: 0x00D5FE96
		// (set) Token: 0x0602FF3B RID: 196411 RVA: 0x00D61C9E File Offset: 0x00D5FE9E
		public ESubCookDataType SubType { get; set; }

		// Token: 0x17006030 RID: 24624
		// (get) Token: 0x0602FF3C RID: 196412 RVA: 0x00D61CA7 File Offset: 0x00D5FEA7
		// (set) Token: 0x0602FF3D RID: 196413 RVA: 0x00D61CAF File Offset: 0x00D5FEAF
		public int UniqueId { get; set; }

		// Token: 0x17006031 RID: 24625
		// (get) Token: 0x0602FF3E RID: 196414 RVA: 0x00D61CB8 File Offset: 0x00D5FEB8
		// (set) Token: 0x0602FF3F RID: 196415 RVA: 0x00D61CC0 File Offset: 0x00D5FEC0
		public int CookCount { get; set; }

		// Token: 0x17006032 RID: 24626
		// (get) Token: 0x0602FF40 RID: 196416 RVA: 0x00D61CC9 File Offset: 0x00D5FEC9
		// (set) Token: 0x0602FF41 RID: 196417 RVA: 0x00D61CD1 File Offset: 0x00D5FED1
		public int? LastRoleId { get; set; }

		// Token: 0x17006033 RID: 24627
		// (get) Token: 0x0602FF42 RID: 196418 RVA: 0x00D61CDA File Offset: 0x00D5FEDA
		// (set) Token: 0x0602FF43 RID: 196419 RVA: 0x00D61CE2 File Offset: 0x00D5FEE2
		public int IsCook { get; set; }

		// Token: 0x17006034 RID: 24628
		// (get) Token: 0x0602FF44 RID: 196420 RVA: 0x00D61CEB File Offset: 0x00D5FEEB
		// (set) Token: 0x0602FF45 RID: 196421 RVA: 0x00D61CF3 File Offset: 0x00D5FEF3
		public int EffectType { get; set; }

		// Token: 0x17006035 RID: 24629
		// (get) Token: 0x0602FF46 RID: 196422 RVA: 0x00D61CFC File Offset: 0x00D5FEFC
		// (set) Token: 0x0602FF47 RID: 196423 RVA: 0x00D61D04 File Offset: 0x00D5FF04
		public int DataId { get; set; }

		// Token: 0x17006036 RID: 24630
		// (get) Token: 0x0602FF48 RID: 196424 RVA: 0x00D61D0D File Offset: 0x00D5FF0D
		// (set) Token: 0x0602FF49 RID: 196425 RVA: 0x00D61D15 File Offset: 0x00D5FF15
		public int LimitTotalCount { get; set; }

		// Token: 0x17006037 RID: 24631
		// (get) Token: 0x0602FF4A RID: 196426 RVA: 0x00D61D1E File Offset: 0x00D5FF1E
		// (set) Token: 0x0602FF4B RID: 196427 RVA: 0x00D61D26 File Offset: 0x00D5FF26
		public int LimitedCount { get; set; }

		// Token: 0x17006038 RID: 24632
		// (get) Token: 0x0602FF4C RID: 196428 RVA: 0x00D61D2F File Offset: 0x00D5FF2F
		// (set) Token: 0x0602FF4D RID: 196429 RVA: 0x00D61D37 File Offset: 0x00D5FF37
		public double ExistStartTime { get; set; }

		// Token: 0x17006039 RID: 24633
		// (get) Token: 0x0602FF4E RID: 196430 RVA: 0x00D61D40 File Offset: 0x00D5FF40
		// (set) Token: 0x0602FF4F RID: 196431 RVA: 0x00D61D48 File Offset: 0x00D5FF48
		public double ExistEndTime { get; set; }
	}
}
