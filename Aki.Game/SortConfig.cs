using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000D5B RID: 3419
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class SortConfig : ConfigBase
{
	// Token: 0x06008C75 RID: 35957 RVA: 0x002A8BC8 File Offset: 0x002A6DC8
	public Sort? GetSortConfig(int configId)
	{
		Sort? config = ConfigSortById.GetConfig(configId, true);
		if (config != null)
		{
			return new Sort?(config.Value);
		}
		return null;
	}

	// Token: 0x06008C76 RID: 35958 RVA: 0x002A8BFC File Offset: 0x002A6DFC
	public string GetSortRuleName(int ruleId, ESortDataType dataType)
	{
		SortRule? config = ConfigSortRuleByIdAndDataId.GetConfig(ruleId, (int)dataType, true);
		if (config != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(config.Value.Name, null) ?? "";
		}
		return "";
	}

	// Token: 0x06008C77 RID: 35959 RVA: 0x002A8C40 File Offset: 0x002A6E40
	public string GetSortRuleIcon(int ruleId, ESortDataType dataType)
	{
		SortRule? config = ConfigSortRuleByIdAndDataId.GetConfig(ruleId, (int)dataType, true);
		if (config != null)
		{
			return config.Value.Icon;
		}
		return "";
	}

	// Token: 0x06008C78 RID: 35960 RVA: 0x002A8C74 File Offset: 0x002A6E74
	public int GetSortRuleAddType(int ruleId, ESortDataType dataType)
	{
		SortRule? config = ConfigSortRuleByIdAndDataId.GetConfig(ruleId, (int)dataType, true);
		if (config != null)
		{
			return config.Value.AddType;
		}
		return 0;
	}

	// Token: 0x06008C79 RID: 35961 RVA: 0x002A8CA4 File Offset: 0x002A6EA4
	public int GetSortRuleAttributeId(int ruleId, ESortDataType dataType)
	{
		SortRule? config = ConfigSortRuleByIdAndDataId.GetConfig(ruleId, (int)dataType, true);
		if (config != null)
		{
			return config.Value.AttributeId;
		}
		return 0;
	}

	// Token: 0x06008C7A RID: 35962 RVA: 0x002A8CD4 File Offset: 0x002A6ED4
	public int GetSortId(EFilterSortGroupId groupId)
	{
		FilterSortGroup? config = ConfigFilterSortGroupById.GetConfig((int)groupId, true);
		if (config != null)
		{
			return config.Value.SortId;
		}
		return 0;
	}

	// Token: 0x06008C7B RID: 35963 RVA: 0x002A8D04 File Offset: 0x002A6F04
	public bool IsConfigSortSave(EFilterSortConfigId configId, int groupId)
	{
		FilterSortConfig? config = ConfigFilterSortConfigById.GetConfig((int)configId, true);
		return config != null && Array.IndexOf<int>(config.Value.SaveGroupId(), groupId) >= 0;
	}

	// Token: 0x06008C7C RID: 35964 RVA: 0x002A8D40 File Offset: 0x002A6F40
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

	// Token: 0x06008C7D RID: 35965 RVA: 0x002A8D80 File Offset: 0x002A6F80
	public FilterSortConfig GetSortFilterConfig(EFilterSortConfigId configId)
	{
		FilterSortConfig? config = ConfigFilterSortConfigById.GetConfig((int)configId, true);
		if (config != null)
		{
			return config.Value;
		}
		return default(FilterSortConfig);
	}

	// Token: 0x17000F70 RID: 3952
	// (get) Token: 0x06008C7E RID: 35966 RVA: 0x002A8DAF File Offset: 0x002A6FAF
	public static SortConfig Instance
	{
		get
		{
			return SortConfig._Instance;
		}
	}

	// Token: 0x06008C7F RID: 35967 RVA: 0x002A8DB6 File Offset: 0x002A6FB6
	public static SortConfig GetOrCreateInstance()
	{
		if (SortConfig._Instance == null)
		{
			SortConfig.CreateInstance();
		}
		return SortConfig._Instance;
	}

	// Token: 0x06008C80 RID: 35968 RVA: 0x002A8DCA File Offset: 0x002A6FCA
	public static bool CreateInstance()
	{
		if (SortConfig._Instance != null)
		{
			return true;
		}
		SortConfig._Instance = new SortConfig();
		return true;
	}

	// Token: 0x06008C81 RID: 35969 RVA: 0x002A8DE0 File Offset: 0x002A6FE0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008C82 RID: 35970 RVA: 0x002A8DE2 File Offset: 0x002A6FE2
	public static void ResetStaticDefaultValue()
	{
		SortConfig._Instance = null;
	}

	// Token: 0x06008C83 RID: 35971 RVA: 0x002A8DEA File Offset: 0x002A6FEA
	static SortConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SortConfig.CreateStaticDefaultValue), new Action(SortConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400543B RID: 21563
	[Nullable(2)]
	private static SortConfig _Instance;
}
