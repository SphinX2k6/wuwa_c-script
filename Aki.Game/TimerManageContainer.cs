using System;
using System.Runtime.CompilerServices;

// Token: 0x0200268B RID: 9867
[NullableContext(2)]
[Nullable(0)]
public class TimerManageContainer
{
	// Token: 0x06018B4E RID: 101198 RVA: 0x0077F0FE File Offset: 0x0077D2FE
	[NullableContext(1)]
	public TimerManageContainer(Action stopCallback)
	{
		this.StopCallback = stopCallback;
	}

	// Token: 0x06018B4F RID: 101199 RVA: 0x0077F110 File Offset: 0x0077D310
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

	// Token: 0x06018B50 RID: 101200 RVA: 0x0077F165 File Offset: 0x0077D365
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

	// Token: 0x06018B51 RID: 101201 RVA: 0x0077F19C File Offset: 0x0077D39C
	public void Stop()
	{
		if (this.Remove())
		{
			this.OnStop(0f);
		}
	}

	// Token: 0x06018B52 RID: 101202 RVA: 0x0077F1B1 File Offset: 0x0077D3B1
	private void OnStop(float delta)
	{
		this.TimerHandle = null;
		this.StopCallback();
	}

	// Token: 0x0400D696 RID: 54934
	private Action StopCallback;

	// Token: 0x0400D697 RID: 54935
	private TimerHandle TimerHandle;
}
