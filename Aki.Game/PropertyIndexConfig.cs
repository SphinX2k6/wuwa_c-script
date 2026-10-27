using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001803 RID: 6147
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PropertyIndexConfig : ConfigBase
{
	// Token: 0x0600B43B RID: 46139 RVA: 0x0028B5D9 File Offset: 0x002897D9
	public PropertyIndex? GetPropertyIndexInfo(int id)
	{
		return ConfigPropertyIndexById.GetConfig(id, true);
	}

	// Token: 0x0600B43C RID: 46140 RVA: 0x0028B5E4 File Offset: 0x002897E4
	public string GetPropertyIndexIcon(int id)
	{
		return this.GetPropertyIndexInfo(id).Value.Icon;
	}

	// Token: 0x0600B43D RID: 46141 RVA: 0x0028B608 File Offset: 0x00289808
	public string GetPropertyIndexLocalName(int id)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetPropertyIndexInfo(id).Value.Name, null) ?? "";
	}

	// Token: 0x0600B43E RID: 46142 RVA: 0x0028B63C File Offset: 0x0028983C
	public string GetPropertyIndexName(int id)
	{
		return this.GetPropertyIndexInfo(id).Value.Name;
	}

	// Token: 0x0600B43F RID: 46143 RVA: 0x0028B660 File Offset: 0x00289860
	[NullableContext(2)]
	public IReadOnlyList<PropertyIndex> GetPropertyIndexList()
	{
		return ConfigPropertyIndexAll.GetConfigList(true);
	}

	// Token: 0x17000F23 RID: 3875
	// (get) Token: 0x0600B440 RID: 46144 RVA: 0x0028B668 File Offset: 0x00289868
	public static PropertyIndexConfig Instance
	{
		get
		{
			return PropertyIndexConfig._Instance;
		}
	}

	// Token: 0x0600B441 RID: 46145 RVA: 0x0028B66F File Offset: 0x0028986F
	public static PropertyIndexConfig GetOrCreateInstance()
	{
		if (PropertyIndexConfig._Instance == null)
		{
			PropertyIndexConfig.CreateInstance();
		}
		return PropertyIndexConfig._Instance;
	}

	// Token: 0x0600B442 RID: 46146 RVA: 0x0028B683 File Offset: 0x00289883
	public static bool CreateInstance()
	{
		if (PropertyIndexConfig._Instance != null)
		{
			return true;
		}
		PropertyIndexConfig._Instance = new PropertyIndexConfig();
		return true;
	}

	// Token: 0x0600B443 RID: 46147 RVA: 0x0028B699 File Offset: 0x00289899
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B444 RID: 46148 RVA: 0x0028B69B File Offset: 0x0028989B
	public static void ResetStaticDefaultValue()
	{
		PropertyIndexConfig._Instance = null;
	}

	// Token: 0x0600B445 RID: 46149 RVA: 0x0028B6A3 File Offset: 0x002898A3
	static PropertyIndexConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PropertyIndexConfig.CreateStaticDefaultValue), new Action(PropertyIndexConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400516A RID: 20842
	[Nullable(2)]
	private static PropertyIndexConfig _Instance;
}
