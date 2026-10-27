using System;
using System.Runtime.CompilerServices;

// Token: 0x0200312F RID: 12591
[NullableContext(2)]
[Nullable(0)]
public class TimerManageContainer
{
	// Token: 0x0601B0E9 RID: 110825 RVA: 0x00758C50 File Offset: 0x00756E50
	[NullableContext(1)]
	public TimerManageContainer(Action stopCallback)
	{
		this.StopCallback = stopCallback;
	}

	// Token: 0x0601B0EA RID: 110826 RVA: 0x00758C60 File Offset: 0x00756E60
	public void Delay(float delay, bool forceRestart = false)
	{
		if (this.TimerHandle != null && !forceRestart)
		{
			return;
		}
		this.Remove();
		int num = (delay < 20f) ? 20 : ((int)delay);
		this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnStop), (float)num, null, null, true, 1f);
	}

	// Token: 0x0601B0EB RID: 110827 RVA: 0x00758CB5 File Offset: 0x00756EB5
	public bool Remove()
	{
		if (this.TimerHandle != null && TimerSystem.Instance.Has(this.TimerHandle))
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
			this.TimerHandle = null;
			return true;
		}
		return false;
	}

	// Token: 0x0601B0EC RID: 110828 RVA: 0x00758CEC File Offset: 0x00756EEC
	public void Stop()
	{
		if (this.Remove())
		{
			this.OnStop(0f);
		}
	}

	// Token: 0x0601B0ED RID: 110829 RVA: 0x00758D01 File Offset: 0x00756F01
	private void OnStop(float delta)
	{
		this.TimerHandle = null;
		this.StopCallback();
	}

	// Token: 0x0400D26C RID: 53868
	private Action StopCallback;

	// Token: 0x0400D26D RID: 53869
	private TimerHandle TimerHandle;
}
