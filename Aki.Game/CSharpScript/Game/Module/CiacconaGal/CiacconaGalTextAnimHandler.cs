using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BC1 RID: 19393
	[NullableContext(1)]
	[Nullable(0)]
	internal class CiacconaGalTextAnimHandler : ICiacconaGalTextAnimHandler, IStaticVariableResetter
	{
		// Token: 0x06030697 RID: 198295 RVA: 0x00D7D717 File Offset: 0x00D7B917
		static CiacconaGalTextAnimHandler()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CiacconaGalTextAnimHandler.CreateStaticDefaultValue), new Action(CiacconaGalTextAnimHandler.ResetStaticDefaultValue));
		}

		// Token: 0x06030698 RID: 198296 RVA: 0x00D7D736 File Offset: 0x00D7B936
		public static void CreateStaticDefaultValue()
		{
			CiacconaGalTextAnimHandler.AudioEventHandle = 0;
		}

		// Token: 0x06030699 RID: 198297 RVA: 0x00D7D73E File Offset: 0x00D7B93E
		public static void ResetStaticDefaultValue()
		{
			CiacconaGalTextAnimHandler.AudioEventHandle = 0;
		}

		// Token: 0x0603069A RID: 198298 RVA: 0x00D7D746 File Offset: 0x00D7B946
		public CiacconaGalTextAnimHandler(ULGUIPlayTweenComponent animCompInternal)
		{
			this.AnimCompInternal = animCompInternal;
		}

		// Token: 0x17006135 RID: 24885
		// (get) Token: 0x0603069B RID: 198299 RVA: 0x00D7D755 File Offset: 0x00D7B955
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

		// Token: 0x0603069C RID: 198300 RVA: 0x00D7D774 File Offset: 0x00D7B974
		public void SetData(CiacconaGalStepData data)
		{
			this.Data = data;
		}

		// Token: 0x0603069D RID: 198301 RVA: 0x00D7D780 File Offset: 0x00D7B980
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

		// Token: 0x0603069E RID: 198302 RVA: 0x00D7D82C File Offset: 0x00D7BA2C
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

		// Token: 0x0603069F RID: 198303 RVA: 0x00D7D8B4 File Offset: 0x00D7BAB4
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

		// Token: 0x060306A0 RID: 198304 RVA: 0x00D7D8E4 File Offset: 0x00D7BAE4
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

		// Token: 0x060306A1 RID: 198305 RVA: 0x00D7D960 File Offset: 0x00D7BB60
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

		// Token: 0x04019A51 RID: 105041
		private CiacconaGalStepData Data;

		// Token: 0x04019A52 RID: 105042
		private static int AudioEventHandle;

		// Token: 0x04019A53 RID: 105043
		private float Duration;

		// Token: 0x04019A54 RID: 105044
		private float StartTime;

		// Token: 0x04019A55 RID: 105045
		private ULGUIPlayTweenComponent AnimCompInternal;
	}
}
