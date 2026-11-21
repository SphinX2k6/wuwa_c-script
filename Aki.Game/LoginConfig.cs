using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001563 RID: 5475
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LoginConfig : ConfigBase
{
	// Token: 0x0600DAD4 RID: 56020 RVA: 0x0040BCDF File Offset: 0x00409EDF
	[NullableContext(2)]
	public IReadOnlyList<InstanceDungeon> GetAllInstanceDungeon()
	{
		return ConfigInstanceDungeonAll.GetConfigList(true);
	}

	// Token: 0x0600DAD5 RID: 56021 RVA: 0x0040BCE7 File Offset: 0x00409EE7
	public string GetInstanceDungeonNameById(string id)
	{
		return ConfigMultiTextLang.GetLocalTextNew(id, null) ?? "";
	}

	// Token: 0x0600DAD6 RID: 56022 RVA: 0x0040BCFC File Offset: 0x00409EFC
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

	// Token: 0x0600DAD7 RID: 56023 RVA: 0x0040BD58 File Offset: 0x00409F58
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

	// Token: 0x0600DAD8 RID: 56024 RVA: 0x0040BE28 File Offset: 0x0040A028
	public int? GetDefaultSingleMapId()
	{
		return ConfigCommonParamById.GetIntConfig("default_single_map_id");
	}

	// Token: 0x0600DAD9 RID: 56025 RVA: 0x0040BE34 File Offset: 0x0040A034
	public int? GetDefaultMultiMapId()
	{
		return ConfigCommonParamById.GetIntConfig("default_multi_map_id");
	}

	// Token: 0x0600DADA RID: 56026 RVA: 0x0040BE40 File Offset: 0x0040A040
	public int? GetSdkReloginTime()
	{
		return ConfigCommonParamById.GetIntConfig("sdk_relogin_time");
	}

	// Token: 0x0600DADB RID: 56027 RVA: 0x0040BE4C File Offset: 0x0040A04C
	[NullableContext(2)]
	public string GetDevLoginServerIp()
	{
		return ConfigCommonParamById.GetStringConfig("dev_sdk_loginserver_ip");
	}

	// Token: 0x0600DADC RID: 56028 RVA: 0x0040BE58 File Offset: 0x0040A058
	[NullableContext(2)]
	public string GetMainlineLoginServerIp()
	{
		return ConfigCommonParamById.GetStringConfig("mainline_sdk_loginserver_ip");
	}

	// Token: 0x0600DADD RID: 56029 RVA: 0x0040BE64 File Offset: 0x0040A064
	public string[] GetLoginViewNoExitButtonPackageIdList()
	{
		return ConfigCommonParamById.GetStringConfig("LoginViewNoShowExitButtonPackageIdList").Split(',', StringSplitOptions.None);
	}

	// Token: 0x0600DADE RID: 56030 RVA: 0x0040BE78 File Offset: 0x0040A078
	public string[] GetLoginViewNoAccountButtonPackageIdList()
	{
		return ConfigCommonParamById.GetStringConfig("LoginViewNoAccountButtonPackageIdList").Split(',', StringSplitOptions.None);
	}

	// Token: 0x0600DADF RID: 56031 RVA: 0x0040BE8C File Offset: 0x0040A08C
	public ServerLimit? GetServerLimitConfig(string region)
	{
		return ConfigServerLimitById.GetConfig(region, true);
	}

	// Token: 0x17001474 RID: 5236
	// (get) Token: 0x0600DAE0 RID: 56032 RVA: 0x0040BE95 File Offset: 0x0040A095
	public static LoginConfig Instance
	{
		get
		{
			return LoginConfig._Instance;
		}
	}

	// Token: 0x0600DAE1 RID: 56033 RVA: 0x0040BE9C File Offset: 0x0040A09C
	public static LoginConfig GetOrCreateInstance()
	{
		if (LoginConfig._Instance == null)
		{
			LoginConfig.CreateInstance();
		}
		return LoginConfig._Instance;
	}

	// Token: 0x0600DAE2 RID: 56034 RVA: 0x0040BEB0 File Offset: 0x0040A0B0
	public static bool CreateInstance()
	{
		if (LoginConfig._Instance != null)
		{
			return true;
		}
		LoginConfig._Instance = new LoginConfig();
		return true;
	}

	// Token: 0x0600DAE3 RID: 56035 RVA: 0x0040BEC6 File Offset: 0x0040A0C6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DAE4 RID: 56036 RVA: 0x0040BEC8 File Offset: 0x0040A0C8
	public static void ResetStaticDefaultValue()
	{
		LoginConfig._Instance = null;
	}

	// Token: 0x0600DAE5 RID: 56037 RVA: 0x0040BED0 File Offset: 0x0040A0D0
	static LoginConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoginConfig.CreateStaticDefaultValue), new Action(LoginConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007A20 RID: 31264
	[Nullable(2)]
	private static LoginConfig _Instance;
}
