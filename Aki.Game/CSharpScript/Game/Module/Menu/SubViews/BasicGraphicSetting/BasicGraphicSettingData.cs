using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02005452 RID: 21586
	public class BasicGraphicSettingData : IStaticVariableResetter
	{
		// Token: 0x060371CF RID: 225743 RVA: 0x00D103B0 File Offset: 0x00D0E5B0
		static BasicGraphicSettingData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BasicGraphicSettingData.CreateStaticDefaultValue), new Action(BasicGraphicSettingData.ResetStaticDefaultValue));
		}

		// Token: 0x060371D0 RID: 225744 RVA: 0x00D103CF File Offset: 0x00D0E5CF
		public static void CreateStaticDefaultValue()
		{
			BasicGraphicSettingData.BasicGraphicFunctionIds = new EFunction[]
			{
				EFunction.BRIGHTNESS,
				EFunction.Saturation,
				EFunction.Contrast
			};
		}

		// Token: 0x060371D1 RID: 225745 RVA: 0x00D103E7 File Offset: 0x00D0E5E7
		public static void ResetStaticDefaultValue()
		{
			BasicGraphicSettingData.BasicGraphicFunctionIds = null;
		}

		// Token: 0x060371D2 RID: 225746 RVA: 0x00D103F0 File Offset: 0x00D0E5F0
		[NullableContext(1)]
		[return: Nullable(2)]
		private static BasicGraphicSettingSliderData CreateBasicGraphicSettingSliderData(MenuData metaData)
		{
			EFunction functionId = metaData.FunctionId;
			if (functionId == EFunction.BRIGHTNESS)
			{
				return new BasicGraphicSettingSliderBrightnessData(metaData);
			}
			if (functionId == EFunction.Saturation)
			{
				return new BasicGraphicSettingSliderSaturationData(metaData);
			}
			if (functionId != EFunction.Contrast)
			{
				return null;
			}
			return new BasicGraphicSettingSliderContrastData(metaData);
		}

		// Token: 0x060371D3 RID: 225747 RVA: 0x00D10430 File Offset: 0x00D0E630
		[NullableContext(1)]
		public static List<BasicGraphicSettingSliderData> GetBasicGraphicSettingSliderDataList()
		{
			List<BasicGraphicSettingSliderData> list = new List<BasicGraphicSettingSliderData>();
			foreach (EFunction key in BasicGraphicSettingData.BasicGraphicFunctionIds)
			{
				MenuConfig metaConfig;
				if (GameSettingsManager.Instance.ValidApplyConfigMap.TryGetValue(key, out metaConfig))
				{
					MenuData menuData = new MenuData(metaConfig);
					if (menuData != null)
					{
						BasicGraphicSettingSliderData basicGraphicSettingSliderData = BasicGraphicSettingData.CreateBasicGraphicSettingSliderData(menuData);
						if (basicGraphicSettingSliderData != null)
						{
							list.Add(basicGraphicSettingSliderData);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0401D13B RID: 119099
		[Nullable(2)]
		private static EFunction[] BasicGraphicFunctionIds;
	}
}
