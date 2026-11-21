using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using Google.FlatBuffers;
using UnrealEngine;

// Token: 0x02002768 RID: 10088
[NullableContext(1)]
[Nullable(0)]
public class FaceExpressionConfig : ConfigBase
{
	// Token: 0x1700286E RID: 10350
	// (get) Token: 0x0601952B RID: 103723 RVA: 0x007BCE98 File Offset: 0x007BB098
	private CacheLru<int, Aki.TDConfigMgr.Action.IFaceExpressionConfigData> FaceExpressionFbLru
	{
		get
		{
			CacheLru<int, Aki.TDConfigMgr.Action.IFaceExpressionConfigData> result;
			if ((result = this.FaceExpressionFbLruInternal) == null)
			{
				result = (this.FaceExpressionFbLruInternal = new CacheLru<int, Aki.TDConfigMgr.Action.IFaceExpressionConfigData>(50, new Func<int, Aki.TDConfigMgr.Action.IFaceExpressionConfigData>(this.LoadFaceExpressionFromFb)));
			}
			return result;
		}
	}

	// Token: 0x0601952C RID: 103724 RVA: 0x007BCECC File Offset: 0x007BB0CC
	[NullableContext(2)]
	private Aki.TDConfigMgr.Action.IFaceExpressionConfigData LoadFaceExpressionFromFb(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
		defaultInterpolatedStringHandler.AppendFormatted(this.FaceExpressionFbPath);
		defaultInterpolatedStringHandler.AppendFormatted<int>(id);
		defaultInterpolatedStringHandler.AppendLiteral(".bytes");
		ByteBuffer byteBuffer = FbFileLoader.LoadBytes(defaultInterpolatedStringHandler.ToStringAndClear());
		if (byteBuffer == null)
		{
			return null;
		}
		return Aki.TDConfigMgr.Action.IFaceExpressionConfigData.Create(Aki.TDConfigMgr.Action.Fb.IFaceExpressionConfigData.Create(new Aki.UniverseEditor.Interface.Fbs.Action.IFaceExpressionConfigData?(Aki.UniverseEditor.Interface.Fbs.Action.IFaceExpressionConfigData.GetRootAsIFaceExpressionConfigData(byteBuffer))));
	}

	// Token: 0x0601952D RID: 103725 RVA: 0x007BCF2A File Offset: 0x007BB12A
	protected override bool OnInit()
	{
		this.CacheFaceExpressionMap = new Dictionary<int, Aki.TDConfigMgr.Action.IFaceExpressionConfigData>();
		return true;
	}

	// Token: 0x0601952E RID: 103726 RVA: 0x007BCF38 File Offset: 0x007BB138
	protected override bool OnClear()
	{
		this.CacheFaceExpressionMap = null;
		return true;
	}

	// Token: 0x0601952F RID: 103727 RVA: 0x007BCF44 File Offset: 0x007BB144
	[NullableContext(2)]
	public Aki.TDConfigMgr.Action.IFaceExpressionConfigData GetFaceExpressionConfig(int id)
	{
		Aki.TDConfigMgr.Action.IFaceExpressionConfigData faceExpressionConfigData = this.FaceExpressionFbLru.Get(id);
		if (((faceExpressionConfigData != null) ? faceExpressionConfigData.FaceExpression : null) == null)
		{
			return null;
		}
		return faceExpressionConfigData;
	}

	// Token: 0x06019530 RID: 103728 RVA: 0x007BCF70 File Offset: 0x007BB170
	private void ParseConfigFromJsonFile()
	{
		if (this.InitFromJson)
		{
			return;
		}
		this.InitFromJson = true;
		string configPath = PublicUtil.Instance.GetConfigPath("../Config/Raw/Tables/k.可视化编辑/__Temp__/Json/FaceExpressionConfig.json");
		if (!PublicUtil.Instance.IsUseTempData())
		{
			configPath = PublicUtil.Instance.GetConfigPath("Content/Aki/UniverseEditorConfig/Json/FaceExpressionConfig.json");
		}
		if (!UBlueprintPathsLibrary.FileExists(configPath))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.NPC;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[FaceExpressionConfig] 不存在FaceExpressionConfig.json文件。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", configPath);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string text = "";
		UKuroStaticLibrary.LoadFileToString(ref text, configPath);
		foreach (Aki.TDConfigMgr.Action.IFaceExpressionConfigData faceExpressionConfigData in Json.Parse<List<Aki.TDConfigMgr.Action.IFaceExpressionConfigData>>(text, null))
		{
			if (faceExpressionConfigData != null && !this.CacheFaceExpressionMap.ContainsKey(faceExpressionConfigData.Id))
			{
				this.CacheFaceExpressionMap[faceExpressionConfigData.Id] = faceExpressionConfigData;
			}
		}
	}

	// Token: 0x1700286F RID: 10351
	// (get) Token: 0x06019531 RID: 103729 RVA: 0x007BD068 File Offset: 0x007BB268
	public static FaceExpressionConfig Instance
	{
		get
		{
			return FaceExpressionConfig._Instance;
		}
	}

	// Token: 0x06019532 RID: 103730 RVA: 0x007BD06F File Offset: 0x007BB26F
	public static FaceExpressionConfig GetOrCreateInstance()
	{
		if (FaceExpressionConfig._Instance == null)
		{
			FaceExpressionConfig.CreateInstance();
		}
		return FaceExpressionConfig._Instance;
	}

	// Token: 0x06019533 RID: 103731 RVA: 0x007BD083 File Offset: 0x007BB283
	public static bool CreateInstance()
	{
		if (FaceExpressionConfig._Instance != null)
		{
			return true;
		}
		FaceExpressionConfig._Instance = new FaceExpressionConfig();
		return true;
	}

	// Token: 0x06019534 RID: 103732 RVA: 0x007BD099 File Offset: 0x007BB299
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06019535 RID: 103733 RVA: 0x007BD09B File Offset: 0x007BB29B
	public static void ResetStaticDefaultValue()
	{
		FaceExpressionConfig._Instance = null;
	}

	// Token: 0x06019536 RID: 103734 RVA: 0x007BD0A3 File Offset: 0x007BB2A3
	static FaceExpressionConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FaceExpressionConfig.CreateStaticDefaultValue), new Action(FaceExpressionConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400DDA5 RID: 56741
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, Aki.TDConfigMgr.Action.IFaceExpressionConfigData> CacheFaceExpressionMap;

	// Token: 0x0400DDA6 RID: 56742
	private bool InitFromJson;

	// Token: 0x0400DDA7 RID: 56743
	private string FaceExpressionFbPath = UBlueprintPathsLibrary.ProjectContentDir() + "Aki/Config/UniverseEditorConfig/FaceExpressions/";

	// Token: 0x0400DDA8 RID: 56744
	private const int FACE_EXPRESSION_FB_LRU_CAPACITY = 50;

	// Token: 0x0400DDA9 RID: 56745
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CacheLru<int, Aki.TDConfigMgr.Action.IFaceExpressionConfigData> FaceExpressionFbLruInternal;

	// Token: 0x0400DDAA RID: 56746
	[Nullable(2)]
	private static FaceExpressionConfig _Instance;
}
