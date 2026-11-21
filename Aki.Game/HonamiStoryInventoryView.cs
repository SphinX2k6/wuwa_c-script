using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200137C RID: 4988
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryInventoryView : UiViewBase
{
	// Token: 0x0600C628 RID: 50728 RVA: 0x003B00D4 File Offset: 0x003AE2D4
	public HonamiStoryInventoryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C629 RID: 50729 RVA: 0x003B00E0 File Offset: 0x003AE2E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C62A RID: 50730 RVA: 0x003B014C File Offset: 0x003AE34C
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryInventoryView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryInventoryView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C62B RID: 50731 RVA: 0x003B018F File Offset: 0x003AE38F
	protected override void OnBeforeShow()
	{
		TabComponentWithCaptionItem<CalabashTabItem> captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SelectToggleByIndex(0, true);
	}

	// Token: 0x0600C62C RID: 50732 RVA: 0x003B01A4 File Offset: 0x003AE3A4
	private UniTask InitCaption()
	{
		HonamiStoryInventoryView.<InitCaption>d__8 <InitCaption>d__;
		<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaption>d__.<>4__this = this;
		<InitCaption>d__.<>1__state = -1;
		<InitCaption>d__.<>t__builder.Start<HonamiStoryInventoryView.<InitCaption>d__8>(ref <InitCaption>d__);
		return <InitCaption>d__.<>t__builder.Task;
	}

	// Token: 0x0600C62D RID: 50733 RVA: 0x003B01E7 File Offset: 0x003AE3E7
	private CalabashTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? _)
	{
		return new CalabashTabItem();
	}

	// Token: 0x0600C62E RID: 50734 RVA: 0x003B01F0 File Offset: 0x003AE3F0
	private void ToggleCallBack(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		string childViewName = uiDynamicTab.ChildViewName;
		CalabashTabItem tabItemByIndex = this.CaptionItem.GetTabItemByIndex(index);
		this.TabViewComponent.ToggleCallBack(uiDynamicTab, (EUiTabViewName)childViewName, tabItemByIndex, null, null);
	}

	// Token: 0x0600C62F RID: 50735 RVA: 0x003B0241 File Offset: 0x003AE441
	private bool CheckTabViewCloseToRoot()
	{
		return false;
	}

	// Token: 0x0600C630 RID: 50736 RVA: 0x003B0244 File Offset: 0x003AE444
	private void OnClickBtnClose()
	{
		if (this.CheckTabViewCloseToRoot())
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600C631 RID: 50737 RVA: 0x003B0258 File Offset: 0x003AE458
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = CalabashModel.Instance.GetViewTabList()[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x040070B8 RID: 28856
	private List<UiDynamicTab> TabDataList;

	// Token: 0x040070B9 RID: 28857
	private TabComponentWithCaptionItem<CalabashTabItem> CaptionItem;

	// Token: 0x040070BA RID: 28858
	private TabViewComponent<object> TabViewComponent;

	// Token: 0x02007626 RID: 30246
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040265E4 RID: 157156
		CaptionItem,
		// Token: 0x040265E5 RID: 157157
		Content
	}
}
