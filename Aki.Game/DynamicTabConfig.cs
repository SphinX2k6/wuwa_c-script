using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02000F47 RID: 3911
[NullableContext(1)]
[Nullable(0)]
public class DynamicTabConfig : ConfigBase
{
	// Token: 0x06009C74 RID: 40052 RVA: 0x002E6A14 File Offset: 0x002E4C14
	public List<UiDynamicTab> GetViewTabList(string parentViewName)
	{
		List<UiDynamicTab> list = ConfigCommon.ToList<UiDynamicTab>(ConfigUiDynamicTabByParentViewName.GetConfigList(parentViewName, true));
		if (list != null)
		{
			list.Sort(new Comparison<UiDynamicTab>(this.SortByTabIndex));
		}
		return list ?? new List<UiDynamicTab>();
	}

	// Token: 0x06009C75 RID: 40053 RVA: 0x002E6A50 File Offset: 0x002E4C50
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

	// Token: 0x06009C76 RID: 40054 RVA: 0x002E6AB8 File Offset: 0x002E4CB8
	public UiDynamicTab GetViewTab(string childViewName)
	{
		return ConfigUiDynamicTabByChildViewName.GetConfig(childViewName, true).GetValueOrDefault();
	}

	// Token: 0x06009C77 RID: 40055 RVA: 0x002E6AD4 File Offset: 0x002E4CD4
	private int SortByTabIndex(UiDynamicTab a, UiDynamicTab b)
	{
		return a.TabIndex.CompareTo(b.TabIndex);
	}

	// Token: 0x06009C78 RID: 40056 RVA: 0x002E6AF8 File Offset: 0x002E4CF8
	public UiDynamicTab GetTabViewConfById(int id)
	{
		return ConfigUiDynamicTabById.GetConfig(id, true).GetValueOrDefault();
	}

	// Token: 0x17001095 RID: 4245
	// (get) Token: 0x06009C79 RID: 40057 RVA: 0x002E6B14 File Offset: 0x002E4D14
	public static DynamicTabConfig Instance
	{
		get
		{
			return DynamicTabConfig._Instance;
		}
	}

	// Token: 0x06009C7A RID: 40058 RVA: 0x002E6B1B File Offset: 0x002E4D1B
	public static DynamicTabConfig GetOrCreateInstance()
	{
		if (DynamicTabConfig._Instance == null)
		{
			DynamicTabConfig.CreateInstance();
		}
		return DynamicTabConfig._Instance;
	}

	// Token: 0x06009C7B RID: 40059 RVA: 0x002E6B2F File Offset: 0x002E4D2F
	public static bool CreateInstance()
	{
		if (DynamicTabConfig._Instance != null)
		{
			return true;
		}
		DynamicTabConfig._Instance = new DynamicTabConfig();
		return true;
	}

	// Token: 0x06009C7C RID: 40060 RVA: 0x002E6B45 File Offset: 0x002E4D45
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009C7D RID: 40061 RVA: 0x002E6B47 File Offset: 0x002E4D47
	public static void ResetStaticDefaultValue()
	{
		DynamicTabConfig._Instance = null;
	}

	// Token: 0x06009C7E RID: 40062 RVA: 0x002E6B4F File Offset: 0x002E4D4F
	static DynamicTabConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DynamicTabConfig.CreateStaticDefaultValue), new Action(DynamicTabConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005D39 RID: 23865
	[Nullable(2)]
	private static DynamicTabConfig _Instance;
}
