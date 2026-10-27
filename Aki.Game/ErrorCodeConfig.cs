using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Typing;

// Token: 0x02001A8D RID: 6797
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ErrorCodeConfig : ConfigBase
{
	// Token: 0x0600C88E RID: 51342 RVA: 0x002DBCEC File Offset: 0x002D9EEC
	public void SetForceShowDebugErrorType(int isShipping)
	{
		this.ForceShowDebugTextType = isShipping;
	}

	// Token: 0x0600C88F RID: 51343 RVA: 0x002DBCF8 File Offset: 0x002D9EF8
	public Aki.Config.ErrorCode? GetConfigByCode(Aki.Protocol.ErrorCode code)
	{
		Aki.Config.ErrorCode? config = ConfigErrorCodeById.GetConfig((int)code, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ErrorCode;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "没有错误码配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("code", code);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x0600C890 RID: 51344 RVA: 0x002DBD44 File Offset: 0x002D9F44
	public string GetTextByErrorId(Aki.Protocol.ErrorCode code)
	{
		Aki.Config.ErrorCode? configByCode = this.GetConfigByCode(code);
		if (configByCode == null)
		{
			return string.Empty;
		}
		if (!KuroApplication.IsBuildShipping() && Info.Instance.IsBuildDevelopmentOrDebug && this.ForceShowDebugTextType == 0)
		{
			return configByCode.Value.DebugText;
		}
		if (string.IsNullOrEmpty(configByCode.Value.Text))
		{
			return TextConfig.Instance.GetTextById("UnknownErrorCodeText");
		}
		return ConfigMultiTextLang.GetLocalTextNew(configByCode.Value.Text, null) ?? string.Empty;
	}

	// Token: 0x0600C891 RID: 51345 RVA: 0x002DBDD8 File Offset: 0x002D9FD8
	public string GetTextKeyByErrorId(Aki.Protocol.ErrorCode code)
	{
		Aki.Config.ErrorCode? configByCode = this.GetConfigByCode(code);
		if (configByCode == null)
		{
			return string.Empty;
		}
		if (string.IsNullOrEmpty(configByCode.Value.Text))
		{
			return TextConfig.Instance.GetTextContentIdById("UnknownErrorCodeText");
		}
		return configByCode.Value.Text;
	}

	// Token: 0x0600C892 RID: 51346 RVA: 0x002DBE34 File Offset: 0x002DA034
	public bool IsTipsOnly(Aki.Protocol.ErrorCode code)
	{
		Aki.Config.ErrorCode? configByCode = this.GetConfigByCode(code);
		return configByCode != null && configByCode.GetValueOrDefault().IsTip;
	}

	// Token: 0x17001071 RID: 4209
	// (get) Token: 0x0600C893 RID: 51347 RVA: 0x002DBE63 File Offset: 0x002DA063
	public static ErrorCodeConfig Instance
	{
		get
		{
			return ErrorCodeConfig._Instance;
		}
	}

	// Token: 0x0600C894 RID: 51348 RVA: 0x002DBE6A File Offset: 0x002DA06A
	public static ErrorCodeConfig GetOrCreateInstance()
	{
		if (ErrorCodeConfig._Instance == null)
		{
			ErrorCodeConfig.CreateInstance();
		}
		return ErrorCodeConfig._Instance;
	}

	// Token: 0x0600C895 RID: 51349 RVA: 0x002DBE7E File Offset: 0x002DA07E
	public static bool CreateInstance()
	{
		if (ErrorCodeConfig._Instance != null)
		{
			return true;
		}
		ErrorCodeConfig._Instance = new ErrorCodeConfig();
		return true;
	}

	// Token: 0x0600C896 RID: 51350 RVA: 0x002DBE94 File Offset: 0x002DA094
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C897 RID: 51351 RVA: 0x002DBE96 File Offset: 0x002DA096
	public static void ResetStaticDefaultValue()
	{
		ErrorCodeConfig._Instance = null;
	}

	// Token: 0x0600C898 RID: 51352 RVA: 0x002DBE9E File Offset: 0x002DA09E
	static ErrorCodeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ErrorCodeConfig.CreateStaticDefaultValue), new Action(ErrorCodeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005C6F RID: 23663
	private int ForceShowDebugTextType = 1;

	// Token: 0x04005C70 RID: 23664
	[Nullable(2)]
	private static ErrorCodeConfig _Instance;
}
