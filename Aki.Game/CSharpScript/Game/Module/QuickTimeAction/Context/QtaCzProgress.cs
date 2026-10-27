using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02004F46 RID: 20294
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaCzProgress
	{
		// Token: 0x0603409E RID: 213150 RVA: 0x00C34400 File Offset: 0x00C32600
		public void InitByConfig(SQtaCustomizationParam_Progress cfg, EQtaCustomization_ProgressResetType resetType = EQtaCustomization_ProgressResetType.停止)
		{
			this.ProgressCfg.InitByConfig(cfg);
			this.ResetType = resetType;
			if (this.ProgressCfg.Max < 0f)
			{
				float max = this.ProgressCfg.Max;
				this.ProgressCfg.Max = ((max < 0f) ? (1f - Math.Abs(this.ProgressCfg.Max)) : max);
			}
			if (this.ProgressCfg.Init < 0f)
			{
				float init = this.ProgressCfg.Init;
				this.CurProgress = MathUtils.Instance.Clamp((init < 0f) ? (this.ProgressCfg.Max + init) : init, 0f, this.ProgressCfg.Max);
			}
		}

		// Token: 0x0603409F RID: 213151 RVA: 0x00C344C0 File Offset: 0x00C326C0
		public void SetSpeed(float speed)
		{
			this.ProgressCfg.AutoSpeed = speed;
		}

		// Token: 0x17007F48 RID: 32584
		// (get) Token: 0x060340A0 RID: 213152 RVA: 0x00C344CE File Offset: 0x00C326CE
		public bool IsFinish
		{
			get
			{
				return this.Finish;
			}
		}

		// Token: 0x17007F49 RID: 32585
		// (get) Token: 0x060340A1 RID: 213153 RVA: 0x00C344D6 File Offset: 0x00C326D6
		public float Progress
		{
			get
			{
				return this.CurProgress;
			}
		}

		// Token: 0x060340A2 RID: 213154 RVA: 0x00C344E0 File Offset: 0x00C326E0
		public void Update(float delta, bool isPressed = false)
		{
			float num = (this.ProgressCfg.AutoSpeed + (isPressed ? this.ProgressCfg.AdditionSpeed : 0f)) * delta * 0.001f * (float)this.Dir;
			this.CurProgress = MathUtils.Instance.Clamp(this.CurProgress + num, 0f, this.ProgressCfg.Max);
			if (this.CurProgress >= this.ProgressCfg.Max || this.CurProgress <= 0f)
			{
				switch (this.ResetType)
				{
				case EQtaCustomization_ProgressResetType.停止:
					break;
				case EQtaCustomization_ProgressResetType.重置:
				{
					float num2 = this.ProgressCfg.AutoSpeed + this.ProgressCfg.AdditionSpeed;
					this.CurProgress = ((num2 > 0f) ? 0f : this.ProgressCfg.Max);
					this.Dir = 1;
					return;
				}
				case EQtaCustomization_ProgressResetType.倒转:
					this.Dir = -this.Dir;
					return;
				case EQtaCustomization_ProgressResetType.结束:
					this.Finish = true;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0401BA39 RID: 113209
		private readonly QtaCzProgressData ProgressCfg = new QtaCzProgressData();

		// Token: 0x0401BA3A RID: 113210
		private EQtaCustomization_ProgressResetType ResetType;

		// Token: 0x0401BA3B RID: 113211
		private float CurProgress;

		// Token: 0x0401BA3C RID: 113212
		private int Dir = 1;

		// Token: 0x0401BA3D RID: 113213
		private bool Finish;
	}
}
