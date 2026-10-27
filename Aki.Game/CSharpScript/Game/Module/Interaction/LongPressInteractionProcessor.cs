using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005848 RID: 22600
	[NullableContext(2)]
	[Nullable(0)]
	public class LongPressInteractionProcessor : InteractionProcessor
	{
		// Token: 0x17008A48 RID: 35400
		// (get) Token: 0x0603971B RID: 235291 RVA: 0x00DA2111 File Offset: 0x00DA0311
		public ELongPressInteractStyle? StyleType
		{
			get
			{
				return this.StyleTypeInternal;
			}
		}

		// Token: 0x17008A49 RID: 35401
		// (get) Token: 0x0603971C RID: 235292 RVA: 0x00DA2119 File Offset: 0x00DA0319
		public string TidContent
		{
			get
			{
				return this.TidContentInternal;
			}
		}

		// Token: 0x17008A4A RID: 35402
		// (get) Token: 0x0603971D RID: 235293 RVA: 0x00DA2121 File Offset: 0x00DA0321
		public float? StartProgress
		{
			get
			{
				return this.StartProgressInternal;
			}
		}

		// Token: 0x0603971E RID: 235294 RVA: 0x00DA212C File Offset: 0x00DA032C
		[NullableContext(1)]
		public void ActivateRestriction(EInputAction? triggerAction, ILongPressInteractRestriction restriction)
		{
			if (this.RestrictionTriggerAction == triggerAction && this.Restriction == restriction)
			{
				return;
			}
			this.ExitRestriction();
			this.RestrictionTriggerAction = triggerAction;
			this.Restriction = restriction;
			restriction.Enter(triggerAction);
		}

		// Token: 0x0603971F RID: 235295 RVA: 0x00DA219C File Offset: 0x00DA039C
		public void ExitRestriction()
		{
			if (this.Restriction == null)
			{
				return;
			}
			EInputAction? restrictionTriggerAction = this.RestrictionTriggerAction;
			ILongPressInteractRestriction restriction = this.Restriction;
			this.RestrictionTriggerAction = null;
			this.Restriction = null;
			restriction.Exit(restrictionTriggerAction);
		}

		// Token: 0x06039720 RID: 235296 RVA: 0x00DA21D8 File Offset: 0x00DA03D8
		[NullableContext(1)]
		public LongPressInteractionProcessor([Nullable(2)] Entity entity, int index, ILongPressInteractConfig config, int optionIndex) : base(entity, index, EInteractionType.LongPress)
		{
			this.OptionIndex = optionIndex;
			this.Duration = config.PressDuration * (float)TimeUtil.Instance.InverseMillisecond;
			this.PressEffect = config.PressEffect;
			ILongPressInteractStyleConfig style = config.Style;
			this.StyleTypeInternal = ((style != null) ? new ELongPressInteractStyle?(style.Type) : null);
			ILongPressInteractStyleConfig style2 = config.Style;
			if (style2 != null && style2.Type == ELongPressInteractStyle.TimeBackInteract)
			{
				ILongPressInteractStyleConfigTimeBackInteract longPressInteractStyleConfigTimeBackInteract = config.Style as ILongPressInteractStyleConfigTimeBackInteract;
				this.TidContentInternal = ((longPressInteractStyleConfigTimeBackInteract != null) ? longPressInteractStyleConfigTimeBackInteract.TidContent : null);
				ILongPressInteractStyleConfigTimeBackInteract longPressInteractStyleConfigTimeBackInteract2 = config.Style as ILongPressInteractStyleConfigTimeBackInteract;
				this.StartProgressInternal = ((longPressInteractStyleConfigTimeBackInteract2 != null) ? longPressInteractStyleConfigTimeBackInteract2.StartProgress : null);
			}
			this.ResetFromCurrentProgress = config.ResetFromCurrentProgress.GetValueOrDefault();
			this.StartActions = config.LongPressStartActions;
			this.InterruptedActions = config.LongPressInterruptedActions;
			this.SuccessActions = config.LongPressSuccessActions;
			this.ProgressActions = config.LongPressProgressActions;
		}

		// Token: 0x06039721 RID: 235297 RVA: 0x00DA22F4 File Offset: 0x00DA04F4
		public override void OnPress()
		{
			if (!this.LongPressingEffectsReady || base.IsPressing || base.IsCompleteInternal)
			{
				return;
			}
			global::Log.Instance.Info(ELogModule.Interaction, ELogAuthor.WRY, "[LongPress] 阶段=开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInterruptPending = true;
			this.RunPhaseActions(this.StartActions);
			base.IsPressing = true;
			ILongPressInteractRestriction restriction = this.Restriction;
			if (restriction != null)
			{
				restriction.Press(this.RestrictionTriggerAction);
			}
			this.StopReverseTick();
			if (!this.ResetFromCurrentProgress)
			{
				this.AccumulatedTime = 0f;
				this.Progress = 0f;
			}
			this.LongPressTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnLongPressTick), 20f, 1f, null, null, true);
			if (this.CameraShakeAsset != null && this.CameraShakeAsset.IsValid() && this.CameraShakeInstanceId == null)
			{
				this.CameraShakeInstanceId = new int?(CameraController.Instance.PlayCameraShake(this.CameraShakeAsset, new float?(CameraController.Instance.MainModel.ShakeModify), null, null, true, true, "MainCamera"));
			}
			this.PlayLongPressingSound();
			this.PlayLongPressingForceFeedback();
			this.PlayLongPressingScreenEffect();
			this.PlayLongPressingEffects();
		}

		// Token: 0x06039722 RID: 235298 RVA: 0x00DA2439 File Offset: 0x00DA0639
		public override void OnRelease()
		{
			if (this.IsSuccessPending)
			{
				return;
			}
			if (this.ResetFromCurrentProgress)
			{
				this.StartReverse();
				return;
			}
			this.OnReset();
		}

		// Token: 0x06039723 RID: 235299 RVA: 0x00DA245C File Offset: 0x00DA065C
		private void StartReverse()
		{
			this.TryTriggerInterrupt();
			this.ReleaseRestriction();
			if (this.CameraShakeInstanceId != null)
			{
				CameraController.Instance.StopCameraShake(this.CameraShakeInstanceId.Value, false, "MainCamera");
				this.CameraShakeInstanceId = null;
			}
			this.StopLongPressTick();
			this.StopLongPressingSound();
			this.StopLongPressingForceFeedback();
			this.StopLongPressingScreenEffect();
			this.StopLongPressingEffects();
			if (this.Progress <= 0f || this.Duration <= 0f)
			{
				return;
			}
			if (this.ReverseTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.ReverseTimerId))
			{
				return;
			}
			this.ReverseTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnReverseTick), 20f, 1f, null, null, true);
		}

		// Token: 0x06039724 RID: 235300 RVA: 0x00DA2528 File Offset: 0x00DA0728
		private void OnReverseTick(float deltaTime)
		{
			this.AccumulatedTime = Math.Max(0f, this.AccumulatedTime - 20f);
			this.Progress = MathUtils.Instance.Clamp(this.AccumulatedTime / this.Duration, 0f, 1f);
			if (base.Entity != null)
			{
				EventSystem.Instance.EmitWithTarget<float>(base.Entity, EEventName.OnInteractionLongPressProgressChange, this.Progress);
			}
			if (this.Progress <= 0f)
			{
				this.StopReverseTick();
			}
		}

		// Token: 0x06039725 RID: 235301 RVA: 0x00DA25AF File Offset: 0x00DA07AF
		private void StopReverseTick()
		{
			if (this.ReverseTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.ReverseTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ReverseTimerId);
				this.ReverseTimerId = null;
			}
		}

		// Token: 0x06039726 RID: 235302 RVA: 0x00DA25E4 File Offset: 0x00DA07E4
		public override void OnReset()
		{
			this.IsSuccessPending = false;
			this.TryTriggerInterrupt();
			this.ReleaseRestriction();
			this.AccumulatedTime = 0f;
			this.Progress = 0f;
			if (base.Entity != null)
			{
				EventSystem.Instance.EmitWithTarget<float>(base.Entity, EEventName.OnInteractionLongPressProgressChange, 0f);
			}
			if (this.CameraShakeInstanceId != null)
			{
				CameraController.Instance.StopCameraShake(this.CameraShakeInstanceId.Value, false, "MainCamera");
				this.CameraShakeInstanceId = null;
			}
			this.StopLongPressTick();
			this.StopReverseTick();
			this.StopLongPressingSound();
			this.StopLongPressingForceFeedback();
			this.StopLongPressingScreenEffect();
			this.StopLongPressingEffects();
		}

		// Token: 0x06039727 RID: 235303 RVA: 0x00DA2698 File Offset: 0x00DA0898
		private bool IsTargetStillInInteractionList()
		{
			Entity entity = base.Entity;
			return entity != null && InteractionModel.Instance.GetInteractEntityIds().Contains(entity.Id);
		}

		// Token: 0x06039728 RID: 235304 RVA: 0x00DA26C8 File Offset: 0x00DA08C8
		private void OnLongPressTick(float deltaTime)
		{
			if (!base.IsPressing)
			{
				return;
			}
			float progress = this.Progress;
			this.AccumulatedTime += deltaTime;
			this.Progress = MathUtils.Instance.Clamp(this.AccumulatedTime / this.Duration, 0f, 1f);
			if (base.Entity != null)
			{
				EventSystem.Instance.EmitWithTarget<float>(base.Entity, EEventName.OnInteractionLongPressProgressChange, this.Progress);
			}
			this.TryTriggerProgressActions(progress, this.Progress);
			if (this.Progress >= 1f)
			{
				this.StopLongPressTick();
				this.IsSuccessPending = true;
				global::Log.Instance.Info(ELogModule.Interaction, ELogAuthor.WRY, "[LongPress] 阶段=等待完成校验", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06039729 RID: 235305 RVA: 0x00DA2784 File Offset: 0x00DA0984
		public void ResolvePendingSuccessAfterEntityUpdate()
		{
			if (!this.IsSuccessPending)
			{
				return;
			}
			if (!this.IsTargetStillInInteractionList())
			{
				base.Reset();
				return;
			}
			this.IsSuccessPending = false;
			this.IsInterruptPending = false;
			base.TriggerComplete();
			this.RunPhaseActions(this.SuccessActions);
			this.ReleaseRestriction();
			this.StopLongPressTick();
			if (this.CameraShakeInstanceId != null)
			{
				CameraController.Instance.StopCameraShake(this.CameraShakeInstanceId.Value, false, "MainCamera");
				this.CameraShakeInstanceId = null;
			}
			this.StopLongPressingSound();
			this.StopLongPressingForceFeedback();
			this.StopLongPressingScreenEffect();
			this.StopLongPressingEffects();
			this.PlayLongPressFinishedForceFeedback();
			global::Log.Instance.Info(ELogModule.Interaction, ELogAuthor.WRY, "[LongPress] 阶段=完成校验通过", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603972A RID: 235306 RVA: 0x00DA2848 File Offset: 0x00DA0A48
		private void TryTriggerProgressActions(float previousProgress, float currentProgress)
		{
			if (this.ProgressActions == null || this.ProgressActions.Count == 0)
			{
				return;
			}
			foreach (ILongPressProgressAction longPressProgressAction in this.ProgressActions)
			{
				float num = longPressProgressAction.Percentage / 100f;
				if (previousProgress < num && currentProgress >= num)
				{
					this.RunPhaseActions(longPressProgressAction.Actions);
				}
			}
		}

		// Token: 0x0603972B RID: 235307 RVA: 0x00DA28CC File Offset: 0x00DA0ACC
		private void RunPhaseActions([Nullable(new byte[]
		{
			2,
			1
		})] List<ActionInfo> actions)
		{
			if (actions == null || actions.Count == 0 || base.Entity == null)
			{
				return;
			}
			EntityContext entityContext = EntityContext.Create(base.Entity.Id, new GameCtxType?(GameCtxType.LongPressInteract));
			entityContext.AddSubParam(0, this.OptionIndex);
			LevelGeneralController.Instance.ExecuteActionsNew(actions, entityContext, null);
		}

		// Token: 0x0603972C RID: 235308 RVA: 0x00DA2924 File Offset: 0x00DA0B24
		private void TryTriggerInterrupt()
		{
			if (!this.IsInterruptPending)
			{
				return;
			}
			this.IsInterruptPending = false;
			global::Log.Instance.Info(ELogModule.Interaction, ELogAuthor.WRY, "[LongPress] 阶段=打断", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RunPhaseActions(this.InterruptedActions);
		}

		// Token: 0x0603972D RID: 235309 RVA: 0x00DA296C File Offset: 0x00DA0B6C
		private void ReleaseRestriction()
		{
			if (!base.IsPressing)
			{
				return;
			}
			base.IsPressing = false;
			ILongPressInteractRestriction restriction = this.Restriction;
			if (restriction == null)
			{
				return;
			}
			restriction.Release(this.RestrictionTriggerAction);
		}

		// Token: 0x0603972E RID: 235310 RVA: 0x00DA2994 File Offset: 0x00DA0B94
		private void StopLongPressTick()
		{
			if (this.LongPressTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.LongPressTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.LongPressTimerId);
				this.LongPressTimerId = null;
			}
		}

		// Token: 0x0603972F RID: 235311 RVA: 0x00DA29C8 File Offset: 0x00DA0BC8
		[NullableContext(0)]
		public override UniTask<bool> LoadAsset()
		{
			LongPressInteractionProcessor.<LoadAsset>d__52 <LoadAsset>d__;
			<LoadAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadAsset>d__.<>4__this = this;
			<LoadAsset>d__.<>1__state = -1;
			<LoadAsset>d__.<>t__builder.Start<LongPressInteractionProcessor.<LoadAsset>d__52>(ref <LoadAsset>d__);
			return <LoadAsset>d__.<>t__builder.Task;
		}

		// Token: 0x06039730 RID: 235312 RVA: 0x00DA2A0C File Offset: 0x00DA0C0C
		[NullableContext(0)]
		private UniTask<bool> LoadLongPressCameraShake([Nullable(1)] string bpPath)
		{
			LongPressInteractionProcessor.<LoadLongPressCameraShake>d__53 <LoadLongPressCameraShake>d__;
			<LoadLongPressCameraShake>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadLongPressCameraShake>d__.<>4__this = this;
			<LoadLongPressCameraShake>d__.bpPath = bpPath;
			<LoadLongPressCameraShake>d__.<>1__state = -1;
			<LoadLongPressCameraShake>d__.<>t__builder.Start<LongPressInteractionProcessor.<LoadLongPressCameraShake>d__53>(ref <LoadLongPressCameraShake>d__);
			return <LoadLongPressCameraShake>d__.<>t__builder.Task;
		}

		// Token: 0x06039731 RID: 235313 RVA: 0x00DA2A58 File Offset: 0x00DA0C58
		[NullableContext(1)]
		[return: Nullable(0)]
		private UniTask<bool> LoadForceFeedbackEffect(string effectPath, Action<UKuroForceFeedbackEffect> onLoaded, string errorMsg)
		{
			LongPressInteractionProcessor.<LoadForceFeedbackEffect>d__54 <LoadForceFeedbackEffect>d__;
			<LoadForceFeedbackEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadForceFeedbackEffect>d__.effectPath = effectPath;
			<LoadForceFeedbackEffect>d__.onLoaded = onLoaded;
			<LoadForceFeedbackEffect>d__.errorMsg = errorMsg;
			<LoadForceFeedbackEffect>d__.<>1__state = -1;
			<LoadForceFeedbackEffect>d__.<>t__builder.Start<LongPressInteractionProcessor.<LoadForceFeedbackEffect>d__54>(ref <LoadForceFeedbackEffect>d__);
			return <LoadForceFeedbackEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06039732 RID: 235314 RVA: 0x00DA2AAC File Offset: 0x00DA0CAC
		private void PlayLongPressingSound()
		{
			ILongPressEffectConfig pressEffect = this.PressEffect;
			string text = (pressEffect != null) ? pressEffect.LongPressSound : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			string text2 = AudioSystem.Instance.parseAudioEventPath(text);
			if (!string.IsNullOrEmpty(text2))
			{
				this.LongPressingSoundHandle = new int?(AudioSystem.Instance.PostEvent(text2));
			}
		}

		// Token: 0x06039733 RID: 235315 RVA: 0x00DA2B00 File Offset: 0x00DA0D00
		private void StopLongPressingSound()
		{
			if (this.LongPressingSoundHandle != null)
			{
				AudioSystem.Instance.ExecuteAction(this.LongPressingSoundHandle.Value, EAudioActionType.Stop, null);
				this.LongPressingSoundHandle = null;
			}
		}

		// Token: 0x06039734 RID: 235316 RVA: 0x00DA2B48 File Offset: 0x00DA0D48
		private void PlayLongPressingForceFeedback()
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (this.LongPressingFeedbackAsset != null && this.LongPressingFeedbackAsset.IsValid())
			{
				GamepadController.Instance.PlayKuroForceFeedback(this.LongPressingFeedbackAsset, null, true, false, false, "LongPressInteraction");
			}
		}

		// Token: 0x06039735 RID: 235317 RVA: 0x00DA2B98 File Offset: 0x00DA0D98
		private void StopLongPressingForceFeedback()
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (this.LongPressingFeedbackAsset != null && this.LongPressingFeedbackAsset.IsValid())
			{
				GamepadController.StopKuroForceFeedback(this.LongPressingFeedbackAsset, FNameUtil.NONE);
			}
		}

		// Token: 0x06039736 RID: 235318 RVA: 0x00DA2BCC File Offset: 0x00DA0DCC
		[NullableContext(0)]
		private UniTask<bool> PreloadLongPressingEffects()
		{
			LongPressInteractionProcessor.<PreloadLongPressingEffects>d__59 <PreloadLongPressingEffects>d__;
			<PreloadLongPressingEffects>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PreloadLongPressingEffects>d__.<>4__this = this;
			<PreloadLongPressingEffects>d__.<>1__state = -1;
			<PreloadLongPressingEffects>d__.<>t__builder.Start<LongPressInteractionProcessor.<PreloadLongPressingEffects>d__59>(ref <PreloadLongPressingEffects>d__);
			return <PreloadLongPressingEffects>d__.<>t__builder.Task;
		}

		// Token: 0x06039737 RID: 235319 RVA: 0x00DA2C10 File Offset: 0x00DA0E10
		[NullableContext(1)]
		private UniTask PreloadOneEffect(string path)
		{
			CustomPromise promise = new CustomPromise();
			ResourceSystem.Instance.LoadAsync<UEffectModelBase>(path, delegate([Nullable(2)] UEffectModelBase asset, string _)
			{
				if (asset != null && asset.IsValid())
				{
					this.PreloadedEffectAssets.Add(asset);
				}
				else
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Interaction;
					ELogAuthor author = ELogAuthor.WRY;
					string message = "[LongPressInteractionProcessor] 预加载特效DA失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", path);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				promise.SetResult();
			}, ResourceSystem.EResourceLoadPriority.Default, "js_undefined");
			return promise.Promise;
		}

		// Token: 0x06039738 RID: 235320 RVA: 0x00DA2C6C File Offset: 0x00DA0E6C
		[NullableContext(0)]
		private UniTask<bool> PreloadLongPressingScreenEffect([Nullable(1)] string path)
		{
			LongPressInteractionProcessor.<PreloadLongPressingScreenEffect>d__61 <PreloadLongPressingScreenEffect>d__;
			<PreloadLongPressingScreenEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PreloadLongPressingScreenEffect>d__.<>4__this = this;
			<PreloadLongPressingScreenEffect>d__.path = path;
			<PreloadLongPressingScreenEffect>d__.<>1__state = -1;
			<PreloadLongPressingScreenEffect>d__.<>t__builder.Start<LongPressInteractionProcessor.<PreloadLongPressingScreenEffect>d__61>(ref <PreloadLongPressingScreenEffect>d__);
			return <PreloadLongPressingScreenEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06039739 RID: 235321 RVA: 0x00DA2CB8 File Offset: 0x00DA0EB8
		private void PlayLongPressingScreenEffect()
		{
			ILongPressEffectConfig pressEffect = this.PressEffect;
			string text = (pressEffect != null) ? pressEffect.LongPressScreenEffect : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			EffectScreenPlayData_C preloadedScreenEffectAsset = this.PreloadedScreenEffectAsset;
			if (preloadedScreenEffectAsset == null || !preloadedScreenEffectAsset.IsValid())
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[LongPressInteractionProcessor] 屏幕特效资源未就绪，跳过播放";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ScreenEffect", text);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ScreenEffectModel instance2 = ScreenEffectModel.Instance;
			if (instance2 == null)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module2 = ELogModule.Interaction;
				ELogAuthor author2 = ELogAuthor.WRY;
				string message2 = "[LongPressInteractionProcessor] 屏幕特效未播放: ScreenEffectModel 不可用";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ScreenEffect", text);
				instance3.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.StopLongPressingScreenEffect();
			this.LongPressingScreenEffectHandle = new int?(instance2.PlayScreenEffect(text, null, null));
		}

		// Token: 0x0603973A RID: 235322 RVA: 0x00DA2D74 File Offset: 0x00DA0F74
		private void StopLongPressingScreenEffect()
		{
			if (this.LongPressingScreenEffectHandle == null)
			{
				return;
			}
			ScreenEffectModel instance = ScreenEffectModel.Instance;
			if (instance == null)
			{
				this.LongPressingScreenEffectHandle = null;
				return;
			}
			instance.EndScreenEffect(this.LongPressingScreenEffectHandle.Value);
			this.LongPressingScreenEffectHandle = null;
		}

		// Token: 0x0603973B RID: 235323 RVA: 0x00DA2DC4 File Offset: 0x00DA0FC4
		private void PlayLongPressingEffects()
		{
			ILongPressEffectConfig pressEffect = this.PressEffect;
			List<string> list = (pressEffect != null) ? pressEffect.PlayEffects : null;
			bool flag = (((list != null) ? new int?(list.Count) : null) ?? 0) == 0;
			if (flag)
			{
				return;
			}
			this.StopLongPressingEffects();
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				global::Log.Instance.Warn(ELogModule.Interaction, ELogAuthor.WRY, "[LongPressInteractionProcessor] 播放长按特效失败: 取不到玩家", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (string text in list)
			{
				if (!StringUtils.IsEmpty(text))
				{
					EffectSystem instance = EffectSystem.Instance;
					UObject world = GlobalData.World;
					FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
					int num = instance.SpawnEffect(world, ftransformDouble, text, "[LongPressInteractionProcessor] PlayEffects", new EffectContext(null, baseCharacter, false), global::EEffectType.Scene, null, null, null, false, false);
					if (EffectSystem.Instance.IsValid(num))
					{
						this.LongPressingEffectIds.Add(num);
						OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
						AActor parent = baseCharacter;
						FName? fname = null;
						effectActor.K2_AttachToActor(parent, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
					}
				}
			}
		}

		// Token: 0x0603973C RID: 235324 RVA: 0x00DA2F20 File Offset: 0x00DA1120
		private void StopLongPressingEffects()
		{
			if (this.LongPressingEffectIds.Count == 0)
			{
				return;
			}
			foreach (int num in this.LongPressingEffectIds)
			{
				if (EffectSystem.Instance.IsValid(num))
				{
					EffectSystem.Instance.StopEffectById(num, "[LongPressInteractionProcessor] StopEffects", false, null);
				}
			}
			this.LongPressingEffectIds.Clear();
		}

		// Token: 0x0603973D RID: 235325 RVA: 0x00DA2FB0 File Offset: 0x00DA11B0
		private void PlayLongPressFinishedForceFeedback()
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (this.LongPressFinishedFeedbackAsset != null && this.LongPressFinishedFeedbackAsset.IsValid())
			{
				GamepadController.Instance.PlayKuroForceFeedback(this.LongPressFinishedFeedbackAsset, null, false, false, false, "LongPressInteractionFinished");
			}
		}

		// Token: 0x0401E0A7 RID: 123047
		private float AccumulatedTime;

		// Token: 0x0401E0A8 RID: 123048
		private float Progress;

		// Token: 0x0401E0A9 RID: 123049
		private readonly int OptionIndex;

		// Token: 0x0401E0AA RID: 123050
		private readonly float Duration;

		// Token: 0x0401E0AB RID: 123051
		private readonly ILongPressEffectConfig PressEffect;

		// Token: 0x0401E0AC RID: 123052
		private readonly ELongPressInteractStyle? StyleTypeInternal;

		// Token: 0x0401E0AD RID: 123053
		private readonly string TidContentInternal;

		// Token: 0x0401E0AE RID: 123054
		private readonly float? StartProgressInternal;

		// Token: 0x0401E0AF RID: 123055
		private readonly bool ResetFromCurrentProgress;

		// Token: 0x0401E0B0 RID: 123056
		private UClass CameraShakeAsset;

		// Token: 0x0401E0B1 RID: 123057
		private int? CameraShakeInstanceId;

		// Token: 0x0401E0B2 RID: 123058
		private TimerHandle LongPressTimerId;

		// Token: 0x0401E0B3 RID: 123059
		private TimerHandle ReverseTimerId;

		// Token: 0x0401E0B4 RID: 123060
		private int? LongPressingSoundHandle;

		// Token: 0x0401E0B5 RID: 123061
		private UKuroForceFeedbackEffect LongPressingFeedbackAsset;

		// Token: 0x0401E0B6 RID: 123062
		private UKuroForceFeedbackEffect LongPressFinishedFeedbackAsset;

		// Token: 0x0401E0B7 RID: 123063
		[Nullable(1)]
		private readonly List<int> LongPressingEffectIds = new List<int>();

		// Token: 0x0401E0B8 RID: 123064
		private int? LongPressingScreenEffectHandle;

		// Token: 0x0401E0B9 RID: 123065
		private bool LongPressingEffectsReady;

		// Token: 0x0401E0BA RID: 123066
		[Nullable(1)]
		private readonly List<UEffectModelBase> PreloadedEffectAssets = new List<UEffectModelBase>();

		// Token: 0x0401E0BB RID: 123067
		private EffectScreenPlayData_C PreloadedScreenEffectAsset;

		// Token: 0x0401E0BC RID: 123068
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly List<ActionInfo> StartActions;

		// Token: 0x0401E0BD RID: 123069
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly List<ActionInfo> InterruptedActions;

		// Token: 0x0401E0BE RID: 123070
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly List<ActionInfo> SuccessActions;

		// Token: 0x0401E0BF RID: 123071
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly List<ILongPressProgressAction> ProgressActions;

		// Token: 0x0401E0C0 RID: 123072
		private bool IsInterruptPending;

		// Token: 0x0401E0C1 RID: 123073
		private bool IsSuccessPending;

		// Token: 0x0401E0C2 RID: 123074
		private EInputAction? RestrictionTriggerAction;

		// Token: 0x0401E0C3 RID: 123075
		private ILongPressInteractRestriction Restriction;
	}
}
