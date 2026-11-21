using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000A49 RID: 2633
public class WheelTowerBossTagItem : GridProxyAbstract<int>
{
	// Token: 0x0600714F RID: 29007 RVA: 0x0022BF7C File Offset: 0x0022A17C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007150 RID: 29008 RVA: 0x0022C008 File Offset: 0x0022A208
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		NewTowerTag? tagConfigByTagId = WheelTowerConfig.Instance.GetTagConfigByTagId(data);
		if (tagConfigByTagId == null)
		{
			return;
		}
		base.GetText(1).ShowTextNew(tagConfigByTagId.Value.Name);
		base.GetSprite(0).SetColor(FColor.FromHex(tagConfigByTagId.Value.Color));
		this.SetSpriteByPath(tagConfigByTagId.Value.Path, base.GetSprite(2), false, null, null);
	}
}
