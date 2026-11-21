using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001E20 RID: 7712
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleSkillBranchTipsContentItem : GridProxyAbstract<IRoleSkillBranchTipsContentItemData>
{
	// Token: 0x06013192 RID: 78226 RVA: 0x005953B8 File Offset: 0x005935B8
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

	// Token: 0x06013193 RID: 78227 RVA: 0x00595484 File Offset: 0x00593684
	[NullableContext(1)]
	public override void Refresh(IRoleSkillBranchTipsContentItemData data, bool isSelected, int gridIndex)
	{
		base.GetSprite(0).SetUIActive(data.IsHighlight);
		base.GetSprite(1).SetUIActive(data.IsHighlight);
		this.SetSpriteByPath(data.IconPath, base.GetSprite(2), false, null, null);
		base.GetText(3).ShowTextNew(data.TitleKey);
		base.GetText(4).ShowTextNew(data.DescKey);
	}

	// Token: 0x020080F4 RID: 33012
	private enum EComponent
	{
		// Token: 0x04029B32 RID: 170802
		ArrowSprite,
		// Token: 0x04029B33 RID: 170803
		TagBgSprite,
		// Token: 0x04029B34 RID: 170804
		TagIconSprite,
		// Token: 0x04029B35 RID: 170805
		TitleTxt,
		// Token: 0x04029B36 RID: 170806
		DescTxt
	}
}
