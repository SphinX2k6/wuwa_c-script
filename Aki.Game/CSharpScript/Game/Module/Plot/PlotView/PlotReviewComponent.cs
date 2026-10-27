using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005059 RID: 20569
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotReviewComponent
	{
		// Token: 0x06034A36 RID: 215606 RVA: 0x00C70510 File Offset: 0x00C6E710
		[NullableContext(1)]
		public PlotReviewComponent(UUIButtonComponent reviewButton, Action clickCallback)
		{
			this.PlotReviewButton = reviewButton;
			this.PlotReviewItem = reviewButton.RootUIComp;
			this.ClickCallback = clickCallback;
			this.PlotReviewButton.OnClickCallBack.Bind(new Action(this.OnReviewButtonClick));
			this.IsActive = false;
		}

		// Token: 0x06034A37 RID: 215607 RVA: 0x00C7056C File Offset: 0x00C6E76C
		public void OnClear()
		{
			this.IsActive = false;
			this.ClickCallback = null;
			UUIButtonComponent plotReviewButton = this.PlotReviewButton;
			if (plotReviewButton == null)
			{
				return;
			}
			plotReviewButton.OnClickCallBack.Unbind();
		}

		// Token: 0x06034A38 RID: 215608 RVA: 0x00C70591 File Offset: 0x00C6E791
		public bool IsReviewButtonEnabled()
		{
			return this.IsActive;
		}

		// Token: 0x06034A39 RID: 215609 RVA: 0x00C7059C File Offset: 0x00C6E79C
		public void EnableReviewButton(bool enable)
		{
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
			UUIItem plotReviewItem = this.PlotReviewItem;
			if (plotReviewItem == null)
			{
				return;
			}
			plotReviewItem.SetUIActive(flag);
		}

		// Token: 0x06034A3A RID: 215610 RVA: 0x00C705E8 File Offset: 0x00C6E7E8
		private void OnReviewButtonClick()
		{
			if (!this.IsActive)
			{
				return;
			}
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x06034A3B RID: 215611 RVA: 0x00C70603 File Offset: 0x00C6E803
		public void UpdateImmersiveInputWakeState(bool isWake)
		{
			if (isWake && !this.ImmersiveInputWakeState && this.IsActive)
			{
				this.PlotReviewItem.SetUIActive(true);
			}
			this.ImmersiveInputWakeState = isWake;
		}

		// Token: 0x0401C0DD RID: 114909
		private bool IsActive;

		// Token: 0x0401C0DE RID: 114910
		private readonly UUIItem PlotReviewItem;

		// Token: 0x0401C0DF RID: 114911
		private readonly UUIButtonComponent PlotReviewButton;

		// Token: 0x0401C0E0 RID: 114912
		private Action ClickCallback;

		// Token: 0x0401C0E1 RID: 114913
		private bool ImmersiveInputWakeState = true;
	}
}
