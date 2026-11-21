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
	// Token: 0x02003F0A RID: 16138
	[NullableContext(2)]
	[Nullable(0)]
	public class QtaPromptPlayer
	{
		// Token: 0x06028EC0 RID: 167616 RVA: 0x00B7C3DB File Offset: 0x00B7A5DB
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

		// Token: 0x06028EC1 RID: 167617 RVA: 0x00B7C41C File Offset: 0x00B7A61C
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

		// Token: 0x06028EC2 RID: 167618 RVA: 0x00B7C4FC File Offset: 0x00B7A6FC
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

		// Token: 0x06028EC3 RID: 167619 RVA: 0x00B7C54E File Offset: 0x00B7A74E
		public void PlayEffectByResult(EQtaResult resultType, int qtaHandle)
		{
			if (resultType == EQtaResult.Success)
			{
				this.PlayEffect(EQtaPromptType.结果成功提示, qtaHandle);
				return;
			}
			this.PlayEffect(EQtaPromptType.结果失败提示, qtaHandle);
		}

		// Token: 0x06028EC4 RID: 167620 RVA: 0x00B7C568 File Offset: 0x00B7A768
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

		// Token: 0x06028EC5 RID: 167621 RVA: 0x00B7C5E1 File Offset: 0x00B7A7E1
		public void StopEffect(int qtaHandle)
		{
			if (this.Context == null || qtaHandle != this.Context.HandleId)
			{
				return;
			}
			this.StopEffectInner();
		}

		// Token: 0x06028EC6 RID: 167622 RVA: 0x00B7C600 File Offset: 0x00B7A800
		private void StopEffectInner()
		{
			this.RemoveCueHandle();
			this.RemoveScreenEffect();
			this.RemoveCameraShake(false);
			this.StopGamepadShake();
			this.StopQtaAudio(this.LastAudioHandle, null);
			this.LastAudioHandle = 0;
		}

		// Token: 0x06028EC7 RID: 167623 RVA: 0x00B7C642 File Offset: 0x00B7A842
		public void RemoveEffect()
		{
			this.RemoveUiEffect();
			this.StopEffectInner();
		}

		// Token: 0x06028EC8 RID: 167624 RVA: 0x00B7C650 File Offset: 0x00B7A850
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

		// Token: 0x06028EC9 RID: 167625 RVA: 0x00B7C6F0 File Offset: 0x00B7A8F0
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

		// Token: 0x06028ECA RID: 167626 RVA: 0x00B7C76C File Offset: 0x00B7A96C
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

		// Token: 0x06028ECB RID: 167627 RVA: 0x00B7C928 File Offset: 0x00B7AB28
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

		// Token: 0x06028ECC RID: 167628 RVA: 0x00B7C9A4 File Offset: 0x00B7ABA4
		private bool IsPlayingScreenEffect()
		{
			return this.ScreenEffectInst != null || this.ScreenEffectHandle != -1;
		}

		// Token: 0x06028ECD RID: 167629 RVA: 0x00B7C9BC File Offset: 0x00B7ABBC
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

		// Token: 0x06028ECE RID: 167630 RVA: 0x00B7CA80 File Offset: 0x00B7AC80
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

		// Token: 0x06028ECF RID: 167631 RVA: 0x00B7CAD0 File Offset: 0x00B7ACD0
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

		// Token: 0x06028ED0 RID: 167632 RVA: 0x00B7CB38 File Offset: 0x00B7AD38
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

		// Token: 0x06028ED1 RID: 167633 RVA: 0x00B7CBA5 File Offset: 0x00B7ADA5
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

		// Token: 0x06028ED2 RID: 167634 RVA: 0x00B7CBD0 File Offset: 0x00B7ADD0
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

		// Token: 0x06028ED3 RID: 167635 RVA: 0x00B7CC50 File Offset: 0x00B7AE50
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

		// Token: 0x06028ED4 RID: 167636 RVA: 0x00B7CCA8 File Offset: 0x00B7AEA8
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

		// Token: 0x040163E9 RID: 91113
		private QtaContextBase Context;

		// Token: 0x040163EA RID: 91114
		private BaseGameplayCueComponent EntityCueComp;

		// Token: 0x040163EB RID: 91115
		private EffectScreenPlayData_C ScreenEffectInst;

		// Token: 0x040163EC RID: 91116
		private int ScreenEffectHandle = -1;

		// Token: 0x040163ED RID: 91117
		private TimerHandle ScreenEffectTimer;

		// Token: 0x040163EE RID: 91118
		private UMatineeCameraShake CameraShakeInst;

		// Token: 0x040163EF RID: 91119
		private TimerHandle CameraShakeTimer;

		// Token: 0x040163F0 RID: 91120
		private bool IsHideAllBattleUi;

		// Token: 0x040163F1 RID: 91121
		[Nullable(1)]
		private List<EBattleUiChild> HideBattleUiChildren = new List<EBattleUiChild>();

		// Token: 0x040163F2 RID: 91122
		private int LastAudioHandle;

		// Token: 0x040163F3 RID: 91123
		[Nullable(1)]
		private readonly List<int> CueHandleIds = new List<int>();

		// Token: 0x040163F4 RID: 91124
		private int LastGamepadShakePromptType;
	}
}
