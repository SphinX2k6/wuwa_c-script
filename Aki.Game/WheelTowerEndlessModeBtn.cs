using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001600 RID: 5632
public class WheelTowerEndlessModeBtn : UiPanelBase
{
	// Token: 0x06009ED2 RID: 40658 RVA: 0x0022B45C File Offset: 0x0022965C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009ED3 RID: 40659 RVA: 0x0022B5A8 File Offset: 0x002297A8
	public void Refresh()
	{
		WheelTowerModel instance = WheelTowerModel.Instance;
		WheelTowerData activityData = instance.ActivityData;
		int totalScore = activityData.GetTotalScore(true);
		EScoreLevel totalScoreLevel = instance.GetTotalScoreLevel(totalScore, new bool?(true), null);
		NewTowerScoreLevel? scoreLevelConfigById = WheelTowerConfig.Instance.GetScoreLevelConfigById((int)totalScoreLevel);
		if (scoreLevelConfigById != null)
		{
			base.SetTextureByPath(scoreLevelConfigById.Value.Icon, base.GetTexture(1), null, null);
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetColor(FColor.FromHex(scoreLevelConfigById.Value.BgColor));
			}
		}
		bool flag = activityData.IsLevelUnlocked(true);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.SetSelfInteractive(flag);
		}
		if (flag)
		{
			ValueTuple<int, int> bossProgress = instance.GetBossProgress(instance.GetMaxChallengeRound(new bool?(true)), new bool?(true));
			MonsterInfoPreview lastBossInfo = instance.GetLastBossInfo(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "WheelTower_Endless_CurProgress", new <>z__ReadOnlyArray<object>(new object[]
			{
				lastBossInfo.Round,
				bossProgress.Item1,
				bossProgress.Item2
			}));
		}
		NewTowerClimbingLevelRecord levelRecord = activityData.GetLevelRecord(true);
		NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(levelRecord.LevelId);
		if (levelConfigById != null)
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(levelConfigById.Value.Cond);
			if (!string.IsNullOrEmpty(conditionGroupHintText))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), conditionGroupHintText, Array.Empty<object>());
			}
		}
	}

	// Token: 0x06009ED4 RID: 40660 RVA: 0x0022B761 File Offset: 0x00229961
	private void OnButtonClick()
	{
		WheelTowerModel.Instance.SetEndlessMode(true);
		UiManager.Instance.OpenView(EUiViewName.WheelTowerModeDetailView, null, null);
	}
}
