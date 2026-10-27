using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02005AC0 RID: 23232
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class DeadReviveController : UiControllerBase
	{
		// Token: 0x0603AD70 RID: 241008 RVA: 0x00E05935 File Offset: 0x00E03B35
		protected override bool OnChangeMode()
		{
			this.CloseReviveView();
			return true;
		}

		// Token: 0x0603AD71 RID: 241009 RVA: 0x00E05940 File Offset: 0x00E03B40
		protected override void OnAddEvents()
		{
			Net.Instance.Register(ENotifyMessageId.PlayerDeadNotify, new Action<IMessage, Net.CallbackStatus>(this.NotifyOnPlayerDead));
			Net.Instance.Register(ENotifyMessageId.PlayerReviveNotify, new Action<IMessage, Net.CallbackStatus>(this.NotifyOnPlayerRevive));
			Net.Instance.Register(ENotifyMessageId.AbyssReviveNotify, new Action<IMessage, Net.CallbackStatus>(this.AbyssReviveNotify));
			Net.Instance.Register(ENotifyMessageId.AbyssReviveTimeNotify, new Action<IMessage, Net.CallbackStatus>(this.AbyssReviveTimeNotify));
			EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
			EventSystem.Instance.Add<Entity>(EEventName.OnRevive, new Action<Entity>(this.OnRoleRevive));
		}

		// Token: 0x0603AD72 RID: 241010 RVA: 0x00E059F8 File Offset: 0x00E03BF8
		protected override void OnRemoveEvents()
		{
			Net.Instance.UnRegister(ENotifyMessageId.PlayerDeadNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PlayerReviveNotify);
			Net.Instance.UnRegister(ENotifyMessageId.AbyssReviveNotify);
			Net.Instance.UnRegister(ENotifyMessageId.AbyssReviveTimeNotify);
			EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
			EventSystem.Instance.Remove(EEventName.OnRevive, new Action<Entity>(this.OnRoleRevive));
		}

		// Token: 0x0603AD73 RID: 241011 RVA: 0x00E05A80 File Offset: 0x00E03C80
		[NullableContext(2)]
		public void ReviveRequest(bool useItem, Action<bool> finishCallback = null, int? customParam = null)
		{
			if (this.IsReviving)
			{
				return;
			}
			ReviveRequest reviveRequest = Aki.Protocol.ReviveRequest.Create();
			reviveRequest.UseItem = useItem;
			if (customParam != null)
			{
				reviveRequest.CustomParam = customParam.Value;
			}
			this.IsReviving = true;
			Net.Instance.Call(ERequestMessageId.ReviveRequest, reviveRequest, delegate(IMessage msg, Net.CallbackStatus status)
			{
				ReviveResponse reviveResponse = (ReviveResponse)msg;
				this.IsReviving = false;
				if (reviveResponse == null)
				{
					Action<bool> finishCallback2 = finishCallback;
					if (finishCallback2 == null)
					{
						return;
					}
					finishCallback2(false);
					return;
				}
				else if (reviveResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(reviveResponse.ErrorCode, 29474, null, true, true);
					Action<bool> finishCallback3 = finishCallback;
					if (finishCallback3 == null)
					{
						return;
					}
					finishCallback3(false);
					return;
				}
				else
				{
					Action<bool> finishCallback4 = finishCallback;
					if (finishCallback4 == null)
					{
						return;
					}
					finishCallback4(true);
					return;
				}
			}, 0);
		}

		// Token: 0x0603AD74 RID: 241012 RVA: 0x00E05AF4 File Offset: 0x00E03CF4
		public void TryReviveRole(long creatureDataId, int roleId, bool needChangeRole = false)
		{
			ReviveCooldownData reviveCooldownData = null;
			DeadReviveModel.Instance.ReviveCooldownCreatureMap.TryGetValue(creatureDataId, out reviveCooldownData);
			if (reviveCooldownData != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("TuanZiAbyss_RE_ReTime", new object[]
				{
					Math.Floor(0.5 + 0.0010000000474974513 * reviveCooldownData.RemainMilliseconds)
				});
				return;
			}
			EReviveMode reviveMode = DeadReviveModel.Instance.ReviveMode;
			if (reviveMode == EReviveMode.Common)
			{
				BuffItemControl.Instance.TryUseResurrectionItem(roleId);
				return;
			}
			if (reviveMode != EReviveMode.ShareReviveTimes)
			{
				return;
			}
			this.TryReviveRoleByShare(roleId, needChangeRole);
		}

		// Token: 0x0603AD75 RID: 241013 RVA: 0x00E05B80 File Offset: 0x00E03D80
		public void TryReviveRoleWhenCurrentRoleDead(long creatureDataId, int roleId)
		{
			if (DeadReviveModel.Instance.ReviveMode != EReviveMode.ShareReviveTimes)
			{
				return;
			}
			EUiViewName? openedViewName = DeadReviveModel.Instance.OpenedViewName;
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			bool flag;
			if (getCurrentEntity == null)
			{
				flag = false;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				flag = ((entity != null) ? new bool?(entity.Active) : null).GetValueOrDefault();
			}
			if (flag || openedViewName == null || !UiManager.Instance.IsViewOpen(openedViewName.Value))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("AbyssDangoReviveWait", Array.Empty<object>());
				return;
			}
			this.TryReviveRole(creatureDataId, roleId, true);
		}

		// Token: 0x0603AD76 RID: 241014 RVA: 0x00E05C1C File Offset: 0x00E03E1C
		public void CheckOtherPlayerReviveCooldown(int playerId, long creatureDataId)
		{
			if (playerId == CreatureModel.Instance.GetPlayerId())
			{
				return;
			}
			OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(playerId);
			if (currentTeamListById == null)
			{
				return;
			}
			ReviveCooldownData reviveCooldownData = null;
			DeadReviveModel.Instance.ReviveCooldownCreatureMap.TryGetValue(creatureDataId, out reviveCooldownData);
			if (reviveCooldownData != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("TuanZiAbyss_RE_TimeRemainder", new object[]
				{
					currentTeamListById.PlayerNumber,
					Math.Floor(0.5 + 0.0010000000474974513 * reviveCooldownData.RemainMilliseconds)
				});
			}
		}

		// Token: 0x0603AD77 RID: 241015 RVA: 0x00E05CAC File Offset: 0x00E03EAC
		[NullableContext(2)]
		private void NotifyOnPlayerDead(IMessage msg, Net.CallbackStatus status)
		{
			PlayerDeadNotify playerDeadNotify = (PlayerDeadNotify)msg;
			DeadReviveModel instance = DeadReviveModel.Instance;
			int playerId = playerDeadNotify.PlayerId;
			int? id = PlayerInfoModel.Instance.GetId();
			if (!(playerId == id.GetValueOrDefault() & id != null))
			{
				return;
			}
			instance.InitReviveConfig(playerDeadNotify.ReviveId);
			instance.ReviveLimitTime = (float)playerDeadNotify.DelaySeconds;
			instance.IsShowRevive = playerDeadNotify.IsShowRevive;
			instance.IsAutoRevive = playerDeadNotify.IsAutoRevive;
			DeadReviveModel.Instance.BlockAllInput = true;
			InputDistributeController.Instance.RefreshInputTag();
			try
			{
				if (!playerDeadNotify.IsAutoRevive && playerDeadNotify.IsShowRevive && !this.IsInstChallengeFinish())
				{
					UiManager.Instance.ResetToBattleView(null);
				}
				LordGymModel instance2 = LordGymModel.Instance;
				if (instance2.IsChallenging())
				{
					instance2.IsDeadInChallenge = true;
				}
				if (playerDeadNotify.IsLogin)
				{
					EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.LoginDeadFinish));
				}
				else if (instance.SkipDeathAnim)
				{
					this.DeadFinish(0f);
				}
				else if (!RoverlikeController.Instance.CheckInRoverlike())
				{
					instance.DeadDelayTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.DeadFinish), 3000f, null, null, true, 1f);
				}
			}
			catch (Exception ex)
			{
				Log instance3 = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "玩家死亡异常";
				Exception error = ex;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance3.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				DeadReviveModel.Instance.BlockAllInput = false;
				InputDistributeController.Instance.RefreshInputTag();
			}
		}

		// Token: 0x0603AD78 RID: 241016 RVA: 0x00E05E40 File Offset: 0x00E04040
		private void LoginDeadFinish()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.LoginDeadFinish));
			DeadReviveModel.Instance.DeadDelayTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.DeadFinish), 1000f, null, null, true, 1f);
		}

		// Token: 0x0603AD79 RID: 241017 RVA: 0x00E05E98 File Offset: 0x00E04098
		private void DeadFinish(float delta)
		{
			DeadReviveModel.Instance.DeadDelayTimer = null;
			if (DeadReviveModel.Instance.IsAutoRevive)
			{
				Log.Instance.Info(ELogModule.World, ELogAuthor.LYY, "自动复活", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.DoDeadFinish(true);
				return;
			}
			this.OpenReviveView();
		}

		// Token: 0x0603AD7A RID: 241018 RVA: 0x00E05EE8 File Offset: 0x00E040E8
		public void DoDeadFinish(bool needReviveRequest = true)
		{
			DeadReviveModel.Instance.BlockAllInput = false;
			InputDistributeController.Instance.RefreshInputTag();
			if (needReviveRequest)
			{
				this.ReviveRequest(false, null, null);
			}
		}

		// Token: 0x0603AD7B RID: 241019 RVA: 0x00E05F20 File Offset: 0x00E04120
		[NullableContext(2)]
		private unsafe void NotifyOnPlayerRevive(IMessage msg, Net.CallbackStatus status)
		{
			PlayerReviveNotify playerReviveNotify = (PlayerReviveNotify)msg;
			Aki.Protocol.Vector location = playerReviveNotify.Location;
			double inX = (double)((location != null) ? location.X : 0f);
			Aki.Protocol.Vector location2 = playerReviveNotify.Location;
			double inY = (double)((location2 != null) ? location2.Y : 0f);
			Aki.Protocol.Vector location3 = playerReviveNotify.Location;
			FVectorDouble fvectorDouble = new FVectorDouble(inX, inY, (double)((location3 != null) ? location3.Z : 0f));
			Aki.Protocol.Rotator rotator = playerReviveNotify.Rotator;
			float inPitch = (rotator != null) ? rotator.Pitch : 0f;
			Aki.Protocol.Rotator rotator2 = playerReviveNotify.Rotator;
			float inYaw = (rotator2 != null) ? rotator2.Yaw : 0f;
			Aki.Protocol.Rotator rotator3 = playerReviveNotify.Rotator;
			FRotator frotator = new FRotator(inPitch, inYaw, (rotator3 != null) ? rotator3.Roll : 0f);
			global::Vector vector = null;
			Aki.Protocol.Vector gravity = playerReviveNotify.Gravity;
			if (gravity != null)
			{
				vector = global::Vector.Create((double)gravity.X, (double)gravity.Y, (double)gravity.Z);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "执行复活流程";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", playerReviveNotify.PlayerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Location", fvectorDouble);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Rotator", frotator);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Gravity", vector);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("ReviveType", playerReviveNotify.ReviveType);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			int playerId = playerReviveNotify.PlayerId;
			int? id = PlayerInfoModel.Instance.GetId();
			if (playerId == id.GetValueOrDefault() & id != null)
			{
				this.SelfRevive(playerReviveNotify, fvectorDouble, frotator, vector).Forget();
				return;
			}
			this.OtherPlayerRevive(playerReviveNotify, fvectorDouble, frotator);
		}

		// Token: 0x0603AD7C RID: 241020 RVA: 0x00E060EC File Offset: 0x00E042EC
		private UniTask SelfRevive(PlayerReviveNotify notify, FVectorDouble location, FRotator rotator, [Nullable(2)] global::Vector gravity)
		{
			DeadReviveController.<SelfRevive>d__17 <SelfRevive>d__;
			<SelfRevive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelfRevive>d__.<>4__this = this;
			<SelfRevive>d__.notify = notify;
			<SelfRevive>d__.location = location;
			<SelfRevive>d__.rotator = rotator;
			<SelfRevive>d__.gravity = gravity;
			<SelfRevive>d__.<>1__state = -1;
			<SelfRevive>d__.<>t__builder.Start<DeadReviveController.<SelfRevive>d__17>(ref <SelfRevive>d__);
			return <SelfRevive>d__.<>t__builder.Task;
		}

		// Token: 0x0603AD7D RID: 241021 RVA: 0x00E06150 File Offset: 0x00E04350
		private bool CanRevivePerform(FVectorDouble location)
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			bool flag = false;
			foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(true))
			{
				WorldEntity entity = entityHandle.Entity;
				BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
				if (baseTagComponent != null && baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["怪物.common.关卡.特殊复活通知"]))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
			if (!TeleportController.Instance.QueryCanTeleportNoLoading(location))
			{
				Log.Instance.Info(ELogModule.World, ELogAuthor.LYY, "复活位置不可无加载传送，不允许复活表演", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x0603AD7E RID: 241022 RVA: 0x00E06214 File Offset: 0x00E04414
		private void OnPlotNetworkEnd(PlotResultInfo plotResult)
		{
			long reviveFlowIncId = DeadReviveModel.Instance.ReviveFlowIncId;
			if (reviveFlowIncId != 0L)
			{
				long? flowIncId = plotResult.FlowIncId;
				long num = reviveFlowIncId;
				if (flowIncId.GetValueOrDefault() == num & flowIncId != null)
				{
					this.NoLoadingTeleport(DeadReviveModel.Instance.RevivePosition.Value, DeadReviveModel.Instance.ReviveRotator, DeadReviveModel.Instance.ReviveGravity, "RevivePerform");
					LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "DeadRevive_PlotEnd", null, new float?(0.5f));
					DeadReviveModel.Instance.ReviveFlowIncId = 0L;
				}
			}
		}

		// Token: 0x0603AD7F RID: 241023 RVA: 0x00E062A4 File Offset: 0x00E044A4
		public void PlayerReviveEnded(float delta)
		{
			SceneTeamController.Instance.ShowControlledRole(PlayerInfoModel.Instance.GetId().Value);
			SceneTeamItem sceneTeamItem = null;
			int changeRoleIdAfterRevive = DeadReviveModel.Instance.ChangeRoleIdAfterRevive;
			if (changeRoleIdAfterRevive != 0)
			{
				sceneTeamItem = SceneTeamModel.Instance.GetTeamItem((long)changeRoleIdAfterRevive, new GetTeamItemOptions
				{
					ParamType = ETeamParamType.ConfigId,
					OnlyMyRole = new bool?(true)
				});
			}
			DeadReviveModel.Instance.ChangeRoleIdAfterRevive = 0;
			if (sceneTeamItem == null && !GameModeModel.Instance.IsMulti)
			{
				List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(true);
				if (teamItems.Count > 0)
				{
					sceneTeamItem = teamItems[0];
				}
			}
			if (sceneTeamItem != null)
			{
				SceneTeamController.Instance.RequestChangeRole(sceneTeamItem.GetCreatureDataId(), null);
			}
		}

		// Token: 0x0603AD80 RID: 241024 RVA: 0x00E06350 File Offset: 0x00E04550
		private void OtherPlayerRevive(PlayerReviveNotify notify, FVectorDouble location, FRotator rotator)
		{
			foreach (ReviveRoleInformation reviveRoleInformation in notify.ReviveRoleInfos)
			{
				long entityId = reviveRoleInformation.EntityId;
				EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
				if (entity != null && entity.Valid)
				{
					if (!entity.IsInit)
					{
						CreatureDataComponent component = entity.Entity.GetComponent<CreatureDataComponent>();
						if (component != null)
						{
							component.SetLivingStatus(LivingStatus.Alive);
						}
						Aki.Protocol.Vector location2 = notify.Location;
						if (location2 != null && component != null)
						{
							component.SetInitLocation(location2);
						}
					}
					else
					{
						CharacterActorComponent component2 = entity.Entity.GetComponent<CharacterActorComponent>();
						component2.SetInputRotator(rotator);
						component2.SetActorLocationAndRotation(location, rotator, "复活流程.复活其他角色", false, null);
						CharacterMovementSyncComponent component3 = entity.Entity.GetComponent<CharacterMovementSyncComponent>();
						if (component3 != null)
						{
							component3.ClearReplaySamples();
						}
					}
				}
			}
			SceneTeamController.Instance.ShowControlledRole(notify.PlayerId);
		}

		// Token: 0x0603AD81 RID: 241025 RVA: 0x00E0644C File Offset: 0x00E0464C
		private void OpenReviveView()
		{
			ValueTuple<EUiViewName?, object> reviveViewName = this.GetReviveViewName();
			EUiViewName? viewName = reviveViewName.Item1;
			object viewData = reviveViewName.Item2;
			if (viewName == null)
			{
				DeadReviveModel.Instance.BlockAllInput = false;
				InputDistributeController.Instance.RefreshInputTag();
				return;
			}
			DeadReviveModel.Instance.OpenedViewName = viewName;
			UiManager.Instance.ResetToBattleView(delegate(bool success)
			{
				if (SceneTeamModel.Instance.GetGroupLivingState(PlayerInfoModel.Instance.GetId().GetValueOrDefault(), ETeamGroupType.Battle) == ETeamLivingState.Alive)
				{
					DeadReviveModel.Instance.BlockAllInput = false;
					InputDistributeController.Instance.RefreshInputTag();
					return;
				}
				UiManager.Instance.OpenView(viewName.Value, viewData, delegate(bool _, int _)
				{
					DeadReviveModel.Instance.BlockAllInput = false;
					InputDistributeController.Instance.RefreshInputTag();
				});
			});
		}

		// Token: 0x0603AD82 RID: 241026 RVA: 0x00E064C8 File Offset: 0x00E046C8
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private ValueTuple<EUiViewName?, object> GetReviveViewName()
		{
			if (this.IsInstChallengeFinish())
			{
				return new ValueTuple<EUiViewName?, object>(null, null);
			}
			if (DeadReviveModel.Instance.ReviveMode == EReviveMode.ShareReviveTimes)
			{
				return new ValueTuple<EUiViewName?, object>(new EUiViewName?(EUiViewName.ShareTimesReviveView), null);
			}
			if (GameModeModel.Instance.IsMulti)
			{
				if (TowerDefenseController.Instance.CheckInInstanceDungeon())
				{
					return new ValueTuple<EUiViewName?, object>(TowerDefenseController.Instance.TryGetReviveViewName(), null);
				}
				return new ValueTuple<EUiViewName?, object>(new EUiViewName?(EUiViewName.MultiReviveView), null);
			}
			else if (KurotatoController.Instance.CheckInKurotatoInstance())
			{
				KurotatoModel instance = KurotatoModel.Instance;
				if (instance.GetSettlementData() != null)
				{
					return new ValueTuple<EUiViewName?, object>(null, null);
				}
				if (instance.GetIsSpecialWave())
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.KurotatoEndSpecialWaveCombatConfirm);
					confirmBoxDataNew.FunctionMap[1] = delegate()
					{
						KurotatoController.Instance.RequestKurotatoEndSpecialWaveCombat().Forget<bool>();
					};
					return new ValueTuple<EUiViewName?, object>(ConfirmBoxController.Instance.GetUiViewName(532), confirmBoxDataNew);
				}
				EConfirmBoxConfigId configId = instance.IsReChallengeCountUnlimited() ? EConfirmBoxConfigId.KurotatoDieNoLimitConfirm : EConfirmBoxConfigId.KurotatoDieConfirm;
				ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(configId);
				confirmBoxDataNew2.IsMultipleView = true;
				if (!instance.IsReChallengeCountUnlimited())
				{
					confirmBoxDataNew2.SetTextArgs(new string[]
					{
						instance.GetRemainReChallengeCount().ToString()
					});
				}
				confirmBoxDataNew2.FunctionMap[1] = delegate()
				{
					KurotatoController.Instance.RequestKurotatoSettlement().Forget<bool>();
				};
				confirmBoxDataNew2.FunctionMap[2] = delegate()
				{
					KurotatoController.Instance.RequestKurotatoReChallenge(true).Forget<bool>();
				};
				return new ValueTuple<EUiViewName?, object>(ConfirmBoxController.Instance.GetUiViewName((int)configId), confirmBoxDataNew2);
			}
			else
			{
				if (!DeadReviveModel.Instance.IsShowRevive)
				{
					return new ValueTuple<EUiViewName?, object>(null, null);
				}
				BabelTowerModel instance2 = BabelTowerModel.Instance;
				if (instance2.CheckInBattleBabelTower() && instance2.CheckCanRevive())
				{
					BabelTowerInstanceData currentChallengeInstData = instance2.CurrentChallengeInstData;
					BabelTowerReviveViewData item = new BabelTowerReviveViewData
					{
						LevelId = currentChallengeInstData.LevelId,
						StarNum = currentChallengeInstData.CurStarNum
					};
					return new ValueTuple<EUiViewName?, object>(new EUiViewName?(EUiViewName.BabelTowerReviveView), item);
				}
				if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
				{
					return new ValueTuple<EUiViewName?, object>(new EUiViewName?(EUiViewName.FlagChallengeReviveView), null);
				}
				return new ValueTuple<EUiViewName?, object>(new EUiViewName?(EUiViewName.ReviveView), null);
			}
		}

		// Token: 0x0603AD83 RID: 241027 RVA: 0x00E0671A File Offset: 0x00E0491A
		private bool IsInstChallengeFinish()
		{
			return DangoAbyssModel.Instance.CheckInAbyss() && DangoAbyssModel.Instance.IsChallengeFinish();
		}

		// Token: 0x0603AD84 RID: 241028 RVA: 0x00E06734 File Offset: 0x00E04934
		private void CloseReviveView()
		{
			EUiViewName? openedViewName = DeadReviveModel.Instance.OpenedViewName;
			if (openedViewName != null && UiManager.Instance.IsViewOpen(openedViewName.Value))
			{
				UiManager.Instance.CloseView(openedViewName.Value, null);
			}
			DeadReviveModel.Instance.OpenedViewName = null;
		}

		// Token: 0x0603AD85 RID: 241029 RVA: 0x00E0678C File Offset: 0x00E0498C
		private void NoLoadingTeleport(FVectorDouble location, FRotator? rotator, [Nullable(2)] global::Vector gravity, string reason)
		{
			ITeleportContextParam param = new ITeleportContextParam
			{
				ClientReason = reason,
				TargetPosition = location,
				TargetRotation = rotator,
				TargetGravityDirect = gravity,
				TeleportMode = new ETeleportMode?(ETeleportMode.Auto)
			};
			TeleportController.Instance.TeleportPlayer(param).ContinueWith(delegate(bool result)
			{
				SceneTeamController.Instance.ShowControlledRole(PlayerInfoModel.Instance.GetId().Value);
				TeleportFinishRequest message = TeleportFinishRequest.Create();
				Net.Instance.Call(ERequestMessageId.TeleportFinishRequest, message, delegate(IMessage response, Net.CallbackStatus status)
				{
				}, 0);
				int changeRoleIdAfterRevive = DeadReviveModel.Instance.ChangeRoleIdAfterRevive;
				if (changeRoleIdAfterRevive != 0)
				{
					SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)changeRoleIdAfterRevive, new GetTeamItemOptions
					{
						ParamType = ETeamParamType.ConfigId,
						OnlyMyRole = new bool?(true)
					});
					DeadReviveModel.Instance.ChangeRoleIdAfterRevive = 0;
					if (teamItem != null)
					{
						SceneTeamController.Instance.RequestChangeRole(teamItem.GetCreatureDataId(), null);
					}
				}
			}).Forget();
		}

		// Token: 0x0603AD86 RID: 241030 RVA: 0x00E06804 File Offset: 0x00E04A04
		[NullableContext(2)]
		private void AbyssReviveNotify(IMessage msg, Net.CallbackStatus status)
		{
			AbyssReviveNotify abyssReviveNotify = (AbyssReviveNotify)msg;
			if (abyssReviveNotify == null)
			{
				return;
			}
			DeadReviveModel instance = DeadReviveModel.Instance;
			instance.CurrentShareReviveTimes = abyssReviveNotify.CurReviveTimes;
			instance.MaxShareReviveTimes = abyssReviveNotify.MaxReviveTimes;
			if (instance.MaxShareReviveTimes > 0)
			{
				instance.ReviveMode = EReviveMode.ShareReviveTimes;
			}
			EventSystem.Instance.Emit(EEventName.OnShareReviveTimesChange);
		}

		// Token: 0x0603AD87 RID: 241031 RVA: 0x00E0685C File Offset: 0x00E04A5C
		public void TryReviveCurrentRoleByShare()
		{
			SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
			if (getCurrentTeamItem == null)
			{
				return;
			}
			this.RequestReviveRoleByShare(getCurrentTeamItem.GetConfigId);
		}

		// Token: 0x0603AD88 RID: 241032 RVA: 0x00E06884 File Offset: 0x00E04A84
		private void TryReviveRoleByShare(int roleId, bool needChangeRole)
		{
			if (DeadReviveModel.Instance.CurrentShareReviveTimes <= 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("TuanZiAbyss_RE_NoNum", Array.Empty<object>());
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ShareReviveRole);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				if (needChangeRole)
				{
					DeadReviveModel.Instance.ChangeRoleIdAfterRevive = roleId;
				}
				this.RequestReviveRoleByShare(roleId);
			};
			int currentShareReviveTimes = DeadReviveModel.Instance.CurrentShareReviveTimes;
			int maxShareReviveTimes = DeadReviveModel.Instance.MaxShareReviveTimes;
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				currentShareReviveTimes.ToString(),
				maxShareReviveTimes.ToString()
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603AD89 RID: 241033 RVA: 0x00E06934 File Offset: 0x00E04B34
		private void RequestReviveRoleByShare(int roleId)
		{
			AbyssReviveCharacterRequest abyssReviveCharacterRequest = AbyssReviveCharacterRequest.Create();
			abyssReviveCharacterRequest.RoleId = roleId;
			Net.Instance.Call(ERequestMessageId.AbyssReviveCharacterRequest, abyssReviveCharacterRequest, delegate(IMessage _, Net.CallbackStatus _)
			{
			}, 0);
		}

		// Token: 0x0603AD8A RID: 241034 RVA: 0x00E06980 File Offset: 0x00E04B80
		[NullableContext(2)]
		private void AbyssReviveTimeNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (AbyssEntityReviveTime abyssEntityReviveTime in ((AbyssReviveTimeNotify)msg).ReviveTimeList)
			{
				DeadReviveModel.Instance.RegisterCooldown(abyssEntityReviveTime.EntityId, abyssEntityReviveTime.ReviveTime);
			}
		}

		// Token: 0x0603AD8B RID: 241035 RVA: 0x00E069E4 File Offset: 0x00E04BE4
		private void OnRoleRevive(Entity entity)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			long creatureDataId = (component != null) ? component.GetCreatureDataId() : 0L;
			DeadReviveModel.Instance.UnRegisterCooldown(creatureDataId);
		}

		// Token: 0x17008C22 RID: 35874
		// (get) Token: 0x0603AD8C RID: 241036 RVA: 0x00E06A10 File Offset: 0x00E04C10
		public static DeadReviveController Instance
		{
			get
			{
				return DeadReviveController._Instance;
			}
		}

		// Token: 0x0603AD8D RID: 241037 RVA: 0x00E06A17 File Offset: 0x00E04C17
		public static DeadReviveController GetOrCreateInstance()
		{
			if (DeadReviveController._Instance == null)
			{
				DeadReviveController.CreateInstance();
			}
			return DeadReviveController._Instance;
		}

		// Token: 0x0603AD8E RID: 241038 RVA: 0x00E06A2B File Offset: 0x00E04C2B
		public static bool CreateInstance()
		{
			if (DeadReviveController._Instance != null)
			{
				return true;
			}
			DeadReviveController._Instance = new DeadReviveController();
			return true;
		}

		// Token: 0x0603AD8F RID: 241039 RVA: 0x00E06A41 File Offset: 0x00E04C41
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AD90 RID: 241040 RVA: 0x00E06A43 File Offset: 0x00E04C43
		public static void ResetStaticDefaultValue()
		{
			DeadReviveController._Instance = null;
		}

		// Token: 0x0603AD91 RID: 241041 RVA: 0x00E06A4B File Offset: 0x00E04C4B
		static DeadReviveController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DeadReviveController.CreateStaticDefaultValue), new Action(DeadReviveController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EB3F RID: 125759
		private const int TIME_TO_REVIVE = 3000;

		// Token: 0x0401EB40 RID: 125760
		private const int LOGIN_REVIVE = 1000;

		// Token: 0x0401EB41 RID: 125761
		private const float OPEN_FADE_DURATION = 0.1f;

		// Token: 0x0401EB42 RID: 125762
		private const float CLOSE_FADE_DURATION = 0.5f;

		// Token: 0x0401EB43 RID: 125763
		private bool IsReviving;

		// Token: 0x0401EB44 RID: 125764
		[Nullable(2)]
		private static DeadReviveController _Instance;
	}
}
