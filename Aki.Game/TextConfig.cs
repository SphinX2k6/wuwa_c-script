using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000251 RID: 593
[NullableContext(1)]
[Nullable(0)]
public class TextConfig : ConfigBase
{
	// Token: 0x06002490 RID: 9360 RVA: 0x000E1624 File Offset: 0x000DF824
	[return: Nullable(2)]
	public string GetTextById(string id)
	{
		string textContentIdById = this.GetTextContentIdById(id);
		if (string.IsNullOrEmpty(textContentIdById))
		{
			return null;
		}
		return this.GetMultiTextByKey(textContentIdById);
	}

	// Token: 0x06002491 RID: 9361 RVA: 0x000E164C File Offset: 0x000DF84C
	[return: Nullable(2)]
	public string GetTextContentIdById(string id)
	{
		Text? config = ConfigTextById.GetConfig(id, true);
		string text = (config != null) ? config.GetValueOrDefault().TextContent : null;
		if (text == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TextUtil;
			ELogAuthor author = ELogAuthor.TL;
			string message = "Text表查找不到Id = ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return text;
	}

	// Token: 0x06002492 RID: 9362 RVA: 0x000E16A8 File Offset: 0x000DF8A8
	[return: Nullable(2)]
	public string GetGenderTextById(string id, bool isMale)
	{
		GenderText? config = ConfigGenderTextByMaleText.GetConfig(id, true);
		if (config != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TextUtil;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "GenderText表查找不到Id = ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (!isMale)
		{
			return config.Value.FemaleText;
		}
		return config.Value.MaleText;
	}

	// Token: 0x06002493 RID: 9363 RVA: 0x000E1711 File Offset: 0x000DF911
	[NullableContext(2)]
	public string GetMultiTextByKey([Nullable(1)] string key, string def)
	{
		return ConfigMultiTextLang.GetLocalTextNew(key, null) ?? def;
	}

	// Token: 0x06002494 RID: 9364 RVA: 0x000E171F File Offset: 0x000DF91F
	[return: Nullable(2)]
	public string GetMultiTextByKey(string key)
	{
		return this.GetMultiTextByKey(key, string.Empty);
	}

	// Token: 0x06002495 RID: 9365 RVA: 0x000E1730 File Offset: 0x000DF930
	public string GetMultiText(string key, params string[] args)
	{
		string multiTextByKey = this.GetMultiTextByKey(key);
		if (string.IsNullOrEmpty(multiTextByKey))
		{
			return string.Empty;
		}
		return StringUtils.Format(multiTextByKey, args);
	}

	// Token: 0x170005B6 RID: 1462
	// (get) Token: 0x06002496 RID: 9366 RVA: 0x000E175A File Offset: 0x000DF95A
	public static TextConfig Instance
	{
		get
		{
			return TextConfig._Instance;
		}
	}

	// Token: 0x06002497 RID: 9367 RVA: 0x000E1761 File Offset: 0x000DF961
	public static TextConfig GetOrCreateInstance()
	{
		if (TextConfig._Instance == null)
		{
			TextConfig.CreateInstance();
		}
		return TextConfig._Instance;
	}

	// Token: 0x06002498 RID: 9368 RVA: 0x000E1775 File Offset: 0x000DF975
	public static bool CreateInstance()
	{
		if (TextConfig._Instance != null)
		{
			return true;
		}
		TextConfig._Instance = new TextConfig();
		return true;
	}

	// Token: 0x06002499 RID: 9369 RVA: 0x000E178B File Offset: 0x000DF98B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600249A RID: 9370 RVA: 0x000E178D File Offset: 0x000DF98D
	public static void ResetStaticDefaultValue()
	{
		TextConfig._Instance = null;
	}

	// Token: 0x0600249B RID: 9371 RVA: 0x000E1795 File Offset: 0x000DF995
	static TextConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TextConfig.CreateStaticDefaultValue), new Action(TextConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04001872 RID: 6258
	[Nullable(2)]
	private static TextConfig _Instance;
}
