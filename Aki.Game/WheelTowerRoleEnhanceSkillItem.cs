using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001583 RID: 5507
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerRoleEnhanceSkillItem : GridProxyAbstract<WheelTowerRoleEnhanceSkillData>
{
	// Token: 0x06009D4D RID: 40269 RVA: 0x00221678 File Offset: 0x0021F878
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009D4E RID: 40270 RVA: 0x00221786 File Offset: 0x0021F986
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06009D4F RID: 40271 RVA: 0x0022179C File Offset: 0x0021F99C
	public override void Refresh(WheelTowerRoleEnhanceSkillData data, bool isSelected, int gridIndex)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.SkillName, Array.Empty<object>());
		this.SetSpriteByPath(data.SkillIcon, base.GetSprite(6), false, null, null);
		UUIText text = base.GetText(4);
		if (text == null)
		{
			return;
		}
		text.SetText(data.SkillDesc, true);
	}
}
