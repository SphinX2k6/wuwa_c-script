using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using Google.FlatBuffers;
using UnrealEngine;

// Token: 0x02002A6A RID: 10858
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BubbleConfig : ConfigBase
{
	// Token: 0x17002C8F RID: 11407
	// (get) Token: 0x0601B8AB RID: 112811 RVA: 0x0087CBCC File Offset: 0x0087ADCC
	private CacheLru<string, Aki.TDConfigMgr.Action.ActionInfo> BubbleFbLru
	{
		get
		{
			CacheLru<string, Aki.TDConfigMgr.Action.ActionInfo> result;
			if ((result = this.BubbleFbLruInternal) == null)
			{
				result = (this.BubbleFbLruInternal = new CacheLru<string, Aki.TDConfigMgr.Action.ActionInfo>(50, new Func<string, Aki.TDConfigMgr.Action.ActionInfo>(this.LoadBubbleFromFb)));
			}
			return result;
		}
	}

	// Token: 0x0601B8AC RID: 112812 RVA: 0x0087CC00 File Offset: 0x0087AE00
	[return: Nullable(2)]
	private Aki.TDConfigMgr.Action.ActionInfo LoadBubbleFromFb(string actionGuid)
	{
		ByteBuffer byteBuffer = FbFileLoader.LoadBytes(this.BubbleFbPath + actionGuid + ".bytes");
		if (byteBuffer == null)
		{
			return null;
		}
		return Aki.TDConfigMgr.Action.ActionInfo.Create(Aki.TDConfigMgr.Action.Fb.ActionInfo.Create(new IActionInfo?(IActionInfo.GetRootAsIActionInfo(byteBuffer))));
	}

	// Token: 0x0601B8AD RID: 112813 RVA: 0x0087CC3E File Offset: 0x0087AE3E
	protected override bool OnInit()
	{
		this.BubbleDataMap = new Dictionary<string, Aki.TDConfigMgr.Action.AddPlayBubble>();
		return true;
	}

	// Token: 0x0601B8AE RID: 112814 RVA: 0x0087CC4C File Offset: 0x0087AE4C
	protected override bool OnClear()
	{
		this.BubbleDataMap = null;
		return true;
	}

	// Token: 0x0601B8AF RID: 112815 RVA: 0x0087CC58 File Offset: 0x0087AE58
	private BubbleData? GetBubbleConfig(string actionGuid)
	{
		BubbleData? config = ConfigBubbleDataByActionGuid.GetConfig(actionGuid, false);
		if (config == null)
		{
			return null;
		}
		return config;
	}

	// Token: 0x0601B8B0 RID: 112816 RVA: 0x0087CC84 File Offset: 0x0087AE84
	[return: Nullable(2)]
	public Aki.TDConfigMgr.Action.AddPlayBubble GetBubbleData(string actionGuid)
	{
		Aki.TDConfigMgr.Action.ActionInfo actionInfo = this.BubbleFbLru.Get(actionGuid);
		return ((actionInfo != null) ? actionInfo.Params : null) as Aki.TDConfigMgr.Action.AddPlayBubble;
	}

	// Token: 0x0601B8B1 RID: 112817 RVA: 0x0087CCB0 File Offset: 0x0087AEB0
	private void ParseConfigFromJsonFile()
	{
		string configPath = PublicUtil.Instance.GetConfigPath("../Config/Raw/Tables/k.可视化编辑/__Temp__/Json/BubbleConfig.json");
		if (!PublicUtil.Instance.IsUseTempData())
		{
			configPath = PublicUtil.Instance.GetConfigPath("Content/Aki/UniverseEditorConfig/Json/BubbleConfig.json");
		}
		if (!UBlueprintPathsLibrary.FileExists(configPath))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[CharacterFlowDynamic] 不存在BubbleConfig.json文件。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", configPath);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string text = "";
		UKuroStaticLibrary.LoadFileToString(ref text, configPath);
		Aki.TDConfigMgr.Action.ActionInfo[] array = Json.Parse<Aki.TDConfigMgr.Action.ActionInfo[]>(text, null);
		if (array == null)
		{
			return;
		}
		foreach (Aki.TDConfigMgr.Action.ActionInfo actionInfo in array)
		{
			if (!string.IsNullOrEmpty(actionInfo.ActionGuid))
			{
				Aki.TDConfigMgr.Action.AddPlayBubble addPlayBubble = actionInfo.Params as Aki.TDConfigMgr.Action.AddPlayBubble;
				if (addPlayBubble != null && !this.BubbleDataMap.ContainsKey(actionInfo.ActionGuid))
				{
					this.BubbleDataMap[actionInfo.ActionGuid] = addPlayBubble;
				}
			}
		}
	}

	// Token: 0x17002C90 RID: 11408
	// (get) Token: 0x0601B8B2 RID: 112818 RVA: 0x0087CD99 File Offset: 0x0087AF99
	public static BubbleConfig Instance
	{
		get
		{
			return BubbleConfig._Instance;
		}
	}

	// Token: 0x0601B8B3 RID: 112819 RVA: 0x0087CDA0 File Offset: 0x0087AFA0
	public static BubbleConfig GetOrCreateInstance()
	{
		if (BubbleConfig._Instance == null)
		{
			BubbleConfig.CreateInstance();
		}
		return BubbleConfig._Instance;
	}

	// Token: 0x0601B8B4 RID: 112820 RVA: 0x0087CDB4 File Offset: 0x0087AFB4
	public static bool CreateInstance()
	{
		if (BubbleConfig._Instance != null)
		{
			return true;
		}
		BubbleConfig._Instance = new BubbleConfig();
		return true;
	}

	// Token: 0x0601B8B5 RID: 112821 RVA: 0x0087CDCA File Offset: 0x0087AFCA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B8B6 RID: 112822 RVA: 0x0087CDCC File Offset: 0x0087AFCC
	public static void ResetStaticDefaultValue()
	{
		BubbleConfig._Instance = null;
	}

	// Token: 0x0601B8B7 RID: 112823 RVA: 0x0087CDD4 File Offset: 0x0087AFD4
	static BubbleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BubbleConfig.CreateStaticDefaultValue), new Action(BubbleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400EDFC RID: 60924
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, Aki.TDConfigMgr.Action.AddPlayBubble> BubbleDataMap;

	// Token: 0x0400EDFD RID: 60925
	private string BubbleFbPath = UBlueprintPathsLibrary.ProjectContentDir() + "Aki/Config/UniverseEditorConfig/Bubbles/";

	// Token: 0x0400EDFE RID: 60926
	private const int BUBBLE_FB_LRU_CAPACITY = 50;

	// Token: 0x0400EDFF RID: 60927
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private CacheLru<string, Aki.TDConfigMgr.Action.ActionInfo> BubbleFbLruInternal;

	// Token: 0x0400EE00 RID: 60928
	[Nullable(2)]
	private static BubbleConfig _Instance;
}
