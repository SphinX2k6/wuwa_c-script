using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02005007 RID: 20487
	public class PlotTimeOfDay
	{
		// Token: 0x060346E1 RID: 214753 RVA: 0x00C58874 File Offset: 0x00C56A74
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

		// Token: 0x060346E2 RID: 214754 RVA: 0x00C588E5 File Offset: 0x00C56AE5
		public void OnSeqStart()
		{
			this.StopTween();
			this.CachePreSeqTime = (int)TimeOfDayModel.Instance.GameTime.Second;
			this.IsInherit = false;
		}

		// Token: 0x060346E3 RID: 214755 RVA: 0x00C5890C File Offset: 0x00C56B0C
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

		// Token: 0x060346E4 RID: 214756 RVA: 0x00C5898C File Offset: 0x00C56B8C
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

		// Token: 0x060346E5 RID: 214757 RVA: 0x00C58A20 File Offset: 0x00C56C20
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

		// Token: 0x060346E6 RID: 214758 RVA: 0x00C58A68 File Offset: 0x00C56C68
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

		// Token: 0x060346E7 RID: 214759 RVA: 0x00C58AAD File Offset: 0x00C56CAD
		public void SetTime(int second)
		{
			TimeOfDayController.Instance.AdjustTime((double)second, SceneDateUpdateReason.LevelPlayAuto, 0U, true);
		}

		// Token: 0x060346E8 RID: 214760 RVA: 0x00C58AC0 File Offset: 0x00C56CC0
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

		// Token: 0x060346E9 RID: 214761 RVA: 0x00C58BCB File Offset: 0x00C56DCB
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

		// Token: 0x0401BED7 RID: 114391
		private bool IsPauseInPlot;

		// Token: 0x0401BED8 RID: 114392
		private bool IsPauseConfig;

		// Token: 0x0401BED9 RID: 114393
		private bool IsInherit;

		// Token: 0x0401BEDA RID: 114394
		private int CachePrePlotTime;

		// Token: 0x0401BEDB RID: 114395
		private int CachePreSeqTime;

		// Token: 0x0401BEDC RID: 114396
		private bool NeedResetTime;

		// Token: 0x0401BEDD RID: 114397
		[Nullable(2)]
		private TimerHandle TimerId;
	}
}
