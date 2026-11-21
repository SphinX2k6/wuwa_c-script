using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x0200369A RID: 13978
	[NullableContext(1)]
	[Nullable(0)]
	public class BowTrapController : GameplayEntityControllerBase
	{
		// Token: 0x06024461 RID: 148577 RVA: 0x00A4225D File Offset: 0x00A4045D
		public BowTrapController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x17004A19 RID: 18969
		// (get) Token: 0x06024462 RID: 148578 RVA: 0x00A42268 File Offset: 0x00A40468
		private WuWaGoBowTrapEntity BowTrap
		{
			get
			{
				return this.Entity as WuWaGoBowTrapEntity;
			}
		}

		// Token: 0x06024463 RID: 148579 RVA: 0x00A42275 File Offset: 0x00A40475
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			base.RegisterAttachedGridMoveParticipant();
			return true;
		}

		// Token: 0x06024464 RID: 148580 RVA: 0x00A42288 File Offset: 0x00A40488
		protected override void OnDestroy()
		{
			base.OnDestroy();
			base.UnregisterAttachedGridMoveParticipant();
			this.IsDestroyed = true;
			this.CleanupArrowSequenceVisual();
		}

		// Token: 0x06024465 RID: 148581 RVA: 0x00A422A3 File Offset: 0x00A404A3
		public override void OnRollbackRestore()
		{
			this.SequenceCancelToken++;
			this.CleanupArrowSequenceVisual();
		}

		// Token: 0x06024466 RID: 148582 RVA: 0x00A422BC File Offset: 0x00A404BC
		protected override UniTask OnExecuteAction()
		{
			BowTrapController.<OnExecuteAction>d__15 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<BowTrapController.<OnExecuteAction>d__15>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x06024467 RID: 148583 RVA: 0x00A42300 File Offset: 0x00A40500
		private UniTask PerformShoot()
		{
			BowTrapController.<PerformShoot>d__16 <PerformShoot>d__;
			<PerformShoot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PerformShoot>d__.<>4__this = this;
			<PerformShoot>d__.<>1__state = -1;
			<PerformShoot>d__.<>t__builder.Start<BowTrapController.<PerformShoot>d__16>(ref <PerformShoot>d__);
			return <PerformShoot>d__.<>t__builder.Task;
		}

		// Token: 0x06024468 RID: 148584 RVA: 0x00A42343 File Offset: 0x00A40543
		private bool HasWallOnNextGrid(Vector currentPos, Vector direction, Vector wallCheckPos)
		{
			currentPos.Addition(direction, wallCheckPos);
			wallCheckPos.Z += 1.0;
			return this.GameData.GetGrid(wallCheckPos) != null;
		}

		// Token: 0x06024469 RID: 148585 RVA: 0x00A42374 File Offset: 0x00A40574
		private unsafe bool TryHitRoleAtPosition(Vector checkPos, float targetDistanceMeter, IArrowShootResult shootResult)
		{
			WuWaGoGrid grid = this.GameData.GetGrid(checkPos);
			if (grid == null)
			{
				return false;
			}
			if (!grid.IsOccupied)
			{
				return false;
			}
			WuWaGoBaseUnit wuWaGoBaseUnit;
			if (this.GameData.AllUnits.TryGetValue(grid.OccupiedUnitId, out wuWaGoBaseUnit))
			{
				WuWaGoRole wuWaGoRole = wuWaGoBaseUnit as WuWaGoRole;
				if (wuWaGoRole != null)
				{
					shootResult.HitRole = wuWaGoRole;
					shootResult.TargetDistanceMeter = targetDistanceMeter;
					Log instance = Log.Instance;
					ELogModule module = ELogModule.WuWaGo;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "弓箭命中目标";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("trapId", this.Entity.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetId", wuWaGoRole.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("position", checkPos);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("targetDistanceMeter", shootResult.TargetDistanceMeter);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602446A RID: 148586 RVA: 0x00A4247C File Offset: 0x00A4067C
		private UniTask TakeAttackOnRole(WuWaGoRole role)
		{
			BowTrapController.<TakeAttackOnRole>d__19 <TakeAttackOnRole>d__;
			<TakeAttackOnRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TakeAttackOnRole>d__.<>4__this = this;
			<TakeAttackOnRole>d__.role = role;
			<TakeAttackOnRole>d__.<>1__state = -1;
			<TakeAttackOnRole>d__.<>t__builder.Start<BowTrapController.<TakeAttackOnRole>d__19>(ref <TakeAttackOnRole>d__);
			return <TakeAttackOnRole>d__.<>t__builder.Task;
		}

		// Token: 0x0602446B RID: 148587 RVA: 0x00A424C8 File Offset: 0x00A406C8
		private UniTask WaitForNoHitPresentation(float waitMs)
		{
			BowTrapController.<WaitForNoHitPresentation>d__20 <WaitForNoHitPresentation>d__;
			<WaitForNoHitPresentation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForNoHitPresentation>d__.waitMs = waitMs;
			<WaitForNoHitPresentation>d__.<>1__state = -1;
			<WaitForNoHitPresentation>d__.<>t__builder.Start<BowTrapController.<WaitForNoHitPresentation>d__20>(ref <WaitForNoHitPresentation>d__);
			return <WaitForNoHitPresentation>d__.<>t__builder.Task;
		}

		// Token: 0x0602446C RID: 148588 RVA: 0x00A4250C File Offset: 0x00A4070C
		private UniTask PlayArrowSequence(float targetDistanceMeter, bool shouldPlayHitEffect)
		{
			BowTrapController.<PlayArrowSequence>d__21 <PlayArrowSequence>d__;
			<PlayArrowSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayArrowSequence>d__.<>4__this = this;
			<PlayArrowSequence>d__.targetDistanceMeter = targetDistanceMeter;
			<PlayArrowSequence>d__.shouldPlayHitEffect = shouldPlayHitEffect;
			<PlayArrowSequence>d__.<>1__state = -1;
			<PlayArrowSequence>d__.<>t__builder.Start<BowTrapController.<PlayArrowSequence>d__21>(ref <PlayArrowSequence>d__);
			return <PlayArrowSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602446D RID: 148589 RVA: 0x00A42560 File Offset: 0x00A40760
		private static float GetGridSizeMeter()
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			int? num = (setting != null) ? new int?(setting.SingleGridSize) : null;
			bool flag;
			if (num != null)
			{
				int valueOrDefault = num.GetValueOrDefault();
				if (valueOrDefault > 0)
				{
					flag = false;
					goto IL_3C;
				}
			}
			flag = true;
			IL_3C:
			if (flag)
			{
				return 3f;
			}
			return (float)num.Value * 0.01f;
		}

		// Token: 0x0602446E RID: 148590 RVA: 0x00A425C0 File Offset: 0x00A407C0
		private float GetArrowNoHitWaitMs(float targetDistanceMeter)
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			int? num = (setting != null) ? new int?(setting.ArrowNoHitWaitMs) : null;
			if (num != null && num.GetValueOrDefault() > 0)
			{
				return (float)num.Value;
			}
			return this.GetArrowPresentationDurationMs(targetDistanceMeter);
		}

		// Token: 0x0602446F RID: 148591 RVA: 0x00A4260F File Offset: 0x00A4080F
		private float GetArrowPresentationDurationMs(float targetDistanceMeter)
		{
			return this.GetBowDelayMs() + this.GetBowFlyDurationMs(targetDistanceMeter);
		}

		// Token: 0x06024470 RID: 148592 RVA: 0x00A42620 File Offset: 0x00A40820
		private float GetBowDelayMs()
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			int? num = (setting != null) ? new int?(setting.BowDelayMs) : null;
			if (num != null && num.GetValueOrDefault() >= 0 && float.IsFinite((float)num.Value))
			{
				return (float)num.Value / WuWaGoUtil.GetMontagePlayRate();
			}
			return 0f;
		}

		// Token: 0x06024471 RID: 148593 RVA: 0x00A42684 File Offset: 0x00A40884
		private unsafe float GetBowFlyDurationMs(float targetDistanceMeter)
		{
			float num = Math.Max(targetDistanceMeter, 0f);
			if (num <= 0f)
			{
				return 0f;
			}
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			int? num2 = (setting != null) ? new int?(setting.BowFlySpeed) : null;
			if (num2 != null && num2.GetValueOrDefault() > 0 && float.IsFinite((float)num2.Value))
			{
				return num * 100f / ((float)num2.Value * WuWaGoUtil.GetMontagePlayRate()) * 1000f;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WuWaGo;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "弓箭陷阱飞行速度未配置，飞行时长使用0兜底";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("trapId", this.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetDistanceMeter", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("flySpeed", num2);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return 0f;
		}

		// Token: 0x06024472 RID: 148594 RVA: 0x00A42795 File Offset: 0x00A40995
		[NullableContext(2)]
		private SceneItemActorComponent GetSceneItemActorComponent()
		{
			EntityHandle entityHandle = this.BowTrap.EntityHandle;
			if (entityHandle == null)
			{
				return null;
			}
			WorldEntity entity = entityHandle.Entity;
			if (entity == null)
			{
				return null;
			}
			return entity.GetComponent<SceneItemActorComponent>();
		}

		// Token: 0x06024473 RID: 148595 RVA: 0x00A427B8 File Offset: 0x00A409B8
		private float GetArrowSequenceTargetProgress(float targetDistanceMeter)
		{
			return Math.Min(Math.Max(targetDistanceMeter / 20f, 0f), 1f);
		}

		// Token: 0x06024474 RID: 148596 RVA: 0x00A427D8 File Offset: 0x00A409D8
		private unsafe void ApplyArrowSequenceDurationOverride(SceneItemActorComponent actorComp, FGameplayTag tag)
		{
			double? activeTagSequenceDurationTime = actorComp.GetActiveTagSequenceDurationTime(tag);
			double? num = activeTagSequenceDurationTime;
			double num2 = 0.0;
			if (num.GetValueOrDefault() <= num2 & num != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "弓箭陷阱无法获取Sequence时长，使用默认播放速率兜底";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("trapId", this.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tagName", EGameplayEntityState.Completed);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			actorComp.SetActiveTagSequenceDurationTime(tag, (float)(activeTagSequenceDurationTime / (double)WuWaGoUtil.GetMontagePlayRate()).Value);
		}

		// Token: 0x06024475 RID: 148597 RVA: 0x00A428B8 File Offset: 0x00A40AB8
		private void PlayArrowEndEffect(SceneItemActorComponent actorComp, FGameplayTag tag)
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			string text = (setting != null) ? setting.BowHitFx.ToAssetPathName() : null;
			if (text == null || StringUtils.IsBlank(text))
			{
				return;
			}
			AActor firstValidArrowActor = this.GetFirstValidArrowActor(actorComp, tag);
			if (firstValidArrowActor == null)
			{
				return;
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(firstValidArrowActor.D_GetTransform());
			instance.SpawnEffect(world, ftransformDouble, text, "WuWaGo.BowTrap.ArrowEnd", new EffectContext(null, firstValidArrowActor, false), EEffectType.Scene, null, null, null, false, false);
		}

		// Token: 0x06024476 RID: 148598 RVA: 0x00A42930 File Offset: 0x00A40B30
		[return: Nullable(2)]
		private AActor GetFirstValidArrowActor(SceneItemActorComponent actorComp, FGameplayTag tag)
		{
			TArray<AActor> refActorsInSceneInteractionByTag = actorComp.GetRefActorsInSceneInteractionByTag(tag);
			if (refActorsInSceneInteractionByTag == null)
			{
				return null;
			}
			int i = 0;
			int num = refActorsInSceneInteractionByTag.Num();
			while (i < num)
			{
				AActor aactor = refActorsInSceneInteractionByTag.Get(i);
				if (aactor != null && aactor.IsValid())
				{
					return aactor;
				}
				i++;
			}
			return null;
		}

		// Token: 0x06024477 RID: 148599 RVA: 0x00A42974 File Offset: 0x00A40B74
		private void CleanupArrowSequenceVisual()
		{
			SceneItemActorComponent sceneItemActorComponent = this.GetSceneItemActorComponent();
			if (sceneItemActorComponent == null)
			{
				return;
			}
			int tagIdByName = GameplayTagUtils.GetTagIdByName(EGameplayEntityState.Completed.ToEnumString());
			if (tagIdByName == 0)
			{
				return;
			}
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(tagIdByName);
			if (gameplayTagById == null)
			{
				return;
			}
			FGameplayTag value = gameplayTagById.Value;
			sceneItemActorComponent.StopExtraEffect(value);
			this.ResetArrowTagActors(sceneItemActorComponent, value, true);
		}

		// Token: 0x06024478 RID: 148600 RVA: 0x00A429C8 File Offset: 0x00A40BC8
		private void ResetArrowTagActors(SceneItemActorComponent actorComp, FGameplayTag tag, bool hideAfterReset)
		{
			TArray<AActor> refActorsInSceneInteractionByTag = actorComp.GetRefActorsInSceneInteractionByTag(tag);
			if (refActorsInSceneInteractionByTag == null)
			{
				return;
			}
			int i = 0;
			int num = refActorsInSceneInteractionByTag.Num();
			while (i < num)
			{
				AActor aactor = refActorsInSceneInteractionByTag.Get(i);
				if (aactor != null && aactor.IsValid())
				{
					FTransformDouble? actorInSceneInteractionOriginalRelTransform = actorComp.GetActorInSceneInteractionOriginalRelTransform(aactor);
					if (actorInSceneInteractionOriginalRelTransform != null)
					{
						aactor.D_K2_SetActorRelativeLocation(actorInSceneInteractionOriginalRelTransform.Value.GetLocation(), false, ref WorldGlobal.SweepHitResult, false);
						aactor.K2_SetActorRelativeRotation(actorInSceneInteractionOriginalRelTransform.Value.Rotator(), false, ref WorldGlobal.SweepHitResult, false);
					}
					aactor.SetActorHiddenInGame(hideAfterReset);
					aactor.SetActorEnableCollision(!hideAfterReset);
				}
				i++;
			}
		}

		// Token: 0x04014337 RID: 82743
		private const int MAX_SHOOT_DISTANCE = 100;

		// Token: 0x04014338 RID: 82744
		private const EGameplayEntityState ARROW_SEQUENCE_TAG_NAME = EGameplayEntityState.Completed;

		// Token: 0x04014339 RID: 82745
		private const int ARROW_SEQUENCE_TOTAL_DISTANCE_METER = 20;

		// Token: 0x0401433A RID: 82746
		private const int DEFAULT_BOW_DELAY_MS = 0;

		// Token: 0x0401433B RID: 82747
		private const int DEFAULT_GRID_SIZE_METER = 3;

		// Token: 0x0401433C RID: 82748
		private const int SECOND_TO_MILLISECOND = 1000;

		// Token: 0x0401433D RID: 82749
		private const int CENTIMETER_TO_METER = 100;

		// Token: 0x0401433E RID: 82750
		private bool IsDestroyed;

		// Token: 0x0401433F RID: 82751
		private int SequenceCancelToken;
	}
}
