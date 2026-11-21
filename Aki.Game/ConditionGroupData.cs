using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000B37 RID: 2871
[NullableContext(1)]
[Nullable(0)]
public class ConditionGroupData : UiPopViewData, IViewOpenParamMultipleView
{
	// Token: 0x17000DE5 RID: 3557
	// (get) Token: 0x060076D1 RID: 30417 RVA: 0x0024A2F1 File Offset: 0x002484F1
	// (set) Token: 0x060076D2 RID: 30418 RVA: 0x0024A2F9 File Offset: 0x002484F9
	public bool IsMultipleView { get; set; }

	// Token: 0x060076D3 RID: 30419 RVA: 0x0024A302 File Offset: 0x00248502
	public ConditionGroupData(int conditionGroupId, List<IActivityConditionData> dataList, [Nullable(2)] string titleId = "", bool isPreOpen = false)
	{
		this.ConditionGroupId = conditionGroupId;
		this.DataList = dataList;
		this.TitleId = titleId;
		this.IsPreOpen = isPreOpen;
		this.DataList.Sort(new Comparison<IActivityConditionData>(this.SortConditionData));
	}

	// Token: 0x17000DE6 RID: 3558
	// (get) Token: 0x060076D4 RID: 30420 RVA: 0x0024A33E File Offset: 0x0024853E
	// (set) Token: 0x060076D5 RID: 30421 RVA: 0x0024A346 File Offset: 0x00248546
	public int ConditionGroupId { get; set; }

	// Token: 0x17000DE7 RID: 3559
	// (get) Token: 0x060076D6 RID: 30422 RVA: 0x0024A34F File Offset: 0x0024854F
	// (set) Token: 0x060076D7 RID: 30423 RVA: 0x0024A357 File Offset: 0x00248557
	public List<IActivityConditionData> DataList { get; set; }

	// Token: 0x17000DE8 RID: 3560
	// (get) Token: 0x060076D8 RID: 30424 RVA: 0x0024A360 File Offset: 0x00248560
	// (set) Token: 0x060076D9 RID: 30425 RVA: 0x0024A368 File Offset: 0x00248568
	[Nullable(2)]
	public string TitleId { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000DE9 RID: 3561
	// (get) Token: 0x060076DA RID: 30426 RVA: 0x0024A371 File Offset: 0x00248571
	// (set) Token: 0x060076DB RID: 30427 RVA: 0x0024A379 File Offset: 0x00248579
	public bool IsPreOpen { get; set; }

	// Token: 0x060076DC RID: 30428 RVA: 0x0024A384 File Offset: 0x00248584
	private int SortConditionData(IActivityConditionData a, IActivityConditionData b)
	{
		int num = (a.IsFinished > false) ? 1 : 0;
		int num2 = (b.IsFinished > false) ? 1 : 0;
		if (num != num2)
		{
			return num - num2;
		}
		int[] array = new int[]
		{
			a.AccessType,
			b.AccessType
		};
		List<int> list = new List<int>();
		foreach (int num3 in array)
		{
			int item = 2;
			if (num3 != 7)
			{
				if (num3 == 16)
				{
					item = 1;
				}
			}
			else
			{
				item = 0;
			}
			list.Add(item);
		}
		return list[0] - list[1];
	}
}
