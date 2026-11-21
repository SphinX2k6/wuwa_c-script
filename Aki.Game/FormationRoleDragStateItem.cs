using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010CB RID: 4299
public class FormationRoleDragStateItem : UiPanelBase
{
	// Token: 0x0600AAE2 RID: 43746 RVA: 0x00325D6C File Offset: 0x00323F6C
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

	// Token: 0x0600AAE3 RID: 43747 RVA: 0x00325DF6 File Offset: 0x00323FF6
	public float GetCanChangeAlpha()
	{
		return base.GetItem(2).GetAlpha();
	}

	// Token: 0x0600AAE4 RID: 43748 RVA: 0x00325E04 File Offset: 0x00324004
	public void SetBarFill(float value)
	{
		base.GetItem(3).SetUIActive(value > 0f);
		base.GetSprite(4).SetFillAmount(value);
	}

	// Token: 0x02007348 RID: 29512
	private enum EChildType
	{
		// Token: 0x0402588B RID: 153739
		CanChangeItem = 2,
		// Token: 0x0402588C RID: 153740
		BarItem,
		// Token: 0x0402588D RID: 153741
		BarSprite
	}
}
