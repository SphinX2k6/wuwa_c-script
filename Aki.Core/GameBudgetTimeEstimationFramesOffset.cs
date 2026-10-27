using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x020000AD RID: 173
public class GameBudgetTimeEstimationFramesOffset : IGameBudgetTimeEstimation
{
	// Token: 0x0600053C RID: 1340 RVA: 0x0001BE0C File Offset: 0x0001A00C
	public GameBudgetTimeEstimationFramesOffset()
	{
		this.GtOffsetToleranceTime = this.GtFrameConsumeBaseTimeMs * this.GtOffsetToleranceTimePercentage;
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0001BE78 File Offset: 0x0001A078
	public void Initialize()
	{
		UKuroGameBudgetAllocatorCSharpInterface.SetBudgetTime(this.TickBudgetTime);
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0001BE88 File Offset: 0x0001A088
	public void SetMaximumFrameRate(int fps)
	{
		this.GtFrameConsumeBaseTimeMs = 1000f / (float)fps * (Info.Instance.IsMobilePlatform() ? 0.8f : 0.95f);
		this.GtFrameMaxBudgetTimeMs = this.GtFrameConsumeBaseTimeMs / (Info.Instance.IsMobilePlatform() ? 2.33f : 1.5f);
		this.TickBudgetTime = (float)Math.Floor((double)(this.GtFrameConsumeBaseTimeMs / 2f));
		this.GtOffsetToleranceTime = this.GtFrameConsumeBaseTimeMs * this.GtOffsetToleranceTimePercentage;
		this.GtAverageConsumeTimeStatisticsFrameCount = fps;
		this.CurrentConsumeTimesPointer = -1;
		this.GtHistoryConsumeTimes.Clear();
		this.GtAverageOffsetTime = 0f;
		UKuroGameBudgetAllocatorCSharpInterface.SetBudgetTime(this.TickBudgetTime);
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0001BF3C File Offset: 0x0001A13C
	public void UpdateBudgetTime(float delta)
	{
		float lastFrameGameThreadConsumeTime = UKuroGameBudgetAllocatorCSharpInterface.GetLastFrameGameThreadConsumeTime();
		if (this.GtHistoryConsumeTimes.Count < this.GtAverageConsumeTimeStatisticsFrameCount)
		{
			this.GtHistoryConsumeTimes.Add(lastFrameGameThreadConsumeTime - this.GtFrameConsumeBaseTimeMs);
			if (this.GtHistoryConsumeTimes.Count == this.GtAverageConsumeTimeStatisticsFrameCount)
			{
				float num = 0f;
				for (int i = 0; i < this.GtHistoryConsumeTimes.Count; i++)
				{
					num += this.GtHistoryConsumeTimes[i];
				}
				this.GtAverageOffsetTime = num / (float)this.GtAverageConsumeTimeStatisticsFrameCount;
				this.CurrentConsumeTimesPointer = -1;
			}
			return;
		}
		this.CurrentConsumeTimesPointer++;
		if (this.CurrentConsumeTimesPointer >= this.GtAverageConsumeTimeStatisticsFrameCount)
		{
			this.CurrentConsumeTimesPointer = 0;
		}
		if (this.CurrentConsumeTimesPointer >= this.GtHistoryConsumeTimes.Count)
		{
			return;
		}
		float num2 = this.GtHistoryConsumeTimes[this.CurrentConsumeTimesPointer];
		float num3 = lastFrameGameThreadConsumeTime - this.GtFrameConsumeBaseTimeMs;
		this.GtHistoryConsumeTimes[this.CurrentConsumeTimesPointer] = num3;
		this.GtAverageOffsetTime += (num3 - num2) / (float)this.GtAverageConsumeTimeStatisticsFrameCount;
		if (this.GtAverageOffsetTime < -this.GtOffsetToleranceTime)
		{
			float num4 = (this.GtOffsetToleranceTime - this.GtAverageOffsetTime) / this.GtOffsetToleranceTime;
			this.TickBudgetTime += this.GtOffsetToleranceTime * num4 / (float)this.GtAverageConsumeTimeStatisticsFrameCount;
		}
		else if (this.GtAverageOffsetTime > this.GtOffsetToleranceTime)
		{
			float num5 = (this.GtAverageOffsetTime - this.GtOffsetToleranceTime) / this.GtOffsetToleranceTime;
			this.TickBudgetTime -= this.GtOffsetToleranceTime * num5 / (float)this.GtAverageConsumeTimeStatisticsFrameCount;
		}
		this.TickBudgetTime = MathCommon.Clamp(this.TickBudgetTime, 0f, this.GtFrameMaxBudgetTimeMs);
		UKuroGameBudgetAllocatorCSharpInterface.SetBudgetTime(this.TickBudgetTime);
		bool debugEnabled = this.DebugEnabled;
	}

	// Token: 0x04000455 RID: 1109
	private float GtFrameConsumeBaseTimeMs = 16.6f;

	// Token: 0x04000456 RID: 1110
	private float GtFrameMaxBudgetTimeMs = 5f;

	// Token: 0x04000457 RID: 1111
	private int GtAverageConsumeTimeStatisticsFrameCount = 60;

	// Token: 0x04000458 RID: 1112
	private float GtAverageOffsetTime;

	// Token: 0x04000459 RID: 1113
	private readonly float GtOffsetToleranceTimePercentage = 0.033333335f;

	// Token: 0x0400045A RID: 1114
	private float GtOffsetToleranceTime;

	// Token: 0x0400045B RID: 1115
	private int CurrentConsumeTimesPointer = -1;

	// Token: 0x0400045C RID: 1116
	[Nullable(1)]
	private readonly List<float> GtHistoryConsumeTimes = new List<float>();

	// Token: 0x0400045D RID: 1117
	public float TickBudgetTime = 8f;

	// Token: 0x0400045E RID: 1118
	private readonly bool DebugEnabled;
}
