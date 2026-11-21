using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004047 RID: 16455
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class PlotAutoPlayComponent
	{
		// Token: 0x06029B45 RID: 170821 RVA: 0x00BC9CD0 File Offset: 0x00BC7ED0
		[NullableContext(1)]
		public void Init(IPlotAutoPlayComponentContext context)
		{
			this.Toggle = context.Toggle;
			this.WaitTime = context.WaitTime;
			this.CheckTalkFinishedDelegate = context.CheckTalkFinishedDelegate;
			this.ContinueToNextTalkDelegate = context.ContinueToNextTalkDelegate;
			this.Toggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
			this.UpdateAutoPlayToggle();
		}

		// Token: 0x06029B46 RID: 170822 RVA: 0x00BC9D2F File Offset: 0x00BC7F2F
		private void OnToggleStateChange(EToggleState state)
		{
			this.ChangeAutoPlay(state == EToggleState.ETT_Checked);
		}

		// Token: 0x06029B47 RID: 170823 RVA: 0x00BC9D3C File Offset: 0x00BC7F3C
		public void ChangeAutoPlay(bool isAutoPlay)
		{
			PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
			if (plotConfig.AutoPlayState > EAutoPlayState.Manual == isAutoPlay)
			{
				return;
			}
			plotConfig.AutoPlayState = (isAutoPlay ? EAutoPlayState.SemiAuto : EAutoPlayState.Manual);
			plotConfig.AutoPlayStateCache = plotConfig.AutoPlayState;
			this.UpdateAutoPlayToggle();
			bool flag = this.IsTalkFinished();
			if (isAutoPlay)
			{
				if (flag)
				{
					Action continueToNextTalkDelegate = this.ContinueToNextTalkDelegate;
					if (continueToNextTalkDelegate == null)
					{
						return;
					}
					continueToNextTalkDelegate();
					return;
				}
			}
			else
			{
				this.RemoveDelayTimer();
			}
		}

		// Token: 0x06029B48 RID: 170824 RVA: 0x00BC9DA4 File Offset: 0x00BC7FA4
		public void UpdateAutoPlayToggle()
		{
			EToggleState state = (PlotModel.Instance.PlotConfig.AutoPlayState > EAutoPlayState.Manual) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.Toggle.SetToggleState(state, false, false, false);
		}

		// Token: 0x06029B49 RID: 170825 RVA: 0x00BC9DDC File Offset: 0x00BC7FDC
		public void MuteAutoPlay(bool isMute)
		{
			if (isMute)
			{
				PlotModel.Instance.PlotConfig.AutoPlayState = EAutoPlayState.Manual;
				this.RemoveDelayTimer();
				this.UpdateAutoPlayToggle();
				return;
			}
			PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
			plotConfig.AutoPlayState = plotConfig.AutoPlayStateCache;
			this.UpdateAutoPlayToggle();
			if (plotConfig.AutoPlayState != EAutoPlayState.Manual && this.IsTalkFinished())
			{
				Action continueToNextTalkDelegate = this.ContinueToNextTalkDelegate;
				if (continueToNextTalkDelegate == null)
				{
					return;
				}
				continueToNextTalkDelegate();
			}
		}

		// Token: 0x06029B4A RID: 170826 RVA: 0x00BC9E44 File Offset: 0x00BC8044
		public bool TryDelayPlayNextTalk()
		{
			if (!this.GetIsAutoPlay())
			{
				return false;
			}
			if (!this.IsTalkFinished())
			{
				return false;
			}
			this.DelayPlayNextTalk();
			return true;
		}

		// Token: 0x06029B4B RID: 170827 RVA: 0x00BC9E61 File Offset: 0x00BC8061
		private void DelayPlayNextTalk()
		{
			this.RemoveDelayTimer();
			this.DelayTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.RemoveDelayTimer();
				Action continueToNextTalkDelegate = this.ContinueToNextTalkDelegate;
				if (continueToNextTalkDelegate == null)
				{
					return;
				}
				continueToNextTalkDelegate();
			}, this.WaitTime, null, null, true, 1f);
		}

		// Token: 0x06029B4C RID: 170828 RVA: 0x00BC9E93 File Offset: 0x00BC8093
		private void RemoveDelayTimer()
		{
			if (this.DelayTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimer);
				this.DelayTimer = null;
			}
		}

		// Token: 0x06029B4D RID: 170829 RVA: 0x00BC9EB5 File Offset: 0x00BC80B5
		public void Clear()
		{
			this.RemoveDelayTimer();
			this.CheckTalkFinishedDelegate = null;
			this.ContinueToNextTalkDelegate = null;
		}

		// Token: 0x06029B4E RID: 170830 RVA: 0x00BC9ECC File Offset: 0x00BC80CC
		public void SetToggleActive(bool active)
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle == null)
			{
				return;
			}
			UUIItem uuiitem = toggle.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(active);
		}

		// Token: 0x06029B4F RID: 170831 RVA: 0x00BC9EFC File Offset: 0x00BC80FC
		public bool IsTalkFinished()
		{
			return this.CheckTalkFinishedDelegate != null && this.CheckTalkFinishedDelegate();
		}

		// Token: 0x06029B50 RID: 170832 RVA: 0x00BC9F13 File Offset: 0x00BC8113
		public bool GetIsAutoPlay()
		{
			return PlotModel.Instance.PlotConfig.AutoPlayState > EAutoPlayState.Manual;
		}

		// Token: 0x04016C15 RID: 93205
		private UUIExtendToggle Toggle;

		// Token: 0x04016C16 RID: 93206
		private TimerHandle DelayTimer;

		// Token: 0x04016C17 RID: 93207
		private float WaitTime;

		// Token: 0x04016C18 RID: 93208
		private Func<bool> CheckTalkFinishedDelegate;

		// Token: 0x04016C19 RID: 93209
		private Action ContinueToNextTalkDelegate;
	}
}
