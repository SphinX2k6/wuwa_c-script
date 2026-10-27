using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015E6 RID: 5606
public class WheelTowerSettlementScorePanel : UiPanelBase
{
	// Token: 0x06009E60 RID: 40544 RVA: 0x002288E4 File Offset: 0x00226AE4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009E61 RID: 40545 RVA: 0x00228A9C File Offset: 0x00226C9C
	public void RefreshRoundWave(bool isEndless, int curBossRound, int curBossWave, int maxBossWave)
	{
		string textStringId = isEndless ? "WheelTower_Settlement_RoundScore" : "WheelTower_Settlement_RoundScore_Normal";
		if (isEndless)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				curBossRound,
				curBossWave,
				maxBossWave
			}));
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, new <>z__ReadOnlyArray<object>(new object[]
		{
			curBossWave,
			maxBossWave
		}));
	}

	// Token: 0x06009E62 RID: 40546 RVA: 0x00228B26 File Offset: 0x00226D26
	public void RefreshTotalScore(int score)
	{
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetText(score.ToString(), true);
	}

	// Token: 0x06009E63 RID: 40547 RVA: 0x00228B44 File Offset: 0x00226D44
	public void RefreshScoreLevel(int scoreLevel)
	{
		NewTowerScoreLevel? scoreLevelConfigById = WheelTowerConfig.Instance.GetScoreLevelConfigById(scoreLevel);
		if (scoreLevelConfigById == null)
		{
			return;
		}
		base.SetTextureByPath(scoreLevelConfigById.Value.Icon, base.GetTexture(5), null, null);
		UUITexture texture = base.GetTexture(6);
		if (texture != null)
		{
			texture.SetColor(FColor.FromHex(scoreLevelConfigById.Value.GridColor));
		}
		UUITexture texture2 = base.GetTexture(7);
		if (texture2 != null)
		{
			texture2.SetColor(FColor.FromHex(scoreLevelConfigById.Value.CircleColor));
		}
		UUITexture texture3 = base.GetTexture(8);
		if (texture3 != null)
		{
			texture3.SetColor(FColor.FromHex(scoreLevelConfigById.Value.CircleColor));
		}
		UUITexture texture4 = base.GetTexture(9);
		if (texture4 != null)
		{
			texture4.SetColor(FColor.FromHex(scoreLevelConfigById.Value.BgColor));
		}
		UUITexture texture5 = base.GetTexture(10);
		if (texture5 != null)
		{
			texture5.SetColor(FColor.FromHex(scoreLevelConfigById.Value.BgLightColor));
		}
		bool flag = scoreLevel == 7;
		UUITexture texture6 = base.GetTexture(10);
		if (texture6 != null)
		{
			texture6.SetUIActive(!flag);
		}
		UUITexture texture7 = base.GetTexture(11);
		if (texture7 != null)
		{
			texture7.SetUIActive(flag);
		}
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetColor(FColor.FromHex(scoreLevelConfigById.Value.TextColor));
	}
}
