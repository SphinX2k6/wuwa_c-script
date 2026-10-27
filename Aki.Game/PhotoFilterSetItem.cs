using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200256A RID: 9578
[NullableContext(1)]
[Nullable(0)]
public class PhotoFilterSetItem : GridProxyAbstract<FilterSetting>
{
	// Token: 0x06013558 RID: 79192 RVA: 0x004CFAD4 File Offset: 0x004CDCD4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnEditHoldClick))
		};
	}

	// Token: 0x06013559 RID: 79193 RVA: 0x004CFBC1 File Offset: 0x004CDDC1
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0601355A RID: 79194 RVA: 0x004CFBD0 File Offset: 0x004CDDD0
	public override void Refresh(FilterSetting data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.SetTextureByPath(data.SpritePath, base.GetTexture(3), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.NameTextId, Array.Empty<object>());
		this.RefreshRedDot(data);
		this.SetEditBtnActive(isSelected);
		this.SetToggleState(isSelected, false);
	}

	// Token: 0x0601355B RID: 79195 RVA: 0x004CFC35 File Offset: 0x004CDE35
	public void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0601355C RID: 79196 RVA: 0x004CFC52 File Offset: 0x004CDE52
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
		this.SetEditBtnActive(true);
	}

	// Token: 0x0601355D RID: 79197 RVA: 0x004CFC63 File Offset: 0x004CDE63
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
		this.SetEditBtnActive(false);
	}

	// Token: 0x0601355E RID: 79198 RVA: 0x004CFC74 File Offset: 0x004CDE74
	public override object GetKey(FilterSetting data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0601355F RID: 79199 RVA: 0x004CFC84 File Offset: 0x004CDE84
	private void RefreshRedDot(FilterSetting data)
	{
		bool flag;
		bool uiactive = MenuModel.Instance.FilterChangedMap.TryGetValue(data.Id, out flag) && flag;
		UUISprite sprite = base.GetSprite(6);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(uiactive);
	}

	// Token: 0x06013560 RID: 79200 RVA: 0x004CFCC0 File Offset: 0x004CDEC0
	private void SetEditBtnActive(bool active)
	{
		UUIButtonComponent button = base.GetButton(5);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem = button.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(active);
	}

	// Token: 0x06013561 RID: 79201 RVA: 0x004CFCF1 File Offset: 0x004CDEF1
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnFilterClick(this.Data);
	}

	// Token: 0x06013562 RID: 79202 RVA: 0x004CFD09 File Offset: 0x004CDF09
	private void OnEditHoldClick()
	{
		this.OnEditClick(this.Data);
	}

	// Token: 0x040091C3 RID: 37315
	private FilterSetting Data;

	// Token: 0x040091C4 RID: 37316
	public Action<FilterSetting> OnFilterClick = delegate(FilterSetting data)
	{
	};

	// Token: 0x040091C5 RID: 37317
	public Action<FilterSetting> OnEditClick = delegate(FilterSetting data)
	{
	};

	// Token: 0x02008B4D RID: 35661
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D3B1 RID: 185265
		ToggleItem,
		// Token: 0x0402D3B2 RID: 185266
		ItemNormalState,
		// Token: 0x0402D3B3 RID: 185267
		ItemContent,
		// Token: 0x0402D3B4 RID: 185268
		TextureBg,
		// Token: 0x0402D3B5 RID: 185269
		TextTitle,
		// Token: 0x0402D3B6 RID: 185270
		BtnEditHold,
		// Token: 0x0402D3B7 RID: 185271
		SpriteRedDot
	}
}
