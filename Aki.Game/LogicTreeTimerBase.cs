using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D9C RID: 7580
[NullableContext(1)]
[Nullable(0)]
public class LogicTreeTimerBase
{
	// Token: 0x1700125F RID: 4703
	// (get) Token: 0x0600E61F RID: 58911 RVA: 0x00363A98 File Offset: 0x00361C98
	public string TimerType
	{
		get
		{
			return this.InnerTimerType;
		}
	}

	// Token: 0x0600E620 RID: 58912 RVA: 0x00363AA0 File Offset: 0x00361CA0
	public LogicTreeTimerBase(long treeIncId, string timerType, bool needTick = true, double intervalTime = 20.0)
	{
		this.TreeId = treeIncId;
		this.InnerTimerType = timerType;
		this.TimerId = TimerSystem.Instance.Forever(new TTimerAction(this.Tick), (float)((int)intervalTime), 1f, null, null, true);
	}

	// Token: 0x0600E621 RID: 58913 RVA: 0x00363ADE File Offset: 0x00361CDE
	public virtual void Destroy()
	{
		if (this.TimerId != null)
		{
			TimerSystem.Instance.Remove(this.TimerId);
		}
	}

	// Token: 0x0600E622 RID: 58914 RVA: 0x00363AF9 File Offset: 0x00361CF9
	private void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x0600E623 RID: 58915 RVA: 0x00363B02 File Offset: 0x00361D02
	public virtual void StartShowTimer(double endTime, double pauseTime)
	{
	}

	// Token: 0x0600E624 RID: 58916 RVA: 0x00363B04 File Offset: 0x00361D04
	public virtual void EndShowTimer()
	{
	}

	// Token: 0x0600E625 RID: 58917 RVA: 0x00363B06 File Offset: 0x00361D06
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0600E626 RID: 58918 RVA: 0x00363B08 File Offset: 0x00361D08
	public virtual double GetRemainTime()
	{
		return 0.0;
	}

	// Token: 0x04006A77 RID: 27255
	protected readonly long TreeId;

	// Token: 0x04006A78 RID: 27256
	[Nullable(2)]
	protected readonly TimerHandle TimerId;

	// Token: 0x04006A79 RID: 27257
	protected readonly string InnerTimerType;
}
