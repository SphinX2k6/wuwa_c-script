using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F24 RID: 3876
[NullableContext(1)]
[Nullable(0)]
public class AchievementGroupDataItem : UiPanelBase
{
	// Token: 0x06006227 RID: 25127 RVA: 0x00132D7A File Offset: 0x00130F7A
	public AchievementGroupDataItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06006228 RID: 25128 RVA: 0x00132D8C File Offset: 0x00130F8C
	public UniTask Init()
	{
		AchievementGroupDataItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementGroupDataItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06006229 RID: 25129 RVA: 0x00132DD0 File Offset: 0x00130FD0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600622A RID: 25130 RVA: 0x00132E39 File Offset: 0x00131039
	protected override void OnStart()
	{
		this.ScrollView = new LoopScrollView<AchievementDataItem, AchievementData>(base.GetLoopScrollViewComponent(0), (AUIBaseActor)base.GetItem(1).GetOwner(), new Func<AchievementDataItem>(this.CreateItem), false);
	}

	// Token: 0x0600622B RID: 25131 RVA: 0x00132E6C File Offset: 0x0013106C
	public void Update(AchievementGroupData groupData)
	{
		List<AchievementData> groupAchievements = AchievementModel.Instance.GetGroupAchievements(groupData.GetId(), true);
		groupAchievements.Sort(AchievementModel.Instance.SortByTabIndex);
		this.RefreshScroller(groupAchievements);
	}

	// Token: 0x0600622C RID: 25132 RVA: 0x00132EA4 File Offset: 0x001310A4
	private void RefreshScroller(List<AchievementData> dataList)
	{
		this.ScrollView.RefreshByData(dataList, true, null, false);
		if (dataList.Count > 0)
		{
			int selectAchievementIndex = this.GetSelectAchievementIndex(dataList);
			this.ScrollView.ScrollToGridIndex(selectAchievementIndex, true);
		}
	}

	// Token: 0x0600622D RID: 25133 RVA: 0x00132EE0 File Offset: 0x001310E0
	private int GetSelectAchievementIndex(List<AchievementData> dataList)
	{
		if (AchievementModel.Instance.CurrentSelectAchievementId == -1)
		{
			return 0;
		}
		int result = 0;
		int count = dataList.Count;
		for (int i = 0; i < count; i++)
		{
			if (AchievementModel.Instance.CurrentSelectAchievementId == dataList[i].GetId())
			{
				result = i;
				break;
			}
		}
		AchievementModel.Instance.CurrentSelectAchievementId = -1;
		return result;
	}

	// Token: 0x0600622E RID: 25134 RVA: 0x00132F39 File Offset: 0x00131139
	private AchievementDataItem CreateItem()
	{
		return new AchievementDataItem();
	}

	// Token: 0x04002C93 RID: 11411
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<AchievementDataItem, AchievementData> ScrollView;

	// Token: 0x04002C94 RID: 11412
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x0200756B RID: 30059
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04026D26 RID: 159014
		ItemScroller,
		// Token: 0x04026D27 RID: 159015
		ItemPrefab
	}
}
