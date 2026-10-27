using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005061 RID: 20577
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotSkipComponent
	{
		// Token: 0x06034A72 RID: 215666 RVA: 0x00C71374 File Offset: 0x00C6F574
		public PlotSkipComponent([Nullable(1)] UUIButtonComponent skipButton, Action skipCallback = null, Action clickCallback = null, UiViewBase attachParent = null, Action cancelCallback = null, EUiBehaviourPopType? customConfirmBoxPopType = null, string customConfirmBoxResourceId = null)
		{
			this.SkipButton = skipButton;
			this.SkipItem = skipButton.RootUIComp.Get();
			this.SkipCallback = skipCallback;
			this.ClickCallback = clickCallback;
			this.CancelCallback = cancelCallback;
			this.AttachParent = attachParent;
			this.CustomConfirmBoxPopType = customConfirmBoxPopType;
			this.CustomConfirmBoxResourceId = customConfirmBoxResourceId;
			this.IsActive = false;
			this.SummaryText = null;
			this.SkipButton.OnClickCallBack.Bind(new Action(this.OnSkipButtonClick));
			this.ToggleText = TextConfig.Instance.GetTextById("PlotSkipConfirmToggle");
			if (string.IsNullOrEmpty(this.ToggleText))
			{
				FlowController.Instance.LogError("剧情跳过二次确认框读不到Toggle文本 \"PlotSkipConfirmToggle\"", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ToggleText = "";
			}
		}

		// Token: 0x06034A73 RID: 215667 RVA: 0x00C71450 File Offset: 0x00C6F650
		public void OnClear()
		{
			this.IsActive = false;
			UUIButtonComponent skipButton = this.SkipButton;
			if (skipButton != null)
			{
				skipButton.OnClickCallBack.Unbind();
			}
			this.SkipButton = null;
			this.SkipItem = null;
			this.AttachParent = null;
			this.SummaryText = null;
			this.SkipCallback = null;
			this.ClickCallback = null;
			this.CancelCallback = null;
			if (this.IsConfirmBoxShowing)
			{
				this.IsConfirmBoxShowing = false;
				ConfirmBoxController.Instance.CloseConfirmBoxView();
			}
		}

		// Token: 0x06034A74 RID: 215668 RVA: 0x00C714C4 File Offset: 0x00C6F6C4
		public void AddEventListener()
		{
			EventSystem.Instance.Add<bool>(EEventName.EnableSkipPlot, new Action<bool>(this.EnableSkipButton));
		}

		// Token: 0x06034A75 RID: 215669 RVA: 0x00C714E2 File Offset: 0x00C6F6E2
		public void RemoveEventListener()
		{
			EventSystem.Instance.Remove<bool>(EEventName.EnableSkipPlot, new Action<bool>(this.EnableSkipButton));
		}

		// Token: 0x06034A76 RID: 215670 RVA: 0x00C71500 File Offset: 0x00C6F700
		public void AddSummary(IShowTalkOutline config)
		{
			if (config == null || StringUtils.IsEmpty(config.TidOutline))
			{
				return;
			}
			string flowConfigLocalText = PublicUtil.Instance.GetFlowConfigLocalText(config.TidOutline);
			this.SummaryText = PlotModel.Instance.PlotTextReplacer.Replace(flowConfigLocalText, false);
		}

		// Token: 0x06034A77 RID: 215671 RVA: 0x00C71546 File Offset: 0x00C6F746
		public bool IsSkipButtonEnabled()
		{
			return this.IsActive;
		}

		// Token: 0x06034A78 RID: 215672 RVA: 0x00C71550 File Offset: 0x00C6F750
		public void EnableSkipButton(bool enable)
		{
			if (enable && !PlotModel.Instance.PlotConfig.CanSkip)
			{
				return;
			}
			if (this.IsActive == enable)
			{
				return;
			}
			this.IsActive = enable;
			bool flag = this.IsActive;
			if (flag && InputManager.Instance.IsImmersiveMouseModeEnabled())
			{
				flag = this.ImmersiveInputWakeState;
			}
			UUIItem skipItem = this.SkipItem;
			if (skipItem != null)
			{
				skipItem.SetUIActive(flag);
			}
			if (!this.IsActive)
			{
				if (this.IsConfirmBoxShowing)
				{
					this.IsConfirmBoxShowing = false;
					ConfirmBoxController.Instance.CloseConfirmBoxView();
					Action cancelCallback = this.CancelCallback;
					if (cancelCallback == null)
					{
						return;
					}
					cancelCallback();
					return;
				}
				else if (this.IsSummaryViewShowing)
				{
					this.IsSummaryViewShowing = false;
					UiManager.Instance.CloseView(EUiViewName.SummaryPopView, null);
					Action cancelCallback2 = this.CancelCallback;
					if (cancelCallback2 == null)
					{
						return;
					}
					cancelCallback2();
				}
			}
		}

		// Token: 0x06034A79 RID: 215673 RVA: 0x00C71613 File Offset: 0x00C6F813
		private void HideSkipButtonAfterConfirm()
		{
			this.IsActive = false;
			UUIItem skipItem = this.SkipItem;
			if (skipItem == null)
			{
				return;
			}
			skipItem.SetUIActive(false);
		}

		// Token: 0x06034A7A RID: 215674 RVA: 0x00C71630 File Offset: 0x00C6F830
		private void OnSkipButtonClick()
		{
			if (!this.IsActive)
			{
				return;
			}
			Action clickCallback = this.ClickCallback;
			if (clickCallback != null)
			{
				clickCallback();
			}
			if (!StringUtils.IsEmpty(this.SummaryText))
			{
				SummaryData param = new SummaryData
				{
					Text = this.SummaryText,
					ConfirmFunc = delegate
					{
						if (!this.IsActive)
						{
							return;
						}
						this.IsSummaryViewShowing = false;
						this.HideSkipButtonAfterConfirm();
						Action skipCallback2 = this.SkipCallback;
						if (skipCallback2 == null)
						{
							return;
						}
						skipCallback2();
					},
					CancelFunc = delegate
					{
						if (!this.IsActive)
						{
							return;
						}
						this.IsSummaryViewShowing = false;
						Action cancelCallback = this.CancelCallback;
						if (cancelCallback == null)
						{
							return;
						}
						cancelCallback();
					}
				};
				this.IsSummaryViewShowing = true;
				UiManager.Instance.OpenView(EUiViewName.SummaryPopView, param, null);
				return;
			}
			if (PlotModel.Instance.PlotConfig.IsSkipConfirmBoxShow)
			{
				this.IsSkipConfirmBoxShowTmp = true;
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SkipPlot);
				if (this.CustomConfirmBoxPopType != null)
				{
					confirmBoxDataNew.CustomPopType = this.CustomConfirmBoxPopType;
				}
				if (!string.IsNullOrEmpty(this.CustomConfirmBoxResourceId))
				{
					confirmBoxDataNew.CustomResourceId = this.CustomConfirmBoxResourceId;
				}
				confirmBoxDataNew.HasToggle = true;
				confirmBoxDataNew.ToggleText = this.ToggleText;
				confirmBoxDataNew.SetToggleFunction(new Action<bool>(this.OnToggle));
				confirmBoxDataNew.AttachView = this.AttachParent;
				confirmBoxDataNew.FunctionMap.Add(1, delegate
				{
					if (!this.IsActive)
					{
						return;
					}
					this.IsConfirmBoxShowing = false;
					Action cancelCallback = this.CancelCallback;
					if (cancelCallback == null)
					{
						return;
					}
					cancelCallback();
				});
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					if (!this.IsActive)
					{
						return;
					}
					PlotModel.Instance.PlotConfig.IsSkipConfirmBoxShow = this.IsSkipConfirmBoxShowTmp;
					this.IsConfirmBoxShowing = false;
					this.HideSkipButtonAfterConfirm();
					Action skipCallback2 = this.SkipCallback;
					if (skipCallback2 == null)
					{
						return;
					}
					skipCallback2();
				});
				this.IsConfirmBoxShowing = ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			Action skipCallback = this.SkipCallback;
			if (skipCallback == null)
			{
				return;
			}
			skipCallback();
		}

		// Token: 0x06034A7B RID: 215675 RVA: 0x00C7178E File Offset: 0x00C6F98E
		private void OnToggle(bool isSelectOn)
		{
			if (!this.IsActive)
			{
				return;
			}
			this.IsSkipConfirmBoxShowTmp = !isSelectOn;
		}

		// Token: 0x06034A7C RID: 215676 RVA: 0x00C717A3 File Offset: 0x00C6F9A3
		public void UpdateImmersiveInputWakeState(bool isWake)
		{
			if (isWake && !this.ImmersiveInputWakeState && this.IsActive)
			{
				UUIItem skipItem = this.SkipItem;
				if (skipItem != null)
				{
					skipItem.SetUIActive(true);
				}
			}
			this.ImmersiveInputWakeState = isWake;
		}

		// Token: 0x0401C0F8 RID: 114936
		private bool IsActive;

		// Token: 0x0401C0F9 RID: 114937
		private UUIItem SkipItem;

		// Token: 0x0401C0FA RID: 114938
		private UUIButtonComponent SkipButton;

		// Token: 0x0401C0FB RID: 114939
		private Action SkipCallback;

		// Token: 0x0401C0FC RID: 114940
		private Action ClickCallback;

		// Token: 0x0401C0FD RID: 114941
		private Action CancelCallback;

		// Token: 0x0401C0FE RID: 114942
		private readonly string ToggleText;

		// Token: 0x0401C0FF RID: 114943
		private bool IsSkipConfirmBoxShowTmp = true;

		// Token: 0x0401C100 RID: 114944
		private UiViewBase AttachParent;

		// Token: 0x0401C101 RID: 114945
		private string SummaryText;

		// Token: 0x0401C102 RID: 114946
		private bool IsConfirmBoxShowing;

		// Token: 0x0401C103 RID: 114947
		private bool IsSummaryViewShowing;

		// Token: 0x0401C104 RID: 114948
		private bool ImmersiveInputWakeState = true;

		// Token: 0x0401C105 RID: 114949
		private readonly EUiBehaviourPopType? CustomConfirmBoxPopType;

		// Token: 0x0401C106 RID: 114950
		private readonly string CustomConfirmBoxResourceId;
	}
}
