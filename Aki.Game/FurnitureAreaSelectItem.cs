using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000478 RID: 1144
public class FurnitureAreaSelectItem : UiPanelBase
{
	// Token: 0x06003AF8 RID: 15096 RVA: 0x0014F094 File Offset: 0x0014D294
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnSelectedInternal))
		};
	}

	// Token: 0x06003AF9 RID: 15097 RVA: 0x0014F195 File Offset: 0x0014D395
	[NullableContext(1)]
	public void Refresh(IFurnitureAreaSelectItemData data)
	{
		this.Data = data;
		this.RefreshToggleState();
		this.RefreshProgress();
		this.RefreshRedDot();
		this.RefreshShowState();
	}

	// Token: 0x06003AFA RID: 15098 RVA: 0x0014F1B6 File Offset: 0x0014D3B6
	public void RefreshToggleState()
	{
		if (this.Data == null)
		{
			return;
		}
		base.GetExtendToggle(0).SetToggleState(this.Data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06003AFB RID: 15099 RVA: 0x0014F1E4 File Offset: 0x0014D3E4
	public void RefreshProgress()
	{
		if (this.Data == null)
		{
			return;
		}
		bool flag = this.Data.PlacedSlotCount == this.Data.MaxSlotCount;
		UUIText text = base.GetText(7);
		UUIItem uuiitem = text;
		bool bUseChangeColor = flag;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "DIY_RegionAtmosphere_Content_1", new <>z__ReadOnlyArray<object>(new object[]
		{
			this.Data.PlacedSlotCount,
			this.Data.MaxSlotCount
		}));
	}

	// Token: 0x06003AFC RID: 15100 RVA: 0x0014F277 File Offset: 0x0014D477
	public void RefreshRedDot()
	{
		if (this.Data == null)
		{
			return;
		}
		base.GetItem(8).SetUIActive(this.Data.RedDotShowState);
	}

	// Token: 0x06003AFD RID: 15101 RVA: 0x0014F29C File Offset: 0x0014D49C
	public void RefreshShowState()
	{
		if (this.Data == null)
		{
			return;
		}
		base.GetItem(1).SetUIActive(!this.Data.IsUnlock);
		base.GetItem(4).SetUIActive(this.Data.IsUnlock);
		this.SetSpriteByPath(this.Data.UnlockAreaIcon, base.GetSprite(5), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), this.Data.AreaName, Array.Empty<object>());
		this.SetSpriteByPath(this.Data.LockAreaIcon, base.GetSprite(2), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.Data.AreaName, Array.Empty<object>());
	}

	// Token: 0x06003AFE RID: 15102 RVA: 0x0014F36B File Offset: 0x0014D56B
	private void OnSelectedInternal(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.Data == null)
		{
			return;
		}
		this.Data.OnSelected(this.Data.AreaId);
	}

	// Token: 0x04002F77 RID: 12151
	[Nullable(2)]
	private IFurnitureAreaSelectItemData Data;
}
