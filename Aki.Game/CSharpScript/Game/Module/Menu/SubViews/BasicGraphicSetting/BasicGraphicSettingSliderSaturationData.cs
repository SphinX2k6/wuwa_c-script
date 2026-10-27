using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02005454 RID: 21588
	public class BasicGraphicSettingSliderSaturationData : BasicGraphicSettingSliderData
	{
		// Token: 0x060371D8 RID: 225752 RVA: 0x00D105DB File Offset: 0x00D0E7DB
		[NullableContext(1)]
		public BasicGraphicSettingSliderSaturationData(MenuData metaData) : base(metaData)
		{
		}

		// Token: 0x060371D9 RID: 225753 RVA: 0x00D105E4 File Offset: 0x00D0E7E4
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
