using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019B4 RID: 6580
[NullableContext(1)]
[Nullable(0)]
public class StaticTabComponent<[Nullable(0)] TTabItem> : UiPanelBase where TTabItem : CommonTabItemBase
{
	// Token: 0x0600BFDF RID: 49119 RVA: 0x002B489B File Offset: 0x002B2A9B
	public StaticTabComponent(Func<UUIItem, int, TTabItem> proxyCreate, Action<int> toggleCallBack)
	{
		this.ProxyCreate = proxyCreate;
		this.ToggleCallBack = toggleCallBack;
	}

	// Token: 0x0600BFE0 RID: 49120 RVA: 0x002B48B8 File Offset: 0x002B2AB8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x0600BFE1 RID: 49121 RVA: 0x002B48E6 File Offset: 0x002B2AE6
	public void Init(List<UUIItem> items)
	{
		this.RegistTabItem(items);
	}

	// Token: 0x0600BFE2 RID: 49122 RVA: 0x002B48F0 File Offset: 0x002B2AF0
	public void RegistTabItem(List<UUIItem> items)
	{
		this.Layout = new List<ILayoutItem<TTabItem>>();
		int count = items.Count;
		for (int i = 0; i < count; i++)
		{
			UUIItem uiItem = items[i];
			ILayoutItem<TTabItem> item = this.InitTabItem(uiItem, i);
			this.Layout.Add(item);
		}
		this.CurrentIndex = 0;
	}

	// Token: 0x0600BFE3 RID: 49123 RVA: 0x002B4940 File Offset: 0x002B2B40
	protected override void OnStart()
	{
		TArray<UUIItem> attachUIChildren = base.GetItem(0).GetAttachUIChildren();
		this.Layout = new List<ILayoutItem<TTabItem>>();
		int num = attachUIChildren.Num();
		for (int i = 0; i < num; i++)
		{
			UUIItem uiItem = attachUIChildren.Get(i);
			ILayoutItem<TTabItem> item = this.InitTabItem(uiItem, i);
			this.Layout.Add(item);
		}
		this.CurrentIndex = 0;
	}

	// Token: 0x0600BFE4 RID: 49124 RVA: 0x002B49A0 File Offset: 0x002B2BA0
	protected override void OnBeforeDestroy()
	{
		if (this.Layout != null)
		{
			foreach (ILayoutItem<TTabItem> layoutItem in this.Layout)
			{
				TTabItem ttabItem = layoutItem.Value;
				if (ttabItem != null)
				{
					ttabItem.Destroy(null);
				}
			}
			this.Layout.Clear();
		}
	}

	// Token: 0x0600BFE5 RID: 49125 RVA: 0x002B4A14 File Offset: 0x002B2C14
	private ILayoutItem<TTabItem> InitTabItem(UUIItem uiItem, int index)
	{
		TTabItem ttabItem = this.ProxyCreate(uiItem, index);
		ttabItem.GridIndex = index;
		ttabItem.InitTabItem();
		ttabItem.SetSelectedCallBack(new Action<int>(this.ToggleEvent));
		ttabItem.SetCanExecuteChange(new Func<int, bool, bool>(this.CanExecuteChange));
		return new LayoutItem<TTabItem>
		{
			Key = index,
			Value = ttabItem
		};
	}

	// Token: 0x0600BFE6 RID: 49126 RVA: 0x002B4A8C File Offset: 0x002B2C8C
	private void ToggleEvent(int index)
	{
		this.SwitchLastToggle();
		this.CurrentIndex = index;
		this.ToggleCallBack(index);
	}

	// Token: 0x0600BFE7 RID: 49127 RVA: 0x002B4AA8 File Offset: 0x002B2CA8
	private void SwitchLastToggle()
	{
		if (this.CurrentIndex == -1)
		{
			return;
		}
		ILayoutItem<TTabItem> layoutItem = this.Layout[this.CurrentIndex];
		if (layoutItem != null)
		{
			layoutItem.Value.SetForceSwitch(EToggleState.ETT_UnChecked, false);
		}
	}

	// Token: 0x0600BFE8 RID: 49128 RVA: 0x002B4AE6 File Offset: 0x002B2CE6
	private bool CanExecuteChange(int index, bool forceSwitch)
	{
		return (this.CurrentIndex != index || forceSwitch) && (this.CanExecuteChangeInternal == null || this.CanExecuteChangeInternal(index));
	}

	// Token: 0x0600BFE9 RID: 49129 RVA: 0x002B4B0C File Offset: 0x002B2D0C
	public void SelectToggleByIndex(int index, bool bIgnored = false)
	{
		if (bIgnored)
		{
			ILayoutItem<TTabItem> layoutItem = this.Layout[this.CurrentIndex];
			if (layoutItem != null)
			{
				layoutItem.Value.SetForceSwitch(EToggleState.ETT_UnChecked, false);
			}
			this.CurrentIndex = -1;
		}
		if (index == this.CurrentIndex)
		{
			return;
		}
		ILayoutItem<TTabItem> layoutItem2 = this.Layout[index];
		if (layoutItem2 != null)
		{
			layoutItem2.Value.SetForceSwitch(EToggleState.ETT_Checked, true);
		}
	}

	// Token: 0x0600BFEA RID: 49130 RVA: 0x002B4B76 File Offset: 0x002B2D76
	public int GetSelectedIndex()
	{
		return this.CurrentIndex;
	}

	// Token: 0x0600BFEB RID: 49131 RVA: 0x002B4B7E File Offset: 0x002B2D7E
	public void SetCanChange(Func<int, bool> callback)
	{
		this.CanExecuteChangeInternal = callback;
	}

	// Token: 0x04005649 RID: 22089
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private List<ILayoutItem<TTabItem>> Layout;

	// Token: 0x0400564A RID: 22090
	private int CurrentIndex = -1;

	// Token: 0x0400564B RID: 22091
	[Nullable(2)]
	private Func<int, bool> CanExecuteChangeInternal;

	// Token: 0x0400564C RID: 22092
	public readonly Func<UUIItem, int, TTabItem> ProxyCreate;

	// Token: 0x0400564D RID: 22093
	public readonly Action<int> ToggleCallBack;

	// Token: 0x02007ED7 RID: 32471
	[NullableContext(0)]
	private enum ETabComponent
	{
		// Token: 0x04029730 RID: 169776
		Layout
	}
}
