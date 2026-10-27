using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C0C RID: 7180
public class FormationRoleDragStateItem : UiPanelBase
{
	// Token: 0x0600D6CF RID: 54991 RVA: 0x0031AA78 File Offset: 0x00318C78
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600D6D0 RID: 54992 RVA: 0x0031AB02 File Offset: 0x00318D02
	public float GetCanChangeAlpha()
	{
		return base.GetItem(2).GetAlpha();
	}

	// Token: 0x0600D6D1 RID: 54993 RVA: 0x0031AB10 File Offset: 0x00318D10
	public void SetBarFill(float value)
	{
		base.GetItem(3).SetUIActive(value > 0f);
		base.GetSprite(4).SetFillAmount(value);
	}

	// Token: 0x020081BF RID: 33215
	private enum EChildType
	{
		// Token: 0x0402A564 RID: 173412
		CanChangeItem = 2,
		// Token: 0x0402A565 RID: 173413
		BarItem,
		// Token: 0x0402A566 RID: 173414
		BarSprite
	}
}
