using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000D06 RID: 3334
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FilterConfig : ConfigBase
{
	// Token: 0x06008A1D RID: 35357 RVA: 0x0029DADF File Offset: 0x0029BCDF
	protected override bool OnInit()
	{
		this.Phantom4cMainProperty = ConfigCommonParamById.GetIntArrayConfig("Phantom4CMainProperty");
		this.Phantom3cMainProperty = ConfigCommonParamById.GetIntArrayConfig("Phantom3CMainProperty");
		this.Phantom1cMainProperty = ConfigCommonParamById.GetIntArrayConfig("Phantom1CMainProperty");
		return true;
	}

	// Token: 0x06008A1E RID: 35358 RVA: 0x0029DB12 File Offset: 0x0029BD12
	public Filter? GetFilterConfig(int id)
	{
		return ConfigFilterById.GetConfig(id, true);
	}

	// Token: 0x06008A1F RID: 35359 RVA: 0x0029DB1B File Offset: 0x0029BD1B
	public FilterRule? GetFilterRuleConfig(int id)
	{
		return ConfigFilterRuleById.GetConfig(id, true);
	}

	// Token: 0x06008A20 RID: 35360 RVA: 0x0029DB24 File Offset: 0x0029BD24
	public int GetFilterId(EFilterSortGroupId groupId)
	{
		return ConfigFilterSortGroupById.GetConfig((int)groupId, true).Value.FilterId;
	}

	// Token: 0x06008A21 RID: 35361 RVA: 0x0029DB48 File Offset: 0x0029BD48
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

	// Token: 0x06008A22 RID: 35362 RVA: 0x0029DB9E File Offset: 0x0029BD9E
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

	// Token: 0x17000F4F RID: 3919
	// (get) Token: 0x06008A23 RID: 35363 RVA: 0x0029DBD4 File Offset: 0x0029BDD4
	public static FilterConfig Instance
	{
		get
		{
			return FilterConfig._Instance;
		}
	}

	// Token: 0x06008A24 RID: 35364 RVA: 0x0029DBDB File Offset: 0x0029BDDB
	public static FilterConfig GetOrCreateInstance()
	{
		if (FilterConfig._Instance == null)
		{
			FilterConfig.CreateInstance();
		}
		return FilterConfig._Instance;
	}

	// Token: 0x06008A25 RID: 35365 RVA: 0x0029DBEF File Offset: 0x0029BDEF
	public static bool CreateInstance()
	{
		if (FilterConfig._Instance != null)
		{
			return true;
		}
		FilterConfig._Instance = new FilterConfig();
		return true;
	}

	// Token: 0x06008A26 RID: 35366 RVA: 0x0029DC05 File Offset: 0x0029BE05
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008A27 RID: 35367 RVA: 0x0029DC07 File Offset: 0x0029BE07
	public static void ResetStaticDefaultValue()
	{
		FilterConfig._Instance = null;
	}

	// Token: 0x06008A28 RID: 35368 RVA: 0x0029DC0F File Offset: 0x0029BE0F
	static FilterConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FilterConfig.CreateStaticDefaultValue), new Action(FilterConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005305 RID: 21253
	private const int COST_4C = 4;

	// Token: 0x04005306 RID: 21254
	private const int COST_3C = 3;

	// Token: 0x04005307 RID: 21255
	private const int COST_1C = 1;

	// Token: 0x04005308 RID: 21256
	private IReadOnlyList<int> Phantom4cMainProperty;

	// Token: 0x04005309 RID: 21257
	private IReadOnlyList<int> Phantom3cMainProperty;

	// Token: 0x0400530A RID: 21258
	private IReadOnlyList<int> Phantom1cMainProperty;

	// Token: 0x0400530B RID: 21259
	[Nullable(2)]
	private static FilterConfig _Instance;
}
