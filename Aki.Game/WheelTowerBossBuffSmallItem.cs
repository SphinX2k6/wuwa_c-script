using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015B6 RID: 5558
public class WheelTowerBossBuffSmallItem : GridProxyAbstract<int>
{
	// Token: 0x06009DC5 RID: 40389 RVA: 0x00224388 File Offset: 0x00222588
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009DC6 RID: 40390 RVA: 0x00224470 File Offset: 0x00222670
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.BuffId = data;
		NewTowerBossBuff? bossBuffConfig = WheelTowerConfig.Instance.GetBossBuffConfig(data);
		if (bossBuffConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), bossBuffConfig.Value.SkillTitle, Array.Empty<object>());
		base.SetTextureByPath(bossBuffConfig.Value.SmallIcon, base.GetTexture(2), null, null);
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetColor(FColor.FromHex(bossBuffConfig.Value.BuffColor));
	}

	// Token: 0x06009DC7 RID: 40391 RVA: 0x0022450C File Offset: 0x0022270C
	private void OnButtonClick()
	{
		WheelTowerBossBuffData param = new WheelTowerBossBuffData
		{
			Round = 0,
			BuffId = this.BuffId,
			IsActivate = true
		};
		UiManager.Instance.OpenView(EUiViewName.WheelTowerBossBuffTip, param, null);
	}

	// Token: 0x040045B8 RID: 17848
	private int BuffId;
}
