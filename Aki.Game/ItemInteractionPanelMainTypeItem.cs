using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D84 RID: 3460
public class ItemInteractionPanelMainTypeItem : UiPanelBase
{
	// Token: 0x06008E1F RID: 36383 RVA: 0x002AD364 File Offset: 0x002AB564
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

	// Token: 0x06008E20 RID: 36384 RVA: 0x002AD3E4 File Offset: 0x002AB5E4
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

	// Token: 0x06008E21 RID: 36385 RVA: 0x002AD45A File Offset: 0x002AB65A
	protected override void OnBeforeDestroy()
	{
		this.OnExtendToggleStateChangedCallback = null;
	}

	// Token: 0x06008E22 RID: 36386 RVA: 0x002AD463 File Offset: 0x002AB663
	public void SetSelected(bool bSelected)
	{
		if (bSelected)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06008E23 RID: 36387 RVA: 0x002AD48B File Offset: 0x002AB68B
	public void SetRedDotVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x06008E24 RID: 36388 RVA: 0x002AD49F File Offset: 0x002AB69F
	[NullableContext(1)]
	public void BindOnExtendToggleStateChanged(Action<int> onExtendToggleStateChanged)
	{
		this.OnExtendToggleStateChangedCallback = onExtendToggleStateChanged;
	}

	// Token: 0x06008E25 RID: 36389 RVA: 0x002AD4A8 File Offset: 0x002AB6A8
	private void OnExtendToggleStateChanged(EToggleState toggleState)
	{
		if (this.OnExtendToggleStateChangedCallback != null)
		{
			this.OnExtendToggleStateChangedCallback(this.MainTypeId);
		}
	}

	// Token: 0x04005507 RID: 21767
	public int MainTypeId;

	// Token: 0x04005508 RID: 21768
	[Nullable(2)]
	private Action<int> OnExtendToggleStateChangedCallback;

	// Token: 0x02006FD9 RID: 28633
	private enum EChildType
	{
		// Token: 0x0402489B RID: 149659
		MainTypeSprite,
		// Token: 0x0402489C RID: 149660
		ExtendToggle,
		// Token: 0x0402489D RID: 149661
		RedDotItem
	}
}
