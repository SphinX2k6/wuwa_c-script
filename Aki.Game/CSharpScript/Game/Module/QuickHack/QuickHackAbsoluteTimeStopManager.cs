using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F84 RID: 20356
	public class QuickHackAbsoluteTimeStopManager : IQuickHackTimeScaleManager
	{
		// Token: 0x060341FD RID: 213501 RVA: 0x00C3B5E8 File Offset: 0x00C397E8
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

		// Token: 0x060341FE RID: 213502 RVA: 0x00C3B65E File Offset: 0x00C3985E
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

		// Token: 0x060341FF RID: 213503 RVA: 0x00C3B67F File Offset: 0x00C3987F
		private void EndTimeScaleInternal()
		{
			if (this.OwnerEntityId != 0)
			{
				SkillUtils.EndAbsoluteTimeStop(this.OwnerEntityId);
				SkillUtils.EndTimeStopRequest(this.OwnerEntityId);
			}
		}

		// Token: 0x0401BB6E RID: 113518
		private int OwnerEntityId;

		// Token: 0x0401BB6F RID: 113519
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
