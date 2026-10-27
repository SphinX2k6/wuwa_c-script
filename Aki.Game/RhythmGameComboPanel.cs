using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001084 RID: 4228
public class RhythmGameComboPanel : UiPanelBase
{
	// Token: 0x06006DB7 RID: 28087 RVA: 0x00163384 File Offset: 0x00161584
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

	// Token: 0x06006DB8 RID: 28088 RVA: 0x001633ED File Offset: 0x001615ED
	protected override void OnBeforeCreate()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(false);
		}
		this.TextComboNum = base.GetText(1);
	}

	// Token: 0x06006DB9 RID: 28089 RVA: 0x00163420 File Offset: 0x00161620
	public void SetCombo(int combo)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem != null && !rootItem.bIsUIActive && combo > 0)
		{
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 != null)
			{
				rootItem2.SetUIActive(true);
			}
		}
		if (combo > 0)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayLevelSequenceByName((this.LastCombo > 0) ? "Up" : "Start", false, null, false);
			}
			UUIText textComboNum = this.TextComboNum;
			if (textComboNum != null)
			{
				textComboNum.SetText(combo.ToString(), true);
			}
		}
		else if (this.LastCombo > 0)
		{
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null)
			{
				sequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
			}
		}
		this.LastCombo = combo;
	}

	// Token: 0x040032AC RID: 12972
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040032AD RID: 12973
	[Nullable(2)]
	private UUIText TextComboNum;

	// Token: 0x040032AE RID: 12974
	private int LastCombo;

	// Token: 0x02007676 RID: 30326
	private enum EViewComponent
	{
		// Token: 0x04027189 RID: 160137
		TextCombo,
		// Token: 0x0402718A RID: 160138
		TextComboNum
	}
}
