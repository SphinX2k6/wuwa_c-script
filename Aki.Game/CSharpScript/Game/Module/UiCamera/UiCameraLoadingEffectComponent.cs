using System;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200398F RID: 14735
	public class UiCameraLoadingEffectComponent : UiCameraComponent
	{
		// Token: 0x17004D68 RID: 19816
		// (get) Token: 0x06025EEC RID: 155372 RVA: 0x00AA642A File Offset: 0x00AA462A
		// (set) Token: 0x06025EED RID: 155373 RVA: 0x00AA6432 File Offset: 0x00AA4632
		public bool IsPlaying { get; private set; }

		// Token: 0x17004D69 RID: 19817
		// (get) Token: 0x06025EEE RID: 155374 RVA: 0x00AA643B File Offset: 0x00AA463B
		// (set) Token: 0x06025EEF RID: 155375 RVA: 0x00AA6443 File Offset: 0x00AA4643
		public bool HasEffect { get; private set; }

		// Token: 0x06025EF0 RID: 155376 RVA: 0x00AA644C File Offset: 0x00AA464C
		public void Play(float duration, float focalDistance, float aperture)
		{
			UiCameraDisplayComponent component = base.Mode.GetComponent<UiCameraDisplayComponent>();
			this.Duration = MathF.Max(duration / (float)TimeUtil.Instance.InverseMillisecond, 0f);
			this.Elapsed = 0f;
			this.SourceFocalDistance = component.GetManualFocusDistance();
			this.SourceAperture = component.GetCurrentAperture();
			this.TargetFocalDistance = focalDistance;
			this.TargetAperture = aperture;
			this.IsPlaying = (this.Duration > 0f);
			this.HasEffect = true;
			this.SetInputBlocked(this.IsPlaying);
			if (!this.IsPlaying)
			{
				component.SetLoadingEffect(this.TargetFocalDistance, this.TargetAperture);
			}
		}

		// Token: 0x06025EF1 RID: 155377 RVA: 0x00AA64F3 File Offset: 0x00AA46F3
		public void Stop()
		{
			this.Duration = 0f;
			this.Elapsed = 0f;
			this.IsPlaying = false;
			this.HasEffect = false;
			base.Mode.GetComponent<UiCameraDisplayComponent>().ClearLoadingEffect();
			this.SetInputBlocked(false);
		}

		// Token: 0x06025EF2 RID: 155378 RVA: 0x00AA6530 File Offset: 0x00AA4730
		public override void Tick(float deltaTime)
		{
			if (!this.IsPlaying)
			{
				return;
			}
			this.Elapsed = MathF.Min(this.Elapsed + deltaTime, this.Duration);
			float alpha = (this.Duration > 0f) ? (this.Elapsed / this.Duration) : 1f;
			base.Mode.GetComponent<UiCameraDisplayComponent>().SetLoadingEffect(UiCameraLoadingEffectComponent.Lerp(this.SourceFocalDistance, this.TargetFocalDistance, alpha), UiCameraLoadingEffectComponent.Lerp(this.SourceAperture, this.TargetAperture, alpha));
			if (this.Elapsed >= this.Duration)
			{
				this.Duration = 0f;
				this.Elapsed = 0f;
				this.IsPlaying = false;
				this.SetInputBlocked(false);
			}
		}

		// Token: 0x06025EF3 RID: 155379 RVA: 0x00AA65E7 File Offset: 0x00AA47E7
		public override void Clear()
		{
			this.Stop();
		}

		// Token: 0x06025EF4 RID: 155380 RVA: 0x00AA65F0 File Offset: 0x00AA47F0
		private void SetInputBlocked(bool blocked)
		{
			UiCameraNormalMode uiCameraNormalMode = base.Mode as UiCameraNormalMode;
			if (uiCameraNormalMode != null)
			{
				uiCameraNormalMode.SetInputBlocked(EUiCameraInputBlockReason.Loading, blocked);
			}
		}

		// Token: 0x06025EF5 RID: 155381 RVA: 0x00AA6614 File Offset: 0x00AA4814
		private static float Lerp(float from, float to, float alpha)
		{
			return from + (to - from) * alpha;
		}

		// Token: 0x04014DC4 RID: 85444
		private float Duration;

		// Token: 0x04014DC5 RID: 85445
		private float Elapsed;

		// Token: 0x04014DC6 RID: 85446
		private float SourceFocalDistance;

		// Token: 0x04014DC7 RID: 85447
		private float TargetFocalDistance;

		// Token: 0x04014DC8 RID: 85448
		private float SourceAperture;

		// Token: 0x04014DC9 RID: 85449
		private float TargetAperture;
	}
}
