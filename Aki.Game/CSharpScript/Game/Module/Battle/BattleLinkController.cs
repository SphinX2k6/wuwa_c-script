using System;
using System.Collections.Generic;
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
	// Token: 0x02004C26 RID: 19494
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class BattleLinkController : ControllerBase
	{
		// Token: 0x06030A24 RID: 199204 RVA: 0x00D8EA40 File Offset: 0x00D8CC40
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

		// Token: 0x06030A25 RID: 199205 RVA: 0x00D8EAA4 File Offset: 0x00D8CCA4
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.LinkingStateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.LinkExitNotify);
			this.UnbindEvents();
			return true;
		}

		// Token: 0x06030A26 RID: 199206 RVA: 0x00D8EAD0 File Offset: 0x00D8CCD0
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

		// Token: 0x06030A27 RID: 199207 RVA: 0x00D8EB70 File Offset: 0x00D8CD70
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

		// Token: 0x06030A28 RID: 199208 RVA: 0x00D8EC90 File Offset: 0x00D8CE90
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

		// Token: 0x06030A29 RID: 199209 RVA: 0x00D8EE0C File Offset: 0x00D8D00C
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

		// Token: 0x06030A2A RID: 199210 RVA: 0x00D8EF94 File Offset: 0x00D8D194
		private void InitSequenceActor()
		{
			if (this.LevelSeqActor == null)
			{
				this.LevelSeqActor = (ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, false) as ALevelSequenceActor);
			}
		}

		// Token: 0x06030A2B RID: 199211 RVA: 0x00D8EFC4 File Offset: 0x00D8D1C4
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

		// Token: 0x06030A2C RID: 199212 RVA: 0x00D8F060 File Offset: 0x00D8D260
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

		// Token: 0x06030A2D RID: 199213 RVA: 0x00D8F164 File Offset: 0x00D8D364
		private void OnCharDead(int entityId)
		{
			this.OnCharDeadOrAliveChanged(entityId, true);
		}

		// Token: 0x06030A2E RID: 199214 RVA: 0x00D8F16E File Offset: 0x00D8D36E
		[NullableContext(1)]
		private void OnCharRevive(Entity entity)
		{
			this.OnCharDeadOrAliveChanged(entity.Id, false);
		}

		// Token: 0x06030A2F RID: 199215 RVA: 0x00D8F17D File Offset: 0x00D8D37D
		private void OnCharDeadOrAliveChanged(int entityId, bool isDead)
		{
			if (!this.TeamEntityIdList.Contains(entityId))
			{
				return;
			}
			EventSystem.Instance.Emit<ENewLinkStatus>(EEventName.OnNewLinkStatusChanged, BattleLinkModel.Instance.GetNewLinkStatus());
		}

		// Token: 0x06030A30 RID: 199216 RVA: 0x00D8F1A8 File Offset: 0x00D8D3A8
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

		// Token: 0x06030A31 RID: 199217 RVA: 0x00D8F2AC File Offset: 0x00D8D4AC
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

		// Token: 0x06030A32 RID: 199218 RVA: 0x00D8F390 File Offset: 0x00D8D590
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

		// Token: 0x06030A33 RID: 199219 RVA: 0x00D8F420 File Offset: 0x00D8D620
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

		// Token: 0x06030A34 RID: 199220 RVA: 0x00D8F480 File Offset: 0x00D8D680
		public void StopLink()
		{
			EventSystem.Instance.Emit(EEventName.OnBattleLinkStop);
		}

		// Token: 0x06030A35 RID: 199221 RVA: 0x00D8F492 File Offset: 0x00D8D692
		public void StartLinkExplosion()
		{
			this.StopLink();
			this.TryPlaySplitScreen();
		}

		// Token: 0x06030A36 RID: 199222 RVA: 0x00D8F4A0 File Offset: 0x00D8D6A0
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

		// Token: 0x06030A37 RID: 199223 RVA: 0x00D8F528 File Offset: 0x00D8D728
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

		// Token: 0x06030A38 RID: 199224 RVA: 0x00D8F5A4 File Offset: 0x00D8D7A4
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

		// Token: 0x06030A39 RID: 199225 RVA: 0x00D8F5DC File Offset: 0x00D8D7DC
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

		// Token: 0x06030A3A RID: 199226 RVA: 0x00D8F7EC File Offset: 0x00D8D9EC
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

		// Token: 0x06030A3B RID: 199227 RVA: 0x00D8F8E6 File Offset: 0x00D8DAE6
		public void LinkExplosionStart()
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("BattleLinkController.LinkExplosionStart");
			this.IsInLinkExplosion = true;
			this.VisibleId = new int?(BattleUiControl.Instance.SetBattleViewInvisible());
			GameModeController.Instance.SetTimeDilation(0f, ETimeDilationType.Default);
		}

		// Token: 0x06030A3C RID: 199228 RVA: 0x00D8F924 File Offset: 0x00D8DB24
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

		// Token: 0x06030A3D RID: 199229 RVA: 0x00D8FB0C File Offset: 0x00D8DD0C
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

		// Token: 0x06030A3E RID: 199230 RVA: 0x00D8FBC8 File Offset: 0x00D8DDC8
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

		// Token: 0x06030A3F RID: 199231 RVA: 0x00D8FC35 File Offset: 0x00D8DE35
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

		// Token: 0x06030A40 RID: 199232 RVA: 0x00D8FC74 File Offset: 0x00D8DE74
		public void RefreshAliveRoleIdList()
		{
			List<int> list = SceneTeamModel.Instance.GetTeamRoleConfigIdList(false, true);
			List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
			List<int> list2 = new List<int>();
			foreach (SceneTeamItem sceneTeamItem in teamItems)
			{
				int baseRoleId = RoleConfig.Instance.GetBaseRoleId(sceneTeamItem.GetConfigId);
				if (baseRoleId != 0 && sceneTeamItem.IsDead())
				{
					list2.Add(baseRoleId);
				}
			}
			List<int> list3 = new List<int>();
			foreach (int item in list)
			{
				if (!list2.Contains(item))
				{
					list3.Add(item);
				}
			}
			list = list3;
			BattleLinkModel.Instance.SetRoleIdList(list);
			BattleLinkModel.Instance.ResetMainBp();
		}

		// Token: 0x06030A41 RID: 199233 RVA: 0x00D8FD68 File Offset: 0x00D8DF68
		public bool GetIsInLinkExplosion()
		{
			return this.IsInLinkExplosion;
		}

		// Token: 0x06030A42 RID: 199234 RVA: 0x00D8FD70 File Offset: 0x00D8DF70
		public void SetMessageId(long? msgId)
		{
			this.MessageId = msgId;
		}

		// Token: 0x06030A43 RID: 199235 RVA: 0x00D8FD79 File Offset: 0x00D8DF79
		public long? GetMessageId()
		{
			return this.MessageId;
		}

		// Token: 0x06030A44 RID: 199236 RVA: 0x00D8FD84 File Offset: 0x00D8DF84
		private static void HandleLinkingStateNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			LinkingStateNotify notify = (LinkingStateNotify)msg;
			BattleLinkModel.Instance.HandleLinkingStateNotify(notify);
		}

		// Token: 0x06030A45 RID: 199237 RVA: 0x00D8FDA4 File Offset: 0x00D8DFA4
		private static void HandleLinkExitNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			LinkExitNotify notify = (LinkExitNotify)msg;
			BattleLinkModel.Instance.HandleLinkExitNotify(notify);
			BattleLinkController.Instance.OnExitLinkBurst();
		}

		// Token: 0x06030A46 RID: 199238 RVA: 0x00D8FDD0 File Offset: 0x00D8DFD0
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

		// Token: 0x06030A47 RID: 199239 RVA: 0x00D8FE5B File Offset: 0x00D8E05B
		public void OnExitLinkBurst()
		{
			AudioSystem.Instance.SetState("game_rogue_link_state", "not_in_link", true);
			this.ClearLinkBurstBuffs();
		}

		// Token: 0x06030A48 RID: 199240 RVA: 0x00D8FE78 File Offset: 0x00D8E078
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

		// Token: 0x06030A49 RID: 199241 RVA: 0x00D8FF18 File Offset: 0x00D8E118
		public UniTask NewLinkBurstTest()
		{
			BattleLinkController.<NewLinkBurstTest>d__57 <NewLinkBurstTest>d__;
			<NewLinkBurstTest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewLinkBurstTest>d__.<>4__this = this;
			<NewLinkBurstTest>d__.<>1__state = -1;
			<NewLinkBurstTest>d__.<>t__builder.Start<BattleLinkController.<NewLinkBurstTest>d__57>(ref <NewLinkBurstTest>d__);
			return <NewLinkBurstTest>d__.<>t__builder.Task;
		}

		// Token: 0x06030A4A RID: 199242 RVA: 0x00D8FF5C File Offset: 0x00D8E15C
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

		// Token: 0x17006189 RID: 24969
		// (get) Token: 0x06030A4B RID: 199243 RVA: 0x00D8FF9F File Offset: 0x00D8E19F
		[Nullable(1)]
		public static BattleLinkController Instance
		{
			[NullableContext(1)]
			get
			{
				return BattleLinkController._Instance;
			}
		}

		// Token: 0x06030A4C RID: 199244 RVA: 0x00D8FFA6 File Offset: 0x00D8E1A6
		[NullableContext(1)]
		public static BattleLinkController GetOrCreateInstance()
		{
			if (BattleLinkController._Instance == null)
			{
				BattleLinkController.CreateInstance();
			}
			return BattleLinkController._Instance;
		}

		// Token: 0x06030A4D RID: 199245 RVA: 0x00D8FFBA File Offset: 0x00D8E1BA
		public static bool CreateInstance()
		{
			if (BattleLinkController._Instance != null)
			{
				return true;
			}
			BattleLinkController._Instance = new BattleLinkController();
			return true;
		}

		// Token: 0x06030A4E RID: 199246 RVA: 0x00D8FFD0 File Offset: 0x00D8E1D0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030A4F RID: 199247 RVA: 0x00D8FFD2 File Offset: 0x00D8E1D2
		public static void ResetStaticDefaultValue()
		{
			BattleLinkController._Instance = null;
		}

		// Token: 0x06030A50 RID: 199248 RVA: 0x00D8FFDA File Offset: 0x00D8E1DA
		static BattleLinkController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleLinkController.CreateStaticDefaultValue), new Action(BattleLinkController.ResetStaticDefaultValue));
		}

		// Token: 0x04019BC1 RID: 105409
		[StaticVariableRuleIgnore]
		private static readonly FName SeqCameraTag = new FName("SequenceCamera");

		// Token: 0x04019BC2 RID: 105410
		[StaticVariableRuleIgnore]
		private static readonly FName CharacterTag = new FName("Character");

		// Token: 0x04019BC3 RID: 105411
		private bool HasBindEvents;

		// Token: 0x04019BC4 RID: 105412
		private int? VisibleId;

		// Token: 0x04019BC5 RID: 105413
		private long? MessageId;

		// Token: 0x04019BC6 RID: 105414
		private bool IsPlayingSplitScreen;

		// Token: 0x04019BC7 RID: 105415
		private int ScreenEffectCueHandle;

		// Token: 0x04019BC8 RID: 105416
		private ALevelSequenceActor LevelSeqActor;

		// Token: 0x04019BC9 RID: 105417
		[Nullable(1)]
		private readonly TArray<AActor> BindingActors = new TArray<AActor>();

		// Token: 0x04019BCA RID: 105418
		private FRotator? RecoverRotation;

		// Token: 0x04019BCB RID: 105419
		private TimerHandle Timer;

		// Token: 0x04019BCC RID: 105420
		[Nullable(1)]
		private readonly Dictionary<int, EntityHandle> EntityCache = new Dictionary<int, EntityHandle>();

		// Token: 0x04019BCD RID: 105421
		private bool NeedEntityCache = true;

		// Token: 0x04019BCE RID: 105422
		private bool IsInLinkExplosion;

		// Token: 0x04019BCF RID: 105423
		[Nullable(1)]
		private readonly List<int> TeamEntityIdList = new List<int>();

		// Token: 0x04019BD0 RID: 105424
		private List<long> CurrentLinkBurstBuffs;

		// Token: 0x04019BD1 RID: 105425
		private WorldEntity AbilityEventEntity;

		// Token: 0x04019BD2 RID: 105426
		private Dictionary<long, int> LinkBuffRoleIdMap;

		// Token: 0x04019BD3 RID: 105427
		private List<int> RoleIdQueue;

		// Token: 0x04019BD4 RID: 105428
		private bool IsLinkTesting;

		// Token: 0x04019BD5 RID: 105429
		private static BattleLinkController _Instance;

		// Token: 0x0200A84C RID: 43084
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04033FD0 RID: 212944
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__HandleLinkingStateNotify;

			// Token: 0x04033FD1 RID: 212945
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
