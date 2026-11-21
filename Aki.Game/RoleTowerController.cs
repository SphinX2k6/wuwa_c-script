using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02001C89 RID: 7305
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class RoleTowerController : UiControllerBase
{
	// Token: 0x06012227 RID: 74279 RVA: 0x00557440 File Offset: 0x00555640
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleTowerStepUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleStepUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerTimerDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleTimerDataUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerTimerDurationUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleTimerDurationUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerChallengeSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleChallengeSettleNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerRewardTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleRewardTaskUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerScoreTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleScoreTaskUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerScoreUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleScoreUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerChallengeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleChallengeUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerTokenUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleTokenUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerFloorSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleFloorSettleNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerUnlockTokenUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleUnlockTokenUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerDieNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleDieNotify));
		Net.Instance.Register(ENotifyMessageId.RoleTowerItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleItemUpdateNotify));
	}

	// Token: 0x06012228 RID: 74280 RVA: 0x005575BC File Offset: 0x005557BC
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerStepUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerTimerDataUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerTimerDurationUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerChallengeSettleNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerRewardTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerScoreTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerScoreUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerChallengeUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerTokenUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerFloorSettleNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerUnlockTokenUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerDieNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleTowerItemUpdateNotify);
	}

	// Token: 0x06012229 RID: 74281 RVA: 0x0055769C File Offset: 0x0055589C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Add(EEventName.OnSetGameModeDataDone, new Action(this.OnSetGameModeDataDone));
		EventSystem.Instance.Add(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnBattleAllRoleDataChanged));
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x0601222A RID: 74282 RVA: 0x00557738 File Offset: 0x00555938
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.OnSetGameModeDataDone, new Action(this.OnSetGameModeDataDone));
		EventSystem.Instance.Remove(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnBattleAllRoleDataChanged));
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x0601222B RID: 74283 RVA: 0x005577D1 File Offset: 0x005559D1
	private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		RoleTowerModel.Instance.RemountTokenButtonAsync().Forget();
	}

	// Token: 0x0601222C RID: 74284 RVA: 0x005577E2 File Offset: 0x005559E2
	private void OnRoleChangeEnd()
	{
		RoleTowerModel.Instance.FixMainRoleInSlots();
	}

	// Token: 0x0601222D RID: 74285 RVA: 0x005577EE File Offset: 0x005559EE
	private void OnBattleAllRoleDataChanged()
	{
		RoleTowerModel.Instance.TrySwitchToMainRoleOnRetry();
	}

	// Token: 0x0601222E RID: 74286 RVA: 0x005577FA File Offset: 0x005559FA
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.LevelUpView, new Func<EUiViewName, object, bool>(this.CheckCanOpenLevelUpView), "RoleTowerController.CheckCanOpenLevelUpView");
	}

	// Token: 0x0601222F RID: 74287 RVA: 0x0055781C File Offset: 0x00555A1C
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.LevelUpView, new Func<EUiViewName, object, bool>(this.CheckCanOpenLevelUpView));
	}

	// Token: 0x06012230 RID: 74288 RVA: 0x00557839 File Offset: 0x00555A39
	[NullableContext(1)]
	private bool CheckCanOpenLevelUpView(EUiViewName viewName, object param)
	{
		return !RoleTowerModel.Instance.IsInRoleTowerDungeon();
	}

	// Token: 0x06012231 RID: 74289 RVA: 0x00557848 File Offset: 0x00555A48
	private void OnSetGameModeDataDone()
	{
		InstanceDungeon? instanceDungeon;
		if (GameModeModel.Instance.InstanceDungeon != null && instanceDungeon.GetValueOrDefault().InstSubType == 67)
		{
			this.LoadDataTables();
		}
	}

	// Token: 0x06012232 RID: 74290 RVA: 0x00557888 File Offset: 0x00555A88
	public unsafe void LoadDataTables()
	{
		if (this.IsDataLoaded)
		{
			return;
		}
		this.IsDataLoaded = true;
		this.DataTableLoadHandles.Clear();
		this.PendingDataTableLoadCount = RoleTowerModel.DataTableConfigs.Count;
		if (this.PendingDataTableLoadCount <= 0)
		{
			this.RegisterGameplayCommonFightDataTables();
			return;
		}
		foreach (IRoleTowerDataTableConfig roleTowerDataTableConfig in RoleTowerModel.DataTableConfigs)
		{
			IRoleTowerDataTableConfig configCopy = roleTowerDataTableConfig;
			int item = ResourceSystem.Instance.LoadAsync<UDataTable>(roleTowerDataTableConfig.Path, delegate([Nullable(2)] UDataTable asset, string _)
			{
				if (!this.IsDataLoaded)
				{
					return;
				}
				if (asset == null || !asset.IsValid())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.LXH;
					string message = "[RoleTower] 3.8爬塔配置, 加载 Common 战斗表失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Path", configCopy.Path);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PropertyName", configCopy.PropertyName);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				this.SetDataTable(configCopy.PropertyName, asset);
				RoleTowerController <>4__this = this;
				int num = this.PendingDataTableLoadCount - 1;
				<>4__this.PendingDataTableLoadCount = num;
				if (num <= 0)
				{
					this.RegisterGameplayCommonFightDataTables();
				}
			}, 100, "js_undefined");
			this.DataTableLoadHandles.Add(item);
		}
	}

	// Token: 0x06012233 RID: 74291 RVA: 0x0055794C File Offset: 0x00555B4C
	private void UnloadDataTables()
	{
		if (!this.IsDataLoaded)
		{
			return;
		}
		foreach (int num in this.DataTableLoadHandles)
		{
			if (num != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(num);
			}
		}
		this.DataTableLoadHandles.Clear();
		this.PendingDataTableLoadCount = 0;
		GameplayCommonFightDataTables.SetGameplayCommonFightDataTables(null);
		foreach (IRoleTowerDataTableConfig roleTowerDataTableConfig in RoleTowerModel.DataTableConfigs)
		{
			this.SetDataTable(roleTowerDataTableConfig.PropertyName, null);
		}
		this.IsDataLoaded = false;
	}

	// Token: 0x06012234 RID: 74292 RVA: 0x00557A10 File Offset: 0x00555C10
	protected override bool OnLeaveLevel()
	{
		this.UnloadDataTables();
		return true;
	}

	// Token: 0x06012235 RID: 74293 RVA: 0x00557A19 File Offset: 0x00555C19
	protected override bool OnClear()
	{
		this.UnloadDataTables();
		RoleTowerModel.Instance.ResetStageRetryState();
		return true;
	}

	// Token: 0x06012236 RID: 74294 RVA: 0x00557A2C File Offset: 0x00555C2C
	private void RegisterGameplayCommonFightDataTables()
	{
		RoleTowerModel instance = RoleTowerModel.Instance;
		GameplayCommonFightDataTables.SetGameplayCommonFightDataTables(new GameplayCommonFightDataTables
		{
			RoleSkillDataTable = instance.CommonSkillInfoDataTable,
			BulletDataTable = instance.CommonBulletDataTable,
			HitEffectDataTable = instance.CommonHitEffectDataTable
		});
	}

	// Token: 0x06012237 RID: 74295 RVA: 0x00557A70 File Offset: 0x00555C70
	[NullableContext(1)]
	private void SetDataTable(string propertyName, [Nullable(2)] UDataTable dataTable)
	{
		RoleTowerModel instance = RoleTowerModel.Instance;
		if (propertyName == "CommonSkillInfoDataTable")
		{
			instance.CommonSkillInfoDataTable = dataTable;
			return;
		}
		if (propertyName == "CommonBulletDataTable")
		{
			instance.CommonBulletDataTable = dataTable;
			return;
		}
		if (!(propertyName == "CommonHitEffectDataTable"))
		{
			return;
		}
		instance.CommonHitEffectDataTable = dataTable;
	}

	// Token: 0x06012238 RID: 74296 RVA: 0x00557AC4 File Offset: 0x00555CC4
	private void OnWorldDoneAndCloseLoading()
	{
		if (RoleTowerModel.Instance.IsInRoleTowerDungeon())
		{
			RoleTowerModel.Instance.OpenExitButtonView();
			RoleTowerModel.Instance.OpenTokenButton();
			RoleTowerModel.Instance.SetInBattle(true);
			RoleTowerModel.Instance.TryShowLevelGuide();
			return;
		}
		RoleTowerModel.Instance.CloseExitButtonView();
		RoleTowerModel.Instance.CloseTokenButton();
		if (RoleTowerModel.Instance.ConsumeOpenActivityMainAfterLeave())
		{
			SplashScreenController.Instance.PushSplashScreenTask(new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
			{
				RoleTowerModel.Instance.OpenActivityMainView(false, null, null);
			}), false);
		}
	}

	// Token: 0x06012239 RID: 74297 RVA: 0x00557B58 File Offset: 0x00555D58
	[NullableContext(1)]
	public void RoleTowerFormationInputHandler(string actionName)
	{
		if (actionName == "切换角色4")
		{
			RoleTowerModel.Instance.TriggerTokenButton();
			return;
		}
		CooperationController.Instance.FormationInputHandler(actionName);
	}

	// Token: 0x0601223A RID: 74298 RVA: 0x00557B80 File Offset: 0x00555D80
	private void HandleStepUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerStepUpdateNotify roleTowerStepUpdateNotify = msg as RoleTowerStepUpdateNotify;
		if (roleTowerStepUpdateNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnStepUpdateNotify(roleTowerStepUpdateNotify);
	}

	// Token: 0x0601223B RID: 74299 RVA: 0x00557BA4 File Offset: 0x00555DA4
	private void HandleTimerDataUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerTimerDataUpdateNotify roleTowerTimerDataUpdateNotify = msg as RoleTowerTimerDataUpdateNotify;
		if (roleTowerTimerDataUpdateNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnTimerDataUpdateNotify(roleTowerTimerDataUpdateNotify);
	}

	// Token: 0x0601223C RID: 74300 RVA: 0x00557BC8 File Offset: 0x00555DC8
	private void HandleTimerDurationUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerTimerDurationUpdateNotify roleTowerTimerDurationUpdateNotify = msg as RoleTowerTimerDurationUpdateNotify;
		if (roleTowerTimerDurationUpdateNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnTimerDurationUpdateNotify(roleTowerTimerDurationUpdateNotify);
	}

	// Token: 0x0601223D RID: 74301 RVA: 0x00557BEC File Offset: 0x00555DEC
	private void HandleChallengeSettleNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerChallengeSettleNotify roleTowerChallengeSettleNotify = msg as RoleTowerChallengeSettleNotify;
		if (roleTowerChallengeSettleNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnChallengeSettleNotify(roleTowerChallengeSettleNotify);
	}

	// Token: 0x0601223E RID: 74302 RVA: 0x00557C10 File Offset: 0x00555E10
	private void HandleScoreUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerScoreUpdateNotify roleTowerScoreUpdateNotify = msg as RoleTowerScoreUpdateNotify;
		if (roleTowerScoreUpdateNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnScoreUpdateNotify(roleTowerScoreUpdateNotify);
	}

	// Token: 0x0601223F RID: 74303 RVA: 0x00557C34 File Offset: 0x00555E34
	private void HandleRewardTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerRewardTaskUpdateNotify roleTowerRewardTaskUpdateNotify = msg as RoleTowerRewardTaskUpdateNotify;
		if (roleTowerRewardTaskUpdateNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnRewardTaskUpdateNotify(roleTowerRewardTaskUpdateNotify);
	}

	// Token: 0x06012240 RID: 74304 RVA: 0x00557C58 File Offset: 0x00555E58
	private void HandleScoreTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerScoreTaskUpdateNotify roleTowerScoreTaskUpdateNotify = msg as RoleTowerScoreTaskUpdateNotify;
		if (roleTowerScoreTaskUpdateNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnScoreTaskUpdateNotify(roleTowerScoreTaskUpdateNotify);
	}

	// Token: 0x06012241 RID: 74305 RVA: 0x00557C7C File Offset: 0x00555E7C
	private void HandleChallengeUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerChallengeUpdateNotify roleTowerChallengeUpdateNotify = msg as RoleTowerChallengeUpdateNotify;
		if (roleTowerChallengeUpdateNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnChallengeUpdateNotify(roleTowerChallengeUpdateNotify);
	}

	// Token: 0x06012242 RID: 74306 RVA: 0x00557CA0 File Offset: 0x00555EA0
	private void HandleTokenUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerTokenUpdateNotify roleTowerTokenUpdateNotify = msg as RoleTowerTokenUpdateNotify;
		if (roleTowerTokenUpdateNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnTokenUpdateNotify(roleTowerTokenUpdateNotify);
	}

	// Token: 0x06012243 RID: 74307 RVA: 0x00557CC4 File Offset: 0x00555EC4
	private void HandleFloorSettleNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerFloorSettleNotify roleTowerFloorSettleNotify = msg as RoleTowerFloorSettleNotify;
		if (roleTowerFloorSettleNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnFloorSettleNotify(roleTowerFloorSettleNotify);
	}

	// Token: 0x06012244 RID: 74308 RVA: 0x00557CE8 File Offset: 0x00555EE8
	private void HandleUnlockTokenUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerUnlockTokenUpdateNotify roleTowerUnlockTokenUpdateNotify = msg as RoleTowerUnlockTokenUpdateNotify;
		if (roleTowerUnlockTokenUpdateNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnUnlockTokenUpdateNotify(roleTowerUnlockTokenUpdateNotify);
	}

	// Token: 0x06012245 RID: 74309 RVA: 0x00557D0C File Offset: 0x00555F0C
	private void HandleDieNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerDieNotify roleTowerDieNotify = msg as RoleTowerDieNotify;
		if (roleTowerDieNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnDieNotify(roleTowerDieNotify);
	}

	// Token: 0x06012246 RID: 74310 RVA: 0x00557D30 File Offset: 0x00555F30
	private void HandleItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleTowerItemUpdateNotify roleTowerItemUpdateNotify = msg as RoleTowerItemUpdateNotify;
		if (roleTowerItemUpdateNotify == null)
		{
			return;
		}
		RoleTowerModel.Instance.OnItemUpdateNotify(roleTowerItemUpdateNotify);
	}

	// Token: 0x06012247 RID: 74311 RVA: 0x00557D54 File Offset: 0x00555F54
	public UniTask SaveDeleteRequest(int challengeId)
	{
		RoleTowerController.<SaveDeleteRequest>d__35 <SaveDeleteRequest>d__;
		<SaveDeleteRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SaveDeleteRequest>d__.challengeId = challengeId;
		<SaveDeleteRequest>d__.<>1__state = -1;
		<SaveDeleteRequest>d__.<>t__builder.Start<RoleTowerController.<SaveDeleteRequest>d__35>(ref <SaveDeleteRequest>d__);
		return <SaveDeleteRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06012248 RID: 74312 RVA: 0x00557D98 File Offset: 0x00555F98
	[NullableContext(0)]
	public UniTask<bool> StepAdvanceRequest([Nullable(1)] RoleTowerStepAdvanceRequest request)
	{
		RoleTowerController.<StepAdvanceRequest>d__36 <StepAdvanceRequest>d__;
		<StepAdvanceRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<StepAdvanceRequest>d__.request = request;
		<StepAdvanceRequest>d__.<>1__state = -1;
		<StepAdvanceRequest>d__.<>t__builder.Start<RoleTowerController.<StepAdvanceRequest>d__36>(ref <StepAdvanceRequest>d__);
		return <StepAdvanceRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06012249 RID: 74313 RVA: 0x00557DDC File Offset: 0x00555FDC
	[NullableContext(0)]
	public UniTask<bool> StepAdvancePrepare()
	{
		RoleTowerController.<StepAdvancePrepare>d__37 <StepAdvancePrepare>d__;
		<StepAdvancePrepare>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<StepAdvancePrepare>d__.<>4__this = this;
		<StepAdvancePrepare>d__.<>1__state = -1;
		<StepAdvancePrepare>d__.<>t__builder.Start<RoleTowerController.<StepAdvancePrepare>d__37>(ref <StepAdvancePrepare>d__);
		return <StepAdvancePrepare>d__.<>t__builder.Task;
	}

	// Token: 0x0601224A RID: 74314 RVA: 0x00557E20 File Offset: 0x00556020
	[NullableContext(0)]
	public UniTask<bool> StepAdvanceSettle()
	{
		RoleTowerStepAdvanceRequest roleTowerStepAdvanceRequest = RoleTowerStepAdvanceRequest.Create();
		roleTowerStepAdvanceRequest.SettleStepPbData = RoleTowerSettleStepPbData.Create();
		return this.StepAdvanceRequest(roleTowerStepAdvanceRequest);
	}

	// Token: 0x0601224B RID: 74315 RVA: 0x00557E48 File Offset: 0x00556048
	[NullableContext(0)]
	public UniTask<bool> StepAdvanceTeamUpgrade()
	{
		RoleTowerStepAdvanceRequest roleTowerStepAdvanceRequest = RoleTowerStepAdvanceRequest.Create();
		roleTowerStepAdvanceRequest.TeamUpgradeStepPbData = RoleTowerTeamUpgradeStepPbData.Create();
		return this.StepAdvanceRequest(roleTowerStepAdvanceRequest);
	}

	// Token: 0x0601224C RID: 74316 RVA: 0x00557E70 File Offset: 0x00556070
	[NullableContext(0)]
	public UniTask<bool> StepAdvanceLoadSubLevel()
	{
		RoleTowerStepAdvanceRequest roleTowerStepAdvanceRequest = RoleTowerStepAdvanceRequest.Create();
		roleTowerStepAdvanceRequest.LoadSubLevelStepPbData = RoleTowerLoadSubLevelStepPbData.Create();
		return this.StepAdvanceRequest(roleTowerStepAdvanceRequest);
	}

	// Token: 0x0601224D RID: 74317 RVA: 0x00557E98 File Offset: 0x00556098
	public void HandleLoadSubLevel(RoleTowerLoadSubLevelStepPbData loadStep)
	{
		RoleTowerController.<>c__DisplayClass41_0 CS$<>8__locals1 = new RoleTowerController.<>c__DisplayClass41_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.loadStep = loadStep;
		if (CS$<>8__locals1.loadStep == null)
		{
			this.StepAdvanceLoadSubLevel().Forget<bool>();
			return;
		}
		AsyncTask task = new AsyncTask("RoleTowerSubLevelChangeTask", delegate()
		{
			RoleTowerController.<>c__DisplayClass41_0.<<HandleLoadSubLevel>b__0>d <<HandleLoadSubLevel>b__0>d;
			<<HandleLoadSubLevel>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<<HandleLoadSubLevel>b__0>d.<>4__this = CS$<>8__locals1;
			<<HandleLoadSubLevel>b__0>d.<>1__state = -1;
			<<HandleLoadSubLevel>b__0>d.<>t__builder.Start<RoleTowerController.<>c__DisplayClass41_0.<<HandleLoadSubLevel>b__0>d>(ref <<HandleLoadSubLevel>b__0>d);
			return <<HandleLoadSubLevel>b__0>d.<>t__builder.Task;
		}, null, null, null);
		TaskSystem.Instance.AddTask(task);
		TaskSystem.Instance.Run();
	}

	// Token: 0x0601224E RID: 74318 RVA: 0x00557F00 File Offset: 0x00556100
	[NullableContext(1)]
	[return: TupleElementNames(new string[]
	{
		"unloads",
		"newLoads"
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	private ValueTuple<string[], string[]> FilterSameSubLevel(RoleTowerLoadSubLevelStepPbData loadStep)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (string item in loadStep.UnLoadSubLevels)
		{
			if (!loadStep.LoadSubLevels.Contains(item))
			{
				list.Add(item);
			}
		}
		foreach (string item2 in loadStep.LoadSubLevels)
		{
			if (!loadStep.UnLoadSubLevels.Contains(item2))
			{
				list2.Add(item2);
			}
		}
		return new ValueTuple<string[], string[]>(list.ToArray(), list2.ToArray());
	}

	// Token: 0x0601224F RID: 74319 RVA: 0x00557FC8 File Offset: 0x005561C8
	public UniTask StageSettleRequest()
	{
		RoleTowerController.<StageSettleRequest>d__43 <StageSettleRequest>d__;
		<StageSettleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StageSettleRequest>d__.<>1__state = -1;
		<StageSettleRequest>d__.<>t__builder.Start<RoleTowerController.<StageSettleRequest>d__43>(ref <StageSettleRequest>d__);
		return <StageSettleRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06012250 RID: 74320 RVA: 0x00558004 File Offset: 0x00556204
	[NullableContext(0)]
	public UniTask<bool> StageRetryRequest(int challengeId, [Nullable(1)] RoleTowerPrepareSelection selection)
	{
		RoleTowerController.<StageRetryRequest>d__44 <StageRetryRequest>d__;
		<StageRetryRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<StageRetryRequest>d__.challengeId = challengeId;
		<StageRetryRequest>d__.selection = selection;
		<StageRetryRequest>d__.<>1__state = -1;
		<StageRetryRequest>d__.<>t__builder.Start<RoleTowerController.<StageRetryRequest>d__44>(ref <StageRetryRequest>d__);
		return <StageRetryRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06012251 RID: 74321 RVA: 0x00558050 File Offset: 0x00556250
	public UniTask ChallengeSettleRequest(int challengeId)
	{
		RoleTowerController.<ChallengeSettleRequest>d__45 <ChallengeSettleRequest>d__;
		<ChallengeSettleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ChallengeSettleRequest>d__.challengeId = challengeId;
		<ChallengeSettleRequest>d__.<>1__state = -1;
		<ChallengeSettleRequest>d__.<>t__builder.Start<RoleTowerController.<ChallengeSettleRequest>d__45>(ref <ChallengeSettleRequest>d__);
		return <ChallengeSettleRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06012252 RID: 74322 RVA: 0x00558094 File Offset: 0x00556294
	public UniTask RankRequest(int activityId)
	{
		RoleTowerController.<RankRequest>d__46 <RankRequest>d__;
		<RankRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RankRequest>d__.activityId = activityId;
		<RankRequest>d__.<>1__state = -1;
		<RankRequest>d__.<>t__builder.Start<RoleTowerController.<RankRequest>d__46>(ref <RankRequest>d__);
		return <RankRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06012253 RID: 74323 RVA: 0x005580D8 File Offset: 0x005562D8
	public UniTask AttributeQueryRequest(int challengeId, int roleId, bool useInitInstData = false)
	{
		RoleTowerController.<AttributeQueryRequest>d__47 <AttributeQueryRequest>d__;
		<AttributeQueryRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AttributeQueryRequest>d__.challengeId = challengeId;
		<AttributeQueryRequest>d__.roleId = roleId;
		<AttributeQueryRequest>d__.useInitInstData = useInitInstData;
		<AttributeQueryRequest>d__.<>1__state = -1;
		<AttributeQueryRequest>d__.<>t__builder.Start<RoleTowerController.<AttributeQueryRequest>d__47>(ref <AttributeQueryRequest>d__);
		return <AttributeQueryRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06012254 RID: 74324 RVA: 0x0055812C File Offset: 0x0055632C
	[NullableContext(1)]
	public UniTask RankRewardReceiveRequest(int[] challengeIds)
	{
		RoleTowerController.<RankRewardReceiveRequest>d__48 <RankRewardReceiveRequest>d__;
		<RankRewardReceiveRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RankRewardReceiveRequest>d__.challengeIds = challengeIds;
		<RankRewardReceiveRequest>d__.<>1__state = -1;
		<RankRewardReceiveRequest>d__.<>t__builder.Start<RoleTowerController.<RankRewardReceiveRequest>d__48>(ref <RankRewardReceiveRequest>d__);
		return <RankRewardReceiveRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06012255 RID: 74325 RVA: 0x00558170 File Offset: 0x00556370
	[NullableContext(1)]
	public UniTask RewardTaskReceiveRequest(int[] taskIds)
	{
		RoleTowerController.<RewardTaskReceiveRequest>d__49 <RewardTaskReceiveRequest>d__;
		<RewardTaskReceiveRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RewardTaskReceiveRequest>d__.taskIds = taskIds;
		<RewardTaskReceiveRequest>d__.<>1__state = -1;
		<RewardTaskReceiveRequest>d__.<>t__builder.Start<RoleTowerController.<RewardTaskReceiveRequest>d__49>(ref <RewardTaskReceiveRequest>d__);
		return <RewardTaskReceiveRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06012256 RID: 74326 RVA: 0x005581B4 File Offset: 0x005563B4
	[NullableContext(1)]
	public UniTask ScoreRewardReceiveRequest(int[] rewardIds)
	{
		RoleTowerController.<ScoreRewardReceiveRequest>d__50 <ScoreRewardReceiveRequest>d__;
		<ScoreRewardReceiveRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ScoreRewardReceiveRequest>d__.rewardIds = rewardIds;
		<ScoreRewardReceiveRequest>d__.<>1__state = -1;
		<ScoreRewardReceiveRequest>d__.<>t__builder.Start<RoleTowerController.<ScoreRewardReceiveRequest>d__50>(ref <ScoreRewardReceiveRequest>d__);
		return <ScoreRewardReceiveRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06012257 RID: 74327 RVA: 0x005581F8 File Offset: 0x005563F8
	public UniTask ConsumeItemRequest(int itemId)
	{
		RoleTowerController.<ConsumeItemRequest>d__51 <ConsumeItemRequest>d__;
		<ConsumeItemRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ConsumeItemRequest>d__.itemId = itemId;
		<ConsumeItemRequest>d__.<>1__state = -1;
		<ConsumeItemRequest>d__.<>t__builder.Start<RoleTowerController.<ConsumeItemRequest>d__51>(ref <ConsumeItemRequest>d__);
		return <ConsumeItemRequest>d__.<>t__builder.Task;
	}

	// Token: 0x17001B5E RID: 7006
	// (get) Token: 0x06012258 RID: 74328 RVA: 0x0055823B File Offset: 0x0055643B
	[Nullable(1)]
	public static RoleTowerController Instance
	{
		[NullableContext(1)]
		get
		{
			return RoleTowerController._Instance;
		}
	}

	// Token: 0x06012259 RID: 74329 RVA: 0x00558242 File Offset: 0x00556442
	[NullableContext(1)]
	public static RoleTowerController GetOrCreateInstance()
	{
		if (RoleTowerController._Instance == null)
		{
			RoleTowerController.CreateInstance();
		}
		return RoleTowerController._Instance;
	}

	// Token: 0x0601225A RID: 74330 RVA: 0x00558256 File Offset: 0x00556456
	public static bool CreateInstance()
	{
		if (RoleTowerController._Instance != null)
		{
			return true;
		}
		RoleTowerController._Instance = new RoleTowerController();
		return true;
	}

	// Token: 0x0601225B RID: 74331 RVA: 0x0055826C File Offset: 0x0055646C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601225C RID: 74332 RVA: 0x0055826E File Offset: 0x0055646E
	public static void ResetStaticDefaultValue()
	{
		RoleTowerController._Instance = null;
	}

	// Token: 0x0601225D RID: 74333 RVA: 0x00558276 File Offset: 0x00556476
	static RoleTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleTowerController.CreateStaticDefaultValue), new Action(RoleTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x04009E1C RID: 40476
	private bool IsDataLoaded;

	// Token: 0x04009E1D RID: 40477
	private int PendingDataTableLoadCount;

	// Token: 0x04009E1E RID: 40478
	[Nullable(1)]
	private readonly List<int> DataTableLoadHandles = new List<int>();

	// Token: 0x04009E1F RID: 40479
	private static RoleTowerController _Instance;
}
