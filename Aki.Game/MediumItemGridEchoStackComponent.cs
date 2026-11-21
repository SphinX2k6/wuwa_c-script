using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000DCB RID: 3531
public class MediumItemGridEchoStackComponent : MediumItemGridComponent
{
	// Token: 0x06008FF1 RID: 36849 RVA: 0x002B45C0 File Offset: 0x002B27C0
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

	// Token: 0x06008FF2 RID: 36850 RVA: 0x002B4629 File Offset: 0x002B2829
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "PnlEchoStack";
	}

	// Token: 0x06008FF3 RID: 36851 RVA: 0x002B4630 File Offset: 0x002B2830
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

	// Token: 0x0200700C RID: 28684
	private class EChildType
	{
		// Token: 0x0402497D RID: 149885
		public const int SpriteStateIcon = 0;

		// Token: 0x0402497E RID: 149886
		public const int TextNum = 1;
	}
}
