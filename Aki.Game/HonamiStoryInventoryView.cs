using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EBA RID: 7866
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryInventoryView : UiViewBase
{
	// Token: 0x0600F209 RID: 61961 RVA: 0x003A45D4 File Offset: 0x003A27D4
	public HonamiStoryInventoryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F20A RID: 61962 RVA: 0x003A45E0 File Offset: 0x003A27E0
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

	// Token: 0x0600F20B RID: 61963 RVA: 0x003A464C File Offset: 0x003A284C
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryInventoryView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryInventoryView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F20C RID: 61964 RVA: 0x003A468F File Offset: 0x003A288F
	protected override void OnBeforeShow()
	{
		TabComponentWithCaptionItem<CalabashTabItem> captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SelectToggleByIndex(0, true);
	}

	// Token: 0x0600F20D RID: 61965 RVA: 0x003A46A4 File Offset: 0x003A28A4
	private UniTask InitCaption()
	{
		HonamiStoryInventoryView.<InitCaption>d__8 <InitCaption>d__;
		<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaption>d__.<>4__this = this;
		<InitCaption>d__.<>1__state = -1;
		<InitCaption>d__.<>t__builder.Start<HonamiStoryInventoryView.<InitCaption>d__8>(ref <InitCaption>d__);
		return <InitCaption>d__.<>t__builder.Task;
	}

	// Token: 0x0600F20E RID: 61966 RVA: 0x003A46E7 File Offset: 0x003A28E7
	private CalabashTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? _)
	{
		return new CalabashTabItem();
	}

	// Token: 0x0600F20F RID: 61967 RVA: 0x003A46F0 File Offset: 0x003A28F0
	private void ToggleCallBack(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		string childViewName = uiDynamicTab.ChildViewName;
		CalabashTabItem tabItemByIndex = this.CaptionItem.GetTabItemByIndex(index);
		this.TabViewComponent.ToggleCallBack(uiDynamicTab, (EUiTabViewName)childViewName, tabItemByIndex, null, null);
	}

	// Token: 0x0600F210 RID: 61968 RVA: 0x003A4741 File Offset: 0x003A2941
	private bool CheckTabViewCloseToRoot()
	{
		return false;
	}

	// Token: 0x0600F211 RID: 61969 RVA: 0x003A4744 File Offset: 0x003A2944
	private void OnClickBtnClose()
	{
		if (this.CheckTabViewCloseToRoot())
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600F212 RID: 61970 RVA: 0x003A4758 File Offset: 0x003A2958
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = CalabashModel.Instance.GetViewTabList()[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x04006FD7 RID: 28631
	private List<UiDynamicTab> TabDataList;

	// Token: 0x04006FD8 RID: 28632
	private TabComponentWithCaptionItem<CalabashTabItem> CaptionItem;

	// Token: 0x04006FD9 RID: 28633
	private TabViewComponent<object> TabViewComponent;

	// Token: 0x020084A1 RID: 33953
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B2C0 RID: 176832
		CaptionItem,
		// Token: 0x0402B2C1 RID: 176833
		Content
	}
}
