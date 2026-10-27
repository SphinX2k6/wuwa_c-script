using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E04 RID: 7684
[NullableContext(1)]
[Nullable(0)]
public class HandBookEntranceView : UiViewBase
{
	// Token: 0x0600E9A7 RID: 59815 RVA: 0x003747D5 File Offset: 0x003729D5
	public HandBookEntranceView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.HandBookEntranceList = new List<HandBookEntrance>();
		this.HandBookEntranceItemList = new List<HandBookEntranceItem>();
	}

	// Token: 0x0600E9A8 RID: 59816 RVA: 0x003747F4 File Offset: 0x003729F4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600E9A9 RID: 59817 RVA: 0x00374864 File Offset: 0x00372A64
	protected override UniTask OnBeforeStartAsync()
	{
		HandBookEntranceView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HandBookEntranceView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E9AA RID: 59818 RVA: 0x0037489F File Offset: 0x00372A9F
	protected override void OnStart()
	{
		this.InitCommonTabTitle();
		this.OnHandBookRedDotUpdate();
		this.OnHandBookDataInit();
	}

	// Token: 0x0600E9AB RID: 59819 RVA: 0x003748B3 File Offset: 0x00372AB3
	protected override void OnBeforeShow()
	{
		HandBookController.Instance.SendIllustratedRedDotRequest().ContinueWith(new Action(this.OnHandBookRedDotUpdate)).Forget();
	}

	// Token: 0x0600E9AC RID: 59820 RVA: 0x003748D5 File Offset: 0x00372AD5
	protected void OnHandBookDataInit()
	{
		this.InitVerticalLayout();
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x0600E9AD RID: 59821 RVA: 0x003748F0 File Offset: 0x00372AF0
	protected void OnHandBookRedDotUpdate()
	{
		int count = this.HandBookEntranceItemList.Count;
		for (int i = 0; i < count; i++)
		{
			this.HandBookEntranceItemList[i].RefreshRedDot();
		}
	}

	// Token: 0x0600E9AE RID: 59822 RVA: 0x00374928 File Offset: 0x00372B28
	protected void InitCommonTabTitle()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("HandBookEntrance");
		string textContentIdById = TextConfig.Instance.GetTextContentIdById("HandBookEntrance");
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseButton));
		this.CaptionItem.SetTitleLocalText(textContentIdById);
		this.CaptionItem.SetTitleIcon(resourcePath);
	}

	// Token: 0x0600E9AF RID: 59823 RVA: 0x00374998 File Offset: 0x00372B98
	protected void InitVerticalLayout()
	{
		List<HandBookEntrance> list = ConfigCommon.ToList<HandBookEntrance>(HandBookConfig.Instance.GetHandBookEntranceConfigList());
		list.Sort(new Comparison<HandBookEntrance>(this.SortIndex));
		this.HandBookEntranceList = list;
		if (this.ScrollView == null)
		{
			this.ScrollView = new GenericScrollViewNew<HandBookEntranceItem, HandBookEntrance>(base.GetScrollViewWithScrollbar(2), new Func<HandBookEntranceItem>(this.InitItem), null, false, null);
		}
		this.ScrollView.RefreshByData(this.HandBookEntranceList, null, false);
		IHandBookEntranceViewParam param = this.OpenParam as IHandBookEntranceViewParam;
		if (param != null)
		{
			int index = this.HandBookEntranceList.FindIndex((HandBookEntrance entrance) => entrance.Id == (int)param.SelectedTabType);
			UUIItem itemByIndex = this.ScrollView.GetItemByIndex(index);
			if (itemByIndex != null)
			{
				GenericScrollViewNew<HandBookEntranceItem, HandBookEntrance> scrollView = this.ScrollView;
				if (scrollView == null)
				{
					return;
				}
				scrollView.LateScrollTo(itemByIndex, null, false);
			}
		}
	}

	// Token: 0x0600E9B0 RID: 59824 RVA: 0x00374A64 File Offset: 0x00372C64
	private HandBookEntranceItem InitItem()
	{
		HandBookEntranceItem handBookEntranceItem = new HandBookEntranceItem();
		this.HandBookEntranceItemList.Add(handBookEntranceItem);
		return handBookEntranceItem;
	}

	// Token: 0x0600E9B1 RID: 59825 RVA: 0x00374A84 File Offset: 0x00372C84
	private int SortIndex(HandBookEntrance a, HandBookEntrance b)
	{
		return a.SortId - b.SortId;
	}

	// Token: 0x0600E9B2 RID: 59826 RVA: 0x00374A95 File Offset: 0x00372C95
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.HandBookEntranceView, null);
	}

	// Token: 0x0600E9B3 RID: 59827 RVA: 0x00374AA7 File Offset: 0x00372CA7
	protected override void OnBeforeDestroy()
	{
		this.HandBookEntranceList = new List<HandBookEntrance>();
		this.HandBookEntranceItemList = new List<HandBookEntranceItem>();
	}

	// Token: 0x04006C6D RID: 27757
	private List<HandBookEntrance> HandBookEntranceList;

	// Token: 0x04006C6E RID: 27758
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<HandBookEntranceItem, HandBookEntrance> ScrollView;

	// Token: 0x04006C6F RID: 27759
	private List<HandBookEntranceItem> HandBookEntranceItemList;

	// Token: 0x04006C70 RID: 27760
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;
}
