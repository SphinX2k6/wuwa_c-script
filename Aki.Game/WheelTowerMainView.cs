using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
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

// Token: 0x0200161B RID: 5659
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerMainView : UiTickViewBase
{
	// Token: 0x06009F2B RID: 40747 RVA: 0x0022D95C File Offset: 0x0022BB5C
	[NullableContext(1)]
	public WheelTowerMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009F2C RID: 40748 RVA: 0x0022D968 File Offset: 0x0022BB68
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

	// Token: 0x06009F2D RID: 40749 RVA: 0x0022DC0C File Offset: 0x0022BE0C
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009F2E RID: 40750 RVA: 0x0022DC4F File Offset: 0x0022BE4F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x06009F2F RID: 40751 RVA: 0x0022DC6D File Offset: 0x0022BE6D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x06009F30 RID: 40752 RVA: 0x0022DC8C File Offset: 0x0022BE8C
	protected override void OnStart()
	{
		UiSequencePlayer bgSequencePlayer = this.BgSequencePlayer;
		if (bgSequencePlayer == null)
		{
			return;
		}
		bgSequencePlayer.PlayOrReplaySequenceByName("SpineStart", false, null);
	}

	// Token: 0x06009F31 RID: 40753 RVA: 0x0022DCB8 File Offset: 0x0022BEB8
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

	// Token: 0x06009F32 RID: 40754 RVA: 0x0022DE1C File Offset: 0x0022C01C
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

	// Token: 0x06009F33 RID: 40755 RVA: 0x0022DE60 File Offset: 0x0022C060
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

	// Token: 0x06009F34 RID: 40756 RVA: 0x0022DEB4 File Offset: 0x0022C0B4
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

	// Token: 0x06009F35 RID: 40757 RVA: 0x0022DF9D File Offset: 0x0022C19D
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

	// Token: 0x06009F36 RID: 40758 RVA: 0x0022DFBB File Offset: 0x0022C1BB
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

	// Token: 0x06009F37 RID: 40759 RVA: 0x0022DFD9 File Offset: 0x0022C1D9
	private void OnCloseBtnClick()
	{
		if (WheelTowerModel.Instance.CheckInInstanceDungeon())
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06009F38 RID: 40760 RVA: 0x0022DFFC File Offset: 0x0022C1FC
	private void OnBossHandBookBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerBossHandBookView, null, null);
		WheelTowerModel.Instance.ActivityData.RecordOpenBossHandBook();
	}

	// Token: 0x06009F39 RID: 40761 RVA: 0x0022E01E File Offset: 0x0022C21E
	private void OnRoleBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerEnhanceRoleView, null, null);
	}

	// Token: 0x06009F3A RID: 40762 RVA: 0x0022E034 File Offset: 0x0022C234
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

	// Token: 0x06009F3B RID: 40763 RVA: 0x0022E087 File Offset: 0x0022C287
	private void OnSeasonMedalsBtnClick()
	{
		WheelTowerController.Instance.OpenSeasonMedalView(0, false);
	}

	// Token: 0x06009F3C RID: 40764 RVA: 0x0022E095 File Offset: 0x0022C295
	private void OnRedDotRefresh(int activityId)
	{
		if (activityId != WheelTowerModel.Instance.ActivityData.Id)
		{
			return;
		}
		this.RefreshRewardBtn();
		this.RefreshSeasonMedalRedDot();
	}

	// Token: 0x06009F3D RID: 40765 RVA: 0x0022E0B6 File Offset: 0x0022C2B6
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

	// Token: 0x06009F3E RID: 40766 RVA: 0x0022E0E8 File Offset: 0x0022C2E8
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
		bool flag2 = Info.Instance.IsBuildDevelopmentOrDebug && LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.IgnoreWheelTowerSeasonReviewMedalCheck, false);
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

	// Token: 0x040047AF RID: 18351
	private PopupCaptionItem CaptionItem;

	// Token: 0x040047B0 RID: 18352
	private ActivityCircleButtonItem SeasonRewardButton;

	// Token: 0x040047B1 RID: 18353
	private ActivityCircleButtonItem RewardButton;

	// Token: 0x040047B2 RID: 18354
	private ActivityCircleButtonItem BossHandBookButton;

	// Token: 0x040047B3 RID: 18355
	private ActivityCircleButtonItem RoleButton;

	// Token: 0x040047B4 RID: 18356
	private WheelTowerNormalModeBtn NormalModeBtn;

	// Token: 0x040047B5 RID: 18357
	private WheelTowerEndlessModeBtn EndlessModeBtn;

	// Token: 0x040047B6 RID: 18358
	private UiSequencePlayer BgSequencePlayer;
}
