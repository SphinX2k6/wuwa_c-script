using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.FollowShooter;
using AkiClient.Game.Aki.Data.Fight.Struct;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007132 RID: 28978
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowShooterDrone
	{
		// Token: 0x06046C2E RID: 289838 RVA: 0x011D5544 File Offset: 0x011D3744
		private static void ExecuteExecutor(TFollowShooterExecutor executor, Entity entity, FName targetName, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
		{
			BaseActorComponent baseActorComponent = entity.CheckGetComponent<BaseActorComponent>();
			AActor aactor = (baseActorComponent != null) ? baseActorComponent.Owner : null;
			if (aactor == null)
			{
				return;
			}
			foreach (USceneComponent usceneComponent in aactor.GetComponentsByTag(USceneComponent.StaticClass(), targetName).Cast<USceneComponent>())
			{
				if (usceneComponent.IsValid())
				{
					executor(entity, usceneComponent, lockOnFollowShooter, lockOnFollowShooterAutoAim);
				}
			}
		}

		// Token: 0x06046C2F RID: 289839 RVA: 0x011D55C4 File Offset: 0x011D37C4
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

		// Token: 0x06046C30 RID: 289840 RVA: 0x011D56F4 File Offset: 0x011D38F4
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

		// Token: 0x06046C31 RID: 289841 RVA: 0x011D5790 File Offset: 0x011D3990
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

		// Token: 0x06046C32 RID: 289842 RVA: 0x011D581C File Offset: 0x011D3A1C
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

		// Token: 0x06046C33 RID: 289843 RVA: 0x011D5904 File Offset: 0x011D3B04
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

		// Token: 0x06046C34 RID: 289844 RVA: 0x011D59E0 File Offset: 0x011D3BE0
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

		// Token: 0x06046C35 RID: 289845 RVA: 0x011D5B10 File Offset: 0x011D3D10
		public static void ClearStrategyStatesForOwner(Entity entity, BP_FollowShooterConfig_C followShooterConfig)
		{
			TFollowShooterExecutor executor;
			if ((executor = FollowShooterDrone.<>O.<0>__ClearStrategyStateExecutor) == null)
			{
				executor = (FollowShooterDrone.<>O.<0>__ClearStrategyStateExecutor = new TFollowShooterExecutor(FollowShooterDrone.ClearStrategyStateExecutor));
			}
			FollowShooterDrone.AllOwnerSceneComponentExecute(entity, followShooterConfig, executor);
		}

		// Token: 0x06046C36 RID: 289846 RVA: 0x011D5B34 File Offset: 0x011D3D34
		private static void ClearStrategyStateExecutor(Entity entity, USceneComponent sceneComponent, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
		{
			FollowShooterAttachStrategies.clearFollowShooterAttachStrategiesStateForSceneComponent(sceneComponent);
		}

		// Token: 0x06046C37 RID: 289847 RVA: 0x011D5B3C File Offset: 0x011D3D3C
		public static void SetHiddenInGame(bool newHidden, Entity entity, USceneComponent sceneComponent, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
		{
			sceneComponent.SetHiddenInGame(newHidden, true);
		}

		// Token: 0x06046C38 RID: 289848 RVA: 0x011D5B48 File Offset: 0x011D3D48
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

		// Token: 0x06046C39 RID: 289849 RVA: 0x011D5BAC File Offset: 0x011D3DAC
		public static void UpdateTransformToCameraForward(Entity entity, FVector up, BP_FollowShooterConfig_C followShooterConfig, float deltaTime)
		{
			float cameraForwardDistance = (followShooterConfig != null) ? followShooterConfig.LockOnConfig.CameraForwardDistance : 0f;
			CameraAimTarget aimTarget = new CameraAimTarget(cameraForwardDistance, up);
			FollowShooterDrone.AllOwnerSceneComponentExecute(entity, followShooterConfig, delegate(Entity entity1, USceneComponent sceneComponent, SLockOnFollowShooter lockOnFollowShooter, SLockOnFollowShooterAutoAim lockOnFollowShooterAutoAim)
			{
				FollowShooterDrone.UpdateTransformByStrategy(deltaTime, aimTarget, null, null, entity1, sceneComponent, lockOnFollowShooter, lockOnFollowShooterAutoAim);
			});
		}

		// Token: 0x06046C3A RID: 289850 RVA: 0x011D5BFC File Offset: 0x011D3DFC
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

		// Token: 0x0402526F RID: 152175
		private static readonly int deadEyeTag = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.死眼跳台.瞄准锁定"];

		// Token: 0x0200CE8E RID: 52878
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E2A8 RID: 254632
			[Nullable(0)]
			public static TFollowShooterExecutor <0>__ClearStrategyStateExecutor;
		}
	}
}
