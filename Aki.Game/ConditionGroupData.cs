using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200167F RID: 5759
[NullableContext(1)]
[Nullable(0)]
public class ConditionGroupData : UiPopViewData, IViewOpenParamMultipleView
{
	// Token: 0x17000DC4 RID: 3524
	// (get) Token: 0x0600A2F3 RID: 41715 RVA: 0x00240366 File Offset: 0x0023E566
	// (set) Token: 0x0600A2F4 RID: 41716 RVA: 0x0024036E File Offset: 0x0023E56E
	public bool IsMultipleView { get; set; }

	// Token: 0x0600A2F5 RID: 41717 RVA: 0x00240377 File Offset: 0x0023E577
	public ConditionGroupData(int conditionGroupId, List<IActivityConditionData> dataList, [Nullable(2)] string titleId = "", bool isPreOpen = false)
	{
		this.ConditionGroupId = conditionGroupId;
		this.DataList = dataList;
		this.TitleId = titleId;
		this.IsPreOpen = isPreOpen;
		this.DataList.Sort(new Comparison<IActivityConditionData>(this.SortConditionData));
	}

	// Token: 0x17000DC5 RID: 3525
	// (get) Token: 0x0600A2F6 RID: 41718 RVA: 0x002403B3 File Offset: 0x0023E5B3
	// (set) Token: 0x0600A2F7 RID: 41719 RVA: 0x002403BB File Offset: 0x0023E5BB
	public int ConditionGroupId { get; set; }

	// Token: 0x17000DC6 RID: 3526
	// (get) Token: 0x0600A2F8 RID: 41720 RVA: 0x002403C4 File Offset: 0x0023E5C4
	// (set) Token: 0x0600A2F9 RID: 41721 RVA: 0x002403CC File Offset: 0x0023E5CC
	public List<IActivityConditionData> DataList { get; set; }

	// Token: 0x17000DC7 RID: 3527
	// (get) Token: 0x0600A2FA RID: 41722 RVA: 0x002403D5 File Offset: 0x0023E5D5
	// (set) Token: 0x0600A2FB RID: 41723 RVA: 0x002403DD File Offset: 0x0023E5DD
	[Nullable(2)]
	public string TitleId { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000DC8 RID: 3528
	// (get) Token: 0x0600A2FC RID: 41724 RVA: 0x002403E6 File Offset: 0x0023E5E6
	// (set) Token: 0x0600A2FD RID: 41725 RVA: 0x002403EE File Offset: 0x0023E5EE
	public bool IsPreOpen { get; set; }

	// Token: 0x0600A2FE RID: 41726 RVA: 0x002403F8 File Offset: 0x0023E5F8
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
