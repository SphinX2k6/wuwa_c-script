using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005366 RID: 21350
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourRankData
	{
		// Token: 0x0603521E RID: 217630 RVA: 0x00ED69E4 File Offset: 0x00ED4BE4
		public MotorParkourRankData(string name, float time, [Nullable(2)] float[] lapTime, bool isOwn = false)
		{
			this.Name = name;
			this.Time = time;
			this.LapTime = (lapTime ?? Array.Empty<float>());
			this.IsOwn = isOwn;
		}

		// Token: 0x0603521F RID: 217631 RVA: 0x00ED6A20 File Offset: 0x00ED4C20
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

		// Token: 0x0401C0A0 RID: 114848
		public string ShowTimeString = "";

		// Token: 0x0401C0A1 RID: 114849
		public string Name;

		// Token: 0x0401C0A2 RID: 114850
		public float Time;

		// Token: 0x0401C0A3 RID: 114851
		public float[] LapTime;

		// Token: 0x0401C0A4 RID: 114852
		public bool IsOwn;
	}
}
