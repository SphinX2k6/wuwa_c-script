using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BA5 RID: 7077
internal class FloroRanchTechLine : UiPanelBase
{
	// Token: 0x0600D2BB RID: 53947 RVA: 0x0030722C File Offset: 0x0030542C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600D2BC RID: 53948 RVA: 0x00307274 File Offset: 0x00305474
	public void Refresh(bool isUnlock)
	{
		UUISprite sprite = base.GetSprite(0);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = !isUnlock;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x02008146 RID: 33094
	private class EFloroRanchTechLineDefine
	{
		// Token: 0x0402A31E RID: 172830
		public const int SpriteLine = 0;
	}
}
