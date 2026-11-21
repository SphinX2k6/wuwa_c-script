using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200404A RID: 16458
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotAutoSelectOptionComponent
	{
		// Token: 0x06029B88 RID: 170888 RVA: 0x00BCA02C File Offset: 0x00BC822C
		[NullableContext(1)]
		public void Init(IPlotAutoSelectOptionComponentContext context)
		{
			this.OptionLimitBar = context.OptionLimitBar;
			this.AutoSelectTimeBar = context.AutoSelectTimeBar;
			this.ImportantList = context.ImportantList;
			this.ImportantOptionTipsIcon = context.ImportantOptionTipsIcon;
			this.ImportantOptionTipsText = context.ImportantOptionTipsText;
			this.GetCurrentContentDelegate = context.GetCurrentContentDelegate;
			this.GetSelectedOptionDelegate = context.GetSelectedOptionDelegate;
			this.GetOptionItemsDelegate = context.GetOptionItemsDelegate;
			this.GetAudioRemainingTimeDelegate = context.GetAudioRemainingTimeDelegate;
			this.GetAutoSelectExtraWaitTimeDelegate = context.GetAutoSelectExtraWaitTimeDelegate;
			this.SelectOptionByIndexDelegate = context.SelectOptionByIndexDelegate;
			this.SetTextureByPathDelegate = context.SetTextureByPathDelegate;
			this.RefreshAutoPlayButtonDelegate = context.RefreshAutoPlayButtonDelegate;
			this.Clear();
		}

		// Token: 0x06029B89 RID: 170889 RVA: 0x00BCA0DC File Offset: 0x00BC82DC
		public static PlotOptionItem GetDefaultSelectedOptionItem([Nullable(new byte[]
		{
			2,
			1
		})] PlotOptionItem[] optionItems, ITalkItem content)
		{
			if (optionItems == null || optionItems.Length == 0)
			{
				return null;
			}
			List<PlotOptionItem> list = new List<PlotOptionItem>();
			foreach (PlotOptionItem plotOptionItem in optionItems)
			{
				if (plotOptionItem.GetActive())
				{
					list.Add(plotOptionItem);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			foreach (PlotOptionItem plotOptionItem2 in list)
			{
				if (!plotOptionItem2.CheckToggleGray())
				{
					return plotOptionItem2;
				}
			}
			list.Sort((PlotOptionItem a, PlotOptionItem b) => a.OptionIndex - b.OptionIndex);
			int num = (content != null) ? Math.Max(0, FlowController.Instance.GetRecommendedOption(content)) : list[0].OptionIndex;
			foreach (PlotOptionItem plotOptionItem3 in list)
			{
				if (plotOptionItem3.OptionIndex >= num)
				{
					return plotOptionItem3;
				}
			}
			return list[0];
		}

		// Token: 0x06029B8A RID: 170890 RVA: 0x00BCA210 File Offset: 0x00BC8410
		public void Clear()
		{
			this.IsOptionShowing = false;
			this.ResetCountdown(true);
			this.HideImportantTips();
		}

		// Token: 0x06029B8B RID: 170891 RVA: 0x00BCA228 File Offset: 0x00BC8428
		public void OnOptionsShow()
		{
			this.IsOptionShowing = true;
			this.ResetCountdown(true);
			this.HideImportantTips();
			Func<ITalkItem> getCurrentContentDelegate = this.GetCurrentContentDelegate;
			ITalkItem talkItem = (getCurrentContentDelegate != null) ? getCurrentContentDelegate() : null;
			if (((talkItem != null) ? talkItem.Options : null) == null || talkItem.Options.Count == 0)
			{
				return;
			}
			if (this.TryStartTimeLimitCountdown(talkItem))
			{
				return;
			}
			if (this.TryShowDisableAutoSelectTips(talkItem))
			{
				return;
			}
			this.TryStartAutoSelectCountdown(talkItem);
		}

		// Token: 0x06029B8C RID: 170892 RVA: 0x00BCA294 File Offset: 0x00BC8494
		public void OnOptionSelected()
		{
			this.IsOptionShowing = false;
			this.FinishCountdown(false);
			this.RefreshImmersiveMousePause();
		}

		// Token: 0x06029B8D RID: 170893 RVA: 0x00BCA2AC File Offset: 0x00BC84AC
		public void OnAutoPlayStateChanged()
		{
			if (!this.IsOptionShowing)
			{
				return;
			}
			this.RefreshImmersiveMousePause();
			if (this.CountdownMode == PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.TimeLimit)
			{
				return;
			}
			this.ResetCountdown(true);
			this.HideImportantTips();
			Func<ITalkItem> getCurrentContentDelegate = this.GetCurrentContentDelegate;
			ITalkItem talkItem = (getCurrentContentDelegate != null) ? getCurrentContentDelegate() : null;
			if (talkItem == null)
			{
				return;
			}
			if (talkItem.TimeLimitOptionGroup != null)
			{
				return;
			}
			if (this.TryShowDisableAutoSelectTips(talkItem))
			{
				return;
			}
			this.TryStartAutoSelectCountdown(talkItem);
		}

		// Token: 0x06029B8E RID: 170894 RVA: 0x00BCA311 File Offset: 0x00BC8511
		public void OnImmersiveInputStateChange()
		{
			this.RefreshImmersiveMousePause();
		}

		// Token: 0x06029B8F RID: 170895 RVA: 0x00BCA31C File Offset: 0x00BC851C
		public void OnSelectedOptionChanged()
		{
			if (this.CountdownMode != PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.AutoSelect)
			{
				return;
			}
			Func<ITalkItem> getCurrentContentDelegate = this.GetCurrentContentDelegate;
			ITalkItem talkItem = (getCurrentContentDelegate != null) ? getCurrentContentDelegate() : null;
			if (talkItem == null)
			{
				return;
			}
			this.TryRefreshAutoSelectCountdownOption(talkItem);
		}

		// Token: 0x06029B90 RID: 170896 RVA: 0x00BCA354 File Offset: 0x00BC8554
		public void OnTick(float delta, bool isMute)
		{
			if (this.CountdownMode == PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.None || isMute)
			{
				return;
			}
			this.OptionLimitTimeDuration += delta;
			this.RefreshAutoSelectCountdownByAudioRemaining();
			UUISliderComponent currentCountdownBar = this.GetCurrentCountdownBar();
			if (currentCountdownBar != null)
			{
				currentCountdownBar.SetValue(Math.Max(0f, 1f - this.OptionLimitTimeDuration / this.OptionLimitTime), true);
			}
			if (this.OptionLimitTimeDuration >= this.OptionLimitTime)
			{
				this.FinishCountdown(true);
			}
		}

		// Token: 0x06029B91 RID: 170897 RVA: 0x00BCA3C8 File Offset: 0x00BC85C8
		[NullableContext(1)]
		private unsafe bool TryStartTimeLimitCountdown(ITalkItem content)
		{
			if (content.TimeLimitOptionGroup == null)
			{
				return false;
			}
			if (content.TimeLimitOptionGroup.Style.Type != ETimeLimitOptionGroupStyle.Default)
			{
				return false;
			}
			ITimeLimitOptionGroupDefault style = content.TimeLimitOptionGroup.Style;
			if (style.TimeLimit <= 0f || style.TimeoutOptionIndex >= content.Options.Count || style.TimeoutOptionIndex < 0)
			{
				FlowController.Instance.LogError("限时选项配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[PlotAutoSelectOption] 限时选项配置错误";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", content.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("timeoutOptionIndex", style.TimeoutOptionIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("timeLimit", style.TimeLimit);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			this.StartCountdown(PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.TimeLimit, style.TimeoutOptionIndex, style.TimeLimit * 1000f);
			return true;
		}

		// Token: 0x06029B92 RID: 170898 RVA: 0x00BCA4E8 File Offset: 0x00BC86E8
		[NullableContext(1)]
		private bool TryShowDisableAutoSelectTips(ITalkItem content)
		{
			ITalkItemDisableAutoSelectOptionGroup disableAutoSelectConfig = this.GetDisableAutoSelectConfig(content);
			if (disableAutoSelectConfig == null)
			{
				return false;
			}
			this.ShowImportantTips(disableAutoSelectConfig);
			return true;
		}

		// Token: 0x06029B93 RID: 170899 RVA: 0x00BCA50C File Offset: 0x00BC870C
		[NullableContext(1)]
		private bool TryStartAutoSelectCountdown(ITalkItem content)
		{
			if (!this.IsAutoSelectEnabled(content))
			{
				return false;
			}
			PlotOptionItem autoSelectOptionItem = this.GetAutoSelectOptionItem(content);
			if (autoSelectOptionItem == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[PlotAutoSelectOption] 找不到可自动选择的选项";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", content.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			float autoSelectOptionCharPerSec = PlotModel.Instance.PlotGlobalConfig.AutoSelectOptionCharPerSec;
			if (autoSelectOptionCharPerSec <= 0f)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Plot;
				ELogAuthor author2 = ELogAuthor.FZX;
				string message2 = "[PlotAutoSelectOption] 自动选择选项速度配置错误";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AutoSelectOptionCharPerSec", autoSelectOptionCharPerSec);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			float val = Math.Max((float)this.GetTotalDisplayCharLengthOfVisibleOptions() / autoSelectOptionCharPerSec * 1000f, 3000f);
			float audioRemainingTime = this.GetAudioRemainingTime();
			float autoSelectExtraWaitTime = this.GetAutoSelectExtraWaitTime();
			float limitTime = Math.Max(val, audioRemainingTime) + autoSelectExtraWaitTime;
			this.StartCountdown(PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.AutoSelect, autoSelectOptionItem.OptionIndex, limitTime);
			return true;
		}

		// Token: 0x06029B94 RID: 170900 RVA: 0x00BCA5EC File Offset: 0x00BC87EC
		[NullableContext(1)]
		private bool TryRefreshAutoSelectCountdownOption(ITalkItem content)
		{
			if (!this.IsAutoSelectEnabled(content))
			{
				return false;
			}
			PlotOptionItem autoSelectOptionItem = this.GetAutoSelectOptionItem(content);
			if (autoSelectOptionItem == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[PlotAutoSelectOption] 找不到可自动选择的选项";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", content.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.CountdownOptionIndex = autoSelectOptionItem.OptionIndex;
			return true;
		}

		// Token: 0x06029B95 RID: 170901 RVA: 0x00BCA650 File Offset: 0x00BC8850
		private void StartCountdown(PlotAutoSelectOptionComponent.EPlotOptionCountdownMode mode, int optionIndex, float limitTime)
		{
			this.HideImportantTips();
			this.HideCountdownBars();
			this.CountdownMode = mode;
			this.CountdownOptionIndex = optionIndex;
			this.OptionLimitTime = limitTime;
			this.OptionLimitTimeDuration = 0f;
			UUISliderComponent countdownBar = this.GetCountdownBar(mode);
			if (countdownBar != null)
			{
				countdownBar.GetRootComponent().SetUIActive(true);
			}
			if (countdownBar != null)
			{
				countdownBar.SetValue(1f, true);
			}
			this.RefreshImmersiveMousePause();
		}

		// Token: 0x06029B96 RID: 170902 RVA: 0x00BCA6BC File Offset: 0x00BC88BC
		private void FinishCountdown(bool needSelect)
		{
			if (this.CountdownMode == PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.None)
			{
				return;
			}
			PlotAutoSelectOptionComponent.EPlotOptionCountdownMode countdownMode = this.CountdownMode;
			int countdownOptionIndex = this.CountdownOptionIndex;
			Func<ITalkItem> getCurrentContentDelegate = this.GetCurrentContentDelegate;
			ITalkItem content = (getCurrentContentDelegate != null) ? getCurrentContentDelegate() : null;
			this.ResetCountdown(true);
			bool flag = false;
			if (needSelect)
			{
				if (countdownMode == PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.AutoSelect)
				{
					PlotOptionItem plotOptionItem = null;
					Func<PlotOptionItem[]> getOptionItemsDelegate = this.GetOptionItemsDelegate;
					PlotOptionItem[] array = (getOptionItemsDelegate != null) ? getOptionItemsDelegate() : null;
					if (array != null)
					{
						foreach (PlotOptionItem plotOptionItem2 in array)
						{
							if (plotOptionItem2.OptionIndex == countdownOptionIndex)
							{
								plotOptionItem = plotOptionItem2;
								break;
							}
						}
					}
					if (plotOptionItem != null)
					{
						if (!plotOptionItem.IsOptionConditionSatisfied())
						{
							this.PauseAutoSelectByLockedOption(content, countdownOptionIndex);
						}
						else
						{
							plotOptionItem.OptionClick(new bool?(true));
							flag = true;
						}
					}
					else if (this.IsConfiguredOptionLocked(content, countdownOptionIndex))
					{
						this.PauseAutoSelectByLockedOption(content, countdownOptionIndex);
					}
					else
					{
						Action<int> selectOptionByIndexDelegate = this.SelectOptionByIndexDelegate;
						if (selectOptionByIndexDelegate != null)
						{
							selectOptionByIndexDelegate(countdownOptionIndex);
						}
						flag = true;
					}
				}
				else
				{
					this.SelectTimeLimitOption(countdownOptionIndex);
					flag = true;
				}
				if (flag)
				{
					this.IsOptionShowing = false;
					this.RefreshImmersiveMousePause();
				}
			}
		}

		// Token: 0x06029B97 RID: 170903 RVA: 0x00BCA7C0 File Offset: 0x00BC89C0
		private void SelectTimeLimitOption(int optionIndex)
		{
			PlotOptionItem plotOptionItem = null;
			Func<PlotOptionItem[]> getOptionItemsDelegate = this.GetOptionItemsDelegate;
			PlotOptionItem[] array = (getOptionItemsDelegate != null) ? getOptionItemsDelegate() : null;
			if (array != null)
			{
				foreach (PlotOptionItem plotOptionItem2 in array)
				{
					if (plotOptionItem2.OptionIndex == optionIndex)
					{
						plotOptionItem = plotOptionItem2;
						break;
					}
				}
			}
			if (plotOptionItem != null)
			{
				plotOptionItem.OptionClick(new bool?(true));
				return;
			}
			Func<ITalkItem> getCurrentContentDelegate = this.GetCurrentContentDelegate;
			ITalkItem talkItem = (getCurrentContentDelegate != null) ? getCurrentContentDelegate() : null;
			if (talkItem == null)
			{
				return;
			}
			PlotModel.Instance.MarkGrayOption(talkItem.Id, optionIndex);
			Action<int> selectOptionByIndexDelegate = this.SelectOptionByIndexDelegate;
			if (selectOptionByIndexDelegate == null)
			{
				return;
			}
			selectOptionByIndexDelegate(optionIndex);
		}

		// Token: 0x06029B98 RID: 170904 RVA: 0x00BCA857 File Offset: 0x00BC8A57
		private void ResetCountdown(bool hideBar)
		{
			this.CountdownMode = PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.None;
			this.OptionLimitTime = 0f;
			this.OptionLimitTimeDuration = 0f;
			this.CountdownOptionIndex = -1;
			if (hideBar)
			{
				this.HideCountdownBars();
			}
			this.RefreshImmersiveMousePause();
		}

		// Token: 0x06029B99 RID: 170905 RVA: 0x00BCA88C File Offset: 0x00BC8A8C
		private UUISliderComponent GetCurrentCountdownBar()
		{
			return this.GetCountdownBar(this.CountdownMode);
		}

		// Token: 0x06029B9A RID: 170906 RVA: 0x00BCA89A File Offset: 0x00BC8A9A
		private UUISliderComponent GetCountdownBar(PlotAutoSelectOptionComponent.EPlotOptionCountdownMode mode)
		{
			if (mode == PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.AutoSelect)
			{
				return this.AutoSelectTimeBar ?? this.OptionLimitBar;
			}
			return this.OptionLimitBar;
		}

		// Token: 0x06029B9B RID: 170907 RVA: 0x00BCA8B7 File Offset: 0x00BC8AB7
		private void HideCountdownBars()
		{
			UUISliderComponent optionLimitBar = this.OptionLimitBar;
			if (optionLimitBar != null)
			{
				optionLimitBar.GetRootComponent().SetUIActive(false);
			}
			UUISliderComponent autoSelectTimeBar = this.AutoSelectTimeBar;
			if (autoSelectTimeBar == null)
			{
				return;
			}
			autoSelectTimeBar.GetRootComponent().SetUIActive(false);
		}

		// Token: 0x06029B9C RID: 170908 RVA: 0x00BCA8E8 File Offset: 0x00BC8AE8
		private void RefreshImmersiveMousePause()
		{
			bool flag = this.ShouldPauseImmersiveMouseForAutoOption();
			if (this.IsImmersiveMousePaused == flag)
			{
				return;
			}
			this.IsImmersiveMousePaused = flag;
			if (flag)
			{
				InputManager.Instance.PauseImmersiveMouseMode(EImmersiveMouseModeReason.PlotAutoSelectOptionHover, true, true, true);
				return;
			}
			InputManager.Instance.ResumeImmersiveMouseMode(EImmersiveMouseModeReason.PlotAutoSelectOptionHover);
		}

		// Token: 0x06029B9D RID: 170909 RVA: 0x00BCA932 File Offset: 0x00BC8B32
		private bool ShouldPauseImmersiveMouseForAutoOption()
		{
			return this.IsOptionShowing && PlotModel.Instance.PlotConfig.AutoPlayState == EAutoPlayState.Auto && InputManager.Instance.GetImmersiveInputWakeState() && this.HasVisibleOptionItem();
		}

		// Token: 0x06029B9E RID: 170910 RVA: 0x00BCA964 File Offset: 0x00BC8B64
		private bool HasVisibleOptionItem()
		{
			Func<PlotOptionItem[]> getOptionItemsDelegate = this.GetOptionItemsDelegate;
			PlotOptionItem[] array = (getOptionItemsDelegate != null) ? getOptionItemsDelegate() : null;
			if (array == null)
			{
				return false;
			}
			PlotOptionItem[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i].GetActive())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06029B9F RID: 170911 RVA: 0x00BCA9A8 File Offset: 0x00BC8BA8
		private int GetTotalDisplayCharLengthOfVisibleOptions()
		{
			Func<PlotOptionItem[]> getOptionItemsDelegate = this.GetOptionItemsDelegate;
			PlotOptionItem[] array = (getOptionItemsDelegate != null) ? getOptionItemsDelegate() : null;
			if (array == null || array.Length == 0)
			{
				return 0;
			}
			int num = 0;
			foreach (PlotOptionItem plotOptionItem in array)
			{
				if (plotOptionItem.GetActive())
				{
					num += plotOptionItem.GetDisplayCharLength();
				}
			}
			return num;
		}

		// Token: 0x06029BA0 RID: 170912 RVA: 0x00BCA9FC File Offset: 0x00BC8BFC
		private float GetAudioRemainingTime()
		{
			float val = 0f;
			Func<float> getAudioRemainingTimeDelegate = this.GetAudioRemainingTimeDelegate;
			return Math.Max(val, (getAudioRemainingTimeDelegate != null) ? getAudioRemainingTimeDelegate() : 0f);
		}

		// Token: 0x06029BA1 RID: 170913 RVA: 0x00BCAA1E File Offset: 0x00BC8C1E
		private float GetAutoSelectExtraWaitTime()
		{
			float val = 0f;
			Func<float> getAutoSelectExtraWaitTimeDelegate = this.GetAutoSelectExtraWaitTimeDelegate;
			return Math.Max(val, (getAutoSelectExtraWaitTimeDelegate != null) ? getAutoSelectExtraWaitTimeDelegate() : 0f);
		}

		// Token: 0x06029BA2 RID: 170914 RVA: 0x00BCAA40 File Offset: 0x00BC8C40
		private void RefreshAutoSelectCountdownByAudioRemaining()
		{
			if (this.CountdownMode != PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.AutoSelect)
			{
				return;
			}
			float audioRemainingTime = this.GetAudioRemainingTime();
			if (audioRemainingTime <= 0f)
			{
				return;
			}
			float num = this.OptionLimitTime - this.OptionLimitTimeDuration;
			float num2 = audioRemainingTime + this.GetAutoSelectExtraWaitTime();
			if (num2 <= num)
			{
				return;
			}
			this.OptionLimitTime = this.OptionLimitTimeDuration + num2;
		}

		// Token: 0x06029BA3 RID: 170915 RVA: 0x00BCAA94 File Offset: 0x00BC8C94
		private PlotOptionItem GetAutoSelectOptionItem(ITalkItem content)
		{
			Func<PlotOptionItem> getSelectedOptionDelegate = this.GetSelectedOptionDelegate;
			PlotOptionItem plotOptionItem = (getSelectedOptionDelegate != null) ? getSelectedOptionDelegate() : null;
			if (plotOptionItem != null && plotOptionItem.GetActive() && !plotOptionItem.CheckToggleGray())
			{
				return plotOptionItem;
			}
			Func<PlotOptionItem[]> getOptionItemsDelegate = this.GetOptionItemsDelegate;
			return PlotAutoSelectOptionComponent.GetDefaultSelectedOptionItem((getOptionItemsDelegate != null) ? getOptionItemsDelegate() : null, content);
		}

		// Token: 0x06029BA4 RID: 170916 RVA: 0x00BCAAE4 File Offset: 0x00BC8CE4
		private bool IsConfiguredOptionLocked(ITalkItem content, int optionIndex)
		{
			if (((content != null) ? content.Options : null) == null || optionIndex < 0 || optionIndex >= content.Options.Count)
			{
				return false;
			}
			ITalkOption option = content.Options[optionIndex];
			return !PlotModel.Instance.CheckOptionCondition(option, optionIndex, content);
		}

		// Token: 0x06029BA5 RID: 170917 RVA: 0x00BCAB30 File Offset: 0x00BC8D30
		private void PauseAutoSelectByLockedOption(ITalkItem content, int optionIndex)
		{
			PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
			plotConfig.AutoPlayState = EAutoPlayState.Manual;
			plotConfig.AutoPlayStateCache = EAutoPlayState.Manual;
			this.ResetCountdown(true);
			this.HideImportantTips();
			Action refreshAutoPlayButtonDelegate = this.RefreshAutoPlayButtonDelegate;
			if (refreshAutoPlayButtonDelegate != null)
			{
				refreshAutoPlayButtonDelegate();
			}
			ITalkOption talkOption = null;
			if (((content != null) ? content.Options : null) != null && optionIndex >= 0 && optionIndex < content.Options.Count)
			{
				talkOption = content.Options[optionIndex];
			}
			string text;
			if (talkOption != null)
			{
				IOptionLockTip optionLockTip = talkOption.OptionLockTip;
				if (((optionLockTip != null) ? optionLockTip.TidHintText : null) != null)
				{
					text = PublicUtil.Instance.GetConfigTextByKey(talkOption.OptionLockTip.TidHintText);
					goto IL_AE;
				}
			}
			text = (ConfigMultiTextLang.GetLocalTextNew("LockedOptionPauseAutoSelection", null) ?? "LockedOptionPauseAutoSelection");
			IL_AE:
			ScrollingTipsController.Instance.ShowTipsByText(text);
		}

		// Token: 0x06029BA6 RID: 170918 RVA: 0x00BCABF8 File Offset: 0x00BC8DF8
		[NullableContext(1)]
		private bool IsAutoSelectEnabled(ITalkItem content)
		{
			return PlotModel.Instance.PlotConfig.AutoPlayState == EAutoPlayState.Auto && content.Type.GetValueOrDefault() != ETalkItemType.SystemOption;
		}

		// Token: 0x06029BA7 RID: 170919 RVA: 0x00BCAC30 File Offset: 0x00BC8E30
		[NullableContext(1)]
		[return: Nullable(2)]
		private ITalkItemDisableAutoSelectOptionGroup GetDisableAutoSelectConfig(ITalkItem content)
		{
			ITalkItemDialog talkItemDialog = content as ITalkItemDialog;
			if (talkItemDialog != null)
			{
				ITalkItemAutoPlayConfig autoPlayConfig = talkItemDialog.AutoPlayConfig;
				if (autoPlayConfig == null)
				{
					return null;
				}
				return autoPlayConfig.DisableAutoSelectOptionGroup;
			}
			else
			{
				ITalkItemOption talkItemOption = content as ITalkItemOption;
				if (talkItemOption == null)
				{
					return null;
				}
				ITalkItemAutoPlayConfig autoPlayConfig2 = talkItemOption.AutoPlayConfig;
				if (autoPlayConfig2 == null)
				{
					return null;
				}
				return autoPlayConfig2.DisableAutoSelectOptionGroup;
			}
		}

		// Token: 0x06029BA8 RID: 170920 RVA: 0x00BCAC78 File Offset: 0x00BC8E78
		[NullableContext(1)]
		private void ShowImportantTips(ITalkItemDisableAutoSelectOptionGroup config)
		{
			string text = StringUtils.IsEmpty(config.TextKey) ? "ImportantSelectionDefault" : config.TextKey;
			UUIText importantOptionTipsText = this.ImportantOptionTipsText;
			if (importantOptionTipsText != null)
			{
				importantOptionTipsText.SetText(ConfigMultiTextLang.GetLocalTextNew(text, null) ?? text, true);
			}
			int? iconId = config.IconId;
			string text2;
			if (iconId != null)
			{
				int valueOrDefault = iconId.GetValueOrDefault();
				if (valueOrDefault != 0)
				{
					TalkOptionIcon? talkOptionIcon;
					text2 = (((ConfigTalkOptionIconById.GetConfig(valueOrDefault, true) != null) ? talkOptionIcon.GetValueOrDefault().Icon : null) ?? "/Game/Aki/UI/UIResources/Common/Image/InteractionIcon/T_InteractionExclamation.T_InteractionExclamation");
					goto IL_89;
				}
			}
			text2 = "/Game/Aki/UI/UIResources/Common/Image/InteractionIcon/T_InteractionExclamation.T_InteractionExclamation";
			IL_89:
			string arg = text2;
			if (this.ImportantOptionTipsIcon != null)
			{
				Action<string, UUITexture> setTextureByPathDelegate = this.SetTextureByPathDelegate;
				if (setTextureByPathDelegate != null)
				{
					setTextureByPathDelegate(arg, this.ImportantOptionTipsIcon);
				}
			}
			UUIItem importantList = this.ImportantList;
			if (importantList == null)
			{
				return;
			}
			importantList.SetUIActive(true);
		}

		// Token: 0x06029BA9 RID: 170921 RVA: 0x00BCAD40 File Offset: 0x00BC8F40
		private void HideImportantTips()
		{
			UUIItem importantList = this.ImportantList;
			if (importantList == null)
			{
				return;
			}
			importantList.SetUIActive(false);
		}

		// Token: 0x04016C27 RID: 93223
		private const int INVALID_OPTION_INDEX = -1;

		// Token: 0x04016C28 RID: 93224
		private const float MIN_AUTO_SELECT_WAIT_TIME = 3000f;

		// Token: 0x04016C29 RID: 93225
		[Nullable(1)]
		private const string DEFAULT_IMPORTANT_TEXT_KEY = "ImportantSelectionDefault";

		// Token: 0x04016C2A RID: 93226
		[Nullable(1)]
		private const string DEFAULT_IMPORTANT_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/InteractionIcon/T_InteractionExclamation.T_InteractionExclamation";

		// Token: 0x04016C2B RID: 93227
		[Nullable(1)]
		private const string LOCKED_OPTION_TIPS_TEXT_ID = "LockedOptionPauseAutoSelection";

		// Token: 0x04016C2C RID: 93228
		private UUISliderComponent OptionLimitBar;

		// Token: 0x04016C2D RID: 93229
		private UUISliderComponent AutoSelectTimeBar;

		// Token: 0x04016C2E RID: 93230
		private UUIItem ImportantList;

		// Token: 0x04016C2F RID: 93231
		private UUITexture ImportantOptionTipsIcon;

		// Token: 0x04016C30 RID: 93232
		private UUIText ImportantOptionTipsText;

		// Token: 0x04016C31 RID: 93233
		private Func<ITalkItem> GetCurrentContentDelegate;

		// Token: 0x04016C32 RID: 93234
		private Func<PlotOptionItem> GetSelectedOptionDelegate;

		// Token: 0x04016C33 RID: 93235
		[Nullable(new byte[]
		{
			2,
			2,
			1
		})]
		private Func<PlotOptionItem[]> GetOptionItemsDelegate;

		// Token: 0x04016C34 RID: 93236
		private Func<float> GetAudioRemainingTimeDelegate;

		// Token: 0x04016C35 RID: 93237
		private Func<float> GetAutoSelectExtraWaitTimeDelegate;

		// Token: 0x04016C36 RID: 93238
		private Action<int> SelectOptionByIndexDelegate;

		// Token: 0x04016C37 RID: 93239
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<string, UUITexture> SetTextureByPathDelegate;

		// Token: 0x04016C38 RID: 93240
		private Action RefreshAutoPlayButtonDelegate;

		// Token: 0x04016C39 RID: 93241
		private PlotAutoSelectOptionComponent.EPlotOptionCountdownMode CountdownMode;

		// Token: 0x04016C3A RID: 93242
		private float OptionLimitTime;

		// Token: 0x04016C3B RID: 93243
		private float OptionLimitTimeDuration;

		// Token: 0x04016C3C RID: 93244
		private int CountdownOptionIndex = -1;

		// Token: 0x04016C3D RID: 93245
		private bool IsOptionShowing;

		// Token: 0x04016C3E RID: 93246
		private bool IsImmersiveMousePaused;

		// Token: 0x02009C54 RID: 40020
		[NullableContext(0)]
		private enum EPlotOptionCountdownMode
		{
			// Token: 0x04030A50 RID: 199248
			None,
			// Token: 0x04030A51 RID: 199249
			TimeLimit,
			// Token: 0x04030A52 RID: 199250
			AutoSelect
		}
	}
}
