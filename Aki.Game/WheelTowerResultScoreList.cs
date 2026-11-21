using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A6A RID: 2666
public class WheelTowerResultScoreList : UiPanelBase
{
	// Token: 0x0600719B RID: 29083 RVA: 0x0022DE20 File Offset: 0x0022C020
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600719C RID: 29084 RVA: 0x0022DE68 File Offset: 0x0022C068
	protected override void OnStart()
	{
		UUIVerticalLayout uuiverticalLayout = this.RootItem.GetOwner().GetComponentByClass(UUIVerticalLayout.StaticClass()) as UUIVerticalLayout;
		if (uuiverticalLayout != null)
		{
			this.ScoreList = new GenericLayout<WheelTowerResultScoreList.ScoreInfoItem, WheelTowerResultScoreInfoItemData>(uuiverticalLayout, new Func<WheelTowerResultScoreList.ScoreInfoItem>(this.CreateScoreInfoItem), null, false, true);
		}
	}

	// Token: 0x0600719D RID: 29085 RVA: 0x0022DEB3 File Offset: 0x0022C0B3
	[NullableContext(1)]
	private WheelTowerResultScoreList.ScoreInfoItem CreateScoreInfoItem()
	{
		return new WheelTowerResultScoreList.ScoreInfoItem();
	}

	// Token: 0x0600719E RID: 29086 RVA: 0x0022DEBC File Offset: 0x0022C0BC
	public void Refresh(int totalScore, int roundScore)
	{
		base.SetUiActive(true);
		WheelTowerModel instance = WheelTowerModel.Instance;
		GenericLayout<WheelTowerResultScoreList.ScoreInfoItem, WheelTowerResultScoreInfoItemData> scoreList = this.ScoreList;
		if (scoreList == null)
		{
			return;
		}
		scoreList.RefreshByData(new <>z__ReadOnlyArray<WheelTowerResultScoreInfoItemData>(new WheelTowerResultScoreInfoItemData[]
		{
			new WheelTowerResultScoreInfoItemData
			{
				Desc = "WheelBattleResult_CurTotalScore",
				Score = totalScore.ToString(),
				ScoreLevel = instance.GetTotalScoreLevel(totalScore, null, null)
			},
			new WheelTowerResultScoreInfoItemData
			{
				Desc = "WheelBattleResult_CurScore",
				Score = roundScore.ToString(),
				ScoreLevel = instance.GetRoundScoreLevel(roundScore)
			}
		}), null, false);
	}

	// Token: 0x04004651 RID: 18001
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerResultScoreList.ScoreInfoItem, WheelTowerResultScoreInfoItemData> ScoreList;

	// Token: 0x02006D45 RID: 27973
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private class ScoreInfoItem : GridProxyAbstract<WheelTowerResultScoreInfoItemData>
	{
		// Token: 0x0603FB89 RID: 261001 RVA: 0x012A58EC File Offset: 0x012A3AEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FB8A RID: 261002 RVA: 0x012A5976 File Offset: 0x012A3B76
		protected override void OnStart()
		{
			this.ScoreItem = new WheelTowerScoreItem(this, base.GetItem(1));
			this.Player = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603FB8B RID: 261003 RVA: 0x012A599C File Offset: 0x012A3B9C
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer player = this.Player;
			if (player == null)
			{
				return;
			}
			player.Clear();
		}

		// Token: 0x0603FB8C RID: 261004 RVA: 0x012A59B0 File Offset: 0x012A3BB0
		[NullableContext(1)]
		public override void Refresh(WheelTowerResultScoreInfoItemData data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(data.Desc);
			}
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				text2.SetText(data.Score, true);
			}
			WheelTowerScoreItem scoreItem = this.ScoreItem;
			if (scoreItem != null)
			{
				scoreItem.Refresh(data.ScoreLevel);
			}
			LevelSequencePlayer player = this.Player;
			if (player == null)
			{
				return;
			}
			player.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x04023DED RID: 146925
		private WheelTowerScoreItem ScoreItem;

		// Token: 0x04023DEE RID: 146926
		private LevelSequencePlayer Player;
	}
}
