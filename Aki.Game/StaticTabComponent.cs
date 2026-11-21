using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E72 RID: 3698
[NullableContext(1)]
[Nullable(0)]
public class StaticTabComponent<[Nullable(0)] TTabItem> : UiPanelBase where TTabItem : CommonTabItemBase
{
	// Token: 0x060093E9 RID: 37865 RVA: 0x002BF82B File Offset: 0x002BDA2B
	public StaticTabComponent(Func<UUIItem, int, TTabItem> proxyCreate, Action<int> toggleCallBack)
	{
		this.ProxyCreate = proxyCreate;
		this.ToggleCallBack = toggleCallBack;
	}

	// Token: 0x060093EA RID: 37866 RVA: 0x002BF848 File Offset: 0x002BDA48
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x060093EB RID: 37867 RVA: 0x002BF876 File Offset: 0x002BDA76
	public void Init(List<UUIItem> items)
	{
		this.RegistTabItem(items);
	}

	// Token: 0x060093EC RID: 37868 RVA: 0x002BF880 File Offset: 0x002BDA80
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

	// Token: 0x060093ED RID: 37869 RVA: 0x002BF8D0 File Offset: 0x002BDAD0
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

	// Token: 0x060093EE RID: 37870 RVA: 0x002BF930 File Offset: 0x002BDB30
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

	// Token: 0x060093EF RID: 37871 RVA: 0x002BF9A4 File Offset: 0x002BDBA4
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

	// Token: 0x060093F0 RID: 37872 RVA: 0x002BFA1C File Offset: 0x002BDC1C
	private void ToggleEvent(int index)
	{
		this.SwitchLastToggle();
		this.CurrentIndex = index;
		this.ToggleCallBack(index);
	}

	// Token: 0x060093F1 RID: 37873 RVA: 0x002BFA38 File Offset: 0x002BDC38
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

	// Token: 0x060093F2 RID: 37874 RVA: 0x002BFA76 File Offset: 0x002BDC76
	private bool CanExecuteChange(int index, bool forceSwitch)
	{
		return (this.CurrentIndex != index || forceSwitch) && (this.CanExecuteChangeInternal == null || this.CanExecuteChangeInternal(index));
	}

	// Token: 0x060093F3 RID: 37875 RVA: 0x002BFA9C File Offset: 0x002BDC9C
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

	// Token: 0x060093F4 RID: 37876 RVA: 0x002BFB06 File Offset: 0x002BDD06
	public int GetSelectedIndex()
	{
		return this.CurrentIndex;
	}

	// Token: 0x060093F5 RID: 37877 RVA: 0x002BFB0E File Offset: 0x002BDD0E
	public void SetCanChange(Func<int, bool> callback)
	{
		this.CanExecuteChangeInternal = callback;
	}

	// Token: 0x040056FB RID: 22267
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private List<ILayoutItem<TTabItem>> Layout;

	// Token: 0x040056FC RID: 22268
	private int CurrentIndex = -1;

	// Token: 0x040056FD RID: 22269
	[Nullable(2)]
	private Func<int, bool> CanExecuteChangeInternal;

	// Token: 0x040056FE RID: 22270
	public readonly Func<UUIItem, int, TTabItem> ProxyCreate;

	// Token: 0x040056FF RID: 22271
	public readonly Action<int> ToggleCallBack;

	// Token: 0x02007066 RID: 28774
	[NullableContext(0)]
	private enum ETabComponent
	{
		// Token: 0x04024A6D RID: 150125
		Layout
	}
}
