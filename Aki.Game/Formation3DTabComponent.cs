using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010BE RID: 4286
[NullableContext(1)]
[Nullable(0)]
public class Formation3DTabComponent : UiPanelBase, IFormationTabComponent
{
	// Token: 0x0600AA06 RID: 43526 RVA: 0x00322013 File Offset: 0x00320213
	public Formation3DTabComponent(UUIItem uiItem, CommonTabComponentData<EditFormationTabItem> data, Func<int, bool> isCurrentTab)
	{
		this.TabComponentData = data;
		this.IsCurrentTab = isCurrentTab;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600AA07 RID: 43527 RVA: 0x00322036 File Offset: 0x00320236
	void IFormationTabComponent.Destroy()
	{
		base.Destroy(null);
	}

	// Token: 0x0600AA08 RID: 43528 RVA: 0x00322040 File Offset: 0x00320240
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600AA09 RID: 43529 RVA: 0x003220AC File Offset: 0x003202AC
	protected override void OnStart()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(1);
		this.TabLoopScrollView = new LoopScrollView<Formation3DTabItem, CommonTabItemData>(loopScrollViewComponent, loopScrollViewComponent.TemplateGrid, new Func<Formation3DTabItem>(this.ProxyCreate), false);
		this.TabTitle = new CommonTabTitle(base.GetItem(0));
	}

	// Token: 0x0600AA0A RID: 43530 RVA: 0x003220F7 File Offset: 0x003202F7
	protected override void OnBeforeDestroy()
	{
		CommonTabTitle tabTitle = this.TabTitle;
		if (tabTitle != null)
		{
			tabTitle.Destroy(null);
		}
		this.TabTitle = null;
		this.TabLoopScrollView = null;
	}

	// Token: 0x0600AA0B RID: 43531 RVA: 0x00322119 File Offset: 0x00320319
	private Formation3DTabItem ProxyCreate()
	{
		Formation3DTabItem formation3DTabItem = new Formation3DTabItem(this.IsCurrentTab);
		formation3DTabItem.InitTabItem();
		formation3DTabItem.SetSelectedCallBack(new Action<int>(this.ToggleCallBack));
		formation3DTabItem.SetCanExecuteChange(new Func<int, bool, bool>(this.CanExecuteChange));
		return formation3DTabItem;
	}

	// Token: 0x0600AA0C RID: 43532 RVA: 0x00322150 File Offset: 0x00320350
	private bool CanExecuteChange(int index, bool forceSwitch)
	{
		if (this.TabLoopScrollView.GetSelectedGridIndex() == index && !forceSwitch)
		{
			return false;
		}
		Func<int, bool> canExecuteChangeInternal = this.CanExecuteChangeInternal;
		return canExecuteChangeInternal == null || canExecuteChangeInternal(index);
	}

	// Token: 0x0600AA0D RID: 43533 RVA: 0x00322178 File Offset: 0x00320378
	private void ToggleCallBack(int index)
	{
		this.TabLoopScrollView.SelectGridProxy(index, false);
		CommonTabData commonTabData = this.TabComponentData.GetCommonData(index);
		if (commonTabData != null)
		{
			this.TabTitle.UpdateIcon(commonTabData.GetSmallIcon());
			this.TabTitle.UpdateTitle(commonTabData.GetTitleData());
		}
		this.TabComponentData.ToggleCallBack(index);
	}

	// Token: 0x0600AA0E RID: 43534 RVA: 0x003221DC File Offset: 0x003203DC
	public UniTask RefreshTabItemAsync(int length)
	{
		Formation3DTabComponent.<RefreshTabItemAsync>d__14 <RefreshTabItemAsync>d__;
		<RefreshTabItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabItemAsync>d__.<>4__this = this;
		<RefreshTabItemAsync>d__.length = length;
		<RefreshTabItemAsync>d__.<>1__state = -1;
		<RefreshTabItemAsync>d__.<>t__builder.Start<Formation3DTabComponent.<RefreshTabItemAsync>d__14>(ref <RefreshTabItemAsync>d__);
		return <RefreshTabItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AA0F RID: 43535 RVA: 0x00322227 File Offset: 0x00320427
	public void SelectToggleByIndex(int index, bool bIgnored = false)
	{
		if (bIgnored)
		{
			this.TabLoopScrollView.DeselectCurrentGridProxy(false);
		}
		if (this.TabLoopScrollView.GetSelectedGridIndex() == index || !this.CanExecuteChange(index, true))
		{
			return;
		}
		this.TabLoopScrollView.SelectGridProxy(index, false);
		this.ToggleCallBack(index);
	}

	// Token: 0x0600AA10 RID: 43536 RVA: 0x00322265 File Offset: 0x00320465
	public int GetSelectedIndex()
	{
		return this.TabLoopScrollView.GetSelectedGridIndex();
	}

	// Token: 0x0600AA11 RID: 43537 RVA: 0x00322272 File Offset: 0x00320472
	public void ScrollToToggleByIndex(int index)
	{
		this.TabLoopScrollView.ScrollToGridIndexLate(index, false);
	}

	// Token: 0x0600AA12 RID: 43538 RVA: 0x00322284 File Offset: 0x00320484
	public void SetInitialNavigationFocus()
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		int selectedIndex = this.GetSelectedIndex();
		if (selectedIndex < 0)
		{
			return;
		}
		this.TabLoopScrollView.ScrollToGridIndex(selectedIndex, false);
		EditFormationTabItem tabItemByIndex = this.GetTabItemByIndex(selectedIndex);
		if (tabItemByIndex == null || tabItemByIndex.GridIndex != selectedIndex)
		{
			return;
		}
		UiNavigationNewController.Instance.SetNavigationFocusForView(tabItemByIndex.GetRootItem(), true, true, true);
	}

	// Token: 0x0600AA13 RID: 43539 RVA: 0x003222E0 File Offset: 0x003204E0
	[NullableContext(2)]
	public EditFormationTabItem GetTabItemByIndex(int index)
	{
		if (!this.TabLoopScrollView.IsGridDisplaying(index))
		{
			return null;
		}
		return this.TabLoopScrollView.UnsafeGetGridProxy(index, false);
	}

	// Token: 0x0600AA14 RID: 43540 RVA: 0x00322300 File Offset: 0x00320500
	public void RefreshTitleByIndex(int index)
	{
		CommonTabData commonTabData = this.TabComponentData.GetCommonData(index);
		if (commonTabData != null)
		{
			this.TabTitle.UpdateTitle(commonTabData.GetTitleData());
		}
	}

	// Token: 0x0600AA15 RID: 43541 RVA: 0x00322333 File Offset: 0x00320533
	public void SetCanChange(Func<int, bool> callback)
	{
		this.CanExecuteChangeInternal = callback;
	}

	// Token: 0x040062AD RID: 25261
	private readonly CommonTabComponentData<EditFormationTabItem> TabComponentData;

	// Token: 0x040062AE RID: 25262
	private readonly Func<int, bool> IsCurrentTab;

	// Token: 0x040062AF RID: 25263
	[Nullable(2)]
	private CommonTabTitle TabTitle;

	// Token: 0x040062B0 RID: 25264
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<Formation3DTabItem, CommonTabItemData> TabLoopScrollView;

	// Token: 0x040062B1 RID: 25265
	[Nullable(2)]
	private Func<int, bool> CanExecuteChangeInternal;

	// Token: 0x0200732F RID: 29487
	[NullableContext(0)]
	private enum EFormation3DTabComponent
	{
		// Token: 0x0402580C RID: 153612
		Title,
		// Token: 0x0402580D RID: 153613
		LoopScrollView
	}
}
