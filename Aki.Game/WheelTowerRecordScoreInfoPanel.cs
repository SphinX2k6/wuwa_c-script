using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A5D RID: 2653
public class WheelTowerRecordScoreInfoPanel : UiPanelBase
{
	// Token: 0x06007179 RID: 29049 RVA: 0x0022D51C File Offset: 0x0022B71C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600717A RID: 29050 RVA: 0x0022D5A8 File Offset: 0x0022B7A8
	public void Refresh()
	{
		WheelTowerModel instance = WheelTowerModel.Instance;
		int selectedRound = instance.SelectedRound;
		bool endlessMode = instance.EndlessMode;
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetUIActive(endlessMode);
		}
		MonsterInfoPreview bossInfoByRound = instance.GetBossInfoByRound(selectedRound, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WheelTower_BossProgress_Endless", new <>z__ReadOnlySingleElementList<object>(bossInfoByRound.Round));
		int roundScore = instance.GetRoundScore(selectedRound);
		UUIText text2 = base.GetText(0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (text2 != null)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted<int>(roundScore);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		ValueTuple<int, int> bossProgress = instance.GetBossProgress(selectedRound, null);
		int item = bossProgress.Item1;
		int item2 = bossProgress.Item2;
		UUIText text3 = base.GetText(2);
		if (text3 == null)
		{
			return;
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
		text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}
}
