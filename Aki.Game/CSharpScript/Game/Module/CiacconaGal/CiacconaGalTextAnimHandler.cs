using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BE1 RID: 23521
	[NullableContext(1)]
	[Nullable(0)]
	internal class CiacconaGalTextAnimHandler : ICiacconaGalTextAnimHandler, IStaticVariableResetter
	{
		// Token: 0x0603B74C RID: 243532 RVA: 0x00E2D40F File Offset: 0x00E2B60F
		static CiacconaGalTextAnimHandler()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CiacconaGalTextAnimHandler.CreateStaticDefaultValue), new Action(CiacconaGalTextAnimHandler.ResetStaticDefaultValue));
		}

		// Token: 0x0603B74D RID: 243533 RVA: 0x00E2D42E File Offset: 0x00E2B62E
		public static void CreateStaticDefaultValue()
		{
			CiacconaGalTextAnimHandler.AudioEventHandle = 0;
		}

		// Token: 0x0603B74E RID: 243534 RVA: 0x00E2D436 File Offset: 0x00E2B636
		public static void ResetStaticDefaultValue()
		{
			CiacconaGalTextAnimHandler.AudioEventHandle = 0;
		}

		// Token: 0x0603B74F RID: 243535 RVA: 0x00E2D43E File Offset: 0x00E2B63E
		public CiacconaGalTextAnimHandler(ULGUIPlayTweenComponent animCompInternal)
		{
			this.AnimCompInternal = animCompInternal;
		}

		// Token: 0x17008D63 RID: 36195
		// (get) Token: 0x0603B750 RID: 243536 RVA: 0x00E2D44D File Offset: 0x00E2B64D
		private ULGUIPlayTweenComponent AnimComp
		{
			get
			{
				if (this.AnimCompInternal == null || !this.AnimCompInternal.IsValid())
				{
					return null;
				}
				return this.AnimCompInternal;
			}
		}

		// Token: 0x0603B751 RID: 243537 RVA: 0x00E2D46C File Offset: 0x00E2B66C
		public void SetData(CiacconaGalStepData data)
		{
			this.Data = data;
		}

		// Token: 0x0603B752 RID: 243538 RVA: 0x00E2D478 File Offset: 0x00E2B678
		public void Play()
		{
			this.StopAudio();
			PlotAudio? config = ConfigPlotAudioById.GetConfig(this.Data.TalkTid, true);
			if (config == null)
			{
				this.PlayDefault();
				return;
			}
			string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(config.Value);
			string @event = "play_vo_caccona_gal";
			FTransformDouble? target = null;
			CiacconaGalTextAnimHandler.AudioEventHandle = AudioSystem.Instance.PostEvent(@event, target, new PostEventArgs?(new PostEventArgs
			{
				ExternalSourceName = "external_caccona_gal_voice",
				ExternalSourceMediaName = externalSourcesMediaName,
				CallbackMask = new ECallbackMask?(ECallbackMask.Duration),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (callbackType == EAkCallbackType.Duration)
					{
						float duration = ((UAkDurationCallbackInfo)callbackInfo).Duration;
						this.Duration = duration;
						ULGUIPlayTween_Float ulguiplayTween_Float = (ULGUIPlayTween_Float)this.AnimComp.GetPlayTween();
						float avgTextAnimShortenTime = CiacconaGalUtils.GetAvgTextAnimShortenTime();
						ulguiplayTween_Float.duration = Math.Max(duration / 1000f - avgTextAnimShortenTime, 1f);
						ulguiplayTween_Float.from = 0.9f;
						ulguiplayTween_Float.to = 0.05f;
						this.AnimComp.Play();
						this.StartTime = (float)Time.Instance.NowSeconds;
					}
				}
			}));
		}

		// Token: 0x0603B753 RID: 243539 RVA: 0x00E2D524 File Offset: 0x00E2B724
		private void PlayDefault()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CiacconaGal;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "剧情步骤没有语音配置，使用默认速率播放";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("StepId", this.Data.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			int textAnimDefaultDuration = this.Data.TextAnimDefaultDuration;
			this.Duration = (float)textAnimDefaultDuration;
			this.AnimComp.GetPlayTween().duration = (float)textAnimDefaultDuration;
			this.AnimComp.Play();
			this.StartTime = (float)TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0603B754 RID: 243540 RVA: 0x00E2D5AC File Offset: 0x00E2B7AC
		public void Stop()
		{
			this.StopAudio();
			ULGUIPlayTweenComponent animComp = this.AnimComp;
			if (animComp == null)
			{
				return;
			}
			ULGUIPlayTween playTween = animComp.GetPlayTween();
			if (playTween == null)
			{
				return;
			}
			ULTweener tweener = playTween.GetTweener();
			if (tweener == null)
			{
				return;
			}
			tweener.Kill(false);
		}

		// Token: 0x0603B755 RID: 243541 RVA: 0x00E2D5DC File Offset: 0x00E2B7DC
		public void Skip()
		{
			ULTweener tweener = this.AnimComp.GetPlayTween().GetTweener();
			if (tweener != null)
			{
				double num = Time.Instance.NowSeconds - (double)this.StartTime;
				double num2 = (double)this.Duration * TimeUtil.Instance.Millisecond - num;
				float avgSkippingTime = CiacconaGalUtils.GetAvgSkippingTime();
				float speed = tweener.GetSpeed();
				double num3 = Math.Max(num2 / (double)avgSkippingTime, 1.0);
				tweener.SetSpeed((float)((double)speed * num3));
			}
		}

		// Token: 0x0603B756 RID: 243542 RVA: 0x00E2D658 File Offset: 0x00E2B858
		private void StopAudio()
		{
			if (CiacconaGalTextAnimHandler.AudioEventHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(CiacconaGalTextAnimHandler.AudioEventHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(500)
				}));
				CiacconaGalTextAnimHandler.AudioEventHandle = 0;
			}
		}

		// Token: 0x0401EFA0 RID: 126880
		private CiacconaGalStepData Data;

		// Token: 0x0401EFA1 RID: 126881
		private static int AudioEventHandle;

		// Token: 0x0401EFA2 RID: 126882
		private float Duration;

		// Token: 0x0401EFA3 RID: 126883
		private float StartTime;

		// Token: 0x0401EFA4 RID: 126884
		private ULGUIPlayTweenComponent AnimCompInternal;
	}
}
