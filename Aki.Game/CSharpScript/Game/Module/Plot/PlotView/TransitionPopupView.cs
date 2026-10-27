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
	// Token: 0x02005072 RID: 20594
	public class TransitionPopupView : UiViewBase
	{
		// Token: 0x06034C2A RID: 216106 RVA: 0x00C7BE47 File Offset: 0x00C7A047
		[NullableContext(1)]
		public TransitionPopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034C2B RID: 216107 RVA: 0x00C7BE50 File Offset: 0x00C7A050
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

		// Token: 0x06034C2C RID: 216108 RVA: 0x00C7BEBC File Offset: 0x00C7A0BC
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

		// Token: 0x06034C2D RID: 216109 RVA: 0x00C7C018 File Offset: 0x00C7A218
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

		// Token: 0x06034C2E RID: 216110 RVA: 0x00C7C06C File Offset: 0x00C7A26C
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

		// Token: 0x06034C2F RID: 216111 RVA: 0x00C7C08B File Offset: 0x00C7A28B
		protected override void OnAfterShow()
		{
			TimerSystem.Instance.Delay(delegate(float _)
			{
				base.CloseMe(null);
			}, this.Duration * 1000f, null, null, true, 1f);
		}

		// Token: 0x06034C30 RID: 216112 RVA: 0x00C7C0B8 File Offset: 0x00C7A2B8
		protected override void OnBeforeDestroy()
		{
			if (this.IsHideBattleView)
			{
				BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.Plot, 1);
			}
			this.IsLimitOperation = false;
			this.IsHideBattleView = false;
		}

		// Token: 0x0401C1D9 RID: 115161
		private bool IsHideBattleView;

		// Token: 0x0401C1DA RID: 115162
		public bool IsLimitOperation;

		// Token: 0x0401C1DB RID: 115163
		private float Duration;

		// Token: 0x0200B20F RID: 45583
		private static class EChildComp
		{
			// Token: 0x04035FCF RID: 221135
			public const int TitleText = 0;

			// Token: 0x04035FD0 RID: 221136
			public const int ContentText = 1;
		}
	}
}
