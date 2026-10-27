using System;
using System.Runtime.CompilerServices;

// Token: 0x020032F5 RID: 13045
[NullableContext(1)]
[Nullable(0)]
public class PlayDrivingSoundOnReachSpeed : KeepDrivingInfo
{
	// Token: 0x0601C63E RID: 116286 RVA: 0x007F3112 File Offset: 0x007F1312
	public PlayDrivingSoundOnReachSpeed(double[] speed, float cd, [Nullable(2)] Func<bool> condition, Action action)
	{
		this.SpeedRange = speed;
		this.CoolDown = cd;
		this.CheckCondition = condition;
		this.RunAction = action;
	}

	// Token: 0x0601C63F RID: 116287 RVA: 0x007F3144 File Offset: 0x007F1344
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

	// Token: 0x0601C640 RID: 116288 RVA: 0x007F31C4 File Offset: 0x007F13C4
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

	// Token: 0x0400E13F RID: 57663
	protected double[] SpeedRange = new double[2];

	// Token: 0x0400E140 RID: 57664
	protected float CoolDown;

	// Token: 0x0400E141 RID: 57665
	protected float LastSpeed;

	// Token: 0x0400E142 RID: 57666
	protected double LastTime;
}
