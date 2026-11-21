using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02002A64 RID: 10852
[NullableContext(1)]
[Nullable(0)]
public class AiBehaviorTreeConfig : ConfigBase
{
	// Token: 0x0601B882 RID: 112770 RVA: 0x0087C39B File Offset: 0x0087A59B
	protected override bool OnInit()
	{
		this.ConfigDataMap.Clear();
		return true;
	}

	// Token: 0x0601B883 RID: 112771 RVA: 0x0087C3A9 File Offset: 0x0087A5A9
	protected override bool OnClear()
	{
		this.ConfigDataMap.Clear();
		return true;
	}

	// Token: 0x0601B884 RID: 112772 RVA: 0x0087C3B8 File Offset: 0x0087A5B8
	[NullableContext(2)]
	public RawAiBehaviorTreeConfigData GetAiBehaviorTreeData(int id)
	{
		if (!this.ConfigDataMap.ContainsKey(id))
		{
			AiBehaviorTree? config = ConfigAiBehaviorTreeById.GetConfig(id, true);
			if (config == null)
			{
				return null;
			}
			this.ConfigDataMap[id] = AiBehaviorTreeConfig.FbToAiBehaviorTreeData(config.Value);
		}
		return this.ConfigDataMap[id];
	}

	// Token: 0x0601B885 RID: 112773 RVA: 0x0087C40C File Offset: 0x0087A60C
	private static RawAiBehaviorTreeConfigData FbToAiBehaviorTreeData(AiBehaviorTree fb)
	{
		return new RawAiBehaviorTreeConfigData
		{
			Id = fb.Id,
			Description = (fb.Description ?? ""),
			BtPath = (fb.BtPath ?? ""),
			BtType = (fb.BtType ?? "")
		};
	}

	// Token: 0x0601B886 RID: 112774 RVA: 0x0087C470 File Offset: 0x0087A670
	private void ParseConfigFromJsonFile()
	{
		string configPath = PublicUtil.Instance.GetConfigPath("../Config/Raw/Tables/k.可视化编辑/__Temp__/Json/AiBehaviorTree.json");
		if (!PublicUtil.Instance.IsUseTempData())
		{
			configPath = PublicUtil.Instance.GetConfigPath("Content/Aki/UniverseEditorConfig/Json/AiBehaviorTree.json");
		}
		if (!UBlueprintPathsLibrary.FileExists(configPath))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "不存在AiBehaviorTree.json文件。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", configPath);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string text = "";
		UKuroStaticLibrary.LoadFileToString(ref text, configPath);
		List<RawAiBehaviorTreeConfigData> list = Json.Parse<List<RawAiBehaviorTreeConfigData>>(text, null);
		if (list == null)
		{
			return;
		}
		foreach (RawAiBehaviorTreeConfigData rawAiBehaviorTreeConfigData in list)
		{
			this.ConfigDataMap[rawAiBehaviorTreeConfigData.Id] = rawAiBehaviorTreeConfigData;
		}
	}

	// Token: 0x17002C8D RID: 11405
	// (get) Token: 0x0601B887 RID: 112775 RVA: 0x0087C544 File Offset: 0x0087A744
	public static AiBehaviorTreeConfig Instance
	{
		get
		{
			return AiBehaviorTreeConfig._Instance;
		}
	}

	// Token: 0x0601B888 RID: 112776 RVA: 0x0087C54B File Offset: 0x0087A74B
	public static AiBehaviorTreeConfig GetOrCreateInstance()
	{
		if (AiBehaviorTreeConfig._Instance == null)
		{
			AiBehaviorTreeConfig.CreateInstance();
		}
		return AiBehaviorTreeConfig._Instance;
	}

	// Token: 0x0601B889 RID: 112777 RVA: 0x0087C55F File Offset: 0x0087A75F
	public static bool CreateInstance()
	{
		if (AiBehaviorTreeConfig._Instance != null)
		{
			return true;
		}
		AiBehaviorTreeConfig._Instance = new AiBehaviorTreeConfig();
		return true;
	}

	// Token: 0x0601B88A RID: 112778 RVA: 0x0087C575 File Offset: 0x0087A775
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B88B RID: 112779 RVA: 0x0087C577 File Offset: 0x0087A777
	public static void ResetStaticDefaultValue()
	{
		AiBehaviorTreeConfig._Instance = null;
	}

	// Token: 0x0601B88C RID: 112780 RVA: 0x0087C57F File Offset: 0x0087A77F
	static AiBehaviorTreeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AiBehaviorTreeConfig.CreateStaticDefaultValue), new Action(AiBehaviorTreeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400EDE9 RID: 60905
	private readonly Dictionary<int, RawAiBehaviorTreeConfigData> ConfigDataMap = new Dictionary<int, RawAiBehaviorTreeConfigData>();

	// Token: 0x0400EDEA RID: 60906
	[Nullable(2)]
	private static AiBehaviorTreeConfig _Instance;
}
