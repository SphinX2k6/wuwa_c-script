using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Typing;

// Token: 0x02000F4C RID: 3916
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ErrorCodeConfig : ConfigBase
{
	// Token: 0x06009C9F RID: 40095 RVA: 0x002E6E94 File Offset: 0x002E5094
	public void SetForceShowDebugErrorType(int isShipping)
	{
		this.ForceShowDebugTextType = isShipping;
	}

	// Token: 0x06009CA0 RID: 40096 RVA: 0x002E6EA0 File Offset: 0x002E50A0
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

	// Token: 0x06009CA1 RID: 40097 RVA: 0x002E6EEC File Offset: 0x002E50EC
	public string GetTextByErrorId(Aki.Protocol.ErrorCode code)
	{
		Aki.Config.ErrorCode? configByCode = this.GetConfigByCode(code);
		if (configByCode == null)
		{
			return string.Empty;
		}
		KuroApplication.IsBuildShipping();
		if (string.IsNullOrEmpty(configByCode.Value.Text))
		{
			return TextConfig.Instance.GetTextById("UnknownErrorCodeText");
		}
		return ConfigMultiTextLang.GetLocalTextNew(configByCode.Value.Text, null) ?? string.Empty;
	}

	// Token: 0x06009CA2 RID: 40098 RVA: 0x002E6F5C File Offset: 0x002E515C
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

	// Token: 0x06009CA3 RID: 40099 RVA: 0x002E6FB8 File Offset: 0x002E51B8
	public bool IsTipsOnly(Aki.Protocol.ErrorCode code)
	{
		Aki.Config.ErrorCode? configByCode = this.GetConfigByCode(code);
		return configByCode != null && configByCode.GetValueOrDefault().IsTip;
	}

	// Token: 0x17001096 RID: 4246
	// (get) Token: 0x06009CA4 RID: 40100 RVA: 0x002E6FE7 File Offset: 0x002E51E7
	public static ErrorCodeConfig Instance
	{
		get
		{
			return ErrorCodeConfig._Instance;
		}
	}

	// Token: 0x06009CA5 RID: 40101 RVA: 0x002E6FEE File Offset: 0x002E51EE
	public static ErrorCodeConfig GetOrCreateInstance()
	{
		if (ErrorCodeConfig._Instance == null)
		{
			ErrorCodeConfig.CreateInstance();
		}
		return ErrorCodeConfig._Instance;
	}

	// Token: 0x06009CA6 RID: 40102 RVA: 0x002E7002 File Offset: 0x002E5202
	public static bool CreateInstance()
	{
		if (ErrorCodeConfig._Instance != null)
		{
			return true;
		}
		ErrorCodeConfig._Instance = new ErrorCodeConfig();
		return true;
	}

	// Token: 0x06009CA7 RID: 40103 RVA: 0x002E7018 File Offset: 0x002E5218
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009CA8 RID: 40104 RVA: 0x002E701A File Offset: 0x002E521A
	public static void ResetStaticDefaultValue()
	{
		ErrorCodeConfig._Instance = null;
	}

	// Token: 0x06009CA9 RID: 40105 RVA: 0x002E7022 File Offset: 0x002E5222
	static ErrorCodeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ErrorCodeConfig.CreateStaticDefaultValue), new Action(ErrorCodeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005D3E RID: 23870
	private int ForceShowDebugTextType = 1;

	// Token: 0x04005D3F RID: 23871
	[Nullable(2)]
	private static ErrorCodeConfig _Instance;
}
