using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000E9B RID: 3739
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ConfirmBoxConfig : ConfigBase
{
	// Token: 0x06009557 RID: 38231 RVA: 0x002C4A8C File Offset: 0x002C2C8C
	public ConfirmBox? GetConfirmBoxConfig(int configId)
	{
		ConfirmBox? config = ConfigConfirmBoxById.GetConfig(configId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ConfirmBox;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "原因:确认框.xlsx表格查找不到对应的配置id 解决:策划查看是否有配置对应的id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置id", configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x06009558 RID: 38232 RVA: 0x002C4AD7 File Offset: 0x002C2CD7
	public string GetTitle(string titleId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(titleId, null);
	}

	// Token: 0x06009559 RID: 38233 RVA: 0x002C4AE0 File Offset: 0x002C2CE0
	public string GetContent(string contentId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(contentId, null);
	}

	// Token: 0x0600955A RID: 38234 RVA: 0x002C4AE9 File Offset: 0x002C2CE9
	public string GetSecondaryContent(string secondaryContentId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(secondaryContentId, null);
	}

	// Token: 0x0600955B RID: 38235 RVA: 0x002C4AF2 File Offset: 0x002C2CF2
	public string GetButtonText(string textId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(textId, null);
	}

	// Token: 0x0600955C RID: 38236 RVA: 0x002C4AFC File Offset: 0x002C2CFC
	public int? GetUiShowType(int configId)
	{
		ConfirmBox? confirmBoxConfig = this.GetConfirmBoxConfig(configId);
		if (confirmBoxConfig == null)
		{
			return null;
		}
		return new int?(confirmBoxConfig.GetValueOrDefault().UiShowType);
	}

	// Token: 0x17001053 RID: 4179
	// (get) Token: 0x0600955D RID: 38237 RVA: 0x002C4B38 File Offset: 0x002C2D38
	public static ConfirmBoxConfig Instance
	{
		get
		{
			return ConfirmBoxConfig._Instance;
		}
	}

	// Token: 0x0600955E RID: 38238 RVA: 0x002C4B3F File Offset: 0x002C2D3F
	public static ConfirmBoxConfig GetOrCreateInstance()
	{
		if (ConfirmBoxConfig._Instance == null)
		{
			ConfirmBoxConfig.CreateInstance();
		}
		return ConfirmBoxConfig._Instance;
	}

	// Token: 0x0600955F RID: 38239 RVA: 0x002C4B53 File Offset: 0x002C2D53
	public static bool CreateInstance()
	{
		if (ConfirmBoxConfig._Instance != null)
		{
			return true;
		}
		ConfirmBoxConfig._Instance = new ConfirmBoxConfig();
		return true;
	}

	// Token: 0x06009560 RID: 38240 RVA: 0x002C4B69 File Offset: 0x002C2D69
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009561 RID: 38241 RVA: 0x002C4B6B File Offset: 0x002C2D6B
	public static void ResetStaticDefaultValue()
	{
		ConfirmBoxConfig._Instance = null;
	}

	// Token: 0x06009562 RID: 38242 RVA: 0x002C4B73 File Offset: 0x002C2D73
	static ConfirmBoxConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ConfirmBoxConfig.CreateStaticDefaultValue), new Action(ConfirmBoxConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040059E9 RID: 23017
	[Nullable(2)]
	private static ConfirmBoxConfig _Instance;
}
