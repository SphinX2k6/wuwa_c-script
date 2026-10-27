using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02005453 RID: 21587
	public class BasicGraphicSettingSliderBrightnessData : BasicGraphicSettingSliderData
	{
		// Token: 0x060371D5 RID: 225749 RVA: 0x00D1049C File Offset: 0x00D0E69C
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

		// Token: 0x060371D6 RID: 225750 RVA: 0x00D104F4 File Offset: 0x00D0E6F4
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

		// Token: 0x060371D7 RID: 225751 RVA: 0x00D1057C File Offset: 0x00D0E77C
		public new void OnApplyValue()
		{
			float num = MathUtils.Instance.Lerp(-1f, 1f, (this.CurValueInternal + this.Scalar) / (this.Scalar * 2f));
			GameSettingsManager.Instance.HandleValueChange(this.FunctionId.Value, (int)MathF.Round(num * 100f), EGameSettingsApplyReason.WhenUi);
		}

		// Token: 0x0401D13C RID: 119100
		private readonly float Scalar;
	}
}
