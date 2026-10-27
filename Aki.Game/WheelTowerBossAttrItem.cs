using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001585 RID: 5509
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerBossAttrItem : UiPanelBase
{
	// Token: 0x06009D51 RID: 40273 RVA: 0x00221804 File Offset: 0x0021FA04
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009D52 RID: 40274 RVA: 0x002218AF File Offset: 0x0021FAAF
	protected override void OnStart()
	{
		this.TagLayout = new GenericLayout<WheelTowerBossTagItem, int>(base.GetHorizontalLayout(2), new Func<WheelTowerBossTagItem>(this.CreateTagItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06009D53 RID: 40275 RVA: 0x002218E4 File Offset: 0x0021FAE4
	public void Refresh(IWheelTowerBossAttrData attrData)
	{
		string text = ConfigMultiTextLang.GetLocalTextNew(attrData.AttrName, null) ?? string.Empty;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WheelTower_BossAttr_Level", new <>z__ReadOnlyArray<object>(new object[]
		{
			attrData.AttrLevel,
			text
		}));
		ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(attrData.ElementId);
		if (elementConfig != null)
		{
			base.SetTextureByPath(elementConfig.Value.Icon, base.GetTexture(0), null, null);
		}
		GenericLayout<WheelTowerBossTagItem, int> tagLayout = this.TagLayout;
		if (tagLayout == null)
		{
			return;
		}
		tagLayout.RefreshByData(attrData.TagIdList, null, false);
	}

	// Token: 0x06009D54 RID: 40276 RVA: 0x00221992 File Offset: 0x0021FB92
	private WheelTowerBossTagItem CreateTagItem()
	{
		return new WheelTowerBossTagItem();
	}

	// Token: 0x0400451B RID: 17691
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerBossTagItem, int> TagLayout;
}
