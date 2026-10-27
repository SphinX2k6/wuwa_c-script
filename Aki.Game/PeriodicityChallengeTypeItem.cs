using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020016B7 RID: 5815
[NullableContext(2)]
[Nullable(0)]
public class PeriodicityChallengeTypeItem : GridProxyAbstract<EDungeonType>
{
	// Token: 0x0600A5DD RID: 42461 RVA: 0x00250F80 File Offset: 0x0024F180
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

	// Token: 0x0600A5DE RID: 42462 RVA: 0x002511B8 File Offset: 0x0024F3B8
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

	// Token: 0x0600A5DF RID: 42463 RVA: 0x0025122C File Offset: 0x0024F42C
	[NullableContext(1)]
	public void BindOnToggleFunc(Action<int, UUIExtendToggle> toggleFunc)
	{
		this.ToggleFunc = delegate(int curId, UUIExtendToggle toggle)
		{
			toggleFunc(curId, toggle);
		};
	}

	// Token: 0x0600A5E0 RID: 42464 RVA: 0x00251258 File Offset: 0x0024F458
	[NullableContext(1)]
	public void BindCanToggleExecuteChange(Func<int, bool> toggle)
	{
		this.OnCanToggleClicked = toggle;
	}

	// Token: 0x0600A5E1 RID: 42465 RVA: 0x00251261 File Offset: 0x0024F461
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.OnCanToggleClicked((int)this.TypeId);
	}

	// Token: 0x0600A5E2 RID: 42466 RVA: 0x00251280 File Offset: 0x0024F480
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

	// Token: 0x0600A5E3 RID: 42467 RVA: 0x00251328 File Offset: 0x0024F528
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

	// Token: 0x0600A5E4 RID: 42468 RVA: 0x00251424 File Offset: 0x0024F624
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

	// Token: 0x0600A5E5 RID: 42469 RVA: 0x00251504 File Offset: 0x0024F704
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

	// Token: 0x0600A5E6 RID: 42470 RVA: 0x002515A4 File Offset: 0x0024F7A4
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

	// Token: 0x0600A5E7 RID: 42471 RVA: 0x0025169C File Offset: 0x0024F89C
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

	// Token: 0x0600A5E8 RID: 42472 RVA: 0x00251734 File Offset: 0x0024F934
	public void RefreshDoubleIcon()
	{
		object adventureUpActivity = ActivityDoubleRewardController.Instance.GetAdventureUpActivity(this.TypeId);
		bool flag = ActivityRegressModel.Instance.IsHasDoubleDrop(this.TypeId);
		bool uiactive = adventureUpActivity != null || flag;
		base.GetItem(1).SetUIActive(uiactive);
	}

	// Token: 0x0600A5E9 RID: 42473 RVA: 0x00251775 File Offset: 0x0024F975
	private void OnToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleFunc((int)this.TypeId, this.Toggle);
		}
	}

	// Token: 0x0600A5EA RID: 42474 RVA: 0x00251792 File Offset: 0x0024F992
	public override void OnSelected(bool bFireEvent)
	{
		if (bFireEvent)
		{
			this.SetSelectToggle(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x0600A5EB RID: 42475 RVA: 0x0025179E File Offset: 0x0024F99E
	public void SetSelectToggle(EToggleState state = EToggleState.ETT_Checked)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, false, true, false);
		this.ToggleFunc((int)this.TypeId, this.Toggle);
	}

	// Token: 0x0600A5EC RID: 42476 RVA: 0x002517C7 File Offset: 0x0024F9C7
	public void OnlySetSelectToggle(EToggleState state = EToggleState.ETT_Checked)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, false, true, false);
	}

	// Token: 0x0600A5ED RID: 42477 RVA: 0x002517D9 File Offset: 0x0024F9D9
	public UUIExtendToggle GetSelfToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600A5EE RID: 42478 RVA: 0x002517E4 File Offset: 0x0024F9E4
	public UUIItem GetButtonItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.RootUIComp.Get();
	}

	// Token: 0x0600A5EF RID: 42479 RVA: 0x0025180B File Offset: 0x0024FA0B
	public bool IsTimeOutType()
	{
		return this.TypeId == EDungeonType.Tower || this.TypeId == EDungeonType.ShipTower || this.TypeId == EDungeonType.WeeklyRogue || this.TypeId == EDungeonType.WheelTower;
	}

	// Token: 0x04004AED RID: 19181
	private EDungeonType TypeId = EDungeonType.Mat;

	// Token: 0x04004AEE RID: 19182
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> ToggleFunc;

	// Token: 0x04004AEF RID: 19183
	private Func<int, bool> OnCanToggleClicked;

	// Token: 0x04004AF0 RID: 19184
	private UUIExtendToggle Toggle;

	// Token: 0x02007C89 RID: 31881
	[NullableContext(0)]
	private enum ENodeDefine
	{
		// Token: 0x04028DBB RID: 167355
		Toggle,
		// Token: 0x04028DBC RID: 167356
		DoubleTip,
		// Token: 0x04028DBD RID: 167357
		RedDotItem,
		// Token: 0x04028DBE RID: 167358
		Icon,
		// Token: 0x04028DBF RID: 167359
		TypeText,
		// Token: 0x04028DC0 RID: 167360
		SubItemA,
		// Token: 0x04028DC1 RID: 167361
		DoingItem,
		// Token: 0x04028DC2 RID: 167362
		FinishItem,
		// Token: 0x04028DC3 RID: 167363
		SubText,
		// Token: 0x04028DC4 RID: 167364
		SubItemB,
		// Token: 0x04028DC5 RID: 167365
		SubItemBText,
		// Token: 0x04028DC6 RID: 167366
		SubItemBIconItem,
		// Token: 0x04028DC7 RID: 167367
		TimeOutItem,
		// Token: 0x04028DC8 RID: 167368
		SprIconR
	}
}
