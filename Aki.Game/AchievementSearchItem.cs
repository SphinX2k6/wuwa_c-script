using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F2F RID: 3887
[NullableContext(1)]
[Nullable(0)]
public class AchievementSearchItem : UiPanelBase
{
	// Token: 0x0600629E RID: 25246 RVA: 0x00134EC2 File Offset: 0x001330C2
	public AchievementSearchItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x0600629F RID: 25247 RVA: 0x00134EDC File Offset: 0x001330DC
	public UniTask Init()
	{
		AchievementSearchItem.<Init>d__6 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementSearchItem.<Init>d__6>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060062A0 RID: 25248 RVA: 0x00134F20 File Offset: 0x00133120
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060062A1 RID: 25249 RVA: 0x00134F8C File Offset: 0x0013318C
	protected override UniTask OnBeforeStartAsync()
	{
		AchievementSearchItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AchievementSearchItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060062A2 RID: 25250 RVA: 0x00134FCF File Offset: 0x001331CF
	protected override void OnStart()
	{
		base.GetUIDynScrollViewComponent(0).GetRootComponent().SetUIActive(this.CurrentSearchScrollerState);
		this.AddEventListener();
	}

	// Token: 0x060062A3 RID: 25251 RVA: 0x00134FEE File Offset: 0x001331EE
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnGetAchievementSearchTextChange, new Action(this.OnGetAchievementSearchTextChange));
		EventSystem.Instance.Add(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x060062A4 RID: 25252 RVA: 0x00135028 File Offset: 0x00133228
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnGetAchievementSearchTextChange, new Action(this.OnGetAchievementSearchTextChange));
		EventSystem.Instance.Remove(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x060062A5 RID: 25253 RVA: 0x00135062 File Offset: 0x00133262
	protected override void OnBeforeDestroy()
	{
		if (this.ScrollView != null)
		{
			this.ScrollView.ClearChildren();
			this.ScrollView = null;
		}
		if (this.AchievementSearchResultDynItem != null)
		{
			this.AchievementSearchResultDynItem.ClearItem();
			this.AchievementSearchResultDynItem = null;
		}
		this.RemoveEventListener();
	}

	// Token: 0x060062A6 RID: 25254 RVA: 0x0013509E File Offset: 0x0013329E
	public void Update()
	{
		this.RefreshSearchResult();
	}

	// Token: 0x060062A7 RID: 25255 RVA: 0x001350A6 File Offset: 0x001332A6
	public void ResetSearchState()
	{
		this.CurrentSearchingText = string.Empty;
	}

	// Token: 0x060062A8 RID: 25256 RVA: 0x001350B4 File Offset: 0x001332B4
	private void RefreshSearchResult()
	{
		string currentSearchText = AchievementModel.Instance.CurrentSearchText;
		if (this.CurrentSearchingText == currentSearchText)
		{
			return;
		}
		this.RefreshUi();
	}

	// Token: 0x060062A9 RID: 25257 RVA: 0x001350E4 File Offset: 0x001332E4
	private void RefreshUi()
	{
		AchievementModel instance = AchievementModel.Instance;
		if (!instance.AchievementSearchState)
		{
			return;
		}
		string currentSearchText = instance.CurrentSearchText;
		Dictionary<AchievementCategoryData, Dictionary<AchievementGroupData, AchievementData[]>> searchResult = instance.GetSearchResult();
		this.CurrentSearchingText = currentSearchText;
		bool searchResultIfNull = instance.GetSearchResultIfNull();
		base.GetUIDynScrollViewComponent(0).GetRootComponent().SetUIActive(!searchResultIfNull);
		this.CurrentSearchScrollerState = !searchResultIfNull;
		List<AchievementSearchData> searchResultData = instance.GetSearchResultData(searchResult);
		instance.CurrentCacheSearchData = searchResultData;
		this.ScrollView.RefreshByData(searchResultData.ToArray(), false, false);
	}

	// Token: 0x060062AA RID: 25258 RVA: 0x00135160 File Offset: 0x00133360
	private AchievementSearchResultItem CreateResultItem(AchievementSearchData data, UUIItem uiItem, int index)
	{
		return new AchievementSearchResultItem();
	}

	// Token: 0x060062AB RID: 25259 RVA: 0x00135167 File Offset: 0x00133367
	private void OnGetAchievementSearchTextChange()
	{
		if (AchievementModel.Instance.AchievementSearchState)
		{
			this.RefreshSearchResult();
		}
	}

	// Token: 0x060062AC RID: 25260 RVA: 0x0013517B File Offset: 0x0013337B
	private void OnAchievementDataNotify()
	{
		AchievementModel.Instance.RefreshSearchResult();
		this.RefreshUi();
	}

	// Token: 0x04002CBB RID: 11451
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<AchievementSearchResultItem, AchievementSearchResultDynItem, AchievementSearchData> ScrollView;

	// Token: 0x04002CBC RID: 11452
	[Nullable(2)]
	private AchievementSearchResultDynItem AchievementSearchResultDynItem;

	// Token: 0x04002CBD RID: 11453
	private bool CurrentSearchScrollerState;

	// Token: 0x04002CBE RID: 11454
	private string CurrentSearchingText = string.Empty;

	// Token: 0x04002CBF RID: 11455
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x02007579 RID: 30073
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04026D69 RID: 159081
		SearchScroller,
		// Token: 0x04026D6A RID: 159082
		TemplateItem
	}
}
