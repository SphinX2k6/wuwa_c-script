using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02001A88 RID: 6792
[NullableContext(1)]
[Nullable(0)]
public class DynamicTabConfig : ConfigBase
{
	// Token: 0x0600C863 RID: 51299 RVA: 0x002DB86C File Offset: 0x002D9A6C
	public List<UiDynamicTab> GetViewTabList(string parentViewName)
	{
		List<UiDynamicTab> list = ConfigCommon.ToList<UiDynamicTab>(ConfigUiDynamicTabByParentViewName.GetConfigList(parentViewName, true));
		if (list != null)
		{
			list.Sort(new Comparison<UiDynamicTab>(this.SortByTabIndex));
		}
		return list ?? new List<UiDynamicTab>();
	}

	// Token: 0x0600C864 RID: 51300 RVA: 0x002DB8A8 File Offset: 0x002D9AA8
	public List<EUiTabViewName> GetTabViewNameList(string parentViewName)
	{
		List<UiDynamicTab> viewTabList = this.GetViewTabList(parentViewName);
		List<EUiTabViewName> list = new List<EUiTabViewName>();
		foreach (UiDynamicTab uiDynamicTab in viewTabList)
		{
			list.Add((EUiTabViewName)uiDynamicTab.ChildViewName);
		}
		return list;
	}

	// Token: 0x0600C865 RID: 51301 RVA: 0x002DB910 File Offset: 0x002D9B10
	public UiDynamicTab GetViewTab(string childViewName)
	{
		return ConfigUiDynamicTabByChildViewName.GetConfig(childViewName, true).GetValueOrDefault();
	}

	// Token: 0x0600C866 RID: 51302 RVA: 0x002DB92C File Offset: 0x002D9B2C
	private int SortByTabIndex(UiDynamicTab a, UiDynamicTab b)
	{
		return a.TabIndex.CompareTo(b.TabIndex);
	}

	// Token: 0x0600C867 RID: 51303 RVA: 0x002DB950 File Offset: 0x002D9B50
	public UiDynamicTab GetTabViewConfById(int id)
	{
		return ConfigUiDynamicTabById.GetConfig(id, true).GetValueOrDefault();
	}

	// Token: 0x17001070 RID: 4208
	// (get) Token: 0x0600C868 RID: 51304 RVA: 0x002DB96C File Offset: 0x002D9B6C
	public static DynamicTabConfig Instance
	{
		get
		{
			return DynamicTabConfig._Instance;
		}
	}

	// Token: 0x0600C869 RID: 51305 RVA: 0x002DB973 File Offset: 0x002D9B73
	public static DynamicTabConfig GetOrCreateInstance()
	{
		if (DynamicTabConfig._Instance == null)
		{
			DynamicTabConfig.CreateInstance();
		}
		return DynamicTabConfig._Instance;
	}

	// Token: 0x0600C86A RID: 51306 RVA: 0x002DB987 File Offset: 0x002D9B87
	public static bool CreateInstance()
	{
		if (DynamicTabConfig._Instance != null)
		{
			return true;
		}
		DynamicTabConfig._Instance = new DynamicTabConfig();
		return true;
	}

	// Token: 0x0600C86B RID: 51307 RVA: 0x002DB99D File Offset: 0x002D9B9D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C86C RID: 51308 RVA: 0x002DB99F File Offset: 0x002D9B9F
	public static void ResetStaticDefaultValue()
	{
		DynamicTabConfig._Instance = null;
	}

	// Token: 0x0600C86D RID: 51309 RVA: 0x002DB9A7 File Offset: 0x002D9BA7
	static DynamicTabConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DynamicTabConfig.CreateStaticDefaultValue), new Action(DynamicTabConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005C6A RID: 23658
	[Nullable(2)]
	private static DynamicTabConfig _Instance;
}
