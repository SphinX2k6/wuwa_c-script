using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002CFE RID: 11518
public class WeaponResonanceSuccessView : UiViewBase
{
	// Token: 0x0601834B RID: 99147 RVA: 0x00628AE3 File Offset: 0x00626CE3
	[NullableContext(1)]
	public WeaponResonanceSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601834C RID: 99148 RVA: 0x00628AEC File Offset: 0x00626CEC
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

	// Token: 0x0601834D RID: 99149 RVA: 0x00628BB4 File Offset: 0x00626DB4
	protected override void OnBeforeShow()
	{
		IWeaponResonanceSuccessViewParam weaponResonanceSuccessViewParam = this.OpenParam as IWeaponResonanceSuccessViewParam;
		int weaponIncId = weaponResonanceSuccessViewParam.WeaponIncId;
		int lastLevel = weaponResonanceSuccessViewParam.LastLevel;
		int resonanceLevel = WeaponModel.Instance.GetWeaponDataByIncId(weaponIncId).GetResonanceLevel();
		LguiUtil.Instance.SetLocalText(base.GetText(1), "WeaponResonanceLevelText", new <>z__ReadOnlySingleElementList<object>(lastLevel));
		LguiUtil.Instance.SetLocalText(base.GetText(2), "WeaponResonanceLevelText", new <>z__ReadOnlySingleElementList<object>(resonanceLevel));
	}

	// Token: 0x0601834E RID: 99150 RVA: 0x00628C2C File Offset: 0x00626E2C
	private void ConfirmClick()
	{
		UiManager.Instance.CloseView(EUiViewName.WeaponResonanceSuccessView, null);
	}

	// Token: 0x02009295 RID: 37525
	private enum EComponent
	{
		// Token: 0x0402F647 RID: 194119
		ConfirmButton,
		// Token: 0x0402F648 RID: 194120
		LastLevelText,
		// Token: 0x0402F649 RID: 194121
		CurLevelText
	}
}
