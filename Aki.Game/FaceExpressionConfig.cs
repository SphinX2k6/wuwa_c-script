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

// Token: 0x020031F9 RID: 12793
[NullableContext(1)]
[Nullable(0)]
public class FaceExpressionConfig : ConfigBase
{
	// Token: 0x1700262D RID: 9773
	// (get) Token: 0x0601B9A6 RID: 113062 RVA: 0x0079476C File Offset: 0x0079296C
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

	// Token: 0x0601B9A7 RID: 113063 RVA: 0x007947A0 File Offset: 0x007929A0
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

	// Token: 0x0601B9A8 RID: 113064 RVA: 0x007947FE File Offset: 0x007929FE
	protected override bool OnInit()
	{
		this.CacheFaceExpressionMap = new Dictionary<int, Aki.TDConfigMgr.Action.IFaceExpressionConfigData>();
		return true;
	}

	// Token: 0x0601B9A9 RID: 113065 RVA: 0x0079480C File Offset: 0x00792A0C
	protected override bool OnClear()
	{
		this.CacheFaceExpressionMap = null;
		return true;
	}

	// Token: 0x0601B9AA RID: 113066 RVA: 0x00794818 File Offset: 0x00792A18
	[NullableContext(2)]
	public Aki.TDConfigMgr.Action.IFaceExpressionConfigData GetFaceExpressionConfig(int id)
	{
		if (!PublicUtil.Instance.UseDbConfig())
		{
			this.ParseConfigFromJsonFile();
			Aki.TDConfigMgr.Action.IFaceExpressionConfigData result;
			this.CacheFaceExpressionMap.TryGetValue(id, out result);
			return result;
		}
		if (WrapperSetting.UseFb)
		{
			Aki.TDConfigMgr.Action.IFaceExpressionConfigData faceExpressionConfigData = this.FaceExpressionFbLru.Get(id);
			if (((faceExpressionConfigData != null) ? faceExpressionConfigData.FaceExpression : null) == null)
			{
				return null;
			}
			return faceExpressionConfigData;
		}
		else
		{
			FaceExpressionData? config = ConfigFaceExpressionDataById.GetConfig(id, false);
			if (config == null || string.IsNullOrEmpty(config.Value.FaceExpression))
			{
				return null;
			}
			Aki.TDConfigMgr.Action.IFaceExpressionConfig maleVariant = null;
			if (!string.IsNullOrEmpty(config.Value.MaleVariant))
			{
				maleVariant = Json.Parse<Aki.TDConfigMgr.Action.IFaceExpressionConfig>(config.Value.MaleVariant, null);
			}
			return new Aki.TDConfigMgr.Action.IFaceExpressionConfigData
			{
				Id = config.Value.Id,
				FaceExpression = Json.Parse<Aki.TDConfigMgr.Action.IFaceExpressionConfig>(config.Value.FaceExpression, null),
				MaleVariant = maleVariant,
				CloseAutoBlink = new bool?(config.Value.CloseAutoBlink)
			};
		}
	}

	// Token: 0x0601B9AB RID: 113067 RVA: 0x00794924 File Offset: 0x00792B24
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

	// Token: 0x1700262E RID: 9774
	// (get) Token: 0x0601B9AC RID: 113068 RVA: 0x00794A1C File Offset: 0x00792C1C
	public static FaceExpressionConfig Instance
	{
		get
		{
			return FaceExpressionConfig._Instance;
		}
	}

	// Token: 0x0601B9AD RID: 113069 RVA: 0x00794A23 File Offset: 0x00792C23
	public static FaceExpressionConfig GetOrCreateInstance()
	{
		if (FaceExpressionConfig._Instance == null)
		{
			FaceExpressionConfig.CreateInstance();
		}
		return FaceExpressionConfig._Instance;
	}

	// Token: 0x0601B9AE RID: 113070 RVA: 0x00794A37 File Offset: 0x00792C37
	public static bool CreateInstance()
	{
		if (FaceExpressionConfig._Instance != null)
		{
			return true;
		}
		FaceExpressionConfig._Instance = new FaceExpressionConfig();
		return true;
	}

	// Token: 0x0601B9AF RID: 113071 RVA: 0x00794A4D File Offset: 0x00792C4D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B9B0 RID: 113072 RVA: 0x00794A4F File Offset: 0x00792C4F
	public static void ResetStaticDefaultValue()
	{
		FaceExpressionConfig._Instance = null;
	}

	// Token: 0x0601B9B1 RID: 113073 RVA: 0x00794A57 File Offset: 0x00792C57
	static FaceExpressionConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FaceExpressionConfig.CreateStaticDefaultValue), new Action(FaceExpressionConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400D907 RID: 55559
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, Aki.TDConfigMgr.Action.IFaceExpressionConfigData> CacheFaceExpressionMap;

	// Token: 0x0400D908 RID: 55560
	private bool InitFromJson;

	// Token: 0x0400D909 RID: 55561
	private string FaceExpressionFbPath = UBlueprintPathsLibrary.ProjectContentDir() + "Aki/Config/UniverseEditorConfig/FaceExpressions/";

	// Token: 0x0400D90A RID: 55562
	private const int FACE_EXPRESSION_FB_LRU_CAPACITY = 50;

	// Token: 0x0400D90B RID: 55563
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CacheLru<int, Aki.TDConfigMgr.Action.IFaceExpressionConfigData> FaceExpressionFbLruInternal;

	// Token: 0x0400D90C RID: 55564
	[Nullable(2)]
	private static FaceExpressionConfig _Instance;
}
