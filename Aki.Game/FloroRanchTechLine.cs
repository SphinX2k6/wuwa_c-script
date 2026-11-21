using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001064 RID: 4196
internal class FloroRanchTechLine : UiPanelBase
{
	// Token: 0x0600A6CC RID: 42700 RVA: 0x0031230C File Offset: 0x0031050C
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

	// Token: 0x0600A6CD RID: 42701 RVA: 0x00312354 File Offset: 0x00310554
	public void Refresh(bool isUnlock)
	{
		UUISprite sprite = base.GetSprite(0);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = !isUnlock;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x020072D4 RID: 29396
	private class EFloroRanchTechLineDefine
	{
		// Token: 0x04025652 RID: 153170
		public const int SpriteLine = 0;
	}
}
