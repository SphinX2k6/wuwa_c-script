using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018CB RID: 6347
public class ItemInteractionPanelMainTypeItem : UiPanelBase
{
	// Token: 0x0600BA36 RID: 47670 RVA: 0x002A2C0C File Offset: 0x002A0E0C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnExtendToggleStateChanged))
		};
	}

	// Token: 0x0600BA37 RID: 47671 RVA: 0x002A2C8C File Offset: 0x002A0E8C
	protected override void OnStart()
	{
		this.MainTypeId = (int)this.OpenParam;
		InventoryConfig instance = InventoryConfig.Instance;
		ItemMainType? itemMainType = (instance != null) ? instance.GetItemMainTypeConfig(this.MainTypeId) : null;
		if (itemMainType == null)
		{
			return;
		}
		this.SetSpriteByPath(itemMainType.Value.Icon, base.GetSprite(0), false, null, null);
		this.SetActive(true);
	}

	// Token: 0x0600BA38 RID: 47672 RVA: 0x002A2D02 File Offset: 0x002A0F02
	protected override void OnBeforeDestroy()
	{
		this.OnExtendToggleStateChangedCallback = null;
	}

	// Token: 0x0600BA39 RID: 47673 RVA: 0x002A2D0B File Offset: 0x002A0F0B
	public void SetSelected(bool bSelected)
	{
		if (bSelected)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600BA3A RID: 47674 RVA: 0x002A2D33 File Offset: 0x002A0F33
	public void SetRedDotVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x0600BA3B RID: 47675 RVA: 0x002A2D47 File Offset: 0x002A0F47
	[NullableContext(1)]
	public void BindOnExtendToggleStateChanged(Action<int> onExtendToggleStateChanged)
	{
		this.OnExtendToggleStateChangedCallback = onExtendToggleStateChanged;
	}

	// Token: 0x0600BA3C RID: 47676 RVA: 0x002A2D50 File Offset: 0x002A0F50
	private void OnExtendToggleStateChanged(EToggleState toggleState)
	{
		if (this.OnExtendToggleStateChangedCallback != null)
		{
			this.OnExtendToggleStateChangedCallback(this.MainTypeId);
		}
	}

	// Token: 0x0400545C RID: 21596
	public int MainTypeId;

	// Token: 0x0400545D RID: 21597
	[Nullable(2)]
	private Action<int> OnExtendToggleStateChangedCallback;

	// Token: 0x02007E52 RID: 32338
	private enum EChildType
	{
		// Token: 0x0402956E RID: 169326
		MainTypeSprite,
		// Token: 0x0402956F RID: 169327
		ExtendToggle,
		// Token: 0x04029570 RID: 169328
		RedDotItem
	}
}
