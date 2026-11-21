using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FA1 RID: 16289
	[NullableContext(1)]
	[Nullable(0)]
	public class MovingShotManager
	{
		// Token: 0x0602934C RID: 168780 RVA: 0x00B92214 File Offset: 0x00B90414
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

		// Token: 0x0602934D RID: 168781 RVA: 0x00B922A2 File Offset: 0x00B904A2
		public void Stop()
		{
			this.SequencePlayer.Stop();
			this.CurvePlayer.Stop();
			this.ShakePlayer.Stop();
		}

		// Token: 0x0602934E RID: 168782 RVA: 0x00B922C5 File Offset: 0x00B904C5
		public void OnTick(double delta)
		{
			this.CurvePlayer.OnTick(delta);
		}

		// Token: 0x040166ED RID: 91885
		private readonly CameraSequencePlayer SequencePlayer = new CameraSequencePlayer();

		// Token: 0x040166EE RID: 91886
		private readonly CameraCurvePlayer CurvePlayer = new CameraCurvePlayer();

		// Token: 0x040166EF RID: 91887
		private readonly CameraShakePlayer ShakePlayer = new CameraShakePlayer();
	}
}
