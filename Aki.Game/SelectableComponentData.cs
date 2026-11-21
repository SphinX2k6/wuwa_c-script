using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E14 RID: 3604
[NullableContext(2)]
[Nullable(0)]
public class SelectableComponentData
{
	// Token: 0x17000FF2 RID: 4082
	// (get) Token: 0x0600916A RID: 37226 RVA: 0x002B886A File Offset: 0x002B6A6A
	// (set) Token: 0x0600916B RID: 37227 RVA: 0x002B8872 File Offset: 0x002B6A72
	public bool IsSingleSelected { get; set; }

	// Token: 0x17000FF3 RID: 4083
	// (get) Token: 0x0600916C RID: 37228 RVA: 0x002B887B File Offset: 0x002B6A7B
	// (set) Token: 0x0600916D RID: 37229 RVA: 0x002B8883 File Offset: 0x002B6A83
	public bool IsNumSelectable { get; set; } = true;

	// Token: 0x17000FF4 RID: 4084
	// (get) Token: 0x0600916E RID: 37230 RVA: 0x002B888C File Offset: 0x002B6A8C
	// (set) Token: 0x0600916F RID: 37231 RVA: 0x002B8894 File Offset: 0x002B6A94
	public int MaxSelectedGridNum { get; set; } = 20;

	// Token: 0x17000FF5 RID: 4085
	// (get) Token: 0x06009170 RID: 37232 RVA: 0x002B889D File Offset: 0x002B6A9D
	// (set) Token: 0x06009171 RID: 37233 RVA: 0x002B88A5 File Offset: 0x002B6AA5
	public bool OnlyGold { get; set; }

	// Token: 0x17000FF6 RID: 4086
	// (get) Token: 0x06009172 RID: 37234 RVA: 0x002B88AE File Offset: 0x002B6AAE
	// (set) Token: 0x06009173 RID: 37235 RVA: 0x002B88B6 File Offset: 0x002B6AB6
	public bool IsSelectFrameFollowClick { get; set; }

	// Token: 0x17000FF7 RID: 4087
	// (get) Token: 0x06009174 RID: 37236 RVA: 0x002B88BF File Offset: 0x002B6ABF
	// (set) Token: 0x06009175 RID: 37237 RVA: 0x002B88C7 File Offset: 0x002B6AC7
	public bool SuitActive { get; set; }

	// Token: 0x17000FF8 RID: 4088
	// (get) Token: 0x06009176 RID: 37238 RVA: 0x002B88D0 File Offset: 0x002B6AD0
	// (set) Token: 0x06009177 RID: 37239 RVA: 0x002B88D8 File Offset: 0x002B6AD8
	public bool IsNeedSort { get; set; } = true;

	// Token: 0x04005626 RID: 22054
	public ISelectedData FirstOpenOperationData;

	// Token: 0x04005627 RID: 22055
	public Action OtherFunction;

	// Token: 0x04005628 RID: 22056
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<object> OnPropItemFunction;

	// Token: 0x04005629 RID: 22057
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public Action<List<ISelectedData>, SelectableExpData> OnChangeSelectedFunction;

	// Token: 0x0400562A RID: 22058
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Func<List<ISelectedData>, int, int, int, bool> CheckIfCanAddFunction;
}
