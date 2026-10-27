using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Render;
using CSharpScript.Game.World.Controller;
using UnrealEngine;

// Token: 0x0200354C RID: 13644
[NullableContext(1)]
[Nullable(0)]
public class WorldGlobal : IStaticVariableResetter
{
	// Token: 0x0601DF5E RID: 122718 RVA: 0x00865700 File Offset: 0x00863900
	static WorldGlobal()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldGlobal.CreateStaticDefaultValue), new Action(WorldGlobal.ResetStaticDefaultValue));
	}

	// Token: 0x0601DF5F RID: 122719 RVA: 0x0086571F File Offset: 0x0086391F
	public static void CreateStaticDefaultValue()
	{
		WorldGlobal.SweepHitResult = null;
	}

	// Token: 0x0601DF60 RID: 122720 RVA: 0x00865727 File Offset: 0x00863927
	public static void ResetStaticDefaultValue()
	{
		WorldGlobal.BeginTravelLoadMapDelegate = null;
		WorldGlobal.EndLoadTransitionMapHandler = null;
		WorldGlobal.BeginLoadMapHandler = null;
		WorldGlobal.EndLoadMapHandler = null;
		WorldGlobal.LoadStreamLevelHandler = null;
		WorldGlobal.UnLoadStreamLevelHandler = null;
		WorldGlobal.SweepHitResult = null;
	}

	// Token: 0x0601DF61 RID: 122721 RVA: 0x00865754 File Offset: 0x00863954
	public static void Initialize()
	{
		GlobalData.GameInstance.场景加载通知器 = new ULoadMapNotify(GlobalData.GameInstance, null, EObjectFlags.RF_NoFlags);
		GlobalData.GameInstance.场景加载通知器.Clear();
		Action<string> callback;
		if ((callback = WorldGlobal.<>O.<0>__BeginTravelLoadMap) == null)
		{
			callback = (WorldGlobal.<>O.<0>__BeginTravelLoadMap = new Action<string>(WorldGlobal.BeginTravelLoadMap));
		}
		WorldGlobal.BeginTravelLoadMapDelegate = DelegateUtils.ToManualReleaseDelegate<FBeginTravelLoadMapDelegate>(callback);
		GlobalData.GameInstance.场景加载通知器.BindBeginTravelLoadMap(WorldGlobal.BeginTravelLoadMapDelegate);
		Action<string> callback2;
		if ((callback2 = WorldGlobal.<>O.<1>__AfterEnterTransitionMap) == null)
		{
			callback2 = (WorldGlobal.<>O.<1>__AfterEnterTransitionMap = new Action<string>(WorldGlobal.AfterEnterTransitionMap));
		}
		WorldGlobal.EndLoadTransitionMapHandler = DelegateUtils.ToManualReleaseDelegate<FEndLoadTransitionMapDelegate>(callback2);
		GlobalData.GameInstance.场景加载通知器.BindEndLoadTransitionMap(WorldGlobal.EndLoadTransitionMapHandler);
		Action<string> callback3;
		if ((callback3 = WorldGlobal.<>O.<2>__BeginLoadMap) == null)
		{
			callback3 = (WorldGlobal.<>O.<2>__BeginLoadMap = new Action<string>(WorldGlobal.BeginLoadMap));
		}
		WorldGlobal.BeginLoadMapHandler = DelegateUtils.ToManualReleaseDelegate<FBeginLoadMapDelegate>(callback3);
		GlobalData.GameInstance.场景加载通知器.BindBeginLoadMap(WorldGlobal.BeginLoadMapHandler);
		Action<string> callback4;
		if ((callback4 = WorldGlobal.<>O.<3>__EndLoadMap) == null)
		{
			callback4 = (WorldGlobal.<>O.<3>__EndLoadMap = new Action<string>(WorldGlobal.EndLoadMap));
		}
		WorldGlobal.EndLoadMapHandler = DelegateUtils.ToManualReleaseDelegate<FEndLoadMapDelegate>(callback4);
		GlobalData.GameInstance.场景加载通知器.BindEndLoadMap(WorldGlobal.EndLoadMapHandler);
		Action<int, FName, ULevelStreaming> callback5;
		if ((callback5 = WorldGlobal.<>O.<4>__LoadSubLevel) == null)
		{
			callback5 = (WorldGlobal.<>O.<4>__LoadSubLevel = new Action<int, FName, ULevelStreaming>(WorldGlobal.LoadSubLevel));
		}
		WorldGlobal.LoadStreamLevelHandler = DelegateUtils.ToManualReleaseDelegate<FLoadStreamLevelDelegate>(callback5);
		GlobalData.GameInstance.场景加载通知器.BindLoadStreamLevel(WorldGlobal.LoadStreamLevelHandler);
		Action<int, FName> callback6;
		if ((callback6 = WorldGlobal.<>O.<5>__UnLoadSubLevel) == null)
		{
			callback6 = (WorldGlobal.<>O.<5>__UnLoadSubLevel = new Action<int, FName>(WorldGlobal.UnLoadSubLevel));
		}
		WorldGlobal.UnLoadStreamLevelHandler = DelegateUtils.ToManualReleaseDelegate<FUnLoadStreamLevelDelegate>(callback6);
		GlobalData.GameInstance.场景加载通知器.BindUnLoadStreamLevel(WorldGlobal.UnLoadStreamLevelHandler);
	}

	// Token: 0x0601DF62 RID: 122722 RVA: 0x008658DC File Offset: 0x00863ADC
	public static void Clear()
	{
		Action<string> callBack;
		if ((callBack = WorldGlobal.<>O.<0>__BeginTravelLoadMap) == null)
		{
			callBack = (WorldGlobal.<>O.<0>__BeginTravelLoadMap = new Action<string>(WorldGlobal.BeginTravelLoadMap));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack);
		Action<string> callBack2;
		if ((callBack2 = WorldGlobal.<>O.<1>__AfterEnterTransitionMap) == null)
		{
			callBack2 = (WorldGlobal.<>O.<1>__AfterEnterTransitionMap = new Action<string>(WorldGlobal.AfterEnterTransitionMap));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack2);
		Action<string> callBack3;
		if ((callBack3 = WorldGlobal.<>O.<2>__BeginLoadMap) == null)
		{
			callBack3 = (WorldGlobal.<>O.<2>__BeginLoadMap = new Action<string>(WorldGlobal.BeginLoadMap));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack3);
		Action<string> callBack4;
		if ((callBack4 = WorldGlobal.<>O.<3>__EndLoadMap) == null)
		{
			callBack4 = (WorldGlobal.<>O.<3>__EndLoadMap = new Action<string>(WorldGlobal.EndLoadMap));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack4);
		Action<int, FName, ULevelStreaming> callBack5;
		if ((callBack5 = WorldGlobal.<>O.<4>__LoadSubLevel) == null)
		{
			callBack5 = (WorldGlobal.<>O.<4>__LoadSubLevel = new Action<int, FName, ULevelStreaming>(WorldGlobal.LoadSubLevel));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack5);
		Action<int, FName> callBack6;
		if ((callBack6 = WorldGlobal.<>O.<5>__UnLoadSubLevel) == null)
		{
			callBack6 = (WorldGlobal.<>O.<5>__UnLoadSubLevel = new Action<int, FName>(WorldGlobal.UnLoadSubLevel));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack6);
		GlobalData.GameInstance.场景加载通知器.Clear();
	}

	// Token: 0x0601DF63 RID: 122723 RVA: 0x008659B8 File Offset: 0x00863BB8
	public static void LoadFromMap(int id)
	{
		AkiMapSource? akiMapSourceConfig = WorldMapConfig.Instance.GetAkiMapSourceConfig(id);
		if (akiMapSourceConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[WorldGlobal.LoadFromMap] 不存在Id:的AkiMapSourceConfig。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		WorldGlobal.OpenLevel(akiMapSourceConfig.Value.MapPath);
	}

	// Token: 0x0601DF64 RID: 122724 RVA: 0x00865A1C File Offset: 0x00863C1C
	public static void OpenLevel(string levelName)
	{
		if (SeamlessTravelModel.Instance.IsSeamlessTravel && SeamlessTravelController.Instance.StartTravel(levelName))
		{
			return;
		}
		if (!GameModeModel.Instance.ForceClientTravel && GameModeModel.Instance.IsSameMapTraveling)
		{
			GameModeModel.Instance.FlushTempDataLayers();
			RenderModuleModel instance = RenderModuleModel.Instance;
			if (instance != null)
			{
				instance.FlushTempDependenciesNotMatchDataLayers();
			}
			WorldGlobal.BeginLoadMap(levelName);
			WorldGlobal.EndLoadMap(levelName);
			return;
		}
		WorldGlobal.PlayerClientTravel(Global.PlayerController, levelName);
	}

	// Token: 0x0601DF65 RID: 122725 RVA: 0x00865A90 File Offset: 0x00863C90
	public static void PlayerClientTravel(APlayerController playerController, string url)
	{
		playerController.ClientTravel(url, ETravelType.TRAVEL_Relative, true, default(FGuid));
	}

	// Token: 0x0601DF66 RID: 122726 RVA: 0x00865AB0 File Offset: 0x00863CB0
	public static void ToUeInt32Array([Nullable(2)] IList<int> inItems, TArray<int> outItems)
	{
		outItems.Empty(true);
		if (inItems == null)
		{
			return;
		}
		foreach (int value in inItems)
		{
			outItems.Add(value);
		}
	}

	// Token: 0x0601DF67 RID: 122727 RVA: 0x00865B04 File Offset: 0x00863D04
	public static void ToUeInt64Array([Nullable(2)] IList<long> inItems, TArray<long> outItems)
	{
		outItems.Empty(true);
		if (inItems == null)
		{
			return;
		}
		foreach (long value in inItems)
		{
			outItems.Add(value);
		}
	}

	// Token: 0x0601DF68 RID: 122728 RVA: 0x00865B58 File Offset: 0x00863D58
	public static void ToUeFloatArray([Nullable(2)] IList<float> inItems, TArray<float> outItems)
	{
		outItems.Empty(true);
		if (inItems == null)
		{
			return;
		}
		foreach (float value in inItems)
		{
			outItems.Add(value);
		}
	}

	// Token: 0x0601DF69 RID: 122729 RVA: 0x00865BAC File Offset: 0x00863DAC
	public static void ToUeStringArray([Nullable(new byte[]
	{
		2,
		1
	})] IList<string> inItems, TArray<string> outItems)
	{
		outItems.Empty(true);
		if (inItems == null)
		{
			return;
		}
		foreach (string value in inItems)
		{
			outItems.Add(value);
		}
	}

	// Token: 0x0601DF6A RID: 122730 RVA: 0x00865C00 File Offset: 0x00863E00
	public static void ToTsArray<[Nullable(2)] T>([Nullable(new byte[]
	{
		2,
		1
	})] TArray<T> inItems, IList<T> outItems)
	{
		if (inItems == null)
		{
			outItems.Clear();
			return;
		}
		int num = inItems.Num();
		outItems.Clear();
		for (int i = 0; i < num; i++)
		{
			outItems.Add(inItems.Get(i));
		}
	}

	// Token: 0x0601DF6B RID: 122731 RVA: 0x00865C3D File Offset: 0x00863E3D
	public static void ResetArraySize<[Nullable(2)] T>(TArray<T> items, int newSize, T defaultValue)
	{
		while (items.Num() > newSize)
		{
			items.RemoveAt(items.Num() - 1);
		}
		while (items.Num() < newSize)
		{
			items.Add(defaultValue);
		}
	}

	// Token: 0x0601DF6C RID: 122732 RVA: 0x00865C6A File Offset: 0x00863E6A
	public static void ResetTsArraySize<[Nullable(2)] T>(List<T> items, int newSize, T defaultValue)
	{
		while (items.Count > newSize)
		{
			items.RemoveAt(items.Count - 1);
		}
		while (items.Count < newSize)
		{
			items.Add(defaultValue);
		}
	}

	// Token: 0x0601DF6D RID: 122733 RVA: 0x00865C97 File Offset: 0x00863E97
	public static Aki.Protocol.Vector ToTsVector(FVectorDouble value)
	{
		return new Aki.Protocol.Vector
		{
			X = (float)value.X,
			Y = (float)value.Y,
			Z = (float)value.Z
		};
	}

	// Token: 0x0601DF6E RID: 122734 RVA: 0x00865CC5 File Offset: 0x00863EC5
	public static Aki.Protocol.Vector ToTsVector(IVector value)
	{
		return new Aki.Protocol.Vector
		{
			X = (float)value.X,
			Y = (float)value.Y,
			Z = (float)value.Z
		};
	}

	// Token: 0x0601DF6F RID: 122735 RVA: 0x00865CF3 File Offset: 0x00863EF3
	[NullableContext(2)]
	public static FVector ToUeVectorOld(Aki.Protocol.Vector value)
	{
		if (value == null)
		{
			return global::Vector.ZeroVector;
		}
		return new FVector(value.X, value.Y, value.Z);
	}

	// Token: 0x0601DF70 RID: 122736 RVA: 0x00865D15 File Offset: 0x00863F15
	[NullableContext(2)]
	public static FVectorDouble ToUeVector(IVector value)
	{
		if (value == null)
		{
			return global::Vector.ZeroVectorDouble;
		}
		return new FVectorDouble(value.X, value.Y, value.Z);
	}

	// Token: 0x0601DF71 RID: 122737 RVA: 0x00865D37 File Offset: 0x00863F37
	public static Aki.Protocol.Rotator ToTsRotator(FRotator value)
	{
		Aki.Protocol.Rotator rotator = Aki.Protocol.Rotator.Create();
		rotator.Pitch = value.Pitch;
		rotator.Yaw = value.Yaw;
		rotator.Roll = value.Roll;
		return rotator;
	}

	// Token: 0x0601DF72 RID: 122738 RVA: 0x00865D62 File Offset: 0x00863F62
	[NullableContext(2)]
	public static FRotator ToUeRotator(Aki.Protocol.Rotator value)
	{
		if (value == null)
		{
			return new FRotator();
		}
		return new FRotator(value.Pitch, value.Yaw, value.Roll);
	}

	// Token: 0x0601DF73 RID: 122739 RVA: 0x00865D84 File Offset: 0x00863F84
	public static FGameplayAttributeData ToUeGameplayAttribute([Nullable(2)] GameplayAttributeData attribute)
	{
		FGameplayAttributeData fgameplayAttributeData = new FGameplayAttributeData();
		if (attribute == null)
		{
			return fgameplayAttributeData;
		}
		fgameplayAttributeData.AttributeType = attribute.AttributeType;
		fgameplayAttributeData.BaseValue = (float)attribute.BaseValue;
		fgameplayAttributeData.CurrentValue = (float)attribute.CurrentValue;
		return fgameplayAttributeData;
	}

	// Token: 0x0601DF74 RID: 122740 RVA: 0x00865DC3 File Offset: 0x00863FC3
	public static void OnStatStart()
	{
		if (GlobalData.World == null || Info.Instance.IsBuildShipping)
		{
			return;
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "STAT STARTFILE", null);
	}

	// Token: 0x0601DF75 RID: 122741 RVA: 0x00865DE9 File Offset: 0x00863FE9
	public static void OnStatStop()
	{
		if (GlobalData.World == null || Info.Instance.IsBuildShipping)
		{
			return;
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "STAT STOPFILE", null);
	}

	// Token: 0x0601DF76 RID: 122742 RVA: 0x00865E0F File Offset: 0x0086400F
	public static void ResetLoadTime()
	{
		if (GlobalData.World == null || Info.Instance.IsBuildShipping)
		{
			return;
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "LoadTimes.TestTime 0", null);
	}

	// Token: 0x0601DF77 RID: 122743 RVA: 0x00865E35 File Offset: 0x00864035
	public static float GetLoadTime()
	{
		if (Info.Instance.IsBuildShipping)
		{
			return 0f;
		}
		return UKismetSystemLibrary.GetConsoleVariableFloatValue("LoadTimes.TestTime");
	}

	// Token: 0x0601DF78 RID: 122744 RVA: 0x00865E53 File Offset: 0x00864053
	public static void LoadTimesCheckBegin(string groupName = "default")
	{
		if (GlobalData.World == null || Info.Instance.IsBuildShipping)
		{
			return;
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "LoadTimes.TestSwitch 1", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "LoadTimes.DumpTest Start " + groupName, null);
	}

	// Token: 0x0601DF79 RID: 122745 RVA: 0x00865E8F File Offset: 0x0086408F
	public static void LoadTimesCheckEnd()
	{
		if (GlobalData.World == null || Info.Instance.IsBuildShipping)
		{
			return;
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "LoadTimes.DumpTest LOWTIME=-1", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "LoadTimes.TestSwitch 0", null);
	}

	// Token: 0x0601DF7A RID: 122746 RVA: 0x00865EC5 File Offset: 0x008640C5
	private static void BeginTravelLoadMap(string mapName)
	{
		EventSystem.Instance.Emit(EEventName.BeforeTravelMap);
	}

	// Token: 0x0601DF7B RID: 122747 RVA: 0x00865ED7 File Offset: 0x008640D7
	private static void AfterEnterTransitionMap(string mapName)
	{
		EventSystem.Instance.Emit(EEventName.OnEnterTransitionMap);
	}

	// Token: 0x0601DF7C RID: 122748 RVA: 0x00865EE9 File Offset: 0x008640E9
	private static void BeginLoadMap(string mapName)
	{
		if (GameModeModel.Instance.MapPath != mapName)
		{
			return;
		}
		GameModeController.Instance.BeforeLoadMap();
	}

	// Token: 0x0601DF7D RID: 122749 RVA: 0x00865F08 File Offset: 0x00864108
	private static void EndLoadMap(string mapName)
	{
		if (GlobalData.World == null || !GlobalData.World.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "加载地图失败，因为World为空。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MapName", mapName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (GameModeModel.Instance.MapPath != mapName)
		{
			return;
		}
		GameModeController.Instance.AfterLoadMap();
		EventSystem.Instance.Emit(EEventName.EndTravelMap);
	}

	// Token: 0x0601DF7E RID: 122750 RVA: 0x00865F7C File Offset: 0x0086417C
	[NullableContext(2)]
	private static void LoadSubLevel(int linkId, FName levelName, ULevelStreaming level)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.LFJW;
		string message = "LoadStream完成。";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelName", levelName.ToString());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (GlobalData.World == null || !GlobalData.World.IsValid())
		{
			return;
		}
		SubLevelController.Instance.OnLoadSubLevel(linkId, levelName.ToString(), level);
	}

	// Token: 0x0601DF7F RID: 122751 RVA: 0x00865FE8 File Offset: 0x008641E8
	private unsafe static void UnLoadSubLevel(int linkId, FName levelName)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.LFJW;
		string message = "UnLoadStream完成。";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LinkId", linkId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LevelName", levelName.ToString());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (GlobalData.World == null || !GlobalData.World.IsValid())
		{
			return;
		}
		SubLevelController.Instance.OnUnLoadSubLevel(linkId, levelName.ToString());
	}

	// Token: 0x0400EB5C RID: 60252
	public const float RAY_DISTANCE = 200f;

	// Token: 0x0400EB5D RID: 60253
	public const int ONE_SECOND_FOR_MILLISECOND = 1000;

	// Token: 0x0400EB5E RID: 60254
	public const int ONE_METER_FOR_CENTIMETER = 100;

	// Token: 0x0400EB5F RID: 60255
	[Nullable(2)]
	private static FBeginTravelLoadMapDelegate BeginTravelLoadMapDelegate;

	// Token: 0x0400EB60 RID: 60256
	[Nullable(2)]
	private static FEndLoadTransitionMapDelegate EndLoadTransitionMapHandler;

	// Token: 0x0400EB61 RID: 60257
	[Nullable(2)]
	private static FBeginLoadMapDelegate BeginLoadMapHandler;

	// Token: 0x0400EB62 RID: 60258
	[Nullable(2)]
	private static FEndLoadMapDelegate EndLoadMapHandler;

	// Token: 0x0400EB63 RID: 60259
	[Nullable(2)]
	private static FLoadStreamLevelDelegate LoadStreamLevelHandler;

	// Token: 0x0400EB64 RID: 60260
	[Nullable(2)]
	private static FUnLoadStreamLevelDelegate UnLoadStreamLevelHandler;

	// Token: 0x0400EB65 RID: 60261
	[Nullable(2)]
	public static FHitResult SweepHitResult;

	// Token: 0x020099C9 RID: 39369
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04030E4B RID: 200267
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <0>__BeginTravelLoadMap;

		// Token: 0x04030E4C RID: 200268
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <1>__AfterEnterTransitionMap;

		// Token: 0x04030E4D RID: 200269
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <2>__BeginLoadMap;

		// Token: 0x04030E4E RID: 200270
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <3>__EndLoadMap;

		// Token: 0x04030E4F RID: 200271
		[Nullable(new byte[]
		{
			0,
			2
		})]
		public static Action<int, FName, ULevelStreaming> <4>__LoadSubLevel;

		// Token: 0x04030E50 RID: 200272
		[Nullable(0)]
		public static Action<int, FName> <5>__UnLoadSubLevel;
	}
}
