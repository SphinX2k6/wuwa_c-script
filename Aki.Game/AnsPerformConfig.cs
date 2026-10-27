using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x020034F1 RID: 13553
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class AnsPerformConfig : ConfigBase
{
	// Token: 0x0601DB80 RID: 121728 RVA: 0x0085419D File Offset: 0x0085239D
	protected override bool OnInit()
	{
		this.ConfigDataMap = new Dictionary<int, AnsPerform>();
		return true;
	}

	// Token: 0x0601DB81 RID: 121729 RVA: 0x008541AB File Offset: 0x008523AB
	protected override bool OnClear()
	{
		this.ConfigDataMap = null;
		return true;
	}

	// Token: 0x0601DB82 RID: 121730 RVA: 0x008541B8 File Offset: 0x008523B8
	private AnsPerform? GetConfig(int id)
	{
		AnsPerform? config = ConfigAnsPerformById.GetConfig(id, false);
		if (config == null)
		{
			return null;
		}
		return config;
	}

	// Token: 0x0601DB83 RID: 121731 RVA: 0x008541E4 File Offset: 0x008523E4
	public AnsPerform? GetConfigData(int id)
	{
		AnsPerform? result = null;
		if (PublicUtil.Instance.UseDbConfig())
		{
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
		else
		{
			this.ParseConfigFromJsonFile();
			AnsPerform value;
			result = (this.ConfigDataMap.TryGetValue(id, out value) ? new AnsPerform?(value) : null);
			if (result == null)
			{
				return null;
			}
			return result;
		}
	}

	// Token: 0x0601DB84 RID: 121732 RVA: 0x008542A8 File Offset: 0x008524A8
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

	// Token: 0x170028F6 RID: 10486
	// (get) Token: 0x0601DB85 RID: 121733 RVA: 0x0085436C File Offset: 0x0085256C
	public static AnsPerformConfig Instance
	{
		get
		{
			return AnsPerformConfig._Instance;
		}
	}

	// Token: 0x0601DB86 RID: 121734 RVA: 0x00854373 File Offset: 0x00852573
	public static AnsPerformConfig GetOrCreateInstance()
	{
		if (AnsPerformConfig._Instance == null)
		{
			AnsPerformConfig.CreateInstance();
		}
		return AnsPerformConfig._Instance;
	}

	// Token: 0x0601DB87 RID: 121735 RVA: 0x00854387 File Offset: 0x00852587
	public static bool CreateInstance()
	{
		if (AnsPerformConfig._Instance != null)
		{
			return true;
		}
		AnsPerformConfig._Instance = new AnsPerformConfig();
		return true;
	}

	// Token: 0x0601DB88 RID: 121736 RVA: 0x0085439D File Offset: 0x0085259D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DB89 RID: 121737 RVA: 0x0085439F File Offset: 0x0085259F
	public static void ResetStaticDefaultValue()
	{
		AnsPerformConfig._Instance = null;
	}

	// Token: 0x0601DB8A RID: 121738 RVA: 0x008543A7 File Offset: 0x008525A7
	static AnsPerformConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AnsPerformConfig.CreateStaticDefaultValue), new Action(AnsPerformConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400E934 RID: 59700
	[Nullable(2)]
	private Dictionary<int, AnsPerform> ConfigDataMap;

	// Token: 0x0400E935 RID: 59701
	[Nullable(2)]
	private static AnsPerformConfig _Instance;
}
