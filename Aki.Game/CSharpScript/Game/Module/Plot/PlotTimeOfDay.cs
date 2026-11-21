using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FD1 RID: 16337
	public class PlotTimeOfDay
	{
		// Token: 0x06029584 RID: 169348 RVA: 0x00BA3D74 File Offset: 0x00BA1F74
		public void OnPlotStart(bool pauseTime)
		{
			if (this.IsPauseConfig)
			{
				return;
			}
			this.IsPauseConfig = pauseTime;
			if (!pauseTime)
			{
				return;
			}
			this.IsPauseInPlot = true;
			this.NeedResetTime = TimeOfDayModel.Instance.TimeRunLockState;
			TimeOfDayModel.Instance.SetUseClientLockState(true);
			TimeOfDayModel.Instance.SetTimeRunLockStateClient(true, true);
			TimeOfDayModel.Instance.SetTimeSyncLockStateClient(true, true);
			this.CachePrePlotTime = (int)TimeOfDayModel.Instance.GameTime.Second;
		}

		// Token: 0x06029585 RID: 169349 RVA: 0x00BA3DE5 File Offset: 0x00BA1FE5
		public void OnSeqStart()
		{
			this.StopTween();
			this.CachePreSeqTime = (int)TimeOfDayModel.Instance.GameTime.Second;
			this.IsInherit = false;
		}

		// Token: 0x06029586 RID: 169350 RVA: 0x00BA3E0C File Offset: 0x00BA200C
		public void OnSeqEnd()
		{
			this.StopTween();
			TimeOfDayModel.Instance.SetTimeRunLockStateClient(this.IsPauseInPlot, true);
			if (this.IsInherit && this.CachePreSeqTime != 0 && Math.Abs((double)this.CachePreSeqTime - TimeOfDayModel.Instance.GameTime.Second) > 9.99999993922529E-09)
			{
				TimeOfDayController.Instance.AdjustTime((double)this.CachePreSeqTime, SceneDateUpdateReason.LevelPlayAuto, 0U, true);
			}
			this.IsInherit = false;
			this.CachePreSeqTime = 0;
		}

		// Token: 0x06029587 RID: 169351 RVA: 0x00BA3E8C File Offset: 0x00BA208C
		public void OnPlotEnd()
		{
			if (!this.IsPauseConfig)
			{
				return;
			}
			TimeOfDayModel.Instance.SetUseClientLockState(false);
			TimeOfDayModel.Instance.SetTimeRunLockStateClient(false, true);
			TimeOfDayModel.Instance.SetTimeSyncLockStateClient(false, true);
			if (this.NeedResetTime && Math.Abs((double)this.CachePrePlotTime - TimeOfDayModel.Instance.GameTime.Second) > 9.99999993922529E-09)
			{
				TimeOfDayController.Instance.AdjustTime((double)this.CachePrePlotTime, SceneDateUpdateReason.LevelPlayAuto, 0U, true);
			}
			this.CachePrePlotTime = 0;
			this.IsPauseConfig = false;
			this.IsPauseInPlot = false;
		}

		// Token: 0x06029588 RID: 169352 RVA: 0x00BA3F20 File Offset: 0x00BA2120
		public void PauseTime()
		{
			if (this.IsPauseInPlot)
			{
				return;
			}
			TimeOfDayModel.Instance.SetTimeRunLockStateClient(true, true);
			this.IsPauseInPlot = true;
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.FZX, "[TimeRunLockState] 剧情行为锁定时间", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06029589 RID: 169353 RVA: 0x00BA3F68 File Offset: 0x00BA2168
		public void ResumeTime()
		{
			if (!this.IsPauseInPlot)
			{
				return;
			}
			TimeOfDayModel.Instance.SetTimeRunLockStateClient(false, true);
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.FZX, "[TimeRunLockState] 剧情行为解锁时间", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsPauseInPlot = false;
		}

		// Token: 0x0602958A RID: 169354 RVA: 0x00BA3FAD File Offset: 0x00BA21AD
		public void SetTime(int second)
		{
			TimeOfDayController.Instance.AdjustTime((double)second, SceneDateUpdateReason.LevelPlayAuto, 0U, true);
		}

		// Token: 0x0602958B RID: 169355 RVA: 0x00BA3FC0 File Offset: 0x00BA21C0
		public void SetTimeDuration(bool isInherit, int startSecond, int endSecond, int tweenSecond)
		{
			this.StopTween();
			this.IsInherit = isInherit;
			int num = startSecond;
			if (num > 86400)
			{
				num = 0;
			}
			if (tweenSecond <= 0)
			{
				TimeOfDayController.Instance.AdjustTime((double)num, SceneDateUpdateReason.LevelPlayAuto, 0U, true);
				return;
			}
			int num2 = endSecond;
			if (num2 > 86400)
			{
				num2 = 0;
			}
			if (num2 < num)
			{
				num2 += 86400;
			}
			double num3 = TodDayTime.ConvertFromRealTimeSecond((double)tweenSecond);
			double num4 = 1.0;
			if (num3 > 0.0)
			{
				num4 = (double)(num2 - num) / num3;
			}
			TimeOfDayModel.Instance.SetTimeRunLockStateClient(false, true);
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.FZX, "[TimeRunLockState] Seq解锁时间", default(ReadOnlySpan<ValueTuple<string, object>>));
			TimeOfDayController.Instance.AdjustTime((double)num, SceneDateUpdateReason.LevelPlayAuto, 0U, true);
			TimeOfDayController.Instance.ChangeTimeScale((float)num4);
			this.TimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				TimeOfDayController.Instance.AdjustTime((double)endSecond, SceneDateUpdateReason.LevelPlayAuto, 0U, true);
				this.TimerId = null;
				TimeOfDayController.Instance.ResumeTimeScale(true);
				TimeOfDayModel.Instance.SetTimeRunLockStateClient(this.IsPauseInPlot, true);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TimeOfDay;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[TimeRunLockState] Seq恢复时间锁定";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IsPauseInPlot", this.IsPauseInPlot);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}, (float)(tweenSecond * TimeUtil.Instance.InverseMillisecond), null, null, true, 1f);
		}

		// Token: 0x0602958C RID: 169356 RVA: 0x00BA40CB File Offset: 0x00BA22CB
		private void StopTween()
		{
			if (this.TimerId != null)
			{
				if (TimerSystem.Instance.Has(this.TimerId))
				{
					TimerSystem.Instance.Remove(this.TimerId);
				}
				TimeOfDayController.Instance.ResumeTimeScale(true);
				this.TimerId = null;
			}
		}

		// Token: 0x040168C0 RID: 92352
		private bool IsPauseInPlot;

		// Token: 0x040168C1 RID: 92353
		private bool IsPauseConfig;

		// Token: 0x040168C2 RID: 92354
		private bool IsInherit;

		// Token: 0x040168C3 RID: 92355
		private int CachePrePlotTime;

		// Token: 0x040168C4 RID: 92356
		private int CachePreSeqTime;

		// Token: 0x040168C5 RID: 92357
		private bool NeedResetTime;

		// Token: 0x040168C6 RID: 92358
		[Nullable(2)]
		private TimerHandle TimerId;
	}
}
