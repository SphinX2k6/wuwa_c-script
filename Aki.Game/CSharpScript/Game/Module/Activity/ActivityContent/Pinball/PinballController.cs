using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x02005245 RID: 21061
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class PinballController : ActivityControllerBase
	{
		// Token: 0x060346A0 RID: 214688 RVA: 0x00EAB3AA File Offset: 0x00EA95AA
		private bool IsBlockedEnterPinballMainInMulti()
		{
			GameModeModel instance = GameModeModel.Instance;
			if (instance == null || !instance.IsMulti)
			{
				return false;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("PinballMultiTips", Array.Empty<object>());
			return true;
		}

		// Token: 0x060346A1 RID: 214689 RVA: 0x00EAB3D9 File Offset: 0x00EA95D9
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.PinballUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPinballUpdateNotify));
		}

		// Token: 0x060346A2 RID: 214690 RVA: 0x00EAB3F7 File Offset: 0x00EA95F7
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.PinballUpdateNotify);
		}

		// Token: 0x060346A3 RID: 214691 RVA: 0x00EAB409 File Offset: 0x00EA9609
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(this.OnQuestRedDotStateChange));
		}

		// Token: 0x060346A4 RID: 214692 RVA: 0x00EAB427 File Offset: 0x00EA9627
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnQuestRedDotStateChange, new Action<int>(this.OnQuestRedDotStateChange));
		}

		// Token: 0x060346A5 RID: 214693 RVA: 0x00EAB448 File Offset: 0x00EA9648
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			PinballController.<OnOpenSubView>d__5 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.<>4__this = this;
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<PinballController.<OnOpenSubView>d__5>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x060346A6 RID: 214694 RVA: 0x00EAB494 File Offset: 0x00EA9694
		[NullableContext(2)]
		private void OnPinballUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			PinballUpdateNotify pinballUpdateNotify = (PinballUpdateNotify)msg;
			PinballActivityData activityData = PinballModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			ConditionTask conditionTask = pinballUpdateNotify.ConditionTask;
			if (conditionTask != null)
			{
				activityData.UpdateTaskData(conditionTask);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
			}
			PinballLevelData levelData = pinballUpdateNotify.LevelData;
			if (levelData != null)
			{
				activityData.UpdateLevelData(levelData);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
			}
			PinballRoles newRole = pinballUpdateNotify.NewRole;
			RepeatedField<Aki.Protocol.PinballRoleData> repeatedField = (newRole != null) ? newRole.Roles : null;
			if (repeatedField != null && repeatedField.Count > 0)
			{
				foreach (Aki.Protocol.PinballRoleData data in repeatedField)
				{
					activityData.UpdateRoleByServerData(data);
				}
			}
			PinballWeapons newWeapon = pinballUpdateNotify.NewWeapon;
			RepeatedField<PinballWeapon> repeatedField2 = (newWeapon != null) ? newWeapon.PinballWeaponList : null;
			if (repeatedField2 != null && repeatedField2.Count > 0)
			{
				foreach (PinballWeapon data2 in repeatedField2)
				{
					activityData.UpdateWeaponData(data2);
				}
			}
			GroupFormation groupFormation = pinballUpdateNotify.GroupFormation;
			if (groupFormation != null)
			{
				activityData.UpDateLevelFormationData(groupFormation);
			}
			activityData.UpdateRoleWeaponRedDot();
		}

		// Token: 0x060346A7 RID: 214695 RVA: 0x00EAB5E8 File Offset: 0x00EA97E8
		[NullableContext(0)]
		public UniTask<bool> PinballRoleLevelUpRequestAsync(int activityId, int roleId, int addLevel)
		{
			PinballController.<PinballRoleLevelUpRequestAsync>d__7 <PinballRoleLevelUpRequestAsync>d__;
			<PinballRoleLevelUpRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PinballRoleLevelUpRequestAsync>d__.activityId = activityId;
			<PinballRoleLevelUpRequestAsync>d__.roleId = roleId;
			<PinballRoleLevelUpRequestAsync>d__.addLevel = addLevel;
			<PinballRoleLevelUpRequestAsync>d__.<>1__state = -1;
			<PinballRoleLevelUpRequestAsync>d__.<>t__builder.Start<PinballController.<PinballRoleLevelUpRequestAsync>d__7>(ref <PinballRoleLevelUpRequestAsync>d__);
			return <PinballRoleLevelUpRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060346A8 RID: 214696 RVA: 0x00EAB63C File Offset: 0x00EA983C
		[NullableContext(0)]
		public UniTask<bool> PinballWeaponWearRequestAsync(int activityId, int roleId, int weaponIncId)
		{
			PinballController.<PinballWeaponWearRequestAsync>d__8 <PinballWeaponWearRequestAsync>d__;
			<PinballWeaponWearRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PinballWeaponWearRequestAsync>d__.activityId = activityId;
			<PinballWeaponWearRequestAsync>d__.roleId = roleId;
			<PinballWeaponWearRequestAsync>d__.weaponIncId = weaponIncId;
			<PinballWeaponWearRequestAsync>d__.<>1__state = -1;
			<PinballWeaponWearRequestAsync>d__.<>t__builder.Start<PinballController.<PinballWeaponWearRequestAsync>d__8>(ref <PinballWeaponWearRequestAsync>d__);
			return <PinballWeaponWearRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060346A9 RID: 214697 RVA: 0x00EAB68F File Offset: 0x00EA988F
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060346AA RID: 214698 RVA: 0x00EAB691 File Offset: 0x00EA9891
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityCatapultStoryGuide";
		}

		// Token: 0x060346AB RID: 214699 RVA: 0x00EAB698 File Offset: 0x00EA9898
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new PinballActivitySubView();
		}

		// Token: 0x060346AC RID: 214700 RVA: 0x00EAB69F File Offset: 0x00EA989F
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new PinballActivityData();
		}

		// Token: 0x060346AD RID: 214701 RVA: 0x00EAB6A6 File Offset: 0x00EA98A6
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060346AE RID: 214702 RVA: 0x00EAB6AC File Offset: 0x00EA98AC
		[NullableContext(0)]
		public UniTask<bool> OpenLevelViewByType(int levelId, bool isFromInstanceDungeon = false)
		{
			PinballController.<OpenLevelViewByType>d__14 <OpenLevelViewByType>d__;
			<OpenLevelViewByType>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenLevelViewByType>d__.<>4__this = this;
			<OpenLevelViewByType>d__.levelId = levelId;
			<OpenLevelViewByType>d__.isFromInstanceDungeon = isFromInstanceDungeon;
			<OpenLevelViewByType>d__.<>1__state = -1;
			<OpenLevelViewByType>d__.<>t__builder.Start<PinballController.<OpenLevelViewByType>d__14>(ref <OpenLevelViewByType>d__);
			return <OpenLevelViewByType>d__.<>t__builder.Task;
		}

		// Token: 0x060346AF RID: 214703 RVA: 0x00EAB700 File Offset: 0x00EA9900
		[NullableContext(0)]
		public UniTask<bool> OpenLevelView(int levelId, bool isFromInstanceDungeon = false)
		{
			PinballController.<OpenLevelView>d__15 <OpenLevelView>d__;
			<OpenLevelView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenLevelView>d__.<>4__this = this;
			<OpenLevelView>d__.levelId = levelId;
			<OpenLevelView>d__.isFromInstanceDungeon = isFromInstanceDungeon;
			<OpenLevelView>d__.<>1__state = -1;
			<OpenLevelView>d__.<>t__builder.Start<PinballController.<OpenLevelView>d__15>(ref <OpenLevelView>d__);
			return <OpenLevelView>d__.<>t__builder.Task;
		}

		// Token: 0x060346B0 RID: 214704 RVA: 0x00EAB754 File Offset: 0x00EA9954
		[NullableContext(0)]
		public UniTask<bool> OpenTowerLevelView(int levelId, bool isFromInstanceDungeon = false)
		{
			PinballController.<OpenTowerLevelView>d__16 <OpenTowerLevelView>d__;
			<OpenTowerLevelView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenTowerLevelView>d__.<>4__this = this;
			<OpenTowerLevelView>d__.levelId = levelId;
			<OpenTowerLevelView>d__.isFromInstanceDungeon = isFromInstanceDungeon;
			<OpenTowerLevelView>d__.<>1__state = -1;
			<OpenTowerLevelView>d__.<>t__builder.Start<PinballController.<OpenTowerLevelView>d__16>(ref <OpenTowerLevelView>d__);
			return <OpenTowerLevelView>d__.<>t__builder.Task;
		}

		// Token: 0x060346B1 RID: 214705 RVA: 0x00EAB7A8 File Offset: 0x00EA99A8
		[NullableContext(0)]
		public UniTask<bool> OpenDailyLevelView(bool isFromInstanceDungeon = false)
		{
			PinballController.<OpenDailyLevelView>d__17 <OpenDailyLevelView>d__;
			<OpenDailyLevelView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenDailyLevelView>d__.<>4__this = this;
			<OpenDailyLevelView>d__.isFromInstanceDungeon = isFromInstanceDungeon;
			<OpenDailyLevelView>d__.<>1__state = -1;
			<OpenDailyLevelView>d__.<>t__builder.Start<PinballController.<OpenDailyLevelView>d__17>(ref <OpenDailyLevelView>d__);
			return <OpenDailyLevelView>d__.<>t__builder.Task;
		}

		// Token: 0x060346B2 RID: 214706 RVA: 0x00EAB7F4 File Offset: 0x00EA99F4
		[NullableContext(0)]
		public UniTask<bool> OpenMainRootView([Nullable(2)] IPinballMainRootViewOpenParam openParam = null)
		{
			PinballController.<OpenMainRootView>d__18 <OpenMainRootView>d__;
			<OpenMainRootView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenMainRootView>d__.<>4__this = this;
			<OpenMainRootView>d__.openParam = openParam;
			<OpenMainRootView>d__.<>1__state = -1;
			<OpenMainRootView>d__.<>t__builder.Start<PinballController.<OpenMainRootView>d__18>(ref <OpenMainRootView>d__);
			return <OpenMainRootView>d__.<>t__builder.Task;
		}

		// Token: 0x060346B3 RID: 214707 RVA: 0x00EAB840 File Offset: 0x00EA9A40
		[NullableContext(0)]
		public UniTask<bool> OpenMonsterDetailView(int levelId)
		{
			PinballController.<OpenMonsterDetailView>d__19 <OpenMonsterDetailView>d__;
			<OpenMonsterDetailView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenMonsterDetailView>d__.levelId = levelId;
			<OpenMonsterDetailView>d__.<>1__state = -1;
			<OpenMonsterDetailView>d__.<>t__builder.Start<PinballController.<OpenMonsterDetailView>d__19>(ref <OpenMonsterDetailView>d__);
			return <OpenMonsterDetailView>d__.<>t__builder.Task;
		}

		// Token: 0x060346B4 RID: 214708 RVA: 0x00EAB884 File Offset: 0x00EA9A84
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<PinballWeaponDegradeResponse> RequestWeaponDecompose(HashSet<int> selection)
		{
			PinballController.<RequestWeaponDecompose>d__20 <RequestWeaponDecompose>d__;
			<RequestWeaponDecompose>d__.<>t__builder = AsyncUniTaskMethodBuilder<PinballWeaponDegradeResponse>.Create();
			<RequestWeaponDecompose>d__.selection = selection;
			<RequestWeaponDecompose>d__.<>1__state = -1;
			<RequestWeaponDecompose>d__.<>t__builder.Start<PinballController.<RequestWeaponDecompose>d__20>(ref <RequestWeaponDecompose>d__);
			return <RequestWeaponDecompose>d__.<>t__builder.Task;
		}

		// Token: 0x060346B5 RID: 214709 RVA: 0x00EAB8C8 File Offset: 0x00EA9AC8
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<PinballWeaponDegradeResponse> RequestWeaponDecompose(IEnumerable<int> weaponIncIdList)
		{
			PinballController.<RequestWeaponDecompose>d__21 <RequestWeaponDecompose>d__;
			<RequestWeaponDecompose>d__.<>t__builder = AsyncUniTaskMethodBuilder<PinballWeaponDegradeResponse>.Create();
			<RequestWeaponDecompose>d__.<>4__this = this;
			<RequestWeaponDecompose>d__.weaponIncIdList = weaponIncIdList;
			<RequestWeaponDecompose>d__.<>1__state = -1;
			<RequestWeaponDecompose>d__.<>t__builder.Start<PinballController.<RequestWeaponDecompose>d__21>(ref <RequestWeaponDecompose>d__);
			return <RequestWeaponDecompose>d__.<>t__builder.Task;
		}

		// Token: 0x060346B6 RID: 214710 RVA: 0x00EAB914 File Offset: 0x00EA9B14
		public void RequestWeaponLock(int incId, bool bLock)
		{
			ItemLockRequest itemLockRequest = ItemLockRequest.Create();
			itemLockRequest.IncrId = incId;
			itemLockRequest.Oper = (bLock ? 1 : 2);
			Net.Instance.Call(ERequestMessageId.ItemLockRequest, itemLockRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				ItemLockResponse itemLockResponse = (ItemLockResponse)msg;
				if (itemLockResponse == null)
				{
					return;
				}
				if (itemLockResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(itemLockResponse.ErrCode, 22732, null, true, true);
					return;
				}
				if (!bLock)
				{
					ScrollingTipsController.Instance.ShowTipsById("ItemUnlockSuccess", Array.Empty<object>());
				}
				else
				{
					ScrollingTipsController.Instance.ShowTipsById("ItemLockSuccess", Array.Empty<object>());
				}
				PinballWeaponData weaponDataByIncId = PinballModel.Instance.GetWeaponDataByIncId(incId);
				if (weaponDataByIncId != null)
				{
					weaponDataByIncId.SetIsLock(bLock);
				}
				EventSystem.Instance.Emit<int, bool>(EEventName.OnPinballWeaponLockChanged, incId, bLock);
			}, 0);
		}

		// Token: 0x060346B7 RID: 214711 RVA: 0x00EAB976 File Offset: 0x00EA9B76
		public void OpenPinballSmallConfirmBoxView(ConfirmBoxDataNew data)
		{
			data.CustomPopType = new EUiBehaviourPopType?(EUiBehaviourPopType.PinballSmall);
			data.CustomResourceId = "UiItem_ComConfirmPopup";
			ConfirmBoxController.Instance.ShowConfirmBoxNew(data);
		}

		// Token: 0x060346B8 RID: 214712 RVA: 0x00EAB99C File Offset: 0x00EA9B9C
		public void ShowBossTips(int bossTypeId)
		{
			PinballBattleBossComingTipsParam param = new PinballBattleBossComingTipsParam
			{
				BossTypeId = bossTypeId,
				AddMask = new bool?(true),
				CloseTime = this.GetTipsCloseTime(EPinballGameTipsType.BossComing)
			};
			UiManager.Instance.OpenView(EUiViewName.PinballBossComingTipsView, param, null);
		}

		// Token: 0x060346B9 RID: 214713 RVA: 0x00EAB9E0 File Offset: 0x00EA9BE0
		[NullableContext(2)]
		public void ShowFailureTips(Action callBack = null)
		{
			this.OpenGameMainViewMask();
			PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
			PinballWorldConfig? pinballWorldConfig = (pinballBattleSubModel != null) ? pinballBattleSubModel.WorldConfigCache : null;
			int num = (pinballWorldConfig == null) ? 0 : pinballWorldConfig.GetValueOrDefault().SettleDelay;
			TimerSystem.FlowTimeInstance.Delay(delegate(float _)
			{
				PinballBattleTipsParam param = new PinballBattleTipsParam
				{
					CloseCallback = callBack,
					AddMask = new bool?(true),
					CloseTime = this.GetTipsCloseTime(EPinballGameTipsType.Failure)
				};
				UiManager.Instance.OpenView(EUiViewName.PinballFailureTipsView, param, null);
			}, (float)num, null, null, true, 1f);
		}

		// Token: 0x060346BA RID: 214714 RVA: 0x00EABA6C File Offset: 0x00EA9C6C
		[NullableContext(2)]
		public void ShowRoleSkillTips(int roleId, Action callBack = null)
		{
			PinballBattleRoleSkillReleaseTips pinballBattleRoleSkillReleaseTips = UiManager.Instance.GetViewByName(EUiViewName.PinballRoleSkillReleaseTipsView) as PinballBattleRoleSkillReleaseTips;
			if (pinballBattleRoleSkillReleaseTips != null)
			{
				pinballBattleRoleSkillReleaseTips.AddNewRole(roleId);
				return;
			}
			PinballBattleRoleSkillReleaseTipsControllerParam param = new PinballBattleRoleSkillReleaseTipsControllerParam
			{
				RoleId = roleId,
				CloseTime = this.GetTipsCloseTime(EPinballGameTipsType.RoleSkillRelease),
				CloseCallback = callBack
			};
			UiManager.Instance.OpenView(EUiViewName.PinballRoleSkillReleaseTipsView, param, null);
		}

		// Token: 0x060346BB RID: 214715 RVA: 0x00EABACC File Offset: 0x00EA9CCC
		[NullableContext(2)]
		public void ShowSuccessTips(Action callBack = null)
		{
			this.OpenGameMainViewMask();
			PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
			PinballWorldConfig? pinballWorldConfig = (pinballBattleSubModel != null) ? pinballBattleSubModel.WorldConfigCache : null;
			int num = (pinballWorldConfig == null) ? 0 : pinballWorldConfig.GetValueOrDefault().SettleDelay;
			TimerSystem.FlowTimeInstance.Delay(delegate(float _)
			{
				PinballBattleTipsParam param = new PinballBattleTipsParam
				{
					CloseCallback = callBack,
					AddMask = new bool?(true),
					CloseTime = this.GetTipsCloseTime(EPinballGameTipsType.Success)
				};
				UiManager.Instance.OpenView(EUiViewName.PinballSuccessTipsView, param, null);
			}, (float)num, null, null, true, 1f);
		}

		// Token: 0x060346BC RID: 214716 RVA: 0x00EABB57 File Offset: 0x00EA9D57
		private void OpenGameMainViewMask()
		{
			CommonGameMainView commonGameMainView = UiManager.Instance.GetViewByName(EUiViewName.CommonGameMainView) as CommonGameMainView;
			if (commonGameMainView == null)
			{
				return;
			}
			commonGameMainView.SetMaskItemActive(true);
		}

		// Token: 0x060346BD RID: 214717 RVA: 0x00EABB78 File Offset: 0x00EA9D78
		public void ShowBossSkillTips(string tipsTextId)
		{
			PinballBattleBossSkillTipsControllerParam param = new PinballBattleBossSkillTipsControllerParam
			{
				TextId = tipsTextId,
				CloseTime = this.GetTipsCloseTime(EPinballGameTipsType.BossSkill)
			};
			UiManager.Instance.OpenView(EUiViewName.PinballBossSkillTipsView, param, null);
		}

		// Token: 0x060346BE RID: 214718 RVA: 0x00EABBB0 File Offset: 0x00EA9DB0
		public void ShowRoleSkillMaxTips(int roleId)
		{
			PinballBattleRoleSkillMaxTipsControllerParam param = new PinballBattleRoleSkillMaxTipsControllerParam
			{
				RoleId = roleId,
				CloseTime = this.GetTipsCloseTime(EPinballGameTipsType.RoleEnergyMax),
				MoveToBehind = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.PinballRoleSkillMaxTipsView, param, null);
		}

		// Token: 0x060346BF RID: 214719 RVA: 0x00EABBF4 File Offset: 0x00EA9DF4
		[NullableContext(2)]
		public void ShowLevelStartTips(int curWave, int maxWave, Action callback = null)
		{
			PinballBattleLevelStartTipsControllerParam param = new PinballBattleLevelStartTipsControllerParam
			{
				CurWave = curWave,
				MaxWave = maxWave,
				CloseCallback = callback,
				AddMask = new bool?(true),
				CloseTime = this.GetTipsCloseTime(EPinballGameTipsType.WaveStart)
			};
			UiManager.Instance.OpenView(EUiViewName.PinballWaveStartTipsView, param, null);
		}

		// Token: 0x060346C0 RID: 214720 RVA: 0x00EABC48 File Offset: 0x00EA9E48
		private int? GetTipsCloseTime(EPinballGameTipsType tipsType)
		{
			PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
			PinballWorldConfig? pinballWorldConfig = (pinballBattleSubModel != null) ? pinballBattleSubModel.WorldConfigCache : null;
			if (pinballWorldConfig != null)
			{
				PinballWorldConfig valueOrDefault = pinballWorldConfig.GetValueOrDefault();
				for (int i = 0; i < valueOrDefault.TipsTimeLength; i++)
				{
					DicIntInt? dicIntInt = valueOrDefault.TipsTime(i);
					if (dicIntInt != null && dicIntInt.Value.Key == (int)tipsType)
					{
						return new int?(dicIntInt.Value.Value);
					}
				}
				return null;
			}
			return null;
		}

		// Token: 0x060346C1 RID: 214721 RVA: 0x00EABCF4 File Offset: 0x00EA9EF4
		[return: Nullable(2)]
		private PinballActivityData GetPinballActivityData(ActivityBaseData data)
		{
			PinballActivityData pinballActivityData = data as PinballActivityData;
			if (pinballActivityData != null)
			{
				return pinballActivityData;
			}
			return null;
		}

		// Token: 0x060346C2 RID: 214722 RVA: 0x00EABD0E File Offset: 0x00EA9F0E
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipCatapultStoryView, null, null);
		}

		// Token: 0x060346C3 RID: 214723 RVA: 0x00EABD24 File Offset: 0x00EA9F24
		private void OnQuestRedDotStateChange(int questId)
		{
			PinballModel instance = PinballModel.Instance;
			PinballActivityData pinballActivityData = (instance != null) ? instance.ActivityData : null;
			if (pinballActivityData == null)
			{
				return;
			}
			List<int> preGuideQuestIds = pinballActivityData.GetPreGuideQuestIds();
			if (preGuideQuestIds == null || preGuideQuestIds.Count == 0)
			{
				return;
			}
			if (questId != 0 && !preGuideQuestIds.Contains(questId))
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, pinballActivityData.Id);
		}

		// Token: 0x060346C4 RID: 214724 RVA: 0x00EABD80 File Offset: 0x00EA9F80
		public UniTask RequestTaskReward(PinballActivityData activityData, int taskId, [Nullable(2)] Action finishCallback = null)
		{
			PinballController.<RequestTaskReward>d__36 <RequestTaskReward>d__;
			<RequestTaskReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestTaskReward>d__.<>4__this = this;
			<RequestTaskReward>d__.activityData = activityData;
			<RequestTaskReward>d__.taskId = taskId;
			<RequestTaskReward>d__.finishCallback = finishCallback;
			<RequestTaskReward>d__.<>1__state = -1;
			<RequestTaskReward>d__.<>t__builder.Start<PinballController.<RequestTaskReward>d__36>(ref <RequestTaskReward>d__);
			return <RequestTaskReward>d__.<>t__builder.Task;
		}

		// Token: 0x060346C5 RID: 214725 RVA: 0x00EABDDC File Offset: 0x00EA9FDC
		public UniTask RequestTaskRewardByTaskIds(PinballActivityData activityData, List<int> taskIds, [Nullable(2)] Action finishCallback = null)
		{
			PinballController.<RequestTaskRewardByTaskIds>d__37 <RequestTaskRewardByTaskIds>d__;
			<RequestTaskRewardByTaskIds>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestTaskRewardByTaskIds>d__.activityData = activityData;
			<RequestTaskRewardByTaskIds>d__.taskIds = taskIds;
			<RequestTaskRewardByTaskIds>d__.finishCallback = finishCallback;
			<RequestTaskRewardByTaskIds>d__.<>1__state = -1;
			<RequestTaskRewardByTaskIds>d__.<>t__builder.Start<PinballController.<RequestTaskRewardByTaskIds>d__37>(ref <RequestTaskRewardByTaskIds>d__);
			return <RequestTaskRewardByTaskIds>d__.<>t__builder.Task;
		}

		// Token: 0x060346C6 RID: 214726 RVA: 0x00EABE30 File Offset: 0x00EAA030
		public UniTask RequestRankDataList(PinballActivityData activityData)
		{
			PinballController.<RequestRankDataList>d__38 <RequestRankDataList>d__;
			<RequestRankDataList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRankDataList>d__.activityData = activityData;
			<RequestRankDataList>d__.<>1__state = -1;
			<RequestRankDataList>d__.<>t__builder.Start<PinballController.<RequestRankDataList>d__38>(ref <RequestRankDataList>d__);
			return <RequestRankDataList>d__.<>t__builder.Task;
		}

		// Token: 0x060346C7 RID: 214727 RVA: 0x00EABE74 File Offset: 0x00EAA074
		public UniTask RequestMyRankData(PinballActivityData activityData)
		{
			PinballController.<RequestMyRankData>d__39 <RequestMyRankData>d__;
			<RequestMyRankData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestMyRankData>d__.<>4__this = this;
			<RequestMyRankData>d__.activityData = activityData;
			<RequestMyRankData>d__.<>1__state = -1;
			<RequestMyRankData>d__.<>t__builder.Start<PinballController.<RequestMyRankData>d__39>(ref <RequestMyRankData>d__);
			return <RequestMyRankData>d__.<>t__builder.Task;
		}

		// Token: 0x060346C8 RID: 214728 RVA: 0x00EABEC0 File Offset: 0x00EAA0C0
		public void OpenConfirmBackWorld()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ShipTowerFromViewLeaveInst);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.LeaveBattle();
			};
			this.OpenPinballSmallConfirmBoxView(confirmBoxDataNew);
		}

		// Token: 0x060346C9 RID: 214729 RVA: 0x00EABEF7 File Offset: 0x00EAA0F7
		private bool LeaveBattle()
		{
			if (!this.CheckInPinballBattleDungeon())
			{
				return false;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			return true;
		}

		// Token: 0x060346CA RID: 214730 RVA: 0x00EABF14 File Offset: 0x00EAA114
		public bool CheckInPinballBattleDungeon()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.Value.InstSubType == 45;
		}

		// Token: 0x060346CB RID: 214731 RVA: 0x00EABF65 File Offset: 0x00EAA165
		public bool CheckToSetRoleRedDotAsRead(int activityId, int roleId)
		{
			if (!PinballModel.Instance.GetRoleRedDot(activityId, roleId))
			{
				return false;
			}
			this.SetRoleRedDotAsRead(activityId, roleId);
			return true;
		}

		// Token: 0x060346CC RID: 214732 RVA: 0x00EABF80 File Offset: 0x00EAA180
		public void SetRoleRedDotAsRead(int activityId, int roleId)
		{
			ActivityModel instance = ActivityModel.Instance;
			PinballActivityData activityDataByActivityId = PinballModel.Instance.GetActivityDataByActivityId(activityId);
			if (activityDataByActivityId == null)
			{
				return;
			}
			global::PinballRoleData roleData = activityDataByActivityId.GetRoleData(roleId);
			if (roleData == null)
			{
				return;
			}
			int subId = roleData.GetConfig().SubId;
			instance.SaveActivityData(activityId, subId, 0, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshPinballRoleRedDot, roleId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}

		// Token: 0x060346CD RID: 214733 RVA: 0x00EABFED File Offset: 0x00EAA1ED
		public void OpenBubbleView(CustomPromise promise)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.PinballBubbleView))
			{
				promise.SetResult();
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.PinballBubbleView, promise, null);
		}

		// Token: 0x170065E8 RID: 26088
		// (get) Token: 0x060346CE RID: 214734 RVA: 0x00EAC018 File Offset: 0x00EAA218
		public static PinballController Instance
		{
			get
			{
				return PinballController._Instance;
			}
		}

		// Token: 0x060346CF RID: 214735 RVA: 0x00EAC01F File Offset: 0x00EAA21F
		public static PinballController GetOrCreateInstance()
		{
			if (PinballController._Instance == null)
			{
				PinballController.CreateInstance();
			}
			return PinballController._Instance;
		}

		// Token: 0x060346D0 RID: 214736 RVA: 0x00EAC033 File Offset: 0x00EAA233
		public static bool CreateInstance()
		{
			if (PinballController._Instance != null)
			{
				return true;
			}
			PinballController._Instance = new PinballController();
			return true;
		}

		// Token: 0x060346D1 RID: 214737 RVA: 0x00EAC049 File Offset: 0x00EAA249
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060346D2 RID: 214738 RVA: 0x00EAC04B File Offset: 0x00EAA24B
		public static void ResetStaticDefaultValue()
		{
			PinballController._Instance = null;
		}

		// Token: 0x060346D3 RID: 214739 RVA: 0x00EAC053 File Offset: 0x00EAA253
		static PinballController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PinballController.CreateStaticDefaultValue), new Action(PinballController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BD49 RID: 113993
		[Nullable(2)]
		private static PinballController _Instance;
	}
}
