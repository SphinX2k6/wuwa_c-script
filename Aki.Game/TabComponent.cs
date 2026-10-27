using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019B5 RID: 6581
[NullableContext(1)]
[Nullable(0)]
public class TabComponent<[Nullable(0)] TTabItem> : UiPanelBase where TTabItem : CommonTabItemBase
{
	// Token: 0x0600BFEC RID: 49132 RVA: 0x002B4B87 File Offset: 0x002B2D87
	public TabComponent(UUIItem uiItem, [Nullable(new byte[]
	{
		1,
		2,
		1
	})] Func<UUIItem, int?, TTabItem> proxyCreate, Action<int> toggleCallBack, [Nullable(2)] UUIItem layoutOriginItem)
	{
		this.ProxyCreate = proxyCreate;
		this.ToggleCallBack = toggleCallBack;
		this.LayoutOriginItem = layoutOriginItem;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600BFED RID: 49133 RVA: 0x002B4BBC File Offset: 0x002B2DBC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BFEE RID: 49134 RVA: 0x002B4C04 File Offset: 0x002B2E04
	protected override void OnStart()
	{
		AUIBaseActor gridActor = (this.LayoutOriginItem != null) ? (this.LayoutOriginItem.GetOwner() as AUIBaseActor) : null;
		this.Layout = new GenericLayout<TTabItem, CommonTabItemData>(base.GetLayoutBase(0), new Func<TTabItem>(this.InitTabItem), gridActor, false, true);
	}

	// Token: 0x0600BFEF RID: 49135 RVA: 0x002B4C4E File Offset: 0x002B2E4E
	protected override void OnBeforeDestroy()
	{
		this.LayoutOriginItem = null;
	}

	// Token: 0x0600BFF0 RID: 49136 RVA: 0x002B4C58 File Offset: 0x002B2E58
	private TTabItem InitTabItem()
	{
		TTabItem ttabItem = this.ProxyCreate(null, null);
		ttabItem.InitTabItem();
		ttabItem.SetSelectedCallBack(new Action<int>(this.ToggleEvent));
		ttabItem.SetCanExecuteChange(new Func<int, bool, bool>(this.CanExecuteChange));
		return ttabItem;
	}

	// Token: 0x0600BFF1 RID: 49137 RVA: 0x002B4CB3 File Offset: 0x002B2EB3
	private void ToggleEvent(int index)
	{
		this.SwitchLastToggle();
		this.CurrentIndex = index;
		this.ToggleCallBack(index);
	}

	// Token: 0x0600BFF2 RID: 49138 RVA: 0x002B4CD0 File Offset: 0x002B2ED0
	private void SwitchLastToggle()
	{
		if (this.CurrentIndex == -1)
		{
			return;
		}
		TTabItem layoutItemByKey = this.Layout.GetLayoutItemByKey(this.CurrentIndex);
		if (layoutItemByKey != null)
		{
			layoutItemByKey.SetForceSwitch(EToggleState.ETT_UnChecked, false);
		}
	}

	// Token: 0x0600BFF3 RID: 49139 RVA: 0x002B4D13 File Offset: 0x002B2F13
	private bool CanExecuteChange(int index, bool forceSwitch)
	{
		return (this.CurrentIndex != index || forceSwitch) && (this.CanExecuteChangeInternal == null || this.CanExecuteChangeInternal(index, new bool?(forceSwitch)));
	}

	// Token: 0x0600BFF4 RID: 49140 RVA: 0x002B4D40 File Offset: 0x002B2F40
	public void RefreshTabItem(List<CommonTabItemData> array, [Nullable(2)] Action callBack = null)
	{
		if (this.CurrentIndex != -1)
		{
			TTabItem ttabItem = this.Layout.GetLayoutItemByIndex(this.CurrentIndex);
			if (ttabItem != null)
			{
				ttabItem.SetForceSwitch(EToggleState.ETT_UnChecked, false);
			}
		}
		this.CurrentIndex = -1;
		this.Layout.RefreshByData(array, callBack, false);
	}

	// Token: 0x0600BFF5 RID: 49141 RVA: 0x002B4D90 File Offset: 0x002B2F90
	public UniTask RefreshTabItemAsync(List<CommonTabItemData> array, bool resetSelect = true)
	{
		TabComponent<TTabItem>.<RefreshTabItemAsync>d__16 <RefreshTabItemAsync>d__;
		<RefreshTabItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabItemAsync>d__.<>4__this = this;
		<RefreshTabItemAsync>d__.array = array;
		<RefreshTabItemAsync>d__.resetSelect = resetSelect;
		<RefreshTabItemAsync>d__.<>1__state = -1;
		<RefreshTabItemAsync>d__.<>t__builder.Start<TabComponent<TTabItem>.<RefreshTabItemAsync>d__16>(ref <RefreshTabItemAsync>d__);
		return <RefreshTabItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BFF6 RID: 49142 RVA: 0x002B4DE4 File Offset: 0x002B2FE4
	[NullableContext(2)]
	public void RefreshTabItemByLength(int length, Action callBack = null)
	{
		List<CommonTabItemData> list = new List<CommonTabItemData>();
		for (int i = 0; i < length; i++)
		{
			list.Add(new CommonTabItemData
			{
				Index = i
			});
		}
		this.RefreshTabItem(list, callBack);
	}

	// Token: 0x0600BFF7 RID: 49143 RVA: 0x002B4E20 File Offset: 0x002B3020
	public UniTask RefreshTabItemByLengthAsync(int length)
	{
		TabComponent<TTabItem>.<RefreshTabItemByLengthAsync>d__18 <RefreshTabItemByLengthAsync>d__;
		<RefreshTabItemByLengthAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabItemByLengthAsync>d__.<>4__this = this;
		<RefreshTabItemByLengthAsync>d__.length = length;
		<RefreshTabItemByLengthAsync>d__.<>1__state = -1;
		<RefreshTabItemByLengthAsync>d__.<>t__builder.Start<TabComponent<TTabItem>.<RefreshTabItemByLengthAsync>d__18>(ref <RefreshTabItemByLengthAsync>d__);
		return <RefreshTabItemByLengthAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BFF8 RID: 49144 RVA: 0x002B4E6C File Offset: 0x002B306C
	public void ResetLastSelectTab()
	{
		TTabItem layoutItemByKey = this.Layout.GetLayoutItemByKey(this.CurrentIndex);
		if (layoutItemByKey != null)
		{
			layoutItemByKey.SetForceSwitch(EToggleState.ETT_UnChecked, false);
		}
	}

	// Token: 0x0600BFF9 RID: 49145 RVA: 0x002B4EA8 File Offset: 0x002B30A8
	public void SelectToggleByIndex(int index, bool bIgnored = false, bool bFire = true)
	{
		if (bIgnored)
		{
			this.ResetSelectIndex();
		}
		if (index == this.CurrentIndex)
		{
			return;
		}
		TTabItem layoutItemByKey = this.Layout.GetLayoutItemByKey(index);
		if (layoutItemByKey != null)
		{
			layoutItemByKey.SetForceSwitch(EToggleState.ETT_Checked, bFire);
		}
	}

	// Token: 0x0600BFFA RID: 49146 RVA: 0x002B4EEF File Offset: 0x002B30EF
	public int GetSelectedIndex()
	{
		return this.CurrentIndex;
	}

	// Token: 0x0600BFFB RID: 49147 RVA: 0x002B4EF7 File Offset: 0x002B30F7
	public int TryGetSelectedIndex(int defaultValue)
	{
		if (this.CurrentIndex == -1)
		{
			return defaultValue;
		}
		return this.CurrentIndex;
	}

	// Token: 0x0600BFFC RID: 49148 RVA: 0x002B4F0A File Offset: 0x002B310A
	public void ResetSelectIndex()
	{
		this.ResetLastSelectTab();
		this.CurrentIndex = -1;
	}

	// Token: 0x0600BFFD RID: 49149 RVA: 0x002B4F19 File Offset: 0x002B3119
	[NullableContext(2)]
	public TTabItem GetTabItemByIndex(int index)
	{
		return this.Layout.GetLayoutItemByKey(index);
	}

	// Token: 0x0600BFFE RID: 49150 RVA: 0x002B4F2C File Offset: 0x002B312C
	public Dictionary<int, TTabItem> GetTabItemMap()
	{
		Dictionary<int, TTabItem> dictionary = new Dictionary<int, TTabItem>();
		foreach (KeyValuePair<object, TTabItem> keyValuePair in this.Layout.GetLayoutItemMap())
		{
			dictionary.Add((int)keyValuePair.Key, keyValuePair.Value);
		}
		return dictionary;
	}

	// Token: 0x0600BFFF RID: 49151 RVA: 0x002B4FA0 File Offset: 0x002B31A0
	[return: Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<TTabItem, CommonTabItemData> GetLayout()
	{
		return this.Layout;
	}

	// Token: 0x0600C000 RID: 49152 RVA: 0x002B4FA8 File Offset: 0x002B31A8
	public void SetCanChange(Func<int, bool?, bool> callback)
	{
		this.CanExecuteChangeInternal = callback;
	}

	// Token: 0x0400564E RID: 22094
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TTabItem, CommonTabItemData> Layout;

	// Token: 0x0400564F RID: 22095
	private int CurrentIndex = -1;

	// Token: 0x04005650 RID: 22096
	[Nullable(2)]
	private UUIItem LayoutOriginItem;

	// Token: 0x04005651 RID: 22097
	[Nullable(2)]
	private Func<int, bool?, bool> CanExecuteChangeInternal;

	// Token: 0x04005652 RID: 22098
	[Nullable(new byte[]
	{
		1,
		2,
		1
	})]
	public readonly Func<UUIItem, int?, TTabItem> ProxyCreate;

	// Token: 0x04005653 RID: 22099
	public readonly Action<int> ToggleCallBack;

	// Token: 0x02007ED8 RID: 32472
	[NullableContext(0)]
	private class ETabComponent
	{
		// Token: 0x04029731 RID: 169777
		public const int Layout = 0;
	}
}
