using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002258 RID: 8792
public class WeaponResonanceSuccessView : UiViewBase
{
	// Token: 0x06015BEC RID: 89068 RVA: 0x0064EAAB File Offset: 0x0064CCAB
	[NullableContext(1)]
	public WeaponResonanceSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015BED RID: 89069 RVA: 0x0064EAB4 File Offset: 0x0064CCB4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ConfirmClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06015BEE RID: 89070 RVA: 0x0064EB7C File Offset: 0x0064CD7C
	protected override void OnBeforeShow()
	{
		IWeaponResonanceSuccessViewParam weaponResonanceSuccessViewParam = this.OpenParam as IWeaponResonanceSuccessViewParam;
		int weaponIncId = weaponResonanceSuccessViewParam.WeaponIncId;
		int lastLevel = weaponResonanceSuccessViewParam.LastLevel;
		int resonanceLevel = WeaponModel.Instance.GetWeaponDataByIncId(weaponIncId).GetResonanceLevel();
		LguiUtil.Instance.SetLocalText(base.GetText(1), "WeaponResonanceLevelText", new <>z__ReadOnlySingleElementList<object>(lastLevel));
		LguiUtil.Instance.SetLocalText(base.GetText(2), "WeaponResonanceLevelText", new <>z__ReadOnlySingleElementList<object>(resonanceLevel));
	}

	// Token: 0x06015BEF RID: 89071 RVA: 0x0064EBF4 File Offset: 0x0064CDF4
	private void ConfirmClick()
	{
		UiManager.Instance.CloseView(EUiViewName.WeaponResonanceSuccessView, null);
	}

	// Token: 0x020084BD RID: 33981
	private enum EComponent
	{
		// Token: 0x0402ACD1 RID: 175313
		ConfirmButton,
		// Token: 0x0402ACD2 RID: 175314
		LastLevelText,
		// Token: 0x0402ACD3 RID: 175315
		CurLevelText
	}
}
