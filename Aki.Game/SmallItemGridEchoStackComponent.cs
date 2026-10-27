using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001976 RID: 6518
public class SmallItemGridEchoStackComponent : SmallItemGridComponent
{
	// Token: 0x0600BED5 RID: 48853 RVA: 0x002B2C34 File Offset: 0x002B0E34
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

	// Token: 0x0600BED6 RID: 48854 RVA: 0x002B2C9D File Offset: 0x002B0E9D
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "PnlEchoStackB";
	}

	// Token: 0x0600BED7 RID: 48855 RVA: 0x002B2CA4 File Offset: 0x002B0EA4
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x0600BED8 RID: 48856 RVA: 0x002B2CA8 File Offset: 0x002B0EA8
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

	// Token: 0x02007EC2 RID: 32450
	private class EChildType
	{
		// Token: 0x040296FC RID: 169724
		public const int SpriteStateIcon = 0;

		// Token: 0x040296FD RID: 169725
		public const int TextNum = 1;
	}
}
