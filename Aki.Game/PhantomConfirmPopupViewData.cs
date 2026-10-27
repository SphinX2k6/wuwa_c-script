using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200185D RID: 6237
[NullableContext(2)]
[Nullable(0)]
public class PhantomConfirmPopupViewData : IPhantomConfirmPopupViewData
{
	// Token: 0x17000F3C RID: 3900
	// (get) Token: 0x0600B6D9 RID: 46809 RVA: 0x00295214 File Offset: 0x00293414
	// (set) Token: 0x0600B6DA RID: 46810 RVA: 0x0029521C File Offset: 0x0029341C
	[Nullable(1)]
	public string Title { [NullableContext(1)] get; [NullableContext(1)] set; } = "";

	// Token: 0x17000F3D RID: 3901
	// (get) Token: 0x0600B6DB RID: 46811 RVA: 0x00295225 File Offset: 0x00293425
	// (set) Token: 0x0600B6DC RID: 46812 RVA: 0x0029522D File Offset: 0x0029342D
	[Nullable(1)]
	public string SubTitle { [NullableContext(1)] get; [NullableContext(1)] set; } = "";

	// Token: 0x17000F3E RID: 3902
	// (get) Token: 0x0600B6DD RID: 46813 RVA: 0x00295236 File Offset: 0x00293436
	// (set) Token: 0x0600B6DE RID: 46814 RVA: 0x0029523E File Offset: 0x0029343E
	[Nullable(1)]
	public List<int> PhantomUniqueIdList { [NullableContext(1)] get; [NullableContext(1)] set; } = new List<int>();

	// Token: 0x17000F3F RID: 3903
	// (get) Token: 0x0600B6DF RID: 46815 RVA: 0x00295247 File Offset: 0x00293447
	// (set) Token: 0x0600B6E0 RID: 46816 RVA: 0x0029524F File Offset: 0x0029344F
	public Action OnRight { get; set; }

	// Token: 0x17000F40 RID: 3904
	// (get) Token: 0x0600B6E1 RID: 46817 RVA: 0x00295258 File Offset: 0x00293458
	// (set) Token: 0x0600B6E2 RID: 46818 RVA: 0x00295260 File Offset: 0x00293460
	public Action OnMiddle { get; set; }

	// Token: 0x17000F41 RID: 3905
	// (get) Token: 0x0600B6E3 RID: 46819 RVA: 0x00295269 File Offset: 0x00293469
	// (set) Token: 0x0600B6E4 RID: 46820 RVA: 0x00295271 File Offset: 0x00293471
	public Action OnLeft { get; set; }

	// Token: 0x17000F42 RID: 3906
	// (get) Token: 0x0600B6E5 RID: 46821 RVA: 0x0029527A File Offset: 0x0029347A
	// (set) Token: 0x0600B6E6 RID: 46822 RVA: 0x00295282 File Offset: 0x00293482
	public string MiddleTxtKey { get; set; } = "";

	// Token: 0x17000F43 RID: 3907
	// (get) Token: 0x0600B6E7 RID: 46823 RVA: 0x0029528B File Offset: 0x0029348B
	// (set) Token: 0x0600B6E8 RID: 46824 RVA: 0x00295293 File Offset: 0x00293493
	public string RightTxtKey { get; set; } = "";

	// Token: 0x17000F44 RID: 3908
	// (get) Token: 0x0600B6E9 RID: 46825 RVA: 0x0029529C File Offset: 0x0029349C
	// (set) Token: 0x0600B6EA RID: 46826 RVA: 0x002952A4 File Offset: 0x002934A4
	public string LeftTxtKey { get; set; } = "";
}
