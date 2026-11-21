using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D16 RID: 3350
[NullableContext(2)]
[Nullable(0)]
public class PhantomConfirmPopupViewData : IPhantomConfirmPopupViewData
{
	// Token: 0x17000F5F RID: 3935
	// (get) Token: 0x06008AC2 RID: 35522 RVA: 0x0029F93B File Offset: 0x0029DB3B
	// (set) Token: 0x06008AC3 RID: 35523 RVA: 0x0029F943 File Offset: 0x0029DB43
	[Nullable(1)]
	public string Title { [NullableContext(1)] get; [NullableContext(1)] set; } = "";

	// Token: 0x17000F60 RID: 3936
	// (get) Token: 0x06008AC4 RID: 35524 RVA: 0x0029F94C File Offset: 0x0029DB4C
	// (set) Token: 0x06008AC5 RID: 35525 RVA: 0x0029F954 File Offset: 0x0029DB54
	[Nullable(1)]
	public string SubTitle { [NullableContext(1)] get; [NullableContext(1)] set; } = "";

	// Token: 0x17000F61 RID: 3937
	// (get) Token: 0x06008AC6 RID: 35526 RVA: 0x0029F95D File Offset: 0x0029DB5D
	// (set) Token: 0x06008AC7 RID: 35527 RVA: 0x0029F965 File Offset: 0x0029DB65
	[Nullable(1)]
	public List<int> PhantomUniqueIdList { [NullableContext(1)] get; [NullableContext(1)] set; } = new List<int>();

	// Token: 0x17000F62 RID: 3938
	// (get) Token: 0x06008AC8 RID: 35528 RVA: 0x0029F96E File Offset: 0x0029DB6E
	// (set) Token: 0x06008AC9 RID: 35529 RVA: 0x0029F976 File Offset: 0x0029DB76
	public Action OnRight { get; set; }

	// Token: 0x17000F63 RID: 3939
	// (get) Token: 0x06008ACA RID: 35530 RVA: 0x0029F97F File Offset: 0x0029DB7F
	// (set) Token: 0x06008ACB RID: 35531 RVA: 0x0029F987 File Offset: 0x0029DB87
	public Action OnMiddle { get; set; }

	// Token: 0x17000F64 RID: 3940
	// (get) Token: 0x06008ACC RID: 35532 RVA: 0x0029F990 File Offset: 0x0029DB90
	// (set) Token: 0x06008ACD RID: 35533 RVA: 0x0029F998 File Offset: 0x0029DB98
	public Action OnLeft { get; set; }

	// Token: 0x17000F65 RID: 3941
	// (get) Token: 0x06008ACE RID: 35534 RVA: 0x0029F9A1 File Offset: 0x0029DBA1
	// (set) Token: 0x06008ACF RID: 35535 RVA: 0x0029F9A9 File Offset: 0x0029DBA9
	public string MiddleTxtKey { get; set; } = "";

	// Token: 0x17000F66 RID: 3942
	// (get) Token: 0x06008AD0 RID: 35536 RVA: 0x0029F9B2 File Offset: 0x0029DBB2
	// (set) Token: 0x06008AD1 RID: 35537 RVA: 0x0029F9BA File Offset: 0x0029DBBA
	public string RightTxtKey { get; set; } = "";

	// Token: 0x17000F67 RID: 3943
	// (get) Token: 0x06008AD2 RID: 35538 RVA: 0x0029F9C3 File Offset: 0x0029DBC3
	// (set) Token: 0x06008AD3 RID: 35539 RVA: 0x0029F9CB File Offset: 0x0029DBCB
	public string LeftTxtKey { get; set; } = "";
}
