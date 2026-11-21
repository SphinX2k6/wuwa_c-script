using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x0200604B RID: 24651
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	[TickController(0)]
	public class DollGrabMachineController : ControllerBase
	{
		// Token: 0x17006FF7 RID: 28663
		// (get) Token: 0x0603B28C RID: 242316 RVA: 0x010B928F File Offset: 0x010B748F
		public bool IsGameplayReady
		{
			get
			{
				return this.IsGameplayReadyInternal;
			}
		}

		// Token: 0x17006FF8 RID: 28664
		// (get) Token: 0x0603B28D RID: 242317 RVA: 0x010B9297 File Offset: 0x010B7497
		public bool IsEndlessMode
		{
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				return dollGrabMachineComponent != null && dollGrabMachineComponent.IsEndlessMode;
			}
		}

		// Token: 0x17006FF9 RID: 28665
		// (get) Token: 0x0603B28E RID: 242318 RVA: 0x010B92AA File Offset: 0x010B74AA
		public int LeaveDollCount
		{
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				if (dollGrabMachineComponent == null)
				{
					return 0;
				}
				return dollGrabMachineComponent.LeaveDollCount;
			}
		}

		// Token: 0x17006FFA RID: 28666
		// (get) Token: 0x0603B28F RID: 242319 RVA: 0x010B92BD File Offset: 0x010B74BD
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IGrabItemData> CurrentDropItemList
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				if (dollGrabMachineComponent == null)
				{
					return null;
				}
				return dollGrabMachineComponent.CurrentDropItemList;
			}
		}

		// Token: 0x17006FFB RID: 28667
		// (get) Token: 0x0603B290 RID: 242320 RVA: 0x010B92D0 File Offset: 0x010B74D0
		public float PlayCost
		{
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				if (dollGrabMachineComponent == null)
				{
					return 0f;
				}
				return dollGrabMachineComponent.PlayCost;
			}
		}

		// Token: 0x17006FFC RID: 28668
		// (get) Token: 0x0603B291 RID: 242321 RVA: 0x010B92E7 File Offset: 0x010B74E7
		public bool HasGrabbingActor
		{
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				return dollGrabMachineComponent != null && dollGrabMachineComponent.HasGrabbingActor;
			}
		}

		// Token: 0x17006FFD RID: 28669
		// (get) Token: 0x0603B292 RID: 242322 RVA: 0x010B92FC File Offset: 0x010B74FC
		public EDollGrabMachineClawState? ClawState
		{
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				if (dollGrabMachineComponent == null)
				{
					return null;
				}
				DgmClawBaseMoveState clawState = dollGrabMachineComponent.ClawState;
				if (clawState == null)
				{
					return null;
				}
				return new EDollGrabMachineClawState?(clawState.ClawState);
			}
		}

		// Token: 0x17006FFE RID: 28670
		// (get) Token: 0x0603B293 RID: 242323 RVA: 0x010B933A File Offset: 0x010B753A
		public bool IsDangerousCountdown
		{
			get
			{
				return this.IsDangerousCountdownInternal;
			}
		}

		// Token: 0x17006FFF RID: 28671
		// (get) Token: 0x0603B294 RID: 242324 RVA: 0x010B9342 File Offset: 0x010B7542
		[Nullable(2)]
		public IDollGrabInfiniteRewardData EndlessRewardData
		{
			[NullableContext(2)]
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				if (dollGrabMachineComponent == null)
				{
					return null;
				}
				return dollGrabMachineComponent.EndlessRewardData;
			}
		}

		// Token: 0x17007000 RID: 28672
		// (get) Token: 0x0603B295 RID: 242325 RVA: 0x010B9355 File Offset: 0x010B7555
		[Nullable(2)]
		public SceneItemDollGrabMachineComponent CurrentDollGrabMachineComponent
		{
			[NullableContext(2)]
			get
			{
				return this.DollGrabMachineComponent;
			}
		}

		// Token: 0x0603B296 RID: 242326 RVA: 0x010B9360 File Offset: 0x010B7560
		protected override bool OnInit()
		{
			global::Log.Instance.Info(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineController] 初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			DollGrabModel.Instance.LoadDollGrabMachineGlobalConfig();
			base.PauseTick();
			return true;
		}

		// Token: 0x0603B297 RID: 242327 RVA: 0x010B939D File Offset: 0x010B759D
		public void RegisterDollGrabMachine(SceneItemDollGrabMachineComponent comp)
		{
			if (this.DollGrabMachineComponentSet.Contains(comp))
			{
				return;
			}
			this.DollGrabMachineComponentSet.Add(comp);
			DollGrabModel.Instance.LoadDollGrabClawSequence(new Action(this.OnDollGrabClawSequenceLoaded));
		}

		// Token: 0x0603B298 RID: 242328 RVA: 0x010B93D4 File Offset: 0x010B75D4
		public void UnregisterDollGrabMachine(SceneItemDollGrabMachineComponent comp)
		{
			if (!this.DollGrabMachineComponentSet.Contains(comp))
			{
				return;
			}
			this.DollGrabMachineComponentSet.Remove(comp);
			if (this.DollGrabMachineComponent == comp && this.IsInCountdownInternal)
			{
				this.PreExitDollGrabMachine(EDollGrabMachineEndReason.Exception, false);
			}
			if (this.DollGrabMachineComponentSet.Count == 0)
			{
				DollGrabModel.Instance.DollGrabClawSequence = null;
			}
		}

		// Token: 0x0603B299 RID: 242329 RVA: 0x010B9430 File Offset: 0x010B7630
		private void OnDollGrabClawSequenceLoaded()
		{
			foreach (SceneItemDollGrabMachineComponent sceneItemDollGrabMachineComponent in this.DollGrabMachineComponentSet)
			{
				sceneItemDollGrabMachineComponent.OnClawSequenceLoaded();
			}
		}

		// Token: 0x0603B29A RID: 242330 RVA: 0x010B9480 File Offset: 0x010B7680
		public void StartDollGrabMachine(IDollGrab config)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(config.TargetDollGrabMachineId);
			if (!entityByPbDataId || !entityByPbDataId.Entity)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.DollGrabMachine;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[StartDollGrabMachine] 娃娃机实体不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", config.TargetDollGrabMachineId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.DollGrabMachineComponent = entityByPbDataId.Entity.GetComponent<SceneItemDollGrabMachineComponent>();
			if (this.DollGrabMachineComponent == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.DollGrabMachine;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "[StartDollGrabMachine] 娃娃机实体没有SceneItemDollGrabMachineComponent组件";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", config.TargetDollGrabMachineId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			if (!EventSystem.Instance.HasWithTarget<ERemoveEntityType, EntityHandle>(entityByPbDataId, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnDollGrabEntityDestroy)))
			{
				EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(entityByPbDataId, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnDollGrabEntityDestroy));
			}
			this.DollGrabMachineComponent.StartDissolve();
			TsInteractionUtils.RegisterOpenViewName(EUiViewName.DollGrabMachineView);
			if (this.IsEndlessMode && GuideController.Instance.TryStartGuide(34303))
			{
				EventSystem.Instance.Add<int>(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideFinish));
				EventSystem.Instance.Add<int>(EEventName.GuideGroupBreak, new Action<int>(this.OnGuideFinish));
				EventSystem.Instance.Add<int>(EEventName.GuideGroupRest, new Action<int>(this.OnGuideFinish));
			}
			else
			{
				this.OnGuideFinish(34303);
			}
			if (!EventSystem.Instance.Has<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange)))
			{
				EventSystem.Instance.Add<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
			}
		}

		// Token: 0x0603B29B RID: 242331 RVA: 0x010B963C File Offset: 0x010B783C
		private void OnGuideFinish(int groupId)
		{
			if (groupId != 34303)
			{
				return;
			}
			if (EventSystem.Instance.Has<int>(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideFinish)))
			{
				EventSystem.Instance.Remove<int>(EEventName.GuideGroupFinished, new Action<int>(this.OnGuideFinish));
			}
			if (EventSystem.Instance.Has<int>(EEventName.GuideGroupBreak, new Action<int>(this.OnGuideFinish)))
			{
				EventSystem.Instance.Remove<int>(EEventName.GuideGroupBreak, new Action<int>(this.OnGuideFinish));
			}
			if (EventSystem.Instance.Has<int>(EEventName.GuideGroupRest, new Action<int>(this.OnGuideFinish)))
			{
				EventSystem.Instance.Remove<int>(EEventName.GuideGroupRest, new Action<int>(this.OnGuideFinish));
			}
			UiManager.Instance.OpenView(EUiViewName.DollGrabMachineView, null, null);
			if (!EventSystem.Instance.Has<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseDollGrabMachineView)))
			{
				EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseDollGrabMachineView));
			}
			int pbDataId = this.DollGrabMachineComponent.Entity.GetComponent<CreatureDataComponent>().GetPbDataId();
			EventSystem.Instance.Emit<int, bool>(EEventName.OnDollGrabMachineGameplayStateChanged, pbDataId, true);
		}

		// Token: 0x0603B29C RID: 242332 RVA: 0x010B976C File Offset: 0x010B796C
		private void StartDollGrabMachineInternal()
		{
			DollGarbStartRequest dollGarbStartRequest = DollGarbStartRequest.Create();
			dollGarbStartRequest.EntityIncId = this.DollGrabMachineComponent.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
			this.IsRequesting = true;
			this.IsInCountdownInternal = false;
			Net.Instance.Call(ERequestMessageId.DollGarbStartRequest, dollGarbStartRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DollGarbStartResponse dollGarbStartResponse = (DollGarbStartResponse)msg;
				this.IsRequesting = false;
				if (dollGarbStartResponse == null)
				{
					return;
				}
				if (dollGarbStartResponse.ErrorCode != ErrorCode.Success)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.DollGrabMachine;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "[StartDollGrabMachine] 开启玩法请求失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", dollGarbStartResponse.ErrorCode);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.IsGameplayReadyInternal = true;
				this.DollGrabMachineComponent.OnStartDollGrabMachine();
				this.RemainingTimeInternal = this.DollGrabMachineComponent.TimeLimit * 1000f;
				this.RemainingTimeLimitInternal = this.RemainingTimeInternal;
				UiManager.Instance.OpenView(EUiViewName.DollGrabFloatCountDownView, null, null);
				if (!EventSystem.Instance.Has<float>(EEventName.OnDollGrabMachineRemainingTimeAdd, new Action<float>(this.OnAddRemainingTime)))
				{
					EventSystem.Instance.Add<float>(EEventName.OnDollGrabMachineRemainingTimeAdd, new Action<float>(this.OnAddRemainingTime));
				}
			}, 0);
		}

		// Token: 0x0603B29D RID: 242333 RVA: 0x010B97C5 File Offset: 0x010B79C5
		public void RegisterTick(SceneItemDollGrabMachineComponent comp)
		{
			if (this.TickComponentSet.Contains(comp))
			{
				return;
			}
			this.TickComponentSet.Add(comp);
			base.ResumeTick();
		}

		// Token: 0x0603B29E RID: 242334 RVA: 0x010B97E9 File Offset: 0x010B79E9
		public void UnregisterTick(SceneItemDollGrabMachineComponent comp)
		{
			if (!this.TickComponentSet.Contains(comp))
			{
				return;
			}
			this.TickComponentSet.Remove(comp);
			if (this.TickComponentSet.Count == 0)
			{
				base.PauseTick();
			}
		}

		// Token: 0x0603B29F RID: 242335 RVA: 0x010B981A File Offset: 0x010B7A1A
		public bool CheckRegisterTick(SceneItemDollGrabMachineComponent comp)
		{
			return this.TickComponentSet.Contains(comp);
		}

		// Token: 0x0603B2A0 RID: 242336 RVA: 0x010B9828 File Offset: 0x010B7A28
		protected override void OnTick(float delta)
		{
			base.OnTick(delta);
			if (this.IsGameplayReadyInternal)
			{
				this.RemainingTimeInternal -= delta;
				this.AddRemainingTimeInternal -= delta;
				if (this.AddRemainingTimeInternal < 0f)
				{
					this.AddRemainingTimeInternal = 0f;
				}
				if (this.RemainingTimeInternal <= 0f)
				{
					this.PreExitDollGrabMachine(EDollGrabMachineEndReason.TimeUp, false);
				}
				else
				{
					if (this.RemainingTimeInternal < DollGrabModel.Instance.DangerousCountdown && !this.IsDangerousCountdown)
					{
						this.ToggleScreenEffect(true);
						this.IsDangerousCountdownInternal = true;
						EventSystem.Instance.Emit<bool>(EEventName.OnDollGrabMachineDangerousCountdown, true);
					}
					if (this.RemainingTimeInternal >= DollGrabModel.Instance.DangerousCountdown && this.IsDangerousCountdown)
					{
						this.ToggleScreenEffect(false);
						this.IsDangerousCountdownInternal = false;
						EventSystem.Instance.Emit<bool>(EEventName.OnDollGrabMachineDangerousCountdown, false);
					}
				}
			}
			foreach (SceneItemDollGrabMachineComponent sceneItemDollGrabMachineComponent in this.TickComponentSet)
			{
				sceneItemDollGrabMachineComponent.ExecuteTick(delta);
			}
		}

		// Token: 0x0603B2A1 RID: 242337 RVA: 0x010B9948 File Offset: 0x010B7B48
		public void OnClickMoveInput(string name, InputDistributeDefine.EActionType actionType)
		{
			if (!this.IsAllowMoveInput())
			{
				return;
			}
			DgmClawBaseMoveState clawState = this.DollGrabMachineComponent.ClawState;
			if (clawState == null || clawState.ClawState > EDollGrabMachineClawState.Idle)
			{
				DgmClawBaseMoveState clawState2 = this.DollGrabMachineComponent.ClawState;
				if (clawState2 == null || clawState2.ClawState != EDollGrabMachineClawState.Release)
				{
					DgmClawBaseMoveState clawState3 = this.DollGrabMachineComponent.ClawState;
					if (clawState3 == null || clawState3.ClawState != EDollGrabMachineClawState.Grabbing)
					{
						this.DollGrabMachineComponent.ClawMoveDirection.Y = 0f;
						this.DollGrabMachineComponent.ClawMoveDirection.X = 0f;
						this.PressedKey.Clear();
						return;
					}
				}
			}
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				this.PressedKey.Add(name);
			}
			else
			{
				this.PressedKey.Remove(name);
			}
			this.DollGrabMachineComponent.ClawMoveDirection.Y = 0f;
			this.DollGrabMachineComponent.ClawMoveDirection.X = 0f;
			foreach (string a in this.PressedKey)
			{
				if (a == "向前移动")
				{
					this.DollGrabMachineComponent.ClawMoveDirection.Y -= 1f;
				}
				else if (a == "向后移动")
				{
					this.DollGrabMachineComponent.ClawMoveDirection.Y += 1f;
				}
				else if (a == "向左移动")
				{
					this.DollGrabMachineComponent.ClawMoveDirection.X -= 1f;
				}
				else if (a == "向右移动")
				{
					this.DollGrabMachineComponent.ClawMoveDirection.X += 1f;
				}
			}
		}

		// Token: 0x0603B2A2 RID: 242338 RVA: 0x010B9B28 File Offset: 0x010B7D28
		public void OnAxisMoveInput(string name, float value)
		{
			if (!this.IsAllowMoveInput())
			{
				return;
			}
			DgmClawBaseMoveState clawState = this.DollGrabMachineComponent.ClawState;
			if (clawState == null || clawState.ClawState > EDollGrabMachineClawState.Idle)
			{
				DgmClawBaseMoveState clawState2 = this.DollGrabMachineComponent.ClawState;
				if (clawState2 == null || clawState2.ClawState != EDollGrabMachineClawState.Release)
				{
					DgmClawBaseMoveState clawState3 = this.DollGrabMachineComponent.ClawState;
					if (clawState3 == null || clawState3.ClawState != EDollGrabMachineClawState.Grabbing)
					{
						this.DollGrabMachineComponent.ClawMoveDirection.Y = 0f;
						this.DollGrabMachineComponent.ClawMoveDirection.X = 0f;
						this.PressedKey.Clear();
						return;
					}
				}
			}
			if (name == "NavigationTopDown" || name == "UiMoveForward")
			{
				this.DollGrabMachineComponent.ClawMoveDirection.Y = -value;
				return;
			}
			if (name == "NavigationLeftRight" || name == "UiMoveRight")
			{
				this.DollGrabMachineComponent.ClawMoveDirection.X = value;
			}
		}

		// Token: 0x0603B2A3 RID: 242339 RVA: 0x010B9C26 File Offset: 0x010B7E26
		public bool IsAllowMoveInput()
		{
			return this.IsGameplayReadyInternal && this.DollGrabMachineComponent != null;
		}

		// Token: 0x0603B2A4 RID: 242340 RVA: 0x010B9C3C File Offset: 0x010B7E3C
		public void OnClickStart()
		{
			if (this.IsRequesting || this.DollGrabMachineComponent == null)
			{
				return;
			}
			DollGarbInsertCoinRequest dollGarbInsertCoinRequest = DollGarbInsertCoinRequest.Create();
			dollGarbInsertCoinRequest.EntityIncId = this.DollGrabMachineComponent.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
			this.IsRequesting = true;
			Net.Instance.Call(ERequestMessageId.DollGarbInsertCoinRequest, dollGarbInsertCoinRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DollGarbInsertCoinResponse dollGarbInsertCoinResponse = (DollGarbInsertCoinResponse)msg;
				this.IsRequesting = false;
				if (dollGarbInsertCoinResponse == null)
				{
					return;
				}
				ErrorCode errorCode = dollGarbInsertCoinResponse.ErrorCode;
				if (errorCode == ErrorCode.Success)
				{
					this.IsInCountdownInternal = true;
					if (!this.IsEndlessMode)
					{
						AudioSystem.Instance.PostEvent("play_interact_crane_game_ui_insert_coin_01");
					}
					EventSystem.Instance.Emit<Action>(EEventName.OnDollGrabMachineStartCoolDown, new Action(this.StartDollGrabMachineInternal));
					return;
				}
				if (errorCode != ErrorCode.ErrNotEnoughItem)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.DollGrabMachine;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "[StartDollGrabMachine] 开启玩法请求失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", dollGarbInsertCoinResponse.ErrorCode);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DollGrabMachineNoEnoughItem);
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					this.PreExitDollGrabMachine(EDollGrabMachineEndReason.Exit, false);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				global::Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[StartDollGrabMachine] 玩家贝币不足", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, 0);
		}

		// Token: 0x0603B2A5 RID: 242341 RVA: 0x010B9CA0 File Offset: 0x010B7EA0
		public void OnClickGrab()
		{
			if (this.IsGameplayReadyInternal && !(!this.DollGrabMachineComponent))
			{
				DgmClawBaseMoveState clawState = this.DollGrabMachineComponent.ClawState;
				if (clawState != null && clawState.ClawState <= EDollGrabMachineClawState.Idle)
				{
					AudioSystem.Instance.PostEvent("play_nteract_crane_game_crane_open");
					this.DollGrabMachineComponent.ChangeClawState(EDollGrabMachineClawState.Grabbing);
					return;
				}
			}
		}

		// Token: 0x0603B2A6 RID: 242342 RVA: 0x010B9CFC File Offset: 0x010B7EFC
		public void PreExitDollGrabMachine(EDollGrabMachineEndReason reason, bool needResume = false)
		{
			DollGrabMachineController.<>c__DisplayClass51_0 CS$<>8__locals1 = new DollGrabMachineController.<>c__DisplayClass51_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.reason = reason;
			if (this.IsRequesting || this.DollGrabMachineComponent == null)
			{
				if (this.IsRequesting && this.DollGrabMachineComponent != null)
				{
					this.IsCachePreExitReason = new EDollGrabMachineEndReason?(CS$<>8__locals1.reason);
				}
				return;
			}
			if (!this.IsGameplayReadyInternal && !this.IsInCountdownInternal)
			{
				if (CS$<>8__locals1.reason == EDollGrabMachineEndReason.Exit || CS$<>8__locals1.reason == EDollGrabMachineEndReason.Exception)
				{
					this.ExitDollGrabMachine();
				}
				return;
			}
			if (needResume)
			{
				this.IsRequesting = true;
				DollGrabPauseEndRequest dollGrabPauseEndRequest = DollGrabPauseEndRequest.Create();
				dollGrabPauseEndRequest.EntityIncId = this.DollGrabMachineComponent.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
				Net.Instance.Call(ERequestMessageId.DollGrabPauseEndRequest, dollGrabPauseEndRequest, delegate(IMessage msg, Net.CallbackStatus _)
				{
					DollGrabPauseEndResponse dollGrabPauseEndResponse = (DollGrabPauseEndResponse)msg;
					CS$<>8__locals1.<>4__this.IsRequesting = false;
					if (dollGrabPauseEndResponse == null)
					{
						return;
					}
					if (dollGrabPauseEndResponse.ErrorCode != ErrorCode.Success)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.DollGrabMachine;
						ELogAuthor author = ELogAuthor.FJH;
						string message = "[PauseDollGrabMachine] Proto_DollGrabPauseEndRequest fail";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", dollGrabPauseEndResponse.ErrorCode);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					CS$<>8__locals1.<>4__this.ResumeTick();
					CS$<>8__locals1.<>4__this.DollGrabMachineComponent.ResumeDollGrabMachine();
					EventSystem.Instance.Emit(EEventName.OnDollGrabMachineResume);
					base.<PreExitDollGrabMachine>g__onStopDollGrabMachine|0();
				}, 0);
				return;
			}
			CS$<>8__locals1.<PreExitDollGrabMachine>g__onStopDollGrabMachine|0();
		}

		// Token: 0x0603B2A7 RID: 242343 RVA: 0x010B9DC8 File Offset: 0x010B7FC8
		public void ExitDollGrabMachine()
		{
			if (EventSystem.Instance.Has<float>(EEventName.OnDollGrabMachineRemainingTimeAdd, new Action<float>(this.OnAddRemainingTime)))
			{
				EventSystem.Instance.Remove<float>(EEventName.OnDollGrabMachineRemainingTimeAdd, new Action<float>(this.OnAddRemainingTime));
			}
			if (this.DollGrabMachineComponent != null && this.DollGrabMachineComponent.Entity != null)
			{
				this.DollGrabMachineComponent.StopDissolve();
				int pbDataId = this.DollGrabMachineComponent.Entity.GetComponent<CreatureDataComponent>().GetPbDataId();
				EventSystem.Instance.Emit<int, bool>(EEventName.OnDollGrabMachineGameplayStateChanged, pbDataId, false);
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
				if (entityByPbDataId != null && EventSystem.Instance.HasWithTarget<ERemoveEntityType, EntityHandle>(entityByPbDataId, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnDollGrabEntityDestroy)))
				{
					EventSystem.Instance.RemoveWithTarget<ERemoveEntityType, EntityHandle>(entityByPbDataId, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnDollGrabEntityDestroy));
				}
			}
			if (EventSystem.Instance.Has<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseDollGrabMachineView)))
			{
				EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseDollGrabMachineView));
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.DollGrabMachineView))
			{
				UiManager.Instance.CloseView(EUiViewName.DollGrabMachineView, null);
			}
			EventSystem.Instance.Remove<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
			DollGrabModel.Instance.ExecuteRestorePlayerCamera("DollGrabMachineFixCamera", delegate
			{
				this.OnStartShowGrabSequence();
			});
		}

		// Token: 0x0603B2A8 RID: 242344 RVA: 0x010B9F2E File Offset: 0x010B812E
		public void RestartDollGrabMachine()
		{
			EventSystem.Instance.Emit(EEventName.OnDollGrabMachineRestart);
		}

		// Token: 0x0603B2A9 RID: 242345 RVA: 0x010B9F40 File Offset: 0x010B8140
		public void PauseDollGrabMachine(bool isHelp = false)
		{
			if (this.DollGrabMachineComponent == null || this.IsRequesting)
			{
				return;
			}
			if (this.IsGameplayReadyInternal)
			{
				this.IsRequesting = true;
				DollGrabPauseStartRequest dollGrabPauseStartRequest = DollGrabPauseStartRequest.Create();
				dollGrabPauseStartRequest.EntityIncId = this.DollGrabMachineComponent.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
				Net.Instance.Call(ERequestMessageId.DollGrabPauseStartRequest, dollGrabPauseStartRequest, delegate(IMessage msg, Net.CallbackStatus _)
				{
					DollGrabPauseStartResponse dollGrabPauseStartResponse = (DollGrabPauseStartResponse)msg;
					this.IsRequesting = false;
					if (dollGrabPauseStartResponse == null)
					{
						return;
					}
					if (dollGrabPauseStartResponse.ErrorCode != ErrorCode.Success)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.DollGrabMachine;
						ELogAuthor author = ELogAuthor.FJH;
						string message = "[PauseDollGrabMachine] Proto_DollGrabPauseStartRequest fail";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", dollGrabPauseStartResponse.ErrorCode);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					this.PauseTick();
					this.DollGrabMachineComponent.PauseDollGrabMachine();
					if (isHelp)
					{
						if (this.IsEndlessMode)
						{
							HelpController.Instance.OpenHelpById(671);
							this.OnceCloseHelpInfoViewWithCondition(EUiViewName.HelpGuideView);
						}
						else
						{
							UiManager.Instance.OpenView(EUiViewName.DollGrabMachineHelpInfoView, null, null);
							this.OnceCloseHelpInfoViewWithCondition(EUiViewName.DollGrabMachineHelpInfoView);
						}
					}
					else
					{
						UiManager.Instance.OpenView(EUiViewName.DollGrabMachinePauseView, null, null);
					}
					EventSystem.Instance.Emit(EEventName.OnDollGrabMachinePause);
				}, 0);
				return;
			}
			if (!isHelp)
			{
				this.PreExitDollGrabMachine(EDollGrabMachineEndReason.Exit, false);
				return;
			}
			if (this.IsEndlessMode)
			{
				HelpController.Instance.OpenHelpById(671);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DollGrabMachineHelpInfoView, null, null);
		}

		// Token: 0x0603B2AA RID: 242346 RVA: 0x010B9FFC File Offset: 0x010B81FC
		public void ResumeDollGrabMachine()
		{
			if (!this.IsGameplayReadyInternal || this.DollGrabMachineComponent == null || this.IsRequesting)
			{
				return;
			}
			this.IsRequesting = true;
			DollGrabPauseEndRequest dollGrabPauseEndRequest = DollGrabPauseEndRequest.Create();
			dollGrabPauseEndRequest.EntityIncId = this.DollGrabMachineComponent.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
			Net.Instance.Call(ERequestMessageId.DollGrabPauseEndRequest, dollGrabPauseEndRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DollGrabPauseEndResponse dollGrabPauseEndResponse = (DollGrabPauseEndResponse)msg;
				this.IsRequesting = false;
				if (dollGrabPauseEndResponse == null)
				{
					return;
				}
				if (dollGrabPauseEndResponse.ErrorCode != ErrorCode.Success)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.DollGrabMachine;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "[PauseDollGrabMachine] Proto_DollGrabPauseEndRequest fail";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", dollGrabPauseEndResponse.ErrorCode);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				base.ResumeTick();
				this.DollGrabMachineComponent.ResumeDollGrabMachine();
				EventSystem.Instance.Emit(EEventName.OnDollGrabMachineResume);
				if (this.IsCachePreExitReason != null)
				{
					this.PreExitDollGrabMachine(this.IsCachePreExitReason.Value, false);
					this.IsCachePreExitReason = null;
				}
			}, 0);
		}

		// Token: 0x0603B2AB RID: 242347 RVA: 0x010BA068 File Offset: 0x010B8268
		private void OnceCloseHelpInfoViewWithCondition(EUiViewName conditionViewName)
		{
			Action<EUiViewName, int> onCloseHelpInfoView = null;
			onCloseHelpInfoView = delegate(EUiViewName viewName, int viewId)
			{
				if (viewName != conditionViewName)
				{
					return;
				}
				EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, onCloseHelpInfoView);
				this.OnCloseHelpInfoView(viewName, viewId);
			};
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, onCloseHelpInfoView);
		}

		// Token: 0x0603B2AC RID: 242348 RVA: 0x010BA0B5 File Offset: 0x010B82B5
		private void OnCloseHelpInfoView(EUiViewName viewName, int viewId)
		{
			if (!this.IsGameplayReadyInternal)
			{
				return;
			}
			if (viewName == EUiViewName.DollGrabMachineHelpInfoView || viewName == EUiViewName.HelpGuideView)
			{
				this.ResumeDollGrabMachine();
			}
		}

		// Token: 0x17007001 RID: 28673
		// (get) Token: 0x0603B2AD RID: 242349 RVA: 0x010BA0E0 File Offset: 0x010B82E0
		public float RemainingTime
		{
			get
			{
				return this.RemainingTimeInternal;
			}
		}

		// Token: 0x17007002 RID: 28674
		// (get) Token: 0x0603B2AE RID: 242350 RVA: 0x010BA0E8 File Offset: 0x010B82E8
		public float RemainingTimeLimit
		{
			get
			{
				return this.RemainingTimeLimitInternal;
			}
		}

		// Token: 0x17007003 RID: 28675
		// (get) Token: 0x0603B2AF RID: 242351 RVA: 0x010BA0F0 File Offset: 0x010B82F0
		public float AddRemainingTime
		{
			get
			{
				return this.AddRemainingTimeInternal;
			}
		}

		// Token: 0x0603B2B0 RID: 242352 RVA: 0x010BA0F8 File Offset: 0x010B82F8
		private void OnAddRemainingTime(float addTime)
		{
			this.RemainingTimeInternal += addTime;
			this.AddRemainingTimeInternal += addTime;
			if (this.RemainingTimeInternal > this.RemainingTimeLimitInternal)
			{
				this.AddRemainingTimeInternal -= this.RemainingTimeInternal - this.RemainingTimeLimitInternal;
				this.RemainingTimeInternal = this.RemainingTimeLimitInternal;
			}
		}

		// Token: 0x0603B2B1 RID: 242353 RVA: 0x010BA158 File Offset: 0x010B8358
		private void ToggleScreenEffect(bool toggle)
		{
			string text = DollGrabModel.Instance.DollGrabMachineGlobalConfig.倒计时屏幕特效.ToAssetPathName();
			if (text.Length == 0)
			{
				return;
			}
			if (toggle && this.ScreenEffectHandle == null && this.DollGrabMachineComponent != null)
			{
				EffectSystem instance = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(this.DollGrabMachineComponent.ActorTransform);
				this.ScreenEffectHandle = new int?(instance.SpawnEffect(world, ftransformDouble, text, "[DollGrabMachineController.ToggleScreenEffect] 开启屏幕特效", new EffectContext(new int?(this.DollGrabMachineComponent.Entity.Id), null, false), global::EEffectType.Scene, null, null, null, false, false));
				return;
			}
			if (!toggle && this.ScreenEffectHandle != null)
			{
				EffectSystem.Instance.StopEffectById(this.ScreenEffectHandle.Value, "[DollGrabMachineController.ToggleScreenEffect] 停止屏幕特效", true, null);
				this.ScreenEffectHandle = null;
			}
		}

		// Token: 0x0603B2B2 RID: 242354 RVA: 0x010BA234 File Offset: 0x010B8434
		private void OnStartShowGrabSequence()
		{
			if (this.DollGrabMachineComponent == null)
			{
				return;
			}
			if (this.DollGrabMachineComponent.MainDollActor == null)
			{
				this.DollGrabMachineComponent = null;
				return;
			}
			CameraController.Instance.MainModel.SceneCamera.DisplayComponent.SetUiActive(false);
			LevelLoadingController instance = LevelLoadingController.Instance;
			ELoadingReason reason = ELoadingReason.SimpleLevelSequence;
			ELoadingPerform perform = ELoadingPerform.CameraFade;
			string context = "SimpleLevelSequenceProcess";
			Action callback = new Action(this.OnStartShowGrabSequenceInternal);
			object[] array = new object[2];
			int num = 0;
			BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
			array[num] = ((dollGrabMachineGlobalConfig != null) ? dollGrabMachineGlobalConfig.黑幕淡入时间 : 0f);
			array[1] = EFadeInScreenShowType.Black;
			instance.OpenLoading<ELoadingPerform>(reason, perform, context, callback, array);
		}

		// Token: 0x0603B2B3 RID: 242355 RVA: 0x010BA2C8 File Offset: 0x010B84C8
		private void OnStartShowGrabSequenceInternal()
		{
			if (this.DollGrabMachineComponent == null || this.DollGrabMachineComponent.MainDollActor == null)
			{
				return;
			}
			FTransformDouble ftransformDouble = new FTransformDouble();
			global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			FVectorDouble fvectorDouble = DollGrabModel.Instance.DollGrabMachineGlobalConfig.阿布展示播放位置;
			commonTempVector.FromUeVector(fvectorDouble);
			global::Vector commonTempVector2 = MathUtils.Instance.CommonTempVector;
			FQuat rotation = this.DollGrabMachineComponent.ActorTransform.GetRotation();
			fvectorDouble = MathUtils.Instance.CommonTempVector.ToUeVector(false);
			FVector fvector = fvectorDouble;
			FVector fvector2 = rotation.RotateVector(fvector);
			commonTempVector2.FromUeVector(fvector2);
			global::Vector commonTempVector3 = MathUtils.Instance.CommonTempVector2;
			fvectorDouble = this.DollGrabMachineComponent.ActorTransform.GetLocation();
			commonTempVector3.FromUeVector(fvectorDouble);
			MathUtils.Instance.CommonTempVector2.Addition(MathUtils.Instance.CommonTempVector, MathUtils.Instance.CommonTempVector);
			fvectorDouble = MathUtils.Instance.CommonTempVector.ToUeVector(false);
			ftransformDouble.SetTranslation(fvectorDouble);
			AKuroLevelSequenceActor akuroLevelSequenceActor = ActorSystem.Instance.Get<AKuroLevelSequenceActor>(AKuroLevelSequenceActor.StaticClass(), ftransformDouble, null, false);
			if (akuroLevelSequenceActor != null)
			{
				this.ShowSequenceActor = akuroLevelSequenceActor;
				this.ShowSequenceActor.SetSequence(DollGrabModel.Instance.DollGrabShowSequence);
				UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.ShowSequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
				this.ShowSequenceActor.bOverrideInstanceData = true;
				udefaultLevelSequenceInstanceData.TransformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(ftransformDouble);
				udefaultLevelSequenceInstanceData.TransformOriginActor = this.ShowSequenceActor;
				this.ShowSequenceActor.DefaultInstanceData = udefaultLevelSequenceInstanceData;
				this.SetBindingInGrabSequence();
			}
		}

		// Token: 0x0603B2B4 RID: 242356 RVA: 0x010BA440 File Offset: 0x010B8640
		private void SetBindingInGrabSequence()
		{
			if (this.ShowSequenceActor == null || this.DollGrabMachineComponent == null || this.DollGrabMachineComponent.MainDollActor == null)
			{
				return;
			}
			global::Log.Instance.Info(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineController] OnStartShowGrabSequenceInternal 绑定 播放", default(ReadOnlySpan<ValueTuple<string, object>>));
			TArray<AActor> tarray = new TArray<AActor>();
			tarray.Add(this.DollGrabMachineComponent.MainDollActor);
			this.DollGrabMachineComponent.ToggleShowMainDollActor(true, false);
			this.ShowSequenceActor.SetBindingByTag(new FName("WaWa"), tarray, false, false);
			tarray.Empty(true);
			this.ShowSequenceCamera = CameraController.Instance.MainModel.SceneCamera.DisplayComponent.GetUnBoundSceneCamera(ESceneSubCameraType.Fix);
			this.ShowSequenceCamera.IsKeepUi = false;
			this.ShowSequenceCamera.FadeIn = 0f;
			this.ShowSequenceCamera.FadeOut = 0f;
			tarray.Add(this.ShowSequenceCamera.Camera);
			this.ShowSequenceActor.SetBindingByTag(new FName("SequenceCamera"), tarray, false, false);
			tarray.Empty(true);
			ULevelSequencePlayer sequencePlayer = this.ShowSequenceActor.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.OnFinished.Add(new Action(this.OnFinishShowGrabSequence));
			}
			BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
			if (dollGrabMachineGlobalConfig != null && dollGrabMachineGlobalConfig.黑幕持续时间 > 0f)
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					LevelLoadingController instance = LevelLoadingController.Instance;
					ELoadingReason reason = ELoadingReason.SimpleLevelSequence;
					string context = "SimpleLevelSequenceProcess";
					Action callback = null;
					BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig2 = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
					instance.CloseLoading(reason, context, callback, new float?((dollGrabMachineGlobalConfig2 != null) ? dollGrabMachineGlobalConfig2.黑幕淡出时间 : 0f));
				}, dollGrabMachineGlobalConfig.黑幕持续时间 * 1000f, null, null, true, 1f);
			}
			else
			{
				LevelLoadingController.Instance.CloseLoading(ELoadingReason.SimpleLevelSequence, "SimpleLevelSequenceProcess", null, new float?((dollGrabMachineGlobalConfig != null) ? dollGrabMachineGlobalConfig.黑幕淡出时间 : 0f));
			}
			ECustomCameraMode? cameraMode = CameraModel.Instance.MainModel.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Scene;
			if (cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null)
			{
				CameraController.Instance.MainModel.SceneCamera.PlayerComponent.EnterSceneSubCamera(this.ShowSequenceCamera, null);
			}
			else
			{
				CameraController.Instance.EnterCameraMode(ECustomCameraMode.Scene, 0f, UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear, 0f, null, false, "MainCamera", null);
			}
			this.ShowSequenceCamera.IsBinding = true;
			ULevelSequencePlayer sequencePlayer2 = this.ShowSequenceActor.SequencePlayer;
			if (sequencePlayer2 == null)
			{
				return;
			}
			sequencePlayer2.Play();
		}

		// Token: 0x0603B2B5 RID: 242357 RVA: 0x010BA680 File Offset: 0x010B8880
		private void OnFinishShowGrabSequence()
		{
			global::Log.Instance.Info(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineController] OnStartShowGrabSequenceInternal 播放结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.SimpleLevelSequence, ELoadingPerform.CameraFade, "SimpleLevelSequenceProcess", delegate
			{
				ULevelSequencePlayer sequencePlayer = this.ShowSequenceActor.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.OnFinished.Remove(new Action(this.OnFinishShowGrabSequence));
				}
				ActorSystem.Instance.Put("DollGrabMachineController.ShowSequenceActorFinish", this.ShowSequenceActor, null);
				this.ShowSequenceActor = null;
				CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitSceneSubCamera(this.ShowSequenceCamera, null, null);
				CameraController.Instance.MainModel.SceneCamera.DisplayComponent.RemoveBoundSceneCamera(this.ShowSequenceCamera);
				this.ShowSequenceCamera = null;
				this.DollGrabMachineComponent.ToggleShowMainDollActor(false, true);
				BP_DollGrabMachineGlobalConfig_C config = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
				if (config != null && config.黑幕持续时间 > 0f)
				{
					TimerSystem.Instance.Delay(delegate(float _)
					{
						LevelLoadingController.Instance.CloseLoading(ELoadingReason.SimpleLevelSequence, "SimpleLevelSequenceProcess", new Action(this.OnCompleterShowGrabSequence), new float?(config.黑幕淡出时间));
					}, config.黑幕持续时间 * 1000f, null, null, true, 1f);
					return;
				}
				LevelLoadingController instance = LevelLoadingController.Instance;
				ELoadingReason reason = ELoadingReason.SimpleLevelSequence;
				string context = "SimpleLevelSequenceProcess";
				Action callback = new Action(this.OnCompleterShowGrabSequence);
				BP_DollGrabMachineGlobalConfig_C config2 = config;
				instance.CloseLoading(reason, context, callback, new float?((config2 != null) ? config2.黑幕淡出时间 : 0f));
			}, new object[]
			{
				0,
				EFadeInScreenShowType.Black
			});
		}

		// Token: 0x0603B2B6 RID: 242358 RVA: 0x010BA6E4 File Offset: 0x010B88E4
		private void OnCompleterShowGrabSequence()
		{
			global::Log.Instance.Info(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineController] OnStartShowGrabSequenceInternal 关闭退出黑幕", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.DollGrabMachineComponent = null;
			CameraController.Instance.MainModel.SceneCamera.DisplayComponent.SetUiActive(true);
		}

		// Token: 0x0603B2B7 RID: 242359 RVA: 0x010BA734 File Offset: 0x010B8934
		private void OnTeamLivingStateChange(bool isMyTeam, ETeamGroupType groupType, ETeamLivingState state, ETeamLivingState oldState)
		{
			if (isMyTeam && groupType == ETeamGroupType.Battle && state == ETeamLivingState.Dead)
			{
				this.PreExitDollGrabMachine(EDollGrabMachineEndReason.Exception, false);
				global::Log.Instance.Info(ELogModule.DollGrabMachine, ELogAuthor.FJH, "OnTeamLivingStateChange 角色死亡，关闭抓娃娃机", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x0603B2B8 RID: 242360 RVA: 0x010BA774 File Offset: 0x010B8974
		private void OnDollGrabEntityDestroy(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (handle.Entity == this.DollGrabMachineComponent.Entity)
			{
				global::Log.Instance.Info(ELogModule.DollGrabMachine, ELogAuthor.FJH, "OnDollGrabEntityDestroy 实体销毁，关闭抓娃娃机", default(ReadOnlySpan<ValueTuple<string, object>>));
				DollGrabMachineController.Instance.PreExitDollGrabMachine(EDollGrabMachineEndReason.Exception, false);
				EventSystem.Instance.RemoveWithTarget<ERemoveEntityType, EntityHandle>(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnDollGrabEntityDestroy));
			}
		}

		// Token: 0x0603B2B9 RID: 242361 RVA: 0x010BA7DC File Offset: 0x010B89DC
		private void OnCloseDollGrabMachineView(EUiViewName viewName, int viewId)
		{
			if (viewName == EUiViewName.DollGrabMachineView)
			{
				this.PreExitDollGrabMachine(EDollGrabMachineEndReason.Exit, false);
			}
		}

		// Token: 0x17007004 RID: 28676
		// (get) Token: 0x0603B2BA RID: 242362 RVA: 0x010BA7F3 File Offset: 0x010B89F3
		public static DollGrabMachineController Instance
		{
			get
			{
				return DollGrabMachineController._Instance;
			}
		}

		// Token: 0x0603B2BB RID: 242363 RVA: 0x010BA7FA File Offset: 0x010B89FA
		public static DollGrabMachineController GetOrCreateInstance()
		{
			if (DollGrabMachineController._Instance == null)
			{
				DollGrabMachineController.CreateInstance();
			}
			return DollGrabMachineController._Instance;
		}

		// Token: 0x0603B2BC RID: 242364 RVA: 0x010BA80E File Offset: 0x010B8A0E
		public static bool CreateInstance()
		{
			if (DollGrabMachineController._Instance != null)
			{
				return true;
			}
			DollGrabMachineController._Instance = new DollGrabMachineController();
			return true;
		}

		// Token: 0x0603B2BD RID: 242365 RVA: 0x010BA824 File Offset: 0x010B8A24
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B2BE RID: 242366 RVA: 0x010BA826 File Offset: 0x010B8A26
		public static void ResetStaticDefaultValue()
		{
			DollGrabMachineController._Instance = null;
		}

		// Token: 0x0603B2BF RID: 242367 RVA: 0x010BA82E File Offset: 0x010B8A2E
		static DollGrabMachineController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DollGrabMachineController.CreateStaticDefaultValue), new Action(DollGrabMachineController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F21B RID: 127515
		[Nullable(2)]
		private SceneItemDollGrabMachineComponent DollGrabMachineComponent;

		// Token: 0x0401F21C RID: 127516
		private readonly HashSet<string> PressedKey = new HashSet<string>();

		// Token: 0x0401F21D RID: 127517
		private bool IsGameplayReadyInternal;

		// Token: 0x0401F21E RID: 127518
		private bool IsInCountdownInternal;

		// Token: 0x0401F21F RID: 127519
		private readonly HashSet<SceneItemDollGrabMachineComponent> DollGrabMachineComponentSet = new HashSet<SceneItemDollGrabMachineComponent>();

		// Token: 0x0401F220 RID: 127520
		private readonly HashSet<SceneItemDollGrabMachineComponent> TickComponentSet = new HashSet<SceneItemDollGrabMachineComponent>();

		// Token: 0x0401F221 RID: 127521
		private float RemainingTimeLimitInternal;

		// Token: 0x0401F222 RID: 127522
		private float RemainingTimeInternal;

		// Token: 0x0401F223 RID: 127523
		private float AddRemainingTimeInternal;

		// Token: 0x0401F224 RID: 127524
		private int? ScreenEffectHandle;

		// Token: 0x0401F225 RID: 127525
		private bool IsDangerousCountdownInternal;

		// Token: 0x0401F226 RID: 127526
		[Nullable(2)]
		private AKuroLevelSequenceActor ShowSequenceActor;

		// Token: 0x0401F227 RID: 127527
		[Nullable(2)]
		private SceneSubCamera ShowSequenceCamera;

		// Token: 0x0401F228 RID: 127528
		private EDollGrabMachineEndReason? IsCachePreExitReason;

		// Token: 0x0401F229 RID: 127529
		private bool IsRequesting;

		// Token: 0x0401F22A RID: 127530
		[Nullable(2)]
		private static DollGrabMachineController _Instance;
	}
}
