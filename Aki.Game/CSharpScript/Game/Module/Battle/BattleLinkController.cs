using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Sequence.Common_Seq.Video.SplitScreen;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C46 RID: 23622
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class BattleLinkController : ControllerBase
	{
		// Token: 0x0603BAD9 RID: 244441 RVA: 0x00E3E6BC File Offset: 0x00E3C8BC
		protected override bool OnInit()
		{
			Net instance = Net.Instance;
			ENotifyMessageId id = ENotifyMessageId.LinkingStateNotify;
			Action<IMessage, Net.CallbackStatus> callback;
			if ((callback = BattleLinkController.<>O.<0>__HandleLinkingStateNotify) == null)
			{
				callback = (BattleLinkController.<>O.<0>__HandleLinkingStateNotify = new Action<IMessage, Net.CallbackStatus>(BattleLinkController.HandleLinkingStateNotify));
			}
			instance.Register(id, callback);
			Net instance2 = Net.Instance;
			ENotifyMessageId id2 = ENotifyMessageId.LinkExitNotify;
			Action<IMessage, Net.CallbackStatus> callback2;
			if ((callback2 = BattleLinkController.<>O.<1>__HandleLinkExitNotify) == null)
			{
				callback2 = (BattleLinkController.<>O.<1>__HandleLinkExitNotify = new Action<IMessage, Net.CallbackStatus>(BattleLinkController.HandleLinkExitNotify));
			}
			instance2.Register(id2, callback2);
			return true;
		}

		// Token: 0x0603BADA RID: 244442 RVA: 0x00E3E720 File Offset: 0x00E3C920
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.LinkingStateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.LinkExitNotify);
			this.UnbindEvents();
			return true;
		}

		// Token: 0x0603BADB RID: 244443 RVA: 0x00E3E74C File Offset: 0x00E3C94C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		protected override ValueTuple<string, CustomPromise<bool>>? OnPreload()
		{
			if (!BattleLinkModel.Instance.CheckInBattleLink())
			{
				return null;
			}
			this.BindEvents();
			this.InitSequenceActor();
			if (BattleLinkModel.Instance.CheckInDreamLink())
			{
				CustomPromise<bool> item = BattleLinkModel.Instance.PreloadTeamRoleRes();
				return new ValueTuple<string, CustomPromise<bool>>?(new ValueTuple<string, CustomPromise<bool>>("BattleLinkController", item));
			}
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo != null && gameInfo.InBattle && BattleLinkModel.Instance.CheckInNewBattleLink())
			{
				CustomPromise<bool> item2 = BattleLinkModel.Instance.PreloadTeamRoleRes();
				return new ValueTuple<string, CustomPromise<bool>>?(new ValueTuple<string, CustomPromise<bool>>("BattleLinkController", item2));
			}
			return null;
		}

		// Token: 0x0603BADC RID: 244444 RVA: 0x00E3E7EC File Offset: 0x00E3C9EC
		protected override bool OnLeaveLevel()
		{
			this.UnbindEvents();
			this.IsPlayingSplitScreen = false;
			if (this.LevelSeqActor != null)
			{
				ULevelSequencePlayer sequencePlayer = this.LevelSeqActor.SequencePlayer;
				if (sequencePlayer != null && sequencePlayer.IsPlaying())
				{
					ULevelSequencePlayer sequencePlayer2 = this.LevelSeqActor.SequencePlayer;
					if (sequencePlayer2 != null)
					{
						sequencePlayer2.Stop();
					}
				}
				ActorSystem.Instance.Put("BattleLinkController.OnLeaveLevel", this.LevelSeqActor, null);
			}
			this.LevelSeqActor = null;
			if (this.Timer != null)
			{
				TimerSystem.Instance.Remove(this.Timer);
				this.Timer = null;
				this.OnTimerEnd();
			}
			if (this.VisibleId != null)
			{
				BattleUiControl.Instance.SetBattleViewVisible(this.VisibleId.Value);
			}
			this.VisibleId = null;
			if (this.IsInLinkExplosion)
			{
				UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("BattleLinkController.LinkExplosionStart");
				GameModeController.Instance.SetTimeDilation(1f, ETimeDilationType.Default);
			}
			this.IsInLinkExplosion = false;
			this.EntityCache.Clear();
			this.NeedEntityCache = true;
			this.RecoverRotation = null;
			this.CurrentLinkBurstBuffs = null;
			this.RoleIdQueue = null;
			return true;
		}

		// Token: 0x0603BADD RID: 244445 RVA: 0x00E3E90C File Offset: 0x00E3CB0C
		private void BindEvents()
		{
			if (this.HasBindEvents)
			{
				return;
			}
			this.HasBindEvents = true;
			if (BattleLinkModel.Instance.CheckInDreamLink())
			{
				EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
				EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
			}
			if (BattleLinkModel.Instance.CheckInNewBattleLink())
			{
				EventSystem.Instance.Add(EEventName.CharOnRoleDead, new Action<int>(this.OnCharDead));
				EventSystem.Instance.Add<Entity>(EEventName.OnRevive, new Action<Entity>(this.OnCharRevive));
			}
			if (BattleLinkModel.Instance.CheckInSpecialBattleLink())
			{
				int playerId = CreatureModel.Instance.GetPlayerId();
				WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
				if (playerEntity != null)
				{
					LinkParam? linkParam = BattleLinkConfig.Instance.GetLinkParam(1);
					if (linkParam != null)
					{
						LinkParam valueOrDefault = linkParam.GetValueOrDefault();
						this.LinkBuffRoleIdMap = new Dictionary<long, int>();
						foreach (KeyValuePair<int, int> keyValuePair in valueOrDefault.LinkBuffRoleMap())
						{
							AbilityEvent.Instance.Add(playerEntity, EAbilityEventName.OnBuffAdd, (long)keyValuePair.Key, new Action<long, int>(this.OnBuffAdd));
							this.LinkBuffRoleIdMap[(long)keyValuePair.Key] = keyValuePair.Value;
						}
					}
					this.AbilityEventEntity = playerEntity;
				}
			}
		}

		// Token: 0x0603BADE RID: 244446 RVA: 0x00E3EA88 File Offset: 0x00E3CC88
		private void UnbindEvents()
		{
			if (!this.HasBindEvents)
			{
				return;
			}
			this.HasBindEvents = false;
			if (EventSystem.Instance.Has(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam)))
			{
				EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
			}
			if (EventSystem.Instance.Has<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill)))
			{
				EventSystem.Instance.Remove<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
			}
			if (EventSystem.Instance.Has(EEventName.CharOnRoleDead, new Action<int>(this.OnCharDead)))
			{
				EventSystem.Instance.Remove(EEventName.CharOnRoleDead, new Action<int>(this.OnCharDead));
			}
			if (EventSystem.Instance.Has(EEventName.OnRevive, new Action<Entity>(this.OnCharRevive)))
			{
				EventSystem.Instance.Remove(EEventName.OnRevive, new Action<Entity>(this.OnCharRevive));
			}
			if (BattleLinkModel.Instance.CheckInSpecialBattleLink() && this.AbilityEventEntity != null && this.LinkBuffRoleIdMap != null)
			{
				foreach (long key in this.LinkBuffRoleIdMap.Keys)
				{
					AbilityEvent.Instance.Remove(this.AbilityEventEntity, EAbilityEventName.OnBuffAdd, key, new Action<long, int>(this.OnBuffAdd));
				}
			}
			this.AbilityEventEntity = null;
			this.LinkBuffRoleIdMap = null;
		}

		// Token: 0x0603BADF RID: 244447 RVA: 0x00E3EC10 File Offset: 0x00E3CE10
		private void InitSequenceActor()
		{
			if (this.LevelSeqActor == null)
			{
				this.LevelSeqActor = (ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, false) as ALevelSequenceActor);
			}
		}

		// Token: 0x0603BAE0 RID: 244448 RVA: 0x00E3EC40 File Offset: 0x00E3CE40
		private void OnCharUseSkill(int entityId, int skillId, bool isAutonomousProxy)
		{
			if (this.NeedEntityCache && !this.EntityCache.ContainsKey(entityId))
			{
				this.AddEntityCache(entityId);
			}
			EntityHandle entityHandle;
			if (!this.EntityCache.TryGetValue(entityId, out entityHandle))
			{
				return;
			}
			WorldEntity entity = entityHandle.Entity;
			CharacterSkillComponent characterSkillComponent = (entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent != null && characterSkillComponent.HasSkillGenre(skillId, ESkillGenre.大招3) && BattleLinkModel.Instance.CanUseLinkSkill(new int?(entityId)))
			{
				BattleLinkModel.Instance.AddLinkEntityId(entityId);
				EventSystem.Instance.Emit(EEventName.OnBattleLinkStop);
				EventSystem.Instance.Emit<ELinkStatus>(EEventName.OnBattleLinkStatusChanged, ELinkStatus.Link);
			}
		}

		// Token: 0x0603BAE1 RID: 244449 RVA: 0x00E3ECDC File Offset: 0x00E3CEDC
		private void OnUpdateSceneTeam()
		{
			if (BattleLinkModel.Instance.CheckInNewBattleLink())
			{
				this.TeamEntityIdList.Clear();
				foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(false))
				{
					EntityHandle entityHandle = sceneTeamItem.EntityHandle;
					int? num;
					if (entityHandle == null)
					{
						num = null;
					}
					else
					{
						WorldEntity entity = entityHandle.Entity;
						num = ((entity != null) ? new int?(entity.Id) : null);
					}
					int? num2 = num;
					int valueOrDefault = num2.GetValueOrDefault();
					if (valueOrDefault != 0)
					{
						this.TeamEntityIdList.Add(valueOrDefault);
					}
				}
				EventSystem.Instance.Emit<ENewLinkStatus>(EEventName.OnNewLinkStatusChanged, BattleLinkModel.Instance.GetNewLinkStatus());
				return;
			}
			List<int> teamRoleConfigIdList = SceneTeamModel.Instance.GetTeamRoleConfigIdList(false, true);
			BattleLinkModel.Instance.SetRoleIdList(teamRoleConfigIdList);
			BattleLinkModel.Instance.ResetMainBp();
			this.EntityCache.Clear();
			this.NeedEntityCache = true;
		}

		// Token: 0x0603BAE2 RID: 244450 RVA: 0x00E3EDE0 File Offset: 0x00E3CFE0
		private void OnCharDead(int entityId)
		{
			this.OnCharDeadOrAliveChanged(entityId, true);
		}

		// Token: 0x0603BAE3 RID: 244451 RVA: 0x00E3EDEA File Offset: 0x00E3CFEA
		[NullableContext(1)]
		private void OnCharRevive(Entity entity)
		{
			this.OnCharDeadOrAliveChanged(entity.Id, false);
		}

		// Token: 0x0603BAE4 RID: 244452 RVA: 0x00E3EDF9 File Offset: 0x00E3CFF9
		private void OnCharDeadOrAliveChanged(int entityId, bool isDead)
		{
			if (!this.TeamEntityIdList.Contains(entityId))
			{
				return;
			}
			EventSystem.Instance.Emit<ENewLinkStatus>(EEventName.OnNewLinkStatusChanged, BattleLinkModel.Instance.GetNewLinkStatus());
		}

		// Token: 0x0603BAE5 RID: 244453 RVA: 0x00E3EE24 File Offset: 0x00E3D024
		private void OnBuffAdd(long buffId, int handle)
		{
			Dictionary<long, int> linkBuffRoleIdMap = this.LinkBuffRoleIdMap;
			int num = (linkBuffRoleIdMap != null) ? linkBuffRoleIdMap.GetValueOrDefault(buffId) : 0;
			if (num != 0)
			{
				if (this.RoleIdQueue == null)
				{
					this.RoleIdQueue = new List<int>();
				}
				if (!this.RoleIdQueue.Contains(num))
				{
					int item = num;
					LinkParam? linkParam = BattleLinkConfig.Instance.GetLinkParam(1);
					if (linkParam != null)
					{
						LinkParam valueOrDefault = linkParam.GetValueOrDefault();
						if (valueOrDefault.ChangeGenderMap().ContainsKey(num))
						{
							MainRoleConfig? mainRoleById = RoleConfig.Instance.GetMainRoleById(num);
							if (mainRoleById != null && mainRoleById.GetValueOrDefault().Gender != (int)PlayerInfoModel.Instance.GetPlayerGender())
							{
								int valueOrDefault2 = valueOrDefault.ChangeGenderMap().GetValueOrDefault(num, 0);
								if (valueOrDefault2 != 0)
								{
									item = valueOrDefault2;
								}
							}
						}
					}
					if (!this.RoleIdQueue.Contains(item))
					{
						this.RoleIdQueue.Insert(0, item);
					}
					if (this.RoleIdQueue.Count > 3)
					{
						this.RoleIdQueue.RemoveRange(3, this.RoleIdQueue.Count - 3);
					}
				}
			}
		}

		// Token: 0x0603BAE6 RID: 244454 RVA: 0x00E3EF28 File Offset: 0x00E3D128
		private void AddEntityCache(int entityId)
		{
			if (this.EntityCache.ContainsKey(entityId))
			{
				return;
			}
			int playerId = CreatureModel.Instance.GetPlayerId();
			List<SceneTeamRole> roleList = SceneTeamModel.Instance.GetTeamPlayerData(playerId).GetCurrentGroup().GetRoleList();
			int num = 0;
			foreach (SceneTeamRole sceneTeamRole in roleList)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(sceneTeamRole.CreatureDataId);
				if (entity.Entity.Id == entityId)
				{
					this.EntityCache[entity.Entity.Id] = entity;
				}
				if (this.EntityCache.ContainsKey(entity.Entity.Id))
				{
					num++;
				}
			}
			if (num == roleList.Count)
			{
				this.NeedEntityCache = false;
			}
		}

		// Token: 0x0603BAE7 RID: 244455 RVA: 0x00E3F00C File Offset: 0x00E3D20C
		public void UseLinkSkill(Entity entity)
		{
			if (entity == null)
			{
				return;
			}
			if (this.MessageId == null)
			{
				return;
			}
			if (BattleLinkModel.Instance.HasLinkEntityId(entity.Id))
			{
				return;
			}
			CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
			long value = this.MessageId.Value;
			long? long54Config = ConfigCommonParamById.GetLong54Config("LinkSkillNotifyBuff");
			if (long54Config != null)
			{
				component.AddBuff(long54Config.Value, new AddBuffParam
				{
					InstigatorId = component.CreatureDataId,
					Reason = "触发Link大招",
					PreMessageId = new long?(value)
				});
			}
		}

		// Token: 0x0603BAE8 RID: 244456 RVA: 0x00E3F09C File Offset: 0x00E3D29C
		public void StartLink(double startTime = 0.0)
		{
			double num = (startTime == 0.0) ? TimeUtil.Instance.GetServerTimeStamp() : startTime;
			if (UiManager.Instance.IsViewOpen(EUiViewName.BattleLinkView))
			{
				EventSystem.Instance.Emit<double>(EEventName.OnBattleLinkRestart, num);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.BattleLinkView, num, null);
		}

		// Token: 0x0603BAE9 RID: 244457 RVA: 0x00E3F0FC File Offset: 0x00E3D2FC
		public void StopLink()
		{
			EventSystem.Instance.Emit(EEventName.OnBattleLinkStop);
		}

		// Token: 0x0603BAEA RID: 244458 RVA: 0x00E3F10E File Offset: 0x00E3D30E
		public void StartLinkExplosion()
		{
			this.StopLink();
			this.TryPlaySplitScreen();
		}

		// Token: 0x0603BAEB RID: 244459 RVA: 0x00E3F11C File Offset: 0x00E3D31C
		public void TryPlaySplitScreen()
		{
			if (this.IsPlayingSplitScreen)
			{
				return;
			}
			if (!BattleLinkModel.Instance.CheckSplitScreenRes() || this.LevelSeqActor == null)
			{
				return;
			}
			this.IsPlayingSplitScreen = true;
			BattleLinkModel.Instance.PlayRoleAnim(true);
			if (BattleLinkModel.Instance.GetSplitScreenMainBp().IsT2)
			{
				this.Timer = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.Timer = null;
					this.PlaySplitScreenSeq();
				}, 100f, null, null, true, 1f);
			}
			else
			{
				this.PlaySplitScreenEffect();
			}
			this.LinkExplosionStart();
		}

		// Token: 0x0603BAEC RID: 244460 RVA: 0x00E3F1A4 File Offset: 0x00E3D3A4
		private void PlaySplitScreenEffect()
		{
			WorldEntity entity = SceneTeamModel.Instance.GetCurrentEntity.Entity;
			if (entity != null)
			{
				CharacterGameplayCueComponent component = entity.GetComponent<CharacterGameplayCueComponent>();
				if (component != null)
				{
					this.ScreenEffectCueHandle = component.AddCue(10010093L, null);
				}
			}
			float interval = 0.3f * (float)TimeUtil.Instance.InverseMillisecond;
			this.Timer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.Timer = null;
				this.OnTimerEnd();
				this.PlaySplitScreenSeq();
			}, interval, null, null, true, 1f);
		}

		// Token: 0x0603BAED RID: 244461 RVA: 0x00E3F220 File Offset: 0x00E3D420
		private void OnTimerEnd()
		{
			WorldEntity entity = SceneTeamModel.Instance.GetCurrentEntity.Entity;
			if (entity != null)
			{
				CharacterGameplayCueComponent component = entity.GetComponent<CharacterGameplayCueComponent>();
				if (component != null)
				{
					component.RemoveCueByHandle((long)this.ScreenEffectCueHandle);
				}
			}
		}

		// Token: 0x0603BAEE RID: 244462 RVA: 0x00E3F258 File Offset: 0x00E3D458
		private void PlaySplitScreenSeq()
		{
			BattleLinkModel instance = BattleLinkModel.Instance;
			OneOf<BP_SplitScreen_C, BP_SplitScreen_New_C> splitScreenMainBp = instance.GetSplitScreenMainBp();
			ULevelSequence splitScreenSeq = instance.GetSplitScreenSeq();
			if (!splitScreenMainBp.HasValue || splitScreenSeq == null || this.LevelSeqActor == null)
			{
				this.LinkExplosionEnd();
				return;
			}
			AudioSystem.Instance.SetState("sp_rogue_link_vo_reuse_burst", "vo_reuse", true);
			instance.InitBeforeStart();
			instance.PlayRoleAnim(false);
			AudioSystem.Instance.SetState("game_rogue_link_state", "in_link", true);
			instance.PlayRoleLinkAudio();
			global::Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
			this.RecoverRotation = new FRotator?(new FRotator(cameraRotator.Pitch, cameraRotator.Yaw, cameraRotator.Roll));
			CameraController.Instance.MainModel.SequenceCamera.PlayerComponent.SetBlendTime(0f, 0f);
			CameraController.Instance.MainModel.SequenceCamera.PlayerComponent.StopSequence();
			BP_CineCamera_C cineCamera = CameraModel.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera;
			this.LevelSeqActor.SetSequence(splitScreenSeq);
			this.BindingActors.Add(cineCamera);
			this.LevelSeqActor.SetBindingByTag(BattleLinkController.SeqCameraTag, this.BindingActors, false, false);
			this.BindingActors.Empty(true);
			this.BindingActors.Add((AActor)splitScreenMainBp.GetValue());
			this.LevelSeqActor.SetBindingByTag(BattleLinkController.CharacterTag, this.BindingActors, false, false);
			this.BindingActors.Empty(true);
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, false, "MainCamera", null);
			if (splitScreenMainBp.IsT1)
			{
				BP_SplitScreen_C asT = splitScreenMainBp.AsT1;
				asT.SetActorHiddenInGame(false);
				asT.Start();
			}
			else
			{
				BP_SplitScreen_New_C asT2 = splitScreenMainBp.AsT2;
				asT2.SetActorHiddenInGame(false);
				asT2.Start();
			}
			this.LevelSeqActor.SequencePlayer.OnFinished.Clear();
			this.LevelSeqActor.SequencePlayer.OnFinished.Add(new Action(this.OnSequenceFinished));
			this.LevelSeqActor.SequencePlayer.Play();
		}

		// Token: 0x0603BAEF RID: 244463 RVA: 0x00E3F468 File Offset: 0x00E3D668
		private void OnSequenceFinished()
		{
			this.IsPlayingSplitScreen = false;
			AudioSystem.Instance.SetState("sp_rogue_link_vo_reuse_burst", "none", true);
			OneOf<BP_SplitScreen_C, BP_SplitScreen_New_C> splitScreenMainBp = BattleLinkModel.Instance.GetSplitScreenMainBp();
			if (splitScreenMainBp.HasValue)
			{
				if (splitScreenMainBp.IsT1)
				{
					BP_SplitScreen_C asT = splitScreenMainBp.AsT1;
					asT.End();
					asT.SetActorHiddenInGame(true);
				}
				else
				{
					BP_SplitScreen_New_C asT2 = splitScreenMainBp.AsT2;
					asT2.End();
					asT2.SetActorHiddenInGame(true);
				}
			}
			BP_CineCamera_C cineCamera = CameraModel.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera;
			if (cineCamera.GetAttachParentActor() != null)
			{
				cineCamera.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
			}
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
			if (this.RecoverRotation != null)
			{
				CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(this.RecoverRotation.Value);
				this.RecoverRotation = null;
			}
			this.LinkExplosionEnd();
		}

		// Token: 0x0603BAF0 RID: 244464 RVA: 0x00E3F562 File Offset: 0x00E3D762
		public void LinkExplosionStart()
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("BattleLinkController.LinkExplosionStart");
			this.IsInLinkExplosion = true;
			this.VisibleId = new int?(BattleUiControl.Instance.SetBattleViewInvisible());
			GameModeController.Instance.SetTimeDilation(0f, ETimeDilationType.Default);
		}

		// Token: 0x0603BAF1 RID: 244465 RVA: 0x00E3F5A0 File Offset: 0x00E3D7A0
		public void LinkExplosionEnd()
		{
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("BattleLinkController.LinkExplosionStart");
			this.IsInLinkExplosion = false;
			if (this.VisibleId != null)
			{
				BattleUiControl.Instance.SetBattleViewVisible(this.VisibleId.Value);
			}
			this.VisibleId = null;
			GameModeController.Instance.SetTimeDilation(1f, ETimeDilationType.Default);
			BattleLinkModel.Instance.ResetLinkSkillStatus();
			if (this.MessageId != null)
			{
				long value = this.MessageId.Value;
				WorldEntity entity = SceneTeamModel.Instance.GetCurrentEntity.Entity;
				CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
				IReadOnlyList<long> readOnlyList = null;
				IReadOnlyList<long> readOnlyList2 = null;
				if (BattleLinkModel.Instance.CheckInDreamLink())
				{
					readOnlyList = ConfigCommonParamById.GetLong54ArrayConfig("LinkBrustBuffs");
					readOnlyList2 = ConfigCommonParamById.GetLong54ArrayConfig("LinkBrustBullets");
				}
				else
				{
					LinkData? linkConfig = BattleLinkModel.Instance.GetLinkConfig();
					if (linkConfig != null)
					{
						LinkData valueOrDefault = linkConfig.GetValueOrDefault();
						readOnlyList = valueOrDefault.BuffIdsInBrust();
						readOnlyList2 = valueOrDefault.BulletIdsInBrust();
					}
				}
				if (readOnlyList != null)
				{
					foreach (long num in readOnlyList)
					{
						component.AddBuff(num, new AddBuffParam
						{
							InstigatorId = component.CreatureDataId,
							Reason = "Link爆发结束增加buff",
							PreMessageId = new long?(value)
						});
						if (this.CurrentLinkBurstBuffs == null)
						{
							this.CurrentLinkBurstBuffs = new List<long>();
						}
						this.CurrentLinkBurstBuffs.Add(num);
					}
				}
				if (readOnlyList2 != null)
				{
					foreach (long num2 in readOnlyList2)
					{
						BulletController.Instance.CreateBulletCustomTarget(entity, num2.ToString(), null, new BulletController.BulletCreateParams(), new long?(value), global::EBulletCreateSource.Others);
					}
				}
			}
		}

		// Token: 0x0603BAF2 RID: 244466 RVA: 0x00E3F788 File Offset: 0x00E3D988
		private void ClearLinkBurstBuffs()
		{
			if (this.CurrentLinkBurstBuffs == null || this.CurrentLinkBurstBuffs.Count == 0)
			{
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			CharacterBuffComponent characterBuffComponent = (worldEntity != null) ? worldEntity.GetComponent<CharacterBuffComponent>() : null;
			if (characterBuffComponent != null)
			{
				foreach (long buffId in this.CurrentLinkBurstBuffs)
				{
					characterBuffComponent.RemoveBuff(buffId, -1, "离开Link爆发状态移除buff", null, null, null);
				}
			}
			this.CurrentLinkBurstBuffs.Clear();
		}

		// Token: 0x0603BAF3 RID: 244467 RVA: 0x00E3F844 File Offset: 0x00E3DA44
		public void SetPlayerUltraSkillEnable(bool enable)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			BaseTagComponent baseTagComponent;
			if (baseCharacter == null)
			{
				baseTagComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				baseTagComponent = ((characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 == null)
			{
				return;
			}
			if (enable)
			{
				baseTagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止大招"]));
				return;
			}
			baseTagComponent2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止大招"]));
		}

		// Token: 0x0603BAF4 RID: 244468 RVA: 0x00E3F8B1 File Offset: 0x00E3DAB1
		public void ShowLinkButton(bool isShow, bool isGm = false)
		{
			BattleView battleView = UiManager.Instance.GetViewByName(EUiViewName.BattleView) as BattleView;
			if (battleView != null)
			{
				battleView.ShowLinkButton(isShow);
			}
			if (isGm)
			{
				BattleLinkModel.Instance.SetNewLinkGmTest(isShow);
				this.UnbindEvents();
				this.BindEvents();
			}
		}

		// Token: 0x0603BAF5 RID: 244469 RVA: 0x00E3F8F0 File Offset: 0x00E3DAF0
		public void RefreshAliveRoleIdList()
		{
			List<int> list = SceneTeamModel.Instance.GetTeamRoleConfigIdList(false, true);
			List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
			List<int> deadRoleIdList = new List<int>();
			foreach (SceneTeamItem sceneTeamItem in teamItems)
			{
				int baseRoleId = RoleConfig.Instance.GetBaseRoleId(sceneTeamItem.GetConfigId);
				if (baseRoleId != 0 && sceneTeamItem.IsDead())
				{
					deadRoleIdList.Add(baseRoleId);
				}
			}
			list = (from roleId in list
			where !deadRoleIdList.Contains(roleId)
			select roleId).ToList<int>();
			BattleLinkModel.Instance.SetRoleIdList(list);
			BattleLinkModel.Instance.ResetMainBp();
		}

		// Token: 0x0603BAF6 RID: 244470 RVA: 0x00E3F9B8 File Offset: 0x00E3DBB8
		public bool GetIsInLinkExplosion()
		{
			return this.IsInLinkExplosion;
		}

		// Token: 0x0603BAF7 RID: 244471 RVA: 0x00E3F9C0 File Offset: 0x00E3DBC0
		public void SetMessageId(long? msgId)
		{
			this.MessageId = msgId;
		}

		// Token: 0x0603BAF8 RID: 244472 RVA: 0x00E3F9C9 File Offset: 0x00E3DBC9
		public long? GetMessageId()
		{
			return this.MessageId;
		}

		// Token: 0x0603BAF9 RID: 244473 RVA: 0x00E3F9D4 File Offset: 0x00E3DBD4
		private static void HandleLinkingStateNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			LinkingStateNotify notify = (LinkingStateNotify)msg;
			BattleLinkModel.Instance.HandleLinkingStateNotify(notify);
		}

		// Token: 0x0603BAFA RID: 244474 RVA: 0x00E3F9F4 File Offset: 0x00E3DBF4
		private static void HandleLinkExitNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			LinkExitNotify notify = (LinkExitNotify)msg;
			BattleLinkModel.Instance.HandleLinkExitNotify(notify);
			BattleLinkController.Instance.OnExitLinkBurst();
		}

		// Token: 0x0603BAFB RID: 244475 RVA: 0x00E3FA20 File Offset: 0x00E3DC20
		[CombatListen(ENotifyMessageId.NewLinkNotify, false, false)]
		public static void OnNewLinkStateNotify(Entity entity, [Nullable(1)] NewLinkNotify notify, CombatCommon combatCommon = null)
		{
			long value = (combatCommon != null) ? combatCommon.MessageId : 0L;
			if (entity == null || !entity.Valid)
			{
				return;
			}
			BattleLinkController.Instance.SetMessageId(new long?(value));
			BattleLinkModel.Instance.HandleNewLinkStateNotify(notify, combatCommon);
			EventSystem.Instance.Emit<ENewLinkStatus>(EEventName.OnNewLinkStatusChanged, (ENewLinkStatus)notify.Current);
			if (notify.Current == ENewLinkStage.Burst)
			{
				EventSystem.Instance.Emit<ELinkStatus>(EEventName.OnBattleLinkStatusChanged, ELinkStatus.Explosion);
				return;
			}
			EventSystem.Instance.Emit<ELinkStatus>(EEventName.OnBattleLinkStatusChanged, ELinkStatus.None);
		}

		// Token: 0x0603BAFC RID: 244476 RVA: 0x00E3FAAB File Offset: 0x00E3DCAB
		public void OnExitLinkBurst()
		{
			AudioSystem.Instance.SetState("game_rogue_link_state", "not_in_link", true);
			this.ClearLinkBurstBuffs();
		}

		// Token: 0x0603BAFD RID: 244477 RVA: 0x00E3FAC8 File Offset: 0x00E3DCC8
		public void RequestNewLinkBurst()
		{
			if (this.MessageId == null)
			{
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			if (worldEntity == null)
			{
				return;
			}
			long value = this.MessageId.Value;
			CombatNet.Instance.Send(EPushMessageId.NewLinkBurstPush, worldEntity, NewLinkBurstPush.Create(), new long?(value), null, null);
			if (this.RoleIdQueue != null)
			{
				BattleLinkModel.Instance.SetRoleIdList(this.RoleIdQueue);
				BattleLinkModel.Instance.ResetMainBp();
			}
			else
			{
				this.RefreshAliveRoleIdList();
			}
			this.TryPlaySplitScreen();
		}

		// Token: 0x0603BAFE RID: 244478 RVA: 0x00E3FB68 File Offset: 0x00E3DD68
		public UniTask NewLinkBurstTest()
		{
			BattleLinkController.<NewLinkBurstTest>d__57 <NewLinkBurstTest>d__;
			<NewLinkBurstTest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewLinkBurstTest>d__.<>4__this = this;
			<NewLinkBurstTest>d__.<>1__state = -1;
			<NewLinkBurstTest>d__.<>t__builder.Start<BattleLinkController.<NewLinkBurstTest>d__57>(ref <NewLinkBurstTest>d__);
			return <NewLinkBurstTest>d__.<>t__builder.Task;
		}

		// Token: 0x0603BAFF RID: 244479 RVA: 0x00E3FBAC File Offset: 0x00E3DDAC
		[NullableContext(0)]
		public UniTask<bool> PreloadRes(int id)
		{
			BattleLinkController.<PreloadRes>d__58 <PreloadRes>d__;
			<PreloadRes>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PreloadRes>d__.id = id;
			<PreloadRes>d__.<>1__state = -1;
			<PreloadRes>d__.<>t__builder.Start<BattleLinkController.<PreloadRes>d__58>(ref <PreloadRes>d__);
			return <PreloadRes>d__.<>t__builder.Task;
		}

		// Token: 0x17008DB7 RID: 36279
		// (get) Token: 0x0603BB00 RID: 244480 RVA: 0x00E3FBEF File Offset: 0x00E3DDEF
		[Nullable(1)]
		public static BattleLinkController Instance
		{
			[NullableContext(1)]
			get
			{
				return BattleLinkController._Instance;
			}
		}

		// Token: 0x0603BB01 RID: 244481 RVA: 0x00E3FBF6 File Offset: 0x00E3DDF6
		[NullableContext(1)]
		public static BattleLinkController GetOrCreateInstance()
		{
			if (BattleLinkController._Instance == null)
			{
				BattleLinkController.CreateInstance();
			}
			return BattleLinkController._Instance;
		}

		// Token: 0x0603BB02 RID: 244482 RVA: 0x00E3FC0A File Offset: 0x00E3DE0A
		public static bool CreateInstance()
		{
			if (BattleLinkController._Instance != null)
			{
				return true;
			}
			BattleLinkController._Instance = new BattleLinkController();
			return true;
		}

		// Token: 0x0603BB03 RID: 244483 RVA: 0x00E3FC20 File Offset: 0x00E3DE20
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BB04 RID: 244484 RVA: 0x00E3FC22 File Offset: 0x00E3DE22
		public static void ResetStaticDefaultValue()
		{
			BattleLinkController._Instance = null;
		}

		// Token: 0x0603BB05 RID: 244485 RVA: 0x00E3FC2A File Offset: 0x00E3DE2A
		static BattleLinkController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleLinkController.CreateStaticDefaultValue), new Action(BattleLinkController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F110 RID: 127248
		[StaticVariableRuleIgnore]
		private static readonly FName SeqCameraTag = new FName("SequenceCamera");

		// Token: 0x0401F111 RID: 127249
		[StaticVariableRuleIgnore]
		private static readonly FName CharacterTag = new FName("Character");

		// Token: 0x0401F112 RID: 127250
		private bool HasBindEvents;

		// Token: 0x0401F113 RID: 127251
		private int? VisibleId;

		// Token: 0x0401F114 RID: 127252
		private long? MessageId;

		// Token: 0x0401F115 RID: 127253
		private bool IsPlayingSplitScreen;

		// Token: 0x0401F116 RID: 127254
		private int ScreenEffectCueHandle;

		// Token: 0x0401F117 RID: 127255
		private ALevelSequenceActor LevelSeqActor;

		// Token: 0x0401F118 RID: 127256
		[Nullable(1)]
		private readonly TArray<AActor> BindingActors = new TArray<AActor>();

		// Token: 0x0401F119 RID: 127257
		private FRotator? RecoverRotation;

		// Token: 0x0401F11A RID: 127258
		private TimerHandle Timer;

		// Token: 0x0401F11B RID: 127259
		[Nullable(1)]
		private readonly Dictionary<int, EntityHandle> EntityCache = new Dictionary<int, EntityHandle>();

		// Token: 0x0401F11C RID: 127260
		private bool NeedEntityCache = true;

		// Token: 0x0401F11D RID: 127261
		private bool IsInLinkExplosion;

		// Token: 0x0401F11E RID: 127262
		[Nullable(1)]
		private readonly List<int> TeamEntityIdList = new List<int>();

		// Token: 0x0401F11F RID: 127263
		private List<long> CurrentLinkBurstBuffs;

		// Token: 0x0401F120 RID: 127264
		private WorldEntity AbilityEventEntity;

		// Token: 0x0401F121 RID: 127265
		private Dictionary<long, int> LinkBuffRoleIdMap;

		// Token: 0x0401F122 RID: 127266
		private List<int> RoleIdQueue;

		// Token: 0x0401F123 RID: 127267
		private bool IsLinkTesting;

		// Token: 0x0401F124 RID: 127268
		private static BattleLinkController _Instance;

		// Token: 0x0200BE44 RID: 48708
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403960D RID: 235021
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__HandleLinkingStateNotify;

			// Token: 0x0403960E RID: 235022
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <1>__HandleLinkExitNotify;
		}
	}
}
