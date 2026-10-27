using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction;
using AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect;
using CSharpScript.Core.Extension;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;
using CSharpScript.Game.World.Controller;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007187 RID: 29063
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemMultiInteractionActorComponent : EntityComponent
	{
		// Token: 0x06047102 RID: 291074 RVA: 0x01204871 File Offset: 0x01202A71
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			return true;
		}

		// Token: 0x06047103 RID: 291075 RVA: 0x01204898 File Offset: 0x01202A98
		private void AfterFinishGenerateActor()
		{
			this.GenerateFinish = true;
			while (!this.DynamicOperateWaitQueue.Empty)
			{
				SceneItemMultiInteractionActorComponent.WaitQueueData waitQueueData = this.DynamicOperateWaitQueue.Pop();
				if (waitQueueData.Func.IsT1)
				{
					waitQueueData.Func.AsT1(waitQueueData.Index, waitQueueData.TagIds);
				}
				else if (waitQueueData.Func.IsT2)
				{
					waitQueueData.Func.AsT2(waitQueueData.Index);
				}
			}
			if (this.OnGeneratedFinish != null)
			{
				this.OnGeneratedFinish();
			}
			SceneInteractionLevel sceneInteractionInfo = this.SceneInteractionInfo;
			SceneInteractionActor sceneInteractionActor = ((sceneInteractionInfo != null) ? sceneInteractionInfo.MainActor : null) as SceneInteractionActor;
			bool flag = (((sceneInteractionActor != null) ? new int?(sceneInteractionActor.CollisionActors.Num()) : null) ?? 0) == 0;
			if (flag)
			{
				return;
			}
			AStaticMeshActor astaticMeshActor = sceneInteractionActor.CollisionActors.Get(0) as AStaticMeshActor;
			if (astaticMeshActor == null)
			{
				return;
			}
			UStaticMeshComponent staticMeshComponent = astaticMeshActor.StaticMeshComponent;
			if (((staticMeshComponent != null) ? staticMeshComponent.StaticMesh : null) == null)
			{
				return;
			}
			TArray<FTransform> tarray = new TArray<FTransform>();
			foreach (KeyValuePair<string, SceneInteractionActor> keyValuePair in this.GeneratedActorMap)
			{
				AActor value = keyValuePair.Value;
				SceneItemActorComponent actorComp = this.ActorComp;
				FTransformDouble? ftransformDouble = (actorComp != null) ? new FTransformDouble?(actorComp.ActorTransform) : null;
				FTransformDouble ftransformDouble2 = value.D_GetTransform();
				FTransformDouble value2 = ftransformDouble.Value;
				FTransform value3 = UKismetMathLibrary.Conv_TransformDoubleToTransform(ftransformDouble2.GetRelativeTransform(value2));
				tarray.Add(value3);
			}
			SceneItemActorComponent actorComp2 = this.ActorComp;
			AActor aactor = (actorComp2 != null) ? actorComp2.Owner : null;
			if (aactor != null)
			{
				UStaticMeshComponent ustaticMeshComponent = aactor.GetComponentByClass(UStaticMeshComponent.StaticClass()) as UStaticMeshComponent;
				if (ustaticMeshComponent != null)
				{
					UKuroStaticMeshLibrary.MergeSimpleCollisions(astaticMeshActor.StaticMeshComponent, tarray);
					UStaticMeshComponent ustaticMeshComponent2 = ustaticMeshComponent;
					UStaticMeshComponent staticMeshComponent2 = astaticMeshActor.StaticMeshComponent;
					ustaticMeshComponent2.SetStaticMesh((staticMeshComponent2 != null) ? staticMeshComponent2.StaticMesh : null);
				}
			}
			foreach (int tagId in SceneItemMultiInteractionActorComponent.NeedForwardTagIds)
			{
				this.TagComp.AddTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayTagChanged), null);
			}
		}

		// Token: 0x06047104 RID: 291076 RVA: 0x01204AFC File Offset: 0x01202CFC
		protected override bool OnEnd()
		{
			foreach (int tagId in SceneItemMultiInteractionActorComponent.NeedForwardTagIds)
			{
				this.TagComp.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayTagChanged));
			}
			foreach (KeyValuePair<string, SceneInteractionActor> keyValuePair in this.GeneratedActorMap)
			{
				SceneInteractionActor value = keyValuePair.Value;
				MultiInteractionActorController.Instance.AddWaitDestroyActor(value);
			}
			this.GeneratedActorMap.Clear();
			SceneInteractionLevel sceneInteractionInfo = this.SceneInteractionInfo;
			bool flag;
			if (sceneInteractionInfo == null)
			{
				flag = false;
			}
			else
			{
				AActor mainActor = sceneInteractionInfo.MainActor;
				flag = ((mainActor != null) ? new bool?(mainActor.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				SceneInteractionActor actor = this.SceneInteractionInfo.MainActor as SceneInteractionActor;
				MultiInteractionActorController.Instance.AddWaitDestroyActor(actor);
			}
			return true;
		}

		// Token: 0x06047105 RID: 291077 RVA: 0x01204C10 File Offset: 0x01202E10
		private void OnGameplayTagChanged(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				using (Dictionary<string, SceneInteractionActor>.Enumerator enumerator = this.GeneratedActorMap.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, SceneInteractionActor> keyValuePair = enumerator.Current;
						string key = keyValuePair.Key;
						this.AddTagsByIndex(JigsawIndex.GenObjFromKey(key), tagId);
					}
					return;
				}
			}
			foreach (KeyValuePair<string, SceneInteractionActor> keyValuePair2 in this.GeneratedActorMap)
			{
				string key2 = keyValuePair2.Key;
				this.RemoveTagsByIndex(JigsawIndex.GenObjFromKey(key2), tagId);
			}
		}

		// Token: 0x06047106 RID: 291078 RVA: 0x01204CC8 File Offset: 0x01202EC8
		private void GenerateActorInternal(JigsawIndex index, AActor actor)
		{
			Vector vector = this.GeneratedActorIndex2LocFunc(index);
			SceneInteractionActor newActor = UKuroStaticLibrary.SpawnActorFromAnother(actor, this.ActorComp.Owner) as SceneInteractionActor;
			SceneInteractionActor newActor2 = newActor;
			if (newActor2 == null || !newActor2.IsValid())
			{
				return;
			}
			AttachToActorController.Instance.AttachToActor(newActor, this.ActorComp.Owner, EDetachType.DestroyExternal, "SceneItemMultiInteractionActorComponent.GenerateActorInternal", null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, false, false, false, false);
			FRotator newRotation = actor.K2_GetActorRotation();
			FHitResult fhitResult = null;
			newActor.D_K2_SetActorLocationAndRotation(vector.ToUeVector(false), newRotation, false, ref fhitResult, true);
			this.CacheActorMap.Clear();
			this.GenerateActorMap(newActor);
			this.ProcessingNewActor(newActor);
			this.ResetActorOwner(newActor, newActor);
			string indexKey = index.GetKey();
			this.GeneratedActorMap[indexKey] = newActor;
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.UpdateSceneInteractionLevel(index);
				if (this.CacheTagsMaps.ContainsKey(indexKey))
				{
					List<int> collection = this.CacheTagsMaps[indexKey];
					this.CacheTagsMaps.Remove(indexKey);
					List<int> list;
					if (!this.GeneratedActorTagMap.TryGetValue(indexKey, out list))
					{
						list = new List<int>();
					}
					list.AddRange(collection);
					this.GeneratedActorTagMap[indexKey] = list;
				}
				List<int> list2;
				if (this.GeneratedActorTagMap.TryGetValue(indexKey, out list2) && list2 != null)
				{
					foreach (int tagId in list2)
					{
						newActor.PlayExtraEffectOnTagsChange(GameplayTagUtils.GetGameplayTagById(tagId).Value, false);
						this.ChangeSceneInteractionEffectOnTagChanged(index, tagId, true);
					}
				}
			}, null, null);
		}

		// Token: 0x06047107 RID: 291079 RVA: 0x01204DFC File Offset: 0x01202FFC
		private EKuroSceneInteractionState GetCurrentState(IReadOnlyList<int> tags)
		{
			TMap<FGameplayTag, EKuroSceneInteractionState> 场景交互物状态列表 = this.ModelConfig.场景交互物状态列表;
			foreach (int tagId in tags)
			{
				FGameplayTag value = GameplayTagUtils.GetGameplayTagById(tagId).Value;
				if (场景交互物状态列表.Contains(value))
				{
					return 场景交互物状态列表.Get(value);
				}
			}
			return EKuroSceneInteractionState.Error;
		}

		// Token: 0x06047108 RID: 291080 RVA: 0x01204E70 File Offset: 0x01203070
		private void GenerateActorMap(AActor actor)
		{
			TArray<AActor> tarray = new TArray<AActor>();
			actor.GetAttachedActors(ref tarray, true);
			for (int i = 0; i < tarray.Num(); i++)
			{
				this.GenerateActorMap(tarray.Get(i));
			}
			if (actor.GetOwner() != null)
			{
				this.CacheActorMap[actor.GetOwner()] = actor;
			}
		}

		// Token: 0x06047109 RID: 291081 RVA: 0x01204EC4 File Offset: 0x012030C4
		private void ProcessingNewActor(SceneInteractionActor actor)
		{
			List<EKuroSceneInteractionState> list = new List<EKuroSceneInteractionState>();
			foreach (KeyValuePair<EKuroSceneInteractionState, SSceneInteractionitem> keyValuePair in actor.States)
			{
				EKuroSceneInteractionState ekuroSceneInteractionState;
				SSceneInteractionitem ssceneInteractionitem;
				keyValuePair.Deconstruct(out ekuroSceneInteractionState, out ssceneInteractionitem);
				EKuroSceneInteractionState item = ekuroSceneInteractionState;
				list.Add(item);
			}
			foreach (EKuroSceneInteractionState key in list)
			{
				SSceneInteractionitem ssceneInteractionitem2 = actor.States.Get(key);
				if (!(ssceneInteractionitem2 == null))
				{
					TArray<BP_EffectActor_C> effects = ssceneInteractionitem2.Effects;
					for (int i = 0; i < effects.Num(); i++)
					{
						BP_EffectActor_C bp_EffectActor_C = effects.Get(i);
						AActor aactor;
						if (bp_EffectActor_C != null && this.CacheActorMap.TryGetValue(bp_EffectActor_C, out aactor))
						{
							BP_EffectActor_C bp_EffectActor_C2 = aactor as BP_EffectActor_C;
							effects.Set(i, bp_EffectActor_C2);
						}
					}
					TArray<AActor> actors = ssceneInteractionitem2.Actors;
					for (int j = 0; j < actors.Num(); j++)
					{
						AActor aactor2 = actors.Get(j);
						AActor aactor3;
						if (aactor2 != null && this.CacheActorMap.TryGetValue(aactor2, out aactor3))
						{
							actors.Set(j, aactor3);
						}
					}
					TArray<AActor> hideActors = ssceneInteractionitem2.HideActors;
					for (int k = 0; k < hideActors.Num(); k++)
					{
						AActor aactor4 = hideActors.Get(k);
						AActor aactor5;
						if (aactor4 != null && this.CacheActorMap.TryGetValue(aactor4, out aactor5))
						{
							hideActors.Set(k, aactor5);
						}
					}
					TArray<SSceneInteractionMaterialController> materialControllers = ssceneInteractionitem2.MaterialControllers;
					for (int l = 0; l < materialControllers.Num(); l++)
					{
						SSceneInteractionMaterialController ssceneInteractionMaterialController = materialControllers.Get(l);
						TArray<AActor> actors2 = ssceneInteractionMaterialController.Actors;
						for (int m = 0; m < actors2.Num(); m++)
						{
							AActor aactor6 = actors2.Get(m);
							AActor aactor7;
							if (aactor6 != null && this.CacheActorMap.TryGetValue(aactor6, out aactor7))
							{
								actors2.Set(m, aactor7);
							}
						}
						materialControllers.Set(l, ssceneInteractionMaterialController);
					}
					TArray<SStateBasedEffect> stateBasedEffect = ssceneInteractionitem2.StateBasedEffect;
					for (int n = 0; n < stateBasedEffect.Num(); n++)
					{
						SStateBasedEffect sstateBasedEffect = stateBasedEffect.Get(n);
						BP_StateMachineEffectBase_C stateBasedEffect2 = sstateBasedEffect.StateBasedEffect;
						AActor aactor8;
						if (stateBasedEffect2 != null && this.CacheActorMap.TryGetValue(stateBasedEffect2, out aactor8))
						{
							BP_StateMachineEffectBase_C stateBasedEffect3 = aactor8 as BP_StateMachineEffectBase_C;
							sstateBasedEffect.StateBasedEffect = stateBasedEffect3;
						}
						stateBasedEffect.Set(n, sstateBasedEffect);
					}
					actor.States[key] = ssceneInteractionitem2;
				}
			}
			List<ESceneInteractionEffect> list2 = new List<ESceneInteractionEffect>();
			foreach (KeyValuePair<ESceneInteractionEffect, SScenePropertyEffect> keyValuePair2 in actor.Effects)
			{
				ESceneInteractionEffect esceneInteractionEffect;
				SScenePropertyEffect sscenePropertyEffect;
				keyValuePair2.Deconstruct(out esceneInteractionEffect, out sscenePropertyEffect);
				ESceneInteractionEffect item2 = esceneInteractionEffect;
				list2.Add(item2);
			}
			foreach (ESceneInteractionEffect key2 in list2)
			{
				SScenePropertyEffect sscenePropertyEffect2 = actor.Effects.Get(key2);
				if (!(sscenePropertyEffect2 == null))
				{
					TArray<AActor> actors3 = sscenePropertyEffect2.Material.Actors;
					for (int num = 0; num < actors3.Num(); num++)
					{
						AActor aactor9 = actors3.Get(num);
						AActor aactor10;
						if (aactor9 != null && this.CacheActorMap.TryGetValue(aactor9, out aactor10))
						{
							actors3.Set(num, aactor10);
						}
					}
					AActor aactor11;
					if (sscenePropertyEffect2.Effect != null && this.CacheActorMap.TryGetValue(sscenePropertyEffect2.Effect, out aactor11))
					{
						BP_EffectActor_C effect = aactor11 as BP_EffectActor_C;
						sscenePropertyEffect2.Effect = effect;
					}
					actor.Effects[key2] = sscenePropertyEffect2;
				}
			}
			List<FGameplayTag> list3 = new List<FGameplayTag>();
			foreach (KeyValuePair<FGameplayTag, SSceneInteractionTags> keyValuePair3 in actor.TagsAndCorrespondingEffects)
			{
				FGameplayTag fgameplayTag;
				SSceneInteractionTags ssceneInteractionTags;
				keyValuePair3.Deconstruct(out fgameplayTag, out ssceneInteractionTags);
				FGameplayTag item3 = fgameplayTag;
				list3.Add(item3);
			}
			foreach (FGameplayTag key3 in list3)
			{
				SSceneInteractionTags ssceneInteractionTags2 = actor.TagsAndCorrespondingEffects.Get(key3);
				if (!(ssceneInteractionTags2 == null))
				{
					TArray<AActor> actors4 = ssceneInteractionTags2.Actors;
					for (int num2 = 0; num2 < actors4.Num(); num2++)
					{
						AActor aactor12 = actors4.Get(num2);
						AActor aactor13;
						if (aactor12 != null && this.CacheActorMap.TryGetValue(aactor12, out aactor13))
						{
							actors4.Set(num2, aactor13);
						}
					}
					TArray<BP_EffectActor_C> effects2 = ssceneInteractionTags2.Effects;
					for (int num3 = 0; num3 < effects2.Num(); num3++)
					{
						BP_EffectActor_C bp_EffectActor_C3 = effects2.Get(num3);
						AActor aactor14;
						if (bp_EffectActor_C3 != null && this.CacheActorMap.TryGetValue(bp_EffectActor_C3, out aactor14))
						{
							BP_EffectActor_C bp_EffectActor_C4 = aactor14 as BP_EffectActor_C;
							effects2.Set(num3, bp_EffectActor_C4);
						}
					}
					TArray<AActor> hideActors2 = ssceneInteractionTags2.HideActors;
					for (int num4 = 0; num4 < hideActors2.Num(); num4++)
					{
						AActor aactor15 = hideActors2.Get(num4);
						AActor aactor16;
						if (aactor15 != null && this.CacheActorMap.TryGetValue(aactor15, out aactor16))
						{
							hideActors2.Set(num4, aactor16);
						}
					}
					TArray<SSceneInteractionMaterialController> materialControllers2 = ssceneInteractionTags2.MaterialControllers;
					for (int num5 = 0; num5 < materialControllers2.Num(); num5++)
					{
						SSceneInteractionMaterialController ssceneInteractionMaterialController2 = materialControllers2.Get(num5);
						TArray<AActor> actors5 = ssceneInteractionMaterialController2.Actors;
						for (int num6 = 0; num6 < actors5.Num(); num6++)
						{
							AActor aactor17 = actors5.Get(num6);
							AActor aactor18;
							if (aactor17 != null && this.CacheActorMap.TryGetValue(aactor17, out aactor18))
							{
								actors5.Set(num6, aactor18);
							}
						}
						materialControllers2.Set(num5, ssceneInteractionMaterialController2);
					}
					actor.TagsAndCorrespondingEffects[key3] = ssceneInteractionTags2;
				}
			}
			this.InteractionDataMap[actor] = new SceneItemMultiInteractionActorComponent.InteractionData(actor.States, actor.Effects);
		}

		// Token: 0x0604710A RID: 291082 RVA: 0x0120552C File Offset: 0x0120372C
		private void ResetActorOwner(AActor actor, AActor owner)
		{
			TArray<AActor> tarray = new TArray<AActor>();
			actor.GetAttachedActors(ref tarray, true);
			for (int i = 0; i < tarray.Num(); i++)
			{
				this.ResetActorOwner(tarray.Get(i), owner);
			}
			actor.Owner = owner;
		}

		// Token: 0x0604710B RID: 291083 RVA: 0x01205570 File Offset: 0x01203770
		public void InitGenerateInfo(string modelConfig, List<JigsawIndex> indexArray, Func<JigsawIndex, Vector> index2LocFunc, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, List<int>> initTag = null, [Nullable(2)] Action onGeneratedFinish = null)
		{
			this.ModelConfig = DataTableUtil.GetDataTableRowFromName<SModelConfig>(EDataTable.ModelConfig, modelConfig);
			this.OnGeneratedFinish = onGeneratedFinish;
			this.GeneratedActorIndexArray = indexArray;
			this.GeneratedActorIndex2LocFunc = index2LocFunc;
			if (initTag != null)
			{
				this.GeneratedActorTagMap = initTag;
			}
			this.InitLevelDynamic(this.ActorComp.ActorLocation, this.ActorComp.ActorRotation);
			this.IsInit = true;
		}

		// Token: 0x0604710C RID: 291084 RVA: 0x012055D0 File Offset: 0x012037D0
		public void InitLevelDynamic(FVectorDouble location, FRotator rotation)
		{
			UObject world = GlobalData.World;
			string text = this.ModelConfig.场景交互物.AssetPathName.ToString();
			if (text.Contains('.'))
			{
				text = text.Split('.', StringSplitOptions.None)[0];
			}
			bool flag = false;
			ULevelStreamingDynamic ulevelStreamingDynamic = ULevelStreamingDynamic.LoadLevelInstance(world, text, location.ToVector(), rotation, ref flag, "", default(TSubclassOf<ULevelStreamingDynamic>));
			FGameplayTag value = GameplayTagUtils.GetGameplayTagById(SceneItemMultiInteractionActorComponent.DefaultTagId).Value;
			EKuroSceneInteractionState? valueOrNull = this.ModelConfig.场景交互物状态列表.GetValueOrNull(value);
			if (flag && ulevelStreamingDynamic != null)
			{
				this.SceneInteractionInfo = new SceneInteractionLevel();
				this.SceneInteractionInfo.Init(ulevelStreamingDynamic, text, location, rotation, -1, valueOrNull, new Action(this.SetupSceneInteractionWhenLoadCompleted), true, false, 0, 0, null);
			}
		}

		// Token: 0x0604710D RID: 291085 RVA: 0x01205698 File Offset: 0x01203898
		private void SetupSceneInteractionWhenLoadCompleted()
		{
			this.SceneInteractionInfo.AttachToActor(this.ActorComp.Owner);
			TArray<AActor> allActorsInLevel = this.SceneInteractionInfo.GetAllActorsInLevel();
			if (allActorsInLevel != null)
			{
				foreach (AActor aactor in allActorsInLevel)
				{
					AStaticMeshActor astaticMeshActor = aactor as AStaticMeshActor;
					if (astaticMeshActor != null)
					{
						astaticMeshActor.Tags.Add(CharacterNameDefines.Instance.NO_SLIDE);
						UStaticMeshComponent staticMeshComponent = astaticMeshActor.StaticMeshComponent;
						if (staticMeshComponent != null)
						{
							staticMeshComponent.SetReceivesDecals(false);
						}
						astaticMeshActor.SetActorHiddenInGame(true);
						astaticMeshActor.SetActorEnableCollision(false);
					}
				}
			}
			if (!base.Active)
			{
				this.NeedGenWhenEnable = true;
				return;
			}
			if (this.GeneratedActorIndexArray != null)
			{
				ComponentForceTickController.Instance.RegisterTick(this, new Action<float>(this.SplitFrameGenerateActor));
			}
		}

		// Token: 0x0604710E RID: 291086 RVA: 0x0120576C File Offset: 0x0120396C
		protected override void OnEnable()
		{
			if (this.NeedGenWhenEnable && this.GeneratedActorIndexArray != null)
			{
				ComponentForceTickController.Instance.RegisterTick(this, new Action<float>(this.SplitFrameGenerateActor));
				this.NeedGenWhenEnable = false;
			}
		}

		// Token: 0x0604710F RID: 291087 RVA: 0x0120579C File Offset: 0x0120399C
		private void SplitFrameGenerateActor(float delta)
		{
			int i = 0;
			if (this.GeneratedActorIndexArray == null)
			{
				ComponentForceTickController.Instance.UnregisterTick(this);
				return;
			}
			while (i < 3)
			{
				if (this.GeneratedActorIndexArray.Count <= 0)
				{
					this.AfterFinishGenerateActor();
					ComponentForceTickController.Instance.UnregisterTick(this);
					return;
				}
				JigsawIndex index = this.GeneratedActorIndexArray[0];
				this.GeneratedActorIndexArray.RemoveAt(0);
				this.GenerateActorInternal(index, this.SceneInteractionInfo.MainActor);
				i++;
			}
		}

		// Token: 0x06047110 RID: 291088 RVA: 0x01205812 File Offset: 0x01203A12
		public bool IsChildrenActor(AActor actor)
		{
			return actor.Owner != null && this.InteractionDataMap.ContainsKey(actor.Owner);
		}

		// Token: 0x06047111 RID: 291089 RVA: 0x01205830 File Offset: 0x01203A30
		[return: Nullable(2)]
		public SceneInteractionActor GetInteractionActorByIndex(JigsawIndex index)
		{
			SceneInteractionActor result;
			if (!this.GeneratedActorMap.TryGetValue(index.GetKey(), out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06047112 RID: 291090 RVA: 0x01205855 File Offset: 0x01203A55
		public void AddTagsByIndex(JigsawIndex index, List<int> tags)
		{
			this.AddTagsByIndexInternal(index, tags);
		}

		// Token: 0x06047113 RID: 291091 RVA: 0x0120585F File Offset: 0x01203A5F
		public void AddTagsByIndex(JigsawIndex index, int tags)
		{
			this.AddTagsByIndexInternal(index, tags);
		}

		// Token: 0x06047114 RID: 291092 RVA: 0x01205870 File Offset: 0x01203A70
		private void AddTagsByIndexInternal(JigsawIndex index, object tags)
		{
			SceneInteractionActor sceneInteractionActor = this.GeneratedActorMap.ContainsKey(index.GetKey()) ? this.GeneratedActorMap[index.GetKey()] : null;
			if ((sceneInteractionActor == null || !sceneInteractionActor.IsValid()) && this.GenerateFinish)
			{
				return;
			}
			Dictionary<string, List<int>> dictionary = this.GenerateFinish ? this.GeneratedActorTagMap : this.CacheTagsMaps;
			List<int> list;
			if (!dictionary.TryGetValue(index.GetKey(), out list))
			{
				list = new List<int>();
				dictionary[index.GetKey()] = list;
			}
			IEnumerable<int> enumerable = tags as IEnumerable<int>;
			if (enumerable != null)
			{
				using (IEnumerator<int> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int num = enumerator.Current;
						if (!list.Contains(num))
						{
							list.Add(num);
							if (this.GenerateFinish)
							{
								sceneInteractionActor.PlayExtraEffectOnTagsChange(GameplayTagUtils.GetGameplayTagById(num).Value, false);
								this.ChangeSceneInteractionEffectOnTagChanged(index, num, true);
							}
						}
					}
					goto IL_136;
				}
			}
			if (tags is int)
			{
				int num2 = (int)tags;
				if (!list.Contains(num2))
				{
					list.Add(num2);
					if (this.GenerateFinish)
					{
						sceneInteractionActor.PlayExtraEffectOnTagsChange(GameplayTagUtils.GetGameplayTagById(num2).Value, false);
						this.ChangeSceneInteractionEffectOnTagChanged(index, num2, true);
					}
				}
			}
			IL_136:
			if (this.GenerateFinish)
			{
				this.UpdateSceneInteractionLevel(index);
			}
		}

		// Token: 0x06047115 RID: 291093 RVA: 0x012059D4 File Offset: 0x01203BD4
		public void RemoveTagsByIndex(JigsawIndex index, List<int> tags)
		{
			this.RemoveTagsByIndexInternal(index, tags);
		}

		// Token: 0x06047116 RID: 291094 RVA: 0x012059DE File Offset: 0x01203BDE
		public void RemoveTagsByIndex(JigsawIndex index, int tags)
		{
			this.RemoveTagsByIndexInternal(index, tags);
		}

		// Token: 0x06047117 RID: 291095 RVA: 0x012059F0 File Offset: 0x01203BF0
		private void RemoveTagsByIndexInternal(JigsawIndex index, object tags)
		{
			SceneInteractionActor sceneInteractionActor = this.GeneratedActorMap.ContainsKey(index.GetKey()) ? this.GeneratedActorMap[index.GetKey()] : null;
			if ((sceneInteractionActor == null || !sceneInteractionActor.IsValid()) && this.GenerateFinish)
			{
				return;
			}
			Dictionary<string, List<int>> dictionary = this.GenerateFinish ? this.GeneratedActorTagMap : this.CacheTagsMaps;
			List<int> list;
			if (!dictionary.TryGetValue(index.GetKey(), out list))
			{
				list = new List<int>();
				dictionary[index.GetKey()] = list;
			}
			IEnumerable<int> enumerable = tags as IEnumerable<int>;
			if (enumerable != null)
			{
				using (IEnumerator<int> enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int num = enumerator.Current;
						if (list.Contains(num))
						{
							list.Remove(num);
							if (this.GenerateFinish)
							{
								sceneInteractionActor.StopExtraEffectOnTagsChange(GameplayTagUtils.GetGameplayTagById(num).Value);
								this.ChangeSceneInteractionEffectOnTagChanged(index, num, false);
							}
						}
					}
					goto IL_136;
				}
			}
			if (tags is int)
			{
				int num2 = (int)tags;
				if (list.Contains(num2))
				{
					list.Remove(num2);
					if (this.GenerateFinish)
					{
						sceneInteractionActor.StopExtraEffectOnTagsChange(GameplayTagUtils.GetGameplayTagById(num2).Value);
						this.ChangeSceneInteractionEffectOnTagChanged(index, num2, false);
					}
				}
			}
			IL_136:
			if (this.GenerateFinish)
			{
				this.UpdateSceneInteractionLevel(index);
			}
		}

		// Token: 0x06047118 RID: 291096 RVA: 0x01205B54 File Offset: 0x01203D54
		public bool HasTagByIndex(JigsawIndex index, int tag)
		{
			List<int> list;
			return (this.GenerateFinish ? this.GeneratedActorTagMap : this.CacheTagsMaps).TryGetValue(index.GetKey(), out list) && list.Contains(tag);
		}

		// Token: 0x06047119 RID: 291097 RVA: 0x01205B90 File Offset: 0x01203D90
		private void ChangeSceneInteractionEffectOnTagChanged(JigsawIndex index, int tagId, bool isAdd)
		{
			Dictionary<int, ESceneInteractionEffect> dictionary = this.SceneInteractionEffectMap.GetValueOrDefault(index.GetKey());
			SceneInteractionActor sceneInteractionActor = this.GeneratedActorMap[index.GetKey()];
			if (isAdd)
			{
				if (dictionary == null)
				{
					dictionary = new Dictionary<int, ESceneInteractionEffect>();
					this.SceneInteractionEffectMap[index.GetKey()] = dictionary;
				}
				if (dictionary.ContainsKey(tagId))
				{
					return;
				}
				FGameplayTag value = GameplayTagUtils.GetGameplayTagById(tagId).Value;
				if (!this.ModelConfig.场景交互物特效列表.Contains(value))
				{
					return;
				}
				TEnumAsByte<ESceneInteractionEffect> value2 = this.ModelConfig.场景交互物特效列表.Get(value);
				sceneInteractionActor.PlayIndependentEffect(value2);
				dictionary[tagId] = value2;
				return;
			}
			else
			{
				if (dictionary == null || dictionary.Count == 0)
				{
					return;
				}
				ESceneInteractionEffect effectKey;
				if (!dictionary.Remove(tagId, out effectKey))
				{
					return;
				}
				sceneInteractionActor.EndIndependentEffect(effectKey);
				sceneInteractionActor.PlayIndependentEndEffect(effectKey);
				return;
			}
		}

		// Token: 0x0604711A RID: 291098 RVA: 0x01205C64 File Offset: 0x01203E64
		private void UpdateSceneInteractionLevel(JigsawIndex index)
		{
			string key = index.GetKey();
			SceneInteractionActor sceneInteractionActor = this.GeneratedActorMap[key];
			IReadOnlyList<int> readOnlyList = Array.Empty<int>();
			EKuroSceneInteractionState ekuroSceneInteractionState = EKuroSceneInteractionState.Error;
			List<int> list;
			if (this.GeneratedActorTagMap.TryGetValue(key, out list))
			{
				readOnlyList = list;
			}
			if (readOnlyList.Count > 0)
			{
				ekuroSceneInteractionState = this.GetCurrentState(readOnlyList);
			}
			if (ekuroSceneInteractionState == EKuroSceneInteractionState.Error)
			{
				FGameplayTag value = GameplayTagUtils.GetGameplayTagById(SceneItemMultiInteractionActorComponent.DefaultTagId).Value;
				ekuroSceneInteractionState = this.ModelConfig.场景交互物状态列表.GetValueOrNull(value).GetValueOrDefault(EKuroSceneInteractionState.Error);
			}
			sceneInteractionActor.SetState(ekuroSceneInteractionState, true, false);
		}

		// Token: 0x0604711B RID: 291099 RVA: 0x01205CF0 File Offset: 0x01203EF0
		public void DynamicRemoveActorByIndex(JigsawIndex index)
		{
			if (!this.GenerateFinish)
			{
				this.DynamicOperateWaitQueue.Push(new SceneItemMultiInteractionActorComponent.WaitQueueData(new SceneItemMultiInteractionActorComponent.TDynamicRemoveFunc(this.DynamicRemoveActorByIndex), index, new List<int>()));
				return;
			}
			string key = index.GetKey();
			SceneInteractionActor valueOrDefault = this.GeneratedActorMap.GetValueOrDefault(key);
			if (valueOrDefault == null)
			{
				return;
			}
			this.GeneratedActorMap.Remove(key);
			valueOrDefault.DestroySelf();
		}

		// Token: 0x0604711C RID: 291100 RVA: 0x01205D54 File Offset: 0x01203F54
		public void DynamicAddActorByIndex(JigsawIndex index, List<int> tagIds)
		{
			if (!this.GenerateFinish)
			{
				this.DynamicOperateWaitQueue.Push(new SceneItemMultiInteractionActorComponent.WaitQueueData(new SceneItemMultiInteractionActorComponent.TDynamicAddFunc(this.DynamicAddActorByIndex), index, tagIds));
				return;
			}
			string key = index.GetKey();
			List<int> list;
			if (!this.GeneratedActorTagMap.TryGetValue(key, out list))
			{
				list = new List<int>();
			}
			list.AddRange(tagIds);
			this.GeneratedActorTagMap[key] = list;
			this.GenerateActorInternal(index, this.SceneInteractionInfo.MainActor);
		}

		// Token: 0x0604711D RID: 291101 RVA: 0x01205DCB File Offset: 0x01203FCB
		public bool GetIsInit()
		{
			return this.IsInit;
		}

		// Token: 0x0604711E RID: 291102 RVA: 0x01205DD3 File Offset: 0x01203FD3
		public bool GetIsFinish()
		{
			return this.GenerateFinish;
		}

		// Token: 0x0604711F RID: 291103 RVA: 0x01205DDB File Offset: 0x01203FDB
		public void SetIsFinish(bool value)
		{
			this.GenerateFinish = value;
		}

		// Token: 0x06047120 RID: 291104 RVA: 0x01205DE4 File Offset: 0x01203FE4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemMultiInteractionActorComponent sceneItemMultiInteractionActorComponent = (SceneItemMultiInteractionActorComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemMultiInteractionActorComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (sceneItemMultiInteractionActorComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ModelConfig"))
			{
				if (sceneItemMultiInteractionActorComponent.ModelConfig == null)
				{
					this.ModelConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SModelConfig>(this.ModelConfig), "ModelConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OnGeneratedFinish"))
			{
				if (sceneItemMultiInteractionActorComponent.OnGeneratedFinish == null)
				{
					this.OnGeneratedFinish = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action>(this.OnGeneratedFinish), "OnGeneratedFinish"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsInit"))
			{
				this.IsInit = sceneItemMultiInteractionActorComponent.IsInit;
			}
			if (base.CanResetComponentProperty("GenerateFinish"))
			{
				this.GenerateFinish = sceneItemMultiInteractionActorComponent.GenerateFinish;
			}
			if (base.CanResetComponentProperty("SceneInteractionInfo"))
			{
				if (sceneItemMultiInteractionActorComponent.SceneInteractionInfo == null)
				{
					this.SceneInteractionInfo = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneInteractionLevel>(this.SceneInteractionInfo), "SceneInteractionInfo"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("GeneratedActorIndexArray"))
			{
				if (sceneItemMultiInteractionActorComponent.GeneratedActorIndexArray == null)
				{
					this.GeneratedActorIndexArray = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<JigsawIndex>>(this.GeneratedActorIndexArray), "GeneratedActorIndexArray"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CacheTagsMaps") && sceneItemMultiInteractionActorComponent.CacheTagsMaps != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, List<int>>>(this.CacheTagsMaps), "CacheTagsMaps"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("GeneratedActorIndex2LocFunc"))
			{
				if (sceneItemMultiInteractionActorComponent.GeneratedActorIndex2LocFunc == null)
				{
					this.GeneratedActorIndex2LocFunc = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Func<JigsawIndex, Vector>>(this.GeneratedActorIndex2LocFunc), "GeneratedActorIndex2LocFunc"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CacheActorMap") && sceneItemMultiInteractionActorComponent.CacheActorMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<AActor, AActor>>(this.CacheActorMap), "CacheActorMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("InteractionDataMap") && sceneItemMultiInteractionActorComponent.InteractionDataMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<AActor, SceneItemMultiInteractionActorComponent.InteractionData>>(this.InteractionDataMap), "InteractionDataMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("GeneratedActorMap") && sceneItemMultiInteractionActorComponent.GeneratedActorMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, SceneInteractionActor>>(this.GeneratedActorMap), "GeneratedActorMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("GeneratedActorTagMap"))
			{
				if (sceneItemMultiInteractionActorComponent.GeneratedActorTagMap == null)
				{
					this.GeneratedActorTagMap = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, List<int>>>(this.GeneratedActorTagMap), "GeneratedActorTagMap"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SceneInteractionEffectMap") && sceneItemMultiInteractionActorComponent.SceneInteractionEffectMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, Dictionary<int, ESceneInteractionEffect>>>(this.SceneInteractionEffectMap), "SceneInteractionEffectMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("NeedGenWhenEnable"))
			{
				this.NeedGenWhenEnable = sceneItemMultiInteractionActorComponent.NeedGenWhenEnable;
			}
			return !base.CanResetComponentProperty("DynamicOperateWaitQueue") || sceneItemMultiInteractionActorComponent.DynamicOperateWaitQueue == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Queue<SceneItemMultiInteractionActorComponent.WaitQueueData>>(this.DynamicOperateWaitQueue), "DynamicOperateWaitQueue");
		}

		// Token: 0x06047122 RID: 291106 RVA: 0x01206194 File Offset: 0x01204394
		// Note: this type is marked as 'beforefieldinit'.
		unsafe static SceneItemMultiInteractionActorComponent()
		{
			int num = 2;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int num2 = 0;
			*span[num2] = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.被控物.被控中表现"];
			num2++;
			*span[num2] = GameplayTagDefine.EGameplayTagId["关卡.Common.状态.销毁"];
			SceneItemMultiInteractionActorComponent.NeedForwardTagIds = list;
		}

		// Token: 0x040255B9 RID: 153017
		private static readonly int DefaultTagId = GameplayTagDefine.EGameplayTagId["物体.表现.初始状态"];

		// Token: 0x040255BA RID: 153018
		private const int MAX_GEN_TIME = 3;

		// Token: 0x040255BB RID: 153019
		[StaticVariableRuleIgnore]
		private static readonly List<int> NeedForwardTagIds;

		// Token: 0x040255BC RID: 153020
		[Nullable(2)]
		private SceneItemActorComponent ActorComp;

		// Token: 0x040255BD RID: 153021
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x040255BE RID: 153022
		[Nullable(2)]
		private SModelConfig ModelConfig;

		// Token: 0x040255BF RID: 153023
		[Nullable(2)]
		private Action OnGeneratedFinish;

		// Token: 0x040255C0 RID: 153024
		private bool IsInit;

		// Token: 0x040255C1 RID: 153025
		private bool GenerateFinish;

		// Token: 0x040255C2 RID: 153026
		[Nullable(2)]
		private SceneInteractionLevel SceneInteractionInfo;

		// Token: 0x040255C3 RID: 153027
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<JigsawIndex> GeneratedActorIndexArray;

		// Token: 0x040255C4 RID: 153028
		private readonly Dictionary<string, List<int>> CacheTagsMaps = new Dictionary<string, List<int>>();

		// Token: 0x040255C5 RID: 153029
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Func<JigsawIndex, Vector> GeneratedActorIndex2LocFunc;

		// Token: 0x040255C6 RID: 153030
		private readonly Dictionary<AActor, AActor> CacheActorMap = new Dictionary<AActor, AActor>();

		// Token: 0x040255C7 RID: 153031
		private readonly Dictionary<AActor, SceneItemMultiInteractionActorComponent.InteractionData> InteractionDataMap = new Dictionary<AActor, SceneItemMultiInteractionActorComponent.InteractionData>();

		// Token: 0x040255C8 RID: 153032
		private readonly Dictionary<string, SceneInteractionActor> GeneratedActorMap = new Dictionary<string, SceneInteractionActor>();

		// Token: 0x040255C9 RID: 153033
		private Dictionary<string, List<int>> GeneratedActorTagMap = new Dictionary<string, List<int>>();

		// Token: 0x040255CA RID: 153034
		private readonly Dictionary<string, Dictionary<int, ESceneInteractionEffect>> SceneInteractionEffectMap = new Dictionary<string, Dictionary<int, ESceneInteractionEffect>>();

		// Token: 0x040255CB RID: 153035
		private bool NeedGenWhenEnable;

		// Token: 0x040255CC RID: 153036
		private readonly Queue<SceneItemMultiInteractionActorComponent.WaitQueueData> DynamicOperateWaitQueue = new Queue<SceneItemMultiInteractionActorComponent.WaitQueueData>(4);

		// Token: 0x0200CED6 RID: 52950
		// (Invoke) Token: 0x06051FA9 RID: 335785
		[NullableContext(0)]
		private delegate void TDynamicAddFunc(JigsawIndex index, List<int> tagIds);

		// Token: 0x0200CED7 RID: 52951
		// (Invoke) Token: 0x06051FAD RID: 335789
		[NullableContext(0)]
		private delegate void TDynamicRemoveFunc(JigsawIndex index);

		// Token: 0x0200CED8 RID: 52952
		[NullableContext(2)]
		[Nullable(0)]
		private class InteractionData
		{
			// Token: 0x06051FB0 RID: 335792 RVA: 0x016462B1 File Offset: 0x016444B1
			public InteractionData([Nullable(new byte[]
			{
				1,
				2
			})] TMap<EKuroSceneInteractionState, SSceneInteractionitem> states, [Nullable(new byte[]
			{
				1,
				2
			})] TMap<ESceneInteractionEffect, SScenePropertyEffect> effects)
			{
				this.States = states;
				this.Effects = effects;
			}

			// Token: 0x0403E3B4 RID: 254900
			public TMap<EKuroSceneInteractionState, SSceneInteractionitem> States;

			// Token: 0x0403E3B5 RID: 254901
			public TMap<ESceneInteractionEffect, SScenePropertyEffect> Effects;
		}

		// Token: 0x0200CED9 RID: 52953
		[Nullable(0)]
		private class WaitQueueData
		{
			// Token: 0x06051FB1 RID: 335793 RVA: 0x016462C7 File Offset: 0x016444C7
			public WaitQueueData(SceneItemMultiInteractionActorComponent.TDynamicAddFunc func, JigsawIndex index, List<int> tagIds)
			{
				this.Func = func;
				this.Index = index;
				this.TagIds = tagIds;
			}

			// Token: 0x06051FB2 RID: 335794 RVA: 0x016462E9 File Offset: 0x016444E9
			public WaitQueueData(SceneItemMultiInteractionActorComponent.TDynamicRemoveFunc func, JigsawIndex index, List<int> tagIds)
			{
				this.Func = func;
				this.Index = index;
				this.TagIds = tagIds;
			}

			// Token: 0x0403E3B6 RID: 254902
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public OneOf<SceneItemMultiInteractionActorComponent.TDynamicAddFunc, SceneItemMultiInteractionActorComponent.TDynamicRemoveFunc> Func;

			// Token: 0x0403E3B7 RID: 254903
			public JigsawIndex Index;

			// Token: 0x0403E3B8 RID: 254904
			public List<int> TagIds;
		}
	}
}
