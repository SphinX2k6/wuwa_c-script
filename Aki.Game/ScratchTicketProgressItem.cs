using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020014F1 RID: 5361
[Nullable(new byte[]
{
	0,
	1
})]
public class ScratchTicketProgressItem : GridProxyAbstract<ScratchTicketRoundData>
{
	// Token: 0x060098CD RID: 39117 RVA: 0x00210438 File Offset: 0x0020E638
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060098CE RID: 39118 RVA: 0x00210528 File Offset: 0x0020E728
	[NullableContext(1)]
	public override void Refresh(ScratchTicketRoundData data, bool isSelected, int gridIndex)
	{
		EScratchTicketRoundState roundState = data.GetRoundState();
		base.GetItem(0).SetUIActive(roundState == EScratchTicketRoundState.InProgress);
		UUISprite sprite = base.GetSprite(1);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = roundState != EScratchTicketRoundState.InProgress;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		base.GetItem(2).SetUIActive(roundState == EScratchTicketRoundState.Lock);
		base.GetItem(3).SetUIActive(roundState == EScratchTicketRoundState.Finish);
		UUISprite sprite2 = base.GetSprite(4);
		UUISprite sprite3 = base.GetSprite(5);
		sprite2.SetUIActive(roundState == EScratchTicketRoundState.InProgress);
		this.SetSpriteByPath(data.Config.Value.YellowRoundIcon, sprite2, false, null, null);
		sprite3.SetUIActive(roundState != EScratchTicketRoundState.InProgress);
		this.SetSpriteByPath(data.Config.Value.BlackRoundIcon, sprite3, false, null, null);
	}

	// Token: 0x02007B25 RID: 31525
	private class EComponent
	{
		// Token: 0x040287FF RID: 165887
		public const int SelectFrame = 0;

		// Token: 0x04028800 RID: 165888
		public const int PackageSprite = 1;

		// Token: 0x04028801 RID: 165889
		public const int LockItem = 2;

		// Token: 0x04028802 RID: 165890
		public const int FinishItem = 3;

		// Token: 0x04028803 RID: 165891
		public const int YellowRoundIcon = 4;

		// Token: 0x04028804 RID: 165892
		public const int BlackRoundIcon = 5;
	}
}
