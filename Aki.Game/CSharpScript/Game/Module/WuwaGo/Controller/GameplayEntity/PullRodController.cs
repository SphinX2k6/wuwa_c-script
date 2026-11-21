using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x020036A8 RID: 13992
	[NullableContext(1)]
	[Nullable(0)]
	public class PullRodController : GameplayEntityControllerBase
	{
		// Token: 0x06024509 RID: 148745 RVA: 0x00A45046 File Offset: 0x00A43246
		public PullRodController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x17004A31 RID: 18993
		// (get) Token: 0x0602450A RID: 148746 RVA: 0x00A45051 File Offset: 0x00A43251
		private WuWaGoPullRodEntity PullRod
		{
			get
			{
				return this.Entity as WuWaGoPullRodEntity;
			}
		}

		// Token: 0x0602450B RID: 148747 RVA: 0x00A4505E File Offset: 0x00A4325E
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			this.IsDestroyed = false;
			base.ResetActorToEntityConfigInitialTransform();
			base.RegisterAttachedGridMoveParticipant();
			return true;
		}

		// Token: 0x0602450C RID: 148748 RVA: 0x00A4507F File Offset: 0x00A4327F
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.IsDestroyed = true;
			base.UnregisterAttachedGridMoveParticipant();
		}

		// Token: 0x0602450D RID: 148749 RVA: 0x00A45094 File Offset: 0x00A43294
		public override void OnRollbackRestore()
		{
			this.PresentationCancelToken++;
		}

		// Token: 0x0602450E RID: 148750 RVA: 0x00A450A4 File Offset: 0x00A432A4
		public void PrepareInteractPresentation(EGameplayEntityState targetState)
		{
			this.PendingPresentationWaitInfo = null;
			SceneItemActorComponent sceneItemActorComponent = this.GetSceneItemActorComponent();
			if (sceneItemActorComponent == null || !sceneItemActorComponent.GetIsSceneInteractionLoadCompleted())
			{
				return;
			}
			SceneInteractionActor sceneInteractionActor = sceneItemActorComponent.GetInteractionMainActor() as SceneInteractionActor;
			if (sceneInteractionActor == null || !sceneInteractionActor.IsValid())
			{
				return;
			}
			EKuroSceneInteractionState key;
			SSceneInteractionitem ssceneInteractionitem = this.ResolveInteractPresentationState(sceneInteractionActor, targetState, out key);
			if (ssceneInteractionitem == null)
			{
				return;
			}
			float playRate = this.ApplyStatePlayRate(ssceneInteractionitem);
			sceneInteractionActor.States[key] = ssceneInteractionitem;
			SSceneInteractionSequence sequence = ssceneInteractionitem.Sequence;
			ULevelSequence ulevelSequence = (sequence != null) ? sequence.Sequence : null;
			if (ulevelSequence == null || !ulevelSequence.IsValid())
			{
				return;
			}
			this.PendingPresentationWaitInfo = new PullRodPresentationWaitInfo
			{
				SceneActor = sceneInteractionActor,
				Sequence = ulevelSequence,
				PlayRate = playRate
			};
		}

		// Token: 0x0602450F RID: 148751 RVA: 0x00A45164 File Offset: 0x00A43364
		[NullableContext(0)]
		public UniTask<bool> WaitForInteractPresentation()
		{
			PullRodController.<WaitForInteractPresentation>d__14 <WaitForInteractPresentation>d__;
			<WaitForInteractPresentation>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<WaitForInteractPresentation>d__.<>4__this = this;
			<WaitForInteractPresentation>d__.<>1__state = -1;
			<WaitForInteractPresentation>d__.<>t__builder.Start<PullRodController.<WaitForInteractPresentation>d__14>(ref <WaitForInteractPresentation>d__);
			return <WaitForInteractPresentation>d__.<>t__builder.Task;
		}

		// Token: 0x06024510 RID: 148752 RVA: 0x00A451A8 File Offset: 0x00A433A8
		private float ApplyStatePlayRate(SSceneInteractionitem state)
		{
			float num = 1f;
			float globalMontagePlayRate = this.GetGlobalMontagePlayRate();
			num *= globalMontagePlayRate;
			if (state.Sequence != null)
			{
				state.Sequence.PlayRate = num;
			}
			return num;
		}

		// Token: 0x06024511 RID: 148753 RVA: 0x00A451E4 File Offset: 0x00A433E4
		protected override UniTask OnExecuteAction()
		{
			PullRodController.<OnExecuteAction>d__16 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<PullRodController.<OnExecuteAction>d__16>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x06024512 RID: 148754 RVA: 0x00A45227 File Offset: 0x00A43427
		[NullableContext(2)]
		private SceneItemActorComponent GetSceneItemActorComponent()
		{
			EntityHandle entityHandle = this.PullRod.EntityHandle;
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

		// Token: 0x06024513 RID: 148755 RVA: 0x00A4524C File Offset: 0x00A4344C
		[return: Nullable(2)]
		private SSceneInteractionitem ResolveInteractPresentationState(SceneInteractionActor sceneActor, EGameplayEntityState targetState, out EKuroSceneInteractionState presentationStateKey)
		{
			presentationStateKey = EKuroSceneInteractionState.State1;
			EKuroSceneInteractionState? ekuroSceneInteractionState = this.ResolveSceneInteractionState(targetState);
			if (ekuroSceneInteractionState == null)
			{
				return null;
			}
			EKuroSceneInteractionState currentState = sceneActor.GetCurrentState();
			SSceneInteractionitem ssceneInteractionitem;
			sceneActor.States.TryGetValue(currentState, out ssceneInteractionitem);
			EKuroSceneInteractionState? ekuroSceneInteractionState2 = null;
			EKuroSceneInteractionState value;
			if (ssceneInteractionitem != null && ssceneInteractionitem.TransitionMap.TryGetValue(ekuroSceneInteractionState.Value, out value))
			{
				ekuroSceneInteractionState2 = new EKuroSceneInteractionState?(value);
			}
			presentationStateKey = (ekuroSceneInteractionState2 ?? ekuroSceneInteractionState.Value);
			SSceneInteractionitem ssceneInteractionitem2;
			sceneActor.States.TryGetValue(presentationStateKey, out ssceneInteractionitem2);
			if (ssceneInteractionitem2 == null)
			{
				return null;
			}
			return ssceneInteractionitem2;
		}

		// Token: 0x06024514 RID: 148756 RVA: 0x00A452EC File Offset: 0x00A434EC
		private EKuroSceneInteractionState? ResolveSceneInteractionState(EGameplayEntityState targetState)
		{
			EntityHandle entityHandle = this.PullRod.EntityHandle;
			WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
			CreatureDataComponent creatureDataComponent = (worldEntity != null) ? worldEntity.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent == null)
			{
				return null;
			}
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(GameplayTagUtils.GetTagIdByName(targetState.ToEnumString()));
			EKuroSceneInteractionState value;
			if (gameplayTagById == null || !creatureDataComponent.GetModelConfig().场景交互物状态列表.TryGetValue(gameplayTagById.Value, out value))
			{
				return null;
			}
			return new EKuroSceneInteractionState?(value);
		}

		// Token: 0x06024515 RID: 148757 RVA: 0x00A45370 File Offset: 0x00A43570
		private int ResolveStatePresentationWaitMs(IPullRodPresentationWaitInfo waitInfo)
		{
			SceneInteractionActor sceneActor = waitInfo.SceneActor;
			ULevelSequence sequence = waitInfo.Sequence;
			float playRate = waitInfo.PlayRate;
			if (!sceneActor.IsValid() || !sequence.IsValid() || playRate <= 0f)
			{
				return 0;
			}
			float activeSequenceRemainTime = sceneActor.GetActiveSequenceRemainTime(sequence);
			if (!float.IsFinite(activeSequenceRemainTime) || activeSequenceRemainTime <= 0f)
			{
				return 0;
			}
			float num = activeSequenceRemainTime * 1000f / playRate;
			if (!float.IsFinite(num) || num <= 0f)
			{
				return 0;
			}
			return Math.Min((int)Math.Ceiling((double)num), 5000);
		}

		// Token: 0x06024516 RID: 148758 RVA: 0x00A453F8 File Offset: 0x00A435F8
		private float GetGlobalMontagePlayRate()
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			float? num = (setting != null) ? new float?(setting.MontagePlayRate) : null;
			if (num != null && num.GetValueOrDefault() > 0f)
			{
				return num.Value;
			}
			return 1f;
		}

		// Token: 0x04014379 RID: 82809
		private const int PULL_ROD_PRESENTATION_TIMEOUT_MS = 5000;

		// Token: 0x0401437A RID: 82810
		private const int PULL_ROD_PRESENTATION_POLL_INTERVAL_MS = 50;

		// Token: 0x0401437B RID: 82811
		private const int MILLISECONDS_PER_SECOND = 1000;

		// Token: 0x0401437C RID: 82812
		private const int PLAY_RATE_FIX = 1;

		// Token: 0x0401437D RID: 82813
		private bool IsDestroyed;

		// Token: 0x0401437E RID: 82814
		private int PresentationCancelToken;

		// Token: 0x0401437F RID: 82815
		[Nullable(2)]
		private IPullRodPresentationWaitInfo PendingPresentationWaitInfo;
	}
}
