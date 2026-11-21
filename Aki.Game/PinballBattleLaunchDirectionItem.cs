using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011AD RID: 4525
public class PinballBattleLaunchDirectionItem : UiPanelBase
{
	// Token: 0x0600B45C RID: 46172 RVA: 0x003543F0 File Offset: 0x003525F0
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

	// Token: 0x0600B45D RID: 46173 RVA: 0x00354459 File Offset: 0x00352659
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
