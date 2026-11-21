using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.FollowShooter;
using AkiClient.Game.Aki.Data.Fight.Struct;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006360 RID: 25440
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowShooterDrone
	{
		// Token: 0x0603DA7F RID: 252543 RVA: 0x011DDF44 File Offset: 0x011DC144
		private static void ExecuteExecutor(TFollowShooterExecutor executor, Entity entity, FName targetName, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
		{
			BaseActorComponent baseActorComponent = entity.CheckGetComponent<BaseActorComponent>();
			AActor aactor = (baseActorComponent != null) ? baseActorComponent.Owner : null;
			if (aactor == null)
			{
				return;
			}
			TArray<UActorComponent> componentsByTag = aactor.GetComponentsByTag(USceneComponent.StaticClass(), targetName);
			if (componentsByTag == null)
			{
				return;
			}
			foreach (UActorComponent uactorComponent in componentsByTag)
			{
				USceneComponent usceneComponent = (USceneComponent)uactorComponent;
				if (usceneComponent.IsValid())
				{
					executor(entity, usceneComponent, lockOnFollowShooter, lockOnFollowShooterAutoAim);
				}
			}
		}

		// Token: 0x0603DA80 RID: 252544 RVA: 0x011DDFD0 File Offset: 0x011DC1D0
		private static void TryShoot(Entity entity, AActor target, float angleDiff, Dictionary<string, double> lastAutoShootTime, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
		{
			FName shouldAimAtLockOnTargetName = lockOnFollowShooterAutoAim.ShouldAimAtLockOnTargetName;
			bool flag = false;
			EntityHandle entityByActor = ActorUtils.GetEntityByActor(target, false);
			if (entityByActor != null && entityByActor.Valid)
			{
				WorldEntity entity2 = entityByActor.Entity;
				if (entity2 != null && entity2.Valid)
				{
					BaseTagComponent baseTagComponent = entityByActor.Entity.CheckGetComponent<BaseTagComponent>();
					if (baseTagComponent == null)
					{
						return;
					}
					foreach (FGameplayTag tag in lockOnFollowShooter.AutoShootGameplayTagContainer.GameplayTags)
					{
						if (baseTagComponent.HasTag(tag.TagId()))
						{
							flag = true;
							break;
						}
					}
				}
			}
			if (!flag)
			{
				return;
			}
			BaseSkillComponent component = entity.GetComponent<BaseSkillComponent>();
			if (component == null)
			{
				return;
			}
			string key = shouldAimAtLockOnTargetName.ToString();
			if (!lastAutoShootTime.ContainsKey(key))
			{
				lastAutoShootTime.Add(key, -1.0);
			}
			if (angleDiff <= lockOnFollowShooterAutoAim.AutoShootAngle && Time.Instance.Now - lastAutoShootTime[key] >= (double)lockOnFollowShooterAutoAim.AutoShootGapTime)
			{
				lastAutoShootTime[key] = Time.Instance.Now;
				component.BeginSkillAsync(lockOnFollowShooterAutoAim.AutoShootSkillId, null).Forget<bool>();
			}
		}

		// Token: 0x0603DA81 RID: 252545 RVA: 0x011DE100 File Offset: 0x011DC300
		public static bool ShouldUpdateRotationToAimAtLockOnTarget(SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim, object actorOrEntityId)
		{
			EntityHandle entityHandle = null;
			if (actorOrEntityId is int)
			{
				entityHandle = CreatureModel.Instance.GetEntityById((int)actorOrEntityId);
			}
			else if (actorOrEntityId is AActor)
			{
				entityHandle = ActorUtils.GetEntityByActor((AActor)actorOrEntityId, false);
			}
			BaseTagComponent baseTagComponent;
			if (entityHandle == null)
			{
				baseTagComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				baseTagComponent = ((entity != null) ? entity.CheckGetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 == null)
			{
				return false;
			}
			for (int i = 0; i < lockOnFollowShooterAutoAim.StopUpdateRotationWhileHasTags.GameplayTags.Num(); i++)
			{
				FGameplayTag tag = lockOnFollowShooterAutoAim.StopUpdateRotationWhileHasTags.GameplayTags.Get(i);
				if (baseTagComponent2.HasTag(tag.TagId()))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603DA82 RID: 252546 RVA: 0x011DE19C File Offset: 0x011DC39C
		private static void UpdateTransformByStrategy(float deltaTime, FollowShooterAimTarget aimTarget, [Nullable(2)] AActor targetForShoot, [Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<string, double> lastAutoShootTime, Entity entity, USceneComponent sceneComponent, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
		{
			if (!FollowShooterDrone.ShouldUpdateRotationToAimAtLockOnTarget(lockOnFollowShooterAutoAim, entity.Id))
			{
				return;
			}
			IFollowShooterAttachStrategy followShooterAttachStrategy = FollowShooterAttachStrategies.getFollowShooterAttachStrategy(FollowShooterAttachStrategies.getSceneComponentAttachStrategy(sceneComponent));
			IUpdateRotationParams @params = new UpdateRotationParams
			{
				DeltaTimeMs = deltaTime,
				RotationInterpSpeed = lockOnFollowShooterAutoAim.RotationInterpSpeed,
				RotateOffset = lockOnFollowShooterAutoAim.RotateOffset,
				AimTarget = aimTarget
			};
			float? num = followShooterAttachStrategy.UpdateTransform(sceneComponent, @params);
			if (num != null && targetForShoot != null && lastAutoShootTime != null)
			{
				FollowShooterDrone.TryShoot(entity, targetForShoot, num.Value, lastAutoShootTime, lockOnFollowShooter, lockOnFollowShooterAutoAim);
			}
		}

		// Token: 0x0603DA83 RID: 252547 RVA: 0x011DE228 File Offset: 0x011DC428
		private unsafe static void AllOwnerSceneComponentExecute(Entity entity, BP_FollowShooterConfig_C followShooterConfig, TFollowShooterExecutor executor)
		{
			if (followShooterConfig == null || !followShooterConfig.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "AllOwnerSceneComponentExecute 参数错误";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FollowShooterConfig", followShooterConfig);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Executor", executor);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			foreach (SLockOnFollowShooterAutoAim slockOnFollowShooterAutoAim in followShooterConfig.LockOnConfig.ArrayAutoAimConfig)
			{
				FollowShooterDrone.ExecuteExecutor(executor, entity, slockOnFollowShooterAutoAim.ShouldAimAtLockOnTargetName, followShooterConfig.LockOnConfig, slockOnFollowShooterAutoAim);
			}
		}

		// Token: 0x0603DA84 RID: 252548 RVA: 0x011DE314 File Offset: 0x011DC514
		public unsafe static void SpecificOwnerSceneComponentExecute(Entity entity, BP_FollowShooterConfig_C followShooterConfig, FName targetName, TFollowShooterExecutor executor)
		{
			if (followShooterConfig == null || !entity.Valid || FNameUtil.IsNothing(targetName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "SpecificOwnerSceneComponentExecute 参数错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FollowShooterConfig", followShooterConfig);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", entity.Id);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			foreach (SLockOnFollowShooterAutoAim slockOnFollowShooterAutoAim in followShooterConfig.LockOnConfig.ArrayAutoAimConfig)
			{
				if (!(targetName != slockOnFollowShooterAutoAim.ShouldAimAtLockOnTargetName))
				{
					FollowShooterDrone.ExecuteExecutor(executor, entity, targetName, followShooterConfig.LockOnConfig, slockOnFollowShooterAutoAim);
				}
			}
		}

		// Token: 0x0603DA85 RID: 252549 RVA: 0x011DE3F4 File Offset: 0x011DC5F4
		public unsafe static void AttachToByConfig(USceneComponent targetComponent, int tagId, Entity entity, USceneComponent sceneComponent, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
		{
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(tagId);
			if (gameplayTagById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "AttachToByConfig 参数错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TagId", tagId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			SLockOnFollowShooterAttachmentRule slockOnFollowShooterAttachmentRule = lockOnFollowShooterAutoAim.MapAttachToFollowingWhileHasTag.Get(gameplayTagById.Value);
			if (slockOnFollowShooterAttachmentRule == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Character;
				ELogAuthor author2 = ELogAuthor.XDW;
				string message2 = "AttachToByConfig 参数错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TagId", tagId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AttachmentRule", slockOnFollowShooterAttachmentRule);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			foreach (IFollowShooterAttachStrategy followShooterAttachStrategy in FollowShooterAttachStrategies.getAllFollowShooterAttachStrategies())
			{
				followShooterAttachStrategy.OnDetach(sceneComponent, slockOnFollowShooterAttachmentRule);
			}
			FollowShooterAttachStrategies.getFollowShooterAttachStrategy(slockOnFollowShooterAttachmentRule.AttachStrategy).OnAttach(sceneComponent, slockOnFollowShooterAttachmentRule, targetComponent);
			FollowShooterAttachStrategies.setSceneComponentAttachStrategy(sceneComponent, slockOnFollowShooterAttachmentRule.AttachStrategy);
		}

		// Token: 0x0603DA86 RID: 252550 RVA: 0x011DE524 File Offset: 0x011DC724
		public static void ClearStrategyStatesForOwner(Entity entity, BP_FollowShooterConfig_C followShooterConfig)
		{
			TFollowShooterExecutor executor;
			if ((executor = FollowShooterDrone.<>O.<0>__ClearStrategyStateExecutor) == null)
			{
				executor = (FollowShooterDrone.<>O.<0>__ClearStrategyStateExecutor = new TFollowShooterExecutor(FollowShooterDrone.ClearStrategyStateExecutor));
			}
			FollowShooterDrone.AllOwnerSceneComponentExecute(entity, followShooterConfig, executor);
		}

		// Token: 0x0603DA87 RID: 252551 RVA: 0x011DE548 File Offset: 0x011DC748
		private static void ClearStrategyStateExecutor(Entity entity, USceneComponent sceneComponent, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
		{
			FollowShooterAttachStrategies.clearFollowShooterAttachStrategiesStateForSceneComponent(sceneComponent);
		}

		// Token: 0x0603DA88 RID: 252552 RVA: 0x011DE550 File Offset: 0x011DC750
		public static void SetHiddenInGame(bool newHidden, Entity entity, USceneComponent sceneComponent, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
		{
			sceneComponent.SetHiddenInGame(newHidden, true);
		}

		// Token: 0x0603DA89 RID: 252553 RVA: 0x011DE55C File Offset: 0x011DC75C
		public static void UpdateTransformToAimAtLockOnTarget(Entity entity, AActor target, Dictionary<string, double> lastAutoShootTime, BP_FollowShooterConfig_C followShooterConfig, float deltaTime)
		{
			FVectorDouble? lockOnTargetLocation = LockOnUtils.GetLockOnTargetLocation(target);
			if (lockOnTargetLocation == null)
			{
				return;
			}
			LockOnAimTarget aimTarget = new LockOnAimTarget(lockOnTargetLocation.Value);
			FollowShooterDrone.AllOwnerSceneComponentExecute(entity, followShooterConfig, delegate(Entity entity1, USceneComponent sceneComponent, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
			{
				FollowShooterDrone.UpdateTransformByStrategy(deltaTime, aimTarget, target, lastAutoShootTime, entity1, sceneComponent, lockOnFollowShooter, lockOnFollowShooterAutoAim);
			});
		}

		// Token: 0x0603DA8A RID: 252554 RVA: 0x011DE5C0 File Offset: 0x011DC7C0
		public static void UpdateTransformToCameraForward(Entity entity, FVector up, BP_FollowShooterConfig_C followShooterConfig, float deltaTime)
		{
			float cameraForwardDistance = (followShooterConfig != null) ? followShooterConfig.LockOnConfig.CameraForwardDistance : 0f;
			CameraAimTarget aimTarget = new CameraAimTarget(cameraForwardDistance, up);
			FollowShooterDrone.AllOwnerSceneComponentExecute(entity, followShooterConfig, delegate(Entity entity1, USceneComponent sceneComponent, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
			{
				FollowShooterDrone.UpdateTransformByStrategy(deltaTime, aimTarget, null, null, entity1, sceneComponent, lockOnFollowShooter, lockOnFollowShooterAutoAim);
			});
		}

		// Token: 0x0603DA8B RID: 252555 RVA: 0x011DE610 File Offset: 0x011DC810
		public static UniTask AsyncStartShootAtTargets(int entityId, BP_FollowShooterConfig_C followShooterConfig, List<Vector> targets, [Nullable(2)] UPrimaryDataAsset deadEyeFollowShooterConfig, float selfCenterTimeDilation)
		{
			FollowShooterDrone.<AsyncStartShootAtTargets>d__13 <AsyncStartShootAtTargets>d__;
			<AsyncStartShootAtTargets>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AsyncStartShootAtTargets>d__.entityId = entityId;
			<AsyncStartShootAtTargets>d__.followShooterConfig = followShooterConfig;
			<AsyncStartShootAtTargets>d__.targets = targets;
			<AsyncStartShootAtTargets>d__.deadEyeFollowShooterConfig = deadEyeFollowShooterConfig;
			<AsyncStartShootAtTargets>d__.selfCenterTimeDilation = selfCenterTimeDilation;
			<AsyncStartShootAtTargets>d__.<>1__state = -1;
			<AsyncStartShootAtTargets>d__.<>t__builder.Start<FollowShooterDrone.<AsyncStartShootAtTargets>d__13>(ref <AsyncStartShootAtTargets>d__);
			return <AsyncStartShootAtTargets>d__.<>t__builder.Task;
		}

		// Token: 0x04020B4F RID: 133967
		private static readonly int deadEyeTag = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.死眼跳台.瞄准锁定"];

		// Token: 0x0200BB56 RID: 47958
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040399B2 RID: 235954
			[Nullable(0)]
			public static TFollowShooterExecutor <0>__ClearStrategyStateExecutor;
		}
	}
}
