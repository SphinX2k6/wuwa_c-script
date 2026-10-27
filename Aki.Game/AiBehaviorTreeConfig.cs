using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x020034F0 RID: 13552
[NullableContext(1)]
[Nullable(0)]
public class AiBehaviorTreeConfig : ConfigBase
{
	// Token: 0x0601DB74 RID: 121716 RVA: 0x00853F63 File Offset: 0x00852163
	protected override bool OnInit()
	{
		this.ConfigDataMap.Clear();
		return true;
	}

	// Token: 0x0601DB75 RID: 121717 RVA: 0x00853F71 File Offset: 0x00852171
	protected override bool OnClear()
	{
		this.ConfigDataMap.Clear();
		return true;
	}

	// Token: 0x0601DB76 RID: 121718 RVA: 0x00853F80 File Offset: 0x00852180
	[NullableContext(2)]
	public RawAiBehaviorTreeConfigData GetAiBehaviorTreeData(int id)
	{
		if (PublicUtil.Instance.UseDbConfig())
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
		this.ParseConfigFromJsonFile();
		RawAiBehaviorTreeConfigData result;
		if (this.ConfigDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0601DB77 RID: 121719 RVA: 0x00853FF8 File Offset: 0x008521F8
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

	// Token: 0x0601DB78 RID: 121720 RVA: 0x0085405C File Offset: 0x0085225C
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

	// Token: 0x170028F5 RID: 10485
	// (get) Token: 0x0601DB79 RID: 121721 RVA: 0x00854130 File Offset: 0x00852330
	public static AiBehaviorTreeConfig Instance
	{
		get
		{
			return AiBehaviorTreeConfig._Instance;
		}
	}

	// Token: 0x0601DB7A RID: 121722 RVA: 0x00854137 File Offset: 0x00852337
	public static AiBehaviorTreeConfig GetOrCreateInstance()
	{
		if (AiBehaviorTreeConfig._Instance == null)
		{
			AiBehaviorTreeConfig.CreateInstance();
		}
		return AiBehaviorTreeConfig._Instance;
	}

	// Token: 0x0601DB7B RID: 121723 RVA: 0x0085414B File Offset: 0x0085234B
	public static bool CreateInstance()
	{
		if (AiBehaviorTreeConfig._Instance != null)
		{
			return true;
		}
		AiBehaviorTreeConfig._Instance = new AiBehaviorTreeConfig();
		return true;
	}

	// Token: 0x0601DB7C RID: 121724 RVA: 0x00854161 File Offset: 0x00852361
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DB7D RID: 121725 RVA: 0x00854163 File Offset: 0x00852363
	public static void ResetStaticDefaultValue()
	{
		AiBehaviorTreeConfig._Instance = null;
	}

	// Token: 0x0601DB7E RID: 121726 RVA: 0x0085416B File Offset: 0x0085236B
	static AiBehaviorTreeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AiBehaviorTreeConfig.CreateStaticDefaultValue), new Action(AiBehaviorTreeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400E932 RID: 59698
	private readonly Dictionary<int, RawAiBehaviorTreeConfigData> ConfigDataMap = new Dictionary<int, RawAiBehaviorTreeConfigData>();

	// Token: 0x0400E933 RID: 59699
	[Nullable(2)]
	private static AiBehaviorTreeConfig _Instance;
}
