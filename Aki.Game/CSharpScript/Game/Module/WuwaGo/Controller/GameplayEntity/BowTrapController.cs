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
	// Token: 0x02004769 RID: 18281
	[NullableContext(1)]
	[Nullable(0)]
	public class BowTrapController : GameplayEntityControllerBase
	{
		// Token: 0x0602FC97 RID: 195735 RVA: 0x00B1229D File Offset: 0x00B1049D
		public BowTrapController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x1700775D RID: 30557
		// (get) Token: 0x0602FC98 RID: 195736 RVA: 0x00B122A8 File Offset: 0x00B104A8
		private WuWaGoBowTrapEntity BowTrap
		{
			get
			{
				return this.Entity as WuWaGoBowTrapEntity;
			}
		}

		// Token: 0x0602FC99 RID: 195737 RVA: 0x00B122B5 File Offset: 0x00B104B5
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			base.RegisterAttachedGridMoveParticipant();
			return true;
		}

		// Token: 0x0602FC9A RID: 195738 RVA: 0x00B122C8 File Offset: 0x00B104C8
		protected override void OnDestroy()
		{
			base.OnDestroy();
			base.UnregisterAttachedGridMoveParticipant();
			this.IsDestroyed = true;
			this.CleanupArrowSequenceVisual();
		}

		// Token: 0x0602FC9B RID: 195739 RVA: 0x00B122E3 File Offset: 0x00B104E3
		public override void OnRollbackRestore()
		{
			this.SequenceCancelToken++;
			this.CleanupArrowSequenceVisual();
		}

		// Token: 0x0602FC9C RID: 195740 RVA: 0x00B122FC File Offset: 0x00B104FC
		protected override UniTask OnExecuteAction()
		{
			BowTrapController.<OnExecuteAction>d__15 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<BowTrapController.<OnExecuteAction>d__15>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC9D RID: 195741 RVA: 0x00B12340 File Offset: 0x00B10540
		private UniTask PerformShoot()
		{
			BowTrapController.<PerformShoot>d__16 <PerformShoot>d__;
			<PerformShoot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PerformShoot>d__.<>4__this = this;
			<PerformShoot>d__.<>1__state = -1;
			<PerformShoot>d__.<>t__builder.Start<BowTrapController.<PerformShoot>d__16>(ref <PerformShoot>d__);
			return <PerformShoot>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC9E RID: 195742 RVA: 0x00B12383 File Offset: 0x00B10583
		private bool HasWallOnNextGrid(Vector currentPos, Vector direction, Vector wallCheckPos)
		{
			currentPos.Addition(direction, wallCheckPos);
			wallCheckPos.Z += 1.0;
			return this.GameData.GetGrid(wallCheckPos) != null;
		}

		// Token: 0x0602FC9F RID: 195743 RVA: 0x00B123B4 File Offset: 0x00B105B4
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

		// Token: 0x0602FCA0 RID: 195744 RVA: 0x00B124BC File Offset: 0x00B106BC
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

		// Token: 0x0602FCA1 RID: 195745 RVA: 0x00B12508 File Offset: 0x00B10708
		private UniTask WaitForNoHitPresentation(float waitMs)
		{
			BowTrapController.<WaitForNoHitPresentation>d__20 <WaitForNoHitPresentation>d__;
			<WaitForNoHitPresentation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForNoHitPresentation>d__.waitMs = waitMs;
			<WaitForNoHitPresentation>d__.<>1__state = -1;
			<WaitForNoHitPresentation>d__.<>t__builder.Start<BowTrapController.<WaitForNoHitPresentation>d__20>(ref <WaitForNoHitPresentation>d__);
			return <WaitForNoHitPresentation>d__.<>t__builder.Task;
		}

		// Token: 0x0602FCA2 RID: 195746 RVA: 0x00B1254C File Offset: 0x00B1074C
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

		// Token: 0x0602FCA3 RID: 195747 RVA: 0x00B125A0 File Offset: 0x00B107A0
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

		// Token: 0x0602FCA4 RID: 195748 RVA: 0x00B12600 File Offset: 0x00B10800
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

		// Token: 0x0602FCA5 RID: 195749 RVA: 0x00B1264F File Offset: 0x00B1084F
		private float GetArrowPresentationDurationMs(float targetDistanceMeter)
		{
			return this.GetBowDelayMs() + this.GetBowFlyDurationMs(targetDistanceMeter);
		}

		// Token: 0x0602FCA6 RID: 195750 RVA: 0x00B12660 File Offset: 0x00B10860
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

		// Token: 0x0602FCA7 RID: 195751 RVA: 0x00B126C4 File Offset: 0x00B108C4
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

		// Token: 0x0602FCA8 RID: 195752 RVA: 0x00B127D5 File Offset: 0x00B109D5
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

		// Token: 0x0602FCA9 RID: 195753 RVA: 0x00B127F8 File Offset: 0x00B109F8
		private float GetArrowSequenceTargetProgress(float targetDistanceMeter)
		{
			return Math.Min(Math.Max(targetDistanceMeter / 20f, 0f), 1f);
		}

		// Token: 0x0602FCAA RID: 195754 RVA: 0x00B12818 File Offset: 0x00B10A18
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

		// Token: 0x0602FCAB RID: 195755 RVA: 0x00B128F8 File Offset: 0x00B10AF8
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

		// Token: 0x0602FCAC RID: 195756 RVA: 0x00B12970 File Offset: 0x00B10B70
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

		// Token: 0x0602FCAD RID: 195757 RVA: 0x00B129B4 File Offset: 0x00B10BB4
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

		// Token: 0x0602FCAE RID: 195758 RVA: 0x00B12A08 File Offset: 0x00B10C08
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

		// Token: 0x04019C87 RID: 105607
		private const int MAX_SHOOT_DISTANCE = 100;

		// Token: 0x04019C88 RID: 105608
		private const EGameplayEntityState ARROW_SEQUENCE_TAG_NAME = EGameplayEntityState.Completed;

		// Token: 0x04019C89 RID: 105609
		private const int ARROW_SEQUENCE_TOTAL_DISTANCE_METER = 20;

		// Token: 0x04019C8A RID: 105610
		private const int DEFAULT_BOW_DELAY_MS = 0;

		// Token: 0x04019C8B RID: 105611
		private const int DEFAULT_GRID_SIZE_METER = 3;

		// Token: 0x04019C8C RID: 105612
		private const int SECOND_TO_MILLISECOND = 1000;

		// Token: 0x04019C8D RID: 105613
		private const int CENTIMETER_TO_METER = 100;

		// Token: 0x04019C8E RID: 105614
		private bool IsDestroyed;

		// Token: 0x04019C8F RID: 105615
		private int SequenceCancelToken;
	}
}
