using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020019DC RID: 6620
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ConfirmBoxConfig : ConfigBase
{
	// Token: 0x0600C14A RID: 49482 RVA: 0x002B9AB4 File Offset: 0x002B7CB4
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

	// Token: 0x0600C14B RID: 49483 RVA: 0x002B9AFF File Offset: 0x002B7CFF
	public string GetTitle(string titleId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(titleId, null);
	}

	// Token: 0x0600C14C RID: 49484 RVA: 0x002B9B08 File Offset: 0x002B7D08
	public string GetContent(string contentId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(contentId, null);
	}

	// Token: 0x0600C14D RID: 49485 RVA: 0x002B9B11 File Offset: 0x002B7D11
	public string GetSecondaryContent(string secondaryContentId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(secondaryContentId, null);
	}

	// Token: 0x0600C14E RID: 49486 RVA: 0x002B9B1A File Offset: 0x002B7D1A
	public string GetButtonText(string textId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(textId, null);
	}

	// Token: 0x0600C14F RID: 49487 RVA: 0x002B9B24 File Offset: 0x002B7D24
	public int? GetUiShowType(int configId)
	{
		ConfirmBox? confirmBoxConfig = this.GetConfirmBoxConfig(configId);
		if (confirmBoxConfig == null)
		{
			return null;
		}
		return new int?(confirmBoxConfig.GetValueOrDefault().UiShowType);
	}

	// Token: 0x1700102E RID: 4142
	// (get) Token: 0x0600C150 RID: 49488 RVA: 0x002B9B60 File Offset: 0x002B7D60
	public static ConfirmBoxConfig Instance
	{
		get
		{
			return ConfirmBoxConfig._Instance;
		}
	}

	// Token: 0x0600C151 RID: 49489 RVA: 0x002B9B67 File Offset: 0x002B7D67
	public static ConfirmBoxConfig GetOrCreateInstance()
	{
		if (ConfirmBoxConfig._Instance == null)
		{
			ConfirmBoxConfig.CreateInstance();
		}
		return ConfirmBoxConfig._Instance;
	}

	// Token: 0x0600C152 RID: 49490 RVA: 0x002B9B7B File Offset: 0x002B7D7B
	public static bool CreateInstance()
	{
		if (ConfirmBoxConfig._Instance != null)
		{
			return true;
		}
		ConfirmBoxConfig._Instance = new ConfirmBoxConfig();
		return true;
	}

	// Token: 0x0600C153 RID: 49491 RVA: 0x002B9B91 File Offset: 0x002B7D91
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C154 RID: 49492 RVA: 0x002B9B93 File Offset: 0x002B7D93
	public static void ResetStaticDefaultValue()
	{
		ConfirmBoxConfig._Instance = null;
	}

	// Token: 0x0600C155 RID: 49493 RVA: 0x002B9B9B File Offset: 0x002B7D9B
	static ConfirmBoxConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ConfirmBoxConfig.CreateStaticDefaultValue), new Action(ConfirmBoxConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400591A RID: 22810
	[Nullable(2)]
	private static ConfirmBoxConfig _Instance;
}
