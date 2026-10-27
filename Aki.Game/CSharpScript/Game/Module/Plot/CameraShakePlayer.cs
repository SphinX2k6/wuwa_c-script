using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FD6 RID: 20438
	public class CameraShakePlayer
	{
		// Token: 0x060344C3 RID: 214211 RVA: 0x00C483A8 File Offset: 0x00C465A8
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

		// Token: 0x060344C4 RID: 214212 RVA: 0x00C48400 File Offset: 0x00C46600
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

		// Token: 0x0401BD0F RID: 113935
		private int LoadingId = -1;

		// Token: 0x0401BD10 RID: 113936
		[Nullable(2)]
		private UMatineeCameraShake CameraShake;

		// Token: 0x0401BD11 RID: 113937
		private bool IsPlaying;
	}
}
