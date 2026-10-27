using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015F3 RID: 5619
public class WheelTowerStrShowPanel : UiPanelBase
{
	// Token: 0x06009E98 RID: 40600 RVA: 0x0022A1E4 File Offset: 0x002283E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009E99 RID: 40601 RVA: 0x0022A2F0 File Offset: 0x002284F0
	protected override void OnStart()
	{
		this.Scroll = new GenericScrollViewNew<StrItem, WheelTowerStrItemData>(base.GetScrollViewWithScrollbar(0), () => new StrItem(), null, false, null);
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetText(WheelTowerModel.Instance.GetTowerConfig().DefaultCostEnergy.ToString(), true);
	}

	// Token: 0x06009E9A RID: 40602 RVA: 0x0022A360 File Offset: 0x00228560
	public void Refresh()
	{
		List<WheelTowerStrItemData> list = new List<WheelTowerStrItemData>();
		foreach (int roleId in WheelTowerModel.Instance.TmpSelectedRoleMap.Values)
		{
			int num = WheelTowerModel.Instance.TryGetRealRoleId(roleId);
			if (WheelTowerModel.Instance.IsEnhanceRole(num))
			{
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(num);
				if (roleConfig != null)
				{
					list.Add(new WheelTowerStrItemData
					{
						RoleName = roleConfig.Value.Name,
						DescList = WheelTowerModel.Instance.GetRoleEnhanceDesc(num)
					});
				}
			}
		}
		this.SetNullState(list.Count == 0);
		GenericScrollViewNew<StrItem, WheelTowerStrItemData> scroll = this.Scroll;
		if (scroll == null)
		{
			return;
		}
		scroll.RefreshByData(list, null, false);
	}

	// Token: 0x06009E9B RID: 40603 RVA: 0x0022A440 File Offset: 0x00228640
	public void SetNullState(bool nullState)
	{
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(nullState);
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(!nullState);
	}

	// Token: 0x06009E9C RID: 40604 RVA: 0x0022A487 File Offset: 0x00228687
	private void ButtonClick()
	{
		Action onClickConfirm = this.OnClickConfirm;
		if (onClickConfirm == null)
		{
			return;
		}
		onClickConfirm();
	}

	// Token: 0x040046E2 RID: 18146
	[Nullable(2)]
	public Action OnClickConfirm;

	// Token: 0x040046E3 RID: 18147
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<StrItem, WheelTowerStrItemData> Scroll;
}
