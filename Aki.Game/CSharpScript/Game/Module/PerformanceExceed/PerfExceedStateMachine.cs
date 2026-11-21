using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x0200432D RID: 17197
	[NullableContext(1)]
	[Nullable(0)]
	public class PerfExceedStateMachine
	{
		// Token: 0x170056EF RID: 22255
		// (get) Token: 0x0602B6D5 RID: 177877 RVA: 0x00C35392 File Offset: 0x00C33592
		// (set) Token: 0x0602B6D6 RID: 177878 RVA: 0x00C3539A File Offset: 0x00C3359A
		public bool HasReportEvent { get; private set; }

		// Token: 0x170056F0 RID: 22256
		// (get) Token: 0x0602B6D7 RID: 177879 RVA: 0x00C353A3 File Offset: 0x00C335A3
		// (set) Token: 0x0602B6D8 RID: 177880 RVA: 0x00C353AB File Offset: 0x00C335AB
		public double ExceedDurationMs { get; private set; }

		// Token: 0x170056F1 RID: 22257
		// (get) Token: 0x0602B6D9 RID: 177881 RVA: 0x00C353B4 File Offset: 0x00C335B4
		// (set) Token: 0x0602B6DA RID: 177882 RVA: 0x00C353BC File Offset: 0x00C335BC
		[Nullable(2)]
		public string LastReportedKey { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x0602B6DB RID: 177883 RVA: 0x00C353C8 File Offset: 0x00C335C8
		public PerfExceedStateMachine(PerfExceedSubMetric subMetric, int threshold, int triggerWindowMs = 3000, int reReportIntervalMs = 60000, int reArmDelayMs = 3000)
		{
			this.SubMetric = subMetric;
			this.Threshold = threshold;
			this.TriggerWindowMs = triggerWindowMs;
			this.ReReportIntervalMs = reReportIntervalMs;
			this.ReArmDelayMs = reArmDelayMs;
		}

		// Token: 0x0602B6DC RID: 177884 RVA: 0x00C3541C File Offset: 0x00C3361C
		public void Update(double nowMs, [Nullable(2)] PerfExceedSample sample, List<string> top3AssetIds, bool canReport)
		{
			this.HasReportEvent = false;
			this.LastReportedKey = null;
			bool flag = sample != null && sample.GetValue(this.SubMetric) > this.Threshold;
			this.ExceedDurationMs = ((this.State != PerfExceedStateMachine.EState.Idle && this.FirstExceedAtMs >= 0.0) ? (nowMs - this.FirstExceedAtMs) : 0.0);
			if (!flag)
			{
				if (this.State == PerfExceedStateMachine.EState.Exceeding)
				{
					this.ResetWindow();
					return;
				}
				this.HandleFallBelow(nowMs);
				return;
			}
			else
			{
				this.FallBelowSinceMs = null;
				if (this.State == PerfExceedStateMachine.EState.Idle)
				{
					this.State = PerfExceedStateMachine.EState.Exceeding;
					this.FirstExceedAtMs = nowMs;
					this.LastReportOrWindowAtMs = null;
					return;
				}
				this.ExceedDurationMs = nowMs - this.FirstExceedAtMs;
				if (this.State == PerfExceedStateMachine.EState.Exceeding)
				{
					if (this.ExceedDurationMs >= (double)this.TriggerWindowMs)
					{
						this.TryReport(nowMs, top3AssetIds, canReport);
					}
					return;
				}
				double valueOrDefault = this.LastReportOrWindowAtMs.GetValueOrDefault(nowMs);
				if (nowMs - valueOrDefault >= (double)this.ReReportIntervalMs)
				{
					this.TryReport(nowMs, top3AssetIds, canReport);
				}
				return;
			}
		}

		// Token: 0x0602B6DD RID: 177885 RVA: 0x00C35520 File Offset: 0x00C33720
		private void HandleFallBelow(double nowMs)
		{
			if (this.State == PerfExceedStateMachine.EState.Idle)
			{
				return;
			}
			double num = this.FallBelowSinceMs.GetValueOrDefault();
			if (this.FallBelowSinceMs == null)
			{
				this.FallBelowSinceMs = new double?(nowMs);
			}
			double? num2 = nowMs - this.FallBelowSinceMs;
			num = (double)this.ReArmDelayMs;
			if (num2.GetValueOrDefault() >= num & num2 != null)
			{
				this.ResetWindow();
			}
		}

		// Token: 0x0602B6DE RID: 177886 RVA: 0x00C355AF File Offset: 0x00C337AF
		private void ResetWindow()
		{
			this.State = PerfExceedStateMachine.EState.Idle;
			this.FirstExceedAtMs = -1.0;
			this.LastReportOrWindowAtMs = null;
			this.FallBelowSinceMs = null;
			this.ExceedDurationMs = 0.0;
		}

		// Token: 0x0602B6DF RID: 177887 RVA: 0x00C355F0 File Offset: 0x00C337F0
		private void TryReport(double nowMs, List<string> top3AssetIds, bool canReport)
		{
			this.State = PerfExceedStateMachine.EState.Reporting;
			this.LastReportOrWindowAtMs = new double?(nowMs);
			if (!canReport)
			{
				return;
			}
			string text = PerfExceedStateMachine.BuildKey(top3AssetIds);
			if (this.ReportedKeys.Contains(text))
			{
				return;
			}
			this.ReportedKeys.Add(text);
			this.HasReportEvent = true;
			this.LastReportedKey = text;
		}

		// Token: 0x0602B6E0 RID: 177888 RVA: 0x00C35648 File Offset: 0x00C33848
		private static string BuildKey(List<string> top3AssetIds)
		{
			if (top3AssetIds == null || top3AssetIds.Count == 0)
			{
				return "<none>";
			}
			List<string> list = new List<string>(top3AssetIds);
			list.Sort(StringComparer.Ordinal);
			return string.Join("|", list);
		}

		// Token: 0x0602B6E1 RID: 177889 RVA: 0x00C35683 File Offset: 0x00C33883
		public void RollbackLastReport()
		{
			if (this.LastReportedKey == null)
			{
				return;
			}
			this.ReportedKeys.Remove(this.LastReportedKey);
			this.LastReportedKey = null;
		}

		// Token: 0x170056F2 RID: 22258
		// (get) Token: 0x0602B6E2 RID: 177890 RVA: 0x00C356A7 File Offset: 0x00C338A7
		public int ReportedKeyCount
		{
			get
			{
				return this.ReportedKeys.Count;
			}
		}

		// Token: 0x040177AC RID: 96172
		private readonly int Threshold;

		// Token: 0x040177AD RID: 96173
		private readonly PerfExceedSubMetric SubMetric;

		// Token: 0x040177AE RID: 96174
		public readonly int TriggerWindowMs;

		// Token: 0x040177AF RID: 96175
		public readonly int ReReportIntervalMs;

		// Token: 0x040177B0 RID: 96176
		public readonly int ReArmDelayMs;

		// Token: 0x040177B1 RID: 96177
		private PerfExceedStateMachine.EState State;

		// Token: 0x040177B2 RID: 96178
		private double FirstExceedAtMs = -1.0;

		// Token: 0x040177B3 RID: 96179
		private double? LastReportOrWindowAtMs;

		// Token: 0x040177B4 RID: 96180
		private double? FallBelowSinceMs;

		// Token: 0x040177B5 RID: 96181
		private readonly HashSet<string> ReportedKeys = new HashSet<string>();

		// Token: 0x02009FF8 RID: 40952
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04031B30 RID: 203568
			Idle,
			// Token: 0x04031B31 RID: 203569
			Exceeding,
			// Token: 0x04031B32 RID: 203570
			Reporting
		}
	}
}
