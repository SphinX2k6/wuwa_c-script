using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using FilterDefine;
using UnrealEngine;

// Token: 0x02001480 RID: 5248
public class SettingGridBig : SettingGridBase
{
	// Token: 0x0600D233 RID: 53811 RVA: 0x003E5A48 File Offset: 0x003E3C48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickedSwitch));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D234 RID: 53812 RVA: 0x003E5B54 File Offset: 0x003E3D54
	[NullableContext(1)]
	public override void Refresh(InventoryDefine.IManageConfigSettingGridData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		if (!this.CheckShow())
		{
			base.SetUiActive(false);
			return;
		}
		base.SetUiActive(true);
		if (data.IsEmpty)
		{
			this.SetEmptyState();
			return;
		}
		base.GetButton(4).SetSelfInteractive(data.IsEditing);
		if (data.IsAdd)
		{
			this.SetAddState();
			return;
		}
		this.SetNormalState();
	}

	// Token: 0x0600D235 RID: 53813 RVA: 0x003E5BB8 File Offset: 0x003E3DB8
	private bool CheckShow()
	{
		InventoryDefine.IManageConfigSettingGridData data = this.Data;
		if (data.IsFirst)
		{
			return data.IsEditing || (data.IsEmpty && !data.IsEditing);
		}
		return data.IsSelect;
	}

	// Token: 0x0600D236 RID: 53814 RVA: 0x003E5C00 File Offset: 0x003E3E00
	private void SetEmptyState()
	{
		base.GetTexture(2).SetUIActive(false);
		base.GetTexture(3).SetUIActive(false);
		base.GetTexture(0).SetUIActive(false);
		base.GetButton(4).SetSelfInteractive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PhantomProject_EmptyChose", Array.Empty<object>());
	}

	// Token: 0x0600D237 RID: 53815 RVA: 0x003E5C5C File Offset: 0x003E3E5C
	private void SetAddState()
	{
		base.GetTexture(2).SetUIActive(true);
		base.GetTexture(3).SetUIActive(false);
		base.GetTexture(0).SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PhantomProject_AddChose", Array.Empty<object>());
	}

	// Token: 0x0600D238 RID: 53816 RVA: 0x003E5CAC File Offset: 0x003E3EAC
	private void SetNormalState()
	{
		InventoryDefine.IManageConfigSettingGridData data = this.Data;
		base.GetTexture(2).SetUIActive(false);
		base.GetTexture(3).SetUIActive(data.IsEditing);
		int filterType = FilterConfig.Instance.GetFilterRuleConfig(data.RuleId).Value.FilterType;
		FilterItemData filterItemData = FilterModel.Instance.GetFilterDataFuncByFilterType((FilterDefine.EFilterType)filterType)(new int[]
		{
			data.Value
		})[0];
		base.GetText(1).SetText(filterItemData.Content ?? "", true);
		this.SetIcon(filterItemData);
	}

	// Token: 0x0600D239 RID: 53817 RVA: 0x003E5D48 File Offset: 0x003E3F48
	[NullableContext(1)]
	private void SetIcon(FilterItemData filterData)
	{
		string iconPath = filterData.GetIconPath();
		UUITexture texture = base.GetTexture(0);
		if (StringUtils.IsBlank(iconPath))
		{
			texture.SetUIActive(false);
			return;
		}
		texture.SetUIActive(true);
		base.SetTextureByPath(iconPath, texture, null, null);
		UUIItem uuiitem = texture;
		bool needChangeColor = filterData.NeedChangeColor;
		FColor? fcolor = new FColor?(texture.changeColor);
		uuiitem.SetChangeColor(needChangeColor, fcolor);
	}

	// Token: 0x0600D23A RID: 53818 RVA: 0x003E5DA7 File Offset: 0x003E3FA7
	private void OnClickedSwitch()
	{
		if (this.CallbackOnClicked != null && this.Data != null)
		{
			this.CallbackOnClicked(this.Data, this.Data.IsAdd);
		}
	}

	// Token: 0x04007685 RID: 30341
	[Nullable(2)]
	private InventoryDefine.IManageConfigSettingGridData Data;

	// Token: 0x02007749 RID: 30537
	private enum EComponentBig
	{
		// Token: 0x04026BD2 RID: 158674
		TextureIcon,
		// Token: 0x04026BD3 RID: 158675
		TextName,
		// Token: 0x04026BD4 RID: 158676
		TextureAdd,
		// Token: 0x04026BD5 RID: 158677
		TextureDelete,
		// Token: 0x04026BD6 RID: 158678
		BtnSwitch
	}
}
