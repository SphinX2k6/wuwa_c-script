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

// Token: 0x02000F29 RID: 3881
[NullableContext(1)]
[Nullable(0)]
public class AchievementMainView : UiViewBase
{
	// Token: 0x06006254 RID: 25172 RVA: 0x001338F5 File Offset: 0x00131AF5
	public AchievementMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006255 RID: 25173 RVA: 0x00133908 File Offset: 0x00131B08
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

	// Token: 0x06006256 RID: 25174 RVA: 0x00133A74 File Offset: 0x00131C74
	protected override UniTask OnCreateAsync()
	{
		AchievementMainView.<OnCreateAsync>d__10 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<AchievementMainView.<OnCreateAsync>d__10>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006257 RID: 25175 RVA: 0x00133AB0 File Offset: 0x00131CB0
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

	// Token: 0x06006258 RID: 25176 RVA: 0x00133B6C File Offset: 0x00131D6C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x06006259 RID: 25177 RVA: 0x00133B8A File Offset: 0x00131D8A
	protected override void OnBeforeShow()
	{
		this.RefreshRecentRewardScroller();
		this.RefreshCategoryScroller();
		this.RefreshStar();
		this.RefreshOneClickBtn();
		this.UpdateProgressText();
	}

	// Token: 0x0600625A RID: 25178 RVA: 0x00133BAA File Offset: 0x00131DAA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x0600625B RID: 25179 RVA: 0x00133BC8 File Offset: 0x00131DC8
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

	// Token: 0x0600625C RID: 25180 RVA: 0x00133C28 File Offset: 0x00131E28
	private void RefreshStar()
	{
		int achievementFinishedStar = AchievementModel.Instance.GetAchievementFinishedStar();
		this.CurrentStarNumText.SetText(achievementFinishedStar.ToString(), true);
	}

	// Token: 0x0600625D RID: 25181 RVA: 0x00133C54 File Offset: 0x00131E54
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

	// Token: 0x0600625E RID: 25182 RVA: 0x00133DC4 File Offset: 0x00131FC4
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

	// Token: 0x0600625F RID: 25183 RVA: 0x00133DF4 File Offset: 0x00131FF4
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

	// Token: 0x06006260 RID: 25184 RVA: 0x00133F10 File Offset: 0x00132110
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

	// Token: 0x06006261 RID: 25185 RVA: 0x00133F60 File Offset: 0x00132160
	private void RefreshCategoryScroller()
	{
		List<AchievementCategoryData> achievementCategoryArray = AchievementModel.Instance.GetAchievementCategoryArray();
		this.ScrollView.RefreshByData(achievementCategoryArray, null, false);
	}

	// Token: 0x06006262 RID: 25186 RVA: 0x00133F86 File Offset: 0x00132186
	private AchievementCategoryItem UpdateItem()
	{
		return new AchievementCategoryItem();
	}

	// Token: 0x06006263 RID: 25187 RVA: 0x00133F8D File Offset: 0x0013218D
	private void OnAchievementDataNotify()
	{
		this.RefreshRecentRewardScroller();
		this.RefreshStar();
		this.UpdateProgressText();
		this.RefreshOneClickBtn();
	}

	// Token: 0x06006264 RID: 25188 RVA: 0x00133FA7 File Offset: 0x001321A7
	private AchievementSmallItem OnRecentScrollerItemCreate()
	{
		return new AchievementSmallItem
		{
			OnClickButtonCallback = new Action<int>(this.OnClickGrid)
		};
	}

	// Token: 0x06006265 RID: 25189 RVA: 0x00133FC0 File Offset: 0x001321C0
	private void OnClickGrid(int index)
	{
		this.CachedFocusGridIndex = index;
	}

	// Token: 0x06006266 RID: 25190 RVA: 0x00133FC9 File Offset: 0x001321C9
	protected override void OnBeforeHide()
	{
	}

	// Token: 0x06006267 RID: 25191 RVA: 0x00133FCB File Offset: 0x001321CB
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06006268 RID: 25192 RVA: 0x00133FD4 File Offset: 0x001321D4
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

	// Token: 0x04002CA2 RID: 11426
	[Nullable(2)]
	private UUIText AchievementProgressText;

	// Token: 0x04002CA3 RID: 11427
	[Nullable(2)]
	private UUIText CurrentStarNumText;

	// Token: 0x04002CA4 RID: 11428
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04002CA5 RID: 11429
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AchievementCategoryItem, AchievementCategoryData> ScrollView;

	// Token: 0x04002CA6 RID: 11430
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<AchievementSmallItem, AchievementData> AchievementRecentScroller;

	// Token: 0x04002CA7 RID: 11431
	[Nullable(2)]
	private List<int> CachedRecentFinishedIds;

	// Token: 0x04002CA8 RID: 11432
	private int CachedFocusGridIndex = -1;

	// Token: 0x02007570 RID: 30064
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04026D40 RID: 159040
		CurrentStarNumText,
		// Token: 0x04026D41 RID: 159041
		AchievementProgressText,
		// Token: 0x04026D42 RID: 159042
		CaptionItem,
		// Token: 0x04026D43 RID: 159043
		RecentFinishScroller,
		// Token: 0x04026D44 RID: 159044
		CategoryScroller,
		// Token: 0x04026D45 RID: 159045
		RecentFinishItem,
		// Token: 0x04026D46 RID: 159046
		EmptyAchievementItem,
		// Token: 0x04026D47 RID: 159047
		BtnOneClickReceive
	}
}
