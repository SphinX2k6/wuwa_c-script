using System;
using System.Runtime.CompilerServices;

// Token: 0x0200125E RID: 4702
[NullableContext(1)]
[Nullable(0)]
public class LogicTreeTimerBase
{
	// Token: 0x17001289 RID: 4745
	// (get) Token: 0x0600BA3D RID: 47677 RVA: 0x0036F6F8 File Offset: 0x0036D8F8
	public string TimerType
	{
		get
		{
			return this.InnerTimerType;
		}
	}

	// Token: 0x0600BA3E RID: 47678 RVA: 0x0036F700 File Offset: 0x0036D900
	public LogicTreeTimerBase(long treeIncId, string timerType, bool needTick = true, double intervalTime = 20.0)
	{
		this.TreeId = treeIncId;
		this.InnerTimerType = timerType;
		this.TimerId = TimerSystem.Instance.Forever(new TTimerAction(this.Tick), (float)((int)intervalTime), 1f, null, null, true);
	}

	// Token: 0x0600BA3F RID: 47679 RVA: 0x0036F73E File Offset: 0x0036D93E
	public virtual void Destroy()
	{
		if (this.TimerId != null)
		{
			TimerSystem.Instance.Remove(this.TimerId);
		}
	}

	// Token: 0x0600BA40 RID: 47680 RVA: 0x0036F759 File Offset: 0x0036D959
	private void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x0600BA41 RID: 47681 RVA: 0x0036F762 File Offset: 0x0036D962
	public virtual void StartShowTimer(double endTime, double pauseTime)
	{
	}

	// Token: 0x0600BA42 RID: 47682 RVA: 0x0036F764 File Offset: 0x0036D964
	public virtual void EndShowTimer()
	{
	}

	// Token: 0x0600BA43 RID: 47683 RVA: 0x0036F766 File Offset: 0x0036D966
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0600BA44 RID: 47684 RVA: 0x0036F768 File Offset: 0x0036D968
	public virtual double GetRemainTime()
	{
		return 0.0;
	}

	// Token: 0x04006B58 RID: 27480
	protected readonly long TreeId;

	// Token: 0x04006B59 RID: 27481
	[Nullable(2)]
	protected readonly TimerHandle TimerId;

	// Token: 0x04006B5A RID: 27482
	protected readonly string InnerTimerType;
}
