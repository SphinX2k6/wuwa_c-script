using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F8D RID: 3981
[NullableContext(2)]
[Nullable(0)]
public class MapExploreStoryView : UiViewBase
{
	// Token: 0x06009FAF RID: 40879 RVA: 0x002F2AEB File Offset: 0x002F0CEB
	[NullableContext(1)]
	public MapExploreStoryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009FB0 RID: 40880 RVA: 0x002F2AFC File Offset: 0x002F0CFC
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

	// Token: 0x06009FB1 RID: 40881 RVA: 0x002F2BEC File Offset: 0x002F0DEC
	protected override UniTask OnBeforeStartAsync()
	{
		MapExploreStoryView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapExploreStoryView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009FB2 RID: 40882 RVA: 0x002F2C30 File Offset: 0x002F0E30
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

	// Token: 0x06009FB3 RID: 40883 RVA: 0x002F2CD0 File Offset: 0x002F0ED0
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

	// Token: 0x06009FB4 RID: 40884 RVA: 0x002F2D44 File Offset: 0x002F0F44
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

	// Token: 0x06009FB5 RID: 40885 RVA: 0x002F2D9F File Offset: 0x002F0F9F
	private void OnCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04005E72 RID: 24178
	private MapExploreStoryViewParams DataParam;

	// Token: 0x04005E73 RID: 24179
	private PopupCaptionItem PopupCaption;

	// Token: 0x04005E74 RID: 24180
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MapExploreStoryItem, IMapExploreStoryItemData> ScrollView;

	// Token: 0x04005E75 RID: 24181
	private MapAreaOnlyShowItem AreaShowItem;

	// Token: 0x04005E76 RID: 24182
	private int JumpIndex = -1;

	// Token: 0x04005E77 RID: 24183
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IMapExploreStoryItemData> StoryList;

	// Token: 0x020071BC RID: 29116
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040250D0 RID: 151760
		ItemCaption,
		// Token: 0x040250D1 RID: 151761
		ScrollView,
		// Token: 0x040250D2 RID: 151762
		ItemStory,
		// Token: 0x040250D3 RID: 151763
		ItemExploreArea,
		// Token: 0x040250D4 RID: 151764
		TxtAreaProgress,
		// Token: 0x040250D5 RID: 151765
		TxtTitle
	}
}
