using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004032 RID: 16434
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotAudioDelegate
	{
		// Token: 0x06029974 RID: 170356 RVA: 0x00BBEB52 File Offset: 0x00BBCD52
		[NullableContext(1)]
		public void Init(Action<float> callback)
		{
			this.Callback = callback;
		}

		// Token: 0x06029975 RID: 170357 RVA: 0x00BBEB5B File Offset: 0x00BBCD5B
		public void Clear()
		{
			this.Disable();
			this.Callback = null;
		}

		// Token: 0x06029976 RID: 170358 RVA: 0x00BBEB6A File Offset: 0x00BBCD6A
		public void Enable()
		{
			if (!this.AudioDelegateEnable)
			{
				this.AudioDelegate = DelegateUtils.ToManualReleaseDelegate<FOnAkPostEventCallback>(new Action<EAkCallbackType, UAkCallbackInfo>(this.AudioEventCallBack));
				this.AudioDelegateEnable = true;
			}
		}

		// Token: 0x06029977 RID: 170359 RVA: 0x00BBEB92 File Offset: 0x00BBCD92
		public void Disable()
		{
			if (this.AudioDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<EAkCallbackType, UAkCallbackInfo>(this.AudioEventCallBack));
				this.AudioDelegate = null;
			}
			this.AudioDelegateEnable = false;
		}

		// Token: 0x06029978 RID: 170360 RVA: 0x00BBEBBC File Offset: 0x00BBCDBC
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

		// Token: 0x04016B32 RID: 92978
		public FOnAkPostEventCallback AudioDelegate;

		// Token: 0x04016B33 RID: 92979
		public bool AudioDelegateEnable;

		// Token: 0x04016B34 RID: 92980
		public Action<float> Callback;
	}
}
