using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003D9 RID: 985
[NullableContext(1)]
[Nullable(0)]
public class AchievementGroupDataItem : UiPanelBase
{
	// Token: 0x060035BF RID: 13759 RVA: 0x0013B6A2 File Offset: 0x001398A2
	public AchievementGroupDataItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x060035C0 RID: 13760 RVA: 0x0013B6B4 File Offset: 0x001398B4
	public UniTask Init()
	{
		AchievementGroupDataItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementGroupDataItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060035C1 RID: 13761 RVA: 0x0013B6F8 File Offset: 0x001398F8
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

	// Token: 0x060035C2 RID: 13762 RVA: 0x0013B761 File Offset: 0x00139961
	protected override void OnStart()
	{
		this.ScrollView = new LoopScrollView<AchievementDataItem, AchievementData>(base.GetLoopScrollViewComponent(0), (AUIBaseActor)base.GetItem(1).GetOwner(), new Func<AchievementDataItem>(this.CreateItem), false);
	}

	// Token: 0x060035C3 RID: 13763 RVA: 0x0013B794 File Offset: 0x00139994
	public void Update(AchievementGroupData groupData)
	{
		List<AchievementData> groupAchievements = AchievementModel.Instance.GetGroupAchievements(groupData.GetId(), true);
		groupAchievements.Sort(AchievementModel.Instance.SortByTabIndex);
		this.RefreshScroller(groupAchievements);
	}

	// Token: 0x060035C4 RID: 13764 RVA: 0x0013B7CC File Offset: 0x001399CC
	private void RefreshScroller(List<AchievementData> dataList)
	{
		this.ScrollView.RefreshByData(dataList, true, null, false);
		if (dataList.Count > 0)
		{
			int selectAchievementIndex = this.GetSelectAchievementIndex(dataList);
			this.ScrollView.ScrollToGridIndex(selectAchievementIndex, true);
		}
	}

	// Token: 0x060035C5 RID: 13765 RVA: 0x0013B808 File Offset: 0x00139A08
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

	// Token: 0x060035C6 RID: 13766 RVA: 0x0013B861 File Offset: 0x00139A61
	private AchievementDataItem CreateItem()
	{
		return new AchievementDataItem();
	}

	// Token: 0x04002D2C RID: 11564
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<AchievementDataItem, AchievementData> ScrollView;

	// Token: 0x04002D2D RID: 11565
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x020066FF RID: 26367
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022071 RID: 139377
		ItemScroller,
		// Token: 0x04022072 RID: 139378
		ItemPrefab
	}
}
