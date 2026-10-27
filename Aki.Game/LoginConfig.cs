using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002090 RID: 8336
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LoginConfig : ConfigBase
{
	// Token: 0x0601066C RID: 67180 RVA: 0x003FF897 File Offset: 0x003FDA97
	[NullableContext(2)]
	public IReadOnlyList<InstanceDungeon> GetAllInstanceDungeon()
	{
		return ConfigInstanceDungeonAll.GetConfigList(true);
	}

	// Token: 0x0601066D RID: 67181 RVA: 0x003FF89F File Offset: 0x003FDA9F
	public string GetInstanceDungeonNameById(string id)
	{
		return ConfigMultiTextLang.GetLocalTextNew(id, null) ?? "";
	}

	// Token: 0x0601066E RID: 67182 RVA: 0x003FF8B4 File Offset: 0x003FDAB4
	public int? GetLoginFailResetTime()
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("login_fail_reset_time");
		int? num = intConfig;
		int num2 = 0;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "登录失败次数重置参数错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("loginFailResetTime", intConfig);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return intConfig;
	}

	// Token: 0x0601066F RID: 67183 RVA: 0x003FF910 File Offset: 0x003FDB10
	public int GetLoginFailParam(int loginFailCount)
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("login_fail_params");
		string[] array = (stringConfig != null) ? stringConfig.Split(RuntimeHelpers.CreateSpan<char>(fieldof(<PrivateImplementationDetails>.021830820ECA87353011E7C2ED9A7A72DBF58F2FD2958302244969DC3C07812C2).FieldHandle)) : null;
		if (array == null || array.Length == 0 || array.Length % 2 != 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "登录失败重试参数错误, 请检查个数";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("params", stringConfig);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		int result = 0;
		for (int i = 0; i < array.Length; i += 2)
		{
			int num;
			int num2;
			if (!int.TryParse(array[i], out num) || num <= 0 || !int.TryParse(array[i + 1], out num2) || num2 <= 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Login;
				ELogAuthor author2 = ELogAuthor.ZJC;
				string message2 = "登录失败重试参数错误, ";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("params", stringConfig);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return 0;
			}
			if (loginFailCount >= num)
			{
				result = num2;
			}
		}
		return result;
	}

	// Token: 0x06010670 RID: 67184 RVA: 0x003FF9E0 File Offset: 0x003FDBE0
	public int? GetDefaultSingleMapId()
	{
		return ConfigCommonParamById.GetIntConfig("default_single_map_id");
	}

	// Token: 0x06010671 RID: 67185 RVA: 0x003FF9EC File Offset: 0x003FDBEC
	public int? GetDefaultMultiMapId()
	{
		return ConfigCommonParamById.GetIntConfig("default_multi_map_id");
	}

	// Token: 0x06010672 RID: 67186 RVA: 0x003FF9F8 File Offset: 0x003FDBF8
	public int? GetSdkReloginTime()
	{
		return ConfigCommonParamById.GetIntConfig("sdk_relogin_time");
	}

	// Token: 0x06010673 RID: 67187 RVA: 0x003FFA04 File Offset: 0x003FDC04
	[NullableContext(2)]
	public string GetDevLoginServerIp()
	{
		return ConfigCommonParamById.GetStringConfig("dev_sdk_loginserver_ip");
	}

	// Token: 0x06010674 RID: 67188 RVA: 0x003FFA10 File Offset: 0x003FDC10
	[NullableContext(2)]
	public string GetMainlineLoginServerIp()
	{
		return ConfigCommonParamById.GetStringConfig("mainline_sdk_loginserver_ip");
	}

	// Token: 0x06010675 RID: 67189 RVA: 0x003FFA1C File Offset: 0x003FDC1C
	public string[] GetLoginViewNoExitButtonPackageIdList()
	{
		return ConfigCommonParamById.GetStringConfig("LoginViewNoShowExitButtonPackageIdList").Split(',', StringSplitOptions.None);
	}

	// Token: 0x06010676 RID: 67190 RVA: 0x003FFA30 File Offset: 0x003FDC30
	public string[] GetLoginViewNoAccountButtonPackageIdList()
	{
		return ConfigCommonParamById.GetStringConfig("LoginViewNoAccountButtonPackageIdList").Split(',', StringSplitOptions.None);
	}

	// Token: 0x06010677 RID: 67191 RVA: 0x003FFA44 File Offset: 0x003FDC44
	public ServerLimit? GetServerLimitConfig(string region)
	{
		return ConfigServerLimitById.GetConfig(region, true);
	}

	// Token: 0x17001447 RID: 5191
	// (get) Token: 0x06010678 RID: 67192 RVA: 0x003FFA4D File Offset: 0x003FDC4D
	public static LoginConfig Instance
	{
		get
		{
			return LoginConfig._Instance;
		}
	}

	// Token: 0x06010679 RID: 67193 RVA: 0x003FFA54 File Offset: 0x003FDC54
	public static LoginConfig GetOrCreateInstance()
	{
		if (LoginConfig._Instance == null)
		{
			LoginConfig.CreateInstance();
		}
		return LoginConfig._Instance;
	}

	// Token: 0x0601067A RID: 67194 RVA: 0x003FFA68 File Offset: 0x003FDC68
	public static bool CreateInstance()
	{
		if (LoginConfig._Instance != null)
		{
			return true;
		}
		LoginConfig._Instance = new LoginConfig();
		return true;
	}

	// Token: 0x0601067B RID: 67195 RVA: 0x003FFA7E File Offset: 0x003FDC7E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601067C RID: 67196 RVA: 0x003FFA80 File Offset: 0x003FDC80
	public static void ResetStaticDefaultValue()
	{
		LoginConfig._Instance = null;
	}

	// Token: 0x0601067D RID: 67197 RVA: 0x003FFA88 File Offset: 0x003FDC88
	static LoginConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoginConfig.CreateStaticDefaultValue), new Action(LoginConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007937 RID: 31031
	[Nullable(2)]
	private static LoginConfig _Instance;
}
