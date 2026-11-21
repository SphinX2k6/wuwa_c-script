using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02004435 RID: 17461
	public class BasicGraphicSettingData : IStaticVariableResetter
	{
		// Token: 0x0602C118 RID: 180504 RVA: 0x00C5F7C8 File Offset: 0x00C5D9C8
		static BasicGraphicSettingData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BasicGraphicSettingData.CreateStaticDefaultValue), new Action(BasicGraphicSettingData.ResetStaticDefaultValue));
		}

		// Token: 0x0602C119 RID: 180505 RVA: 0x00C5F7E7 File Offset: 0x00C5D9E7
		public static void CreateStaticDefaultValue()
		{
			BasicGraphicSettingData.BasicGraphicFunctionIds = new EFunction[]
			{
				EFunction.BRIGHTNESS,
				EFunction.Saturation,
				EFunction.Contrast
			};
		}

		// Token: 0x0602C11A RID: 180506 RVA: 0x00C5F7FF File Offset: 0x00C5D9FF
		public static void ResetStaticDefaultValue()
		{
			BasicGraphicSettingData.BasicGraphicFunctionIds = null;
		}

		// Token: 0x0602C11B RID: 180507 RVA: 0x00C5F808 File Offset: 0x00C5DA08
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

		// Token: 0x0602C11C RID: 180508 RVA: 0x00C5F848 File Offset: 0x00C5DA48
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

		// Token: 0x04017BD4 RID: 97236
		[Nullable(2)]
		private static EFunction[] BasicGraphicFunctionIds;
	}
}
