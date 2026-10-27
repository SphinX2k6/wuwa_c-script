using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005077 RID: 20599
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class PlotAutoPlayComponent
	{
		// Token: 0x06034C50 RID: 216144 RVA: 0x00C7C8F8 File Offset: 0x00C7AAF8
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

		// Token: 0x06034C51 RID: 216145 RVA: 0x00C7C957 File Offset: 0x00C7AB57
		private void OnToggleStateChange(EToggleState state)
		{
			this.ChangeAutoPlay(state == EToggleState.ETT_Checked);
		}

		// Token: 0x06034C52 RID: 216146 RVA: 0x00C7C964 File Offset: 0x00C7AB64
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

		// Token: 0x06034C53 RID: 216147 RVA: 0x00C7C9CC File Offset: 0x00C7ABCC
		public void UpdateAutoPlayToggle()
		{
			EToggleState state = (PlotModel.Instance.PlotConfig.AutoPlayState > EAutoPlayState.Manual) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.Toggle.SetToggleState(state, false, false, false);
		}

		// Token: 0x06034C54 RID: 216148 RVA: 0x00C7CA04 File Offset: 0x00C7AC04
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

		// Token: 0x06034C55 RID: 216149 RVA: 0x00C7CA6C File Offset: 0x00C7AC6C
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

		// Token: 0x06034C56 RID: 216150 RVA: 0x00C7CA89 File Offset: 0x00C7AC89
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

		// Token: 0x06034C57 RID: 216151 RVA: 0x00C7CABB File Offset: 0x00C7ACBB
		private void RemoveDelayTimer()
		{
			if (this.DelayTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayTimer);
				this.DelayTimer = null;
			}
		}

		// Token: 0x06034C58 RID: 216152 RVA: 0x00C7CADD File Offset: 0x00C7ACDD
		public void Clear()
		{
			this.RemoveDelayTimer();
			this.CheckTalkFinishedDelegate = null;
			this.ContinueToNextTalkDelegate = null;
		}

		// Token: 0x06034C59 RID: 216153 RVA: 0x00C7CAF4 File Offset: 0x00C7ACF4
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

		// Token: 0x06034C5A RID: 216154 RVA: 0x00C7CB24 File Offset: 0x00C7AD24
		public bool IsTalkFinished()
		{
			return this.CheckTalkFinishedDelegate != null && this.CheckTalkFinishedDelegate();
		}

		// Token: 0x06034C5B RID: 216155 RVA: 0x00C7CB3B File Offset: 0x00C7AD3B
		public bool GetIsAutoPlay()
		{
			return PlotModel.Instance.PlotConfig.AutoPlayState > EAutoPlayState.Manual;
		}

		// Token: 0x0401C1EA RID: 115178
		private UUIExtendToggle Toggle;

		// Token: 0x0401C1EB RID: 115179
		private TimerHandle DelayTimer;

		// Token: 0x0401C1EC RID: 115180
		private float WaitTime;

		// Token: 0x0401C1ED RID: 115181
		private Func<bool> CheckTalkFinishedDelegate;

		// Token: 0x0401C1EE RID: 115182
		private Action ContinueToNextTalkDelegate;
	}
}
