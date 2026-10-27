using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiCameraAnimation
{
	// Token: 0x02004A0E RID: 18958
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraAnimationConfig : ConfigBase
	{
		// Token: 0x06031321 RID: 201505 RVA: 0x00B68E2A File Offset: 0x00B6702A
		public UiShow? GetViewConfig(EUiViewName viewName)
		{
			return ConfigUiShowByViewName.GetConfig(viewName, true);
		}

		// Token: 0x06031322 RID: 201506 RVA: 0x00B68E38 File Offset: 0x00B67038
		[return: Nullable(2)]
		public SUiCameraAnimationSettings GetUiCameraAnimationConfig(string handleName)
		{
			return DataTableUtil.GetDataTableRowFromName<SUiCameraAnimationSettings>(EDataTable.UiCameraAnimationSettings, handleName);
		}

		// Token: 0x06031323 RID: 201507 RVA: 0x00B68E42 File Offset: 0x00B67042
		[return: Nullable(2)]
		public SUiCameraAnimationBlendSettings GetUiCameraAnimationBlendData(string blendDataName)
		{
			return DataTableUtil.GetDataTableRowFromName<SUiCameraAnimationBlendSettings>(EDataTable.UiCameraAnimationBlendSettings, blendDataName);
		}

		// Token: 0x06031324 RID: 201508 RVA: 0x00B68E4C File Offset: 0x00B6704C
		public UiCameraMapping? GetUiCameraMappingConfig(string viewName)
		{
			return ConfigUiCameraMappingByViewName.GetConfig(viewName, true);
		}

		// Token: 0x06031325 RID: 201509 RVA: 0x00B68E55 File Offset: 0x00B67055
		public UiCameraMapping? GetUiCameraMappingConfigById(int cameraId)
		{
			return ConfigUiCameraMappingById.GetConfig(cameraId, true);
		}

		// Token: 0x06031326 RID: 201510 RVA: 0x00B68E5E File Offset: 0x00B6705E
		public ChildUiCameraMapping? GetChildUiCameraMappingConfig(string viewName)
		{
			return ConfigChildUiCameraMappingByViewName.GetConfig(viewName, true);
		}

		// Token: 0x06031327 RID: 201511 RVA: 0x00B68E67 File Offset: 0x00B67067
		[NullableContext(2)]
		public IReadOnlyList<UiCameraMapping> GetAllUiCameraMappingConfig()
		{
			return ConfigUiCameraMappingAll.GetConfigList(true);
		}

		// Token: 0x06031328 RID: 201512 RVA: 0x00B68E6F File Offset: 0x00B6706F
		[NullableContext(2)]
		public IReadOnlyList<ChildUiCameraMapping> GetAllChildUiCameraMappingConfig()
		{
			return ConfigChildUiCameraMappingAll.GetConfigList(true);
		}

		// Token: 0x170079F1 RID: 31217
		// (get) Token: 0x06031329 RID: 201513 RVA: 0x00B68E77 File Offset: 0x00B67077
		public static UiCameraAnimationConfig Instance
		{
			get
			{
				return UiCameraAnimationConfig._Instance;
			}
		}

		// Token: 0x0603132A RID: 201514 RVA: 0x00B68E7E File Offset: 0x00B6707E
		public static UiCameraAnimationConfig GetOrCreateInstance()
		{
			if (UiCameraAnimationConfig._Instance == null)
			{
				UiCameraAnimationConfig.CreateInstance();
			}
			return UiCameraAnimationConfig._Instance;
		}

		// Token: 0x0603132B RID: 201515 RVA: 0x00B68E92 File Offset: 0x00B67092
		public static bool CreateInstance()
		{
			if (UiCameraAnimationConfig._Instance != null)
			{
				return true;
			}
			UiCameraAnimationConfig._Instance = new UiCameraAnimationConfig();
			return true;
		}

		// Token: 0x0603132C RID: 201516 RVA: 0x00B68EA8 File Offset: 0x00B670A8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603132D RID: 201517 RVA: 0x00B68EAA File Offset: 0x00B670AA
		public static void ResetStaticDefaultValue()
		{
			UiCameraAnimationConfig._Instance = null;
		}

		// Token: 0x0603132E RID: 201518 RVA: 0x00B68EB2 File Offset: 0x00B670B2
		static UiCameraAnimationConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiCameraAnimationConfig.CreateStaticDefaultValue), new Action(UiCameraAnimationConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401A4FD RID: 107773
		[Nullable(2)]
		private static UiCameraAnimationConfig _Instance;
	}
}
