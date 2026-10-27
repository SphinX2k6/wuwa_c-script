using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CEB RID: 7403
public class PinballBattleLaunchDirectionItem : UiPanelBase
{
	// Token: 0x0600E03F RID: 57407 RVA: 0x003489C8 File Offset: 0x00346BC8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E040 RID: 57408 RVA: 0x00348A31 File Offset: 0x00346C31
	protected override void OnStart()
	{
		UUITexture texture = base.GetTexture(0);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(false);
	}
}
