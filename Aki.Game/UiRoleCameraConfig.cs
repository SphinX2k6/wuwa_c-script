using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001E66 RID: 7782
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class UiRoleCameraConfig : ConfigBase
{
	// Token: 0x0601340F RID: 78863 RVA: 0x005A06F4 File Offset: 0x0059E8F4
	public SUiRoleCameraSetting? GetRoleCameraConfig(string rowName)
	{
		SUiRoleCameraSetting? result;
		DataTableUtil.TryGetDataTableRowStruct<SUiRoleCameraSetting>(EDataTable.UiRoleCameraSettings, rowName, out result);
		return result;
	}

	// Token: 0x06013410 RID: 78864 RVA: 0x005A070D File Offset: 0x0059E90D
	public SUiRoleCameraSetting? GetRoleCameraConfigBySkin(string rowName, int skinId)
	{
		return this.GetRoleCameraConfig(this.GetOverrideRowName(rowName, skinId));
	}

	// Token: 0x06013411 RID: 78865 RVA: 0x005A0720 File Offset: 0x0059E920
	private unsafe string GetOverrideRowName(string rowName, int skinId)
	{
		if (skinId <= 0)
		{
			return rowName;
		}
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(skinId);
		if (roleSkinConfig == null)
		{
			return rowName;
		}
		int uiCameraSettingOverridesLength = roleSkinConfig.Value.UiCameraSettingOverridesLength;
		for (int i = 0; i < uiCameraSettingOverridesLength; i++)
		{
			DicStringString? dicStringString = roleSkinConfig.Value.UiCameraSettingOverrides(i);
			if (dicStringString != null && !(dicStringString.Value.Key != rowName))
			{
				string value = dicStringString.Value.Value;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "相机配置按皮肤替换";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("皮肤Id", skinId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("原配置行", rowName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("替换为", value);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return value;
			}
		}
		return rowName;
	}

	// Token: 0x06013412 RID: 78866 RVA: 0x005A0831 File Offset: 0x0059EA31
	public SUiRoleCameraSetting? GetDefaultRoleCameraConfig()
	{
		return this.GetRoleCameraConfig("默认");
	}

	// Token: 0x06013413 RID: 78867 RVA: 0x005A0840 File Offset: 0x0059EA40
	public SUiRoleCameraOffsetSetting? GetRoleCameraOffsetConfig(string roleBody)
	{
		SUiRoleCameraOffsetSetting? result;
		DataTableUtil.TryGetDataTableRowStruct<SUiRoleCameraOffsetSetting>(EDataTable.UiRoleCameraOffsetSettings, roleBody, out result);
		return result;
	}

	// Token: 0x17001D67 RID: 7527
	// (get) Token: 0x06013414 RID: 78868 RVA: 0x005A0859 File Offset: 0x0059EA59
	public static UiRoleCameraConfig Instance
	{
		get
		{
			return UiRoleCameraConfig._Instance;
		}
	}

	// Token: 0x06013415 RID: 78869 RVA: 0x005A0860 File Offset: 0x0059EA60
	public static UiRoleCameraConfig GetOrCreateInstance()
	{
		if (UiRoleCameraConfig._Instance == null)
		{
			UiRoleCameraConfig.CreateInstance();
		}
		return UiRoleCameraConfig._Instance;
	}

	// Token: 0x06013416 RID: 78870 RVA: 0x005A0874 File Offset: 0x0059EA74
	public static bool CreateInstance()
	{
		if (UiRoleCameraConfig._Instance != null)
		{
			return true;
		}
		UiRoleCameraConfig._Instance = new UiRoleCameraConfig();
		return true;
	}

	// Token: 0x06013417 RID: 78871 RVA: 0x005A088A File Offset: 0x0059EA8A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013418 RID: 78872 RVA: 0x005A088C File Offset: 0x0059EA8C
	public static void ResetStaticDefaultValue()
	{
		UiRoleCameraConfig._Instance = null;
	}

	// Token: 0x06013419 RID: 78873 RVA: 0x005A0894 File Offset: 0x0059EA94
	static UiRoleCameraConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiRoleCameraConfig.CreateStaticDefaultValue), new Action(UiRoleCameraConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A4C8 RID: 42184
	[Nullable(2)]
	private static UiRoleCameraConfig _Instance;
}
