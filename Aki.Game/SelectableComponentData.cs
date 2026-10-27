using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001957 RID: 6487
[NullableContext(2)]
[Nullable(0)]
public class SelectableComponentData
{
	// Token: 0x17000FCE RID: 4046
	// (get) Token: 0x0600BD67 RID: 48487 RVA: 0x002ADA26 File Offset: 0x002ABC26
	// (set) Token: 0x0600BD68 RID: 48488 RVA: 0x002ADA2E File Offset: 0x002ABC2E
	public bool IsSingleSelected { get; set; }

	// Token: 0x17000FCF RID: 4047
	// (get) Token: 0x0600BD69 RID: 48489 RVA: 0x002ADA37 File Offset: 0x002ABC37
	// (set) Token: 0x0600BD6A RID: 48490 RVA: 0x002ADA3F File Offset: 0x002ABC3F
	public bool IsNumSelectable { get; set; } = true;

	// Token: 0x17000FD0 RID: 4048
	// (get) Token: 0x0600BD6B RID: 48491 RVA: 0x002ADA48 File Offset: 0x002ABC48
	// (set) Token: 0x0600BD6C RID: 48492 RVA: 0x002ADA50 File Offset: 0x002ABC50
	public int MaxSelectedGridNum { get; set; } = 20;

	// Token: 0x17000FD1 RID: 4049
	// (get) Token: 0x0600BD6D RID: 48493 RVA: 0x002ADA59 File Offset: 0x002ABC59
	// (set) Token: 0x0600BD6E RID: 48494 RVA: 0x002ADA61 File Offset: 0x002ABC61
	public bool OnlyGold { get; set; }

	// Token: 0x17000FD2 RID: 4050
	// (get) Token: 0x0600BD6F RID: 48495 RVA: 0x002ADA6A File Offset: 0x002ABC6A
	// (set) Token: 0x0600BD70 RID: 48496 RVA: 0x002ADA72 File Offset: 0x002ABC72
	public bool IsSelectFrameFollowClick { get; set; }

	// Token: 0x17000FD3 RID: 4051
	// (get) Token: 0x0600BD71 RID: 48497 RVA: 0x002ADA7B File Offset: 0x002ABC7B
	// (set) Token: 0x0600BD72 RID: 48498 RVA: 0x002ADA83 File Offset: 0x002ABC83
	public bool SuitActive { get; set; }

	// Token: 0x17000FD4 RID: 4052
	// (get) Token: 0x0600BD73 RID: 48499 RVA: 0x002ADA8C File Offset: 0x002ABC8C
	// (set) Token: 0x0600BD74 RID: 48500 RVA: 0x002ADA94 File Offset: 0x002ABC94
	public bool IsNeedSort { get; set; } = true;

	// Token: 0x04005579 RID: 21881
	public ISelectedData FirstOpenOperationData;

	// Token: 0x0400557A RID: 21882
	public Action OtherFunction;

	// Token: 0x0400557B RID: 21883
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<object> OnPropItemFunction;

	// Token: 0x0400557C RID: 21884
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public Action<List<ISelectedData>, SelectableExpData> OnChangeSelectedFunction;

	// Token: 0x0400557D RID: 21885
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Func<List<ISelectedData>, int, int, int, bool> CheckIfCanAddFunction;
}
