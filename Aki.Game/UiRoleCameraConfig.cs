using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Skin;

// Token: 0x020028EB RID: 10475
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class UiRoleCameraConfig : ConfigBase
{
	// Token: 0x06015A0B RID: 88587 RVA: 0x00575828 File Offset: 0x00573A28
	public SUiRoleCameraSetting? GetRoleCameraConfig(string rowName)
	{
		SUiRoleCameraSetting? result;
		DataTableUtil.TryGetDataTableRowStruct<SUiRoleCameraSetting>(EDataTable.UiRoleCameraSettings, rowName, out result);
		return result;
	}

	// Token: 0x06015A0C RID: 88588 RVA: 0x00575841 File Offset: 0x00573A41
	public SUiRoleCameraSetting? GetRoleCameraConfigBySkin(string rowName, int skinId)
	{
		return this.GetRoleCameraConfig(this.GetOverrideRowName(rowName, skinId));
	}

	// Token: 0x06015A0D RID: 88589 RVA: 0x00575854 File Offset: 0x00573A54
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

	// Token: 0x06015A0E RID: 88590 RVA: 0x00575965 File Offset: 0x00573B65
	public SUiRoleCameraSetting? GetDefaultRoleCameraConfig()
	{
		return this.GetRoleCameraConfig("默认");
	}

	// Token: 0x06015A0F RID: 88591 RVA: 0x00575974 File Offset: 0x00573B74
	public SUiRoleCameraOffsetSetting? GetRoleCameraOffsetConfig(string roleBody)
	{
		SUiRoleCameraOffsetSetting? result;
		DataTableUtil.TryGetDataTableRowStruct<SUiRoleCameraOffsetSetting>(EDataTable.UiRoleCameraOffsetSettings, roleBody, out result);
		return result;
	}

	// Token: 0x17001D0D RID: 7437
	// (get) Token: 0x06015A10 RID: 88592 RVA: 0x0057598D File Offset: 0x00573B8D
	public static UiRoleCameraConfig Instance
	{
		get
		{
			return UiRoleCameraConfig._Instance;
		}
	}

	// Token: 0x06015A11 RID: 88593 RVA: 0x00575994 File Offset: 0x00573B94
	public static UiRoleCameraConfig GetOrCreateInstance()
	{
		if (UiRoleCameraConfig._Instance == null)
		{
			UiRoleCameraConfig.CreateInstance();
		}
		return UiRoleCameraConfig._Instance;
	}

	// Token: 0x06015A12 RID: 88594 RVA: 0x005759A8 File Offset: 0x00573BA8
	public static bool CreateInstance()
	{
		if (UiRoleCameraConfig._Instance != null)
		{
			return true;
		}
		UiRoleCameraConfig._Instance = new UiRoleCameraConfig();
		return true;
	}

	// Token: 0x06015A13 RID: 88595 RVA: 0x005759BE File Offset: 0x00573BBE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015A14 RID: 88596 RVA: 0x005759C0 File Offset: 0x00573BC0
	public static void ResetStaticDefaultValue()
	{
		UiRoleCameraConfig._Instance = null;
	}

	// Token: 0x06015A15 RID: 88597 RVA: 0x005759C8 File Offset: 0x00573BC8
	static UiRoleCameraConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiRoleCameraConfig.CreateStaticDefaultValue), new Action(UiRoleCameraConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A0DE RID: 41182
	[Nullable(2)]
	private static UiRoleCameraConfig _Instance;
}
