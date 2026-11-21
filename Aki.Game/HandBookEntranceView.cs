using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012C6 RID: 4806
[NullableContext(1)]
[Nullable(0)]
public class HandBookEntranceView : UiViewBase
{
	// Token: 0x0600BDC6 RID: 48582 RVA: 0x003804DD File Offset: 0x0037E6DD
	public HandBookEntranceView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.HandBookEntranceList = new List<HandBookEntrance>();
		this.HandBookEntranceItemList = new List<HandBookEntranceItem>();
	}

	// Token: 0x0600BDC7 RID: 48583 RVA: 0x003804FC File Offset: 0x0037E6FC
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

	// Token: 0x0600BDC8 RID: 48584 RVA: 0x0038056C File Offset: 0x0037E76C
	protected override UniTask OnBeforeStartAsync()
	{
		HandBookEntranceView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HandBookEntranceView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BDC9 RID: 48585 RVA: 0x003805A7 File Offset: 0x0037E7A7
	protected override void OnStart()
	{
		this.InitCommonTabTitle();
		this.OnHandBookRedDotUpdate();
		this.OnHandBookDataInit();
	}

	// Token: 0x0600BDCA RID: 48586 RVA: 0x003805BB File Offset: 0x0037E7BB
	protected override void OnBeforeShow()
	{
		HandBookController.Instance.SendIllustratedRedDotRequest().ContinueWith(new Action(this.OnHandBookRedDotUpdate)).Forget();
	}

	// Token: 0x0600BDCB RID: 48587 RVA: 0x003805DD File Offset: 0x0037E7DD
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

	// Token: 0x0600BDCC RID: 48588 RVA: 0x003805F8 File Offset: 0x0037E7F8
	protected void OnHandBookRedDotUpdate()
	{
		int count = this.HandBookEntranceItemList.Count;
		for (int i = 0; i < count; i++)
		{
			this.HandBookEntranceItemList[i].RefreshRedDot();
		}
	}

	// Token: 0x0600BDCD RID: 48589 RVA: 0x00380630 File Offset: 0x0037E830
	protected void InitCommonTabTitle()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("HandBookEntrance");
		string textContentIdById = TextConfig.Instance.GetTextContentIdById("HandBookEntrance");
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseButton));
		this.CaptionItem.SetTitleLocalText(textContentIdById);
		this.CaptionItem.SetTitleIcon(resourcePath);
	}

	// Token: 0x0600BDCE RID: 48590 RVA: 0x003806A0 File Offset: 0x0037E8A0
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

	// Token: 0x0600BDCF RID: 48591 RVA: 0x0038076C File Offset: 0x0037E96C
	private HandBookEntranceItem InitItem()
	{
		HandBookEntranceItem handBookEntranceItem = new HandBookEntranceItem();
		this.HandBookEntranceItemList.Add(handBookEntranceItem);
		return handBookEntranceItem;
	}

	// Token: 0x0600BDD0 RID: 48592 RVA: 0x0038078C File Offset: 0x0037E98C
	private int SortIndex(HandBookEntrance a, HandBookEntrance b)
	{
		return a.SortId - b.SortId;
	}

	// Token: 0x0600BDD1 RID: 48593 RVA: 0x0038079D File Offset: 0x0037E99D
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.HandBookEntranceView, null);
	}

	// Token: 0x0600BDD2 RID: 48594 RVA: 0x003807AF File Offset: 0x0037E9AF
	protected override void OnBeforeDestroy()
	{
		this.HandBookEntranceList = new List<HandBookEntrance>();
		this.HandBookEntranceItemList = new List<HandBookEntranceItem>();
	}

	// Token: 0x04006D4E RID: 27982
	private List<HandBookEntrance> HandBookEntranceList;

	// Token: 0x04006D4F RID: 27983
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<HandBookEntranceItem, HandBookEntrance> ScrollView;

	// Token: 0x04006D50 RID: 27984
	private List<HandBookEntranceItem> HandBookEntranceItemList;

	// Token: 0x04006D51 RID: 27985
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;
}
