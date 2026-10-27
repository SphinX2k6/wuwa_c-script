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
	// Token: 0x020062C7 RID: 25287
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class PinballController : ActivityControllerBase
	{
		// Token: 0x0603F9DF RID: 260575 RVA: 0x00F6444E File Offset: 0x00F6264E
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

		// Token: 0x0603F9E0 RID: 260576 RVA: 0x00F6447D File Offset: 0x00F6267D
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.PinballUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPinballUpdateNotify));
		}

		// Token: 0x0603F9E1 RID: 260577 RVA: 0x00F6449B File Offset: 0x00F6269B
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.PinballUpdateNotify);
		}

		// Token: 0x0603F9E2 RID: 260578 RVA: 0x00F644AD File Offset: 0x00F626AD
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(this.OnQuestRedDotStateChange));
		}

		// Token: 0x0603F9E3 RID: 260579 RVA: 0x00F644CB File Offset: 0x00F626CB
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnQuestRedDotStateChange, new Action<int>(this.OnQuestRedDotStateChange));
		}

		// Token: 0x0603F9E4 RID: 260580 RVA: 0x00F644EC File Offset: 0x00F626EC
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

		// Token: 0x0603F9E5 RID: 260581 RVA: 0x00F64538 File Offset: 0x00F62738
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

		// Token: 0x0603F9E6 RID: 260582 RVA: 0x00F6468C File Offset: 0x00F6288C
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

		// Token: 0x0603F9E7 RID: 260583 RVA: 0x00F646E0 File Offset: 0x00F628E0
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

		// Token: 0x0603F9E8 RID: 260584 RVA: 0x00F64733 File Offset: 0x00F62933
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603F9E9 RID: 260585 RVA: 0x00F64735 File Offset: 0x00F62935
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityCatapultStoryGuide";
		}

		// Token: 0x0603F9EA RID: 260586 RVA: 0x00F6473C File Offset: 0x00F6293C
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new PinballActivitySubView();
		}

		// Token: 0x0603F9EB RID: 260587 RVA: 0x00F64743 File Offset: 0x00F62943
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new PinballActivityData();
		}

		// Token: 0x0603F9EC RID: 260588 RVA: 0x00F6474A File Offset: 0x00F6294A
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603F9ED RID: 260589 RVA: 0x00F64750 File Offset: 0x00F62950
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

		// Token: 0x0603F9EE RID: 260590 RVA: 0x00F647A4 File Offset: 0x00F629A4
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

		// Token: 0x0603F9EF RID: 260591 RVA: 0x00F647F8 File Offset: 0x00F629F8
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

		// Token: 0x0603F9F0 RID: 260592 RVA: 0x00F6484C File Offset: 0x00F62A4C
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

		// Token: 0x0603F9F1 RID: 260593 RVA: 0x00F64898 File Offset: 0x00F62A98
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

		// Token: 0x0603F9F2 RID: 260594 RVA: 0x00F648E4 File Offset: 0x00F62AE4
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

		// Token: 0x0603F9F3 RID: 260595 RVA: 0x00F64928 File Offset: 0x00F62B28
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

		// Token: 0x0603F9F4 RID: 260596 RVA: 0x00F6496C File Offset: 0x00F62B6C
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

		// Token: 0x0603F9F5 RID: 260597 RVA: 0x00F649B8 File Offset: 0x00F62BB8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(itemLockResponse.ErrCode, 18915, null, true, true);
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

		// Token: 0x0603F9F6 RID: 260598 RVA: 0x00F64A1A File Offset: 0x00F62C1A
		public void OpenPinballSmallConfirmBoxView(ConfirmBoxDataNew data)
		{
			data.CustomPopType = new EUiBehaviourPopType?(EUiBehaviourPopType.PinballSmall);
			data.CustomResourceId = "UiItem_ComConfirmPopup";
			ConfirmBoxController.Instance.ShowConfirmBoxNew(data);
		}

		// Token: 0x0603F9F7 RID: 260599 RVA: 0x00F64A40 File Offset: 0x00F62C40
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

		// Token: 0x0603F9F8 RID: 260600 RVA: 0x00F64A84 File Offset: 0x00F62C84
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

		// Token: 0x0603F9F9 RID: 260601 RVA: 0x00F64B10 File Offset: 0x00F62D10
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

		// Token: 0x0603F9FA RID: 260602 RVA: 0x00F64B70 File Offset: 0x00F62D70
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

		// Token: 0x0603F9FB RID: 260603 RVA: 0x00F64BFB File Offset: 0x00F62DFB
		private void OpenGameMainViewMask()
		{
			CommonGameMainView commonGameMainView = UiManager.Instance.GetViewByName(EUiViewName.CommonGameMainView) as CommonGameMainView;
			if (commonGameMainView == null)
			{
				return;
			}
			commonGameMainView.SetMaskItemActive(true);
		}

		// Token: 0x0603F9FC RID: 260604 RVA: 0x00F64C1C File Offset: 0x00F62E1C
		public void ShowBossSkillTips(string tipsTextId)
		{
			PinballBattleBossSkillTipsControllerParam param = new PinballBattleBossSkillTipsControllerParam
			{
				TextId = tipsTextId,
				CloseTime = this.GetTipsCloseTime(EPinballGameTipsType.BossSkill)
			};
			UiManager.Instance.OpenView(EUiViewName.PinballBossSkillTipsView, param, null);
		}

		// Token: 0x0603F9FD RID: 260605 RVA: 0x00F64C54 File Offset: 0x00F62E54
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

		// Token: 0x0603F9FE RID: 260606 RVA: 0x00F64C98 File Offset: 0x00F62E98
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

		// Token: 0x0603F9FF RID: 260607 RVA: 0x00F64CEC File Offset: 0x00F62EEC
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

		// Token: 0x0603FA00 RID: 260608 RVA: 0x00F64D98 File Offset: 0x00F62F98
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

		// Token: 0x0603FA01 RID: 260609 RVA: 0x00F64DB2 File Offset: 0x00F62FB2
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipCatapultStoryView, null, null);
		}

		// Token: 0x0603FA02 RID: 260610 RVA: 0x00F64DC8 File Offset: 0x00F62FC8
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

		// Token: 0x0603FA03 RID: 260611 RVA: 0x00F64E24 File Offset: 0x00F63024
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

		// Token: 0x0603FA04 RID: 260612 RVA: 0x00F64E80 File Offset: 0x00F63080
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

		// Token: 0x0603FA05 RID: 260613 RVA: 0x00F64ED4 File Offset: 0x00F630D4
		public UniTask RequestRankDataList(PinballActivityData activityData)
		{
			PinballController.<RequestRankDataList>d__38 <RequestRankDataList>d__;
			<RequestRankDataList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRankDataList>d__.activityData = activityData;
			<RequestRankDataList>d__.<>1__state = -1;
			<RequestRankDataList>d__.<>t__builder.Start<PinballController.<RequestRankDataList>d__38>(ref <RequestRankDataList>d__);
			return <RequestRankDataList>d__.<>t__builder.Task;
		}

		// Token: 0x0603FA06 RID: 260614 RVA: 0x00F64F18 File Offset: 0x00F63118
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

		// Token: 0x0603FA07 RID: 260615 RVA: 0x00F64F64 File Offset: 0x00F63164
		public void OpenConfirmBackWorld()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ShipTowerFromViewLeaveInst);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.LeaveBattle();
			};
			this.OpenPinballSmallConfirmBoxView(confirmBoxDataNew);
		}

		// Token: 0x0603FA08 RID: 260616 RVA: 0x00F64F9B File Offset: 0x00F6319B
		private bool LeaveBattle()
		{
			if (!this.CheckInPinballBattleDungeon())
			{
				return false;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			return true;
		}

		// Token: 0x0603FA09 RID: 260617 RVA: 0x00F64FB8 File Offset: 0x00F631B8
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

		// Token: 0x0603FA0A RID: 260618 RVA: 0x00F65009 File Offset: 0x00F63209
		public bool CheckToSetRoleRedDotAsRead(int activityId, int roleId)
		{
			if (!PinballModel.Instance.GetRoleRedDot(activityId, roleId))
			{
				return false;
			}
			this.SetRoleRedDotAsRead(activityId, roleId);
			return true;
		}

		// Token: 0x0603FA0B RID: 260619 RVA: 0x00F65024 File Offset: 0x00F63224
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

		// Token: 0x0603FA0C RID: 260620 RVA: 0x00F65091 File Offset: 0x00F63291
		public void OpenBubbleView(CustomPromise promise)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.PinballBubbleView))
			{
				promise.SetResult();
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.PinballBubbleView, promise, null);
		}

		// Token: 0x17009286 RID: 37510
		// (get) Token: 0x0603FA0D RID: 260621 RVA: 0x00F650BC File Offset: 0x00F632BC
		public static PinballController Instance
		{
			get
			{
				return PinballController._Instance;
			}
		}

		// Token: 0x0603FA0E RID: 260622 RVA: 0x00F650C3 File Offset: 0x00F632C3
		public static PinballController GetOrCreateInstance()
		{
			if (PinballController._Instance == null)
			{
				PinballController.CreateInstance();
			}
			return PinballController._Instance;
		}

		// Token: 0x0603FA0F RID: 260623 RVA: 0x00F650D7 File Offset: 0x00F632D7
		public static bool CreateInstance()
		{
			if (PinballController._Instance != null)
			{
				return true;
			}
			PinballController._Instance = new PinballController();
			return true;
		}

		// Token: 0x0603FA10 RID: 260624 RVA: 0x00F650ED File Offset: 0x00F632ED
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603FA11 RID: 260625 RVA: 0x00F650EF File Offset: 0x00F632EF
		public static void ResetStaticDefaultValue()
		{
			PinballController._Instance = null;
		}

		// Token: 0x0603FA12 RID: 260626 RVA: 0x00F650F7 File Offset: 0x00F632F7
		static PinballController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PinballController.CreateStaticDefaultValue), new Action(PinballController.ResetStaticDefaultValue));
		}

		// Token: 0x0402141A RID: 136218
		[Nullable(2)]
		private static PinballController _Instance;
	}
}
