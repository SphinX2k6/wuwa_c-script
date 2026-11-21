using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000A72 RID: 2674
internal class BossTagItem : GridProxyAbstract<int>
{
	// Token: 0x060071B6 RID: 29110 RVA: 0x0022E948 File Offset: 0x0022CB48
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

	// Token: 0x060071B7 RID: 29111 RVA: 0x0022E9D2 File Offset: 0x0022CBD2
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.RefreshByData(data);
	}

	// Token: 0x060071B8 RID: 29112 RVA: 0x0022E9DC File Offset: 0x0022CBDC
	public void RefreshByData(int data)
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
