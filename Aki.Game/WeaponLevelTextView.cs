using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D19 RID: 11545
public class WeaponLevelTextView : UiPanelBase
{
	// Token: 0x06018435 RID: 99381 RVA: 0x0062C4C4 File Offset: 0x0062A6C4
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

	// Token: 0x06018436 RID: 99382 RVA: 0x0062C52D File Offset: 0x0062A72D
	protected override void OnStart()
	{
		base.GetText(0).SetUIActive(true);
		base.GetText(1).SetUIActive(true);
	}

	// Token: 0x06018437 RID: 99383 RVA: 0x0062C549 File Offset: 0x0062A749
	public void SetCurrentLevelText(int level)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), "WeaponLevelUpLevelText", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x06018438 RID: 99384 RVA: 0x0062C56C File Offset: 0x0062A76C
	public void SetMaxLevelText(int maxLevel)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), "WeaponMaxLevelText", new <>z__ReadOnlySingleElementList<object>(maxLevel));
	}

	// Token: 0x020092A9 RID: 37545
	private enum ELevelTextComponent
	{
		// Token: 0x0402F6A7 RID: 194215
		CurrentLevelText,
		// Token: 0x0402F6A8 RID: 194216
		MaxLevelText
	}
}
