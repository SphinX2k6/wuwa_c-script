using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A55 RID: 6741
[NullableContext(1)]
[Nullable(0)]
public class PhotoFilterSetItem : GridProxyAbstract<FilterSetting>
{
	// Token: 0x06010A3A RID: 68154 RVA: 0x004DE70C File Offset: 0x004DC90C
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

	// Token: 0x06010A3B RID: 68155 RVA: 0x004DE7F9 File Offset: 0x004DC9F9
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06010A3C RID: 68156 RVA: 0x004DE808 File Offset: 0x004DCA08
	public override void Refresh(FilterSetting data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.SetTextureByPath(data.SpritePath, base.GetTexture(3), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.NameTextId, Array.Empty<object>());
		this.RefreshRedDot(data);
		this.SetEditBtnActive(isSelected);
		this.SetToggleState(isSelected, false);
	}

	// Token: 0x06010A3D RID: 68157 RVA: 0x004DE86D File Offset: 0x004DCA6D
	public void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06010A3E RID: 68158 RVA: 0x004DE88A File Offset: 0x004DCA8A
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
		this.SetEditBtnActive(true);
	}

	// Token: 0x06010A3F RID: 68159 RVA: 0x004DE89B File Offset: 0x004DCA9B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
		this.SetEditBtnActive(false);
	}

	// Token: 0x06010A40 RID: 68160 RVA: 0x004DE8AC File Offset: 0x004DCAAC
	public override object GetKey(FilterSetting data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06010A41 RID: 68161 RVA: 0x004DE8BC File Offset: 0x004DCABC
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

	// Token: 0x06010A42 RID: 68162 RVA: 0x004DE8F8 File Offset: 0x004DCAF8
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

	// Token: 0x06010A43 RID: 68163 RVA: 0x004DE929 File Offset: 0x004DCB29
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		this.OnFilterClick(this.Data);
	}

	// Token: 0x06010A44 RID: 68164 RVA: 0x004DE941 File Offset: 0x004DCB41
	private void OnEditHoldClick()
	{
		this.OnEditClick(this.Data);
	}

	// Token: 0x0400931C RID: 37660
	private FilterSetting Data;

	// Token: 0x0400931D RID: 37661
	public Action<FilterSetting> OnFilterClick = delegate(FilterSetting data)
	{
	};

	// Token: 0x0400931E RID: 37662
	public Action<FilterSetting> OnEditClick = delegate(FilterSetting data)
	{
	};

	// Token: 0x02007CD3 RID: 31955
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040286BE RID: 165566
		ToggleItem,
		// Token: 0x040286BF RID: 165567
		ItemNormalState,
		// Token: 0x040286C0 RID: 165568
		ItemContent,
		// Token: 0x040286C1 RID: 165569
		TextureBg,
		// Token: 0x040286C2 RID: 165570
		TextTitle,
		// Token: 0x040286C3 RID: 165571
		BtnEditHold,
		// Token: 0x040286C4 RID: 165572
		SpriteRedDot
	}
}
