using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001599 RID: 5529
public class WheelTowerResultRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06009D7F RID: 40319 RVA: 0x00222980 File Offset: 0x00220B80
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009D80 RID: 40320 RVA: 0x00222A90 File Offset: 0x00220C90
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(5);
		if (item3 != null)
		{
			item3.SetUIActive(true);
		}
		UUIItem item4 = base.GetItem(6);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		int id = roleId;
		if (RoleModel.Instance.IsMainRole(roleId))
		{
			id = RoleModel.Instance.GetCurSelectMainRoleId().Value;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(id);
		if (roleConfig != null)
		{
			base.SetTextureShowUntilLoaded(roleConfig.Value.Card, base.GetTexture(1), null);
		}
	}
}
