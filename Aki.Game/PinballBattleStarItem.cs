using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CF0 RID: 7408
internal class PinballBattleStarItem : GridProxyAbstract<bool>
{
	// Token: 0x0600E07C RID: 57468 RVA: 0x00349D78 File Offset: 0x00347F78
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

	// Token: 0x0600E07D RID: 57469 RVA: 0x00349DC0 File Offset: 0x00347FC0
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
