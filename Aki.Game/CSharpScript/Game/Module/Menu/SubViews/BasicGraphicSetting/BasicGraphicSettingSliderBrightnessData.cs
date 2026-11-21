using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02004436 RID: 17462
	public class BasicGraphicSettingSliderBrightnessData : BasicGraphicSettingSliderData
	{
		// Token: 0x0602C11E RID: 180510 RVA: 0x00C5F8B4 File Offset: 0x00C5DAB4
		[NullableContext(1)]
		public BasicGraphicSettingSliderBrightnessData(MenuData metaData) : base(metaData)
		{
			this.Scalar = 100f;
			int? currentValue = GameSettingsManager.Instance.GetCurrentValue(metaData.FunctionId, true, true);
			if (currentValue != null)
			{
				this.CurValueInternal = (float)currentValue.Value;
				return;
			}
			this.CurValueInternal = metaData.SliderDefault;
		}

		// Token: 0x0602C11F RID: 180511 RVA: 0x00C5F90C File Offset: 0x00C5DB0C
		public new void OnChangeValue(float value)
		{
			float parameterValue = 2.2f;
			if (value <= 0f)
			{
				parameterValue = MathUtils.Instance.Lerp(1.5f, 2.2f, (value + this.Scalar) / this.Scalar);
			}
			if (value > 0f)
			{
				parameterValue = MathUtils.Instance.Lerp(2.2f, 3.5f, value / this.Scalar);
			}
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetUiShowColorSettingMaterialParameterCollection(), RenderConfig.UIShowBrightness, parameterValue);
			this.CurValueInternal = value;
		}

		// Token: 0x0602C120 RID: 180512 RVA: 0x00C5F994 File Offset: 0x00C5DB94
		public new void OnApplyValue()
		{
			float num = MathUtils.Instance.Lerp(-1f, 1f, (this.CurValueInternal + this.Scalar) / (this.Scalar * 2f));
			GameSettingsManager.Instance.HandleValueChange(this.FunctionId.Value, (int)MathF.Round(num * 100f), EGameSettingsApplyReason.WhenUi);
		}

		// Token: 0x04017BD5 RID: 97237
		private readonly float Scalar;
	}
}
