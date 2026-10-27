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

// Token: 0x02001BFF RID: 7167
[NullableContext(1)]
[Nullable(0)]
public class Formation3DTabComponent : UiPanelBase, IFormationTabComponent
{
	// Token: 0x0600D5F3 RID: 54771 RVA: 0x00316D3B File Offset: 0x00314F3B
	public Formation3DTabComponent(UUIItem uiItem, CommonTabComponentData<EditFormationTabItem> data, Func<int, bool> isCurrentTab)
	{
		this.TabComponentData = data;
		this.IsCurrentTab = isCurrentTab;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600D5F4 RID: 54772 RVA: 0x00316D5E File Offset: 0x00314F5E
	void IFormationTabComponent.Destroy()
	{
		base.Destroy(null);
	}

	// Token: 0x0600D5F5 RID: 54773 RVA: 0x00316D68 File Offset: 0x00314F68
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

	// Token: 0x0600D5F6 RID: 54774 RVA: 0x00316DD4 File Offset: 0x00314FD4
	protected override void OnStart()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(1);
		this.TabLoopScrollView = new LoopScrollView<Formation3DTabItem, CommonTabItemData>(loopScrollViewComponent, loopScrollViewComponent.TemplateGrid, new Func<Formation3DTabItem>(this.ProxyCreate), false);
		this.TabTitle = new CommonTabTitle(base.GetItem(0));
	}

	// Token: 0x0600D5F7 RID: 54775 RVA: 0x00316E1F File Offset: 0x0031501F
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

	// Token: 0x0600D5F8 RID: 54776 RVA: 0x00316E41 File Offset: 0x00315041
	private Formation3DTabItem ProxyCreate()
	{
		Formation3DTabItem formation3DTabItem = new Formation3DTabItem(this.IsCurrentTab);
		formation3DTabItem.InitTabItem();
		formation3DTabItem.SetSelectedCallBack(new Action<int>(this.ToggleCallBack));
		formation3DTabItem.SetCanExecuteChange(new Func<int, bool, bool>(this.CanExecuteChange));
		return formation3DTabItem;
	}

	// Token: 0x0600D5F9 RID: 54777 RVA: 0x00316E78 File Offset: 0x00315078
	private bool CanExecuteChange(int index, bool forceSwitch)
	{
		if (this.TabLoopScrollView.GetSelectedGridIndex() == index && !forceSwitch)
		{
			return false;
		}
		Func<int, bool> canExecuteChangeInternal = this.CanExecuteChangeInternal;
		return canExecuteChangeInternal == null || canExecuteChangeInternal(index);
	}

	// Token: 0x0600D5FA RID: 54778 RVA: 0x00316EA0 File Offset: 0x003150A0
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

	// Token: 0x0600D5FB RID: 54779 RVA: 0x00316F04 File Offset: 0x00315104
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

	// Token: 0x0600D5FC RID: 54780 RVA: 0x00316F4F File Offset: 0x0031514F
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

	// Token: 0x0600D5FD RID: 54781 RVA: 0x00316F8D File Offset: 0x0031518D
	public int GetSelectedIndex()
	{
		return this.TabLoopScrollView.GetSelectedGridIndex();
	}

	// Token: 0x0600D5FE RID: 54782 RVA: 0x00316F9A File Offset: 0x0031519A
	public void ScrollToToggleByIndex(int index)
	{
		this.TabLoopScrollView.ScrollToGridIndexLate(index, false);
	}

	// Token: 0x0600D5FF RID: 54783 RVA: 0x00316FAC File Offset: 0x003151AC
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

	// Token: 0x0600D600 RID: 54784 RVA: 0x00317008 File Offset: 0x00315208
	[NullableContext(2)]
	public EditFormationTabItem GetTabItemByIndex(int index)
	{
		if (!this.TabLoopScrollView.IsGridDisplaying(index))
		{
			return null;
		}
		return this.TabLoopScrollView.UnsafeGetGridProxy(index, false);
	}

	// Token: 0x0600D601 RID: 54785 RVA: 0x00317028 File Offset: 0x00315228
	public void RefreshTitleByIndex(int index)
	{
		CommonTabData commonTabData = this.TabComponentData.GetCommonData(index);
		if (commonTabData != null)
		{
			this.TabTitle.UpdateTitle(commonTabData.GetTitleData());
		}
	}

	// Token: 0x0600D602 RID: 54786 RVA: 0x0031705B File Offset: 0x0031525B
	public void SetCanChange(Func<int, bool> callback)
	{
		this.CanExecuteChangeInternal = callback;
	}

	// Token: 0x040061DB RID: 25051
	private readonly CommonTabComponentData<EditFormationTabItem> TabComponentData;

	// Token: 0x040061DC RID: 25052
	private readonly Func<int, bool> IsCurrentTab;

	// Token: 0x040061DD RID: 25053
	[Nullable(2)]
	private CommonTabTitle TabTitle;

	// Token: 0x040061DE RID: 25054
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<Formation3DTabItem, CommonTabItemData> TabLoopScrollView;

	// Token: 0x040061DF RID: 25055
	[Nullable(2)]
	private Func<int, bool> CanExecuteChangeInternal;

	// Token: 0x020081A4 RID: 33188
	[NullableContext(0)]
	private enum EFormation3DTabComponent
	{
		// Token: 0x0402A4E1 RID: 173281
		Title,
		// Token: 0x0402A4E2 RID: 173282
		LoopScrollView
	}
}
