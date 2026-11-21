using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004042 RID: 16450
	public class TransitionPopupView : UiViewBase
	{
		// Token: 0x06029B1F RID: 170783 RVA: 0x00BC921F File Offset: 0x00BC741F
		[NullableContext(1)]
		public TransitionPopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06029B20 RID: 170784 RVA: 0x00BC9228 File Offset: 0x00BC7428
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06029B21 RID: 170785 RVA: 0x00BC9294 File Offset: 0x00BC7494
		protected override void OnStart()
		{
			TransitionPopupViewParams transitionPopupViewParams = this.OpenParam as TransitionPopupViewParams;
			UUIText text = base.GetText(0);
			UUIText text2 = base.GetText(1);
			if (((transitionPopupViewParams != null) ? transitionPopupViewParams.Style : null) != null)
			{
				ValueTuple<string, string> styleTexts = this.GetStyleTexts(transitionPopupViewParams.Style);
				string item = styleTexts.Item1;
				string item2 = styleTexts.Item2;
				this.ShowText(text, item);
				this.ShowText(text2, item2);
			}
			else
			{
				TransitionPopup? transitionPopup = (transitionPopupViewParams != null && transitionPopupViewParams.BoardId != null) ? ConfigTransitionPopupById.GetConfig(transitionPopupViewParams.BoardId.Value, true) : null;
				if (transitionPopup != null)
				{
					this.ShowText(text, transitionPopup.Value.Title);
					this.ShowText(text2, transitionPopup.Value.ContentText);
				}
				else
				{
					if (text != null)
					{
						text.SetUIActive(false);
					}
					if (text2 != null)
					{
						text2.SetUIActive(false);
					}
				}
			}
			if (transitionPopupViewParams == null || !transitionPopupViewParams.InPlot)
			{
				BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.Plot, null, 1);
				this.IsHideBattleView = true;
				this.IsLimitOperation = true;
			}
			this.Duration = (((transitionPopupViewParams != null) ? transitionPopupViewParams.Duration : null) ?? PlotModel.Instance.PlotGlobalConfig.TransitionPopupTime);
		}

		// Token: 0x06029B22 RID: 170786 RVA: 0x00BC93F0 File Offset: 0x00BC75F0
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		private ValueTuple<string, string> GetStyleTexts(ITransitionPopupStyle style)
		{
			ITransitionPopupLeftTopTip transitionPopupLeftTopTip = style as ITransitionPopupLeftTopTip;
			ValueTuple<string, string> result;
			if (transitionPopupLeftTopTip == null)
			{
				ITransitionPopupLeftBottomTransition transitionPopupLeftBottomTransition = style as ITransitionPopupLeftBottomTransition;
				if (transitionPopupLeftBottomTransition == null)
				{
					result = new ValueTuple<string, string>(null, null);
				}
				else
				{
					result = new ValueTuple<string, string>(transitionPopupLeftBottomTransition.TitleText, transitionPopupLeftBottomTransition.ContentText);
				}
			}
			else
			{
				result = new ValueTuple<string, string>(transitionPopupLeftTopTip.TitleText, transitionPopupLeftTopTip.ContentText);
			}
			return result;
		}

		// Token: 0x06029B23 RID: 170787 RVA: 0x00BC9444 File Offset: 0x00BC7644
		[NullableContext(2)]
		private void ShowText(UUIText textWidget, string tid)
		{
			if (!string.IsNullOrEmpty(tid))
			{
				if (textWidget != null)
				{
					textWidget.ShowTextNew(tid);
					return;
				}
			}
			else if (textWidget != null)
			{
				textWidget.SetUIActive(false);
			}
		}

		// Token: 0x06029B24 RID: 170788 RVA: 0x00BC9463 File Offset: 0x00BC7663
		protected override void OnAfterShow()
		{
			TimerSystem.Instance.Delay(delegate(float _)
			{
				base.CloseMe(null);
			}, this.Duration * 1000f, null, null, true, 1f);
		}

		// Token: 0x06029B25 RID: 170789 RVA: 0x00BC9490 File Offset: 0x00BC7690
		protected override void OnBeforeDestroy()
		{
			if (this.IsHideBattleView)
			{
				BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.Plot, 1);
			}
			this.IsLimitOperation = false;
			this.IsHideBattleView = false;
		}

		// Token: 0x04016C04 RID: 93188
		private bool IsHideBattleView;

		// Token: 0x04016C05 RID: 93189
		public bool IsLimitOperation;

		// Token: 0x04016C06 RID: 93190
		private float Duration;

		// Token: 0x02009C48 RID: 40008
		private static class EChildComp
		{
			// Token: 0x04030A23 RID: 199203
			public const int TitleText = 0;

			// Token: 0x04030A24 RID: 199204
			public const int ContentText = 1;
		}
	}
}
