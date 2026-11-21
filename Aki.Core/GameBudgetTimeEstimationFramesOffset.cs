using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x020000AF RID: 175
public class GameBudgetTimeEstimationFramesOffset : IGameBudgetTimeEstimation
{
	// Token: 0x0600057D RID: 1405 RVA: 0x0001C4F4 File Offset: 0x0001A6F4
	public GameBudgetTimeEstimationFramesOffset()
	{
		this.GtOffsetToleranceTime = this.GtFrameConsumeBaseTimeMs * this.GtOffsetToleranceTimePercentage;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x0001C560 File Offset: 0x0001A760
	public void Initialize()
	{
		UKuroGameBudgetAllocatorCSharpInterface.SetBudgetTime(this.TickBudgetTime);
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x0001C570 File Offset: 0x0001A770
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

	// Token: 0x06000580 RID: 1408 RVA: 0x0001C624 File Offset: 0x0001A824
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

	// Token: 0x04000463 RID: 1123
	private float GtFrameConsumeBaseTimeMs = 16.6f;

	// Token: 0x04000464 RID: 1124
	private float GtFrameMaxBudgetTimeMs = 5f;

	// Token: 0x04000465 RID: 1125
	private int GtAverageConsumeTimeStatisticsFrameCount = 60;

	// Token: 0x04000466 RID: 1126
	private float GtAverageOffsetTime;

	// Token: 0x04000467 RID: 1127
	private readonly float GtOffsetToleranceTimePercentage = 0.033333335f;

	// Token: 0x04000468 RID: 1128
	private float GtOffsetToleranceTime;

	// Token: 0x04000469 RID: 1129
	private int CurrentConsumeTimesPointer = -1;

	// Token: 0x0400046A RID: 1130
	[Nullable(1)]
	private readonly List<float> GtHistoryConsumeTimes = new List<float>();

	// Token: 0x0400046B RID: 1131
	public float TickBudgetTime = 8f;

	// Token: 0x0400046C RID: 1132
	private readonly bool DebugEnabled;
}
