using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02004946 RID: 18758
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantBarTween
	{
		// Token: 0x0602F0A0 RID: 192672 RVA: 0x00D1D584 File Offset: 0x00D1B784
		private void AccumTweenCall(float value)
		{
			UUISprite accum = this.Accum;
			if (accum == null)
			{
				return;
			}
			accum.SetFillAmount(value);
		}

		// Token: 0x0602F0A1 RID: 192673 RVA: 0x00D1D597 File Offset: 0x00D1B797
		private void PreviewTweenCall(float value)
		{
			UUISprite preview = this.Preview;
			if (preview == null)
			{
				return;
			}
			preview.SetFillAmount(value);
		}

		// Token: 0x0602F0A2 RID: 192674 RVA: 0x00D1D5AC File Offset: 0x00D1B7AC
		public GiantBarTween(UUISprite accum, UUISprite preview)
		{
			this.AccumDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.AccumTweenCall));
			this.PreviewDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.PreviewTweenCall));
			this.Accum = accum;
			this.Preview = preview;
		}

		// Token: 0x0602F0A3 RID: 192675 RVA: 0x00D1D5FC File Offset: 0x00D1B7FC
		public void PlayAccumTo(double target, double time, Action onDone)
		{
			this.KillAccum();
			this.OnAccumDone = onDone;
			UiLayer.Instance.SetShowMaskLayer(GiantBarTween.MaskTag, true);
			UUISprite accum = this.Accum;
			float num = (accum != null) ? accum.GetFillAmount() : 0f;
			if (Math.Abs((double)num - target) < 0.0001)
			{
				UUISprite accum2 = this.Accum;
				if (accum2 != null)
				{
					accum2.SetFillAmount((float)target);
				}
				this.FinishAccum();
				return;
			}
			this.AccumTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.AccumDelegate, num, (float)target, (float)time, 0f, LTweenEase.OutCubic);
			ULTweener accumTweener = this.AccumTweener;
			if (accumTweener != null)
			{
				accumTweener.SetEase(LTweenEase.OutCubic);
			}
			ULTweener accumTweener2 = this.AccumTweener;
			if (accumTweener2 == null)
			{
				return;
			}
			accumTweener2.OnCompleteCallBack.Bind(new Action(this.OnAccumComplete));
		}

		// Token: 0x0602F0A4 RID: 192676 RVA: 0x00D1D6C0 File Offset: 0x00D1B8C0
		private void OnAccumComplete()
		{
			this.KillAccum();
			this.FinishAccum();
		}

		// Token: 0x0602F0A5 RID: 192677 RVA: 0x00D1D6CE File Offset: 0x00D1B8CE
		private void FinishAccum()
		{
			UiLayer.Instance.SetShowMaskLayer(GiantBarTween.MaskTag, false);
			Action onAccumDone = this.OnAccumDone;
			this.OnAccumDone = null;
			if (onAccumDone == null)
			{
				return;
			}
			onAccumDone();
		}

		// Token: 0x0602F0A6 RID: 192678 RVA: 0x00D1D6F7 File Offset: 0x00D1B8F7
		private void KillAccum()
		{
			ULTweener accumTweener = this.AccumTweener;
			if (accumTweener != null)
			{
				accumTweener.Kill(false);
			}
			this.AccumTweener = null;
		}

		// Token: 0x0602F0A7 RID: 192679 RVA: 0x00D1D714 File Offset: 0x00D1B914
		public void PlayPreview(UUISprite preview, double target, double time)
		{
			this.KillPreview();
			this.Preview = preview;
			float fillAmount = preview.GetFillAmount();
			if (Math.Abs((double)fillAmount - target) < 0.0001)
			{
				preview.SetFillAmount((float)target);
				return;
			}
			this.PreviewTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.PreviewDelegate, fillAmount, (float)target, (float)time, 0f, LTweenEase.OutCubic);
			ULTweener previewTweener = this.PreviewTweener;
			if (previewTweener != null)
			{
				previewTweener.SetEase(LTweenEase.OutCubic);
			}
			ULTweener previewTweener2 = this.PreviewTweener;
			if (previewTweener2 == null)
			{
				return;
			}
			previewTweener2.OnCompleteCallBack.Bind(new Action(this.KillPreview));
		}

		// Token: 0x0602F0A8 RID: 192680 RVA: 0x00D1D7A7 File Offset: 0x00D1B9A7
		public void KillPreview()
		{
			ULTweener previewTweener = this.PreviewTweener;
			if (previewTweener != null)
			{
				previewTweener.Kill(false);
			}
			this.PreviewTweener = null;
		}

		// Token: 0x0602F0A9 RID: 192681 RVA: 0x00D1D7C4 File Offset: 0x00D1B9C4
		public void Destroy()
		{
			UiLayer.Instance.SetShowMaskLayer(GiantBarTween.MaskTag, false);
			this.KillAccum();
			this.KillPreview();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.AccumTweenCall));
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.PreviewTweenCall));
			this.Accum = null;
			this.Preview = null;
			this.OnAccumDone = null;
		}

		// Token: 0x04018F47 RID: 102215
		public static readonly string MaskTag = "GiantSystemCollectView";

		// Token: 0x04018F48 RID: 102216
		[Nullable(2)]
		private UUISprite Accum;

		// Token: 0x04018F49 RID: 102217
		[Nullable(2)]
		private UUISprite Preview;

		// Token: 0x04018F4A RID: 102218
		[Nullable(2)]
		private ULTweener AccumTweener;

		// Token: 0x04018F4B RID: 102219
		[Nullable(2)]
		private ULTweener PreviewTweener;

		// Token: 0x04018F4C RID: 102220
		[Nullable(2)]
		private Action OnAccumDone;

		// Token: 0x04018F4D RID: 102221
		private FLTweenFloatSetterDynamic AccumDelegate;

		// Token: 0x04018F4E RID: 102222
		private FLTweenFloatSetterDynamic PreviewDelegate;
	}
}
