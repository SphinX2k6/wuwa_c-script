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
	// Token: 0x02004820 RID: 18464
	[NullableContext(2)]
	[Nullable(0)]
	public class LongPressInteractionProcessor : InteractionProcessor
	{
		// Token: 0x17005E11 RID: 24081
		// (get) Token: 0x0602E632 RID: 190002 RVA: 0x00CF0DE9 File Offset: 0x00CEEFE9
		public ELongPressInteractStyle? StyleType
		{
			get
			{
				return this.StyleTypeInternal;
			}
		}

		// Token: 0x17005E12 RID: 24082
		// (get) Token: 0x0602E633 RID: 190003 RVA: 0x00CF0DF1 File Offset: 0x00CEEFF1
		public string TidContent
		{
			get
			{
				return this.TidContentInternal;
			}
		}

		// Token: 0x17005E13 RID: 24083
		// (get) Token: 0x0602E634 RID: 190004 RVA: 0x00CF0DF9 File Offset: 0x00CEEFF9
		public float? StartProgress
		{
			get
			{
				return this.StartProgressInternal;
			}
		}

		// Token: 0x0602E635 RID: 190005 RVA: 0x00CF0E04 File Offset: 0x00CEF004
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

		// Token: 0x0602E636 RID: 190006 RVA: 0x00CF0E74 File Offset: 0x00CEF074
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

		// Token: 0x0602E637 RID: 190007 RVA: 0x00CF0EB0 File Offset: 0x00CEF0B0
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

		// Token: 0x0602E638 RID: 190008 RVA: 0x00CF0FCC File Offset: 0x00CEF1CC
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

		// Token: 0x0602E639 RID: 190009 RVA: 0x00CF1111 File Offset: 0x00CEF311
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

		// Token: 0x0602E63A RID: 190010 RVA: 0x00CF1134 File Offset: 0x00CEF334
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

		// Token: 0x0602E63B RID: 190011 RVA: 0x00CF1200 File Offset: 0x00CEF400
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

		// Token: 0x0602E63C RID: 190012 RVA: 0x00CF1287 File Offset: 0x00CEF487
		private void StopReverseTick()
		{
			if (this.ReverseTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.ReverseTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ReverseTimerId);
				this.ReverseTimerId = null;
			}
		}

		// Token: 0x0602E63D RID: 190013 RVA: 0x00CF12BC File Offset: 0x00CEF4BC
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

		// Token: 0x0602E63E RID: 190014 RVA: 0x00CF1370 File Offset: 0x00CEF570
		private bool IsTargetStillInInteractionList()
		{
			Entity entity = base.Entity;
			return entity != null && InteractionModel.Instance.GetInteractEntityIds().Contains(entity.Id);
		}

		// Token: 0x0602E63F RID: 190015 RVA: 0x00CF13A0 File Offset: 0x00CEF5A0
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

		// Token: 0x0602E640 RID: 190016 RVA: 0x00CF145C File Offset: 0x00CEF65C
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

		// Token: 0x0602E641 RID: 190017 RVA: 0x00CF1520 File Offset: 0x00CEF720
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

		// Token: 0x0602E642 RID: 190018 RVA: 0x00CF15A4 File Offset: 0x00CEF7A4
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

		// Token: 0x0602E643 RID: 190019 RVA: 0x00CF15FC File Offset: 0x00CEF7FC
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

		// Token: 0x0602E644 RID: 190020 RVA: 0x00CF1644 File Offset: 0x00CEF844
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

		// Token: 0x0602E645 RID: 190021 RVA: 0x00CF166C File Offset: 0x00CEF86C
		private void StopLongPressTick()
		{
			if (this.LongPressTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.LongPressTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.LongPressTimerId);
				this.LongPressTimerId = null;
			}
		}

		// Token: 0x0602E646 RID: 190022 RVA: 0x00CF16A0 File Offset: 0x00CEF8A0
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

		// Token: 0x0602E647 RID: 190023 RVA: 0x00CF16E4 File Offset: 0x00CEF8E4
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

		// Token: 0x0602E648 RID: 190024 RVA: 0x00CF1730 File Offset: 0x00CEF930
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

		// Token: 0x0602E649 RID: 190025 RVA: 0x00CF1784 File Offset: 0x00CEF984
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

		// Token: 0x0602E64A RID: 190026 RVA: 0x00CF17D8 File Offset: 0x00CEF9D8
		private void StopLongPressingSound()
		{
			if (this.LongPressingSoundHandle != null)
			{
				AudioSystem.Instance.ExecuteAction(this.LongPressingSoundHandle.Value, EAudioActionType.Stop, null);
				this.LongPressingSoundHandle = null;
			}
		}

		// Token: 0x0602E64B RID: 190027 RVA: 0x00CF1820 File Offset: 0x00CEFA20
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

		// Token: 0x0602E64C RID: 190028 RVA: 0x00CF1870 File Offset: 0x00CEFA70
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

		// Token: 0x0602E64D RID: 190029 RVA: 0x00CF18A4 File Offset: 0x00CEFAA4
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

		// Token: 0x0602E64E RID: 190030 RVA: 0x00CF18E8 File Offset: 0x00CEFAE8
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

		// Token: 0x0602E64F RID: 190031 RVA: 0x00CF1944 File Offset: 0x00CEFB44
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

		// Token: 0x0602E650 RID: 190032 RVA: 0x00CF1990 File Offset: 0x00CEFB90
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

		// Token: 0x0602E651 RID: 190033 RVA: 0x00CF1A4C File Offset: 0x00CEFC4C
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

		// Token: 0x0602E652 RID: 190034 RVA: 0x00CF1A9C File Offset: 0x00CEFC9C
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

		// Token: 0x0602E653 RID: 190035 RVA: 0x00CF1BF8 File Offset: 0x00CEFDF8
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

		// Token: 0x0602E654 RID: 190036 RVA: 0x00CF1C88 File Offset: 0x00CEFE88
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

		// Token: 0x04018B43 RID: 101187
		private float AccumulatedTime;

		// Token: 0x04018B44 RID: 101188
		private float Progress;

		// Token: 0x04018B45 RID: 101189
		private readonly int OptionIndex;

		// Token: 0x04018B46 RID: 101190
		private readonly float Duration;

		// Token: 0x04018B47 RID: 101191
		private readonly ILongPressEffectConfig PressEffect;

		// Token: 0x04018B48 RID: 101192
		private readonly ELongPressInteractStyle? StyleTypeInternal;

		// Token: 0x04018B49 RID: 101193
		private readonly string TidContentInternal;

		// Token: 0x04018B4A RID: 101194
		private readonly float? StartProgressInternal;

		// Token: 0x04018B4B RID: 101195
		private readonly bool ResetFromCurrentProgress;

		// Token: 0x04018B4C RID: 101196
		private UClass CameraShakeAsset;

		// Token: 0x04018B4D RID: 101197
		private int? CameraShakeInstanceId;

		// Token: 0x04018B4E RID: 101198
		private TimerHandle LongPressTimerId;

		// Token: 0x04018B4F RID: 101199
		private TimerHandle ReverseTimerId;

		// Token: 0x04018B50 RID: 101200
		private int? LongPressingSoundHandle;

		// Token: 0x04018B51 RID: 101201
		private UKuroForceFeedbackEffect LongPressingFeedbackAsset;

		// Token: 0x04018B52 RID: 101202
		private UKuroForceFeedbackEffect LongPressFinishedFeedbackAsset;

		// Token: 0x04018B53 RID: 101203
		[Nullable(1)]
		private readonly List<int> LongPressingEffectIds = new List<int>();

		// Token: 0x04018B54 RID: 101204
		private int? LongPressingScreenEffectHandle;

		// Token: 0x04018B55 RID: 101205
		private bool LongPressingEffectsReady;

		// Token: 0x04018B56 RID: 101206
		[Nullable(1)]
		private readonly List<UEffectModelBase> PreloadedEffectAssets = new List<UEffectModelBase>();

		// Token: 0x04018B57 RID: 101207
		private EffectScreenPlayData_C PreloadedScreenEffectAsset;

		// Token: 0x04018B58 RID: 101208
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly List<ActionInfo> StartActions;

		// Token: 0x04018B59 RID: 101209
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly List<ActionInfo> InterruptedActions;

		// Token: 0x04018B5A RID: 101210
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly List<ActionInfo> SuccessActions;

		// Token: 0x04018B5B RID: 101211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly List<ILongPressProgressAction> ProgressActions;

		// Token: 0x04018B5C RID: 101212
		private bool IsInterruptPending;

		// Token: 0x04018B5D RID: 101213
		private bool IsSuccessPending;

		// Token: 0x04018B5E RID: 101214
		private EInputAction? RestrictionTriggerAction;

		// Token: 0x04018B5F RID: 101215
		private ILongPressInteractRestriction Restriction;
	}
}
