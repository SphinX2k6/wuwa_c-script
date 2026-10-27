using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005062 RID: 20578
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotAudioDelegate
	{
		// Token: 0x06034A81 RID: 215681 RVA: 0x00C7187A File Offset: 0x00C6FA7A
		[NullableContext(1)]
		public void Init(Action<float> callback)
		{
			this.Callback = callback;
		}

		// Token: 0x06034A82 RID: 215682 RVA: 0x00C71883 File Offset: 0x00C6FA83
		public void Clear()
		{
			this.Disable();
			this.Callback = null;
		}

		// Token: 0x06034A83 RID: 215683 RVA: 0x00C71892 File Offset: 0x00C6FA92
		public void Enable()
		{
			if (!this.AudioDelegateEnable)
			{
				this.AudioDelegate = DelegateUtils.ToManualReleaseDelegate<FOnAkPostEventCallback>(new Action<EAkCallbackType, UAkCallbackInfo>(this.AudioEventCallBack));
				this.AudioDelegateEnable = true;
			}
		}

		// Token: 0x06034A84 RID: 215684 RVA: 0x00C718BA File Offset: 0x00C6FABA
		public void Disable()
		{
			if (this.AudioDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<EAkCallbackType, UAkCallbackInfo>(this.AudioEventCallBack));
				this.AudioDelegate = null;
			}
			this.AudioDelegateEnable = false;
		}

		// Token: 0x06034A85 RID: 215685 RVA: 0x00C718E4 File Offset: 0x00C6FAE4
		private void AudioEventCallBack(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
		{
			if (!this.AudioDelegateEnable)
			{
				Log.Instance.Warn(ELogModule.Plot, ELogAuthor.CFT, "回调没移除成功", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (callbackType == EAkCallbackType.Duration)
			{
				UAkDurationCallbackInfo uakDurationCallbackInfo = callbackInfo as UAkDurationCallbackInfo;
				this.Callback(uakDurationCallbackInfo.Duration);
			}
		}

		// Token: 0x0401C107 RID: 114951
		public FOnAkPostEventCallback AudioDelegate;

		// Token: 0x0401C108 RID: 114952
		public bool AudioDelegateEnable;

		// Token: 0x0401C109 RID: 114953
		public Action<float> Callback;
	}
}
