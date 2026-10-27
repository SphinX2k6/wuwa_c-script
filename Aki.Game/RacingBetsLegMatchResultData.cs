using System;
using System.Runtime.CompilerServices;

// Token: 0x020026F3 RID: 9971
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsLegMatchResultData : IRacingBetsLegMatchResultData
{
	// Token: 0x17001A9E RID: 6814
	// (get) Token: 0x06014713 RID: 83731 RVA: 0x0052B9CA File Offset: 0x00529BCA
	// (set) Token: 0x06014714 RID: 83732 RVA: 0x0052B9D2 File Offset: 0x00529BD2
	public int DangoId { get; set; }

	// Token: 0x17001A9F RID: 6815
	// (get) Token: 0x06014715 RID: 83733 RVA: 0x0052B9DB File Offset: 0x00529BDB
	// (set) Token: 0x06014716 RID: 83734 RVA: 0x0052B9E3 File Offset: 0x00529BE3
	public int Rank { get; set; }

	// Token: 0x17001AA0 RID: 6816
	// (get) Token: 0x06014717 RID: 83735 RVA: 0x0052B9EC File Offset: 0x00529BEC
	// (set) Token: 0x06014718 RID: 83736 RVA: 0x0052B9F4 File Offset: 0x00529BF4
	public bool HasAdvanced { get; set; }

	// Token: 0x17001AA1 RID: 6817
	// (get) Token: 0x06014719 RID: 83737 RVA: 0x0052B9FD File Offset: 0x00529BFD
	// (set) Token: 0x0601471A RID: 83738 RVA: 0x0052BA05 File Offset: 0x00529C05
	public ERacingBetsLegMatchType LegMatchType { get; set; }

	// Token: 0x17001AA2 RID: 6818
	// (get) Token: 0x0601471B RID: 83739 RVA: 0x0052BA0E File Offset: 0x00529C0E
	// (set) Token: 0x0601471C RID: 83740 RVA: 0x0052BA16 File Offset: 0x00529C16
	public bool IsChampion { get; set; }

	// Token: 0x17001AA3 RID: 6819
	// (get) Token: 0x0601471D RID: 83741 RVA: 0x0052BA1F File Offset: 0x00529C1F
	// (set) Token: 0x0601471E RID: 83742 RVA: 0x0052BA27 File Offset: 0x00529C27
	public ERacingBetsLegMatchResultType ResultShowType { get; set; }

	// Token: 0x17001AA4 RID: 6820
	// (get) Token: 0x0601471F RID: 83743 RVA: 0x0052BA30 File Offset: 0x00529C30
	// (set) Token: 0x06014720 RID: 83744 RVA: 0x0052BA38 File Offset: 0x00529C38
	public string AdvancedNextMatchName { get; set; }

	// Token: 0x17001AA5 RID: 6821
	// (get) Token: 0x06014721 RID: 83745 RVA: 0x0052BA41 File Offset: 0x00529C41
	// (set) Token: 0x06014722 RID: 83746 RVA: 0x0052BA49 File Offset: 0x00529C49
	public string LoserNextMatchName { get; set; }
}
