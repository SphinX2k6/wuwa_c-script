using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F86 RID: 20358
	public class QuickHackWorldTimeDilationManager : IQuickHackTimeScaleManager
	{
		// Token: 0x06034204 RID: 213508 RVA: 0x00C3B6B8 File Offset: 0x00C398B8
		public void BeginTimeScale(QuickHackDevice config, int ownerEntityId)
		{
			int timeScaleDuration = config.TimeScaleDuration;
			if (timeScaleDuration == 0)
			{
				return;
			}
			float num = MathUtils.Instance.Clamp(config.TimeDilation, 0f, 1f);
			if (num >= 1f)
			{
				return;
			}
			this.IsChangeTimeScale = true;
			GameModeController.Instance.SetTimeDilation(num, ETimeDilationType.QuickHack);
			CameraController.Instance.SetTimeDilation(1f, "MainCamera");
			if (timeScaleDuration > 0)
			{
				this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.TimerHandle = null;
					this.EndInternal();
				}, (float)timeScaleDuration, null, null, true, 1f);
			}
		}

		// Token: 0x06034205 RID: 213509 RVA: 0x00C3B747 File Offset: 0x00C39947
		public void EndTimeScale()
		{
			TimerHandle timerHandle = this.TimerHandle;
			if (timerHandle != null)
			{
				timerHandle.Remove();
			}
			this.TimerHandle = null;
			this.EndInternal();
		}

		// Token: 0x06034206 RID: 213510 RVA: 0x00C3B768 File Offset: 0x00C39968
		private void EndInternal()
		{
			if (this.IsChangeTimeScale)
			{
				GameModeController.Instance.SetTimeDilation(1f, ETimeDilationType.QuickHack);
				this.IsChangeTimeScale = false;
			}
		}

		// Token: 0x0401BB70 RID: 113520
		private bool IsChangeTimeScale;

		// Token: 0x0401BB71 RID: 113521
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
