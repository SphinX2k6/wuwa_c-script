using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015BA RID: 5562
internal class BossTagItem : GridProxyAbstract<int>
{
	// Token: 0x06009DD8 RID: 40408 RVA: 0x00224B98 File Offset: 0x00222D98
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

	// Token: 0x06009DD9 RID: 40409 RVA: 0x00224C22 File Offset: 0x00222E22
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.RefreshByData(data);
	}

	// Token: 0x06009DDA RID: 40410 RVA: 0x00224C2C File Offset: 0x00222E2C
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
