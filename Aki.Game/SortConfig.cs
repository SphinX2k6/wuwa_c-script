using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020018A2 RID: 6306
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class SortConfig : ConfigBase
{
	// Token: 0x0600B88C RID: 47244 RVA: 0x0029E4AC File Offset: 0x0029C6AC
	public Sort? GetSortConfig(int configId)
	{
		Sort? config = ConfigSortById.GetConfig(configId, true);
		if (config != null)
		{
			return new Sort?(config.Value);
		}
		return null;
	}

	// Token: 0x0600B88D RID: 47245 RVA: 0x0029E4E0 File Offset: 0x0029C6E0
	public string GetSortRuleName(int ruleId, ESortDataType dataType)
	{
		SortRule? config = ConfigSortRuleByIdAndDataId.GetConfig(ruleId, (int)dataType, true);
		if (config != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(config.Value.Name, null) ?? "";
		}
		return "";
	}

	// Token: 0x0600B88E RID: 47246 RVA: 0x0029E524 File Offset: 0x0029C724
	public string GetSortRuleIcon(int ruleId, ESortDataType dataType)
	{
		SortRule? config = ConfigSortRuleByIdAndDataId.GetConfig(ruleId, (int)dataType, true);
		if (config != null)
		{
			return config.Value.Icon;
		}
		return "";
	}

	// Token: 0x0600B88F RID: 47247 RVA: 0x0029E558 File Offset: 0x0029C758
	public int GetSortRuleAddType(int ruleId, ESortDataType dataType)
	{
		SortRule? config = ConfigSortRuleByIdAndDataId.GetConfig(ruleId, (int)dataType, true);
		if (config != null)
		{
			return config.Value.AddType;
		}
		return 0;
	}

	// Token: 0x0600B890 RID: 47248 RVA: 0x0029E588 File Offset: 0x0029C788
	public int GetSortRuleAttributeId(int ruleId, ESortDataType dataType)
	{
		SortRule? config = ConfigSortRuleByIdAndDataId.GetConfig(ruleId, (int)dataType, true);
		if (config != null)
		{
			return config.Value.AttributeId;
		}
		return 0;
	}

	// Token: 0x0600B891 RID: 47249 RVA: 0x0029E5B8 File Offset: 0x0029C7B8
	public int GetSortId(EFilterSortGroupId groupId)
	{
		FilterSortGroup? config = ConfigFilterSortGroupById.GetConfig((int)groupId, true);
		if (config != null)
		{
			return config.Value.SortId;
		}
		return 0;
	}

	// Token: 0x0600B892 RID: 47250 RVA: 0x0029E5E8 File Offset: 0x0029C7E8
	public bool IsConfigSortSave(EFilterSortConfigId configId, int groupId)
	{
		FilterSortConfig? config = ConfigFilterSortConfigById.GetConfig((int)configId, true);
		return config != null && config.Value.SaveGroupId().Contains(groupId);
	}

	// Token: 0x0600B893 RID: 47251 RVA: 0x0029E620 File Offset: 0x0029C820
	public string GetConfigSortFormatId(EFilterSortConfigId configId, int groupId, string extraParam = "")
	{
		int num = (int)configId;
		string text = num.ToString() + "_" + groupId.ToString();
		if (!StringUtils.IsBlank(extraParam))
		{
			text = text + "_" + extraParam;
		}
		return text;
	}

	// Token: 0x0600B894 RID: 47252 RVA: 0x0029E660 File Offset: 0x0029C860
	public FilterSortConfig GetSortFilterConfig(EFilterSortConfigId configId)
	{
		FilterSortConfig? config = ConfigFilterSortConfigById.GetConfig((int)configId, true);
		if (config != null)
		{
			return config.Value;
		}
		return default(FilterSortConfig);
	}

	// Token: 0x17000F4D RID: 3917
	// (get) Token: 0x0600B895 RID: 47253 RVA: 0x0029E68F File Offset: 0x0029C88F
	public static SortConfig Instance
	{
		get
		{
			return SortConfig._Instance;
		}
	}

	// Token: 0x0600B896 RID: 47254 RVA: 0x0029E696 File Offset: 0x0029C896
	public static SortConfig GetOrCreateInstance()
	{
		if (SortConfig._Instance == null)
		{
			SortConfig.CreateInstance();
		}
		return SortConfig._Instance;
	}

	// Token: 0x0600B897 RID: 47255 RVA: 0x0029E6AA File Offset: 0x0029C8AA
	public static bool CreateInstance()
	{
		if (SortConfig._Instance != null)
		{
			return true;
		}
		SortConfig._Instance = new SortConfig();
		return true;
	}

	// Token: 0x0600B898 RID: 47256 RVA: 0x0029E6C0 File Offset: 0x0029C8C0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B899 RID: 47257 RVA: 0x0029E6C2 File Offset: 0x0029C8C2
	public static void ResetStaticDefaultValue()
	{
		SortConfig._Instance = null;
	}

	// Token: 0x0600B89A RID: 47258 RVA: 0x0029E6CA File Offset: 0x0029C8CA
	static SortConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SortConfig.CreateStaticDefaultValue), new Action(SortConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005390 RID: 21392
	[Nullable(2)]
	private static SortConfig _Instance;
}
