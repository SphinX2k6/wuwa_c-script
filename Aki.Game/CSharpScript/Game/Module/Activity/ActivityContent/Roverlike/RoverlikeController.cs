using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020060E6 RID: 24806
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class RoverlikeController : UiControllerBase
	{
		// Token: 0x0603EBA8 RID: 256936 RVA: 0x00F26939 File Offset: 0x00F24B39
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603EBA9 RID: 256937 RVA: 0x00F2693C File Offset: 0x00F24B3C
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

		// Token: 0x0603EBAA RID: 256938 RVA: 0x00F26B0C File Offset: 0x00F24D0C
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

		// Token: 0x0603EBAB RID: 256939 RVA: 0x00F26C19 File Offset: 0x00F24E19
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0603EBAC RID: 256940 RVA: 0x00F26C37 File Offset: 0x00F24E37
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x0603EBAD RID: 256941 RVA: 0x00F26C58 File Offset: 0x00F24E58
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

		// Token: 0x0603EBAE RID: 256942 RVA: 0x00F26C94 File Offset: 0x00F24E94
		protected override bool OnLeaveLevel()
		{
			if (EventSystem.Instance.Has<Entity>(EEventName.OnRevive, new Action<Entity>(this.OnRevive)))
			{
				EventSystem.Instance.Remove<Entity>(EEventName.OnRevive, new Action<Entity>(this.OnRevive));
			}
			this.ClearDeathAnimTimer();
			return true;
		}

		// Token: 0x0603EBAF RID: 256943 RVA: 0x00F26CE1 File Offset: 0x00F24EE1
		private void OnWorldDone()
		{
			if (RoverlikeModel.Instance.NeedOpenMainView)
			{
				this.AddMainViewSplashTask();
			}
		}

		// Token: 0x0603EBB0 RID: 256944 RVA: 0x00F26CF8 File Offset: 0x00F24EF8
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

		// Token: 0x0603EBB1 RID: 256945 RVA: 0x00F26D70 File Offset: 0x00F24F70
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

		// Token: 0x0603EBB2 RID: 256946 RVA: 0x00F26D95 File Offset: 0x00F24F95
		public void PlayRoleUnlockQueue()
		{
			this.TryShowNextRoleUnlock();
		}

		// Token: 0x0603EBB3 RID: 256947 RVA: 0x00F26DA0 File Offset: 0x00F24FA0
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

		// Token: 0x0603EBB4 RID: 256948 RVA: 0x00F26E24 File Offset: 0x00F25024
		private UniTask CacheAndDiffUnlockLoots()
		{
			RoverlikeController.<CacheAndDiffUnlockLoots>d__20 <CacheAndDiffUnlockLoots>d__;
			<CacheAndDiffUnlockLoots>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CacheAndDiffUnlockLoots>d__.<>4__this = this;
			<CacheAndDiffUnlockLoots>d__.<>1__state = -1;
			<CacheAndDiffUnlockLoots>d__.<>t__builder.Start<RoverlikeController.<CacheAndDiffUnlockLoots>d__20>(ref <CacheAndDiffUnlockLoots>d__);
			return <CacheAndDiffUnlockLoots>d__.<>t__builder.Task;
		}

		// Token: 0x0603EBB5 RID: 256949 RVA: 0x00F26E68 File Offset: 0x00F25068
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

		// Token: 0x0603EBB6 RID: 256950 RVA: 0x00F26EC6 File Offset: 0x00F250C6
		private void NotifyUnlockFlowEnd()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeUnlockShowEnd");
		}

		// Token: 0x0603EBB7 RID: 256951 RVA: 0x00F26EE0 File Offset: 0x00F250E0
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

		// Token: 0x0603EBB8 RID: 256952 RVA: 0x00F26F28 File Offset: 0x00F25128
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

		// Token: 0x0603EBB9 RID: 256953 RVA: 0x00F26FD8 File Offset: 0x00F251D8
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

		// Token: 0x0603EBBA RID: 256954 RVA: 0x00F2705C File Offset: 0x00F2525C
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

		// Token: 0x0603EBBB RID: 256955 RVA: 0x00F27150 File Offset: 0x00F25350
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

		// Token: 0x0603EBBC RID: 256956 RVA: 0x00F27228 File Offset: 0x00F25428
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

		// Token: 0x0603EBBD RID: 256957 RVA: 0x00F272D0 File Offset: 0x00F254D0
		private void OnRoverRogueGainDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueGainDataUpdateNotify notify = (RoverRogueGainDataUpdateNotify)msg;
			if (RoverlikeModel.Instance.InstanceData != null)
			{
				RoverlikeModel.Instance.InstanceData.ApplyGainDataUpdate(notify);
			}
		}

		// Token: 0x0603EBBE RID: 256958 RVA: 0x00F27300 File Offset: 0x00F25500
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

		// Token: 0x0603EBBF RID: 256959 RVA: 0x00F2732C File Offset: 0x00F2552C
		[NullableContext(1)]
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			EInputState state = (actionType == InputDistributeDefine.EActionType.Press) ? EInputState.Press : EInputState.Release;
			InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.幻象2, state);
		}

		// Token: 0x0603EBC0 RID: 256960 RVA: 0x00F27354 File Offset: 0x00F25554
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

		// Token: 0x0603EBC1 RID: 256961 RVA: 0x00F275C0 File Offset: 0x00F257C0
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

		// Token: 0x0603EBC2 RID: 256962 RVA: 0x00F2761C File Offset: 0x00F2581C
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

		// Token: 0x0603EBC3 RID: 256963 RVA: 0x00F27694 File Offset: 0x00F25894
		[NullableContext(1)]
		private void ShowResourcesFloatText(List<IRoverlikeFloatTextData> floatTextList)
		{
			RoverlikeModel.Instance.EnqueueFloatText(floatTextList);
			this.TryOpenFloatTipsView();
		}

		// Token: 0x0603EBC4 RID: 256964 RVA: 0x00F276A7 File Offset: 0x00F258A7
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

		// Token: 0x0603EBC5 RID: 256965 RVA: 0x00F276DC File Offset: 0x00F258DC
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

		// Token: 0x0603EBC6 RID: 256966 RVA: 0x00F27734 File Offset: 0x00F25934
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
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			foreach (string text in notify.UnLoadSubLevels)
			{
				bool flag = false;
				foreach (string b in notify.LoadSubLevels)
				{
					if (text == b)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(text);
				}
			}
			foreach (string text2 in notify.LoadSubLevels)
			{
				bool flag2 = false;
				foreach (string b2 in notify.UnLoadSubLevels)
				{
					if (text2 == b2)
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					list2.Add(text2);
				}
			}
			return new ValueTuple<string[], string[]>(list.ToArray(), list2.ToArray());
		}

		// Token: 0x0603EBC7 RID: 256967 RVA: 0x00F27880 File Offset: 0x00F25A80
		private UniTask RoverRogueGotoNextRoomCommitAsync()
		{
			RoverlikeController.<RoverRogueGotoNextRoomCommitAsync>d__39 <RoverRogueGotoNextRoomCommitAsync>d__;
			<RoverRogueGotoNextRoomCommitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoverRogueGotoNextRoomCommitAsync>d__.<>1__state = -1;
			<RoverRogueGotoNextRoomCommitAsync>d__.<>t__builder.Start<RoverlikeController.<RoverRogueGotoNextRoomCommitAsync>d__39>(ref <RoverRogueGotoNextRoomCommitAsync>d__);
			return <RoverRogueGotoNextRoomCommitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EBC8 RID: 256968 RVA: 0x00F278BB File Offset: 0x00F25ABB
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

		// Token: 0x0603EBC9 RID: 256969 RVA: 0x00F278D8 File Offset: 0x00F25AD8
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

		// Token: 0x0603EBCA RID: 256970 RVA: 0x00F2796C File Offset: 0x00F25B6C
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

		// Token: 0x0603EBCB RID: 256971 RVA: 0x00F279FD File Offset: 0x00F25BFD
		public void OpenGameInfoView(EUiTabViewName? viewName = null)
		{
			UiManager.Instance.OpenView(EUiViewName.RoverlikeDetailView, viewName, null);
		}

		// Token: 0x0603EBCC RID: 256972 RVA: 0x00F27A18 File Offset: 0x00F25C18
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

		// Token: 0x0603EBCD RID: 256973 RVA: 0x00F27A58 File Offset: 0x00F25C58
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

		// Token: 0x0603EBCE RID: 256974 RVA: 0x00F27AD0 File Offset: 0x00F25CD0
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

		// Token: 0x0603EBCF RID: 256975 RVA: 0x00F27B20 File Offset: 0x00F25D20
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

		// Token: 0x0603EBD0 RID: 256976 RVA: 0x00F27BE4 File Offset: 0x00F25DE4
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

		// Token: 0x0603EBD1 RID: 256977 RVA: 0x00F27C24 File Offset: 0x00F25E24
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

		// Token: 0x0603EBD2 RID: 256978 RVA: 0x00F27CCC File Offset: 0x00F25ECC
		public void RoverRogueReChallengeRequest(int instId, Action<bool> callback = null)
		{
			int mainRoleId = RoverlikeModel.Instance.GetMainRoleId();
			this.RoverRogueStartRequest(instId, mainRoleId, 0, true, 0, callback);
		}

		// Token: 0x0603EBD3 RID: 256979 RVA: 0x00F27CF0 File Offset: 0x00F25EF0
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

		// Token: 0x0603EBD4 RID: 256980 RVA: 0x00F27D3C File Offset: 0x00F25F3C
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

		// Token: 0x0603EBD5 RID: 256981 RVA: 0x00F27D90 File Offset: 0x00F25F90
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

		// Token: 0x0603EBD6 RID: 256982 RVA: 0x00F27DDC File Offset: 0x00F25FDC
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

		// Token: 0x0603EBD7 RID: 256983 RVA: 0x00F27E1C File Offset: 0x00F2601C
		private void OnRoverRogueShopInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueShopSnapshot snapshot = ((RoverRogueShopInfoUpdateNotify)msg).Snapshot;
			if (snapshot == null)
			{
				return;
			}
			EventSystem.Instance.Emit<RoverRogueShopSnapshot>(EEventName.RoverlikeShopInfoUpdate, snapshot);
		}

		// Token: 0x0603EBD8 RID: 256984 RVA: 0x00F27E4C File Offset: 0x00F2604C
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
						flag2 = !roverRogueActivity2.Value.IgnoreLoseEffectType().ToList<string>().Contains(type);
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

		// Token: 0x0603EBD9 RID: 256985 RVA: 0x00F27F7C File Offset: 0x00F2617C
		[NullableContext(1)]
		public void OpenRoverlikeGeneralObtainView(IRoverlikeGeneralObtainParam param)
		{
			if (!this.PushObtainParam(param))
			{
				return;
			}
			this.OpenRoverlikeGeneralObtainViewIfNeeded();
		}

		// Token: 0x0603EBDA RID: 256986 RVA: 0x00F27F8E File Offset: 0x00F2618E
		private void OpenRoverlikeGeneralObtainViewIfNeeded()
		{
			if (!UiManager.Instance.IsViewOpen(EUiViewName.RoverlikeGeneralObtainView))
			{
				UiManager.Instance.OpenView(EUiViewName.RoverlikeGeneralObtainView, null, null);
			}
		}

		// Token: 0x0603EBDB RID: 256987 RVA: 0x00F27FB4 File Offset: 0x00F261B4
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

		// Token: 0x0603EBDC RID: 256988 RVA: 0x00F2802C File Offset: 0x00F2622C
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

		// Token: 0x0603EBDD RID: 256989 RVA: 0x00F280A8 File Offset: 0x00F262A8
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

		// Token: 0x0603EBDE RID: 256990 RVA: 0x00F28144 File Offset: 0x00F26344
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

		// Token: 0x0603EBDF RID: 256991 RVA: 0x00F28184 File Offset: 0x00F26384
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

		// Token: 0x0603EBE0 RID: 256992 RVA: 0x00F281D4 File Offset: 0x00F263D4
		private void OnRoverRogueUpdateReviveTimesNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoverRogueUpdateReviveTimesNotify roverRogueUpdateReviveTimesNotify = (RoverRogueUpdateReviveTimesNotify)msg;
			RoverlikeModel.Instance.UpdateReviveTimes(roverRogueUpdateReviveTimesNotify.ReviveTimes, roverRogueUpdateReviveTimesNotify.ReviveTimesMax);
			EventSystem.Instance.Emit<int, int>(EEventName.RoverlikeReviveTimesUpdate, roverRogueUpdateReviveTimesNotify.ReviveTimes, roverRogueUpdateReviveTimesNotify.ReviveTimesMax);
		}

		// Token: 0x0603EBE1 RID: 256993 RVA: 0x00F2821C File Offset: 0x00F2641C
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

		// Token: 0x0603EBE2 RID: 256994 RVA: 0x00F282A0 File Offset: 0x00F264A0
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

		// Token: 0x0603EBE3 RID: 256995 RVA: 0x00F28310 File Offset: 0x00F26510
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

		// Token: 0x0603EBE4 RID: 256996 RVA: 0x00F2838C File Offset: 0x00F2658C
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

		// Token: 0x0603EBE5 RID: 256997 RVA: 0x00F283D8 File Offset: 0x00F265D8
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

		// Token: 0x0603EBE6 RID: 256998 RVA: 0x00F2841C File Offset: 0x00F2661C
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

		// Token: 0x0603EBE7 RID: 256999 RVA: 0x00F28468 File Offset: 0x00F26668
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

		// Token: 0x0603EBE8 RID: 257000 RVA: 0x00F284B4 File Offset: 0x00F266B4
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

		// Token: 0x0603EBE9 RID: 257001 RVA: 0x00F28594 File Offset: 0x00F26794
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

		// Token: 0x0603EBEA RID: 257002 RVA: 0x00F285D8 File Offset: 0x00F267D8
		public int GetEquippedLootLevel()
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
			int equippedLootId = (roverlikeActivityData != null) ? roverlikeActivityData.GetEquippedLootId() : 0;
			if (equippedLootId <= 0)
			{
				return 0;
			}
			RoverRogueGainEntry roverRogueGainEntry = this.CachedLootInfoList.FirstOrDefault((RoverRogueGainEntry loot) => loot.ConfigId == equippedLootId);
			int? num;
			if (roverRogueGainEntry == null)
			{
				num = null;
			}
			else
			{
				RoverRogueLootInfo lootInfo = roverRogueGainEntry.LootInfo;
				num = ((lootInfo != null) ? new int?(lootInfo.LootLv) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x0603EBEB RID: 257003 RVA: 0x00F28668 File Offset: 0x00F26868
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

		// Token: 0x0603EBEC RID: 257004 RVA: 0x00F28784 File Offset: 0x00F26984
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

		// Token: 0x0603EBED RID: 257005 RVA: 0x00F287B0 File Offset: 0x00F269B0
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

		// Token: 0x0603EBEE RID: 257006 RVA: 0x00F2880C File Offset: 0x00F26A0C
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

		// Token: 0x0603EBEF RID: 257007 RVA: 0x00F2884C File Offset: 0x00F26A4C
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

		// Token: 0x0603EBF0 RID: 257008 RVA: 0x00F288C8 File Offset: 0x00F26AC8
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

		// Token: 0x0603EBF1 RID: 257009 RVA: 0x00F28957 File Offset: 0x00F26B57
		public void FinishActionSubView(int incId)
		{
			RoverlikeActionSubViewManager actionSubViewManager = RoverlikeModel.Instance.ActionSubViewManager;
			if (actionSubViewManager == null)
			{
				return;
			}
			actionSubViewManager.FinishSubView(incId);
		}

		// Token: 0x0603EBF2 RID: 257010 RVA: 0x00F28970 File Offset: 0x00F26B70
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

		// Token: 0x0603EBF3 RID: 257011 RVA: 0x00F289C0 File Offset: 0x00F26BC0
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

		// Token: 0x0603EBF4 RID: 257012 RVA: 0x00F28A68 File Offset: 0x00F26C68
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

		// Token: 0x0603EBF5 RID: 257013 RVA: 0x00F28ADC File Offset: 0x00F26CDC
		private void ClearDeathAnimTimer()
		{
			if (this.DeathAnimTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DeathAnimTimer);
				this.DeathAnimTimer = null;
			}
		}

		// Token: 0x0603EBF6 RID: 257014 RVA: 0x00F28B00 File Offset: 0x00F26D00
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

		// Token: 0x0603EBF7 RID: 257015 RVA: 0x00F28B60 File Offset: 0x00F26D60
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

		// Token: 0x17009144 RID: 37188
		// (get) Token: 0x0603EBF8 RID: 257016 RVA: 0x00F28BD6 File Offset: 0x00F26DD6
		[Nullable(1)]
		public static RoverlikeController Instance
		{
			[NullableContext(1)]
			get
			{
				return RoverlikeController._Instance;
			}
		}

		// Token: 0x0603EBF9 RID: 257017 RVA: 0x00F28BDD File Offset: 0x00F26DDD
		[NullableContext(1)]
		public static RoverlikeController GetOrCreateInstance()
		{
			if (RoverlikeController._Instance == null)
			{
				RoverlikeController.CreateInstance();
			}
			return RoverlikeController._Instance;
		}

		// Token: 0x0603EBFA RID: 257018 RVA: 0x00F28BF1 File Offset: 0x00F26DF1
		public static bool CreateInstance()
		{
			if (RoverlikeController._Instance != null)
			{
				return true;
			}
			RoverlikeController._Instance = new RoverlikeController();
			return true;
		}

		// Token: 0x0603EBFB RID: 257019 RVA: 0x00F28C07 File Offset: 0x00F26E07
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603EBFC RID: 257020 RVA: 0x00F28C09 File Offset: 0x00F26E09
		public static void ResetStaticDefaultValue()
		{
			RoverlikeController._Instance = null;
		}

		// Token: 0x0603EBFD RID: 257021 RVA: 0x00F28C11 File Offset: 0x00F26E11
		static RoverlikeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoverlikeController.CreateStaticDefaultValue), new Action(RoverlikeController.ResetStaticDefaultValue));
		}

		// Token: 0x04020C8B RID: 134283
		private const int REVIVE_EFFECT_BUFF_ID = 1502000501;

		// Token: 0x04020C8C RID: 134284
		[Nullable(1)]
		private readonly List<int> RoleUnlockQueue = new List<int>();

		// Token: 0x04020C8D RID: 134285
		private bool IsRoleUnlockShowing;

		// Token: 0x04020C8E RID: 134286
		[Nullable(1)]
		private readonly HashSet<int> KnownUnlockedLootIds = new HashSet<int>();

		// Token: 0x04020C8F RID: 134287
		private bool IsLootCacheInited;

		// Token: 0x04020C90 RID: 134288
		[Nullable(1)]
		private List<RoverRogueGainEntry> PendingUnlockLoots = new List<RoverRogueGainEntry>();

		// Token: 0x04020C91 RID: 134289
		private bool IsLootUnlockReady;

		// Token: 0x04020C92 RID: 134290
		[Nullable(1)]
		private List<RoverRogueGainEntry> CachedLootInfoList = new List<RoverRogueGainEntry>();

		// Token: 0x04020C93 RID: 134291
		private TimerHandle DeathAnimTimer;

		// Token: 0x04020C94 RID: 134292
		private bool IsRoleDeathEnded;

		// Token: 0x04020C95 RID: 134293
		private static RoverlikeController _Instance;
	}
}
