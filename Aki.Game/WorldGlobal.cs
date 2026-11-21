using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Render;
using CSharpScript.Game.World.Controller;
using UnrealEngine;

// Token: 0x02002AC1 RID: 10945
[NullableContext(1)]
[Nullable(0)]
public class WorldGlobal : IStaticVariableResetter
{
	// Token: 0x0601BC86 RID: 113798 RVA: 0x0088D338 File Offset: 0x0088B538
	static WorldGlobal()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldGlobal.CreateStaticDefaultValue), new Action(WorldGlobal.ResetStaticDefaultValue));
	}

	// Token: 0x0601BC87 RID: 113799 RVA: 0x0088D357 File Offset: 0x0088B557
	public static void CreateStaticDefaultValue()
	{
		WorldGlobal.SweepHitResult = null;
	}

	// Token: 0x0601BC88 RID: 113800 RVA: 0x0088D35F File Offset: 0x0088B55F
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

	// Token: 0x0601BC89 RID: 113801 RVA: 0x0088D38C File Offset: 0x0088B58C
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

	// Token: 0x0601BC8A RID: 113802 RVA: 0x0088D514 File Offset: 0x0088B714
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

	// Token: 0x0601BC8B RID: 113803 RVA: 0x0088D5F0 File Offset: 0x0088B7F0
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

	// Token: 0x0601BC8C RID: 113804 RVA: 0x0088D654 File Offset: 0x0088B854
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

	// Token: 0x0601BC8D RID: 113805 RVA: 0x0088D6C8 File Offset: 0x0088B8C8
	public static void PlayerClientTravel(APlayerController playerController, string url)
	{
		playerController.ClientTravel(url, ETravelType.TRAVEL_Relative, true, default(FGuid));
	}

	// Token: 0x0601BC8E RID: 113806 RVA: 0x0088D6E8 File Offset: 0x0088B8E8
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

	// Token: 0x0601BC8F RID: 113807 RVA: 0x0088D73C File Offset: 0x0088B93C
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

	// Token: 0x0601BC90 RID: 113808 RVA: 0x0088D790 File Offset: 0x0088B990
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

	// Token: 0x0601BC91 RID: 113809 RVA: 0x0088D7E4 File Offset: 0x0088B9E4
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

	// Token: 0x0601BC92 RID: 113810 RVA: 0x0088D838 File Offset: 0x0088BA38
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

	// Token: 0x0601BC93 RID: 113811 RVA: 0x0088D875 File Offset: 0x0088BA75
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

	// Token: 0x0601BC94 RID: 113812 RVA: 0x0088D8A2 File Offset: 0x0088BAA2
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

	// Token: 0x0601BC95 RID: 113813 RVA: 0x0088D8CF File Offset: 0x0088BACF
	public static Aki.Protocol.Vector ToTsVector(FVectorDouble value)
	{
		return new Aki.Protocol.Vector
		{
			X = (float)value.X,
			Y = (float)value.Y,
			Z = (float)value.Z
		};
	}

	// Token: 0x0601BC96 RID: 113814 RVA: 0x0088D8FD File Offset: 0x0088BAFD
	public static Aki.Protocol.Vector ToTsVector(IVector value)
	{
		return new Aki.Protocol.Vector
		{
			X = (float)value.X,
			Y = (float)value.Y,
			Z = (float)value.Z
		};
	}

	// Token: 0x0601BC97 RID: 113815 RVA: 0x0088D92B File Offset: 0x0088BB2B
	[NullableContext(2)]
	public static FVector ToUeVectorOld(Aki.Protocol.Vector value)
	{
		if (value == null)
		{
			return global::Vector.ZeroVector;
		}
		return new FVector(value.X, value.Y, value.Z);
	}

	// Token: 0x0601BC98 RID: 113816 RVA: 0x0088D94D File Offset: 0x0088BB4D
	[NullableContext(2)]
	public static FVectorDouble ToUeVector(IVector value)
	{
		if (value == null)
		{
			return global::Vector.ZeroVectorDouble;
		}
		return new FVectorDouble(value.X, value.Y, value.Z);
	}

	// Token: 0x0601BC99 RID: 113817 RVA: 0x0088D96F File Offset: 0x0088BB6F
	public static Aki.Protocol.Rotator ToTsRotator(FRotator value)
	{
		Aki.Protocol.Rotator rotator = Aki.Protocol.Rotator.Create();
		rotator.Pitch = value.Pitch;
		rotator.Yaw = value.Yaw;
		rotator.Roll = value.Roll;
		return rotator;
	}

	// Token: 0x0601BC9A RID: 113818 RVA: 0x0088D99A File Offset: 0x0088BB9A
	[NullableContext(2)]
	public static FRotator ToUeRotator(Aki.Protocol.Rotator value)
	{
		if (value == null)
		{
			return new FRotator();
		}
		return new FRotator(value.Pitch, value.Yaw, value.Roll);
	}

	// Token: 0x0601BC9B RID: 113819 RVA: 0x0088D9BC File Offset: 0x0088BBBC
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

	// Token: 0x0601BC9C RID: 113820 RVA: 0x0088D9FB File Offset: 0x0088BBFB
	public static void OnStatStart()
	{
		UWorld world = GlobalData.World;
	}

	// Token: 0x0601BC9D RID: 113821 RVA: 0x0088DA03 File Offset: 0x0088BC03
	public static void OnStatStop()
	{
		UWorld world = GlobalData.World;
	}

	// Token: 0x0601BC9E RID: 113822 RVA: 0x0088DA0B File Offset: 0x0088BC0B
	public static void ResetLoadTime()
	{
		UWorld world = GlobalData.World;
	}

	// Token: 0x0601BC9F RID: 113823 RVA: 0x0088DA13 File Offset: 0x0088BC13
	public static float GetLoadTime()
	{
		return 0f;
	}

	// Token: 0x0601BCA0 RID: 113824 RVA: 0x0088DA1A File Offset: 0x0088BC1A
	public static void LoadTimesCheckBegin(string groupName = "default")
	{
		UWorld world = GlobalData.World;
	}

	// Token: 0x0601BCA1 RID: 113825 RVA: 0x0088DA22 File Offset: 0x0088BC22
	public static void LoadTimesCheckEnd()
	{
		UWorld world = GlobalData.World;
	}

	// Token: 0x0601BCA2 RID: 113826 RVA: 0x0088DA2A File Offset: 0x0088BC2A
	private static void BeginTravelLoadMap(string mapName)
	{
		EventSystem.Instance.Emit(EEventName.BeforeTravelMap);
	}

	// Token: 0x0601BCA3 RID: 113827 RVA: 0x0088DA3C File Offset: 0x0088BC3C
	private static void AfterEnterTransitionMap(string mapName)
	{
		EventSystem.Instance.Emit(EEventName.OnEnterTransitionMap);
	}

	// Token: 0x0601BCA4 RID: 113828 RVA: 0x0088DA4E File Offset: 0x0088BC4E
	private static void BeginLoadMap(string mapName)
	{
		if (GameModeModel.Instance.MapPath != mapName)
		{
			return;
		}
		GameModeController.Instance.BeforeLoadMap();
	}

	// Token: 0x0601BCA5 RID: 113829 RVA: 0x0088DA70 File Offset: 0x0088BC70
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

	// Token: 0x0601BCA6 RID: 113830 RVA: 0x0088DAE4 File Offset: 0x0088BCE4
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

	// Token: 0x0601BCA7 RID: 113831 RVA: 0x0088DB50 File Offset: 0x0088BD50
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

	// Token: 0x0400F019 RID: 61465
	public const float RAY_DISTANCE = 200f;

	// Token: 0x0400F01A RID: 61466
	public const int ONE_SECOND_FOR_MILLISECOND = 1000;

	// Token: 0x0400F01B RID: 61467
	public const int ONE_METER_FOR_CENTIMETER = 100;

	// Token: 0x0400F01C RID: 61468
	[Nullable(2)]
	private static FBeginTravelLoadMapDelegate BeginTravelLoadMapDelegate;

	// Token: 0x0400F01D RID: 61469
	[Nullable(2)]
	private static FEndLoadTransitionMapDelegate EndLoadTransitionMapHandler;

	// Token: 0x0400F01E RID: 61470
	[Nullable(2)]
	private static FBeginLoadMapDelegate BeginLoadMapHandler;

	// Token: 0x0400F01F RID: 61471
	[Nullable(2)]
	private static FEndLoadMapDelegate EndLoadMapHandler;

	// Token: 0x0400F020 RID: 61472
	[Nullable(2)]
	private static FLoadStreamLevelDelegate LoadStreamLevelHandler;

	// Token: 0x0400F021 RID: 61473
	[Nullable(2)]
	private static FUnLoadStreamLevelDelegate UnLoadStreamLevelHandler;

	// Token: 0x0400F022 RID: 61474
	[Nullable(2)]
	public static FHitResult SweepHitResult;

	// Token: 0x02008BE3 RID: 35811
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402C4CE RID: 181454
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <0>__BeginTravelLoadMap;

		// Token: 0x0402C4CF RID: 181455
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <1>__AfterEnterTransitionMap;

		// Token: 0x0402C4D0 RID: 181456
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <2>__BeginLoadMap;

		// Token: 0x0402C4D1 RID: 181457
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<string> <3>__EndLoadMap;

		// Token: 0x0402C4D2 RID: 181458
		[Nullable(new byte[]
		{
			0,
			2
		})]
		public static Action<int, FName, ULevelStreaming> <4>__LoadSubLevel;

		// Token: 0x0402C4D3 RID: 181459
		[Nullable(0)]
		public static Action<int, FName> <5>__UnLoadSubLevel;
	}
}
