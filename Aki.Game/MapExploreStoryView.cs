using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001ACE RID: 6862
[NullableContext(2)]
[Nullable(0)]
public class MapExploreStoryView : UiViewBase
{
	// Token: 0x0600CB9E RID: 52126 RVA: 0x002E7997 File Offset: 0x002E5B97
	[NullableContext(1)]
	public MapExploreStoryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CB9F RID: 52127 RVA: 0x002E79A8 File Offset: 0x002E5BA8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CBA0 RID: 52128 RVA: 0x002E7A98 File Offset: 0x002E5C98
	protected override UniTask OnBeforeStartAsync()
	{
		MapExploreStoryView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapExploreStoryView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBA1 RID: 52129 RVA: 0x002E7ADC File Offset: 0x002E5CDC
	protected override void OnBeforeShow()
	{
		MapExploreStoryViewParams dataParam = this.DataParam;
		ExploreAreaData exploreAreaData = (dataParam != null) ? dataParam.AreaData : null;
		if (exploreAreaData == null)
		{
			return;
		}
		string storyViewTitle = exploreAreaData.GetStoryViewTitle();
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(storyViewTitle, true);
		}
		float value = (float)exploreAreaData.GetProgress();
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<float>(value);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		MapAreaOnlyShowItem areaShowItem = this.AreaShowItem;
		if (areaShowItem == null)
		{
			return;
		}
		areaShowItem.Refresh(exploreAreaData.GetIconPercentDataAreaStory(), null);
	}

	// Token: 0x0600CBA2 RID: 52130 RVA: 0x002E7B7C File Offset: 0x002E5D7C
	protected override void OnAfterPlayStartSequence()
	{
		if (this.JumpIndex >= 0 && this.StoryList != null)
		{
			for (int i = this.JumpIndex; i < this.StoryList.Count; i++)
			{
				if (this.StoryList[i].IsNewOpen.GetValueOrDefault())
				{
					GenericScrollViewNew<MapExploreStoryItem, IMapExploreStoryItemData> scrollView = this.ScrollView;
					if (scrollView != null)
					{
						MapExploreStoryItem scrollItemByIndex = scrollView.GetScrollItemByIndex(i);
						if (scrollItemByIndex != null)
						{
							scrollItemByIndex.PlayNewOpenAnim();
						}
					}
				}
			}
		}
	}

	// Token: 0x0600CBA3 RID: 52131 RVA: 0x002E7BF0 File Offset: 0x002E5DF0
	protected override void OnBeforeDestroy()
	{
		MapExploreStoryViewParams dataParam = this.DataParam;
		if (dataParam != null)
		{
			ExploreAreaData areaData = dataParam.AreaData;
			if (areaData != null)
			{
				areaData.SaveLocalAreaStoryProgress();
			}
		}
		MapExploreStoryViewParams dataParam2 = this.DataParam;
		if (dataParam2 != null)
		{
			ExploreAreaData areaData2 = dataParam2.AreaData;
			if (areaData2 != null)
			{
				areaData2.SaveLocalIconPercentAreaStory();
			}
		}
		this.PopupCaption = null;
		this.ScrollView = null;
		this.AreaShowItem = null;
	}

	// Token: 0x0600CBA4 RID: 52132 RVA: 0x002E7C4B File Offset: 0x002E5E4B
	private void OnCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04005DA3 RID: 23971
	private MapExploreStoryViewParams DataParam;

	// Token: 0x04005DA4 RID: 23972
	private PopupCaptionItem PopupCaption;

	// Token: 0x04005DA5 RID: 23973
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MapExploreStoryItem, IMapExploreStoryItemData> ScrollView;

	// Token: 0x04005DA6 RID: 23974
	private MapAreaOnlyShowItem AreaShowItem;

	// Token: 0x04005DA7 RID: 23975
	private int JumpIndex = -1;

	// Token: 0x04005DA8 RID: 23976
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IMapExploreStoryItemData> StoryList;

	// Token: 0x0200802E RID: 32814
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029D9C RID: 171420
		ItemCaption,
		// Token: 0x04029D9D RID: 171421
		ScrollView,
		// Token: 0x04029D9E RID: 171422
		ItemStory,
		// Token: 0x04029D9F RID: 171423
		ItemExploreArea,
		// Token: 0x04029DA0 RID: 171424
		TxtAreaProgress,
		// Token: 0x04029DA1 RID: 171425
		TxtTitle
	}
}
