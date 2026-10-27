using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015C2 RID: 5570
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerScoreLevelTargetItem : GridProxyAbstract<WheelTowerScoreLevelTargetData>
{
	// Token: 0x06009DF2 RID: 40434 RVA: 0x00225794 File Offset: 0x00223994
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009DF3 RID: 40435 RVA: 0x00225840 File Offset: 0x00223A40
	public override void Refresh(WheelTowerScoreLevelTargetData data, bool isSelected, int gridIndex)
	{
		NewTowerScoreLevel? scoreLevelConfigById = WheelTowerConfig.Instance.GetScoreLevelConfigById(data.LevelId);
		if (scoreLevelConfigById == null)
		{
			return;
		}
		base.SetTextureByPath(scoreLevelConfigById.Value.Icon, base.GetTexture(0), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WheelTower_ScoreReach", new <>z__ReadOnlySingleElementList<object>(data.Score));
		bool flag = WheelTowerModel.Instance.GetRoundTotalScore(WheelTowerModel.Instance.SelectedRound) >= data.Score;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(!flag);
	}
}
