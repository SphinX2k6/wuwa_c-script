using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A6C RID: 2668
public class WheelTowerBossBuffItem : UiPanelBase
{
	// Token: 0x060071A0 RID: 29088 RVA: 0x0022DF68 File Offset: 0x0022C168
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060071A1 RID: 29089 RVA: 0x0022E058 File Offset: 0x0022C258
	[NullableContext(1)]
	public void Refresh(IWheelTowerBossBuffData data)
	{
		NewTowerBossBuff? bossBuffConfig = WheelTowerConfig.Instance.GetBossBuffConfig(data.BuffId);
		if (bossBuffConfig == null)
		{
			return;
		}
		base.SetTextureByPath(bossBuffConfig.Value.SkillIcon, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), bossBuffConfig.Value.SkillTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), bossBuffConfig.Value.SkillDesc, Array.Empty<object>());
		this.SetSpriteByPath(bossBuffConfig.Value.DetailTipBgQuality, base.GetSprite(5), false, null, null);
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data.IsActivate);
	}
}
