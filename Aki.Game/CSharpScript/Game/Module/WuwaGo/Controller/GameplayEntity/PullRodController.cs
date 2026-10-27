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
	// Token: 0x02004777 RID: 18295
	[NullableContext(1)]
	[Nullable(0)]
	public class PullRodController : GameplayEntityControllerBase
	{
		// Token: 0x0602FD3F RID: 195903 RVA: 0x00B14FE6 File Offset: 0x00B131E6
		public PullRodController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x17007775 RID: 30581
		// (get) Token: 0x0602FD40 RID: 195904 RVA: 0x00B14FF1 File Offset: 0x00B131F1
		private WuWaGoPullRodEntity PullRod
		{
			get
			{
				return this.Entity as WuWaGoPullRodEntity;
			}
		}

		// Token: 0x0602FD41 RID: 195905 RVA: 0x00B14FFE File Offset: 0x00B131FE
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

		// Token: 0x0602FD42 RID: 195906 RVA: 0x00B1501F File Offset: 0x00B1321F
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.IsDestroyed = true;
			base.UnregisterAttachedGridMoveParticipant();
		}

		// Token: 0x0602FD43 RID: 195907 RVA: 0x00B15034 File Offset: 0x00B13234
		public override void OnRollbackRestore()
		{
			this.PresentationCancelToken++;
		}

		// Token: 0x0602FD44 RID: 195908 RVA: 0x00B15044 File Offset: 0x00B13244
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

		// Token: 0x0602FD45 RID: 195909 RVA: 0x00B15104 File Offset: 0x00B13304
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

		// Token: 0x0602FD46 RID: 195910 RVA: 0x00B15148 File Offset: 0x00B13348
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

		// Token: 0x0602FD47 RID: 195911 RVA: 0x00B15184 File Offset: 0x00B13384
		protected override UniTask OnExecuteAction()
		{
			PullRodController.<OnExecuteAction>d__16 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<PullRodController.<OnExecuteAction>d__16>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD48 RID: 195912 RVA: 0x00B151C7 File Offset: 0x00B133C7
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

		// Token: 0x0602FD49 RID: 195913 RVA: 0x00B151EC File Offset: 0x00B133EC
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

		// Token: 0x0602FD4A RID: 195914 RVA: 0x00B1528C File Offset: 0x00B1348C
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

		// Token: 0x0602FD4B RID: 195915 RVA: 0x00B15310 File Offset: 0x00B13510
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

		// Token: 0x0602FD4C RID: 195916 RVA: 0x00B15398 File Offset: 0x00B13598
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

		// Token: 0x04019CC9 RID: 105673
		private const int PULL_ROD_PRESENTATION_TIMEOUT_MS = 5000;

		// Token: 0x04019CCA RID: 105674
		private const int PULL_ROD_PRESENTATION_POLL_INTERVAL_MS = 50;

		// Token: 0x04019CCB RID: 105675
		private const int MILLISECONDS_PER_SECOND = 1000;

		// Token: 0x04019CCC RID: 105676
		private const int PLAY_RATE_FIX = 1;

		// Token: 0x04019CCD RID: 105677
		private bool IsDestroyed;

		// Token: 0x04019CCE RID: 105678
		private int PresentationCancelToken;

		// Token: 0x04019CCF RID: 105679
		[Nullable(2)]
		private IPullRodPresentationWaitInfo PendingPresentationWaitInfo;
	}
}
