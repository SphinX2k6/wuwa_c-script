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
	// Token: 0x0200507A RID: 20602
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotAutoSelectOptionComponent
	{
		// Token: 0x06034C93 RID: 216211 RVA: 0x00C7CC54 File Offset: 0x00C7AE54
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

		// Token: 0x06034C94 RID: 216212 RVA: 0x00C7CD04 File Offset: 0x00C7AF04
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

		// Token: 0x06034C95 RID: 216213 RVA: 0x00C7CE38 File Offset: 0x00C7B038
		public void Clear()
		{
			this.IsOptionShowing = false;
			this.ResetCountdown(true);
			this.HideImportantTips();
		}

		// Token: 0x06034C96 RID: 216214 RVA: 0x00C7CE50 File Offset: 0x00C7B050
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

		// Token: 0x06034C97 RID: 216215 RVA: 0x00C7CEBC File Offset: 0x00C7B0BC
		public void OnOptionSelected()
		{
			this.IsOptionShowing = false;
			this.FinishCountdown(false);
			this.RefreshImmersiveMousePause();
		}

		// Token: 0x06034C98 RID: 216216 RVA: 0x00C7CED4 File Offset: 0x00C7B0D4
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

		// Token: 0x06034C99 RID: 216217 RVA: 0x00C7CF39 File Offset: 0x00C7B139
		public void OnImmersiveInputStateChange()
		{
			this.RefreshImmersiveMousePause();
		}

		// Token: 0x06034C9A RID: 216218 RVA: 0x00C7CF44 File Offset: 0x00C7B144
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

		// Token: 0x06034C9B RID: 216219 RVA: 0x00C7CF7C File Offset: 0x00C7B17C
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

		// Token: 0x06034C9C RID: 216220 RVA: 0x00C7CFF0 File Offset: 0x00C7B1F0
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

		// Token: 0x06034C9D RID: 216221 RVA: 0x00C7D110 File Offset: 0x00C7B310
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

		// Token: 0x06034C9E RID: 216222 RVA: 0x00C7D134 File Offset: 0x00C7B334
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

		// Token: 0x06034C9F RID: 216223 RVA: 0x00C7D214 File Offset: 0x00C7B414
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

		// Token: 0x06034CA0 RID: 216224 RVA: 0x00C7D278 File Offset: 0x00C7B478
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

		// Token: 0x06034CA1 RID: 216225 RVA: 0x00C7D2E4 File Offset: 0x00C7B4E4
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

		// Token: 0x06034CA2 RID: 216226 RVA: 0x00C7D3E8 File Offset: 0x00C7B5E8
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

		// Token: 0x06034CA3 RID: 216227 RVA: 0x00C7D47F File Offset: 0x00C7B67F
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

		// Token: 0x06034CA4 RID: 216228 RVA: 0x00C7D4B4 File Offset: 0x00C7B6B4
		private UUISliderComponent GetCurrentCountdownBar()
		{
			return this.GetCountdownBar(this.CountdownMode);
		}

		// Token: 0x06034CA5 RID: 216229 RVA: 0x00C7D4C2 File Offset: 0x00C7B6C2
		private UUISliderComponent GetCountdownBar(PlotAutoSelectOptionComponent.EPlotOptionCountdownMode mode)
		{
			if (mode == PlotAutoSelectOptionComponent.EPlotOptionCountdownMode.AutoSelect)
			{
				return this.AutoSelectTimeBar ?? this.OptionLimitBar;
			}
			return this.OptionLimitBar;
		}

		// Token: 0x06034CA6 RID: 216230 RVA: 0x00C7D4DF File Offset: 0x00C7B6DF
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

		// Token: 0x06034CA7 RID: 216231 RVA: 0x00C7D510 File Offset: 0x00C7B710
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

		// Token: 0x06034CA8 RID: 216232 RVA: 0x00C7D55A File Offset: 0x00C7B75A
		private bool ShouldPauseImmersiveMouseForAutoOption()
		{
			return this.IsOptionShowing && PlotModel.Instance.PlotConfig.AutoPlayState == EAutoPlayState.Auto && InputManager.Instance.GetImmersiveInputWakeState() && this.HasVisibleOptionItem();
		}

		// Token: 0x06034CA9 RID: 216233 RVA: 0x00C7D58C File Offset: 0x00C7B78C
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

		// Token: 0x06034CAA RID: 216234 RVA: 0x00C7D5D0 File Offset: 0x00C7B7D0
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

		// Token: 0x06034CAB RID: 216235 RVA: 0x00C7D624 File Offset: 0x00C7B824
		private float GetAudioRemainingTime()
		{
			float val = 0f;
			Func<float> getAudioRemainingTimeDelegate = this.GetAudioRemainingTimeDelegate;
			return Math.Max(val, (getAudioRemainingTimeDelegate != null) ? getAudioRemainingTimeDelegate() : 0f);
		}

		// Token: 0x06034CAC RID: 216236 RVA: 0x00C7D646 File Offset: 0x00C7B846
		private float GetAutoSelectExtraWaitTime()
		{
			float val = 0f;
			Func<float> getAutoSelectExtraWaitTimeDelegate = this.GetAutoSelectExtraWaitTimeDelegate;
			return Math.Max(val, (getAutoSelectExtraWaitTimeDelegate != null) ? getAutoSelectExtraWaitTimeDelegate() : 0f);
		}

		// Token: 0x06034CAD RID: 216237 RVA: 0x00C7D668 File Offset: 0x00C7B868
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

		// Token: 0x06034CAE RID: 216238 RVA: 0x00C7D6BC File Offset: 0x00C7B8BC
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

		// Token: 0x06034CAF RID: 216239 RVA: 0x00C7D70C File Offset: 0x00C7B90C
		private bool IsConfiguredOptionLocked(ITalkItem content, int optionIndex)
		{
			if (((content != null) ? content.Options : null) == null || optionIndex < 0 || optionIndex >= content.Options.Count)
			{
				return false;
			}
			ITalkOption option = content.Options[optionIndex];
			return !PlotModel.Instance.CheckOptionCondition(option, optionIndex, content);
		}

		// Token: 0x06034CB0 RID: 216240 RVA: 0x00C7D758 File Offset: 0x00C7B958
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

		// Token: 0x06034CB1 RID: 216241 RVA: 0x00C7D820 File Offset: 0x00C7BA20
		[NullableContext(1)]
		private bool IsAutoSelectEnabled(ITalkItem content)
		{
			return PlotModel.Instance.PlotConfig.AutoPlayState == EAutoPlayState.Auto && content.Type.GetValueOrDefault() != ETalkItemType.SystemOption;
		}

		// Token: 0x06034CB2 RID: 216242 RVA: 0x00C7D858 File Offset: 0x00C7BA58
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

		// Token: 0x06034CB3 RID: 216243 RVA: 0x00C7D8A0 File Offset: 0x00C7BAA0
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

		// Token: 0x06034CB4 RID: 216244 RVA: 0x00C7D968 File Offset: 0x00C7BB68
		private void HideImportantTips()
		{
			UUIItem importantList = this.ImportantList;
			if (importantList == null)
			{
				return;
			}
			importantList.SetUIActive(false);
		}

		// Token: 0x0401C1FC RID: 115196
		private const int INVALID_OPTION_INDEX = -1;

		// Token: 0x0401C1FD RID: 115197
		private const float MIN_AUTO_SELECT_WAIT_TIME = 3000f;

		// Token: 0x0401C1FE RID: 115198
		[Nullable(1)]
		private const string DEFAULT_IMPORTANT_TEXT_KEY = "ImportantSelectionDefault";

		// Token: 0x0401C1FF RID: 115199
		[Nullable(1)]
		private const string DEFAULT_IMPORTANT_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/InteractionIcon/T_InteractionExclamation.T_InteractionExclamation";

		// Token: 0x0401C200 RID: 115200
		[Nullable(1)]
		private const string LOCKED_OPTION_TIPS_TEXT_ID = "LockedOptionPauseAutoSelection";

		// Token: 0x0401C201 RID: 115201
		private UUISliderComponent OptionLimitBar;

		// Token: 0x0401C202 RID: 115202
		private UUISliderComponent AutoSelectTimeBar;

		// Token: 0x0401C203 RID: 115203
		private UUIItem ImportantList;

		// Token: 0x0401C204 RID: 115204
		private UUITexture ImportantOptionTipsIcon;

		// Token: 0x0401C205 RID: 115205
		private UUIText ImportantOptionTipsText;

		// Token: 0x0401C206 RID: 115206
		private Func<ITalkItem> GetCurrentContentDelegate;

		// Token: 0x0401C207 RID: 115207
		private Func<PlotOptionItem> GetSelectedOptionDelegate;

		// Token: 0x0401C208 RID: 115208
		[Nullable(new byte[]
		{
			2,
			2,
			1
		})]
		private Func<PlotOptionItem[]> GetOptionItemsDelegate;

		// Token: 0x0401C209 RID: 115209
		private Func<float> GetAudioRemainingTimeDelegate;

		// Token: 0x0401C20A RID: 115210
		private Func<float> GetAutoSelectExtraWaitTimeDelegate;

		// Token: 0x0401C20B RID: 115211
		private Action<int> SelectOptionByIndexDelegate;

		// Token: 0x0401C20C RID: 115212
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<string, UUITexture> SetTextureByPathDelegate;

		// Token: 0x0401C20D RID: 115213
		private Action RefreshAutoPlayButtonDelegate;

		// Token: 0x0401C20E RID: 115214
		private PlotAutoSelectOptionComponent.EPlotOptionCountdownMode CountdownMode;

		// Token: 0x0401C20F RID: 115215
		private float OptionLimitTime;

		// Token: 0x0401C210 RID: 115216
		private float OptionLimitTimeDuration;

		// Token: 0x0401C211 RID: 115217
		private int CountdownOptionIndex = -1;

		// Token: 0x0401C212 RID: 115218
		private bool IsOptionShowing;

		// Token: 0x0401C213 RID: 115219
		private bool IsImmersiveMousePaused;

		// Token: 0x0200B21B RID: 45595
		[NullableContext(0)]
		private enum EPlotOptionCountdownMode
		{
			// Token: 0x04035FFC RID: 221180
			None,
			// Token: 0x04035FFD RID: 221181
			TimeLimit,
			// Token: 0x04035FFE RID: 221182
			AutoSelect
		}
	}
}
