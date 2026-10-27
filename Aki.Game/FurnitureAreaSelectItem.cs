using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000FC3 RID: 4035
public class FurnitureAreaSelectItem : UiPanelBase
{
	// Token: 0x06006760 RID: 26464 RVA: 0x001467D0 File Offset: 0x001449D0
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

	// Token: 0x06006761 RID: 26465 RVA: 0x001468D1 File Offset: 0x00144AD1
	[NullableContext(1)]
	public void Refresh(IFurnitureAreaSelectItemData data)
	{
		this.Data = data;
		this.RefreshToggleState();
		this.RefreshProgress();
		this.RefreshRedDot();
		this.RefreshShowState();
	}

	// Token: 0x06006762 RID: 26466 RVA: 0x001468F2 File Offset: 0x00144AF2
	public void RefreshToggleState()
	{
		if (this.Data == null)
		{
			return;
		}
		base.GetExtendToggle(0).SetToggleState(this.Data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06006763 RID: 26467 RVA: 0x00146920 File Offset: 0x00144B20
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

	// Token: 0x06006764 RID: 26468 RVA: 0x001469B3 File Offset: 0x00144BB3
	public void RefreshRedDot()
	{
		if (this.Data == null)
		{
			return;
		}
		base.GetItem(8).SetUIActive(this.Data.RedDotShowState);
	}

	// Token: 0x06006765 RID: 26469 RVA: 0x001469D8 File Offset: 0x00144BD8
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

	// Token: 0x06006766 RID: 26470 RVA: 0x00146AA7 File Offset: 0x00144CA7
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

	// Token: 0x04002EDE RID: 11998
	[Nullable(2)]
	private IFurnitureAreaSelectItemData Data;
}
