using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045E5 RID: 17893
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneInteractionManager : IStaticVariableResetter
	{
		// Token: 0x0602E223 RID: 188963 RVA: 0x00AA8426 File Offset: 0x00AA6626
		static SceneInteractionManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneInteractionManager.CreateStaticDefaultValue), new Action(SceneInteractionManager.ResetStaticDefaultValue));
		}

		// Token: 0x0602E224 RID: 188964 RVA: 0x00AA8445 File Offset: 0x00AA6645
		public static SceneInteractionManager Get()
		{
			return SceneInteractionManager.Instanced;
		}

		// Token: 0x0602E225 RID: 188965 RVA: 0x00AA844C File Offset: 0x00AA664C
		public static void Initialize()
		{
			if (SceneInteractionManager.Instanced == null)
			{
				SceneInteractionManager.Instanced = new SceneInteractionManager();
				SceneInteractionManager.Instanced.Init();
			}
		}

		// Token: 0x0602E226 RID: 188966 RVA: 0x00AA846C File Offset: 0x00AA666C
		public static void StaticTick(float delta)
		{
			float deltaSeconds = delta / 1000f;
			if (SceneInteractionManager.Instanced != null)
			{
				SceneInteractionManager.Instanced.Tick(deltaSeconds);
			}
		}

		// Token: 0x0602E227 RID: 188967 RVA: 0x00AA8494 File Offset: 0x00AA6694
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

		// Token: 0x0602E228 RID: 188968 RVA: 0x00AA853C File Offset: 0x00AA673C
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

		// Token: 0x0602E229 RID: 188969 RVA: 0x00AA860C File Offset: 0x00AA680C
		private void OnUpdateSceneTeam()
		{
			this.OnChangeRole(null, null);
		}

		// Token: 0x0602E22A RID: 188970 RVA: 0x00AA8618 File Offset: 0x00AA6818
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

		// Token: 0x0602E22B RID: 188971 RVA: 0x00AA8667 File Offset: 0x00AA6867
		private void TickProcessUpdateInteraction(float delta)
		{
			this.TickProcessId = 0;
			this.TimerHandle = TimerSystem.Instance.Next(delegate(float _)
			{
				this.TimerHandle = null;
				this.UpdateInteractionConfigs();
			}, null, null);
		}

		// Token: 0x0602E22C RID: 188972 RVA: 0x00AA868E File Offset: 0x00AA688E
		protected void LoadAssets()
		{
			ResourceSystem.Instance.LoadAsync<PDA_InteractionPlayerConfig_C>("/Game/Aki/Render/Data/Interaction/DA_InteractionMainPlayerConfig.DA_InteractionMainPlayerConfig", delegate([Nullable(2)] PDA_InteractionPlayerConfig_C result, string _)
			{
				this.MainPlayerConfig = result;
				this.OnChangeRole(null, null);
			}, 100, "js_undefined");
		}

		// Token: 0x0602E22D RID: 188973 RVA: 0x00AA86B4 File Offset: 0x00AA68B4
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

		// Token: 0x0602E22E RID: 188974 RVA: 0x00AA878C File Offset: 0x00AA698C
		public void SetLevelStreamingPriority(int handleId, int priority)
		{
			SceneInteractionLevel sceneInteractionLevel;
			if (this.AllSceneInteractionInfos != null && this.AllSceneInteractionInfos.TryGetValue(handleId, out sceneInteractionLevel))
			{
				sceneInteractionLevel.SetStreamingPriority(priority);
			}
		}

		// Token: 0x0602E22F RID: 188975 RVA: 0x00AA87B8 File Offset: 0x00AA69B8
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

		// Token: 0x0602E230 RID: 188976 RVA: 0x00AA8858 File Offset: 0x00AA6A58
		public bool SwitchSceneInteractionToState(int handleId, EKuroSceneInteractionState targetState, bool needTransition, bool force, bool jumpToEnd = false)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			return sceneInteractionLevel != null && sceneInteractionLevel.SwitchToState(targetState, needTransition, force, jumpToEnd);
		}

		// Token: 0x0602E231 RID: 188977 RVA: 0x00AA8894 File Offset: 0x00AA6A94
		public EKuroSceneInteractionState GetSceneInteractionCurrentState(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetCurrentState();
			}
			return EKuroSceneInteractionState.Error;
		}

		// Token: 0x0602E232 RID: 188978 RVA: 0x00AA88CC File Offset: 0x00AA6ACC
		public void PlaySceneInteractionEffect(int handleId, ESceneInteractionEffect effectKey)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PlaySceneEffect(effectKey);
			}
		}

		// Token: 0x0602E233 RID: 188979 RVA: 0x00AA8904 File Offset: 0x00AA6B04
		public void EndSceneInteractionEffect(int handleId, ESceneInteractionEffect effectKey)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.EndSceneEffect(effectKey);
			}
		}

		// Token: 0x0602E234 RID: 188980 RVA: 0x00AA893C File Offset: 0x00AA6B3C
		public void PlaySceneInteractionEndEffect(int handleId, ESceneInteractionEffect effectKey)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PlaySceneEndEffect(effectKey);
			}
		}

		// Token: 0x0602E235 RID: 188981 RVA: 0x00AA8974 File Offset: 0x00AA6B74
		public void ChangeSceneInteractionPlayDirection(int handleId, bool bPlayBack)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.ChangePlayDirection(bPlayBack);
			}
		}

		// Token: 0x0602E236 RID: 188982 RVA: 0x00AA89AC File Offset: 0x00AA6BAC
		public bool IsSceneInteractionStreamingComplete(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			return sceneInteractionLevel != null && sceneInteractionLevel.IsStreamingComplete();
		}

		// Token: 0x0602E237 RID: 188983 RVA: 0x00AA89E4 File Offset: 0x00AA6BE4
		public void ToggleSceneInteractionVisible(int handleId, bool visible, bool needHidden = false, [Nullable(2)] Action onLevelStreamingShowOrHideCallback = null, string reason = "")
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.ToggleLevelVisible(visible, needHidden, onLevelStreamingShowOrHideCallback, reason);
			}
		}

		// Token: 0x0602E238 RID: 188984 RVA: 0x00AA8A20 File Offset: 0x00AA6C20
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

		// Token: 0x0602E239 RID: 188985 RVA: 0x00AA8A58 File Offset: 0x00AA6C58
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

		// Token: 0x0602E23A RID: 188986 RVA: 0x00AA8A90 File Offset: 0x00AA6C90
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

		// Token: 0x0602E23B RID: 188987 RVA: 0x00AA8AC8 File Offset: 0x00AA6CC8
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

		// Token: 0x0602E23C RID: 188988 RVA: 0x00AA8B00 File Offset: 0x00AA6D00
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

		// Token: 0x0602E23D RID: 188989 RVA: 0x00AA8B38 File Offset: 0x00AA6D38
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

		// Token: 0x0602E23E RID: 188990 RVA: 0x00AA8B70 File Offset: 0x00AA6D70
		public FTransformDouble? GetActorOriginalRelTransform(int handleId, AActor actor)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetActorOriginalRelTransform(actor);
			}
			return null;
		}

		// Token: 0x0602E23F RID: 188991 RVA: 0x00AA8BB0 File Offset: 0x00AA6DB0
		public void AttachToActor(int handleId, AActor parentActor)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.AttachToActor(parentActor);
			}
		}

		// Token: 0x0602E240 RID: 188992 RVA: 0x00AA8BE8 File Offset: 0x00AA6DE8
		public void SetCollisionActorsOwner(int handleId, AActor owner)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.SetCollisionActorsOwner(owner);
			}
		}

		// Token: 0x0602E241 RID: 188993 RVA: 0x00AA8C20 File Offset: 0x00AA6E20
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

		// Token: 0x0602E242 RID: 188994 RVA: 0x00AA8CAC File Offset: 0x00AA6EAC
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

		// Token: 0x0602E243 RID: 188995 RVA: 0x00AA8D28 File Offset: 0x00AA6F28
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

		// Token: 0x0602E244 RID: 188996 RVA: 0x00AA8D60 File Offset: 0x00AA6F60
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

		// Token: 0x0602E245 RID: 188997 RVA: 0x00AA8D98 File Offset: 0x00AA6F98
		public FGameplayTag? GetPartCollisionActorTag(int handleId, AActor actor)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetPartCollisionActorTag(actor);
			}
			return null;
		}

		// Token: 0x0602E246 RID: 188998 RVA: 0x00AA8DD8 File Offset: 0x00AA6FD8
		public int? GetPartCollisionActorsNum(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetPartCollisionActorsNum();
			}
			return null;
		}

		// Token: 0x0602E247 RID: 188999 RVA: 0x00AA8E18 File Offset: 0x00AA7018
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

		// Token: 0x0602E248 RID: 189000 RVA: 0x00AA8E50 File Offset: 0x00AA7050
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

		// Token: 0x0602E249 RID: 189001 RVA: 0x00AA8E88 File Offset: 0x00AA7088
		public float? GetActiveTagSequencePlaybackProgress(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetActiveTagSequencePlaybackProgress(tag);
			}
			return null;
		}

		// Token: 0x0602E24A RID: 189002 RVA: 0x00AA8EC8 File Offset: 0x00AA70C8
		public void SetActiveTagSequencePlaybackProgress(int handleId, FGameplayTag tag, float progress)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.SetActiveTagSequencePlaybackProgress(tag, progress);
			}
		}

		// Token: 0x0602E24B RID: 189003 RVA: 0x00AA8F00 File Offset: 0x00AA7100
		public double? GetActiveTagSequenceDurationTime(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetActiveTagSequenceDurationTime(tag);
			}
			return null;
		}

		// Token: 0x0602E24C RID: 189004 RVA: 0x00AA8F40 File Offset: 0x00AA7140
		public void SetActiveTagSequenceDurationTime(int handleId, FGameplayTag tag, float durationSecond)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.SetActiveTagSequenceDurationTime(tag, durationSecond);
			}
		}

		// Token: 0x0602E24D RID: 189005 RVA: 0x00AA8F78 File Offset: 0x00AA7178
		public void PauseActiveTagSequence(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PauseActiveTagSequence(tag);
			}
		}

		// Token: 0x0602E24E RID: 189006 RVA: 0x00AA8FB0 File Offset: 0x00AA71B0
		public void ResumeActiveTagSequence(int handleId, FGameplayTag tag, bool bReverseFromConfig = false)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.ResumeActiveTagSequence(tag, bReverseFromConfig);
			}
		}

		// Token: 0x0602E24F RID: 189007 RVA: 0x00AA8FE8 File Offset: 0x00AA71E8
		public bool? GetIsActiveTagSequencePlayReverseFromConfig(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				return sceneInteractionLevel.GetIsActiveTagSequencePlayReverseFromConfig(tag);
			}
			return null;
		}

		// Token: 0x0602E250 RID: 189008 RVA: 0x00AA9028 File Offset: 0x00AA7228
		public void PlayActiveTagSequenceTo(int handleId, FGameplayTag tag, float progress, bool bReverseFromConfig = false)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PlayActiveTagSequenceTo(tag, progress, bReverseFromConfig);
			}
		}

		// Token: 0x0602E251 RID: 189009 RVA: 0x00AA9060 File Offset: 0x00AA7260
		public void RegisterWaterEffectObject(SceneObjectWaterEffect objectParam)
		{
			this.WaterObjects.Add(objectParam);
			objectParam.AfterRegistered();
		}

		// Token: 0x0602E252 RID: 189010 RVA: 0x00AA9074 File Offset: 0x00AA7274
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

		// Token: 0x0602E253 RID: 189011 RVA: 0x00AA9121 File Offset: 0x00AA7321
		public void RegisterAirWallEffectObject(SceneObjectAirWallEffect objectParam)
		{
			this.AirWallObjects.Add(objectParam);
			objectParam.AfterRegistered();
		}

		// Token: 0x0602E254 RID: 189012 RVA: 0x00AA9138 File Offset: 0x00AA7338
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

		// Token: 0x0602E255 RID: 189013 RVA: 0x00AA91E8 File Offset: 0x00AA73E8
		public void PlayExtraEffectByTag(int handleId, FGameplayTag tag, bool jumpToEnd)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PlayExtraEffect(tag, jumpToEnd);
			}
		}

		// Token: 0x0602E256 RID: 189014 RVA: 0x00AA9220 File Offset: 0x00AA7420
		public void PlayKuroSkeletalMeshDestruction(int handleId, AActor actor, bool jumpToEnd = false)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.PlayKuroSkeletalMeshDestruction(actor, jumpToEnd);
			}
		}

		// Token: 0x0602E257 RID: 189015 RVA: 0x00AA9258 File Offset: 0x00AA7458
		public void StopExtraEffectByTag(int handleId, FGameplayTag tag)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.StopExtraEffect(tag);
			}
		}

		// Token: 0x0602E258 RID: 189016 RVA: 0x00AA9290 File Offset: 0x00AA7490
		public void UpdateHitInfo(int handleId, Vector pos, FVector dir)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.UpdateHitInfo(pos, dir);
			}
		}

		// Token: 0x0602E259 RID: 189017 RVA: 0x00AA92C8 File Offset: 0x00AA74C8
		public void UpdateRangeOverlapInfo(int handleId, bool isEnter, AActor otherActor)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.UpdateRangeOverlapInfo(isEnter, otherActor);
			}
		}

		// Token: 0x0602E25A RID: 189018 RVA: 0x00AA9300 File Offset: 0x00AA7500
		public void SetOverrideSeqBindActor(int handleId, AActor actorToBind, [Nullable(2)] string bindingName = null)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel == null)
			{
				return;
			}
			sceneInteractionLevel.SetOverrideSeqBindActor(actorToBind, bindingName);
		}

		// Token: 0x0602E25B RID: 189019 RVA: 0x00AA9338 File Offset: 0x00AA7538
		public void UnsetOverrideSeqBindActor(int handleId, AActor actorToUnBind, [Nullable(2)] string bindingName = null)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel == null)
			{
				return;
			}
			sceneInteractionLevel.UnsetOverrideSeqBindActor(actorToUnBind, bindingName);
		}

		// Token: 0x0602E25C RID: 189020 RVA: 0x00AA9370 File Offset: 0x00AA7570
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

		// Token: 0x0602E25D RID: 189021 RVA: 0x00AA93A8 File Offset: 0x00AA75A8
		public void DisableInteractionLevel(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.Disable();
			}
		}

		// Token: 0x0602E25E RID: 189022 RVA: 0x00AA93DC File Offset: 0x00AA75DC
		public void EnableInteractionLevel(int handleId)
		{
			SceneInteractionLevel sceneInteractionLevel = this.AllSceneInteractionInfos.ContainsKey(handleId) ? this.AllSceneInteractionInfos[handleId] : null;
			if (sceneInteractionLevel != null)
			{
				sceneInteractionLevel.Enable();
			}
		}

		// Token: 0x0602E25F RID: 189023 RVA: 0x00AA9410 File Offset: 0x00AA7610
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

		// Token: 0x0602E260 RID: 189024 RVA: 0x00AA9544 File Offset: 0x00AA7744
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E261 RID: 189025 RVA: 0x00AA9546 File Offset: 0x00AA7746
		public static void ResetStaticDefaultValue()
		{
			SceneInteractionManager.Instanced = null;
		}

		// Token: 0x04018C1B RID: 101403
		public bool IsOnMobile;

		// Token: 0x04018C1C RID: 101404
		[Nullable(2)]
		protected static SceneInteractionManager Instanced;

		// Token: 0x04018C1D RID: 101405
		protected int UniqueLevelInstanceId;

		// Token: 0x04018C1E RID: 101406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, SceneInteractionLevel> AllSceneInteractionInfos;

		// Token: 0x04018C1F RID: 101407
		protected List<int> TempCacheIds = new List<int>();

		// Token: 0x04018C20 RID: 101408
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<AActor, int> ActorMap;

		// Token: 0x04018C21 RID: 101409
		[Nullable(2)]
		public PDA_InteractionPlayerConfig_C MainPlayerConfig;

		// Token: 0x04018C22 RID: 101410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<SceneObjectWaterEffect> WaterObjects;

		// Token: 0x04018C23 RID: 101411
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<SceneObjectAirWallEffect> AirWallObjects;

		// Token: 0x04018C24 RID: 101412
		[Nullable(2)]
		protected Vector TempVector;

		// Token: 0x04018C25 RID: 101413
		private int TickProcessId;

		// Token: 0x04018C26 RID: 101414
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x04018C27 RID: 101415
		private const float ms2s = 1000f;

		// Token: 0x04018C28 RID: 101416
		private const float updateInternalScaleForRemote = 2f;
	}
}
