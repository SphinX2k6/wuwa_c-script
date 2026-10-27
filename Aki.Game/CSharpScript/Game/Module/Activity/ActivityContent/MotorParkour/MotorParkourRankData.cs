using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063E8 RID: 25576
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourRankData
	{
		// Token: 0x0604055D RID: 263517 RVA: 0x00F8FA4C File Offset: 0x00F8DC4C
		public MotorParkourRankData(string name, float time, [Nullable(2)] float[] lapTime, bool isOwn = false)
		{
			this.Name = name;
			this.Time = time;
			this.LapTime = (lapTime ?? Array.Empty<float>());
			this.IsOwn = isOwn;
		}

		// Token: 0x0604055E RID: 263518 RVA: 0x00F8FA88 File Offset: 0x00F8DC88
		public void UpdateShowTimeString(int lap, float playerTime, bool isNeedShowGap)
		{
			float num = this.LapTime[lap - 1];
			if (!isNeedShowGap)
			{
				this.ShowTimeString = TimeUtil.Instance.GetRemainTimeDataFormat5((double)num * TimeUtil.Instance.Millisecond);
				return;
			}
			double floatPointFloor = MathUtils.Instance.GetFloatPointFloor((double)Math.Abs(playerTime - num) * TimeUtil.Instance.Millisecond, 2);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (playerTime > num)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted<double>(floatPointFloor);
				defaultInterpolatedStringHandler.AppendLiteral("s");
				this.ShowTimeString = defaultInterpolatedStringHandler.ToStringAndClear();
				return;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted<double>(floatPointFloor);
			defaultInterpolatedStringHandler.AppendLiteral("s");
			this.ShowTimeString = defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x04021771 RID: 137073
		public string ShowTimeString = "";

		// Token: 0x04021772 RID: 137074
		public string Name;

		// Token: 0x04021773 RID: 137075
		public float Time;

		// Token: 0x04021774 RID: 137076
		public float[] LapTime;

		// Token: 0x04021775 RID: 137077
		public bool IsOwn;
	}
}
