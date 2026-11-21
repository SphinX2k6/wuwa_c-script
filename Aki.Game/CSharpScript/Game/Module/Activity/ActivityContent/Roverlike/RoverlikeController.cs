using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.BattleViewDynamicUI;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005064 RID: 20580
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class RoverlikeController : UiControllerBase
	{
		// Token: 0x0603386A RID: 211050 RVA: 0x00E6D801 File Offset: 0x00E6BA01
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603386B RID: 211051 RVA: 0x00E6D804 File Offset: 0x00E6BA04
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RoverRogueInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueInfoNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueRoomInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueRoomInfoNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueChooseDataNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueChooseDataNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueSubLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueSubLevelNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueResultNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueCurrencyNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueCurrencyNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueGainDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueGainDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueShopUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueShopUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueShopInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueShopInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueGainGetOrLoseNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueGainGetOrLoseNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueBlessGroupSelectNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueBlessGroupSelectNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueEventNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueEventNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueLootChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueLootChangeNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueUpdateReviveTimesNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueUpdateReviveTimesNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueTalentUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueTalentUnlockNotify));
			Net.Instance.Register(ENotifyMessageId.RoverRogueResourcesUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoverRogueResourcesUpdateNotify));
		}

		// Token: 0x0603386C RID: 211052 RVA: 0x00E6D9D4 File Offset: 0x00E6BBD4
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueRoomInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueChooseDataNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueSubLevelNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueResultNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueCurrencyNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueGainDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueShopUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueShopInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueGainGetOrLoseNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueBlessGroupSelectNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueEventNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueLootChangeNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueUpdateReviveTimesNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueTalentUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoverRogueResourcesUpdateNotify);
		}

		// Token: 0x0603386D RID: 211053 RVA: 0x00E6DAE1 File Offset: 0x00E6BCE1
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0603386E RID: 211054 RVA: 0x00E6DAFF File Offset: 0x00E6BCFF
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0603386F RID: 211055 RVA: 0x00E6DB20 File Offset: 0x00E6BD20
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		protected override ValueTuple<string, CustomPromise<bool>>? OnPreload()
		{
			if (this.CheckInRoverlike())
			{
				EventSystem.Instance.Add<Entity>(EEventName.OnRevive, new Action<Entity>(this.OnRevive));
			}
			return null;
		}

		// Token: 0x06033870 RID: 211056 RVA: 0x00E6DB5C File Offset: 0x00E6BD5C
		protected override bool OnLeaveLevel()
		{
			if (EventSystem.Instance.Has<Entity>(EEventName.OnRevive, new Action<Entity>(this.OnRevive)))
			{
				EventSystem.Instance.Remove<Entity>(EEventName.OnRevive, new Action<Entity>(this.OnRevive));
			}
			this.ClearDeathAnimTimer();
			return true;
		}

		// Token: 0x06033871 RID: 211057 RVA: 0x00E6DBA9 File Offset: 0x00E6BDA9
		private void OnWorldDone()
		{
			if (RoverlikeModel.Instance.NeedOpenMainView)
			{
				this.AddMainViewSplashTask();
			}
		}

		// Token: 0x06033872 RID: 211058 RVA: 0x00E6DBC0 File Offset: 0x00E6BDC0
		private void EnqueueRoleUnlockByInstId(int instId)
		{
			IReadOnlyList<RoverRogueBlessRole> blessRoleConfigListByUnlockInsId = RoverlikeConfig.Instance.GetBlessRoleConfigListByUnlockInsId(instId);
			if (blessRoleConfigListByUnlockInsId == null)
			{
				return;
			}
			foreach (RoverRogueBlessRole roverRogueBlessRole in blessRoleConfigListByUnlockInsId)
			{
				if (!this.RoleUnlockQueue.Contains(roverRogueBlessRole.Id))
				{
					this.RoleUnlockQueue.Add(roverRogueBlessRole.Id);
				}
			}
		}

		// Token: 0x06033873 RID: 211059 RVA: 0x00E6DC38 File Offset: 0x00E6BE38
		public void PlayMainViewUnlockFlow()
		{
			this.IsLootUnlockReady = false;
			UniTask.Create(delegate()
			{
				RoverlikeController.<<PlayMainViewUnlockFlow>b__17_0>d <<PlayMainViewUnlockFlow>b__17_0>d;
				<<PlayMainViewUnlockFlow>b__17_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PlayMainViewUnlockFlow>b__17_0>d.<>4__this = this;
				<<PlayMainViewUnlockFlow>b__17_0>d.<>1__state = -1;
				<<PlayMainViewUnlockFlow>b__17_0>d.<>t__builder.Start<RoverlikeController.<<PlayMainViewUnlockFlow>b__17_0>d>(ref <<PlayMainViewUnlockFlow>b__17_0>d);
				return <<PlayMainViewUnlockFlow>b__17_0>d.<>t__builder.Task;
			}).Forget();
			this.PlayRoleUnlockQueue();
		}

		// Token: 0x06033874 RID: 211060 RVA: 0x00E6DC5D File Offset: 0x00E6BE5D
		public void PlayRoleUnlockQueue()
		{
			this.TryShowNextRoleUnlock();
		}

		// Token: 0x06033875 RID: 211061 RVA: 0x00E6DC68 File Offset: 0x00E6BE68
		private void TryShowNextRoleUnlock()
		{
			if (this.IsRoleUnlockShowing)
			{
				return;
			}
			if (this.RoleUnlockQueue.Count == 0)
			{
				if (this.IsLootUnlockReady)
				{
					this.TryShowLootUnlockView();
				}
				return;
			}
			int blessRoleId = this.RoleUnlockQueue[0];
			this.RoleUnlockQueue.RemoveAt(0);
			this.IsRoleUnlockShowing = true;
			RoverlikeRoleUnlockViewParam param = new RoverlikeRoleUnlockViewParam
			{
				BlessRoleId = blessRoleId,
				OnClosed = delegate()
				{
					this.IsRoleUnlockShowing = false;
					this.TryShowNextRoleUnlock();
				}
			};
			UiManager.Instance.OpenView(EUiViewName.RoverlikeRoleUnlockView, param, null);
		}

		// Token: 0x06033876 RID: 211062 RVA: 0x00E6DCEC File Offset: 0x00E6BEEC
		private UniTask CacheAndDiffUnlockLoots()
		{
			RoverlikeController.<CacheAndDiffUnlockLoots>d__20 <CacheAndDiffUnlockLoots>d__;
			<CacheAndDiffUnlockLoots>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CacheAndDiffUnlockLoots>d__.<>4__this = this;
			<CacheAndDiffUnlockLoots>d__.<>1__state = -1;
			<CacheAndDiffUnlockLoots>d__.<>t__builder.Start<RoverlikeController.<CacheAndDiffUnlockLoots>d__20>(ref <CacheAndDiffUnlockLoots>d__);
			return <CacheAndDiffUnlockLoots>d__.<>t__builder.Task;
		}

		// Token: 0x06033877 RID: 211063 RVA: 0x00E6DD30 File Offset: 0x00E6BF30
		private void TryShowLootUnlockView()
		{
			List<RoverRogueGainEntry> pendingUnlockLoots = this.PendingUnlockLoots;
			this.PendingUnlockLoots = new List<RoverRogueGainEntry>();
			if (pendingUnlockLoots.Count == 0)
			{
				this.NotifyUnlockFlowEnd();
				return;
			}
			RoverlikeLootUnlockViewOpenParam param = new RoverlikeLootUnlockViewOpenParam
			{
				Loots = pendingUnlockLoots,
				OnClosed = new Action(this.NotifyUnlockFlowEnd)
			};
			UiManager.Instance.OpenView(EUiViewName.RoverlikeLootUnlockView, param, null);
		}

		// Token: 0x06033878 RID: 211064 RVA: 0x00E6DD8E File Offset: 0x00E6BF8E
		private void NotifyUnlockFlowEnd()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeUnlockShowEnd");
		}

		// Token: 0x06033879 RID: 211065 RVA: 0x00E6DDA8 File Offset: 0x00E6BFA8
		private void OnRoverRogueTalentUnlockNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueTalentUnlockNotify roverRogueTalentUnlockNotify = (RoverRogueTalentUnlockNotify)msg;
			RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			currentActivityData.TalentTreeData.UpdateUnlockTalentIds(roverRogueTalentUnlockNotify.TalentIds, true);
			EventSystem.Instance.Emit(EEventName.RoverlikeTalentUnlockDataUpdate);
		}

		// Token: 0x0603387A RID: 211066 RVA: 0x00E6DDF0 File Offset: 0x00E6BFF0
		private void OnRoverRogueInfoNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueInfoNotify roverRogueInfoNotify = (RoverRogueInfoNotify)msg;
			RoverlikeModel instance = RoverlikeModel.Instance;
			instance.CreateInstanceData();
			instance.CreateActionData();
			instance.InstanceData.InitFromNotify(roverRogueInfoNotify);
			instance.UpdateCurrency(roverRogueInfoNotify.ItemData);
			HudUnitController.Instance.TryCreateHud(EHudUnitType.RoverlikeMonsterCursor);
			BattleViewDynamicUIController.Instance.TryCreateDynamicUI(EBattleViewDynamicUIType.RoverlikeBattleInfo);
			BattleUiModel.Instance.RegisterTopPanelHook(new RoverlikeTopHudHook());
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera != null)
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				if (logicComponent != null)
				{
					CameraCollision cameraCollision = logicComponent.CameraCollision;
					if (cameraCollision != null)
					{
						cameraCollision.SetCameraCollisionMode(ECameraCollisionMode.InPlaceProbe);
					}
				}
			}
			InputDistributeController.Instance.BindAction("大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603387B RID: 211067 RVA: 0x00E6DEA0 File Offset: 0x00E6C0A0
		private void ClearRoverRogueInstance()
		{
			RoverlikeModel.Instance.ClearInstanceData();
			RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
			if (currentActivityData != null && currentActivityData.CheckIfInOpenTime())
			{
				RoverlikeModel.Instance.HasNewSettle = true;
			}
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera != null)
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				if (logicComponent != null)
				{
					CameraCollision cameraCollision = logicComponent.CameraCollision;
					if (cameraCollision != null)
					{
						cameraCollision.SetCameraCollisionMode(ECameraCollisionMode.Default);
					}
				}
			}
			InputDistributeController.Instance.UnBindAction("大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603387C RID: 211068 RVA: 0x00E6DF24 File Offset: 0x00E6C124
		private void OnRoverRogueRoomInfoNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueRoomInfoNotify roverRogueRoomInfoNotify = (RoverRogueRoomInfoNotify)msg;
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			if (instanceData != null)
			{
				instanceData.UpdateRoomUpdateInfo(roverRogueRoomInfoNotify);
			}
			RoverRogueRoom? roomConfig = RoverlikeConfig.Instance.GetRoomConfig(roverRogueRoomInfoNotify.RoomId);
			RoverRogueRoomType? roomTypeConfig = RoverlikeConfig.Instance.GetRoomTypeConfig(roverRogueRoomInfoNotify.RoomTypeId);
			if (!StringUtils.IsEmpty((roomConfig != null) ? roomConfig.GetValueOrDefault().MusicState : null))
			{
				RoverlikeModel.Instance.CurRoomMusicState = ((roomConfig != null) ? roomConfig.GetValueOrDefault().MusicState : null);
			}
			else
			{
				RoverlikeModel.Instance.CurRoomMusicState = ((roomTypeConfig != null) ? roomTypeConfig.GetValueOrDefault().MusicState : null);
			}
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UiManager.Instance.OpenView(EUiViewName.RoverlikeLevelTipsView, null, null);
			}, 1000f, null, null, true, 1f);
		}

		// Token: 0x0603387D RID: 211069 RVA: 0x00E6E018 File Offset: 0x00E6C218
		private void OnRoverRogueResultNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueResultNotify roverRogueResultNotify = (RoverRogueResultNotify)msg;
			RoverRogueResultInfo resultInfo = roverRogueResultNotify.ResultInfo;
			if (resultInfo == null)
			{
				return;
			}
			if (this.TryExitRoverRogueWithoutResultView(resultInfo))
			{
				return;
			}
			if (resultInfo.IsDeadTrigger)
			{
				TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					UiManager.Instance.OpenView(EUiViewName.RoverlikeResultView, resultInfo, null);
				}, 3000f, null, null, true, 1f);
				return;
			}
			RoverlikeModel.Instance.SaveLastPassRoleTypeId();
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeLevelSelectData roverlikeLevelSelectData;
			if (instance == null)
			{
				roverlikeLevelSelectData = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				roverlikeLevelSelectData = ((currentActivityData != null) ? currentActivityData.LevelSelectData : null);
			}
			RoverlikeLevelSelectData roverlikeLevelSelectData2 = roverlikeLevelSelectData;
			if (roverlikeLevelSelectData2 == null || !roverlikeLevelSelectData2.IsPassed(resultInfo.InstId))
			{
				this.EnqueueRoleUnlockByInstId(resultInfo.InstId);
			}
			UiManager.Instance.OpenView(EUiViewName.RoverlikeResultView, resultInfo, null);
		}

		// Token: 0x0603387E RID: 211070 RVA: 0x00E6E0F0 File Offset: 0x00E6C2F0
		private void OnRoverRogueCurrencyNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueCurrencyNotify roverRogueCurrencyNotify = (RoverRogueCurrencyNotify)msg;
			RoverlikeModel.Instance.UpdateCurrency(roverRogueCurrencyNotify.ItemData);
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
			int num = (roverlikeActivityData != null) ? roverlikeActivityData.TalentTreeData.TalentPointItemId : 0;
			if (num <= 0)
			{
				return;
			}
			using (IEnumerator<RoverRogueItemCurrencyData> enumerator = (roverRogueCurrencyNotify.ItemData ?? new RepeatedField<RoverRogueItemCurrencyData>()).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.ItemId == num)
					{
						EventSystem.Instance.Emit(EEventName.RoverlikeTalentUnlockDataUpdate);
					}
				}
			}
		}

		// Token: 0x0603387F RID: 211071 RVA: 0x00E6E198 File Offset: 0x00E6C398
		private void OnRoverRogueGainDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueGainDataUpdateNotify notify = (RoverRogueGainDataUpdateNotify)msg;
			if (RoverlikeModel.Instance.InstanceData != null)
			{
				RoverlikeModel.Instance.InstanceData.ApplyGainDataUpdate(notify);
			}
		}

		// Token: 0x06033880 RID: 211072 RVA: 0x00E6E1C8 File Offset: 0x00E6C3C8
		private void OnRoverRogueResourcesUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueResourcesUpdateNotify notify = (RoverRogueResourcesUpdateNotify)msg;
			List<IRoverlikeFloatTextData> list = this.BuildResourcesFloatTextList(notify);
			if (list.Count == 0)
			{
				return;
			}
			this.ShowResourcesFloatText(list);
		}

		// Token: 0x06033881 RID: 211073 RVA: 0x00E6E1F4 File Offset: 0x00E6C3F4
		[NullableContext(1)]
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			EInputState state = (actionType == InputDistributeDefine.EActionType.Press) ? EInputState.Press : EInputState.Release;
			InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.幻象2, state);
		}

		// Token: 0x06033882 RID: 211074 RVA: 0x00E6E21C File Offset: 0x00E6C41C
		[NullableContext(1)]
		private List<IRoverlikeFloatTextData> BuildResourcesFloatTextList(RoverRogueResourcesUpdateNotify notify)
		{
			List<IRoverlikeFloatTextData> list = new List<IRoverlikeFloatTextData>();
			int effectId = notify.EffectId;
			if (effectId > 0)
			{
				RoverRogueEffect? effectConfig = RoverlikeConfig.Instance.GetEffectConfig(effectId);
				if (effectConfig == null || !effectConfig.Value.ClientDisplay)
				{
					return list;
				}
			}
			this.PushFloatTextIfAny(list, ERoverlikeFloatTextType.HpMax, (double)notify.HpMax, null);
			this.PushFloatTextIfAny(list, ERoverlikeFloatTextType.Coin, (double)notify.Coin, null);
			this.PushFloatTextIfAny(list, ERoverlikeFloatTextType.TalentPoint, (double)notify.TalentPoint, null);
			this.PushFloatTextIfAny(list, ERoverlikeFloatTextType.GoldEfficiency, (double)notify.GoldEfficiency / 100.0, null);
			foreach (RoverRogueResourcesItem roverRogueResourcesItem in (notify.Item ?? new RepeatedField<RoverRogueResourcesItem>()))
			{
				RoverRogueItem? itemConfig = RoverlikeConfig.Instance.GetItemConfig(roverRogueResourcesItem.ConfId);
				if (itemConfig != null)
				{
					string text = ConfigMultiTextLang.GetLocalTextNew(itemConfig.Value.Name, null) ?? string.Empty;
					this.PushFloatTextIfAny(list, ERoverlikeFloatTextType.ItemRound, (double)roverRogueResourcesItem.RoundNum, new string[]
					{
						text,
						roverRogueResourcesItem.RoundNum.ToString()
					});
				}
			}
			foreach (RoverRogueAttChange roverRogueAttChange in (notify.AttChange ?? new RepeatedField<RoverRogueAttChange>()))
			{
				int attId = roverRogueAttChange.AttId;
				PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attId);
				if (propertyIndexInfo != null)
				{
					RoverlikeActivityController instance = RoverlikeActivityController.Instance;
					RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
					string priorityAttributeName = this.GetPriorityAttributeName(roverlikeActivityData.GetParamConfig().Value, attId);
					string text2 = string.Empty;
					if (!StringUtils.IsEmpty(priorityAttributeName))
					{
						text2 = (ConfigMultiTextLang.GetLocalTextNew(priorityAttributeName, null) ?? string.Empty);
					}
					else
					{
						text2 = (ConfigMultiTextLang.GetLocalTextNew(propertyIndexInfo.Value.Name, null) ?? string.Empty);
					}
					string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(attId, (double)roverRogueAttChange.ChangeAttValue, propertyIndexInfo.Value.IsPercent);
					this.PushFloatTextIfAny(list, ERoverlikeFloatTextType.Attr, (double)roverRogueAttChange.ChangeAttValue, new string[]
					{
						text2,
						formatAttributeValueString
					});
				}
			}
			return list;
		}

		// Token: 0x06033883 RID: 211075 RVA: 0x00E6E488 File Offset: 0x00E6C688
		private string GetPriorityAttributeName(RoverRogueActivity activityConfig, int attrId)
		{
			for (int i = 0; i < activityConfig.AttributeNameLength; i++)
			{
				DicIntString? dicIntString = activityConfig.AttributeName(i);
				if (dicIntString != null && dicIntString.GetValueOrDefault().Key == attrId)
				{
					return dicIntString.Value.Value;
				}
			}
			return null;
		}

		// Token: 0x06033884 RID: 211076 RVA: 0x00E6E4E4 File Offset: 0x00E6C6E4
		[NullableContext(1)]
		private void PushFloatTextIfAny(List<IRoverlikeFloatTextData> floatTextList, ERoverlikeFloatTextType type, double value, [Nullable(new byte[]
		{
			2,
			1
		})] string[] param = null)
		{
			if (value == 0.0)
			{
				return;
			}
			RoverlikeFloatTextKeyPair roverlikeFloatTextKeyPair = RoverlikeFloatTextKeyMap.Map[type];
			RoverlikeFloatTextData roverlikeFloatTextData = new RoverlikeFloatTextData();
			roverlikeFloatTextData.Type = type;
			roverlikeFloatTextData.TextKey = ((value > 0.0) ? roverlikeFloatTextKeyPair.Increment : roverlikeFloatTextKeyPair.Decrements);
			RoverlikeFloatTextData roverlikeFloatTextData2 = roverlikeFloatTextData;
			string[] textParam = param;
			if (param == null)
			{
				(textParam = new string[1])[0] = value.ToString();
			}
			roverlikeFloatTextData2.TextParam = textParam;
			RoverlikeFloatTextData item = roverlikeFloatTextData;
			floatTextList.Add(item);
		}

		// Token: 0x06033885 RID: 211077 RVA: 0x00E6E55C File Offset: 0x00E6C75C
		[NullableContext(1)]
		private void ShowResourcesFloatText(List<IRoverlikeFloatTextData> floatTextList)
		{
			RoverlikeModel.Instance.EnqueueFloatText(floatTextList);
			this.TryOpenFloatTipsView();
		}

		// Token: 0x06033886 RID: 211078 RVA: 0x00E6E56F File Offset: 0x00E6C76F
		private void TryOpenFloatTipsView()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.RoverlikeInfoTipsView))
			{
				return;
			}
			if (RoverlikeModel.Instance.IsFloatTextEmpty)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RoverlikeInfoTipsView, null, null);
		}

		// Token: 0x06033887 RID: 211079 RVA: 0x00E6E5A4 File Offset: 0x00E6C7A4
		private void OnRoverRogueSubLevelNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverlikeController.<>c__DisplayClass37_0 CS$<>8__locals1 = new RoverlikeController.<>c__DisplayClass37_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.notify = (RoverRogueSubLevelNotify)msg;
			AsyncTask task = new AsyncTask("RoverlikeSubLevelChangeTask", delegate()
			{
				RoverlikeController.<>c__DisplayClass37_0.<<OnRoverRogueSubLevelNotify>b__0>d <<OnRoverRogueSubLevelNotify>b__0>d;
				<<OnRoverRogueSubLevelNotify>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
				<<OnRoverRogueSubLevelNotify>b__0>d.<>4__this = CS$<>8__locals1;
				<<OnRoverRogueSubLevelNotify>b__0>d.<>1__state = -1;
				<<OnRoverRogueSubLevelNotify>b__0>d.<>t__builder.Start<RoverlikeController.<>c__DisplayClass37_0.<<OnRoverRogueSubLevelNotify>b__0>d>(ref <<OnRoverRogueSubLevelNotify>b__0>d);
				return <<OnRoverRogueSubLevelNotify>b__0>d.<>t__builder.Task;
			}, null, null, null);
			TaskSystem.Instance.AddTask(task);
			TaskSystem.Instance.Run();
		}

		// Token: 0x06033888 RID: 211080 RVA: 0x00E6E5FC File Offset: 0x00E6C7FC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1
		})]
		private ValueTuple<string[], string[]> FilterSameSubLevel(RoverRogueSubLevelNotify notify)
		{
			HashSet<string> loadSet = new HashSet<string>(notify.LoadSubLevels, StringComparer.Ordinal);
			HashSet<string> unloadSet = new HashSet<string>(notify.UnLoadSubLevels, StringComparer.Ordinal);
			return new ValueTuple<string[], string[]>(NoLinq.WhereToArray<string>(notify.UnLoadSubLevels, (string item) => !loadSet.Contains(item)), NoLinq.WhereToArray<string>(notify.LoadSubLevels, (string item) => !unloadSet.Contains(item)));
		}

		// Token: 0x06033889 RID: 211081 RVA: 0x00E6E670 File Offset: 0x00E6C870
		private UniTask RoverRogueGotoNextRoomCommitAsync()
		{
			RoverlikeController.<RoverRogueGotoNextRoomCommitAsync>d__39 <RoverRogueGotoNextRoomCommitAsync>d__;
			<RoverRogueGotoNextRoomCommitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoverRogueGotoNextRoomCommitAsync>d__.<>1__state = -1;
			<RoverRogueGotoNextRoomCommitAsync>d__.<>t__builder.Start<RoverlikeController.<RoverRogueGotoNextRoomCommitAsync>d__39>(ref <RoverRogueGotoNextRoomCommitAsync>d__);
			return <RoverRogueGotoNextRoomCommitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603388A RID: 211082 RVA: 0x00E6E6AB File Offset: 0x00E6C8AB
		[NullableContext(1)]
		private bool TryExitRoverRogueWithoutResultView(RoverRogueResultInfo resultInfo)
		{
			if (resultInfo.InstId != 0)
			{
				return false;
			}
			if (this.CheckInRoverlike())
			{
				this.RoverRogueExitRequest();
			}
			return true;
		}

		// Token: 0x0603388B RID: 211083 RVA: 0x00E6E6C8 File Offset: 0x00E6C8C8
		public void OpenRoverRogueLootViewRequest()
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
			bool flag = roverlikeActivityData != null && roverlikeActivityData.HasSaveProgress();
			int num = (roverlikeActivityData != null) ? roverlikeActivityData.GetEquippedLootId() : 0;
			RoverlikeLootViewOpenParam roverlikeLootViewOpenParam = new RoverlikeLootViewOpenParam();
			roverlikeLootViewOpenParam.IsInGame = false;
			roverlikeLootViewOpenParam.Loots = new List<RoverRogueGainEntry>(this.CachedLootInfoList);
			roverlikeLootViewOpenParam.EnableUse = new bool?(!flag);
			List<int> equippedLootIds;
			if (num <= 0)
			{
				equippedLootIds = new List<int>();
			}
			else
			{
				(equippedLootIds = new List<int>()).Add(num);
			}
			roverlikeLootViewOpenParam.EquippedLootIds = equippedLootIds;
			IRoverlikeLootViewOpenParam param = roverlikeLootViewOpenParam;
			UiManager.Instance.OpenView(EUiViewName.RoverlikeLootView, param, null);
		}

		// Token: 0x0603388C RID: 211084 RVA: 0x00E6E75C File Offset: 0x00E6C95C
		[NullableContext(1)]
		public void OpenRoverRogueLootSelectView(int defaultLootId, Action<int, int> onConfirm)
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
			int num = (roverlikeActivityData != null) ? roverlikeActivityData.GetEquippedLootId() : 0;
			RoverlikeLootViewOpenParam roverlikeLootViewOpenParam = new RoverlikeLootViewOpenParam();
			roverlikeLootViewOpenParam.IsInGame = false;
			roverlikeLootViewOpenParam.Loots = new List<RoverRogueGainEntry>(this.CachedLootInfoList);
			roverlikeLootViewOpenParam.EnableUse = new bool?(true);
			List<int> equippedLootIds;
			if (num <= 0)
			{
				equippedLootIds = new List<int>();
			}
			else
			{
				(equippedLootIds = new List<int>()).Add(num);
			}
			roverlikeLootViewOpenParam.EquippedLootIds = equippedLootIds;
			roverlikeLootViewOpenParam.DefaultSelectedLootId = defaultLootId;
			roverlikeLootViewOpenParam.OnConfirmSelect = onConfirm;
			IRoverlikeLootViewOpenParam param = roverlikeLootViewOpenParam;
			UiManager.Instance.OpenView(EUiViewName.RoverlikeLootView, param, null);
		}

		// Token: 0x0603388D RID: 211085 RVA: 0x00E6E7ED File Offset: 0x00E6C9ED
		public void OpenGameInfoView(EUiTabViewName? viewName = null)
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikeDetailView, viewName, null);
		}

		// Token: 0x0603388E RID: 211086 RVA: 0x00E6E808 File Offset: 0x00E6CA08
		private void AddMainViewSplashTask()
		{
			SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
			{
				RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
				if (currentActivityData == null)
				{
					SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.None);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.RoverlikeMainView, currentActivityData, null);
			});
			SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
		}

		// Token: 0x0603388F RID: 211087 RVA: 0x00E6E848 File Offset: 0x00E6CA48
		public void RequestInsList(Action callback = null)
		{
			RoverlikeController.<>c__DisplayClass45_0 CS$<>8__locals1 = new RoverlikeController.<>c__DisplayClass45_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			RoverlikeController.<>c__DisplayClass45_0 CS$<>8__locals2 = CS$<>8__locals1;
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			CS$<>8__locals2.activityData = ((instance != null) ? instance.GetCurrentActivityData() : null);
			if (CS$<>8__locals1.activityData == null)
			{
				return;
			}
			int id = CS$<>8__locals1.activityData.Id;
			RoverRogueInsListRequest roverRogueInsListRequest = RoverRogueInsListRequest.Create();
			roverRogueInsListRequest.ActivityId = id;
			Net.Instance.Call(ERequestMessageId.RoverRogueInsListRequest, roverRogueInsListRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoverRogueInsListResponse roverRogueInsListResponse = (RoverRogueInsListResponse)msg;
				if (roverRogueInsListResponse == null)
				{
					return;
				}
				if (roverRogueInsListResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueInsListResponse.ErrorCode, EResponseMessageId.RoverRogueInsListResponse, null, true, true);
					return;
				}
				CS$<>8__locals1.<>4__this.HandleInsListResponse(CS$<>8__locals1.activityData, roverRogueInsListResponse, CS$<>8__locals1.callback);
			}, 0);
		}

		// Token: 0x06033890 RID: 211088 RVA: 0x00E6E8C0 File Offset: 0x00E6CAC0
		[NullableContext(1)]
		private void HandleInsListResponse(RoverlikeActivityData activityData, RoverRogueInsListResponse response, [Nullable(2)] Action callback = null)
		{
			if (response.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, EResponseMessageId.RoverRogueInsListResponse, null, true, true);
				return;
			}
			activityData.LevelSelectData.UpdateEntries(response.List);
			activityData.RefreshNewLevelUnlockRedDot();
			if (callback != null)
			{
				callback();
			}
		}

		// Token: 0x06033891 RID: 211089 RVA: 0x00E6E910 File Offset: 0x00E6CB10
		public void RequestUnlockTalentNode(int talentHeadId, Action callback = null)
		{
			RoverlikeController.<>c__DisplayClass47_0 CS$<>8__locals1 = new RoverlikeController.<>c__DisplayClass47_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.talentHeadId = talentHeadId;
			CS$<>8__locals1.callback = callback;
			RoverlikeController.<>c__DisplayClass47_0 CS$<>8__locals2 = CS$<>8__locals1;
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			CS$<>8__locals2.activityData = ((instance != null) ? instance.GetCurrentActivityData() : null);
			if (CS$<>8__locals1.activityData == null)
			{
				return;
			}
			RoverlikeTalentNodeData nodeData = CS$<>8__locals1.activityData.TalentTreeData.GetNodeData(CS$<>8__locals1.talentHeadId);
			if (nodeData == null)
			{
				return;
			}
			if (!CS$<>8__locals1.activityData.TalentTreeData.IsTalentCanUnlock(nodeData))
			{
				return;
			}
			int nextLevelId = nodeData.NextLevelId;
			if (nextLevelId <= 0)
			{
				return;
			}
			int id = CS$<>8__locals1.activityData.Id;
			RoverRogueTalentUnlockRequest roverRogueTalentUnlockRequest = RoverRogueTalentUnlockRequest.Create();
			roverRogueTalentUnlockRequest.ActivityId = id;
			roverRogueTalentUnlockRequest.TalentId = nextLevelId;
			Net.Instance.Call(ERequestMessageId.RoverRogueTalentUnlockRequest, roverRogueTalentUnlockRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoverRogueTalentUnlockResponse roverRogueTalentUnlockResponse = (RoverRogueTalentUnlockResponse)msg;
				if (roverRogueTalentUnlockResponse == null)
				{
					return;
				}
				if (roverRogueTalentUnlockResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueTalentUnlockResponse.ErrorCode, EResponseMessageId.RoverRogueTalentUnlockResponse, null, true, true);
					return;
				}
				CS$<>8__locals1.<>4__this.HandleTalentUnlockResponse(CS$<>8__locals1.activityData, roverRogueTalentUnlockResponse, CS$<>8__locals1.talentHeadId, CS$<>8__locals1.callback);
			}, 0);
		}

		// Token: 0x06033892 RID: 211090 RVA: 0x00E6E9D4 File Offset: 0x00E6CBD4
		[NullableContext(1)]
		private void HandleTalentUnlockResponse(RoverlikeActivityData activityData, RoverRogueTalentUnlockResponse response, int talentHeadId, [Nullable(2)] Action callback = null)
		{
			if (response.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, EResponseMessageId.RoverRogueTalentUnlockResponse, null, true, true);
				return;
			}
			if (!activityData.TalentTreeData.LocalUnlockNextTalentLevel(talentHeadId))
			{
				return;
			}
			if (callback != null)
			{
				callback();
			}
		}

		// Token: 0x06033893 RID: 211091 RVA: 0x00E6EA14 File Offset: 0x00E6CC14
		public void RoverRogueStartRequest(int instId, int roleId, int roleType, bool continueLastProgress, int lootId, Action<bool> callback = null)
		{
			RoverRogueInsCtx roverRogueInsCtx = new RoverRogueInsCtx();
			roverRogueInsCtx.RoverId = roleId;
			roverRogueInsCtx.ContinueLastProgress = continueLastProgress;
			RepeatedField<int> equippedLootIds = roverRogueInsCtx.EquippedLootIds;
			List<int> values;
			if (lootId <= 0)
			{
				values = new List<int>();
			}
			else
			{
				(values = new List<int>()).Add(lootId);
			}
			equippedLootIds.AddRange(values);
			roverRogueInsCtx.RoverRoleType = roleType;
			InstanceDungeonModel.Instance.InstanceContinue = continueLastProgress;
			InstanceDungeonModel.Instance.InstanceEnterContentText.RoverRogueInsCtx = roverRogueInsCtx;
			InstanceDungeonController.Instance.PrewarTeamFightRequest(instId, new List<int>
			{
				roleId
			}, 0, 0, null, null).ContinueWith(delegate(bool success)
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(success);
			}).Forget();
		}

		// Token: 0x06033894 RID: 211092 RVA: 0x00E6EABC File Offset: 0x00E6CCBC
		public void RoverRogueReChallengeRequest(int instId, Action<bool> callback = null)
		{
			int mainRoleId = RoverlikeModel.Instance.GetMainRoleId();
			this.RoverRogueStartRequest(instId, mainRoleId, 0, true, 0, callback);
		}

		// Token: 0x06033895 RID: 211093 RVA: 0x00E6EAE0 File Offset: 0x00E6CCE0
		public void RoverRogueQuitRequest(int activityId, Action<bool> callback = null)
		{
			RoverRogueQuitRequest roverRogueQuitRequest = Aki.Protocol.RoverRogueQuitRequest.Create();
			roverRogueQuitRequest.ActivityId = activityId;
			Net.Instance.Call(ERequestMessageId.RoverRogueQuitRequest, roverRogueQuitRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoverRogueQuitResponse roverRogueQuitResponse = (RoverRogueQuitResponse)msg;
				if (roverRogueQuitResponse == null)
				{
					return;
				}
				if (roverRogueQuitResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueQuitResponse.ErrorCode, EResponseMessageId.RoverRogueQuitResponse, null, true, true);
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					this.ClearRoverRogueInstance();
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 0);
		}

		// Token: 0x06033896 RID: 211094 RVA: 0x00E6EB2C File Offset: 0x00E6CD2C
		public void RoverRogueResultRequest(int activityId, int instId, Action<bool> callback = null)
		{
			RoverRogueResultRequest roverRogueResultRequest = Aki.Protocol.RoverRogueResultRequest.Create();
			roverRogueResultRequest.ActivityId = activityId;
			roverRogueResultRequest.InstId = instId;
			Net.Instance.Call(ERequestMessageId.RoverRogueResultRequest, roverRogueResultRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoverRogueResultResponse roverRogueResultResponse = (RoverRogueResultResponse)msg;
				if (roverRogueResultResponse == null)
				{
					return;
				}
				if (roverRogueResultResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueResultResponse.ErrorCode, EResponseMessageId.RoverRogueResultResponse, null, true, true);
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					RoverRogueResultInfo roverRogueResultInfo = (roverRogueResultResponse != null) ? roverRogueResultResponse.ResultInfo : null;
					if (roverRogueResultInfo != null && !this.TryExitRoverRogueWithoutResultView(roverRogueResultInfo))
					{
						Action<bool> callback3 = callback;
						if (callback3 != null)
						{
							callback3(true);
						}
						UiManager.Instance.OpenView(EUiViewName.RoverlikeResultView, roverRogueResultInfo, null);
						return;
					}
					Action<bool> callback4 = callback;
					if (callback4 == null)
					{
						return;
					}
					callback4(false);
					return;
				}
			}, 0);
		}

		// Token: 0x06033897 RID: 211095 RVA: 0x00E6EB80 File Offset: 0x00E6CD80
		public void RoverRogueExitRequest()
		{
			if (!this.CheckInRoverlike())
			{
				UiManager.Instance.CloseView(EUiViewName.RoverlikeResultView, null);
				this.ClearRoverRogueInstance();
				return;
			}
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().ContinueWith(delegate(bool _)
			{
				this.ClearRoverRogueInstance();
			}).Forget();
		}

		// Token: 0x06033898 RID: 211096 RVA: 0x00E6EBCC File Offset: 0x00E6CDCC
		private void OnRoverRogueShopUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueShopSnapshot snapshot = ((RoverRogueShopUpdateNotify)msg).Snapshot;
			if (snapshot == null)
			{
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.RoverlikeGameShopView))
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RoverlikeGameShopView, snapshot, null);
		}

		// Token: 0x06033899 RID: 211097 RVA: 0x00E6EC0C File Offset: 0x00E6CE0C
		private void OnRoverRogueShopInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueShopSnapshot snapshot = ((RoverRogueShopInfoUpdateNotify)msg).Snapshot;
			if (snapshot == null)
			{
				return;
			}
			EventSystem.Instance.Emit<RoverRogueShopSnapshot>(EEventName.RoverlikeShopInfoUpdate, snapshot);
		}

		// Token: 0x0603389A RID: 211098 RVA: 0x00E6EC3C File Offset: 0x00E6CE3C
		private void OnRoverRogueGainGetOrLoseNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueGainGetOrLoseNotify roverRogueGainGetOrLoseNotify = (RoverRogueGainGetOrLoseNotify)msg;
			bool flag = false;
			foreach (RoverRogueGetOrLoseData roverRogueGetOrLoseData in roverRogueGainGetOrLoseNotify.Data)
			{
				int effectId = roverRogueGetOrLoseData.EffectId;
				bool flag2 = true;
				if (effectId > 0)
				{
					RoverRogueEffect? effectConfig = RoverlikeConfig.Instance.GetEffectConfig(effectId);
					if (effectConfig == null || !effectConfig.Value.ClientDisplay)
					{
						continue;
					}
					string type = effectConfig.Value.Type;
					RoverlikeActivityController instance = RoverlikeActivityController.Instance;
					RoverRogueActivity? roverRogueActivity;
					if (instance == null)
					{
						roverRogueActivity = null;
					}
					else
					{
						RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
						roverRogueActivity = ((currentActivityData != null) ? currentActivityData.GetParamConfig() : null);
					}
					RoverRogueActivity? roverRogueActivity2 = roverRogueActivity;
					if (roverRogueActivity2 != null)
					{
						flag2 = (Array.IndexOf<string>(roverRogueActivity2.Value.IgnoreLoseEffectType(), type) < 0);
					}
				}
				if (flag2 && this.PushObtainIfAny(roverRogueGetOrLoseData.RoverRogueGainEntryIncIdLose, true))
				{
					flag = true;
				}
				if (this.PushObtainIfAny(roverRogueGetOrLoseData.RoverRogueGainEntryIncIdGet, false))
				{
					flag = true;
				}
			}
			if (!flag)
			{
				return;
			}
			this.OpenRoverlikeGeneralObtainViewIfNeeded();
		}

		// Token: 0x0603389B RID: 211099 RVA: 0x00E6ED68 File Offset: 0x00E6CF68
		[NullableContext(1)]
		public void OpenRoverlikeGeneralObtainView(IRoverlikeGeneralObtainParam param)
		{
			if (!this.PushObtainParam(param))
			{
				return;
			}
			this.OpenRoverlikeGeneralObtainViewIfNeeded();
		}

		// Token: 0x0603389C RID: 211100 RVA: 0x00E6ED7A File Offset: 0x00E6CF7A
		private void OpenRoverlikeGeneralObtainViewIfNeeded()
		{
			if (!UiManager.Instance.IsViewOpen(EUiViewName.RoverlikeGeneralObtainView))
			{
				UiManager.Instance.OpenView(EUiViewName.RoverlikeGeneralObtainView, null, null);
			}
		}

		// Token: 0x0603389D RID: 211101 RVA: 0x00E6EDA0 File Offset: 0x00E6CFA0
		[NullableContext(1)]
		private bool PushObtainParam(IRoverlikeGeneralObtainParam param)
		{
			RoverlikeActionData actionData = RoverlikeModel.Instance.ActionData;
			if (actionData == null)
			{
				return false;
			}
			if (param.Entries.Count == 0)
			{
				Log.Instance.Error(ELogModule.Roverlike, ELogAuthor.YYZ, "[俯视角肉鸽] 打开通用获得界面失败，Entries为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			IRoverlikeGeneralObtainParam param2 = new RoverlikeGeneralObtainParam
			{
				Entries = new List<RoverlikeGainEntry>(param.Entries),
				IsLose = param.IsLose
			};
			actionData.PushObtainParam(param2);
			return true;
		}

		// Token: 0x0603389E RID: 211102 RVA: 0x00E6EE18 File Offset: 0x00E6D018
		[NullableContext(1)]
		private bool PushObtainIfAny(IList<RoverRogueGainEntry> protoEntries, bool isLose)
		{
			if (protoEntries == null || protoEntries.Count == 0)
			{
				return false;
			}
			List<RoverlikeGainEntry> list = new List<RoverlikeGainEntry>();
			foreach (RoverRogueGainEntry proto in protoEntries)
			{
				list.Add(new RoverlikeGainEntry(proto));
			}
			IRoverlikeGeneralObtainParam param = new RoverlikeGeneralObtainParam
			{
				Entries = list,
				IsLose = isLose
			};
			return this.PushObtainParam(param);
		}

		// Token: 0x0603389F RID: 211103 RVA: 0x00E6EE94 File Offset: 0x00E6D094
		private void OnRoverRogueBlessGroupSelectNotify(IMessage msg, Net.CallbackStatus _)
		{
			RepeatedField<RoverRogueBlessGroupData> blessGroupData = ((RoverRogueBlessGroupSelectNotify)msg).BlessGroupData;
			List<IRoverlikeBlessingSuitData> list = new List<IRoverlikeBlessingSuitData>();
			if (blessGroupData != null)
			{
				foreach (RoverRogueBlessGroupData roverRogueBlessGroupData in blessGroupData)
				{
					IRoverlikeBlessingSuitData item = new RoverlikeBlessingSuitData
					{
						SuitId = roverRogueBlessGroupData.BlessGroupId,
						BlessingIdList = ((roverRogueBlessGroupData.BlessIdList != null) ? new List<int>(roverRogueBlessGroupData.BlessIdList) : new List<int>())
					};
					list.Add(item);
				}
			}
			this.OpenActionSubView(ERoverActionSubViewType.BlessingSuitPreview, list);
		}

		// Token: 0x060338A0 RID: 211104 RVA: 0x00E6EF30 File Offset: 0x00E6D130
		private void OnRoverRogueChooseDataNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueChooseDataNotify roverRogueChooseDataNotify = (RoverRogueChooseDataNotify)msg;
			if (roverRogueChooseDataNotify.ChooseData == null)
			{
				return;
			}
			if (RoverlikeModel.Instance.ActionData == null)
			{
				return;
			}
			RoverlikeModel.Instance.ActionData.SetChooseData(roverRogueChooseDataNotify.ChooseData);
		}

		// Token: 0x060338A1 RID: 211105 RVA: 0x00E6EF70 File Offset: 0x00E6D170
		private void OnRoverRogueEventNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueEventNotify roverRogueEventNotify = (RoverRogueEventNotify)msg;
			IRoverlikeEventOpenParam openParam = new RoverlikeEventOpenParam
			{
				EventIncId = roverRogueEventNotify.EventIncId,
				ChoiceList = ((roverRogueEventNotify.ChoiceList != null) ? new List<int>(roverRogueEventNotify.ChoiceList) : new List<int>())
			};
			this.OpenActionSubView(ERoverActionSubViewType.SelectEvent, openParam);
		}

		// Token: 0x060338A2 RID: 211106 RVA: 0x00E6EFC0 File Offset: 0x00E6D1C0
		private void OnRoverRogueUpdateReviveTimesNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueUpdateReviveTimesNotify roverRogueUpdateReviveTimesNotify = (RoverRogueUpdateReviveTimesNotify)msg;
			RoverlikeModel.Instance.UpdateReviveTimes(roverRogueUpdateReviveTimesNotify.ReviveTimes, roverRogueUpdateReviveTimesNotify.ReviveTimesMax);
			EventSystem.Instance.Emit<int, int>(EEventName.RoverlikeReviveTimesUpdate, roverRogueUpdateReviveTimesNotify.ReviveTimes, roverRogueUpdateReviveTimesNotify.ReviveTimesMax);
		}

		// Token: 0x060338A3 RID: 211107 RVA: 0x00E6F008 File Offset: 0x00E6D208
		public void RoverRogueChooseDataResultRequest(int bindId, int incId, Action<bool> callback = null)
		{
			RoverlikeActionData actionData = RoverlikeModel.Instance.ActionData;
			if (actionData != null)
			{
				RoverRogueChooseDataResultRequest roverRogueChooseDataResultRequest = Aki.Protocol.RoverRogueChooseDataResultRequest.Create();
				roverRogueChooseDataResultRequest.BindId = bindId;
				roverRogueChooseDataResultRequest.IncId = incId;
				Net.Instance.Call(ERequestMessageId.RoverRogueChooseDataResultRequest, roverRogueChooseDataResultRequest, delegate(IMessage msg, Net.CallbackStatus _)
				{
					RoverRogueChooseDataResultResponse roverRogueChooseDataResultResponse = (RoverRogueChooseDataResultResponse)msg;
					if (roverRogueChooseDataResultResponse == null)
					{
						return;
					}
					if (roverRogueChooseDataResultResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueChooseDataResultResponse.ErrorCode, EResponseMessageId.RoverRogueChooseDataResultResponse, null, true, true);
						Action<bool> callback3 = callback;
						if (callback3 == null)
						{
							return;
						}
						callback3(false);
						return;
					}
					else
					{
						actionData.RemoveChooseData(bindId);
						Action<bool> callback4 = callback;
						if (callback4 == null)
						{
							return;
						}
						callback4(true);
						return;
					}
				}, 0);
				return;
			}
			Action<bool> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(false);
		}

		// Token: 0x060338A4 RID: 211108 RVA: 0x00E6F08C File Offset: 0x00E6D28C
		public void RoverRogueRefreshGainRequest(int bindId, Action<bool> callback = null)
		{
			RoverlikeActionData actionData = RoverlikeModel.Instance.ActionData;
			if (actionData != null)
			{
				RoverRogueRefreshGainRequest roverRogueRefreshGainRequest = Aki.Protocol.RoverRogueRefreshGainRequest.Create();
				roverRogueRefreshGainRequest.BindId = bindId;
				Net.Instance.Call(ERequestMessageId.RoverRogueRefreshGainRequest, roverRogueRefreshGainRequest, delegate(IMessage msg, Net.CallbackStatus _)
				{
					RoverRogueRefreshGainResponse roverRogueRefreshGainResponse = (RoverRogueRefreshGainResponse)msg;
					if (roverRogueRefreshGainResponse == null)
					{
						return;
					}
					if (roverRogueRefreshGainResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
					{
						if (roverRogueRefreshGainResponse.ChooseData != null)
						{
							actionData.SetChooseData(roverRogueRefreshGainResponse.ChooseData);
						}
						Action<bool> callback3 = callback;
						if (callback3 != null)
						{
							callback3(true);
						}
						ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_RefreshSuccess", Array.Empty<object>());
						return;
					}
					ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueRefreshGainResponse.ErrorCode, EResponseMessageId.RoverRogueRefreshGainResponse, null, true, true);
					Action<bool> callback4 = callback;
					if (callback4 == null)
					{
						return;
					}
					callback4(false);
				}, 0);
				return;
			}
			Action<bool> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(false);
		}

		// Token: 0x060338A5 RID: 211109 RVA: 0x00E6F0FC File Offset: 0x00E6D2FC
		public void RoverRogueGiveUpGainRequest(int bindId, Action<bool> callback = null)
		{
			RoverlikeActionData actionData = RoverlikeModel.Instance.ActionData;
			if (actionData != null)
			{
				RoverRogueGiveUpGainRequest roverRogueGiveUpGainRequest = Aki.Protocol.RoverRogueGiveUpGainRequest.Create();
				roverRogueGiveUpGainRequest.BindId = bindId;
				Net.Instance.Call(ERequestMessageId.RoverRogueGiveUpGainRequest, roverRogueGiveUpGainRequest, delegate(IMessage msg, Net.CallbackStatus _)
				{
					RoverRogueGiveUpGainResponse roverRogueGiveUpGainResponse = (RoverRogueGiveUpGainResponse)msg;
					if (roverRogueGiveUpGainResponse == null)
					{
						return;
					}
					if (roverRogueGiveUpGainResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueGiveUpGainResponse.ErrorCode, EResponseMessageId.RoverRogueGiveUpGainResponse, null, true, true);
						Action<bool> callback3 = callback;
						if (callback3 == null)
						{
							return;
						}
						callback3(false);
						return;
					}
					else
					{
						actionData.RemoveChooseData(bindId);
						Action<bool> callback4 = callback;
						if (callback4 == null)
						{
							return;
						}
						callback4(true);
						return;
					}
				}, 0);
				return;
			}
			Action<bool> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(false);
		}

		// Token: 0x060338A6 RID: 211110 RVA: 0x00E6F178 File Offset: 0x00E6D378
		public void RoverRogueShopBuyRequest(int activityId, int goodIncId, Action<bool> callback = null)
		{
			RoverRogueShopBuyRequest roverRogueShopBuyRequest = Aki.Protocol.RoverRogueShopBuyRequest.Create();
			roverRogueShopBuyRequest.ActivityId = activityId;
			roverRogueShopBuyRequest.GoodIncId = goodIncId;
			Net.Instance.Call(ERequestMessageId.RoverRogueShopBuyRequest, roverRogueShopBuyRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoverRogueShopBuyResponse roverRogueShopBuyResponse = (RoverRogueShopBuyResponse)msg;
				if (roverRogueShopBuyResponse == null)
				{
					return;
				}
				if (roverRogueShopBuyResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueShopBuyResponse.ErrorCode, EResponseMessageId.RoverRogueShopBuyResponse, null, true, true);
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 0);
		}

		// Token: 0x060338A7 RID: 211111 RVA: 0x00E6F1C4 File Offset: 0x00E6D3C4
		public void RoverRogueShopRefreshRequest(int activityId, Action<RoverRogueShopSnapshot> callback = null)
		{
			RoverRogueShopRefreshRequest roverRogueShopRefreshRequest = Aki.Protocol.RoverRogueShopRefreshRequest.Create();
			roverRogueShopRefreshRequest.ActivityId = activityId;
			Net.Instance.Call(ERequestMessageId.RoverRogueShopRefreshRequest, roverRogueShopRefreshRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoverRogueShopRefreshResponse roverRogueShopRefreshResponse = (RoverRogueShopRefreshResponse)msg;
				if (roverRogueShopRefreshResponse == null)
				{
					return;
				}
				if (roverRogueShopRefreshResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
				{
					Action<RoverRogueShopSnapshot> callback2 = callback;
					if (callback2 != null)
					{
						callback2(roverRogueShopRefreshResponse.Snapshot);
					}
					ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_RefreshSuccess", Array.Empty<object>());
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueShopRefreshResponse.ErrorCode, EResponseMessageId.RoverRogueShopRefreshResponse, null, true, true);
				Action<RoverRogueShopSnapshot> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(null);
			}, 0);
		}

		// Token: 0x060338A8 RID: 211112 RVA: 0x00E6F208 File Offset: 0x00E6D408
		public void RoverRogueBlessGroupSelectRequest(int activityId, int blessGroupId, Action<bool> callback = null)
		{
			RoverRogueBlessGroupSelectRequest roverRogueBlessGroupSelectRequest = Aki.Protocol.RoverRogueBlessGroupSelectRequest.Create();
			roverRogueBlessGroupSelectRequest.ActivityId = activityId;
			roverRogueBlessGroupSelectRequest.BlessGroupId = blessGroupId;
			Net.Instance.Call(ERequestMessageId.RoverRogueBlessGroupSelectRequest, roverRogueBlessGroupSelectRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoverRogueBlessGroupSelectResponse roverRogueBlessGroupSelectResponse = (RoverRogueBlessGroupSelectResponse)msg;
				if (roverRogueBlessGroupSelectResponse == null)
				{
					return;
				}
				if (roverRogueBlessGroupSelectResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueBlessGroupSelectResponse.ErrorCode, EResponseMessageId.RoverRogueBlessGroupSelectResponse, null, true, true);
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 0);
		}

		// Token: 0x060338A9 RID: 211113 RVA: 0x00E6F254 File Offset: 0x00E6D454
		public void RoverRogueEventSelectRequest(int eventIncId, int choiceId, Action<bool> callback = null)
		{
			RoverRogueEventSelectRequest roverRogueEventSelectRequest = Aki.Protocol.RoverRogueEventSelectRequest.Create();
			roverRogueEventSelectRequest.EventIncId = eventIncId;
			roverRogueEventSelectRequest.ChoiceId = choiceId;
			Net.Instance.Call(ERequestMessageId.RoverRogueEventSelectRequest, roverRogueEventSelectRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoverRogueEventSelectResponse roverRogueEventSelectResponse = (RoverRogueEventSelectResponse)msg;
				if (roverRogueEventSelectResponse == null)
				{
					return;
				}
				if (roverRogueEventSelectResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueEventSelectResponse.ErrorCode, EResponseMessageId.RoverRogueEventSelectResponse, null, true, true);
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 0);
		}

		// Token: 0x060338AA RID: 211114 RVA: 0x00E6F2A0 File Offset: 0x00E6D4A0
		private void OnRoverRogueLootChangeNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueLootChangeNotify roverRogueLootChangeNotify = (RoverRogueLootChangeNotify)msg;
			List<int> list = new List<int>();
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			foreach (RoverlikeLootGainEntry roverlikeLootGainEntry in (((instanceData != null) ? instanceData.GetLootItemList() : null) ?? new List<RoverlikeLootGainEntry>()))
			{
				list.Add(roverlikeLootGainEntry.ConfigId);
			}
			IRoverlikeLootViewOpenParam param = new RoverlikeLootViewOpenParam
			{
				IsInGame = true,
				Loots = new List<RoverRogueGainEntry>(roverRogueLootChangeNotify.LootData),
				EnableUse = new bool?(roverRogueLootChangeNotify.EnableUse),
				EquippedLootIds = list,
				DefaultSelectedLootId = ((list.Count > 0) ? list[0] : 0)
			};
			UiManager.Instance.OpenView(EUiViewName.RoverlikeLootView, param, null);
		}

		// Token: 0x060338AB RID: 211115 RVA: 0x00E6F380 File Offset: 0x00E6D580
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private UniTask<List<RoverRogueGainEntry>> RefreshLootInfoCacheAsync()
		{
			RoverlikeController.<RefreshLootInfoCacheAsync>d__73 <RefreshLootInfoCacheAsync>d__;
			<RefreshLootInfoCacheAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<RoverRogueGainEntry>>.Create();
			<RefreshLootInfoCacheAsync>d__.<>4__this = this;
			<RefreshLootInfoCacheAsync>d__.<>1__state = -1;
			<RefreshLootInfoCacheAsync>d__.<>t__builder.Start<RoverlikeController.<RefreshLootInfoCacheAsync>d__73>(ref <RefreshLootInfoCacheAsync>d__);
			return <RefreshLootInfoCacheAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060338AC RID: 211116 RVA: 0x00E6F3C4 File Offset: 0x00E6D5C4
		public int GetEquippedLootLevel()
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
			int num = (roverlikeActivityData != null) ? roverlikeActivityData.GetEquippedLootId() : 0;
			if (num <= 0)
			{
				return 0;
			}
			RoverRogueGainEntry roverRogueGainEntry = null;
			foreach (RoverRogueGainEntry roverRogueGainEntry2 in this.CachedLootInfoList)
			{
				if (roverRogueGainEntry2.ConfigId == num)
				{
					roverRogueGainEntry = roverRogueGainEntry2;
					break;
				}
			}
			int? num2;
			if (roverRogueGainEntry == null)
			{
				num2 = null;
			}
			else
			{
				RoverRogueLootInfo lootInfo = roverRogueGainEntry.LootInfo;
				num2 = ((lootInfo != null) ? new int?(lootInfo.LootLv) : null);
			}
			int? num3 = num2;
			return num3.GetValueOrDefault();
		}

		// Token: 0x060338AD RID: 211117 RVA: 0x00E6F47C File Offset: 0x00E6D67C
		[NullableContext(1)]
		private List<RoverRogueGainEntry> MergeLootWithConfig(IReadOnlyList<RoverRogueGainEntry> serverLoots)
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				num = ((currentActivityData != null) ? new int?(currentActivityData.Id) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			IReadOnlyList<RoverRogueLoot> lootConfigListByActivityId = RoverlikeConfig.Instance.GetLootConfigListByActivityId(valueOrDefault);
			if (lootConfigListByActivityId.Count == 0)
			{
				return new List<RoverRogueGainEntry>(serverLoots);
			}
			Dictionary<int, RoverRogueGainEntry> dictionary = new Dictionary<int, RoverRogueGainEntry>();
			foreach (RoverRogueGainEntry roverRogueGainEntry in serverLoots)
			{
				dictionary[roverRogueGainEntry.ConfigId] = roverRogueGainEntry;
			}
			List<RoverRogueGainEntry> list = new List<RoverRogueGainEntry>();
			foreach (RoverRogueLoot roverRogueLoot in lootConfigListByActivityId)
			{
				RoverRogueGainEntry roverRogueGainEntry2;
				list.Add(dictionary.TryGetValue(roverRogueLoot.Id, out roverRogueGainEntry2) ? roverRogueGainEntry2 : this.CreateLockedLootEntry(roverRogueLoot.Id));
			}
			return list;
		}

		// Token: 0x060338AE RID: 211118 RVA: 0x00E6F598 File Offset: 0x00E6D798
		[NullableContext(1)]
		private RoverRogueGainEntry CreateLockedLootEntry(int configId)
		{
			RoverRogueGainEntry roverRogueGainEntry = RoverRogueGainEntry.Create();
			roverRogueGainEntry.Type = RoverRogueGainDataType.RoverRogueGainLootItem;
			roverRogueGainEntry.ConfigId = configId;
			roverRogueGainEntry.LootInfo = RoverRogueLootInfo.Create();
			roverRogueGainEntry.LootInfo.Unlock = false;
			return roverRogueGainEntry;
		}

		// Token: 0x060338AF RID: 211119 RVA: 0x00E6F5C4 File Offset: 0x00E6D7C4
		public void RoverRogueLootChangeRequest(int lootId, Action<bool> callback = null)
		{
			RoverRogueLootChangeRequest roverRogueLootChangeRequest = Aki.Protocol.RoverRogueLootChangeRequest.Create();
			roverRogueLootChangeRequest.ActivityId = RoverlikeActivityController.Instance.GetCurrentActivityData().Id;
			roverRogueLootChangeRequest.LootId = lootId;
			Net.Instance.Call(ERequestMessageId.RoverRogueLootChangeRequest, roverRogueLootChangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoverRogueLootChangeResponse roverRogueLootChangeResponse = (RoverRogueLootChangeResponse)msg;
				if (roverRogueLootChangeResponse == null)
				{
					return;
				}
				if (roverRogueLootChangeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueLootChangeResponse.ErrorCode, EResponseMessageId.RoverRogueLootChangeResponse, null, true, true);
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 0);
		}

		// Token: 0x060338B0 RID: 211120 RVA: 0x00E6F620 File Offset: 0x00E6D820
		public void RoverRogueOutGameLootChangeRequest(int lootId, int lootLv, Action<bool> callback = null)
		{
			this.RoverRogueLootChangeRequest(lootId, delegate(bool success)
			{
				if (success)
				{
					RoverlikeActivityController instance = RoverlikeActivityController.Instance;
					RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
					if (roverlikeActivityData != null)
					{
						roverlikeActivityData.SetEquippedLoot(lootId);
					}
					if (((roverlikeActivityData != null) ? roverlikeActivityData.LevelSelectData : null) != null)
					{
						roverlikeActivityData.LevelSelectData.SelectedLootLv = lootLv;
					}
				}
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(success);
			});
		}

		// Token: 0x060338B1 RID: 211121 RVA: 0x00E6F660 File Offset: 0x00E6D860
		public void UpdateActionSubView(int incId)
		{
			RoverlikeActionSubViewManager actionSubViewManager = RoverlikeModel.Instance.ActionSubViewManager;
			if (actionSubViewManager == null)
			{
				Log.Instance.Error(ELogModule.Roverlike, ELogAuthor.YYZ, "[俯视角肉鸽] ActionSubViewManager不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			RoverlikeActionSubViewBase subViewByIncId = actionSubViewManager.GetSubViewByIncId(incId);
			if (subViewByIncId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Roverlike;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[俯视角肉鸽] ActionSubView不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			subViewByIncId.OnRefreshSubView();
		}

		// Token: 0x060338B2 RID: 211122 RVA: 0x00E6F6DC File Offset: 0x00E6D8DC
		public int OpenActionSubView(ERoverActionSubViewType type, object openParam = null)
		{
			RoverlikeActionSubViewManager actionSubViewManager = RoverlikeModel.Instance.ActionSubViewManager;
			if (actionSubViewManager == null || actionSubViewManager.IsDisposed)
			{
				Log.Instance.Error(ELogModule.Roverlike, ELogAuthor.YYZ, "[俯视角肉鸽] ActionSubViewManager不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return -1;
			}
			if (!actionSubViewManager.HostReady)
			{
				if (UiManager.Instance.GetViewByName(EUiViewName.RoverlikeGeneralActionView) != null)
				{
					UiManager.Instance.CloseAndOpenView(EUiViewName.RoverlikeGeneralActionView, EUiViewName.RoverlikeGeneralActionView, null, null, true);
				}
				else
				{
					UiManager.Instance.OpenView(EUiViewName.RoverlikeGeneralActionView, null, null);
				}
			}
			return actionSubViewManager.AddSubView(type, openParam);
		}

		// Token: 0x060338B3 RID: 211123 RVA: 0x00E6F76B File Offset: 0x00E6D96B
		public void FinishActionSubView(int incId)
		{
			RoverlikeActionSubViewManager actionSubViewManager = RoverlikeModel.Instance.ActionSubViewManager;
			if (actionSubViewManager == null)
			{
				return;
			}
			actionSubViewManager.FinishSubView(incId);
		}

		// Token: 0x060338B4 RID: 211124 RVA: 0x00E6F784 File Offset: 0x00E6D984
		public bool CheckInRoverlike()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				int instanceId = CreatureModel.Instance.GetInstanceId();
				InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
				return config != null && config.Value.InstSubType == 59;
			}
			return false;
		}

		// Token: 0x060338B5 RID: 211125 RVA: 0x00E6F7D4 File Offset: 0x00E6D9D4
		[NullableContext(1)]
		public void RequestTaskRewardTake(List<int> taskIds, [Nullable(2)] Action<bool> callback = null)
		{
			RoverlikeController.<>c__DisplayClass83_0 CS$<>8__locals1 = new RoverlikeController.<>c__DisplayClass83_0();
			CS$<>8__locals1.callback = callback;
			RoverlikeController.<>c__DisplayClass83_0 CS$<>8__locals2 = CS$<>8__locals1;
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			CS$<>8__locals2.activityData = ((instance != null) ? instance.GetCurrentActivityData() : null);
			if (CS$<>8__locals1.activityData == null)
			{
				Action<bool> callback2 = CS$<>8__locals1.callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
				return;
			}
			else
			{
				if (taskIds.Count != 0)
				{
					RoverRogueTaskRewardTakeRequest roverRogueTaskRewardTakeRequest = RoverRogueTaskRewardTakeRequest.Create();
					roverRogueTaskRewardTakeRequest.ActivityId = CS$<>8__locals1.activityData.Id;
					roverRogueTaskRewardTakeRequest.RewardIds.AddRange(taskIds);
					Net.Instance.Call(ERequestMessageId.RoverRogueTaskRewardTakeRequest, roverRogueTaskRewardTakeRequest, delegate(IMessage msg, Net.CallbackStatus _)
					{
						RoverRogueTaskRewardTakeResponse roverRogueTaskRewardTakeResponse = (RoverRogueTaskRewardTakeResponse)msg;
						if (roverRogueTaskRewardTakeResponse == null)
						{
							Action<bool> callback4 = CS$<>8__locals1.callback;
							if (callback4 == null)
							{
								return;
							}
							callback4(false);
							return;
						}
						else if (roverRogueTaskRewardTakeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
						{
							ErrorCodeController.Instance.OpenErrorCodeTipView(roverRogueTaskRewardTakeResponse.ErrorCode, EResponseMessageId.RoverRogueTaskRewardTakeResponse, null, true, true);
							Action<bool> callback5 = CS$<>8__locals1.callback;
							if (callback5 == null)
							{
								return;
							}
							callback5(false);
							return;
						}
						else
						{
							foreach (int taskId in roverRogueTaskRewardTakeResponse.SuccessRewardIds)
							{
								CS$<>8__locals1.activityData.QuestData.MarkTaken(taskId);
							}
							EventSystem.Instance.Emit(EEventName.RoverlikeQuestTaskUpdate);
							EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, CS$<>8__locals1.activityData.Id);
							Action<bool> callback6 = CS$<>8__locals1.callback;
							if (callback6 == null)
							{
								return;
							}
							callback6(true);
							return;
						}
					}, 0);
					return;
				}
				Action<bool> callback3 = CS$<>8__locals1.callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(false);
				return;
			}
		}

		// Token: 0x060338B6 RID: 211126 RVA: 0x00E6F87C File Offset: 0x00E6DA7C
		[NullableContext(1)]
		public void RoleDeathStart(Entity entity)
		{
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			if (component == null || !component.IsRoleAndCtrlByMe)
			{
				return;
			}
			this.IsRoleDeathEnded = false;
			this.ClearDeathAnimTimer();
			this.DeathAnimTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.ClearDeathAnimTimer();
				DeadReviveModel.Instance.BlockAllInput = false;
				InputDistributeController.Instance.RefreshInputTag();
				if (this.CheckInRoverlike())
				{
					this.RoleDeathEnded(entity);
				}
			}, 3000f, null, null, true, 1f);
		}

		// Token: 0x060338B7 RID: 211127 RVA: 0x00E6F8F0 File Offset: 0x00E6DAF0
		private void ClearDeathAnimTimer()
		{
			if (this.DeathAnimTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DeathAnimTimer);
				this.DeathAnimTimer = null;
			}
		}

		// Token: 0x060338B8 RID: 211128 RVA: 0x00E6F914 File Offset: 0x00E6DB14
		[NullableContext(1)]
		public void RoleDeathEnded(Entity entity)
		{
			if (this.IsRoleDeathEnded)
			{
				return;
			}
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			if (component == null || !component.IsRoleAndCtrlByMe)
			{
				return;
			}
			this.IsRoleDeathEnded = true;
			this.ClearDeathAnimTimer();
			bool flag = RoverlikeModel.Instance.ConsumeReviveTimes();
			if (!flag)
			{
				entity.DisableByKey(EEntityDisableKey.RoverlikeDeath, true);
			}
			DeadReviveController.Instance.DoDeadFinish(flag);
		}

		// Token: 0x060338B9 RID: 211129 RVA: 0x00E6F974 File Offset: 0x00E6DB74
		[NullableContext(1)]
		private void OnRevive(Entity entity)
		{
			if (!this.CheckInRoverlike())
			{
				return;
			}
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			if (component != null && component.IsRoleAndCtrlByMe)
			{
				this.IsRoleDeathEnded = false;
				if (entity.HasDisableKey(EEntityDisableKey.RoverlikeDeath))
				{
					entity.EnableByKey(EEntityDisableKey.RoverlikeDeath, true);
				}
				BaseBuffComponent component2 = entity.GetComponent<BaseBuffComponent>();
				if (component2 != null)
				{
					component2.AddBuff(1502000501L, new AddBuffParam
					{
						InstigatorId = component2.CreatureDataId,
						Reason = "Roverlike角色复活效果"
					});
				}
			}
		}

		// Token: 0x170064A6 RID: 25766
		// (get) Token: 0x060338BA RID: 211130 RVA: 0x00E6F9EA File Offset: 0x00E6DBEA
		[Nullable(1)]
		public static RoverlikeController Instance
		{
			[NullableContext(1)]
			get
			{
				return RoverlikeController._Instance;
			}
		}

		// Token: 0x060338BB RID: 211131 RVA: 0x00E6F9F1 File Offset: 0x00E6DBF1
		[NullableContext(1)]
		public static RoverlikeController GetOrCreateInstance()
		{
			if (RoverlikeController._Instance == null)
			{
				RoverlikeController.CreateInstance();
			}
			return RoverlikeController._Instance;
		}

		// Token: 0x060338BC RID: 211132 RVA: 0x00E6FA05 File Offset: 0x00E6DC05
		public static bool CreateInstance()
		{
			if (RoverlikeController._Instance != null)
			{
				return true;
			}
			RoverlikeController._Instance = new RoverlikeController();
			return true;
		}

		// Token: 0x060338BD RID: 211133 RVA: 0x00E6FA1B File Offset: 0x00E6DC1B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060338BE RID: 211134 RVA: 0x00E6FA1D File Offset: 0x00E6DC1D
		public static void ResetStaticDefaultValue()
		{
			RoverlikeController._Instance = null;
		}

		// Token: 0x060338BF RID: 211135 RVA: 0x00E6FA25 File Offset: 0x00E6DC25
		static RoverlikeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoverlikeController.CreateStaticDefaultValue), new Action(RoverlikeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B5B8 RID: 112056
		private const int REVIVE_EFFECT_BUFF_ID = 1502000501;

		// Token: 0x0401B5B9 RID: 112057
		[Nullable(1)]
		private readonly List<int> RoleUnlockQueue = new List<int>();

		// Token: 0x0401B5BA RID: 112058
		private bool IsRoleUnlockShowing;

		// Token: 0x0401B5BB RID: 112059
		[Nullable(1)]
		private readonly HashSet<int> KnownUnlockedLootIds = new HashSet<int>();

		// Token: 0x0401B5BC RID: 112060
		private bool IsLootCacheInited;

		// Token: 0x0401B5BD RID: 112061
		[Nullable(1)]
		private List<RoverRogueGainEntry> PendingUnlockLoots = new List<RoverRogueGainEntry>();

		// Token: 0x0401B5BE RID: 112062
		private bool IsLootUnlockReady;

		// Token: 0x0401B5BF RID: 112063
		[Nullable(1)]
		private List<RoverRogueGainEntry> CachedLootInfoList = new List<RoverRogueGainEntry>();

		// Token: 0x0401B5C0 RID: 112064
		private TimerHandle DeathAnimTimer;

		// Token: 0x0401B5C1 RID: 112065
		private bool IsRoleDeathEnded;

		// Token: 0x0401B5C2 RID: 112066
		private static RoverlikeController _Instance;
	}
}
