using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004031 RID: 16433
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotSkipComponent
	{
		// Token: 0x06029965 RID: 170341 RVA: 0x00BBE64C File Offset: 0x00BBC84C
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

		// Token: 0x06029966 RID: 170342 RVA: 0x00BBE728 File Offset: 0x00BBC928
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

		// Token: 0x06029967 RID: 170343 RVA: 0x00BBE79C File Offset: 0x00BBC99C
		public void AddEventListener()
		{
			EventSystem.Instance.Add<bool>(EEventName.EnableSkipPlot, new Action<bool>(this.EnableSkipButton));
		}

		// Token: 0x06029968 RID: 170344 RVA: 0x00BBE7BA File Offset: 0x00BBC9BA
		public void RemoveEventListener()
		{
			EventSystem.Instance.Remove<bool>(EEventName.EnableSkipPlot, new Action<bool>(this.EnableSkipButton));
		}

		// Token: 0x06029969 RID: 170345 RVA: 0x00BBE7D8 File Offset: 0x00BBC9D8
		public void AddSummary(IShowTalkOutline config)
		{
			if (config == null || StringUtils.IsEmpty(config.TidOutline))
			{
				return;
			}
			string flowConfigLocalText = PublicUtil.Instance.GetFlowConfigLocalText(config.TidOutline);
			this.SummaryText = PlotModel.Instance.PlotTextReplacer.Replace(flowConfigLocalText, false);
		}

		// Token: 0x0602996A RID: 170346 RVA: 0x00BBE81E File Offset: 0x00BBCA1E
		public bool IsSkipButtonEnabled()
		{
			return this.IsActive;
		}

		// Token: 0x0602996B RID: 170347 RVA: 0x00BBE828 File Offset: 0x00BBCA28
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

		// Token: 0x0602996C RID: 170348 RVA: 0x00BBE8EB File Offset: 0x00BBCAEB
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

		// Token: 0x0602996D RID: 170349 RVA: 0x00BBE908 File Offset: 0x00BBCB08
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

		// Token: 0x0602996E RID: 170350 RVA: 0x00BBEA66 File Offset: 0x00BBCC66
		private void OnToggle(bool isSelectOn)
		{
			if (!this.IsActive)
			{
				return;
			}
			this.IsSkipConfirmBoxShowTmp = !isSelectOn;
		}

		// Token: 0x0602996F RID: 170351 RVA: 0x00BBEA7B File Offset: 0x00BBCC7B
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

		// Token: 0x04016B23 RID: 92963
		private bool IsActive;

		// Token: 0x04016B24 RID: 92964
		private UUIItem SkipItem;

		// Token: 0x04016B25 RID: 92965
		private UUIButtonComponent SkipButton;

		// Token: 0x04016B26 RID: 92966
		private Action SkipCallback;

		// Token: 0x04016B27 RID: 92967
		private Action ClickCallback;

		// Token: 0x04016B28 RID: 92968
		private Action CancelCallback;

		// Token: 0x04016B29 RID: 92969
		private readonly string ToggleText;

		// Token: 0x04016B2A RID: 92970
		private bool IsSkipConfirmBoxShowTmp = true;

		// Token: 0x04016B2B RID: 92971
		private UiViewBase AttachParent;

		// Token: 0x04016B2C RID: 92972
		private string SummaryText;

		// Token: 0x04016B2D RID: 92973
		private bool IsConfirmBoxShowing;

		// Token: 0x04016B2E RID: 92974
		private bool IsSummaryViewShowing;

		// Token: 0x04016B2F RID: 92975
		private bool ImmersiveInputWakeState = true;

		// Token: 0x04016B30 RID: 92976
		private readonly EUiBehaviourPopType? CustomConfirmBoxPopType;

		// Token: 0x04016B31 RID: 92977
		private readonly string CustomConfirmBoxResourceId;
	}
}
