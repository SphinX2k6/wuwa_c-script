using System;
using System.Runtime.CompilerServices;

// Token: 0x02002866 RID: 10342
[NullableContext(1)]
[Nullable(0)]
public class KeepDrivingDurationAtSpeed : KeepDrivingInfo
{
	// Token: 0x0601A300 RID: 107264 RVA: 0x008194E8 File Offset: 0x008176E8
	[NullableContext(2)]
	public KeepDrivingDurationAtSpeed([Nullable(1)] double[] speed, float duration, Func<bool> condition = null, Action action = null, float? cd = null)
	{
		this.SpeedRange = speed;
		this.Duration = duration;
		this.CoolDown = cd.GetValueOrDefault();
		this.CheckCondition = condition;
		this.RunAction = action;
	}

	// Token: 0x0601A301 RID: 107265 RVA: 0x00819528 File Offset: 0x00817728
	public override bool UpdateDrivingInfo(float delta, VehicleMoveComponent moveComp)
	{
		if (MathUtils.Instance.InRangeArray((double)moveComp.Speed, this.SpeedRange))
		{
			this.CurrentDuration += delta;
			if (this.CurrentDuration > this.Duration)
			{
				if (Math.Abs(TimerSystem.Instance.Now - this.LastTime) > (double)this.CoolDown)
				{
					this.LastTime = TimerSystem.Instance.Now;
					return true;
				}
				return false;
			}
		}
		else
		{
			this.CurrentDuration = 0f;
		}
		return false;
	}

	// Token: 0x0601A302 RID: 107266 RVA: 0x008195AC File Offset: 0x008177AC
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
		defaultInterpolatedStringHandler.AppendLiteral("保持速度在区间[");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.SpeedRange[0]);
		defaultInterpolatedStringHandler.AppendLiteral(",");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.SpeedRange[1]);
		defaultInterpolatedStringHandler.AppendLiteral("]内,持续");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Duration);
		defaultInterpolatedStringHandler.AppendLiteral("毫秒,冷却时间");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.CoolDown);
		defaultInterpolatedStringHandler.AppendLiteral("毫秒");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400E5E5 RID: 58853
	protected double[] SpeedRange = new double[2];

	// Token: 0x0400E5E6 RID: 58854
	protected float Duration;

	// Token: 0x0400E5E7 RID: 58855
	protected float CurrentDuration;

	// Token: 0x0400E5E8 RID: 58856
	protected float CoolDown;

	// Token: 0x0400E5E9 RID: 58857
	protected double LastTime;
}
