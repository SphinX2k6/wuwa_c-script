using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001591 RID: 5521
public class WheelTowerBossTagItem : GridProxyAbstract<int>
{
	// Token: 0x06009D71 RID: 40305 RVA: 0x002221CC File Offset: 0x002203CC
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

	// Token: 0x06009D72 RID: 40306 RVA: 0x00222258 File Offset: 0x00220458
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
