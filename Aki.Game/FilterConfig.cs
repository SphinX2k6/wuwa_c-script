using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200184D RID: 6221
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FilterConfig : ConfigBase
{
	// Token: 0x0600B634 RID: 46644 RVA: 0x002933CF File Offset: 0x002915CF
	protected override bool OnInit()
	{
		this.Phantom4cMainProperty = ConfigCommonParamById.GetIntArrayConfig("Phantom4CMainProperty");
		this.Phantom3cMainProperty = ConfigCommonParamById.GetIntArrayConfig("Phantom3CMainProperty");
		this.Phantom1cMainProperty = ConfigCommonParamById.GetIntArrayConfig("Phantom1CMainProperty");
		return true;
	}

	// Token: 0x0600B635 RID: 46645 RVA: 0x00293402 File Offset: 0x00291602
	public Filter? GetFilterConfig(int id)
	{
		return ConfigFilterById.GetConfig(id, true);
	}

	// Token: 0x0600B636 RID: 46646 RVA: 0x0029340B File Offset: 0x0029160B
	public FilterRule? GetFilterRuleConfig(int id)
	{
		return ConfigFilterRuleById.GetConfig(id, true);
	}

	// Token: 0x0600B637 RID: 46647 RVA: 0x00293414 File Offset: 0x00291614
	public int GetFilterId(EFilterSortGroupId groupId)
	{
		return ConfigFilterSortGroupById.GetConfig((int)groupId, true).Value.FilterId;
	}

	// Token: 0x0600B638 RID: 46648 RVA: 0x00293438 File Offset: 0x00291638
	public IReadOnlyList<int> GetCostByMainMainProp(int mainPropId)
	{
		List<int> list = new List<int>();
		if (this.Phantom4cMainProperty.IndexOf(mainPropId) >= 0)
		{
			list.Add(4);
		}
		if (this.Phantom3cMainProperty.IndexOf(mainPropId) >= 0)
		{
			list.Add(3);
		}
		if (this.Phantom1cMainProperty.IndexOf(mainPropId) >= 0)
		{
			list.Add(1);
		}
		return list;
	}

	// Token: 0x0600B639 RID: 46649 RVA: 0x0029348E File Offset: 0x0029168E
	public IReadOnlyList<int> GetMainPropIdsByCost(int cost)
	{
		switch (cost)
		{
		case 1:
			return this.Phantom1cMainProperty;
		case 3:
			return this.Phantom3cMainProperty;
		case 4:
			return this.Phantom4cMainProperty;
		}
		return Array.Empty<int>();
	}

	// Token: 0x17000F2C RID: 3884
	// (get) Token: 0x0600B63A RID: 46650 RVA: 0x002934C4 File Offset: 0x002916C4
	public static FilterConfig Instance
	{
		get
		{
			return FilterConfig._Instance;
		}
	}

	// Token: 0x0600B63B RID: 46651 RVA: 0x002934CB File Offset: 0x002916CB
	public static FilterConfig GetOrCreateInstance()
	{
		if (FilterConfig._Instance == null)
		{
			FilterConfig.CreateInstance();
		}
		return FilterConfig._Instance;
	}

	// Token: 0x0600B63C RID: 46652 RVA: 0x002934DF File Offset: 0x002916DF
	public static bool CreateInstance()
	{
		if (FilterConfig._Instance != null)
		{
			return true;
		}
		FilterConfig._Instance = new FilterConfig();
		return true;
	}

	// Token: 0x0600B63D RID: 46653 RVA: 0x002934F5 File Offset: 0x002916F5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B63E RID: 46654 RVA: 0x002934F7 File Offset: 0x002916F7
	public static void ResetStaticDefaultValue()
	{
		FilterConfig._Instance = null;
	}

	// Token: 0x0600B63F RID: 46655 RVA: 0x002934FF File Offset: 0x002916FF
	static FilterConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FilterConfig.CreateStaticDefaultValue), new Action(FilterConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400525A RID: 21082
	private const int COST_4C = 4;

	// Token: 0x0400525B RID: 21083
	private const int COST_3C = 3;

	// Token: 0x0400525C RID: 21084
	private const int COST_1C = 1;

	// Token: 0x0400525D RID: 21085
	private IReadOnlyList<int> Phantom4cMainProperty;

	// Token: 0x0400525E RID: 21086
	private IReadOnlyList<int> Phantom3cMainProperty;

	// Token: 0x0400525F RID: 21087
	private IReadOnlyList<int> Phantom1cMainProperty;

	// Token: 0x04005260 RID: 21088
	[Nullable(2)]
	private static FilterConfig _Instance;
}
