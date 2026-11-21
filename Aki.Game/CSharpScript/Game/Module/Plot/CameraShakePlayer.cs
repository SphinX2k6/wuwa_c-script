using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FA0 RID: 16288
	public class CameraShakePlayer
	{
		// Token: 0x06029348 RID: 168776 RVA: 0x00B92104 File Offset: 0x00B90304
		[NullableContext(1)]
		public void Play(IFlowCameraShake param)
		{
			if (this.IsPlaying)
			{
				this.Stop();
			}
			this.IsPlaying = true;
			this.LoadingId = ResourceSystem.Instance.LoadAsync<UClass>(param.CameraShakeBp + "_C", delegate([Nullable(2)] UClass csClass, string _)
			{
				this.LoadingId = -1;
				if (csClass == null || !csClass.IsValid())
				{
					return;
				}
				this.CameraShake = Global.CharacterCameraManager.StartMatineeCameraShake(csClass, 1f, ECameraShakePlaySpace.CameraLocal, default(FRotator), 1f);
			}, 100, "js_undefined");
		}

		// Token: 0x06029349 RID: 168777 RVA: 0x00B9215C File Offset: 0x00B9035C
		public void Stop()
		{
			if (!this.IsPlaying)
			{
				return;
			}
			this.IsPlaying = false;
			if (this.LoadingId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadingId);
				this.LoadingId = -1;
			}
			if (this.CameraShake != null)
			{
				Global.CharacterCameraManager.StopCameraShake(this.CameraShake, true);
				this.CameraShake = null;
			}
		}

		// Token: 0x040166EA RID: 91882
		private int LoadingId = -1;

		// Token: 0x040166EB RID: 91883
		[Nullable(2)]
		private UMatineeCameraShake CameraShake;

		// Token: 0x040166EC RID: 91884
		private bool IsPlaying;
	}
}
