using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Wrapper.Out;
using Aki.UniverseEditor.Interface.Fbs.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using Google.FlatBuffers;
using UnrealEngine;

// Token: 0x020034F6 RID: 13558
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BubbleConfig : ConfigBase
{
	// Token: 0x170028F7 RID: 10487
	// (get) Token: 0x0601DB9D RID: 121757 RVA: 0x00854804 File Offset: 0x00852A04
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

	// Token: 0x0601DB9E RID: 121758 RVA: 0x00854838 File Offset: 0x00852A38
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

	// Token: 0x0601DB9F RID: 121759 RVA: 0x00854876 File Offset: 0x00852A76
	protected override bool OnInit()
	{
		this.BubbleDataMap = new Dictionary<string, Aki.TDConfigMgr.Action.AddPlayBubble>();
		return true;
	}

	// Token: 0x0601DBA0 RID: 121760 RVA: 0x00854884 File Offset: 0x00852A84
	protected override bool OnClear()
	{
		this.BubbleDataMap = null;
		return true;
	}

	// Token: 0x0601DBA1 RID: 121761 RVA: 0x00854890 File Offset: 0x00852A90
	private BubbleData? GetBubbleConfig(string actionGuid)
	{
		BubbleData? config = ConfigBubbleDataByActionGuid.GetConfig(actionGuid, false);
		if (config == null)
		{
			return null;
		}
		return config;
	}

	// Token: 0x0601DBA2 RID: 121762 RVA: 0x008548BC File Offset: 0x00852ABC
	[return: Nullable(2)]
	public Aki.TDConfigMgr.Action.AddPlayBubble GetBubbleData(string actionGuid)
	{
		if (!PublicUtil.Instance.UseDbConfig())
		{
			this.ParseConfigFromJsonFile();
			return this.BubbleDataMap.GetValueOrDefault(actionGuid);
		}
		if (WrapperSetting.UseFb)
		{
			Aki.TDConfigMgr.Action.ActionInfo actionInfo = this.BubbleFbLru.Get(actionGuid);
			return ((actionInfo != null) ? actionInfo.Params : null) as Aki.TDConfigMgr.Action.AddPlayBubble;
		}
		Aki.TDConfigMgr.Action.AddPlayBubble addPlayBubble;
		if (!this.BubbleDataMap.TryGetValue(actionGuid, out addPlayBubble))
		{
			BubbleData? bubbleConfig = this.GetBubbleConfig(actionGuid);
			if (bubbleConfig == null)
			{
				return null;
			}
			Aki.TDConfigMgr.Action.AddPlayBubble addPlayBubble2 = Json.Decode<Aki.TDConfigMgr.Action.AddPlayBubble>(bubbleConfig.Value.Params, null);
			if (addPlayBubble2 != null)
			{
				this.BubbleDataMap[actionGuid] = addPlayBubble2;
			}
		}
		return this.BubbleDataMap.GetValueOrDefault(actionGuid);
	}

	// Token: 0x0601DBA3 RID: 121763 RVA: 0x00854964 File Offset: 0x00852B64
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

	// Token: 0x170028F8 RID: 10488
	// (get) Token: 0x0601DBA4 RID: 121764 RVA: 0x00854A4D File Offset: 0x00852C4D
	public static BubbleConfig Instance
	{
		get
		{
			return BubbleConfig._Instance;
		}
	}

	// Token: 0x0601DBA5 RID: 121765 RVA: 0x00854A54 File Offset: 0x00852C54
	public static BubbleConfig GetOrCreateInstance()
	{
		if (BubbleConfig._Instance == null)
		{
			BubbleConfig.CreateInstance();
		}
		return BubbleConfig._Instance;
	}

	// Token: 0x0601DBA6 RID: 121766 RVA: 0x00854A68 File Offset: 0x00852C68
	public static bool CreateInstance()
	{
		if (BubbleConfig._Instance != null)
		{
			return true;
		}
		BubbleConfig._Instance = new BubbleConfig();
		return true;
	}

	// Token: 0x0601DBA7 RID: 121767 RVA: 0x00854A7E File Offset: 0x00852C7E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DBA8 RID: 121768 RVA: 0x00854A80 File Offset: 0x00852C80
	public static void ResetStaticDefaultValue()
	{
		BubbleConfig._Instance = null;
	}

	// Token: 0x0601DBA9 RID: 121769 RVA: 0x00854A88 File Offset: 0x00852C88
	static BubbleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BubbleConfig.CreateStaticDefaultValue), new Action(BubbleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400E945 RID: 59717
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, Aki.TDConfigMgr.Action.AddPlayBubble> BubbleDataMap;

	// Token: 0x0400E946 RID: 59718
	private string BubbleFbPath = UBlueprintPathsLibrary.ProjectContentDir() + "Aki/Config/UniverseEditorConfig/Bubbles/";

	// Token: 0x0400E947 RID: 59719
	private const int BUBBLE_FB_LRU_CAPACITY = 50;

	// Token: 0x0400E948 RID: 59720
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private CacheLru<string, Aki.TDConfigMgr.Action.ActionInfo> BubbleFbLruInternal;

	// Token: 0x0400E949 RID: 59721
	[Nullable(2)]
	private static BubbleConfig _Instance;
}
