using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x0200596D RID: 22893
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantBarTween
	{
		// Token: 0x0603A17A RID: 237946 RVA: 0x00DCE2FC File Offset: 0x00DCC4FC
		private void AccumTweenCall(float value)
		{
			UUISprite accum = this.Accum;
			if (accum == null)
			{
				return;
			}
			accum.SetFillAmount(value);
		}

		// Token: 0x0603A17B RID: 237947 RVA: 0x00DCE30F File Offset: 0x00DCC50F
		private void PreviewTweenCall(float value)
		{
			UUISprite preview = this.Preview;
			if (preview == null)
			{
				return;
			}
			preview.SetFillAmount(value);
		}

		// Token: 0x0603A17C RID: 237948 RVA: 0x00DCE324 File Offset: 0x00DCC524
		public GiantBarTween(UUISprite accum, UUISprite preview)
		{
			this.AccumDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.AccumTweenCall));
			this.PreviewDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.PreviewTweenCall));
			this.Accum = accum;
			this.Preview = preview;
		}

		// Token: 0x0603A17D RID: 237949 RVA: 0x00DCE374 File Offset: 0x00DCC574
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

		// Token: 0x0603A17E RID: 237950 RVA: 0x00DCE438 File Offset: 0x00DCC638
		private void OnAccumComplete()
		{
			this.KillAccum();
			this.FinishAccum();
		}

		// Token: 0x0603A17F RID: 237951 RVA: 0x00DCE446 File Offset: 0x00DCC646
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

		// Token: 0x0603A180 RID: 237952 RVA: 0x00DCE46F File Offset: 0x00DCC66F
		private void KillAccum()
		{
			ULTweener accumTweener = this.AccumTweener;
			if (accumTweener != null)
			{
				accumTweener.Kill(false);
			}
			this.AccumTweener = null;
		}

		// Token: 0x0603A181 RID: 237953 RVA: 0x00DCE48C File Offset: 0x00DCC68C
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

		// Token: 0x0603A182 RID: 237954 RVA: 0x00DCE51F File Offset: 0x00DCC71F
		public void KillPreview()
		{
			ULTweener previewTweener = this.PreviewTweener;
			if (previewTweener != null)
			{
				previewTweener.Kill(false);
			}
			this.PreviewTweener = null;
		}

		// Token: 0x0603A183 RID: 237955 RVA: 0x00DCE53C File Offset: 0x00DCC73C
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

		// Token: 0x0401E4A9 RID: 124073
		public static readonly string MaskTag = "GiantSystemCollectView";

		// Token: 0x0401E4AA RID: 124074
		[Nullable(2)]
		private UUISprite Accum;

		// Token: 0x0401E4AB RID: 124075
		[Nullable(2)]
		private UUISprite Preview;

		// Token: 0x0401E4AC RID: 124076
		[Nullable(2)]
		private ULTweener AccumTweener;

		// Token: 0x0401E4AD RID: 124077
		[Nullable(2)]
		private ULTweener PreviewTweener;

		// Token: 0x0401E4AE RID: 124078
		[Nullable(2)]
		private Action OnAccumDone;

		// Token: 0x0401E4AF RID: 124079
		private FLTweenFloatSetterDynamic AccumDelegate;

		// Token: 0x0401E4B0 RID: 124080
		private FLTweenFloatSetterDynamic PreviewDelegate;
	}
}
