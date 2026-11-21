using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x0200350E RID: 13582
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneInteractionManager : IStaticVariableResetter
	{
		// Token: 0x06022918 RID: 141592 RVA: 0x009D4BBE File Offset: 0x009D2DBE
		static SceneInteractionManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneInteractionManager.CreateStaticDefaultValue), new Action(SceneInteractionManager.ResetStaticDefaultValue));
		}

		// Token: 0x06022919 RID: 141593 RVA: 0x009D4BDD File Offset: 0x009D2DDD
		public static SceneInteractionManager Get()
		{
			return SceneInteractionManager.Instanced;
		}

		// Token: 0x0602291A RID: 141594 RVA: 0x009D4BE4 File Offset: 0x009D2DE4
		public static void Initialize()
		{
			if (SceneInteractionManager.Instanced == null)
			{
				SceneInteractionManager.Instanced = new SceneInteractionManager();
				SceneInteractionManager.Instanced.Init();
			}
		}

		// Token: 0x0602291B RID: 141595 RVA: 0x009D4C04 File Offset: 0x009D2E04
		public static void StaticTick(float delta)
		{
			float deltaSeconds = delta / 1000f;
			if (SceneInteractionManager.Instanced != null)
			{
				SceneInteractionManager.Instanced.Tick(deltaSeconds);
			}
		}

		// Token: 0x0602291C RID: 141596 RVA: 0x009D4C2C File Offset: 0x009D2E2C
		protected void Init()
		{
			this.IsOnMobile = (UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldFeatureLevel(GlobalData.World) == KuroFeatureLevel.ES3_1);
			this.UniqueLevelInstanceId = 1;
			this.AllSceneInteractionInfos = new Dictionary<int, SceneInteractionLevel>();
			this.TempCacheIds.Clear();
			this.ActorMap = new Dictionary<AActor, int>();
			this.TempVector = Vector.Create();
			this.WaterObjects = new List<SceneObjectWaterEffect>();
			this.AirWallObjects = new List<SceneObjectAirWallEffect>();
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
			this.LoadAssets();
		}

		// Token: 0x0602291D RID: 141597 RVA: 0x009D4CD4 File Offset: 0x009D2ED4
		private void UpdateInteractionConfigs()
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(false))
			{
				EntityHandle entityHandle = sceneTeamItem.EntityHandle;
				object obj;
				if (entityHandle == null)
				{
					obj = null;
				}
				else
				{
					WorldEntity entity = entityHandle.Entity;
					if (entity == null)
					{
						obj = null;
					}
					else
					{
						CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
						obj = ((component != null) ? component.Owner : null);
					}
				}
				TsBaseCharacter tsBaseCharacter = obj as TsBaseCharacter;
				if (tsBaseCharacter != null)
				{
					if (sceneTeamItem.IsControl())
					{
						CharRenderingComponent charRenderingComponent = tsBaseCharacter.CharRenderingComponent;
						if (charRenderingComponent != null)
						{
							charRenderingComponent.AddInteraction(this.MainPlayerConfig, sceneTeamItem.IsMyRole() ? 1f : 2f);
						}
					}
					else
					{
						CharRenderingComponent charRenderingComponent2 = tsBaseCharacter.CharRenderingComponent;
						if (charRenderingComponent2 != null)
						{
							charRenderingComponent2.RemoveInteraction();
						}
					}
				}
			}
		}

		// Token: 0x0602291E RID: 141598 RVA: 0x009D4DA4 File Offset: 0x009D2FA4
		private void OnUpdateSceneTeam()
		{
			this.OnChangeRole(null, null);
		}

		// Token: 0x0602291F RID: 141599 RVA: 0x009D4DB0 File Offset: 0x009D2FB0
		private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			if (this.TickProcessId != 0)
			{
				return;
			}
			if (this.TimerHandle != null)
			{
				this.TimerHandle.Remove();
				this.TimerHandle = null;
			}
			this.TickProcessId = TickProcessSystem.Instance.RegisterOnceTickProcess(ETickingGroup.TG_PostUpdateWork, true, new Action<float>(this.TickProcessUpdateInteraction));
		}

		// Token: 0x06022920 RID: 141600 RVA: 0x009D4DFF File Offset: 0x009D2FFF
		private void TickProcessUpdateInteraction(float delta)
		{
			this.TickProcessId = 0;
			this.TimerHandle = TimerSystem.Instance.Next(delegate(float _)
			{
				this.TimerHandle = null;
				this.UpdateInteractionConfigs();
			}, null, null);
		}

		// Token: 0x06022921 RID: 141601 RVA: 0x009D4E26 File Offset: 0x009D3026
		protected void LoadAssets()
		{
			ResourceSystem.Instance.LoadAsync<PDA_InteractionPlayerConfig_C>("/Game/Aki/Render/Data/Interaction/DA_InteractionMainPlayerConfig.DA_InteractionMainPlayerConfig", delegate([Nullable(2)] PDA_InteractionPlayerConfig_C result, string _)
			{
				this.MainPlayerConfig = result;
				this.OnChangeRole(null, null);
			}, 100, "js_undefined");
		}

		// Token: 0x06022922 RID: 141602 RVA: 0x009D4E4C File Offset: 0x009D304C
		[NullableContext(2)]
		public int CreateSceneInteractionLevel([Nullable(1)] string inLevelName, EKuroSceneInteractionState? initState, FVectorDouble location, FRotator rotation, Action onLevelStreamingCompleteCallback, bool afterLoadVisible = true, bool isInitShow = false, int pbDataId = 0, int entityId = 0, Action onLevelStreamingLoadedCompleteCallback = null)
		{
			UWorld world = GlobalData.World;
			if (world == null)
			{
				Log.Instance.Error(ELogModule.RenderScene, ELogAuthor.HCS, "错误，获取不到World", default(ReadOnlySpan<ValueTuple<string, object>>));
				return -1;
			}
			string text = inLevelName;
			if (inLevelName.Contains("."))
			{
				text = inLevelName.Split(".", StringSplitOptions.None)[0];
			}
			int uniqueLevelInstanceId = this.UniqueLevelInstanceId;
			bool flag = false;
			string optionalLevelNameOverride = "KuroSceneInteraction_" + uniqueLevelInstanceId.ToString();
			ULevelStreamingDynamic ulevelStreamingDynamic = ULevelStreamingDynamic.LoadLevelInstance(world, text, location, rotation, ref flag, optionalLevelNameOverride, default(TSubclassOf<ULevelStreamingDynamic>));
			if (flag && ulevelStreamingDynamic != null)
			{
				SceneInteractionLevel sceneInteractionLevel = new SceneInteractionLevel();
				sceneInteractionLevel.Init(ulevelStreamingDynamic, text, location, rotation, uniqueLevelInstanceId, initState, onLevelStreamingCompleteCallback, afterLoadVisible, isInitShow, pbDataId, entityId, onLevelStreamingLoadedCompleteCallback);
				this.UniqueLevelInstanceId++;
				this.AllSceneInteractionInfos[uniqueLevelInstanceId] = sceneInteractionLevel;
				return uniqueLevelInstanceId;
			}
			return -1;
		}

		// Token: 0x06022923 RID: 141603 RVA: 0x009D4F24 File Offset: 0x009D3124
		public void SetLevelStreamingPriority(int handleId, int priority)
		{
			SceneInteractionLevel sceneInteractionLevel;
			if (this.AllSceneInteractionInfos != null && this.AllSceneInteractionInfos.TryGetValue(handleId, out sceneInteractionLevel))
			{
				sceneInteractionLevel.SetStreamingPriority(priority);
			}
		}

		// Token: 0x06022924 RID: 141604 RVA: 0x009D4F50 File Offset: 0x009D3150
		public bool DestroySceneInteraction(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel == null)
			{
				return false;
			}
			sceneInteractionLevel.Destroy();
			this.AllSceneInteractionInfos.Remove(handleId);
			IReadOnlyDictionary<string, AActor> allActor = sceneInteractionLevel.GetAllActor();
			if (allActor == null)
			{
				return true;
			}
			foreach (KeyValuePair<string, AActor> keyValuePair in allActor)
			{
				AActor value = keyValuePair.Value;
				if (value != null)
				{
					this.ActorMap.Remove(value);
				}
			}
			return true;
		}

		// Token: 0x06022925 RID: 141605 RVA: 0x009D4FF0 File Offset: 0x009D31F0
		public bool SwitchSceneInteractionToState(int handleId, EKuroSceneInteractionState targetState, bool needTransition, bool force, bool jumpToEnd = false)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			return sceneInteractionLevel != null && sceneInteractionLevel.SwitchToState(targetState, needTransition, force, jumpToEnd);
		}

		// Token: 0x06022926 RID: 141606 RVA: 0x009D502C File Offset: 0x009D322C
		public EKuroSceneInteractionState GetSceneInteractionCurrentState(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetCurrentState();
			}
			return EKuroSceneInteractionState.Error;
		}

		// Token: 0x06022927 RID: 141607 RVA: 0x009D5064 File Offset: 0x009D3264
		public void PlaySceneInteractionEffect(int handleId, ESceneInteractionEffect effectKey)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PlaySceneEffect(effectKey);
			}
		}

		// Token: 0x06022928 RID: 141608 RVA: 0x009D509C File Offset: 0x009D329C
		public void EndSceneInteractionEffect(int handleId, ESceneInteractionEffect effectKey)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.EndSceneEffect(effectKey);
			}
		}

		// Token: 0x06022929 RID: 141609 RVA: 0x009D50D4 File Offset: 0x009D32D4
		public void PlaySceneInteractionEndEffect(int handleId, ESceneInteractionEffect effectKey)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PlaySceneEndEffect(effectKey);
			}
		}

		// Token: 0x0602292A RID: 141610 RVA: 0x009D510C File Offset: 0x009D330C
		public void ChangeSceneInteractionPlayDirection(int handleId, bool bPlayBack)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.ChangePlayDirection(bPlayBack);
			}
		}

		// Token: 0x0602292B RID: 141611 RVA: 0x009D5144 File Offset: 0x009D3344
		public bool IsSceneInteractionStreamingComplete(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			return sceneInteractionLevel != null && sceneInteractionLevel.IsStreamingComplete();
		}

		// Token: 0x0602292C RID: 141612 RVA: 0x009D517C File Offset: 0x009D337C
		public void ToggleSceneInteractionVisible(int handleId, bool visible, bool needHidden = false, [Nullable(2)] Action onLevelStreamingShowOrHideCallback = null, string reason = "")
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.ToggleLevelVisible(visible, needHidden, onLevelStreamingShowOrHideCallback, reason);
			}
		}

		// Token: 0x0602292D RID: 141613 RVA: 0x009D51B8 File Offset: 0x009D33B8
		[NullableContext(2)]
		public string GetSceneInteractionLevelName(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.LevelName;
			}
			return null;
		}

		// Token: 0x0602292E RID: 141614 RVA: 0x009D51F0 File Offset: 0x009D33F0
		[NullableContext(2)]
		public AActor GetSceneInteractionMainActor(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.MainActor;
			}
			return null;
		}

		// Token: 0x0602292F RID: 141615 RVA: 0x009D5228 File Offset: 0x009D3428
		[return: Nullable(2)]
		public AActor GetSceneInteractionActorByKey(int handleId, string key)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetActorByKey(key);
			}
			return null;
		}

		// Token: 0x06022930 RID: 141616 RVA: 0x009D5260 File Offset: 0x009D3460
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public IReadOnlyDictionary<string, AActor> GetSceneInteractionAllKeyRefActors(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetAllActor();
			}
			return null;
		}

		// Token: 0x06022931 RID: 141617 RVA: 0x009D5298 File Offset: 0x009D3498
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public TArray<AActor> GetRefSceneInteractionActorsByTag(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetRefActorsByTag(tag);
			}
			return null;
		}

		// Token: 0x06022932 RID: 141618 RVA: 0x009D52D0 File Offset: 0x009D34D0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public TArray<AActor> GetSceneInteractionAllActorsInLevel(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetAllActorsInLevel();
			}
			return null;
		}

		// Token: 0x06022933 RID: 141619 RVA: 0x009D5308 File Offset: 0x009D3508
		public FTransformDouble? GetActorOriginalRelTransform(int handleId, AActor actor)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetActorOriginalRelTransform(actor);
			}
			return null;
		}

		// Token: 0x06022934 RID: 141620 RVA: 0x009D5348 File Offset: 0x009D3548
		public void AttachToActor(int handleId, AActor parentActor)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.AttachToActor(parentActor);
			}
		}

		// Token: 0x06022935 RID: 141621 RVA: 0x009D5380 File Offset: 0x009D3580
		public void SetCollisionActorsOwner(int handleId, AActor owner)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.SetCollisionActorsOwner(owner);
			}
		}

		// Token: 0x06022936 RID: 141622 RVA: 0x009D53B8 File Offset: 0x009D35B8
		public void AttachChildActor(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel == null)
			{
				return;
			}
			IReadOnlyDictionary<string, AActor> allActor = sceneInteractionLevel.GetAllActor();
			if (allActor == null)
			{
				return;
			}
			foreach (KeyValuePair<string, AActor> keyValuePair in allActor)
			{
				AActor value = keyValuePair.Value;
				if (value != null)
				{
					this.ActorMap[value] = handleId;
				}
			}
		}

		// Token: 0x06022937 RID: 141623 RVA: 0x009D5444 File Offset: 0x009D3644
		public void EmitActor(AActor actor, string seqName, string eventName)
		{
			if (actor == null)
			{
				return;
			}
			int key = this.ActorMap.ContainsKey(actor) ? this.ActorMap[actor] : 0;
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(key) ? this.AllSceneInteractionInfos[key] : null;
			if (sceneInteractionLevel == null)
			{
				return;
			}
			AActor attachActor = sceneInteractionLevel.GetAttachActor();
			if (attachActor == null)
			{
				return;
			}
			EntityHandle entityByActor = ActorUtils.GetEntityByActor(attachActor, true);
			if (entityByActor == null)
			{
				return;
			}
			EventSystem.Instance.EmitWithTarget<string, string>(entityByActor, EEventName.SceneItemInteractionEvent, seqName, eventName);
		}

		// Token: 0x06022938 RID: 141624 RVA: 0x009D54C0 File Offset: 0x009D36C0
		[NullableContext(2)]
		public AActor GetMainCollisionActor(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetMainCollisionActor();
			}
			return null;
		}

		// Token: 0x06022939 RID: 141625 RVA: 0x009D54F8 File Offset: 0x009D36F8
		[NullableContext(2)]
		public ASkeletalMeshActor GetSceneInteractionSkeletalMeshActor(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetSkeletalMeshActor();
			}
			return null;
		}

		// Token: 0x0602293A RID: 141626 RVA: 0x009D5530 File Offset: 0x009D3730
		public FGameplayTag? GetPartCollisionActorTag(int handleId, AActor actor)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetPartCollisionActorTag(actor);
			}
			return null;
		}

		// Token: 0x0602293B RID: 141627 RVA: 0x009D5570 File Offset: 0x009D3770
		public int? GetPartCollisionActorsNum(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetPartCollisionActorsNum();
			}
			return null;
		}

		// Token: 0x0602293C RID: 141628 RVA: 0x009D55B0 File Offset: 0x009D37B0
		[NullableContext(2)]
		public AActor GetPartCollisionActor(int handleId, int index)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetPartCollisionActor(index);
			}
			return null;
		}

		// Token: 0x0602293D RID: 141629 RVA: 0x009D55E8 File Offset: 0x009D37E8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public TArray<AActor> GetInteractionEffectHookActors(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetInteractionEffectHookActors();
			}
			return null;
		}

		// Token: 0x0602293E RID: 141630 RVA: 0x009D5620 File Offset: 0x009D3820
		public float? GetActiveTagSequencePlaybackProgress(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetActiveTagSequencePlaybackProgress(tag);
			}
			return null;
		}

		// Token: 0x0602293F RID: 141631 RVA: 0x009D5660 File Offset: 0x009D3860
		public void SetActiveTagSequencePlaybackProgress(int handleId, FGameplayTag tag, float progress)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.SetActiveTagSequencePlaybackProgress(tag, progress);
			}
		}

		// Token: 0x06022940 RID: 141632 RVA: 0x009D5698 File Offset: 0x009D3898
		public double? GetActiveTagSequenceDurationTime(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetActiveTagSequenceDurationTime(tag);
			}
			return null;
		}

		// Token: 0x06022941 RID: 141633 RVA: 0x009D56D8 File Offset: 0x009D38D8
		public void SetActiveTagSequenceDurationTime(int handleId, FGameplayTag tag, float durationSecond)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.SetActiveTagSequenceDurationTime(tag, durationSecond);
			}
		}

		// Token: 0x06022942 RID: 141634 RVA: 0x009D5710 File Offset: 0x009D3910
		public void PauseActiveTagSequence(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PauseActiveTagSequence(tag);
			}
		}

		// Token: 0x06022943 RID: 141635 RVA: 0x009D5748 File Offset: 0x009D3948
		public void ResumeActiveTagSequence(int handleId, FGameplayTag tag, bool bReverseFromConfig = false)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.ResumeActiveTagSequence(tag, bReverseFromConfig);
			}
		}

		// Token: 0x06022944 RID: 141636 RVA: 0x009D5780 File Offset: 0x009D3980
		public bool? GetIsActiveTagSequencePlayReverseFromConfig(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetIsActiveTagSequencePlayReverseFromConfig(tag);
			}
			return null;
		}

		// Token: 0x06022945 RID: 141637 RVA: 0x009D57C0 File Offset: 0x009D39C0
		public void PlayActiveTagSequenceTo(int handleId, FGameplayTag tag, float progress, bool bReverseFromConfig = false)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PlayActiveTagSequenceTo(tag, progress, bReverseFromConfig);
			}
		}

		// Token: 0x06022946 RID: 141638 RVA: 0x009D57F8 File Offset: 0x009D39F8
		public void RegisterWaterEffectObject(SceneObjectWaterEffect objectParam)
		{
			this.WaterObjects.Add(objectParam);
			objectParam.AfterRegistered();
		}

		// Token: 0x06022947 RID: 141639 RVA: 0x009D580C File Offset: 0x009D3A0C
		public void UnregisterWaterEffectObject(SceneObjectWaterEffect objectParam)
		{
			int num = this.WaterObjects.FindIndex((SceneObjectWaterEffect value) => value == objectParam);
			if (num == -1)
			{
				Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.LSY, "要移除的SceneObjectWaterEffect不存在队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (objectParam != null)
				{
					objectParam.BeforeUnregistered();
				}
				return;
			}
			objectParam.BeforeUnregistered();
			this.WaterObjects[num] = this.WaterObjects[this.WaterObjects.Count - 1];
			this.WaterObjects.RemoveAt(this.WaterObjects.Count - 1);
		}

		// Token: 0x06022948 RID: 141640 RVA: 0x009D58B9 File Offset: 0x009D3AB9
		public void RegisterAirWallEffectObject(SceneObjectAirWallEffect objectParam)
		{
			this.AirWallObjects.Add(objectParam);
			objectParam.AfterRegistered();
		}

		// Token: 0x06022949 RID: 141641 RVA: 0x009D58D0 File Offset: 0x009D3AD0
		public void UnregisterAirWallEffectObject(SceneObjectAirWallEffect objectParam)
		{
			int num = this.AirWallObjects.FindIndex((SceneObjectAirWallEffect value) => value == objectParam);
			if (num == -1)
			{
				Log.Instance.Error(ELogModule.RenderEffect, ELogAuthor.CH, "要移除的SceneObjectAirWallEffect不存在队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (objectParam != null)
				{
					objectParam.BeforeUnregistered();
				}
				return;
			}
			objectParam.BeforeUnregistered();
			this.AirWallObjects[num] = this.AirWallObjects[this.AirWallObjects.Count - 1];
			this.AirWallObjects.RemoveAt(this.AirWallObjects.Count - 1);
		}

		// Token: 0x0602294A RID: 141642 RVA: 0x009D5980 File Offset: 0x009D3B80
		public void PlayExtraEffectByTag(int handleId, FGameplayTag tag, bool jumpToEnd)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PlayExtraEffect(tag, jumpToEnd);
			}
		}

		// Token: 0x0602294B RID: 141643 RVA: 0x009D59B8 File Offset: 0x009D3BB8
		public void PlayKuroSkeletalMeshDestruction(int handleId, AActor actor, bool jumpToEnd = false)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PlayKuroSkeletalMeshDestruction(actor, jumpToEnd);
			}
		}

		// Token: 0x0602294C RID: 141644 RVA: 0x009D59F0 File Offset: 0x009D3BF0
		public void StopExtraEffectByTag(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.StopExtraEffect(tag);
			}
		}

		// Token: 0x0602294D RID: 141645 RVA: 0x009D5A28 File Offset: 0x009D3C28
		public void UpdateHitInfo(int handleId, Vector pos, FVector dir)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.UpdateHitInfo(pos, dir);
			}
		}

		// Token: 0x0602294E RID: 141646 RVA: 0x009D5A60 File Offset: 0x009D3C60
		public void UpdateRangeOverlapInfo(int handleId, bool isEnter, AActor otherActor)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.UpdateRangeOverlapInfo(isEnter, otherActor);
			}
		}

		// Token: 0x0602294F RID: 141647 RVA: 0x009D5A98 File Offset: 0x009D3C98
		public void SetOverrideSeqBindActor(int handleId, AActor actorToBind, [Nullable(2)] string bindingName = null)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel == null)
			{
				return;
			}
			sceneInteractionLevel.SetOverrideSeqBindActor(actorToBind, bindingName);
		}

		// Token: 0x06022950 RID: 141648 RVA: 0x009D5AD0 File Offset: 0x009D3CD0
		public void UnsetOverrideSeqBindActor(int handleId, AActor actorToUnBind, [Nullable(2)] string bindingName = null)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel == null)
			{
				return;
			}
			sceneInteractionLevel.UnsetOverrideSeqBindActor(actorToUnBind, bindingName);
		}

		// Token: 0x06022951 RID: 141649 RVA: 0x009D5B08 File Offset: 0x009D3D08
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public TArray<AActor> GetReceivingDecalsActors(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetReceivingDecalsActors();
			}
			return null;
		}

		// Token: 0x06022952 RID: 141650 RVA: 0x009D5B40 File Offset: 0x009D3D40
		public void DisableInteractionLevel(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.Disable();
			}
		}

		// Token: 0x06022953 RID: 141651 RVA: 0x009D5B74 File Offset: 0x009D3D74
		public void EnableInteractionLevel(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.Enable();
			}
		}

		// Token: 0x06022954 RID: 141652 RVA: 0x009D5BA8 File Offset: 0x009D3DA8
		public void Tick(float deltaSeconds)
		{
			int i = 0;
			int count = this.WaterObjects.Count;
			while (i < count)
			{
				this.WaterObjects[i].Update(deltaSeconds);
				i++;
			}
			int j = 0;
			int count2 = this.AirWallObjects.Count;
			while (j < count2)
			{
				this.AirWallObjects[j].Update((double)deltaSeconds);
				j++;
			}
			this.TempCacheIds.Clear();
			foreach (int item in this.AllSceneInteractionInfos.Keys)
			{
				this.TempCacheIds.Add(item);
			}
			foreach (int key in this.TempCacheIds)
			{
				SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(key) ? this.AllSceneInteractionInfos[key] : null;
				if (sceneInteractionLevel != null && !sceneInteractionLevel.IsInfoDestroyed())
				{
					sceneInteractionLevel.Update(deltaSeconds);
				}
			}
		}

		// Token: 0x06022955 RID: 141653 RVA: 0x009D5CDC File Offset: 0x009D3EDC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022956 RID: 141654 RVA: 0x009D5CDE File Offset: 0x009D3EDE
		public static void ResetStaticDefaultValue()
		{
			SceneInteractionManager.Instanced = null;
		}

		// Token: 0x0401325A RID: 78426
		public bool IsOnMobile;

		// Token: 0x0401325B RID: 78427
		[Nullable(2)]
		protected static SceneInteractionManager Instanced;

		// Token: 0x0401325C RID: 78428
		protected int UniqueLevelInstanceId;

		// Token: 0x0401325D RID: 78429
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, SceneInteractionLevel> AllSceneInteractionInfos;

		// Token: 0x0401325E RID: 78430
		protected List<int> TempCacheIds = new List<int>();

		// Token: 0x0401325F RID: 78431
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<AActor, int> ActorMap;

		// Token: 0x04013260 RID: 78432
		[Nullable(2)]
		public PDA_InteractionPlayerConfig_C MainPlayerConfig;

		// Token: 0x04013261 RID: 78433
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<SceneObjectWaterEffect> WaterObjects;

		// Token: 0x04013262 RID: 78434
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<SceneObjectAirWallEffect> AirWallObjects;

		// Token: 0x04013263 RID: 78435
		[Nullable(2)]
		protected Vector TempVector;

		// Token: 0x04013264 RID: 78436
		private int TickProcessId;

		// Token: 0x04013265 RID: 78437
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x04013266 RID: 78438
		private const float ms2s = 1000f;

		// Token: 0x04013267 RID: 78439
		private const float updateInternalScaleForRemote = 2f;
	}
}
