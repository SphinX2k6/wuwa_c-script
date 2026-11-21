using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02004438 RID: 17464
	public class BasicGraphicSettingSliderContrastData : BasicGraphicSettingSliderData
	{
		// Token: 0x0602C123 RID: 180515 RVA: 0x00C5FA8E File Offset: 0x00C5DC8E
		[NullableContext(1)]
		public BasicGraphicSettingSliderContrastData(MenuData metaData) : base(metaData)
		{
		}

		// Token: 0x0602C124 RID: 180516 RVA: 0x00C5FA98 File Offset: 0x00C5DC98
		public new void OnChangeValue(float value)
		{
			float from = 0.5f;
			float to = 2f;
			float parameterValue = 1f;
			if (value <= 50f)
			{
				parameterValue = MathUtils.Instance.Lerp(from, 1f, value * 2f / 100f);
			}
			if (value > 50f)
			{
				parameterValue = MathUtils.Instance.Lerp(1f, to, (value - 50f) * 2f / 100f);
			}
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetUiShowColorSettingMaterialParameterCollection(), RenderConfig.UIShowContrast, parameterValue);
			this.CurValueInternal = value;
		}
	}
}
