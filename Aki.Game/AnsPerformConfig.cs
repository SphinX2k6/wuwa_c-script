using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02002A65 RID: 10853
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class AnsPerformConfig : ConfigBase
{
	// Token: 0x0601B88E RID: 112782 RVA: 0x0087C5B1 File Offset: 0x0087A7B1
	protected override bool OnInit()
	{
		this.ConfigDataMap = new Dictionary<int, AnsPerform>();
		return true;
	}

	// Token: 0x0601B88F RID: 112783 RVA: 0x0087C5BF File Offset: 0x0087A7BF
	protected override bool OnClear()
	{
		this.ConfigDataMap = null;
		return true;
	}

	// Token: 0x0601B890 RID: 112784 RVA: 0x0087C5CC File Offset: 0x0087A7CC
	private AnsPerform? GetConfig(int id)
	{
		AnsPerform? config = ConfigAnsPerformById.GetConfig(id, false);
		if (config == null)
		{
			return null;
		}
		return config;
	}

	// Token: 0x0601B891 RID: 112785 RVA: 0x0087C5F8 File Offset: 0x0087A7F8
	public AnsPerform? GetConfigData(int id)
	{
		AnsPerform? result = null;
		if (!this.ConfigDataMap.ContainsKey(id))
		{
			result = this.GetConfig(id);
			if (result == null)
			{
				return null;
			}
			this.ConfigDataMap[id] = result.Value;
		}
		result = new AnsPerform?(this.ConfigDataMap[id]);
		if (result == null)
		{
			return null;
		}
		return result;
	}

	// Token: 0x0601B892 RID: 112786 RVA: 0x0087C670 File Offset: 0x0087A870
	private void ParseConfigFromJsonFile()
	{
		string configPath = PublicUtil.Instance.GetConfigPath("../Config/Raw/Tables/k.可视化编辑/__Temp__/Json/AnsPerformData.json");
		if (!PublicUtil.Instance.IsUseTempData())
		{
			configPath = PublicUtil.Instance.GetConfigPath("Content/Aki/UniverseEditorConfig/Json/AnsPerformData.json");
		}
		if (!UBlueprintPathsLibrary.FileExists(configPath))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[CharacterFlowDynamic] 不存在AnsPerform.json文件。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", configPath);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string text = "";
		UKuroStaticLibrary.LoadFileToString(ref text, configPath);
		foreach (AnsPerform value in Json.Parse<AnsPerform[]>(text, null))
		{
			if (!this.ConfigDataMap.ContainsKey(value.Id))
			{
				this.ConfigDataMap[value.Id] = value;
			}
		}
	}

	// Token: 0x17002C8E RID: 11406
	// (get) Token: 0x0601B893 RID: 112787 RVA: 0x0087C734 File Offset: 0x0087A934
	public static AnsPerformConfig Instance
	{
		get
		{
			return AnsPerformConfig._Instance;
		}
	}

	// Token: 0x0601B894 RID: 112788 RVA: 0x0087C73B File Offset: 0x0087A93B
	public static AnsPerformConfig GetOrCreateInstance()
	{
		if (AnsPerformConfig._Instance == null)
		{
			AnsPerformConfig.CreateInstance();
		}
		return AnsPerformConfig._Instance;
	}

	// Token: 0x0601B895 RID: 112789 RVA: 0x0087C74F File Offset: 0x0087A94F
	public static bool CreateInstance()
	{
		if (AnsPerformConfig._Instance != null)
		{
			return true;
		}
		AnsPerformConfig._Instance = new AnsPerformConfig();
		return true;
	}

	// Token: 0x0601B896 RID: 112790 RVA: 0x0087C765 File Offset: 0x0087A965
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B897 RID: 112791 RVA: 0x0087C767 File Offset: 0x0087A967
	public static void ResetStaticDefaultValue()
	{
		AnsPerformConfig._Instance = null;
	}

	// Token: 0x0601B898 RID: 112792 RVA: 0x0087C76F File Offset: 0x0087A96F
	static AnsPerformConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AnsPerformConfig.CreateStaticDefaultValue), new Action(AnsPerformConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400EDEB RID: 60907
	[Nullable(2)]
	private Dictionary<int, AnsPerform> ConfigDataMap;

	// Token: 0x0400EDEC RID: 60908
	[Nullable(2)]
	private static AnsPerformConfig _Instance;
}
