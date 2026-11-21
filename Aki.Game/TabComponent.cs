using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E73 RID: 3699
[NullableContext(1)]
[Nullable(0)]
public class TabComponent<[Nullable(0)] TTabItem> : UiPanelBase where TTabItem : CommonTabItemBase
{
	// Token: 0x060093F6 RID: 37878 RVA: 0x002BFB17 File Offset: 0x002BDD17
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

	// Token: 0x060093F7 RID: 37879 RVA: 0x002BFB4C File Offset: 0x002BDD4C
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

	// Token: 0x060093F8 RID: 37880 RVA: 0x002BFB94 File Offset: 0x002BDD94
	protected override void OnStart()
	{
		AUIBaseActor gridActor = (this.LayoutOriginItem != null) ? (this.LayoutOriginItem.GetOwner() as AUIBaseActor) : null;
		this.Layout = new GenericLayout<TTabItem, CommonTabItemData>(base.GetLayoutBase(0), new Func<TTabItem>(this.InitTabItem), gridActor, false, true);
	}

	// Token: 0x060093F9 RID: 37881 RVA: 0x002BFBDE File Offset: 0x002BDDDE
	protected override void OnBeforeDestroy()
	{
		this.LayoutOriginItem = null;
	}

	// Token: 0x060093FA RID: 37882 RVA: 0x002BFBE8 File Offset: 0x002BDDE8
	private TTabItem InitTabItem()
	{
		TTabItem ttabItem = this.ProxyCreate(null, null);
		ttabItem.InitTabItem();
		ttabItem.SetSelectedCallBack(new Action<int>(this.ToggleEvent));
		ttabItem.SetCanExecuteChange(new Func<int, bool, bool>(this.CanExecuteChange));
		return ttabItem;
	}

	// Token: 0x060093FB RID: 37883 RVA: 0x002BFC43 File Offset: 0x002BDE43
	private void ToggleEvent(int index)
	{
		this.SwitchLastToggle();
		this.CurrentIndex = index;
		this.ToggleCallBack(index);
	}

	// Token: 0x060093FC RID: 37884 RVA: 0x002BFC60 File Offset: 0x002BDE60
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

	// Token: 0x060093FD RID: 37885 RVA: 0x002BFCA3 File Offset: 0x002BDEA3
	private bool CanExecuteChange(int index, bool forceSwitch)
	{
		return (this.CurrentIndex != index || forceSwitch) && (this.CanExecuteChangeInternal == null || this.CanExecuteChangeInternal(index, new bool?(forceSwitch)));
	}

	// Token: 0x060093FE RID: 37886 RVA: 0x002BFCD0 File Offset: 0x002BDED0
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

	// Token: 0x060093FF RID: 37887 RVA: 0x002BFD20 File Offset: 0x002BDF20
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

	// Token: 0x06009400 RID: 37888 RVA: 0x002BFD74 File Offset: 0x002BDF74
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

	// Token: 0x06009401 RID: 37889 RVA: 0x002BFDB0 File Offset: 0x002BDFB0
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

	// Token: 0x06009402 RID: 37890 RVA: 0x002BFDFC File Offset: 0x002BDFFC
	public void ResetLastSelectTab()
	{
		TTabItem layoutItemByKey = this.Layout.GetLayoutItemByKey(this.CurrentIndex);
		if (layoutItemByKey != null)
		{
			layoutItemByKey.SetForceSwitch(EToggleState.ETT_UnChecked, false);
		}
	}

	// Token: 0x06009403 RID: 37891 RVA: 0x002BFE38 File Offset: 0x002BE038
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

	// Token: 0x06009404 RID: 37892 RVA: 0x002BFE7F File Offset: 0x002BE07F
	public int GetSelectedIndex()
	{
		return this.CurrentIndex;
	}

	// Token: 0x06009405 RID: 37893 RVA: 0x002BFE87 File Offset: 0x002BE087
	public int TryGetSelectedIndex(int defaultValue)
	{
		if (this.CurrentIndex == -1)
		{
			return defaultValue;
		}
		return this.CurrentIndex;
	}

	// Token: 0x06009406 RID: 37894 RVA: 0x002BFE9A File Offset: 0x002BE09A
	public void ResetSelectIndex()
	{
		this.ResetLastSelectTab();
		this.CurrentIndex = -1;
	}

	// Token: 0x06009407 RID: 37895 RVA: 0x002BFEA9 File Offset: 0x002BE0A9
	[NullableContext(2)]
	public TTabItem GetTabItemByIndex(int index)
	{
		return this.Layout.GetLayoutItemByKey(index);
	}

	// Token: 0x06009408 RID: 37896 RVA: 0x002BFEBC File Offset: 0x002BE0BC
	public Dictionary<int, TTabItem> GetTabItemMap()
	{
		Dictionary<int, TTabItem> dictionary = new Dictionary<int, TTabItem>();
		foreach (KeyValuePair<object, TTabItem> keyValuePair in this.Layout.GetLayoutItemMap())
		{
			dictionary.Add((int)keyValuePair.Key, keyValuePair.Value);
		}
		return dictionary;
	}

	// Token: 0x06009409 RID: 37897 RVA: 0x002BFF30 File Offset: 0x002BE130
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

	// Token: 0x0600940A RID: 37898 RVA: 0x002BFF38 File Offset: 0x002BE138
	public void SetCanChange(Func<int, bool?, bool> callback)
	{
		this.CanExecuteChangeInternal = callback;
	}

	// Token: 0x04005700 RID: 22272
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TTabItem, CommonTabItemData> Layout;

	// Token: 0x04005701 RID: 22273
	private int CurrentIndex = -1;

	// Token: 0x04005702 RID: 22274
	[Nullable(2)]
	private UUIItem LayoutOriginItem;

	// Token: 0x04005703 RID: 22275
	[Nullable(2)]
	private Func<int, bool?, bool> CanExecuteChangeInternal;

	// Token: 0x04005704 RID: 22276
	[Nullable(new byte[]
	{
		1,
		2,
		1
	})]
	public readonly Func<UUIItem, int?, TTabItem> ProxyCreate;

	// Token: 0x04005705 RID: 22277
	public readonly Action<int> ToggleCallBack;

	// Token: 0x02007067 RID: 28775
	[NullableContext(0)]
	private class ETabComponent
	{
		// Token: 0x04024A6E RID: 150126
		public const int Layout = 0;
	}
}
