using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001912 RID: 6418
public class MediumItemGridEchoStackComponent : MediumItemGridComponent
{
	// Token: 0x0600BC07 RID: 48135 RVA: 0x002A9E64 File Offset: 0x002A8064
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BC08 RID: 48136 RVA: 0x002A9ECD File Offset: 0x002A80CD
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "PnlEchoStack";
	}

	// Token: 0x0600BC09 RID: 48137 RVA: 0x002A9ED4 File Offset: 0x002A80D4
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		MediumItemGridEchoStack mediumItemGridEchoStack = data as MediumItemGridEchoStack;
		if (mediumItemGridEchoStack == null)
		{
			return;
		}
		if (mediumItemGridEchoStack.Count <= 0)
		{
			this.SetActive(false);
			return;
		}
		string echoStackBadgeSpritePath = PhantomStackUtil.GetEchoStackBadgeSpritePath(mediumItemGridEchoStack.Type);
		this.SetSpriteByPath(echoStackBadgeSpritePath, base.GetSprite(0), false, null, null);
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(PhantomStackUtil.GetEchoStackBadgeCountText(mediumItemGridEchoStack.Count), true);
		}
		this.SetActive(true);
	}

	// Token: 0x02007E85 RID: 32389
	private class EChildType
	{
		// Token: 0x04029651 RID: 169553
		public const int SpriteStateIcon = 0;

		// Token: 0x04029652 RID: 169554
		public const int TextNum = 1;
	}
}
