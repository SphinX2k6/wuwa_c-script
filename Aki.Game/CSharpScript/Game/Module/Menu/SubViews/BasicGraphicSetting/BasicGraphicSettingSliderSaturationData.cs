using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02004437 RID: 17463
	public class BasicGraphicSettingSliderSaturationData : BasicGraphicSettingSliderData
	{
		// Token: 0x0602C121 RID: 180513 RVA: 0x00C5F9F3 File Offset: 0x00C5DBF3
		[NullableContext(1)]
		public BasicGraphicSettingSliderSaturationData(MenuData metaData) : base(metaData)
		{
		}

		// Token: 0x0602C122 RID: 180514 RVA: 0x00C5F9FC File Offset: 0x00C5DBFC
		public new void OnChangeValue(float value)
		{
			float from = 0f;
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
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetUiShowColorSettingMaterialParameterCollection(), RenderConfig.UIShowSaturation, parameterValue);
			this.CurValueInternal = value;
		}
	}
}
