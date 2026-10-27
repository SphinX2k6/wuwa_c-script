using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020028A5 RID: 10405
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleSkillBranchTipsContentItem : GridProxyAbstract<IRoleSkillBranchTipsContentItemData>
{
	// Token: 0x06015792 RID: 87954 RVA: 0x0056A570 File Offset: 0x00568770
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015793 RID: 87955 RVA: 0x0056A63C File Offset: 0x0056883C
	[NullableContext(1)]
	public override void Refresh(IRoleSkillBranchTipsContentItemData data, bool isSelected, int gridIndex)
	{
		base.GetSprite(0).SetUIActive(data.IsHighlight);
		base.GetSprite(1).SetUIActive(data.IsHighlight);
		this.SetSpriteByPath(data.IconPath, base.GetSprite(2), false, null, null);
		base.GetText(3).ShowTextNew(data.TitleKey);
		base.GetText(4).ShowTextNew(data.DescKey);
	}

	// Token: 0x02008EAD RID: 36525
	private enum EComponent
	{
		// Token: 0x0402E435 RID: 189493
		ArrowSprite,
		// Token: 0x0402E436 RID: 189494
		TagBgSprite,
		// Token: 0x0402E437 RID: 189495
		TagIconSprite,
		// Token: 0x0402E438 RID: 189496
		TitleTxt,
		// Token: 0x0402E439 RID: 189497
		DescTxt
	}
}
