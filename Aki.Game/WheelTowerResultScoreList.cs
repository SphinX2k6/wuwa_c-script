using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015B2 RID: 5554
public class WheelTowerResultScoreList : UiPanelBase
{
	// Token: 0x06009DBD RID: 40381 RVA: 0x00224070 File Offset: 0x00222270
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

	// Token: 0x06009DBE RID: 40382 RVA: 0x002240B8 File Offset: 0x002222B8
	protected override void OnStart()
	{
		UUIVerticalLayout uuiverticalLayout = this.RootItem.GetOwner().GetComponentByClass(UUIVerticalLayout.StaticClass()) as UUIVerticalLayout;
		if (uuiverticalLayout != null)
		{
			this.ScoreList = new GenericLayout<WheelTowerResultScoreList.ScoreInfoItem, WheelTowerResultScoreInfoItemData>(uuiverticalLayout, new Func<WheelTowerResultScoreList.ScoreInfoItem>(this.CreateScoreInfoItem), null, false, true);
		}
	}

	// Token: 0x06009DBF RID: 40383 RVA: 0x00224103 File Offset: 0x00222303
	[NullableContext(1)]
	private WheelTowerResultScoreList.ScoreInfoItem CreateScoreInfoItem()
	{
		return new WheelTowerResultScoreList.ScoreInfoItem();
	}

	// Token: 0x06009DC0 RID: 40384 RVA: 0x0022410C File Offset: 0x0022230C
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

	// Token: 0x040045AB RID: 17835
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerResultScoreList.ScoreInfoItem, WheelTowerResultScoreInfoItemData> ScoreList;

	// Token: 0x02007BBA RID: 31674
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private class ScoreInfoItem : GridProxyAbstract<WheelTowerResultScoreInfoItemData>
	{
		// Token: 0x06049762 RID: 300898 RVA: 0x013025D4 File Offset: 0x013007D4
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

		// Token: 0x06049763 RID: 300899 RVA: 0x0130265E File Offset: 0x0130085E
		protected override void OnStart()
		{
			this.ScoreItem = new WheelTowerScoreItem(this, base.GetItem(1));
			this.Player = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06049764 RID: 300900 RVA: 0x01302684 File Offset: 0x01300884
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer player = this.Player;
			if (player == null)
			{
				return;
			}
			player.Clear();
		}

		// Token: 0x06049765 RID: 300901 RVA: 0x01302698 File Offset: 0x01300898
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

		// Token: 0x04028AB2 RID: 166578
		private WheelTowerScoreItem ScoreItem;

		// Token: 0x04028AB3 RID: 166579
		private LevelSequencePlayer Player;
	}
}
