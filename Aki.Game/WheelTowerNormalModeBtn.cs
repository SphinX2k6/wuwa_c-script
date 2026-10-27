using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001606 RID: 5638
public class WheelTowerNormalModeBtn : UiPanelBase
{
	// Token: 0x06009EDC RID: 40668 RVA: 0x0022B9C8 File Offset: 0x00229BC8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009EDD RID: 40669 RVA: 0x0022BAB0 File Offset: 0x00229CB0
	public void Refresh()
	{
		WheelTowerModel instance = WheelTowerModel.Instance;
		int totalScore = instance.ActivityData.GetTotalScore(false);
		EScoreLevel totalScoreLevel = instance.GetTotalScoreLevel(totalScore, new bool?(false), null);
		NewTowerScoreLevel? scoreLevelConfigById = WheelTowerConfig.Instance.GetScoreLevelConfigById((int)totalScoreLevel);
		if (scoreLevelConfigById == null)
		{
			return;
		}
		base.SetTextureByPath(scoreLevelConfigById.Value.Icon, base.GetTexture(1), null, null);
		UUITexture texture = base.GetTexture(3);
		if (texture != null)
		{
			texture.SetColor(FColor.FromHex(scoreLevelConfigById.Value.BgColor));
		}
		ValueTuple<int, int> bossProgress = instance.GetBossProgress(instance.GetMaxChallengeRound(new bool?(false)), new bool?(false));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "WheelTowerNormalFinishedNum", new <>z__ReadOnlyArray<object>(new object[]
		{
			bossProgress.Item1,
			bossProgress.Item2
		}));
	}

	// Token: 0x06009EDE RID: 40670 RVA: 0x0022BBA6 File Offset: 0x00229DA6
	private void OnButtonClick()
	{
		WheelTowerModel.Instance.SetEndlessMode(false);
		UiManager.Instance.OpenView(EUiViewName.WheelTowerModeDetailView, null, null);
	}
}
