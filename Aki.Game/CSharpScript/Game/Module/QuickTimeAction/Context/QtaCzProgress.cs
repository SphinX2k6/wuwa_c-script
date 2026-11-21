using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02003F0F RID: 16143
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaCzProgress
	{
		// Token: 0x06028F0C RID: 167692 RVA: 0x00B7DBA0 File Offset: 0x00B7BDA0
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

		// Token: 0x06028F0D RID: 167693 RVA: 0x00B7DC60 File Offset: 0x00B7BE60
		public void SetSpeed(float speed)
		{
			this.ProgressCfg.AutoSpeed = speed;
		}

		// Token: 0x170052F8 RID: 21240
		// (get) Token: 0x06028F0E RID: 167694 RVA: 0x00B7DC6E File Offset: 0x00B7BE6E
		public bool IsFinish
		{
			get
			{
				return this.Finish;
			}
		}

		// Token: 0x170052F9 RID: 21241
		// (get) Token: 0x06028F0F RID: 167695 RVA: 0x00B7DC76 File Offset: 0x00B7BE76
		public float Progress
		{
			get
			{
				return this.CurProgress;
			}
		}

		// Token: 0x06028F10 RID: 167696 RVA: 0x00B7DC80 File Offset: 0x00B7BE80
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

		// Token: 0x0401640E RID: 91150
		private readonly QtaCzProgressData ProgressCfg = new QtaCzProgressData();

		// Token: 0x0401640F RID: 91151
		private EQtaCustomization_ProgressResetType ResetType;

		// Token: 0x04016410 RID: 91152
		private float CurProgress;

		// Token: 0x04016411 RID: 91153
		private int Dir = 1;

		// Token: 0x04016412 RID: 91154
		private bool Finish;
	}
}
