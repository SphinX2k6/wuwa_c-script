using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039AB RID: 14763
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class UiCameraConfig : ConfigBase
	{
		// Token: 0x06026047 RID: 155719 RVA: 0x00AAB1C7 File Offset: 0x00AA93C7
		public UiShow? GetViewConfig(EUiViewName viewName)
		{
			return ConfigUiShowByViewName.GetConfig(viewName, true);
		}

		// Token: 0x06026048 RID: 155720 RVA: 0x00AAB1D8 File Offset: 0x00AA93D8
		public float GetLoadingCameraAnimationLength()
		{
			return (float)ConfigCommonParamById.GetIntConfig("LoadingViewCameraAnimationLength").GetValueOrDefault();
		}

		// Token: 0x06026049 RID: 155721 RVA: 0x00AAB1F8 File Offset: 0x00AA93F8
		public float GetLoadingCameraFocalDistance()
		{
			return ConfigCommonParamById.GetFloatConfig("LoadingViewManualFocusDistance").GetValueOrDefault();
		}

		// Token: 0x0602604A RID: 155722 RVA: 0x00AAB218 File Offset: 0x00AA9418
		public float GetLoadingCameraAperture()
		{
			return ConfigCommonParamById.GetFloatConfig("LoadingViewAperture").GetValueOrDefault();
		}

		// Token: 0x0602604B RID: 155723 RVA: 0x00AAB237 File Offset: 0x00AA9437
		[return: Nullable(2)]
		public SUiCameraAnimationSettings GetUiCameraAnimationConfig(string handleName)
		{
			return DataTableUtil.GetDataTableRowFromName<SUiCameraAnimationSettings>(EDataTable.UiCameraAnimationSettings, handleName);
		}

		// Token: 0x0602604C RID: 155724 RVA: 0x00AAB241 File Offset: 0x00AA9441
		[return: Nullable(2)]
		public SUiCameraAnimationBlendSettings GetUiCameraAnimationBlendData(string blendName)
		{
			return DataTableUtil.GetDataTableRowFromName<SUiCameraAnimationBlendSettings>(EDataTable.UiCameraAnimationBlendSettings, blendName);
		}

		// Token: 0x0602604D RID: 155725 RVA: 0x00AAB24C File Offset: 0x00AA944C
		public UiCameraMapping? GetUiCameraMappingConfig(string viewName)
		{
			this.EnsureUiCameraMappingCache();
			UiCameraMapping value;
			if (this.UiCameraMappingByViewName == null || !this.UiCameraMappingByViewName.TryGetValue(viewName, out value))
			{
				return null;
			}
			return new UiCameraMapping?(value);
		}

		// Token: 0x0602604E RID: 155726 RVA: 0x00AAB288 File Offset: 0x00AA9488
		[NullableContext(2)]
		public string GetBlendName([Nullable(1)] string fromViewName, string toViewName)
		{
			UiCameraMapping? uiCameraMappingConfig = this.GetUiCameraMappingConfig(fromViewName);
			if (uiCameraMappingConfig != null)
			{
				return UiCameraConfig.GetBlendName(uiCameraMappingConfig.Value, toViewName);
			}
			ChildUiCameraMapping? childUiCameraMappingConfig = this.GetChildUiCameraMappingConfig(fromViewName);
			if (childUiCameraMappingConfig != null)
			{
				return UiCameraConfig.GetBlendName(childUiCameraMappingConfig.Value, toViewName);
			}
			return null;
		}

		// Token: 0x0602604F RID: 155727 RVA: 0x00AAB2D4 File Offset: 0x00AA94D4
		[return: Nullable(2)]
		public string GetDefaultHandleName(string viewName)
		{
			UiCameraMapping? uiCameraMappingConfig = this.GetUiCameraMappingConfig(viewName);
			if (uiCameraMappingConfig != null)
			{
				return uiCameraMappingConfig.Value.DefaultUiCameraSettingsName;
			}
			if (this.GetChildUiCameraMappingConfig(viewName) == null)
			{
				return null;
			}
			ChildUiCameraMapping? childUiCameraMapping;
			return childUiCameraMapping.GetValueOrDefault().DefaultUiCameraSettingsName;
		}

		// Token: 0x06026050 RID: 155728 RVA: 0x00AAB324 File Offset: 0x00AA9524
		public int GetUiCameraDelayTime(string viewName)
		{
			UiCameraMapping? uiCameraMappingConfig = this.GetUiCameraMappingConfig(viewName);
			if (uiCameraMappingConfig != null)
			{
				return uiCameraMappingConfig.Value.UiCameraDelayTime;
			}
			if (this.GetChildUiCameraMappingConfig(viewName) == null)
			{
				return 0;
			}
			ChildUiCameraMapping? childUiCameraMapping;
			return childUiCameraMapping.GetValueOrDefault().UiCameraDelayTime;
		}

		// Token: 0x06026051 RID: 155729 RVA: 0x00AAB374 File Offset: 0x00AA9574
		public EUiCameraAnimationTargetType GetBodyTargetType(string viewName)
		{
			UiCameraMapping? uiCameraMappingConfig = this.GetUiCameraMappingConfig(viewName);
			if (uiCameraMappingConfig != null)
			{
				return (EUiCameraAnimationTargetType)uiCameraMappingConfig.Value.BodyTargetType;
			}
			ChildUiCameraMapping? childUiCameraMappingConfig = this.GetChildUiCameraMappingConfig(viewName);
			if (childUiCameraMappingConfig != null)
			{
				return (EUiCameraAnimationTargetType)childUiCameraMappingConfig.Value.BodyTargetType;
			}
			return EUiCameraAnimationTargetType.None;
		}

		// Token: 0x06026052 RID: 155730 RVA: 0x00AAB3C8 File Offset: 0x00AA95C8
		[return: Nullable(2)]
		public string GetBodyHandleName(string viewName, string bodyKey)
		{
			UiCameraMapping? uiCameraMappingConfig = this.GetUiCameraMappingConfig(viewName);
			if (uiCameraMappingConfig != null)
			{
				for (int i = 0; i < uiCameraMappingConfig.Value.BodyCameraSettingsNameMapLength; i++)
				{
					DicStringString? dicStringString = uiCameraMappingConfig.Value.BodyCameraSettingsNameMap(i);
					if (((dicStringString != null) ? dicStringString.GetValueOrDefault().Key : null) == bodyKey && !string.IsNullOrEmpty(dicStringString.Value.Value))
					{
						return dicStringString.Value.Value;
					}
				}
				return null;
			}
			ChildUiCameraMapping? childUiCameraMappingConfig = this.GetChildUiCameraMappingConfig(viewName);
			if (childUiCameraMappingConfig == null)
			{
				return null;
			}
			for (int j = 0; j < childUiCameraMappingConfig.Value.BodyCameraSettingsNameMapLength; j++)
			{
				DicStringString? dicStringString2 = childUiCameraMappingConfig.Value.BodyCameraSettingsNameMap(j);
				if (((dicStringString2 != null) ? dicStringString2.GetValueOrDefault().Key : null) == bodyKey && !string.IsNullOrEmpty(dicStringString2.Value.Value))
				{
					return dicStringString2.Value.Value;
				}
			}
			return null;
		}

		// Token: 0x06026053 RID: 155731 RVA: 0x00AAB4F4 File Offset: 0x00AA96F4
		public bool ShouldPlayLoadingCameraAnimation(string viewName)
		{
			UiCameraMapping? uiCameraMappingConfig = this.GetUiCameraMappingConfig(viewName);
			if (uiCameraMappingConfig != null)
			{
				return uiCameraMappingConfig.Value.BPlayLoadingCameraAnimation;
			}
			ChildUiCameraMapping? childUiCameraMapping;
			return this.GetChildUiCameraMappingConfig(viewName) != null && childUiCameraMapping.GetValueOrDefault().BPlayLoadingCameraAnimation;
		}

		// Token: 0x06026054 RID: 155732 RVA: 0x00AAB544 File Offset: 0x00AA9744
		[NullableContext(2)]
		private static string GetBlendName(UiCameraMapping mapping, string toViewName)
		{
			if (!string.IsNullOrEmpty(toViewName))
			{
				for (int i = 0; i < mapping.UiCameraBlendNameMapLength; i++)
				{
					DicStringString? dicStringString = mapping.UiCameraBlendNameMap(i);
					if (((dicStringString != null) ? dicStringString.GetValueOrDefault().Key : null) == toViewName && !string.IsNullOrEmpty(dicStringString.Value.Value))
					{
						return dicStringString.Value.Value;
					}
				}
			}
			return mapping.DefaultCameraBlendName;
		}

		// Token: 0x06026055 RID: 155733 RVA: 0x00AAB5C4 File Offset: 0x00AA97C4
		[NullableContext(2)]
		private static string GetBlendName(ChildUiCameraMapping mapping, string toViewName)
		{
			if (!string.IsNullOrEmpty(toViewName))
			{
				for (int i = 0; i < mapping.UiCameraBlendNameMapLength; i++)
				{
					DicStringString? dicStringString = mapping.UiCameraBlendNameMap(i);
					if (((dicStringString != null) ? dicStringString.GetValueOrDefault().Key : null) == toViewName && !string.IsNullOrEmpty(dicStringString.Value.Value))
					{
						return dicStringString.Value.Value;
					}
				}
			}
			return mapping.DefaultCameraBlendName;
		}

		// Token: 0x06026056 RID: 155734 RVA: 0x00AAB644 File Offset: 0x00AA9844
		public UiCameraMapping? GetUiCameraMappingConfigById(int cameraId)
		{
			return ConfigUiCameraMappingById.GetConfig(cameraId, true);
		}

		// Token: 0x06026057 RID: 155735 RVA: 0x00AAB650 File Offset: 0x00AA9850
		public ChildUiCameraMapping? GetChildUiCameraMappingConfig(string viewName)
		{
			this.EnsureChildUiCameraMappingCache();
			ChildUiCameraMapping value;
			if (this.ChildUiCameraMappingByViewName == null || !this.ChildUiCameraMappingByViewName.TryGetValue(viewName, out value))
			{
				return null;
			}
			return new ChildUiCameraMapping?(value);
		}

		// Token: 0x06026058 RID: 155736 RVA: 0x00AAB68B File Offset: 0x00AA988B
		[NullableContext(2)]
		public IReadOnlyList<UiCameraMapping> GetAllUiCameraMappingConfig()
		{
			return ConfigUiCameraMappingAll.GetConfigList(true);
		}

		// Token: 0x06026059 RID: 155737 RVA: 0x00AAB693 File Offset: 0x00AA9893
		[NullableContext(2)]
		public IReadOnlyList<ChildUiCameraMapping> GetAllChildUiCameraMappingConfig()
		{
			return ConfigChildUiCameraMappingAll.GetConfigList(true);
		}

		// Token: 0x0602605A RID: 155738 RVA: 0x00AAB69C File Offset: 0x00AA989C
		private void EnsureUiCameraMappingCache()
		{
			if (this.UiCameraMappingByViewName != null)
			{
				return;
			}
			IReadOnlyList<UiCameraMapping> allUiCameraMappingConfig = this.GetAllUiCameraMappingConfig();
			if (allUiCameraMappingConfig == null)
			{
				return;
			}
			this.UiCameraMappingByViewName = new Dictionary<string, UiCameraMapping>(allUiCameraMappingConfig.Count);
			foreach (UiCameraMapping value in allUiCameraMappingConfig)
			{
				this.UiCameraMappingByViewName[value.ViewName] = value;
			}
		}

		// Token: 0x0602605B RID: 155739 RVA: 0x00AAB718 File Offset: 0x00AA9918
		private void EnsureChildUiCameraMappingCache()
		{
			if (this.ChildUiCameraMappingByViewName != null)
			{
				return;
			}
			IReadOnlyList<ChildUiCameraMapping> allChildUiCameraMappingConfig = this.GetAllChildUiCameraMappingConfig();
			if (allChildUiCameraMappingConfig == null)
			{
				return;
			}
			this.ChildUiCameraMappingByViewName = new Dictionary<string, ChildUiCameraMapping>(allChildUiCameraMappingConfig.Count);
			foreach (ChildUiCameraMapping value in allChildUiCameraMappingConfig)
			{
				this.ChildUiCameraMappingByViewName[value.ViewName] = value;
			}
		}

		// Token: 0x17004D97 RID: 19863
		// (get) Token: 0x0602605C RID: 155740 RVA: 0x00AAB794 File Offset: 0x00AA9994
		public static UiCameraConfig Instance
		{
			get
			{
				return UiCameraConfig._Instance;
			}
		}

		// Token: 0x0602605D RID: 155741 RVA: 0x00AAB79B File Offset: 0x00AA999B
		public static UiCameraConfig GetOrCreateInstance()
		{
			if (UiCameraConfig._Instance == null)
			{
				UiCameraConfig.CreateInstance();
			}
			return UiCameraConfig._Instance;
		}

		// Token: 0x0602605E RID: 155742 RVA: 0x00AAB7AF File Offset: 0x00AA99AF
		public static bool CreateInstance()
		{
			if (UiCameraConfig._Instance != null)
			{
				return true;
			}
			UiCameraConfig._Instance = new UiCameraConfig();
			return true;
		}

		// Token: 0x0602605F RID: 155743 RVA: 0x00AAB7C5 File Offset: 0x00AA99C5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06026060 RID: 155744 RVA: 0x00AAB7C7 File Offset: 0x00AA99C7
		public static void ResetStaticDefaultValue()
		{
			UiCameraConfig._Instance = null;
		}

		// Token: 0x06026061 RID: 155745 RVA: 0x00AAB7CF File Offset: 0x00AA99CF
		static UiCameraConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiCameraConfig.CreateStaticDefaultValue), new Action(UiCameraConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04014E36 RID: 85558
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<string, UiCameraMapping> UiCameraMappingByViewName;

		// Token: 0x04014E37 RID: 85559
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<string, ChildUiCameraMapping> ChildUiCameraMappingByViewName;

		// Token: 0x04014E38 RID: 85560
		[Nullable(2)]
		private static UiCameraConfig _Instance;
	}
}
