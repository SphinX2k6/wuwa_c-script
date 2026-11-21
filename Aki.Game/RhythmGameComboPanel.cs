using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000538 RID: 1336
public class RhythmGameComboPanel : UiPanelBase
{
	// Token: 0x0600414C RID: 16716 RVA: 0x0016BCB8 File Offset: 0x00169EB8
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

	// Token: 0x0600414D RID: 16717 RVA: 0x0016BD21 File Offset: 0x00169F21
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

	// Token: 0x0600414E RID: 16718 RVA: 0x0016BD54 File Offset: 0x00169F54
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

	// Token: 0x04003345 RID: 13125
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003346 RID: 13126
	[Nullable(2)]
	private UUIText TextComboNum;

	// Token: 0x04003347 RID: 13127
	private int LastCombo;

	// Token: 0x0200680A RID: 26634
	private enum EViewComponent
	{
		// Token: 0x040224D4 RID: 140500
		TextCombo,
		// Token: 0x040224D5 RID: 140501
		TextComboNum
	}
}
