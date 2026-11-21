using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004029 RID: 16425
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotReviewComponent
	{
		// Token: 0x06029929 RID: 170281 RVA: 0x00BBD7B0 File Offset: 0x00BBB9B0
		[NullableContext(1)]
		public PlotReviewComponent(UUIButtonComponent reviewButton, Action clickCallback)
		{
			this.PlotReviewButton = reviewButton;
			this.PlotReviewItem = reviewButton.RootUIComp;
			this.ClickCallback = clickCallback;
			this.PlotReviewButton.OnClickCallBack.Bind(new Action(this.OnReviewButtonClick));
			this.IsActive = false;
		}

		// Token: 0x0602992A RID: 170282 RVA: 0x00BBD80C File Offset: 0x00BBBA0C
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

		// Token: 0x0602992B RID: 170283 RVA: 0x00BBD831 File Offset: 0x00BBBA31
		public bool IsReviewButtonEnabled()
		{
			return this.IsActive;
		}

		// Token: 0x0602992C RID: 170284 RVA: 0x00BBD83C File Offset: 0x00BBBA3C
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

		// Token: 0x0602992D RID: 170285 RVA: 0x00BBD888 File Offset: 0x00BBBA88
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

		// Token: 0x0602992E RID: 170286 RVA: 0x00BBD8A3 File Offset: 0x00BBBAA3
		public void UpdateImmersiveInputWakeState(bool isWake)
		{
			if (isWake && !this.ImmersiveInputWakeState && this.IsActive)
			{
				this.PlotReviewItem.SetUIActive(true);
			}
			this.ImmersiveInputWakeState = isWake;
		}

		// Token: 0x04016B08 RID: 92936
		private bool IsActive;

		// Token: 0x04016B09 RID: 92937
		private readonly UUIItem PlotReviewItem;

		// Token: 0x04016B0A RID: 92938
		private readonly UUIButtonComponent PlotReviewButton;

		// Token: 0x04016B0B RID: 92939
		private Action ClickCallback;

		// Token: 0x04016B0C RID: 92940
		private bool ImmersiveInputWakeState = true;
	}
}
