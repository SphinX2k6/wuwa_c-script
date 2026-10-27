using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015C6 RID: 5574
public class WheelTowerSmallBuffItem : UiPanelBase
{
	// Token: 0x06009E01 RID: 40449 RVA: 0x0022609C File Offset: 0x0022429C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009E02 RID: 40450 RVA: 0x00226184 File Offset: 0x00224384
	public void Refresh(int buffId)
	{
		bool flag = buffId > 0;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		if (!flag)
		{
			return;
		}
		NewTowerBuff? buffConfigById = WheelTowerConfig.Instance.GetBuffConfigById(buffId);
		if (buffConfigById == null)
		{
			return;
		}
		base.SetTextureByPath(buffConfigById.Value.Icon, base.GetTexture(3), null, null);
	}

	// Token: 0x06009E03 RID: 40451 RVA: 0x002261FF File Offset: 0x002243FF
	private void OnBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerBuffSelectView, 32, null);
	}
}
