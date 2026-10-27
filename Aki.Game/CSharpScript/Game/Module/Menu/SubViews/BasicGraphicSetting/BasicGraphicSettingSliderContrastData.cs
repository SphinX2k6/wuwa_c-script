using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02005455 RID: 21589
	public class BasicGraphicSettingSliderContrastData : BasicGraphicSettingSliderData
	{
		// Token: 0x060371DA RID: 225754 RVA: 0x00D10676 File Offset: 0x00D0E876
		[NullableContext(1)]
		public BasicGraphicSettingSliderContrastData(MenuData metaData) : base(metaData)
		{
		}

		// Token: 0x060371DB RID: 225755 RVA: 0x00D10680 File Offset: 0x00D0E880
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
