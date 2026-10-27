using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FD7 RID: 20439
	[NullableContext(1)]
	[Nullable(0)]
	public class MovingShotManager
	{
		// Token: 0x060344C7 RID: 214215 RVA: 0x00C484B8 File Offset: 0x00C466B8
		public void Play(IShowTalkCameraMotion param)
		{
			this.Stop();
			EShowTalkCameraMotionType type = param.Type;
			if (type != EShowTalkCameraMotionType.Preset)
			{
				if (type != EShowTalkCameraMotionType.Tween)
				{
					return;
				}
				IShowTalkCameraMotionTween showTalkCameraMotionTween = param as IShowTalkCameraMotionTween;
				this.CurvePlayer.Play(showTalkCameraMotionTween);
				if (showTalkCameraMotionTween.CamShake != null)
				{
					this.ShakePlayer.Play(showTalkCameraMotionTween.CamShake);
				}
			}
			else
			{
				IShowTalkCameraMotionPreset showTalkCameraMotionPreset = param as IShowTalkCameraMotionPreset;
				if (!StringUtils.IsEmpty(showTalkCameraMotionPreset.Sequence))
				{
					this.SequencePlayer.Play(showTalkCameraMotionPreset.Sequence, true);
				}
				if (showTalkCameraMotionPreset.CamShake != null)
				{
					this.ShakePlayer.Play(showTalkCameraMotionPreset.CamShake);
					return;
				}
			}
		}

		// Token: 0x060344C8 RID: 214216 RVA: 0x00C48546 File Offset: 0x00C46746
		public void Stop()
		{
			this.SequencePlayer.Stop();
			this.CurvePlayer.Stop();
			this.ShakePlayer.Stop();
		}

		// Token: 0x060344C9 RID: 214217 RVA: 0x00C48569 File Offset: 0x00C46769
		public void OnTick(double delta)
		{
			this.CurvePlayer.OnTick(delta);
		}

		// Token: 0x0401BD12 RID: 113938
		private readonly CameraSequencePlayer SequencePlayer = new CameraSequencePlayer();

		// Token: 0x0401BD13 RID: 113939
		private readonly CameraCurvePlayer CurvePlayer = new CameraCurvePlayer();

		// Token: 0x0401BD14 RID: 113940
		private readonly CameraShakePlayer ShakePlayer = new CameraShakePlayer();
	}
}
