using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Core.Common;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Module.QuickTimeAction.Context;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02004F41 RID: 20289
	[NullableContext(2)]
	[Nullable(0)]
	public class QtaPromptPlayer
	{
		// Token: 0x06034052 RID: 213074 RVA: 0x00C32C3B File Offset: 0x00C30E3B
		[NullableContext(1)]
		public void SetQtaContext(QtaContextBase context)
		{
			this.Context = context;
			IQtaExtraParams extraParams = context.ExtraParams;
			if (((extraParams != null) ? extraParams.EntityHandle : null) != null)
			{
				WorldEntity entity = context.ExtraParams.EntityHandle.Entity;
				this.EntityCueComp = ((entity != null) ? entity.GetComponent<BaseGameplayCueComponent>() : null);
			}
		}

		// Token: 0x06034053 RID: 213075 RVA: 0x00C32C7C File Offset: 0x00C30E7C
		[NullableContext(1)]
		public void StartUiEffect(SQtaBase config)
		{
			if (Info.Instance.OperationType == EOperationType.Pad)
			{
				if (config.HideAllBattleUiInMobile)
				{
					this.IsHideAllBattleUi = true;
					BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.PanelQta, new List<EBattleUiChild>
					{
						EBattleUiChild.PanelQta
					}, 0);
					return;
				}
			}
			else if (config.HideAllBattleUi)
			{
				this.IsHideAllBattleUi = true;
				BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.PanelQta, new List<EBattleUiChild>
				{
					EBattleUiChild.PanelQta
				}, 0);
				return;
			}
			this.IsHideAllBattleUi = false;
			int num = config.HideUiElement.Num();
			if (num > 0)
			{
				List<EBattleUiChild> list = new List<EBattleUiChild>();
				for (int i = 0; i < num; i++)
				{
					list.Add((EBattleUiChild)config.HideUiElement.Get(i));
				}
				BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.PanelQta, list, false, true, 0);
				this.HideBattleUiChildren = list;
				return;
			}
			this.HideBattleUiChildren.Clear();
		}

		// Token: 0x06034054 RID: 213076 RVA: 0x00C32D5C File Offset: 0x00C30F5C
		public void RemoveUiEffect()
		{
			if (this.IsHideAllBattleUi)
			{
				BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.PanelQta, 0);
				this.IsHideAllBattleUi = false;
				return;
			}
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.PanelQta, this.HideBattleUiChildren, true, true, 0);
			this.HideBattleUiChildren.Clear();
		}

		// Token: 0x06034055 RID: 213077 RVA: 0x00C32DAE File Offset: 0x00C30FAE
		public void PlayEffectByResult(EQtaResult resultType, int qtaHandle)
		{
			if (resultType == EQtaResult.Success)
			{
				this.PlayEffect(EQtaPromptType.结果成功提示, qtaHandle);
				return;
			}
			this.PlayEffect(EQtaPromptType.结果失败提示, qtaHandle);
		}

		// Token: 0x06034056 RID: 213078 RVA: 0x00C32DC8 File Offset: 0x00C30FC8
		public void PlayEffect(EQtaPromptType promptType, int qtaHandle)
		{
			if (this.Context == null || qtaHandle != this.Context.HandleId)
			{
				return;
			}
			if (this.Context.GetPromptResource(promptType) == null)
			{
				return;
			}
			this.StopEffect(qtaHandle);
			this.PlayCue(promptType);
			this.PlayScreenEffect(promptType);
			this.PlayCameraShake(promptType);
			this.PlayGamepadShake(promptType);
			this.StopQtaAudio(this.LastAudioHandle, null);
			this.LastAudioHandle = this.PlayQtaAudio(promptType, null);
		}

		// Token: 0x06034057 RID: 213079 RVA: 0x00C32E41 File Offset: 0x00C31041
		public void StopEffect(int qtaHandle)
		{
			if (this.Context == null || qtaHandle != this.Context.HandleId)
			{
				return;
			}
			this.StopEffectInner();
		}

		// Token: 0x06034058 RID: 213080 RVA: 0x00C32E60 File Offset: 0x00C31060
		private void StopEffectInner()
		{
			this.RemoveCueHandle();
			this.RemoveScreenEffect();
			this.RemoveCameraShake(false);
			this.StopGamepadShake();
			this.StopQtaAudio(this.LastAudioHandle, null);
			this.LastAudioHandle = 0;
		}

		// Token: 0x06034059 RID: 213081 RVA: 0x00C32EA2 File Offset: 0x00C310A2
		public void RemoveEffect()
		{
			this.RemoveUiEffect();
			this.StopEffectInner();
		}

		// Token: 0x0603405A RID: 213082 RVA: 0x00C32EB0 File Offset: 0x00C310B0
		private void PlayCue(EQtaPromptType promptType)
		{
			if (this.EntityCueComp == null)
			{
				return;
			}
			this.RemoveCueHandle();
			IQtaPromptResource promptResource = this.Context.GetPromptResource(promptType);
			List<long> list = (promptResource != null) ? promptResource.CueIds : null;
			if (list != null && list.Count > 0)
			{
				foreach (long cueId in list)
				{
					int item = this.EntityCueComp.AddCue(cueId, null);
					this.CueHandleIds.Add(item);
				}
			}
		}

		// Token: 0x0603405B RID: 213083 RVA: 0x00C32F50 File Offset: 0x00C31150
		private void RemoveCueHandle()
		{
			if (this.EntityCueComp != null && this.CueHandleIds.Count > 0)
			{
				foreach (int num in this.CueHandleIds)
				{
					this.EntityCueComp.RemoveCueByHandle((long)num);
				}
				this.CueHandleIds.Clear();
			}
		}

		// Token: 0x0603405C RID: 213084 RVA: 0x00C32FCC File Offset: 0x00C311CC
		private void PlayScreenEffect(EQtaPromptType promptType)
		{
			QtaPromptPlayer.<>c__DisplayClass21_0 CS$<>8__locals1 = new QtaPromptPlayer.<>c__DisplayClass21_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.Context == null)
			{
				return;
			}
			if (this.IsPlayingScreenEffect())
			{
				return;
			}
			QtaPromptPlayer.<>c__DisplayClass21_0 CS$<>8__locals2 = CS$<>8__locals1;
			IQtaPromptResource promptResource = this.Context.GetPromptResource(promptType);
			CS$<>8__locals2.screenEffect = ((promptResource != null) ? promptResource.ScreenEffect1 : null);
			if (CS$<>8__locals1.screenEffect != null)
			{
				this.ScreenEffectInst = CS$<>8__locals1.screenEffect;
				ScreenEffectSystem.GetInstance().PlayScreenEffect(CS$<>8__locals1.screenEffect);
				if (CS$<>8__locals1.screenEffect.Loop == 0f)
				{
					float currentValue = (CS$<>8__locals1.screenEffect.Start + CS$<>8__locals1.screenEffect.End) * (float)TimeUtil.Instance.InverseMillisecond;
					this.ScreenEffectTimer = TimerSystem.Instance.Delay(delegate(float _)
					{
						ScreenEffectSystem.GetInstance().EndScreenEffect(CS$<>8__locals1.screenEffect);
						CS$<>8__locals1.<>4__this.ScreenEffectInst = null;
						CS$<>8__locals1.<>4__this.ScreenEffectTimer = null;
					}, MathUtils.Instance.Clamp(currentValue, 20f, 180000f), null, null, true, 1f);
				}
			}
			IQtaPromptResource promptResource2 = this.Context.GetPromptResource(promptType);
			EffectModelPostProcess effectModelPostProcess = (promptResource2 != null) ? promptResource2.ScreenEffect2 : null;
			if (effectModelPostProcess != null)
			{
				IQtaPromptResource promptResource3 = this.Context.GetPromptResource(promptType);
				string text = (promptResource3 != null) ? promptResource3.ScreenEffect2Path : null;
				if (!string.IsNullOrEmpty(text))
				{
					EffectSystem instance = EffectSystem.Instance;
					UObject world = GlobalData.World;
					FTransformDouble? ftransformDouble = new FTransformDouble?(Transform.Create().ToUeTransform());
					this.ScreenEffectHandle = instance.SpawnEffect(world, ftransformDouble, text, "[QtaController.PlayScreenEffect]", null, EEffectType.Scene, null, null, null, false, false);
					if (effectModelPostProcess.LoopTime == 0f)
					{
						float currentValue2 = (effectModelPostProcess.StartTime + effectModelPostProcess.EndTime) * (float)TimeUtil.Instance.InverseMillisecond;
						this.ScreenEffectTimer = TimerSystem.Instance.Delay(delegate(float _)
						{
							EffectSystem.Instance.StopEffectById(CS$<>8__locals1.<>4__this.ScreenEffectHandle, "[QtaController.ScreenEffectTimer]", true, null);
							CS$<>8__locals1.<>4__this.ScreenEffectHandle = -1;
							CS$<>8__locals1.<>4__this.ScreenEffectTimer = null;
						}, MathUtils.Instance.Clamp(currentValue2, 20f, 180000f), null, null, true, 1f);
					}
				}
			}
		}

		// Token: 0x0603405D RID: 213085 RVA: 0x00C33188 File Offset: 0x00C31388
		private void RemoveScreenEffect()
		{
			if (this.ScreenEffectTimer != null)
			{
				TimerSystem.Instance.Remove(this.ScreenEffectTimer);
				this.ScreenEffectTimer = null;
			}
			if (this.ScreenEffectInst != null)
			{
				ScreenEffectSystem.GetInstance().EndScreenEffect(this.ScreenEffectInst);
				this.ScreenEffectInst = null;
			}
			if (this.ScreenEffectHandle != -1)
			{
				EffectSystem.Instance.StopEffectById(this.ScreenEffectHandle, "[QtaController.RemoveScreenEffect]", true, null);
				this.ScreenEffectHandle = -1;
			}
		}

		// Token: 0x0603405E RID: 213086 RVA: 0x00C33204 File Offset: 0x00C31404
		private bool IsPlayingScreenEffect()
		{
			return this.ScreenEffectInst != null || this.ScreenEffectHandle != -1;
		}

		// Token: 0x0603405F RID: 213087 RVA: 0x00C3321C File Offset: 0x00C3141C
		private void PlayCameraShake(EQtaPromptType promptType)
		{
			if (this.Context == null)
			{
				return;
			}
			if (this.CameraShakeInst != null)
			{
				return;
			}
			IQtaPromptResource promptResource = this.Context.GetPromptResource(promptType);
			UClass uclass = (promptResource != null) ? promptResource.CameraShake : null;
			if (uclass != null)
			{
				this.CameraShakeInst = Global.CharacterCameraManager.StartMatineeCameraShake(uclass, 1f, ECameraShakePlaySpace.CameraLocal, default(FRotator), 1f);
				if (this.CameraShakeInst != null)
				{
					float currentValue = this.CameraShakeInst.OscillatorTimeRemaining * (float)TimeUtil.Instance.InverseMillisecond;
					this.CameraShakeTimer = TimerSystem.Instance.Delay(delegate(float _)
					{
						Global.CharacterCameraManager.StopCameraShake(this.CameraShakeInst, false);
						this.CameraShakeInst = null;
						this.CameraShakeTimer = null;
					}, MathUtils.Instance.Clamp(currentValue, 20f, 180000f), null, null, true, 1f);
				}
			}
		}

		// Token: 0x06034060 RID: 213088 RVA: 0x00C332E0 File Offset: 0x00C314E0
		private void RemoveCameraShake(bool immediately = true)
		{
			if (this.CameraShakeTimer != null)
			{
				TimerSystem.Instance.Remove(this.CameraShakeTimer);
				this.CameraShakeTimer = null;
			}
			if (this.CameraShakeInst != null)
			{
				Global.CharacterCameraManager.StopCameraShake(this.CameraShakeInst, immediately);
				this.CameraShakeInst = null;
			}
		}

		// Token: 0x06034061 RID: 213089 RVA: 0x00C33330 File Offset: 0x00C31530
		private void PlayGamepadShake(EQtaPromptType promptType)
		{
			if (this.Context == null)
			{
				return;
			}
			IQtaPromptResource promptResource = this.Context.GetPromptResource(promptType);
			UKuroForceFeedbackEffect ukuroForceFeedbackEffect = (promptResource != null) ? promptResource.GamepadShake : null;
			if (ukuroForceFeedbackEffect == null || this.Context.Type == null)
			{
				return;
			}
			this.LastGamepadShakePromptType = (int)promptType;
			GamepadController.Instance.TriggerGamepadShakeByQte((ECommonQteContextType)this.Context.Type.Value, ukuroForceFeedbackEffect);
		}

		// Token: 0x06034062 RID: 213090 RVA: 0x00C33398 File Offset: 0x00C31598
		private void StopGamepadShake()
		{
			if (this.Context == null)
			{
				return;
			}
			IQtaPromptResource promptResource = this.Context.GetPromptResource((EQtaPromptType)this.LastGamepadShakePromptType);
			UKuroForceFeedbackEffect ukuroForceFeedbackEffect = (promptResource != null) ? promptResource.GamepadShake : null;
			this.LastGamepadShakePromptType = 0;
			if (ukuroForceFeedbackEffect == null || this.Context.Type == null)
			{
				return;
			}
			GamepadController.Instance.StopQteGamepadShake((ECommonQteContextType)this.Context.Type.Value, ukuroForceFeedbackEffect);
		}

		// Token: 0x06034063 RID: 213091 RVA: 0x00C33405 File Offset: 0x00C31605
		public int PlayQtaAudio(EQtaPromptType promptType, AActor actor = null)
		{
			QtaContextBase context = this.Context;
			string audioEvent;
			if (context == null)
			{
				audioEvent = null;
			}
			else
			{
				IQtaPromptResource promptResource = context.GetPromptResource(promptType);
				audioEvent = ((promptResource != null) ? promptResource.Audio : null);
			}
			return this.PlayQtaAudioWithPath(audioEvent, actor);
		}

		// Token: 0x06034064 RID: 213092 RVA: 0x00C33430 File Offset: 0x00C31630
		private int PlayQtaAudioWithPath(string audioEvent, AActor actor = null)
		{
			if (string.IsNullOrEmpty(audioEvent))
			{
				return 0;
			}
			string text = AudioSystem.Instance.parseAudioEventPath(audioEvent);
			if (string.IsNullOrEmpty(text))
			{
				QtaContextBase context = this.Context;
				string message = "PlayQtaAudioWithPath 缺少有效路径";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("", audioEvent ?? string.Empty);
				QtaLog.Info(context, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			if (actor != null)
			{
				return AudioSystem.Instance.PostEvent(text, actor, null);
			}
			return AudioSystem.Instance.PostEvent(text);
		}

		// Token: 0x06034065 RID: 213093 RVA: 0x00C334B0 File Offset: 0x00C316B0
		[NullableContext(1)]
		public void SeekQtaAudio(int position, string audioEvent, [Nullable(2)] AActor actor = null, int? handle = null)
		{
			if (string.IsNullOrEmpty(audioEvent))
			{
				return;
			}
			string text = AudioSystem.Instance.parseAudioEventPath(audioEvent);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			AudioSystem.Instance.SeekOnEvent(text, position, new SeekOnEventArgs?(new SeekOnEventArgs
			{
				Actor = actor,
				Handle = handle
			}));
		}

		// Token: 0x06034066 RID: 213094 RVA: 0x00C33508 File Offset: 0x00C31708
		public void StopQtaAudio(int handle, int? blendOutTime = null)
		{
			if (handle == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(blendOutTime.GetValueOrDefault())
			}));
		}

		// Token: 0x0401BA14 RID: 113172
		private QtaContextBase Context;

		// Token: 0x0401BA15 RID: 113173
		private BaseGameplayCueComponent EntityCueComp;

		// Token: 0x0401BA16 RID: 113174
		private EffectScreenPlayData_C ScreenEffectInst;

		// Token: 0x0401BA17 RID: 113175
		private int ScreenEffectHandle = -1;

		// Token: 0x0401BA18 RID: 113176
		private TimerHandle ScreenEffectTimer;

		// Token: 0x0401BA19 RID: 113177
		private UMatineeCameraShake CameraShakeInst;

		// Token: 0x0401BA1A RID: 113178
		private TimerHandle CameraShakeTimer;

		// Token: 0x0401BA1B RID: 113179
		private bool IsHideAllBattleUi;

		// Token: 0x0401BA1C RID: 113180
		[Nullable(1)]
		private List<EBattleUiChild> HideBattleUiChildren = new List<EBattleUiChild>();

		// Token: 0x0401BA1D RID: 113181
		private int LastAudioHandle;

		// Token: 0x0401BA1E RID: 113182
		[Nullable(1)]
		private readonly List<int> CueHandleIds = new List<int>();

		// Token: 0x0401BA1F RID: 113183
		private int LastGamepadShakePromptType;
	}
}
