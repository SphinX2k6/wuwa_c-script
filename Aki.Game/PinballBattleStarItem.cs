using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020011B2 RID: 4530
internal class PinballBattleStarItem : GridProxyAbstract<bool>
{
	// Token: 0x0600B499 RID: 46233 RVA: 0x003557A0 File Offset: 0x003539A0
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

	// Token: 0x0600B49A RID: 46234 RVA: 0x003557E8 File Offset: 0x003539E8
	public override void Refresh(bool isBright, bool isSelected, int gridIndex)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(isBright);
	}
}
