using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002C02 RID: 11266
public class TowerReviewItem : GridProxyAbstract<int>
{
	// Token: 0x06017667 RID: 95847 RVA: 0x005F5310 File Offset: 0x005F3510
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06017668 RID: 95848 RVA: 0x005F537C File Offset: 0x005F357C
	public override void Refresh(int towerId, bool isSelected, int gridIndex)
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(towerId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.AreaName, Array.Empty<object>());
		int areaStars = TowerModel.Instance.GetAreaStars(value.Difficulty, value.AreaNum, true);
		base.GetText(1).SetText(areaStars.ToString(), true);
	}

	// Token: 0x020091C9 RID: 37321
	private enum EChildType
	{
		// Token: 0x0402F2BD RID: 193213
		TowerNameText,
		// Token: 0x0402F2BE RID: 193214
		StarNumberText
	}
}
