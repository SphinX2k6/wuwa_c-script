using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F4F RID: 16207
	public class QuickHackWorldTimeDilationManager : IQuickHackTimeScaleManager
	{
		// Token: 0x06029072 RID: 168050 RVA: 0x00B84E64 File Offset: 0x00B83064
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

		// Token: 0x06029073 RID: 168051 RVA: 0x00B84EF3 File Offset: 0x00B830F3
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

		// Token: 0x06029074 RID: 168052 RVA: 0x00B84F14 File Offset: 0x00B83114
		private void EndInternal()
		{
			if (this.IsChangeTimeScale)
			{
				GameModeController.Instance.SetTimeDilation(1f, ETimeDilationType.QuickHack);
				this.IsChangeTimeScale = false;
			}
		}

		// Token: 0x04016545 RID: 91461
		private bool IsChangeTimeScale;

		// Token: 0x04016546 RID: 91462
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
