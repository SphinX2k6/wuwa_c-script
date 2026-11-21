using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000B6F RID: 2927
[NullableContext(2)]
[Nullable(0)]
public class PeriodicityChallengeTypeItem : GridProxyAbstract<EDungeonType>
{
	// Token: 0x060079BD RID: 31165 RVA: 0x0025B390 File Offset: 0x00259590
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060079BE RID: 31166 RVA: 0x0025B5C8 File Offset: 0x002597C8
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(0);
		UUIExtendToggle toggle = this.Toggle;
		if (toggle != null)
		{
			toggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		}
		base.GetItem(2).SetUIActive(false);
		base.GetItem(12).SetUIActive(false);
		base.GetText(10).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
	}

	// Token: 0x060079BF RID: 31167 RVA: 0x0025B63C File Offset: 0x0025983C
	[NullableContext(1)]
	public void BindOnToggleFunc(Action<int, UUIExtendToggle> toggleFunc)
	{
		this.ToggleFunc = delegate(int curId, UUIExtendToggle toggle)
		{
			toggleFunc(curId, toggle);
		};
	}

	// Token: 0x060079C0 RID: 31168 RVA: 0x0025B668 File Offset: 0x00259868
	[NullableContext(1)]
	public void BindCanToggleExecuteChange(Func<int, bool> toggle)
	{
		this.OnCanToggleClicked = toggle;
	}

	// Token: 0x060079C1 RID: 31169 RVA: 0x0025B671 File Offset: 0x00259871
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.OnCanToggleClicked((int)this.TypeId);
	}

	// Token: 0x060079C2 RID: 31170 RVA: 0x0025B690 File Offset: 0x00259890
	public override void Refresh(EDungeonType data, bool isSelected, int gridIndex)
	{
		this.TypeId = data;
		SecondaryGuideData value = AdventureGuideConfig.Instance.GetSecondaryGuideDataConf((int)this.TypeId).Value;
		UUIText text = base.GetText(4);
		LguiUtil.Instance.SetLocalTextNew(text, value.Text, Array.Empty<object>());
		this.SetSpriteByPath(value.Icon, base.GetSprite(3), false, null, null);
		this.SetSpriteByPath(value.Icon, base.GetSprite(13), false, null, null);
		this.Toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshSubText();
		this.RefreshDoubleIcon();
	}

	// Token: 0x060079C3 RID: 31171 RVA: 0x0025B738 File Offset: 0x00259938
	public void RefreshSubText()
	{
		IPeriodicityChallengeTypeData periodicityChallengeTypeData = null;
		if (this.TypeId == EDungeonType.Tower)
		{
			periodicityChallengeTypeData = this.GetTowerData();
		}
		else if (this.TypeId == EDungeonType.ShipTower)
		{
			periodicityChallengeTypeData = this.GetShipTowerData();
		}
		else if (this.TypeId == EDungeonType.WeeklyRogue)
		{
			periodicityChallengeTypeData = this.GetWeeklyRougeData();
		}
		else if (this.TypeId == EDungeonType.WheelTower)
		{
			periodicityChallengeTypeData = this.GetWheelTowerData();
		}
		if (periodicityChallengeTypeData == null)
		{
			return;
		}
		base.GetItem(7).SetUIActive(periodicityChallengeTypeData.IsFinish);
		base.GetItem(2).SetUIActive(periodicityChallengeTypeData.RedPoint);
		base.GetText(8).SetText(periodicityChallengeTypeData.SubText, true);
		SecondaryGuideData? secondaryGuideDataConf = AdventureGuideConfig.Instance.GetSecondaryGuideDataConf((int)this.TypeId);
		if (secondaryGuideDataConf != null && secondaryGuideDataConf.Value.TimeOutDay > 0 && this.IsTimeOutType())
		{
			bool uiactive = periodicityChallengeTypeData.LeftTime <= (float)(secondaryGuideDataConf.Value.TimeOutDay * TimeUtil.Instance.OneDaySeconds);
			base.GetItem(12).SetUIActive(uiactive);
		}
	}

	// Token: 0x060079C4 RID: 31172 RVA: 0x0025B834 File Offset: 0x00259A34
	private IPeriodicityChallengeTypeData GetTowerData()
	{
		if (!FunctionModel.Instance.IsOpen(10055))
		{
			return null;
		}
		TowerModel instance = TowerModel.Instance;
		double num = (double)((int)MathUtils.Instance.LongToNumber(instance.TowerEndTime.Value)) - TimeUtil.Instance.GetServerTime();
		int difficultyMaxStars = instance.GetDifficultyMaxStars(3, false);
		int difficultyAllStars = instance.GetDifficultyAllStars(3, false);
		float difficultyRewardProgress = instance.GetDifficultyRewardProgress(3);
		int maxDifficulty = TowerModel.Instance.GetMaxDifficulty();
		string newTowerDifficultTitle = TowerClimbConfig.Instance.GetNewTowerDifficultTitle(maxDifficulty);
		return new PeriodicityChallengeTypeData
		{
			LeftTime = ((num > 0.0) ? ((float)num) : 0f),
			CurrentNum = difficultyMaxStars,
			TotalNum = difficultyAllStars,
			IsFinish = (difficultyRewardProgress == 1f),
			RedPoint = AdventureGuideModel.Instance.GetPeriodicityRedDot(EPeriodicityChallengeType.TowerVariation, TowerModel.Instance.CurrentSeason),
			SubText = newTowerDifficultTitle
		};
	}

	// Token: 0x060079C5 RID: 31173 RVA: 0x0025B914 File Offset: 0x00259B14
	private IPeriodicityChallengeTypeData GetShipTowerData()
	{
		ActivityShipTowerController instance = ActivityShipTowerController.Instance;
		ActivityShipTowerData activityShipTowerData = (instance != null) ? instance.Data : null;
		if (activityShipTowerData == null || !activityShipTowerData.IsUnLock())
		{
			return null;
		}
		ShipTowerModel instance2 = ShipTowerModel.Instance;
		ValueTuple<int, int> endlessRewardProgressNumData = instance2.GetEndlessRewardProgressNumData();
		int item = endlessRewardProgressNumData.Item1;
		int item2 = endlessRewardProgressNumData.Item2;
		return new PeriodicityChallengeTypeData
		{
			LeftTime = (float)instance2.GetRemainTime(),
			CurrentNum = item,
			TotalNum = item2,
			IsFinish = (item == item2 && item != 0),
			RedPoint = AdventureGuideModel.Instance.GetPeriodicityRedDot(EPeriodicityChallengeType.ShipTowerPeriodicity, ShipTowerModel.Instance.CurSeason),
			SubText = instance2.GetCurrentStageSeasonName2()
		};
	}

	// Token: 0x060079C6 RID: 31174 RVA: 0x0025B9B4 File Offset: 0x00259BB4
	private IPeriodicityChallengeTypeData GetWeeklyRougeData()
	{
		WeeklyRogueData activityDataNew = WeeklyRogueModel.Instance.ActivityDataNew;
		if (activityDataNew == null || !activityDataNew.IsUnLock())
		{
			return null;
		}
		int score = activityDataNew.Score;
		RogueWeeklyCycle? cycleConfig = activityDataNew.GetCycleConfig();
		int totalNum = (cycleConfig != null) ? cycleConfig.GetValueOrDefault().MaxScore : 0;
		WeeklyRogueModel instance = WeeklyRogueModel.Instance;
		WeeklyRogueData weeklyRogueData = (instance != null) ? instance.ActivityData : null;
		string text;
		if (weeklyRogueData == null)
		{
			text = null;
		}
		else
		{
			cycleConfig = weeklyRogueData.GetCycleConfig();
			text = ((cycleConfig != null) ? cycleConfig.GetValueOrDefault().CycleName : null);
		}
		string key = text ?? "";
		return new PeriodicityChallengeTypeData
		{
			LeftTime = (float)activityDataNew.GetCycleRemainTime(),
			CurrentNum = score,
			TotalNum = totalNum,
			IsFinish = activityDataNew.IsScoreRewardAllReceive(),
			RedPoint = AdventureGuideModel.Instance.GetPeriodicityRedDot(EPeriodicityChallengeType.WeeklyRogue, WeeklyRogueModel.Instance.CycleId),
			SubText = (TextConfig.Instance.GetMultiTextByKey(key) ?? "")
		};
	}

	// Token: 0x060079C7 RID: 31175 RVA: 0x0025BAAC File Offset: 0x00259CAC
	private IPeriodicityChallengeTypeData GetWheelTowerData()
	{
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		if (activityData == null || !activityData.IsUnLock() || !activityData.IsInCycle())
		{
			return null;
		}
		string key = activityData.IsLevelUnlocked(true) ? "WheelTowerModeTitle_Endless" : "WheelTowerModeTitle_Normal";
		return new PeriodicityChallengeTypeData
		{
			LeftTime = (float)activityData.GetCycleRemainTime(),
			CurrentNum = 0,
			TotalNum = 0,
			IsFinish = activityData.GetExDataFinishShowStateExternal(),
			RedPoint = activityData.CheckFirstOpenPage(),
			SubText = (TextConfig.Instance.GetMultiTextByKey(key) ?? "")
		};
	}

	// Token: 0x060079C8 RID: 31176 RVA: 0x0025BB44 File Offset: 0x00259D44
	public void RefreshDoubleIcon()
	{
		object adventureUpActivity = ActivityDoubleRewardController.Instance.GetAdventureUpActivity(this.TypeId);
		bool flag = ActivityRegressModel.Instance.IsHasDoubleDrop(this.TypeId);
		bool uiactive = adventureUpActivity != null || flag;
		base.GetItem(1).SetUIActive(uiactive);
	}

	// Token: 0x060079C9 RID: 31177 RVA: 0x0025BB85 File Offset: 0x00259D85
	private void OnToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleFunc((int)this.TypeId, this.Toggle);
		}
	}

	// Token: 0x060079CA RID: 31178 RVA: 0x0025BBA2 File Offset: 0x00259DA2
	public override void OnSelected(bool bFireEvent)
	{
		if (bFireEvent)
		{
			this.SetSelectToggle(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x060079CB RID: 31179 RVA: 0x0025BBAE File Offset: 0x00259DAE
	public void SetSelectToggle(EToggleState state = EToggleState.ETT_Checked)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, false, true, false);
		this.ToggleFunc((int)this.TypeId, this.Toggle);
	}

	// Token: 0x060079CC RID: 31180 RVA: 0x0025BBD7 File Offset: 0x00259DD7
	public void OnlySetSelectToggle(EToggleState state = EToggleState.ETT_Checked)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, false, true, false);
	}

	// Token: 0x060079CD RID: 31181 RVA: 0x0025BBE9 File Offset: 0x00259DE9
	public UUIExtendToggle GetSelfToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x060079CE RID: 31182 RVA: 0x0025BBF4 File Offset: 0x00259DF4
	public UUIItem GetButtonItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.RootUIComp.Get();
	}

	// Token: 0x060079CF RID: 31183 RVA: 0x0025BC1B File Offset: 0x00259E1B
	public bool IsTimeOutType()
	{
		return this.TypeId == EDungeonType.Tower || this.TypeId == EDungeonType.ShipTower || this.TypeId == EDungeonType.WeeklyRogue || this.TypeId == EDungeonType.WheelTower;
	}

	// Token: 0x04004B94 RID: 19348
	private EDungeonType TypeId = EDungeonType.Mat;

	// Token: 0x04004B95 RID: 19349
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> ToggleFunc;

	// Token: 0x04004B96 RID: 19350
	private Func<int, bool> OnCanToggleClicked;

	// Token: 0x04004B97 RID: 19351
	private UUIExtendToggle Toggle;

	// Token: 0x02006E0E RID: 28174
	[NullableContext(0)]
	private enum ENodeDefine
	{
		// Token: 0x040240E4 RID: 147684
		Toggle,
		// Token: 0x040240E5 RID: 147685
		DoubleTip,
		// Token: 0x040240E6 RID: 147686
		RedDotItem,
		// Token: 0x040240E7 RID: 147687
		Icon,
		// Token: 0x040240E8 RID: 147688
		TypeText,
		// Token: 0x040240E9 RID: 147689
		SubItemA,
		// Token: 0x040240EA RID: 147690
		DoingItem,
		// Token: 0x040240EB RID: 147691
		FinishItem,
		// Token: 0x040240EC RID: 147692
		SubText,
		// Token: 0x040240ED RID: 147693
		SubItemB,
		// Token: 0x040240EE RID: 147694
		SubItemBText,
		// Token: 0x040240EF RID: 147695
		SubItemBIconItem,
		// Token: 0x040240F0 RID: 147696
		TimeOutItem,
		// Token: 0x040240F1 RID: 147697
		SprIconR
	}
}
