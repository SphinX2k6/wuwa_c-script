using System;
using System.Runtime.CompilerServices;

// Token: 0x020032F4 RID: 13044
[NullableContext(1)]
[Nullable(0)]
public class KeepDrivingDurationAtSpeed : KeepDrivingInfo
{
	// Token: 0x0601C63B RID: 116283 RVA: 0x007F2FBC File Offset: 0x007F11BC
	[NullableContext(2)]
	public KeepDrivingDurationAtSpeed([Nullable(1)] double[] speed, float duration, Func<bool> condition = null, Action action = null, float? cd = null)
	{
		this.SpeedRange = speed;
		this.Duration = duration;
		this.CoolDown = cd.GetValueOrDefault();
		this.CheckCondition = condition;
		this.RunAction = action;
	}

	// Token: 0x0601C63C RID: 116284 RVA: 0x007F2FFC File Offset: 0x007F11FC
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

	// Token: 0x0601C63D RID: 116285 RVA: 0x007F3080 File Offset: 0x007F1280
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

	// Token: 0x0400E13A RID: 57658
	protected double[] SpeedRange = new double[2];

	// Token: 0x0400E13B RID: 57659
	protected float Duration;

	// Token: 0x0400E13C RID: 57660
	protected float CurrentDuration;

	// Token: 0x0400E13D RID: 57661
	protected float CoolDown;

	// Token: 0x0400E13E RID: 57662
	protected double LastTime;
}
