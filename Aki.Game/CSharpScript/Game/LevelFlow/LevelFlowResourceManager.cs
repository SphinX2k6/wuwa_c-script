using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.GamePlay.Physics.FauxPhysics;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelFlow.Action;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using CSharpScript.Game.NewWorld.SceneItem.RefCompController;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelFlow
{
	// Token: 0x020060EE RID: 24814
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowResourceManager : IStaticVariableResetter
	{
		// Token: 0x0603B7E1 RID: 243681 RVA: 0x010D6FAC File Offset: 0x010D51AC
		static LevelFlowResourceManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowResourceManager.CreateStaticDefaultValue), new Action(LevelFlowResourceManager.ResetStaticDefaultValue));
		}

		// Token: 0x0603B7E2 RID: 243682 RVA: 0x010D703C File Offset: 0x010D523C
		public static void HandleSequence(PlayLevelSequence inSequenceConfig)
		{
			if (string.IsNullOrEmpty(inSequenceConfig.LevelSequencePath) || inSequenceConfig.LevelSequencePath == "None")
			{
				global::Log.Instance.Error(ELogModule.Interaction, ELogAuthor.YZH, "LevelSequence", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SimpleLevelSequenceActor sequenceActor;
			LevelFlowResourceManager.SimpleSequenceActorMap.TryGetValue(inSequenceConfig.LevelSequencePath, out sequenceActor);
			if (sequenceActor == null)
			{
				LevelFlowResourceManager.LoadResourceAsyncWithQueue<ULevelSequence>(inSequenceConfig.LevelSequencePath, delegate(UObject data)
				{
					if (data == null || !data.IsValid())
					{
						global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YZH, "此LevelEvent只能配置在SceneActorRefComponent中", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
					sequenceActor = new SimpleLevelSequenceActor((ULevelSequence)data);
					sequenceActor.UpdateSettings(new bool?(inSequenceConfig.KeepUI.GetValueOrDefault()));
					LevelFlowResourceManager.SimpleSequenceActorMap[inSequenceConfig.LevelSequencePath] = sequenceActor;
					LevelFlowResourceManager.PlaySequence(sequenceActor, inSequenceConfig);
				}, ResourceSystem.EResourceLoadPriority.Default);
				return;
			}
			sequenceActor.UpdateSettings(new bool?(inSequenceConfig.KeepUI.Value));
			LevelFlowResourceManager.PlaySequence(sequenceActor, inSequenceConfig);
		}

		// Token: 0x0603B7E3 RID: 243683 RVA: 0x010D7118 File Offset: 0x010D5318
		[return: Nullable(2)]
		public static SimpleLevelSequenceActor GetLevelSequenceActor(string path)
		{
			SimpleLevelSequenceActor result;
			LevelFlowResourceManager.SimpleSequenceActorMap.TryGetValue(path, out result);
			return result;
		}

		// Token: 0x0603B7E4 RID: 243684 RVA: 0x010D7134 File Offset: 0x010D5334
		public static void ReleaseSequence(string path)
		{
			SimpleLevelSequenceActor simpleLevelSequenceActor;
			if (!LevelFlowResourceManager.SimpleSequenceActorMap.TryGetValue(path, out simpleLevelSequenceActor))
			{
				return;
			}
			simpleLevelSequenceActor.Clear();
			LevelFlowResourceManager.SimpleSequenceActorMap.Remove(path);
		}

		// Token: 0x0603B7E5 RID: 243685 RVA: 0x010D7164 File Offset: 0x010D5364
		public static void ReleaseAllSequence()
		{
			foreach (KeyValuePair<string, SimpleLevelSequenceActor> keyValuePair in LevelFlowResourceManager.SimpleSequenceActorMap)
			{
				keyValuePair.Value.Clear();
			}
			LevelFlowResourceManager.SimpleSequenceActorMap.Clear();
		}

		// Token: 0x0603B7E6 RID: 243686 RVA: 0x010D71C8 File Offset: 0x010D53C8
		private static void PlaySequence(SimpleLevelSequenceActor sequenceActor, PlayLevelSequence inSequenceConfig)
		{
			ILevelSequenceTransitionType levelSequenceTransitionType = null;
			RefCompDefine.TransitStruct tempInTransit;
			if (inSequenceConfig.Intro == null)
			{
				tempInTransit = new RefCompDefine.TransitStruct(ELevelSequenceTransition.Camera, new float?(0f), new float?(0f), new float?(0f), new bool?(false), null);
			}
			else
			{
				ILevelSequenceTransitionType intro = inSequenceConfig.Intro;
				if (intro != null && intro.Type == ELevelSequenceTransition.Camera)
				{
					levelSequenceTransitionType = (inSequenceConfig.Intro as ICameraTransition);
					ELevelSequenceTransition transitType = ELevelSequenceTransition.Camera;
					float? duration;
					if (levelSequenceTransitionType == null || levelSequenceTransitionType.Duration == null)
					{
						duration = new float?(0f);
					}
					else
					{
						float? duration2 = levelSequenceTransitionType.Duration;
						float num = 0f;
						duration = ((duration2.GetValueOrDefault() > num & duration2 != null) ? levelSequenceTransitionType.Duration : new float?(0f));
					}
					tempInTransit = new RefCompDefine.TransitStruct(transitType, duration, new float?(0f), new float?(0f), new bool?(true), null);
				}
				else
				{
					IMaskTransition maskTransition = inSequenceConfig.Intro as IMaskTransition;
					ELevelSequenceTransition transitType2 = ELevelSequenceTransition.Mask;
					float? duration3;
					if (levelSequenceTransitionType == null || levelSequenceTransitionType.Duration == null)
					{
						duration3 = new float?(0f);
					}
					else
					{
						float? duration2 = levelSequenceTransitionType.Duration;
						float num = 0f;
						duration3 = ((duration2.GetValueOrDefault() > num & duration2 != null) ? levelSequenceTransitionType.Duration : new float?(0f));
					}
					tempInTransit = new RefCompDefine.TransitStruct(transitType2, duration3, new float?((((maskTransition != null) ? maskTransition.FadeIn : null) != null) ? ((maskTransition.FadeIn.Duration > 0f) ? maskTransition.FadeIn.Duration : 1f) : 1f), new float?((((maskTransition != null) ? maskTransition.FadeOut : null) != null) ? ((maskTransition.FadeOut.Duration > 0f) ? maskTransition.FadeOut.Duration : 1f) : 1f), new bool?(true), (maskTransition != null) ? new ETransitionMask?(maskTransition.Mask) : null);
				}
			}
			RefCompDefine.TransitStruct tempOutTransit;
			if (inSequenceConfig.Outro == null)
			{
				tempOutTransit = new RefCompDefine.TransitStruct(ELevelSequenceTransition.Camera, new float?(0f), new float?(0f), new float?(0f), new bool?(false), null);
			}
			else
			{
				ILevelSequenceTransitionType outro = inSequenceConfig.Outro;
				if (outro != null && outro.Type == ELevelSequenceTransition.Camera)
				{
					levelSequenceTransitionType = (inSequenceConfig.Outro as ICameraTransition);
					ELevelSequenceTransition transitType3 = ELevelSequenceTransition.Camera;
					float? duration4;
					if (levelSequenceTransitionType == null || levelSequenceTransitionType.Duration == null)
					{
						duration4 = new float?(0f);
					}
					else
					{
						float? duration2 = levelSequenceTransitionType.Duration;
						float num = 0f;
						duration4 = ((duration2.GetValueOrDefault() > num & duration2 != null) ? levelSequenceTransitionType.Duration : new float?(0f));
					}
					tempOutTransit = new RefCompDefine.TransitStruct(transitType3, duration4, new float?(0f), new float?(0f), new bool?(true), null);
				}
				else
				{
					IMaskTransition maskTransition2 = inSequenceConfig.Outro as IMaskTransition;
					ELevelSequenceTransition transitType4 = ELevelSequenceTransition.Mask;
					float? duration5;
					if (levelSequenceTransitionType == null || levelSequenceTransitionType.Duration == null)
					{
						duration5 = new float?(0f);
					}
					else
					{
						float? duration2 = levelSequenceTransitionType.Duration;
						float num = 0f;
						duration5 = ((duration2.GetValueOrDefault() > num & duration2 != null) ? levelSequenceTransitionType.Duration : new float?(0f));
					}
					tempOutTransit = new RefCompDefine.TransitStruct(transitType4, duration5, new float?((((maskTransition2 != null) ? maskTransition2.FadeIn : null) != null) ? ((maskTransition2.FadeIn.Duration > 0f) ? maskTransition2.FadeIn.Duration : 1f) : 1f), new float?((((maskTransition2 != null) ? maskTransition2.FadeOut : null) != null) ? ((maskTransition2.FadeOut.Duration > 0f) ? maskTransition2.FadeOut.Duration : 1f) : 1f), new bool?(true), (maskTransition2 != null) ? new ETransitionMask?(maskTransition2.Mask) : null);
				}
			}
			float? playRateAbs = new float?(Math.Abs(inSequenceConfig.Rate.GetValueOrDefault(1f)));
			EKuroEasingFuncType easeType = EKuroEasingFuncType.KEF_Linear;
			IEaseData rateEase = inSequenceConfig.RateEase;
			RefCompDefine.PlayRateStruct playRateStruct = new RefCompDefine.PlayRateStruct(playRateAbs, easeType, (rateEase != null) ? new float?(rateEase.Duration) : null, new float?(0f));
			IEaseData rateEase2 = inSequenceConfig.RateEase;
			EEaseType? eeaseType = (rateEase2 != null) ? new EEaseType?(rateEase2.Type) : null;
			if (eeaseType != null)
			{
				switch (eeaseType.GetValueOrDefault())
				{
				case EEaseType.Transient:
					playRateStruct.EaseType = EKuroEasingFuncType.KEF_Linear;
					playRateStruct.EaseDuration = new float?(0f);
					goto IL_4F7;
				case EEaseType.InOutCubic:
					playRateStruct.EaseType = EKuroEasingFuncType.KEF_EaseInOut;
					playRateStruct.EaseExponent = new float?((float)3);
					goto IL_4F7;
				case EEaseType.OutSine:
					playRateStruct.EaseType = EKuroEasingFuncType.KEF_SinOut;
					goto IL_4F7;
				case EEaseType.OutQuart:
					playRateStruct.EaseType = EKuroEasingFuncType.KEF_EaseOut;
					playRateStruct.EaseExponent = new float?((float)4);
					goto IL_4F7;
				}
			}
			playRateStruct.EaseType = EKuroEasingFuncType.KEF_Linear;
			IL_4F7:
			switch (inSequenceConfig.PlayMode.Value)
			{
			case TPlayMode.instant:
				sequenceActor.PlayToMarkByCheckWay(inSequenceConfig.Mark, tempInTransit, tempOutTransit, playRateStruct, false);
				return;
			case TPlayMode.loop:
				if (inSequenceConfig.LoopRange != null)
				{
					sequenceActor.PlayLoopBetweenMarks(inSequenceConfig.LoopRange, inSequenceConfig.Rate.GetValueOrDefault(1f) < 0f, tempInTransit, tempOutTransit, playRateStruct, false);
					return;
				}
				sequenceActor.PlayLoop(inSequenceConfig.Rate.GetValueOrDefault(1f) < 0f, -1, tempInTransit, tempOutTransit, playRateStruct);
				return;
			case TPlayMode.shortestPath:
				sequenceActor.PlayToMark(inSequenceConfig.Mark, tempInTransit, tempOutTransit, playRateStruct, true);
				return;
			}
			sequenceActor.PlayToMark(inSequenceConfig.Mark, tempInTransit, tempOutTransit, playRateStruct, false);
		}

		// Token: 0x0603B7E7 RID: 243687 RVA: 0x010D7784 File Offset: 0x010D5984
		private static int LoadResourceAsyncWithQueue<[Nullable(0)] T>(string path, [Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject> callback, ResourceSystem.EResourceLoadPriority priority = ResourceSystem.EResourceLoadPriority.Default) where T : UObject
		{
			if (LevelFlowResourceManager.ResourceLoadCallbackHandleQueue == null)
			{
				LevelFlowResourceManager.ResourceLoadCallbackHandleQueue = new Queue<ResourceLoadCallbackHandle>(4);
			}
			ResourceLoadCallbackHandle handle = new ResourceLoadCallbackHandle(path, callback);
			LevelFlowResourceManager.ResourceLoadCallbackHandleQueue.Push(handle);
			handle.ResourceSystemId = ResourceSystem.Instance.LoadAsync<T>(path, delegate([Nullable(2)] T asset, string _)
			{
				LevelFlowResourceManager.OnResourceLoadAsyncCallback(handle, asset);
			}, priority, "js_undefined");
			return handle.ResourceSystemId;
		}

		// Token: 0x0603B7E8 RID: 243688 RVA: 0x010D77FC File Offset: 0x010D59FC
		private static void OnResourceLoadAsyncCallback(ResourceLoadCallbackHandle handle, [Nullable(2)] UObject asset)
		{
			handle.Asset = asset;
			handle.LoadAsyncFinished = true;
			while (LevelFlowResourceManager.ResourceLoadCallbackHandleQueue != null && LevelFlowResourceManager.ResourceLoadCallbackHandleQueue.Size > 0)
			{
				ResourceLoadCallbackHandle front = LevelFlowResourceManager.ResourceLoadCallbackHandleQueue.Front;
				if (front == null || !front.LoadAsyncFinished)
				{
					break;
				}
				ResourceLoadCallbackHandle resourceLoadCallbackHandle = LevelFlowResourceManager.ResourceLoadCallbackHandleQueue.Pop();
				if (resourceLoadCallbackHandle != null)
				{
					Action<UObject, string> callback = resourceLoadCallbackHandle.Callback;
					if (callback != null)
					{
						callback(resourceLoadCallbackHandle.Asset, resourceLoadCallbackHandle.Path);
					}
				}
			}
		}

		// Token: 0x0603B7E9 RID: 243689 RVA: 0x010D7870 File Offset: 0x010D5A70
		private static void SequenceDilationChange(float timeDilation)
		{
			foreach (KeyValuePair<string, SimpleLevelSequenceActor> keyValuePair in LevelFlowResourceManager.SimpleSequenceActorMap)
			{
				keyValuePair.Value.SetTimeDilation(timeDilation);
			}
		}

		// Token: 0x0603B7EA RID: 243690 RVA: 0x010D78C8 File Offset: 0x010D5AC8
		public static void ShowHookEffect(int entityId, string targetTag, int cueId)
		{
			if (LevelFlowResourceManager.HookCueMap.ContainsKey(entityId))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				string message = "HookCue已经存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(targetTag) ?? FName.NAME_None, ECollectActorType.Default);
			if (actorWithTag == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.LevelFlow;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "Actor加载超时或已被移除";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("TargetTag", targetTag);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			GameplayCue? config = ConfigGameplayCueById.GetConfig((long)cueId, true);
			if (config == null)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.LevelFlow;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "Invalid GamePlayCue Id";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("CueId", cueId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById == null)
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.LevelFlow;
				ELogAuthor author4 = ELogAuthor.BB;
				string message4 = "Entity加载超时或已被移除";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("EntityId", entityId);
				instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return;
			}
			CreatureDataComponent component = entityById.Entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				global::Log instance5 = global::Log.Instance;
				ELogModule module5 = ELogModule.LevelFlow;
				ELogAuthor author5 = ELogAuthor.BB;
				string message5 = "Entity没有ActorComponent";
				ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("EntityId", entityId);
				instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
				return;
			}
			EEntityType entityType = component.GetEntityType();
			if (entityType != EEntityType.Player && entityType != EEntityType.Vehicle)
			{
				global::Log instance6 = global::Log.Instance;
				ELogModule module6 = ELogModule.LevelFlow;
				ELogAuthor author6 = ELogAuthor.BB;
				string message6 = "Entity不是Character或Vehicle";
				ValueTuple<string, object> valueTuple6 = new ValueTuple<string, object>("EntityId", entityId);
				instance6.Error(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple6));
				return;
			}
			GameplayCueHookCommonItem value;
			if (entityType == EEntityType.Vehicle)
			{
				value = GameplayCueHookCommonItem.Spawn(entityById.Entity.GetComponent<VehicleActorComponent>().Actor, FNameUtil.GetDynamicFName(config.Value.Socket) ?? FName.NAME_None, actorWithTag.D_K2_GetActorLocation(), config.Value.Resources(), true);
			}
			else
			{
				value = GameplayCueHookCommonItem.Spawn(entityById.Entity.GetComponent<CharacterActorComponent>().Actor, FNameUtil.GetDynamicFName(config.Value.Socket) ?? FName.NAME_None, actorWithTag.D_K2_GetActorLocation(), config.Value.Resources(), true);
			}
			LevelFlowResourceManager.HookCueMap.Add(entityId, value);
			LevelFlowResourceManager.HookTargetActorMap.Add(entityId, actorWithTag);
		}

		// Token: 0x0603B7EB RID: 243691 RVA: 0x010D7B44 File Offset: 0x010D5D44
		public static void HideHookEffect(int entityId)
		{
			GameplayCueHookCommonItem gameplayCueHookCommonItem;
			if (!LevelFlowResourceManager.HookCueMap.TryGetValue(entityId, out gameplayCueHookCommonItem))
			{
				return;
			}
			gameplayCueHookCommonItem.Destroy();
			LevelFlowResourceManager.HookCueMap.Remove(entityId);
			LevelFlowResourceManager.HookTargetActorMap.Remove(entityId);
		}

		// Token: 0x0603B7EC RID: 243692 RVA: 0x010D7B80 File Offset: 0x010D5D80
		public static void TickHookEffect(float deltaTime)
		{
			foreach (KeyValuePair<int, GameplayCueHookCommonItem> keyValuePair in LevelFlowResourceManager.HookCueMap)
			{
				AActor aactor;
				if (LevelFlowResourceManager.HookTargetActorMap.TryGetValue(keyValuePair.Key, out aactor) && aactor != null && aactor.IsValid())
				{
					keyValuePair.Value.Tick(aactor.D_K2_GetActorLocation());
				}
			}
		}

		// Token: 0x0603B7ED RID: 243693 RVA: 0x010D7C00 File Offset: 0x010D5E00
		private static void ReleaseHookEffect()
		{
			foreach (KeyValuePair<int, GameplayCueHookCommonItem> keyValuePair in LevelFlowResourceManager.HookCueMap)
			{
				keyValuePair.Value.Destroy();
			}
			LevelFlowResourceManager.HookCueMap.Clear();
			LevelFlowResourceManager.HookTargetActorMap.Clear();
		}

		// Token: 0x0603B7EE RID: 243694 RVA: 0x010D7C6C File Offset: 0x010D5E6C
		public static UniTask LoadDestructibleActor(int key, ActionSpawnDestructibleActorWithTrackCapability param)
		{
			LevelFlowResourceManager.<LoadDestructibleActor>d__25 <LoadDestructibleActor>d__;
			<LoadDestructibleActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadDestructibleActor>d__.key = key;
			<LoadDestructibleActor>d__.param = param;
			<LoadDestructibleActor>d__.<>1__state = -1;
			<LoadDestructibleActor>d__.<>t__builder.Start<LevelFlowResourceManager.<LoadDestructibleActor>d__25>(ref <LoadDestructibleActor>d__);
			return <LoadDestructibleActor>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7EF RID: 243695 RVA: 0x010D7CB8 File Offset: 0x010D5EB8
		public static void ReleaseDestructibleActor(int key)
		{
			AKuroDestructibleActor akuroDestructibleActor;
			if (LevelFlowResourceManager.DestructibleActorMap.TryGetValue(key, out akuroDestructibleActor) && akuroDestructibleActor != null && akuroDestructibleActor.IsValid())
			{
				akuroDestructibleActor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				ActorSystem.Instance.Put("LevelFlowReleaseDestructibleActor", akuroDestructibleActor, null);
			}
			LevelFlowResourceManager.DestructibleActorMap.Remove(key);
			BP_KuroTrackTargetWhileRotate_C bp_KuroTrackTargetWhileRotate_C;
			if (LevelFlowResourceManager.DestructibleRotateActorMap.TryGetValue(key, out bp_KuroTrackTargetWhileRotate_C) && bp_KuroTrackTargetWhileRotate_C != null && bp_KuroTrackTargetWhileRotate_C.IsValid())
			{
				ActorSystem.Instance.Put("LevelFlowReleaseDestructibleRotateActor", bp_KuroTrackTargetWhileRotate_C, null);
			}
			LevelFlowResourceManager.DestructibleRotateActorMap.Remove(key);
			LevelFlowResourceManager.ClearEffect(key);
		}

		// Token: 0x0603B7F0 RID: 243696 RVA: 0x010D7D44 File Offset: 0x010D5F44
		private static void ReleaseAllDestructibleActor()
		{
			foreach (int key in new List<int>(LevelFlowResourceManager.DestructibleActorMap.Keys))
			{
				LevelFlowResourceManager.ReleaseDestructibleActor(key);
			}
		}

		// Token: 0x0603B7F1 RID: 243697 RVA: 0x010D7DA0 File Offset: 0x010D5FA0
		private static UniTask LoadTypeAsync()
		{
			LevelFlowResourceManager.<LoadTypeAsync>d__28 <LoadTypeAsync>d__;
			<LoadTypeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTypeAsync>d__.<>1__state = -1;
			<LoadTypeAsync>d__.<>t__builder.Start<LevelFlowResourceManager.<LoadTypeAsync>d__28>(ref <LoadTypeAsync>d__);
			return <LoadTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7F2 RID: 243698 RVA: 0x010D7DDC File Offset: 0x010D5FDC
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<UKuroDestructibleAsset> LoadKuroDestructibleAsset(string path)
		{
			LevelFlowResourceManager.<LoadKuroDestructibleAsset>d__29 <LoadKuroDestructibleAsset>d__;
			<LoadKuroDestructibleAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder<UKuroDestructibleAsset>.Create();
			<LoadKuroDestructibleAsset>d__.path = path;
			<LoadKuroDestructibleAsset>d__.<>1__state = -1;
			<LoadKuroDestructibleAsset>d__.<>t__builder.Start<LevelFlowResourceManager.<LoadKuroDestructibleAsset>d__29>(ref <LoadKuroDestructibleAsset>d__);
			return <LoadKuroDestructibleAsset>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7F3 RID: 243699 RVA: 0x010D7E20 File Offset: 0x010D6020
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<UKuroDestructibleDestructionAsset> LoadKuroDestructibleDestructionAsset(string path)
		{
			LevelFlowResourceManager.<LoadKuroDestructibleDestructionAsset>d__30 <LoadKuroDestructibleDestructionAsset>d__;
			<LoadKuroDestructibleDestructionAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder<UKuroDestructibleDestructionAsset>.Create();
			<LoadKuroDestructibleDestructionAsset>d__.path = path;
			<LoadKuroDestructibleDestructionAsset>d__.<>1__state = -1;
			<LoadKuroDestructibleDestructionAsset>d__.<>t__builder.Start<LevelFlowResourceManager.<LoadKuroDestructibleDestructionAsset>d__30>(ref <LoadKuroDestructibleDestructionAsset>d__);
			return <LoadKuroDestructibleDestructionAsset>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7F4 RID: 243700 RVA: 0x010D7E64 File Offset: 0x010D6064
		private static int SpawnEffect(AActor actor, FKuroDestructibleEffect effectData)
		{
			EffectSystem instance = EffectSystem.Instance;
			FTransformDouble? ftransformDouble = new FTransformDouble?(actor.D_GetTransform());
			int num = instance.SpawnEffect(actor, ftransformDouble, effectData.EffectModelPath.ToString(), "LevelFlowResourceManager.SpawnEffect", null, global::EEffectType.Scene, null, null, null, false, false);
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
			if (effectData.AttachLocation || effectData.AttachRotation || effectData.AttachScale)
			{
				OneOf<KuroEffectActorHandle, AActor> self = effectActor;
				FName? fname = new FName?(effectData.Socket);
				self.K2_AttachToActor(actor, fname, effectData.AttachLocation ? EAttachmentRule.SnapToTarget : EAttachmentRule.KeepWorld, effectData.AttachRotation ? EAttachmentRule.SnapToTarget : EAttachmentRule.KeepWorld, effectData.AttachScale ? EAttachmentRule.SnapToTarget : EAttachmentRule.KeepWorld, false);
			}
			FHitResult fhitResult = null;
			OneOf<KuroEffectActorHandle, AActor> self2 = effectActor;
			FTransform offset = effectData.Offset;
			self2.K2_AddActorLocalTransform(offset, false, ref fhitResult, false);
			return num;
		}

		// Token: 0x0603B7F5 RID: 243701 RVA: 0x010D7F24 File Offset: 0x010D6124
		private static void ClearEffect(int key)
		{
			HashSet<int> hashSet;
			if (LevelFlowResourceManager.DestructibleEffectIds.TryGetValue(key, out hashSet))
			{
				foreach (int handle in hashSet)
				{
					EffectSystem.Instance.StopEffectById(handle, "LevelFlowResourceManager.PlayEffectWhenStartDestruction", true, null);
				}
			}
		}

		// Token: 0x0603B7F6 RID: 243702 RVA: 0x010D7F98 File Offset: 0x010D6198
		private static void SpawnThenCacheEffectId(AActor actor, FKuroDestructibleEffect effectData, int key)
		{
			if (!actor.IsValid())
			{
				return;
			}
			int item = LevelFlowResourceManager.SpawnEffect(actor, effectData);
			if (!LevelFlowResourceManager.DestructibleEffectIds.ContainsKey(key))
			{
				LevelFlowResourceManager.DestructibleEffectIds.Add(key, new HashSet<int>());
			}
			LevelFlowResourceManager.DestructibleEffectIds[key].Add(item);
		}

		// Token: 0x0603B7F7 RID: 243703 RVA: 0x010D7FE8 File Offset: 0x010D61E8
		[return: Nullable(2)]
		private static AKuroDestructibleActor SpawnKuroDestructibleActor(int key, FTransformDouble spawnTransform, UKuroDestructibleAsset kuroDestructibleAsset, UKuroDestructibleDestructionAsset kuroDestructibleDestructionAsset)
		{
			AKuroDestructibleActor kuroDestructibleActor = UGameplayStatics.D_BeginDeferredActorSpawnFromClass(Global.BaseCharacter, AKuroDestructibleActor.StaticClass(), spawnTransform, ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn, null) as AKuroDestructibleActor;
			AKuroDestructibleActor kuroDestructibleActor2 = kuroDestructibleActor;
			if (kuroDestructibleActor2 == null || !kuroDestructibleActor2.IsValid())
			{
				return null;
			}
			kuroDestructibleActor.PlayEffectPostInitialized.Bind(delegate(FKuroDestructibleEffect effectData)
			{
				LevelFlowResourceManager.SpawnThenCacheEffectId(kuroDestructibleActor, effectData, key);
			});
			kuroDestructibleActor.KuroDestructibleAsset = kuroDestructibleAsset;
			kuroDestructibleActor.KuroDestructibleDestructionAsset = kuroDestructibleDestructionAsset;
			UGameplayStatics.D_FinishSpawningActor(kuroDestructibleActor, spawnTransform);
			return kuroDestructibleActor;
		}

		// Token: 0x0603B7F8 RID: 243704 RVA: 0x010D8088 File Offset: 0x010D6288
		private static void OnStopTrackTarget(int key, bool hitPlayer, int hitBuff, int revertMaxHp)
		{
			AKuroDestructibleActor akuroDestructibleActor;
			if (LevelFlowResourceManager.DestructibleActorMap.TryGetValue(key, out akuroDestructibleActor) && akuroDestructibleActor.IsValid())
			{
				akuroDestructibleActor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				AudioSystem.Instance.PostEvent("play_interact_seq_luxin_fireball_explode", akuroDestructibleActor, null);
			}
			BP_KuroTrackTargetWhileRotate_C bp_KuroTrackTargetWhileRotate_C;
			if (LevelFlowResourceManager.DestructibleRotateActorMap.TryGetValue(key, out bp_KuroTrackTargetWhileRotate_C) && bp_KuroTrackTargetWhileRotate_C.IsValid())
			{
				ActorSystem.Instance.Put("LevelFlowReleaseDestructibleRotateActor", bp_KuroTrackTargetWhileRotate_C, null);
			}
			LevelFlowResourceManager.DestructibleRotateActorMap.Remove(key);
			if (!hitPlayer)
			{
				return;
			}
			if (hitBuff <= 0 || revertMaxHp <= 0)
			{
				return;
			}
			BaseAttributeComponent component = Global.BaseCharacter.CharacterActorComponent.Entity.GetComponent<BaseAttributeComponent>();
			float? num = (component != null) ? new float?(component.GetCurrentValue(EAttributeType.Life)) : null;
			if (num == null)
			{
				return;
			}
			float? num2 = num;
			float num3 = (float)revertMaxHp;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				LevelFlowModel.Instance.PushDynamicAction(new LevelFlowAddBuffAction().Init(Global.BaseCharacter.CharacterActorComponent.Entity.Id, new List<long>
				{
					(long)hitBuff
				}));
			}
		}

		// Token: 0x0603B7F9 RID: 243705 RVA: 0x010D819C File Offset: 0x010D639C
		public static void OnTick(float deltaTime)
		{
			LevelFlowResourceManager.TickHookEffect(deltaTime);
		}

		// Token: 0x0603B7FA RID: 243706 RVA: 0x010D81A4 File Offset: 0x010D63A4
		public static void OnTimeDilationChange()
		{
			LevelFlowResourceManager.SequenceDilationChange(Time.Instance.TimeDilation);
		}

		// Token: 0x0603B7FB RID: 243707 RVA: 0x010D81B5 File Offset: 0x010D63B5
		public static void Release()
		{
			LevelFlowResourceManager.ReleaseAllSequence();
			LevelFlowResourceManager.ReleaseHookEffect();
			LevelFlowResourceManager.ReleaseAllDestructibleActor();
		}

		// Token: 0x0603B7FC RID: 243708 RVA: 0x010D81C8 File Offset: 0x010D63C8
		public static void CreateStaticDefaultValue()
		{
			LevelFlowResourceManager.SimpleSequenceActorMap = new Dictionary<string, SimpleLevelSequenceActor>();
			LevelFlowResourceManager.ResourceLoadCallbackHandleQueue = new Queue<ResourceLoadCallbackHandle>(4);
			LevelFlowResourceManager.DestructibleRotateActorMap = new Dictionary<int, BP_KuroTrackTargetWhileRotate_C>();
			LevelFlowResourceManager.DestructibleEffectIds = new Dictionary<int, HashSet<int>>();
			LevelFlowResourceManager.DestructibleActorMap = new Dictionary<int, AKuroDestructibleActor>();
			LevelFlowResourceManager.HookCueMap = new Dictionary<int, GameplayCueHookCommonItem>();
			LevelFlowResourceManager.HookTargetActorMap = new Dictionary<int, AActor>();
		}

		// Token: 0x0603B7FD RID: 243709 RVA: 0x010D821C File Offset: 0x010D641C
		public static void ResetStaticDefaultValue()
		{
			LevelFlowResourceManager.SimpleSequenceActorMap = null;
			LevelFlowResourceManager.ResourceLoadCallbackHandleQueue = null;
			LevelFlowResourceManager.DestructibleRotateActorMap = null;
			LevelFlowResourceManager.DestructibleEffectIds = null;
			LevelFlowResourceManager.DestructibleActorMap = null;
			LevelFlowResourceManager.HookCueMap = null;
			LevelFlowResourceManager.HookTargetActorMap = null;
		}

		// Token: 0x0401F5F3 RID: 128499
		private const string AUTO_AIM_TAG = "关卡.Common.表现.摩托车浮游炮.辅助瞄准";

		// Token: 0x0401F5F4 RID: 128500
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, SimpleLevelSequenceActor> SimpleSequenceActorMap;

		// Token: 0x0401F5F5 RID: 128501
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Queue<ResourceLoadCallbackHandle> ResourceLoadCallbackHandleQueue;

		// Token: 0x0401F5F6 RID: 128502
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<int, GameplayCueHookCommonItem> HookCueMap;

		// Token: 0x0401F5F7 RID: 128503
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<int, AActor> HookTargetActorMap;

		// Token: 0x0401F5F8 RID: 128504
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<int, BP_KuroTrackTargetWhileRotate_C> DestructibleRotateActorMap;

		// Token: 0x0401F5F9 RID: 128505
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<int, HashSet<int>> DestructibleEffectIds;

		// Token: 0x0401F5FA RID: 128506
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<int, AKuroDestructibleActor> DestructibleActorMap;

		// Token: 0x0401F5FB RID: 128507
		[StaticVariableRuleIgnore]
		private static readonly FKuroDestructibleEffect stopTrackTargetEffectParam = new FKuroDestructibleEffect
		{
			AttachLocation = false,
			AttachRotation = false,
			AttachScale = false,
			DetachOnEnd = false,
			EffectModelPath = (FNameUtil.GetDynamicFName("/Game/Aki/Effect/DataAsset/Niagara/Scene/3_0/3_0LuXin/DA_Fx_Sc1_LuXin_ExploderSmoke_02.DA_Fx_Sc1_LuXin_ExploderSmoke_02") ?? FName.NAME_None),
			Offset = new FTransform(),
			Socket = FNameUtil.EMPTY
		};

		// Token: 0x0401F5FC RID: 128508
		private const string DEFAULT_AK_EVENT_NAME = "play_interact_seq_luxin_fireball_explode";

		// Token: 0x0401F5FD RID: 128509
		public const string STONE_TRAIL_EFFECT_PATH = "/Game/Aki/Effect/DataAsset/Niagara/Scene/3_0/3_0LuXin/DA_FX_SC1_LuXin_YunShiTrail_02.DA_FX_SC1_LuXin_YunShiTrail_02";

		// Token: 0x0401F5FE RID: 128510
		public const string EXPLOSION_EFFECT_PATH = "/Game/Aki/Effect/DataAsset/Niagara/Scene/3_0/3_0LuXin/DA_Fx_Sc1_LuXin_ExploderSmoke_03.DA_Fx_Sc1_LuXin_ExploderSmoke_03";
	}
}
