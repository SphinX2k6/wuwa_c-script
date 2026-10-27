using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using FilterDefine;
using UnrealEngine;

// Token: 0x02001FBE RID: 8126
public class SettingGridBig : SettingGridBase
{
	// Token: 0x0600FE0D RID: 65037 RVA: 0x003DA06C File Offset: 0x003D826C
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

	// Token: 0x0600FE0E RID: 65038 RVA: 0x003DA178 File Offset: 0x003D8378
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

	// Token: 0x0600FE0F RID: 65039 RVA: 0x003DA1DC File Offset: 0x003D83DC
	private bool CheckShow()
	{
		InventoryDefine.IManageConfigSettingGridData data = this.Data;
		if (data.IsFirst)
		{
			return data.IsEditing || (data.IsEmpty && !data.IsEditing);
		}
		return data.IsSelect;
	}

	// Token: 0x0600FE10 RID: 65040 RVA: 0x003DA224 File Offset: 0x003D8424
	private void SetEmptyState()
	{
		base.GetTexture(2).SetUIActive(false);
		base.GetTexture(3).SetUIActive(false);
		base.GetTexture(0).SetUIActive(false);
		base.GetButton(4).SetSelfInteractive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PhantomProject_EmptyChose", Array.Empty<object>());
	}

	// Token: 0x0600FE11 RID: 65041 RVA: 0x003DA280 File Offset: 0x003D8480
	private void SetAddState()
	{
		base.GetTexture(2).SetUIActive(true);
		base.GetTexture(3).SetUIActive(false);
		base.GetTexture(0).SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PhantomProject_AddChose", Array.Empty<object>());
	}

	// Token: 0x0600FE12 RID: 65042 RVA: 0x003DA2D0 File Offset: 0x003D84D0
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

	// Token: 0x0600FE13 RID: 65043 RVA: 0x003DA36C File Offset: 0x003D856C
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

	// Token: 0x0600FE14 RID: 65044 RVA: 0x003DA3CB File Offset: 0x003D85CB
	private void OnClickedSwitch()
	{
		if (this.CallbackOnClicked != null && this.Data != null)
		{
			this.CallbackOnClicked(this.Data, this.Data.IsAdd);
		}
	}

	// Token: 0x040075A3 RID: 30115
	[Nullable(2)]
	private InventoryDefine.IManageConfigSettingGridData Data;

	// Token: 0x020085C7 RID: 34247
	private enum EComponentBig
	{
		// Token: 0x0402B8CA RID: 178378
		TextureIcon,
		// Token: 0x0402B8CB RID: 178379
		TextName,
		// Token: 0x0402B8CC RID: 178380
		TextureAdd,
		// Token: 0x0402B8CD RID: 178381
		TextureDelete,
		// Token: 0x0402B8CE RID: 178382
		BtnSwitch
	}
}
