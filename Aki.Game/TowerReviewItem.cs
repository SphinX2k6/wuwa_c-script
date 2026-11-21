using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200217D RID: 8573
public class TowerReviewItem : GridProxyAbstract<int>
{
	// Token: 0x06015098 RID: 86168 RVA: 0x00621E38 File Offset: 0x00620038
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

	// Token: 0x06015099 RID: 86169 RVA: 0x00621EA4 File Offset: 0x006200A4
	public override void Refresh(int towerId, bool isSelected, int gridIndex)
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(towerId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.AreaName, Array.Empty<object>());
		int areaStars = TowerModel.Instance.GetAreaStars(value.Difficulty, value.AreaNum, true);
		base.GetText(1).SetText(areaStars.ToString(), true);
	}

	// Token: 0x0200840C RID: 33804
	private enum EChildType
	{
		// Token: 0x0402A9BE RID: 174526
		TowerNameText,
		// Token: 0x0402A9BF RID: 174527
		StarNumberText
	}
}
