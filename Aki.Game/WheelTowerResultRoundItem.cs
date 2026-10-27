using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015AE RID: 5550
public class WheelTowerResultRoundItem : UiPanelBase
{
	// Token: 0x06009DB1 RID: 40369 RVA: 0x00223F30 File Offset: 0x00222130
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

	// Token: 0x06009DB2 RID: 40370 RVA: 0x00223F78 File Offset: 0x00222178
	protected override void OnStart()
	{
		this.Player = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06009DB3 RID: 40371 RVA: 0x00223F8B File Offset: 0x0022218B
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer player = this.Player;
		if (player == null)
		{
			return;
		}
		player.Clear();
	}

	// Token: 0x06009DB4 RID: 40372 RVA: 0x00223FA0 File Offset: 0x002221A0
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

	// Token: 0x040045A1 RID: 17825
	[Nullable(2)]
	private LevelSequencePlayer Player;
}
