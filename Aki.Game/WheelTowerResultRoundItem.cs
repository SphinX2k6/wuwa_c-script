using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A66 RID: 2662
public class WheelTowerResultRoundItem : UiPanelBase
{
	// Token: 0x0600718F RID: 29071 RVA: 0x0022DCE0 File Offset: 0x0022BEE0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007190 RID: 29072 RVA: 0x0022DD28 File Offset: 0x0022BF28
	protected override void OnStart()
	{
		this.Player = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06007191 RID: 29073 RVA: 0x0022DD3B File Offset: 0x0022BF3B
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer player = this.Player;
		if (player == null)
		{
			return;
		}
		player.Clear();
	}

	// Token: 0x06007192 RID: 29074 RVA: 0x0022DD50 File Offset: 0x0022BF50
	public void Refresh(bool endless, int currentRound, int totalRound)
	{
		base.SetUiActive(true);
		string textStringId = endless ? "WheelBattleResult_Endless" : "WheelBattleResult_Normal";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, new <>z__ReadOnlyArray<object>(new object[]
		{
			currentRound,
			totalRound
		}));
		LevelSequencePlayer player = this.Player;
		if (player == null)
		{
			return;
		}
		player.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x04004647 RID: 17991
	[Nullable(2)]
	private LevelSequencePlayer Player;
}
