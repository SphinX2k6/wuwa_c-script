using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F4D RID: 16205
	public class QuickHackAbsoluteTimeStopManager : IQuickHackTimeScaleManager
	{
		// Token: 0x0602906B RID: 168043 RVA: 0x00B84D94 File Offset: 0x00B82F94
		public void BeginTimeScale(QuickHackDevice config, int ownerEntityId)
		{
			int timeScaleDuration = config.TimeScaleDuration;
			if (timeScaleDuration <= 0)
			{
				return;
			}
			float timeDilation = config.TimeDilation;
			if (timeDilation >= 1f)
			{
				return;
			}
			this.OwnerEntityId = ownerEntityId;
			float duration = (float)timeScaleDuration * 0.001f;
			SkillUtils.BeginAbsoluteTimeStop(ownerEntityId, duration, true, timeDilation);
			SkillUtils.BeginTimeStopRequest(ownerEntityId, duration, 0f);
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.TimerHandle = null;
				this.EndTimeScaleInternal();
			}, (float)timeScaleDuration, null, null, true, 1f);
		}

		// Token: 0x0602906C RID: 168044 RVA: 0x00B84E0A File Offset: 0x00B8300A
		public void EndTimeScale()
		{
			TimerHandle timerHandle = this.TimerHandle;
			if (timerHandle != null)
			{
				timerHandle.Remove();
			}
			this.TimerHandle = null;
			this.EndTimeScaleInternal();
		}

		// Token: 0x0602906D RID: 168045 RVA: 0x00B84E2B File Offset: 0x00B8302B
		private void EndTimeScaleInternal()
		{
			if (this.OwnerEntityId != 0)
			{
				SkillUtils.EndAbsoluteTimeStop(this.OwnerEntityId);
				SkillUtils.EndTimeStopRequest(this.OwnerEntityId);
			}
		}

		// Token: 0x04016543 RID: 91459
		private int OwnerEntityId;

		// Token: 0x04016544 RID: 91460
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
