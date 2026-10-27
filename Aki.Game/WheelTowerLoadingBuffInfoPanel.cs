using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001593 RID: 5523
public class WheelTowerLoadingBuffInfoPanel : UiPanelBase
{
	// Token: 0x06009D74 RID: 40308 RVA: 0x002222E8 File Offset: 0x002204E8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009D75 RID: 40309 RVA: 0x00222394 File Offset: 0x00220594
	public void Refresh(int buffId, int round)
	{
		if (buffId <= 0)
		{
			base.SetUiActive(false);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WheelTower_TeamSelectTab", new <>z__ReadOnlySingleElementList<object>(round + 1));
		base.SetUiActive(true);
		NewTowerBuff? buffConfigById = WheelTowerConfig.Instance.GetBuffConfigById(buffId);
		if (buffConfigById == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(buffConfigById.Value.Icon, base.GetTexture(1), null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), buffConfigById.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "WheelTower_FixedBuffDesc", Array.Empty<object>());
	}
}
