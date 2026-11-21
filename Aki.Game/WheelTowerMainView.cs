using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AD3 RID: 2771
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerMainView : UiTickViewBase
{
	// Token: 0x06007309 RID: 29449 RVA: 0x0023778C File Offset: 0x0023598C
	[NullableContext(1)]
	public WheelTowerMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600730A RID: 29450 RVA: 0x00237798 File Offset: 0x00235998
	protected unsafe override void OnRegisterComponent()
	{
		int num = 16;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnSeasonTipsBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnSeasonMedalsBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600730B RID: 29451 RVA: 0x00237A3C File Offset: 0x00235C3C
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600730C RID: 29452 RVA: 0x00237A7F File Offset: 0x00235C7F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x0600730D RID: 29453 RVA: 0x00237A9D File Offset: 0x00235C9D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x0600730E RID: 29454 RVA: 0x00237ABC File Offset: 0x00235CBC
	protected override void OnStart()
	{
		UiSequencePlayer bgSequencePlayer = this.BgSequencePlayer;
		if (bgSequencePlayer == null)
		{
			return;
		}
		bgSequencePlayer.PlayOrReplaySequenceByName("SpineStart", false, null);
	}

	// Token: 0x0600730F RID: 29455 RVA: 0x00237AE8 File Offset: 0x00235CE8
	protected override void OnBeforeShow()
	{
		WheelTowerModel instance = WheelTowerModel.Instance;
		WheelTowerData activityData = instance.ActivityData;
		this.RefreshRewardBtn();
		NewTowerParam towerConfig = instance.GetTowerConfig();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), towerConfig.CycleName, Array.Empty<object>());
		if (activityData.SeasonId != 0)
		{
			NewTowerSeason? seasonConfig = WheelTowerConfig.Instance.GetSeasonConfig(activityData.SeasonId);
			if (seasonConfig != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), seasonConfig.Value.Name, Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "WheelTower_SeasonReward_EndVersion", new <>z__ReadOnlySingleElementList<object>(seasonConfig.Value.EndVersionId));
				base.SetTextureByPath(seasonConfig.Value.VersionIconMain, base.GetTexture(1), null, null);
				UUIButtonComponent button = base.GetButton(12);
				if (button != null)
				{
					UUIItem rootComponent = button.GetRootComponent();
					if (rootComponent != null)
					{
						rootComponent.SetUIActive(seasonConfig.Value.InfoDisplayId != 0);
					}
				}
			}
		}
		ActivityCircleButtonItem bossHandBookButton = this.BossHandBookButton;
		if (bossHandBookButton != null)
		{
			bossHandBookButton.SetRedDotVisible(activityData.HasBossHandBookRedDot());
		}
		ActivityCircleButtonItem roleButton = this.RoleButton;
		if (roleButton != null)
		{
			roleButton.SetRedDotVisible(false);
		}
		WheelTowerNormalModeBtn normalModeBtn = this.NormalModeBtn;
		if (normalModeBtn != null)
		{
			normalModeBtn.Refresh();
		}
		WheelTowerEndlessModeBtn endlessModeBtn = this.EndlessModeBtn;
		if (endlessModeBtn != null)
		{
			endlessModeBtn.Refresh();
		}
		this.RefreshSeasonMedalRedDot();
	}

	// Token: 0x06007310 RID: 29456 RVA: 0x00237C4C File Offset: 0x00235E4C
	private void RefreshSeasonMedalRedDot()
	{
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		int seasonId = (activityData != null) ? activityData.SeasonId : 0;
		bool uiactive = WheelTowerModel.Instance.HasUnreadSeasonMedalRedDot(seasonId);
		UUIItem item = base.GetItem(14);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x06007311 RID: 29457 RVA: 0x00237C90 File Offset: 0x00235E90
	protected override void OnTick(float delta)
	{
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		string text = ConfigMultiTextLang.GetLocalTextNew("WheelTower_CycleReward_RemainTime", null) ?? "";
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(activityData.EndShowTime, text);
		UUIText text2 = base.GetText(3);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(remainTimeText, true);
	}

	// Token: 0x06007312 RID: 29458 RVA: 0x00237CE4 File Offset: 0x00235EE4
	private void RefreshRewardBtn()
	{
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		int count = activityData.GetReceivedSeasonRewardIds().Count;
		int count2 = activityData.GetSeasonTaskList().Count;
		ActivityCircleButtonItem seasonRewardButton = this.SeasonRewardButton;
		if (seasonRewardButton != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(count2);
			seasonRewardButton.SetSubText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		ActivityCircleButtonItem seasonRewardButton2 = this.SeasonRewardButton;
		if (seasonRewardButton2 != null)
		{
			seasonRewardButton2.SetRedDotVisible(activityData.ShouldShowSeasonRewardRedDot());
		}
		int currentRewardProgress = activityData.GetCurrentRewardProgress(EFilterMode.All);
		int totalRewardProgress = activityData.GetTotalRewardProgress(EFilterMode.All);
		ActivityCircleButtonItem rewardButton = this.RewardButton;
		if (rewardButton != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(currentRewardProgress);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(totalRewardProgress);
			rewardButton.SetSubText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		ActivityCircleButtonItem rewardButton2 = this.RewardButton;
		if (rewardButton2 == null)
		{
			return;
		}
		rewardButton2.SetRedDotVisible(activityData.ShouldShowRewardRedDot());
	}

	// Token: 0x06007313 RID: 29459 RVA: 0x00237DCD File Offset: 0x00235FCD
	private void OnSeasonRewardBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerSeasonRewardView, null, delegate(bool success, int viewId)
		{
			if (success)
			{
				base.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x06007314 RID: 29460 RVA: 0x00237DEB File Offset: 0x00235FEB
	private void OnRewardBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerLimitRewardView, null, delegate(bool success, int viewId)
		{
			if (success)
			{
				base.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x06007315 RID: 29461 RVA: 0x00237E09 File Offset: 0x00236009
	private void OnCloseBtnClick()
	{
		if (WheelTowerModel.Instance.CheckInInstanceDungeon())
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06007316 RID: 29462 RVA: 0x00237E2C File Offset: 0x0023602C
	private void OnBossHandBookBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerBossHandBookView, null, null);
		WheelTowerModel.Instance.ActivityData.RecordOpenBossHandBook();
	}

	// Token: 0x06007317 RID: 29463 RVA: 0x00237E4E File Offset: 0x0023604E
	private void OnRoleBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerEnhanceRoleView, null, null);
	}

	// Token: 0x06007318 RID: 29464 RVA: 0x00237E64 File Offset: 0x00236064
	private void OnSeasonTipsBtnClick()
	{
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		int seasonId = (activityData != null) ? activityData.SeasonId : 0;
		NewTowerSeason? seasonConfig = WheelTowerConfig.Instance.GetSeasonConfig(seasonId);
		if (seasonConfig == null)
		{
			return;
		}
		HelpController.Instance.OpenHelpById(seasonConfig.Value.InfoDisplayId);
	}

	// Token: 0x06007319 RID: 29465 RVA: 0x00237EB7 File Offset: 0x002360B7
	private void OnSeasonMedalsBtnClick()
	{
		WheelTowerController.Instance.OpenSeasonMedalView(0, false);
	}

	// Token: 0x0600731A RID: 29466 RVA: 0x00237EC5 File Offset: 0x002360C5
	private void OnRedDotRefresh(int activityId)
	{
		if (activityId != WheelTowerModel.Instance.ActivityData.Id)
		{
			return;
		}
		this.RefreshRewardBtn();
		this.RefreshSeasonMedalRedDot();
	}

	// Token: 0x0600731B RID: 29467 RVA: 0x00237EE6 File Offset: 0x002360E6
	private void AddHomeBtnExtraCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			WheelTowerMainView.<>c.<<AddHomeBtnExtraCallback>b__26_0>d <<AddHomeBtnExtraCallback>b__26_0>d;
			<<AddHomeBtnExtraCallback>b__26_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__26_0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__26_0>d.<>t__builder.Start<WheelTowerMainView.<>c.<<AddHomeBtnExtraCallback>b__26_0>d>(ref <<AddHomeBtnExtraCallback>b__26_0>d);
			return <<AddHomeBtnExtraCallback>b__26_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x0600731C RID: 29468 RVA: 0x00237F18 File Offset: 0x00236118
	private void TryTriggerSeasonReview()
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		int num = (activityData != null) ? activityData.SeasonId : 0;
		if (num == 0)
		{
			return;
		}
		IReadOnlyList<NewTowerSeason> allSeasonConfigs = WheelTowerConfig.Instance.GetAllSeasonConfigs();
		if (allSeasonConfigs == null)
		{
			return;
		}
		int num2 = 0;
		foreach (NewTowerSeason newTowerSeason in allSeasonConfigs)
		{
			if (newTowerSeason.Id < num && newTowerSeason.Id > num2)
			{
				num2 = newTowerSeason.Id;
			}
		}
		if (num2 == 0)
		{
			return;
		}
		bool flag = WheelTowerModel.Instance.GetSeasonMedalGroupList(num2, EWheelTowerMedalType.Season).Count > 0;
		bool flag2 = false;
		if (!flag && !flag2)
		{
			return;
		}
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.WheelTowerSeasonReview) as ServerStorageMap;
		if (serverStorageMap == null)
		{
			return;
		}
		int? num3 = serverStorageMap.Get(0);
		int num4 = num2;
		if (num3.GetValueOrDefault() == num4 & num3 != null)
		{
			return;
		}
		WheelTowerSeasonReviewViewData param = new WheelTowerSeasonReviewViewData
		{
			SeasonId = num2
		};
		UiManager.Instance.OpenView(EUiViewName.WheelTowerSeasonReviewView, param, null);
		serverStorageMap.Set(0, num2);
		WheelTowerModel.Instance.CleanOldSeasonMedalsStorage(num);
	}

	// Token: 0x04004855 RID: 18517
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004856 RID: 18518
	private ActivityCircleButtonItem SeasonRewardButton;

	// Token: 0x04004857 RID: 18519
	private ActivityCircleButtonItem RewardButton;

	// Token: 0x04004858 RID: 18520
	private ActivityCircleButtonItem BossHandBookButton;

	// Token: 0x04004859 RID: 18521
	private ActivityCircleButtonItem RoleButton;

	// Token: 0x0400485A RID: 18522
	private WheelTowerNormalModeBtn NormalModeBtn;

	// Token: 0x0400485B RID: 18523
	private WheelTowerEndlessModeBtn EndlessModeBtn;

	// Token: 0x0400485C RID: 18524
	private UiSequencePlayer BgSequencePlayer;
}
