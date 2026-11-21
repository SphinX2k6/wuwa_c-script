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

// Token: 0x020003E4 RID: 996
[NullableContext(1)]
[Nullable(0)]
public class AchievementSearchItem : UiPanelBase
{
	// Token: 0x06003636 RID: 13878 RVA: 0x0013D7EA File Offset: 0x0013B9EA
	public AchievementSearchItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06003637 RID: 13879 RVA: 0x0013D804 File Offset: 0x0013BA04
	public UniTask Init()
	{
		AchievementSearchItem.<Init>d__6 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementSearchItem.<Init>d__6>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06003638 RID: 13880 RVA: 0x0013D848 File Offset: 0x0013BA48
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

	// Token: 0x06003639 RID: 13881 RVA: 0x0013D8B4 File Offset: 0x0013BAB4
	protected override UniTask OnBeforeStartAsync()
	{
		AchievementSearchItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AchievementSearchItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600363A RID: 13882 RVA: 0x0013D8F7 File Offset: 0x0013BAF7
	protected override void OnStart()
	{
		base.GetUIDynScrollViewComponent(0).GetRootComponent().SetUIActive(this.CurrentSearchScrollerState);
		this.AddEventListener();
	}

	// Token: 0x0600363B RID: 13883 RVA: 0x0013D916 File Offset: 0x0013BB16
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnGetAchievementSearchTextChange, new Action(this.OnGetAchievementSearchTextChange));
		EventSystem.Instance.Add(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x0600363C RID: 13884 RVA: 0x0013D950 File Offset: 0x0013BB50
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnGetAchievementSearchTextChange, new Action(this.OnGetAchievementSearchTextChange));
		EventSystem.Instance.Remove(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x0600363D RID: 13885 RVA: 0x0013D98A File Offset: 0x0013BB8A
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

	// Token: 0x0600363E RID: 13886 RVA: 0x0013D9C6 File Offset: 0x0013BBC6
	public void Update()
	{
		this.RefreshSearchResult();
	}

	// Token: 0x0600363F RID: 13887 RVA: 0x0013D9CE File Offset: 0x0013BBCE
	public void ResetSearchState()
	{
		this.CurrentSearchingText = string.Empty;
	}

	// Token: 0x06003640 RID: 13888 RVA: 0x0013D9DC File Offset: 0x0013BBDC
	private void RefreshSearchResult()
	{
		string currentSearchText = AchievementModel.Instance.CurrentSearchText;
		if (this.CurrentSearchingText == currentSearchText)
		{
			return;
		}
		this.RefreshUi();
	}

	// Token: 0x06003641 RID: 13889 RVA: 0x0013DA0C File Offset: 0x0013BC0C
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

	// Token: 0x06003642 RID: 13890 RVA: 0x0013DA88 File Offset: 0x0013BC88
	private AchievementSearchResultItem CreateResultItem(AchievementSearchData data, UUIItem uiItem, int index)
	{
		return new AchievementSearchResultItem();
	}

	// Token: 0x06003643 RID: 13891 RVA: 0x0013DA8F File Offset: 0x0013BC8F
	private void OnGetAchievementSearchTextChange()
	{
		if (AchievementModel.Instance.AchievementSearchState)
		{
			this.RefreshSearchResult();
		}
	}

	// Token: 0x06003644 RID: 13892 RVA: 0x0013DAA3 File Offset: 0x0013BCA3
	private void OnAchievementDataNotify()
	{
		AchievementModel.Instance.RefreshSearchResult();
		this.RefreshUi();
	}

	// Token: 0x04002D54 RID: 11604
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<AchievementSearchResultItem, AchievementSearchResultDynItem, AchievementSearchData> ScrollView;

	// Token: 0x04002D55 RID: 11605
	[Nullable(2)]
	private AchievementSearchResultDynItem AchievementSearchResultDynItem;

	// Token: 0x04002D56 RID: 11606
	private bool CurrentSearchScrollerState;

	// Token: 0x04002D57 RID: 11607
	private string CurrentSearchingText = string.Empty;

	// Token: 0x04002D58 RID: 11608
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x0200670D RID: 26381
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040220B4 RID: 139444
		SearchScroller,
		// Token: 0x040220B5 RID: 139445
		TemplateItem
	}
}
