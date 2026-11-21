using System;
using System.Runtime.CompilerServices;

// Token: 0x02002867 RID: 10343
[NullableContext(1)]
[Nullable(0)]
public class PlayDrivingSoundOnReachSpeed : KeepDrivingInfo
{
	// Token: 0x0601A303 RID: 107267 RVA: 0x0081963E File Offset: 0x0081783E
	public PlayDrivingSoundOnReachSpeed(double[] speed, float cd, [Nullable(2)] Func<bool> condition, Action action)
	{
		this.SpeedRange = speed;
		this.CoolDown = cd;
		this.CheckCondition = condition;
		this.RunAction = action;
	}

	// Token: 0x0601A304 RID: 107268 RVA: 0x00819670 File Offset: 0x00817870
	public override bool UpdateDrivingInfo(float delta, VehicleMoveComponent moveComp)
	{
		bool flag = !MathUtils.Instance.InRangeArray((double)this.LastSpeed, this.SpeedRange) && MathUtils.Instance.InRangeArray((double)moveComp.Speed, this.SpeedRange);
		this.LastSpeed = moveComp.Speed;
		if (flag && Math.Abs(TimerSystem.Instance.Now - this.LastTime) > (double)this.CoolDown)
		{
			this.LastTime = TimerSystem.Instance.Now;
			return true;
		}
		return false;
	}

	// Token: 0x0601A305 RID: 107269 RVA: 0x008196F0 File Offset: 0x008178F0
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
		defaultInterpolatedStringHandler.AppendLiteral("速度每次进入区间[");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.SpeedRange[0]);
		defaultInterpolatedStringHandler.AppendLiteral(",");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.SpeedRange[1]);
		defaultInterpolatedStringHandler.AppendLiteral("]内,触发事件,冷却时间");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.CoolDown);
		defaultInterpolatedStringHandler.AppendLiteral("毫秒");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400E5EA RID: 58858
	protected double[] SpeedRange = new double[2];

	// Token: 0x0400E5EB RID: 58859
	protected float CoolDown;

	// Token: 0x0400E5EC RID: 58860
	protected float LastSpeed;

	// Token: 0x0400E5ED RID: 58861
	protected double LastTime;
}
