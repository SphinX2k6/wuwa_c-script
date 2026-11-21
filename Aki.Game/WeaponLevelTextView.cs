using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002273 RID: 8819
public class WeaponLevelTextView : UiPanelBase
{
	// Token: 0x06015CD6 RID: 89302 RVA: 0x006524B8 File Offset: 0x006506B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015CD7 RID: 89303 RVA: 0x00652521 File Offset: 0x00650721
	protected override void OnStart()
	{
		base.GetText(0).SetUIActive(true);
		base.GetText(1).SetUIActive(true);
	}

	// Token: 0x06015CD8 RID: 89304 RVA: 0x0065253D File Offset: 0x0065073D
	public void SetCurrentLevelText(int level)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), "WeaponLevelUpLevelText", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x06015CD9 RID: 89305 RVA: 0x00652560 File Offset: 0x00650760
	public void SetMaxLevelText(int maxLevel)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), "WeaponMaxLevelText", new <>z__ReadOnlySingleElementList<object>(maxLevel));
	}

	// Token: 0x020084D1 RID: 34001
	private enum ELevelTextComponent
	{
		// Token: 0x0402AD31 RID: 175409
		CurrentLevelText,
		// Token: 0x0402AD32 RID: 175410
		MaxLevelText
	}
}
