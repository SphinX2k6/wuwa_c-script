using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000E33 RID: 3635
public class SmallItemGridEchoStackComponent : SmallItemGridComponent
{
	// Token: 0x060092DD RID: 37597 RVA: 0x002BDBB8 File Offset: 0x002BBDB8
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

	// Token: 0x060092DE RID: 37598 RVA: 0x002BDC21 File Offset: 0x002BBE21
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "PnlEchoStackB";
	}

	// Token: 0x060092DF RID: 37599 RVA: 0x002BDC28 File Offset: 0x002BBE28
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x060092E0 RID: 37600 RVA: 0x002BDC2C File Offset: 0x002BBE2C
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

	// Token: 0x02007051 RID: 28753
	private class EChildType
	{
		// Token: 0x04024A39 RID: 150073
		public const int SpriteStateIcon = 0;

		// Token: 0x04024A3A RID: 150074
		public const int TextNum = 1;
	}
}
