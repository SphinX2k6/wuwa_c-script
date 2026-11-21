using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000CBC RID: 3260
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PropertyIndexConfig : ConfigBase
{
	// Token: 0x06008826 RID: 34854 RVA: 0x00295CF9 File Offset: 0x00293EF9
	public PropertyIndex? GetPropertyIndexInfo(int id)
	{
		return ConfigPropertyIndexById.GetConfig(id, true);
	}

	// Token: 0x06008827 RID: 34855 RVA: 0x00295D04 File Offset: 0x00293F04
	public string GetPropertyIndexIcon(int id)
	{
		return this.GetPropertyIndexInfo(id).Value.Icon;
	}

	// Token: 0x06008828 RID: 34856 RVA: 0x00295D28 File Offset: 0x00293F28
	public string GetPropertyIndexLocalName(int id)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetPropertyIndexInfo(id).Value.Name, null) ?? "";
	}

	// Token: 0x06008829 RID: 34857 RVA: 0x00295D5C File Offset: 0x00293F5C
	public string GetPropertyIndexName(int id)
	{
		return this.GetPropertyIndexInfo(id).Value.Name;
	}

	// Token: 0x0600882A RID: 34858 RVA: 0x00295D80 File Offset: 0x00293F80
	[NullableContext(2)]
	public IReadOnlyList<PropertyIndex> GetPropertyIndexList()
	{
		return ConfigPropertyIndexAll.GetConfigList(true);
	}

	// Token: 0x17000F46 RID: 3910
	// (get) Token: 0x0600882B RID: 34859 RVA: 0x00295D88 File Offset: 0x00293F88
	public static PropertyIndexConfig Instance
	{
		get
		{
			return PropertyIndexConfig._Instance;
		}
	}

	// Token: 0x0600882C RID: 34860 RVA: 0x00295D8F File Offset: 0x00293F8F
	public static PropertyIndexConfig GetOrCreateInstance()
	{
		if (PropertyIndexConfig._Instance == null)
		{
			PropertyIndexConfig.CreateInstance();
		}
		return PropertyIndexConfig._Instance;
	}

	// Token: 0x0600882D RID: 34861 RVA: 0x00295DA3 File Offset: 0x00293FA3
	public static bool CreateInstance()
	{
		if (PropertyIndexConfig._Instance != null)
		{
			return true;
		}
		PropertyIndexConfig._Instance = new PropertyIndexConfig();
		return true;
	}

	// Token: 0x0600882E RID: 34862 RVA: 0x00295DB9 File Offset: 0x00293FB9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600882F RID: 34863 RVA: 0x00295DBB File Offset: 0x00293FBB
	public static void ResetStaticDefaultValue()
	{
		PropertyIndexConfig._Instance = null;
	}

	// Token: 0x06008830 RID: 34864 RVA: 0x00295DC3 File Offset: 0x00293FC3
	static PropertyIndexConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PropertyIndexConfig.CreateStaticDefaultValue), new Action(PropertyIndexConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005215 RID: 21013
	[Nullable(2)]
	private static PropertyIndexConfig _Instance;
}
