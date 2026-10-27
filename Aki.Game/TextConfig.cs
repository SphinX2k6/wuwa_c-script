using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200024D RID: 589
[NullableContext(1)]
[Nullable(0)]
public class TextConfig : ConfigBase
{
	// Token: 0x060023D8 RID: 9176 RVA: 0x000DB0DC File Offset: 0x000D92DC
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

	// Token: 0x060023D9 RID: 9177 RVA: 0x000DB104 File Offset: 0x000D9304
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

	// Token: 0x060023DA RID: 9178 RVA: 0x000DB160 File Offset: 0x000D9360
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

	// Token: 0x060023DB RID: 9179 RVA: 0x000DB1C9 File Offset: 0x000D93C9
	[NullableContext(2)]
	public string GetMultiTextByKey([Nullable(1)] string key, string def)
	{
		return ConfigMultiTextLang.GetLocalTextNew(key, null) ?? def;
	}

	// Token: 0x060023DC RID: 9180 RVA: 0x000DB1D7 File Offset: 0x000D93D7
	[return: Nullable(2)]
	public string GetMultiTextByKey(string key)
	{
		return this.GetMultiTextByKey(key, string.Empty);
	}

	// Token: 0x060023DD RID: 9181 RVA: 0x000DB1E8 File Offset: 0x000D93E8
	public string GetMultiText(string key, params string[] args)
	{
		string multiTextByKey = this.GetMultiTextByKey(key);
		if (string.IsNullOrEmpty(multiTextByKey))
		{
			return string.Empty;
		}
		return StringUtils.Format(multiTextByKey, args);
	}

	// Token: 0x1700058F RID: 1423
	// (get) Token: 0x060023DE RID: 9182 RVA: 0x000DB212 File Offset: 0x000D9412
	public static TextConfig Instance
	{
		get
		{
			return TextConfig._Instance;
		}
	}

	// Token: 0x060023DF RID: 9183 RVA: 0x000DB219 File Offset: 0x000D9419
	public static TextConfig GetOrCreateInstance()
	{
		if (TextConfig._Instance == null)
		{
			TextConfig.CreateInstance();
		}
		return TextConfig._Instance;
	}

	// Token: 0x060023E0 RID: 9184 RVA: 0x000DB22D File Offset: 0x000D942D
	public static bool CreateInstance()
	{
		if (TextConfig._Instance != null)
		{
			return true;
		}
		TextConfig._Instance = new TextConfig();
		return true;
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x000DB243 File Offset: 0x000D9443
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x000DB245 File Offset: 0x000D9445
	public static void ResetStaticDefaultValue()
	{
		TextConfig._Instance = null;
	}

	// Token: 0x060023E3 RID: 9187 RVA: 0x000DB24D File Offset: 0x000D944D
	static TextConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TextConfig.CreateStaticDefaultValue), new Action(TextConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400182E RID: 6190
	[Nullable(2)]
	private static TextConfig _Instance;
}
