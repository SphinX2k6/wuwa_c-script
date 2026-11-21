using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003DE RID: 990
[NullableContext(1)]
[Nullable(0)]
public class AchievementMainView : UiViewBase
{
	// Token: 0x060035EC RID: 13804 RVA: 0x0013C21D File Offset: 0x0013A41D
	public AchievementMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060035ED RID: 13805 RVA: 0x0013C230 File Offset: 0x0013A430
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickOneClickReceive));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060035EE RID: 13806 RVA: 0x0013C39C File Offset: 0x0013A59C
	protected override UniTask OnCreateAsync()
	{
		AchievementMainView.<OnCreateAsync>d__10 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<AchievementMainView.<OnCreateAsync>d__10>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060035EF RID: 13807 RVA: 0x0013C3D8 File Offset: 0x0013A5D8
	protected override void OnStart()
	{
		this.CurrentStarNumText = base.GetText(0);
		this.AchievementProgressText = base.GetText(1);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(2));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickBackBtn));
		this.AchievementRecentScroller = new LoopScrollView<AchievementSmallItem, AchievementData>(base.GetLoopScrollViewComponent(3), (AUIBaseActor)base.GetItem(5).GetOwner(), new Func<AchievementSmallItem>(this.OnRecentScrollerItemCreate), false);
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		this.ScrollView = new GenericLayout<AchievementCategoryItem, AchievementCategoryData>(scrollViewWithScrollbar.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase, new Func<AchievementCategoryItem>(this.UpdateItem), null, false, true);
	}

	// Token: 0x060035F0 RID: 13808 RVA: 0x0013C494 File Offset: 0x0013A694
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x060035F1 RID: 13809 RVA: 0x0013C4B2 File Offset: 0x0013A6B2
	protected override void OnBeforeShow()
	{
		this.RefreshRecentRewardScroller();
		this.RefreshCategoryScroller();
		this.RefreshStar();
		this.RefreshOneClickBtn();
		this.UpdateProgressText();
	}

	// Token: 0x060035F2 RID: 13810 RVA: 0x0013C4D2 File Offset: 0x0013A6D2
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x060035F3 RID: 13811 RVA: 0x0013C4F0 File Offset: 0x0013A6F0
	protected override void OnBeforeDestroy()
	{
		if (this.CaptionItem != null)
		{
			this.CaptionItem.Destroy(null);
			this.CaptionItem = null;
		}
		if (this.AchievementRecentScroller != null)
		{
			this.AchievementRecentScroller.ClearGridProxies();
			this.AchievementRecentScroller = null;
		}
		if (this.AchievementProgressText != null)
		{
			this.AchievementProgressText = null;
		}
		if (this.CurrentStarNumText != null)
		{
			this.CurrentStarNumText = null;
		}
	}

	// Token: 0x060035F4 RID: 13812 RVA: 0x0013C550 File Offset: 0x0013A750
	private void RefreshStar()
	{
		int achievementFinishedStar = AchievementModel.Instance.GetAchievementFinishedStar();
		this.CurrentStarNumText.SetText(achievementFinishedStar.ToString(), true);
	}

	// Token: 0x060035F5 RID: 13813 RVA: 0x0013C57C File Offset: 0x0013A77C
	private void RefreshOneClickBtn()
	{
		HashSet<int> hashSet = new HashSet<int>();
		IReadOnlyList<RogueSeason> rogueSeasonConfigList = RoguelikeConfig.Instance.GetRogueSeasonConfigList();
		if (rogueSeasonConfigList != null)
		{
			for (int i = 0; i < rogueSeasonConfigList.Count; i++)
			{
				hashSet.Add(rogueSeasonConfigList[i].Achievement);
			}
		}
		AchievementConfig instance = AchievementConfig.Instance;
		Dictionary<int, AchievementData> allAchievementData = AchievementModel.Instance.GetAllAchievementData();
		Dictionary<int, AchievementGroupData> allAchievementGroupData = AchievementModel.Instance.GetAllAchievementGroupData();
		bool flag = false;
		foreach (AchievementData achievementData in allAchievementData.Values)
		{
			if (achievementData.GetFinishState() == EAchievementStateEnum.CanGetReward)
			{
				int achievementGroupCategory = instance.GetAchievementGroupCategory(achievementData.GetGroupId());
				if (!hashSet.Contains(achievementGroupCategory))
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			allAchievementGroupData.GetEnumerator();
			foreach (AchievementGroupData achievementGroupData in allAchievementGroupData.Values)
			{
				if (achievementGroupData.GetFinishState() == EAchievementStateEnum.CanGetReward)
				{
					int achievementGroupCategory2 = instance.GetAchievementGroupCategory(achievementGroupData.GetId());
					if (!hashSet.Contains(achievementGroupCategory2) && achievementGroupData.GetRewards().Count > 0)
					{
						flag = true;
						break;
					}
				}
			}
		}
		base.GetButton(7).RootUIComp.Get().SetUIActive(flag);
	}

	// Token: 0x060035F6 RID: 13814 RVA: 0x0013C6EC File Offset: 0x0013A8EC
	private void UpdateProgressText()
	{
		int finishedAchievementNum = AchievementModel.Instance.GetFinishedAchievementNum();
		UUIText achievementProgressText = this.AchievementProgressText;
		if (achievementProgressText == null)
		{
			return;
		}
		achievementProgressText.SetText(finishedAchievementNum.ToString(), true);
	}

	// Token: 0x060035F7 RID: 13815 RVA: 0x0013C71C File Offset: 0x0013A91C
	private void RefreshRecentRewardScroller()
	{
		AchievementModel instance = AchievementModel.Instance;
		List<int> recentFinishedAchievementList = AchievementModel.Instance.GetRecentFinishedAchievementList();
		bool flag = recentFinishedAchievementList.Count > 0;
		List<AchievementData> list = new List<AchievementData>();
		for (int i = 0; i < recentFinishedAchievementList.Count; i++)
		{
			list.Add(instance.GetAchievementData(recentFinishedAchievementList[i]));
		}
		this.AchievementRecentScroller.RefreshByData(list, false, null, true);
		this.AchievementRecentScroller.SetTargetRootComponentActive(flag);
		base.GetItem(6).SetUIActive(!flag);
		List<int> list2 = new List<int>(recentFinishedAchievementList);
		if (flag)
		{
			if (this.IsRecentFinishedListChanged(list2))
			{
				this.CachedFocusGridIndex = 0;
				this.AchievementRecentScroller.ScrollToGridIndex(0, false);
				UUIItem gridByDisplayIndex = this.AchievementRecentScroller.GetGridByDisplayIndex(0);
				if (gridByDisplayIndex != null)
				{
					UiNavigationNewController.Instance.SetNavigationFocusForView(gridByDisplayIndex, true, false, false);
				}
			}
			else if (this.CachedFocusGridIndex > 0)
			{
				this.AchievementRecentScroller.ScrollToGridIndex(this.CachedFocusGridIndex, false);
				UUIItem grid = this.AchievementRecentScroller.GetGrid(this.CachedFocusGridIndex);
				if (grid != null)
				{
					UiNavigationNewController.Instance.SetNavigationFocusForView(grid, true, false, false);
				}
			}
		}
		this.CachedRecentFinishedIds = list2;
	}

	// Token: 0x060035F8 RID: 13816 RVA: 0x0013C838 File Offset: 0x0013AA38
	private bool IsRecentFinishedListChanged(List<int> currentIds)
	{
		List<int> cachedRecentFinishedIds = this.CachedRecentFinishedIds;
		if (cachedRecentFinishedIds == null)
		{
			return true;
		}
		if (cachedRecentFinishedIds.Count != currentIds.Count)
		{
			return true;
		}
		for (int i = 0; i < cachedRecentFinishedIds.Count; i++)
		{
			if (cachedRecentFinishedIds[i] != currentIds[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060035F9 RID: 13817 RVA: 0x0013C888 File Offset: 0x0013AA88
	private void RefreshCategoryScroller()
	{
		List<AchievementCategoryData> achievementCategoryArray = AchievementModel.Instance.GetAchievementCategoryArray();
		this.ScrollView.RefreshByData(achievementCategoryArray, null, false);
	}

	// Token: 0x060035FA RID: 13818 RVA: 0x0013C8AE File Offset: 0x0013AAAE
	private AchievementCategoryItem UpdateItem()
	{
		return new AchievementCategoryItem();
	}

	// Token: 0x060035FB RID: 13819 RVA: 0x0013C8B5 File Offset: 0x0013AAB5
	private void OnAchievementDataNotify()
	{
		this.RefreshRecentRewardScroller();
		this.RefreshStar();
		this.UpdateProgressText();
		this.RefreshOneClickBtn();
	}

	// Token: 0x060035FC RID: 13820 RVA: 0x0013C8CF File Offset: 0x0013AACF
	private AchievementSmallItem OnRecentScrollerItemCreate()
	{
		return new AchievementSmallItem
		{
			OnClickButtonCallback = new Action<int>(this.OnClickGrid)
		};
	}

	// Token: 0x060035FD RID: 13821 RVA: 0x0013C8E8 File Offset: 0x0013AAE8
	private void OnClickGrid(int index)
	{
		this.CachedFocusGridIndex = index;
	}

	// Token: 0x060035FE RID: 13822 RVA: 0x0013C8F1 File Offset: 0x0013AAF1
	protected override void OnBeforeHide()
	{
	}

	// Token: 0x060035FF RID: 13823 RVA: 0x0013C8F3 File Offset: 0x0013AAF3
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06003600 RID: 13824 RVA: 0x0013C8FC File Offset: 0x0013AAFC
	private void OnClickOneClickReceive()
	{
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		HashSet<int> hashSet = new HashSet<int>();
		IReadOnlyList<RogueSeason> rogueSeasonConfigList = RoguelikeConfig.Instance.GetRogueSeasonConfigList();
		if (rogueSeasonConfigList != null)
		{
			for (int i = 0; i < rogueSeasonConfigList.Count; i++)
			{
				hashSet.Add(rogueSeasonConfigList[i].Achievement);
			}
		}
		Dictionary<int, AchievementData> allAchievementData = AchievementModel.Instance.GetAllAchievementData();
		AchievementConfig instance = AchievementConfig.Instance;
		foreach (KeyValuePair<int, AchievementData> keyValuePair in allAchievementData)
		{
			int key = keyValuePair.Key;
			AchievementData value = keyValuePair.Value;
			int achievementGroupCategory = instance.GetAchievementGroupCategory(value.GetGroupId());
			if (value.GetFinishState() == EAchievementStateEnum.CanGetReward && !hashSet.Contains(achievementGroupCategory))
			{
				list.Add(key);
			}
		}
		foreach (KeyValuePair<int, AchievementGroupData> keyValuePair2 in AchievementModel.Instance.GetAllAchievementGroupData())
		{
			int key2 = keyValuePair2.Key;
			AchievementGroupData value2 = keyValuePair2.Value;
			int category = value2.GetCategory();
			if (value2.GetFinishState() == EAchievementStateEnum.CanGetReward && !hashSet.Contains(category) && value2.GetRewards().Count > 0)
			{
				list2.Add(key2);
			}
		}
		AchievementController.Instance.RequestGetMultiAchievementReward(list.ToArray(), list2.ToArray());
	}

	// Token: 0x04002D3B RID: 11579
	[Nullable(2)]
	private UUIText AchievementProgressText;

	// Token: 0x04002D3C RID: 11580
	[Nullable(2)]
	private UUIText CurrentStarNumText;

	// Token: 0x04002D3D RID: 11581
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04002D3E RID: 11582
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AchievementCategoryItem, AchievementCategoryData> ScrollView;

	// Token: 0x04002D3F RID: 11583
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<AchievementSmallItem, AchievementData> AchievementRecentScroller;

	// Token: 0x04002D40 RID: 11584
	[Nullable(2)]
	private List<int> CachedRecentFinishedIds;

	// Token: 0x04002D41 RID: 11585
	private int CachedFocusGridIndex = -1;

	// Token: 0x02006704 RID: 26372
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402208B RID: 139403
		CurrentStarNumText,
		// Token: 0x0402208C RID: 139404
		AchievementProgressText,
		// Token: 0x0402208D RID: 139405
		CaptionItem,
		// Token: 0x0402208E RID: 139406
		RecentFinishScroller,
		// Token: 0x0402208F RID: 139407
		CategoryScroller,
		// Token: 0x04022090 RID: 139408
		RecentFinishItem,
		// Token: 0x04022091 RID: 139409
		EmptyAchievementItem,
		// Token: 0x04022092 RID: 139410
		BtnOneClickReceive
	}
}
