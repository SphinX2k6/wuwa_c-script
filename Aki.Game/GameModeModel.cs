using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.DataLayerSwitch;
using UnrealEngine;

// Token: 0x02002A99 RID: 10905
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class GameModeModel : ModelBase
{
	// Token: 0x17002CB6 RID: 11446
	// (get) Token: 0x0601BAEE RID: 113390 RVA: 0x008878B2 File Offset: 0x00885AB2
	// (set) Token: 0x0601BAEF RID: 113391 RVA: 0x008878BA File Offset: 0x00885ABA
	public SceneInformation JoinSceneInfo
	{
		get
		{
			return this.JoinSceneInfoInternal;
		}
		set
		{
			this.JoinSceneInfoInternal = value;
		}
	}

	// Token: 0x17002CB7 RID: 11447
	// (get) Token: 0x0601BAF0 RID: 113392 RVA: 0x008878C3 File Offset: 0x00885AC3
	// (set) Token: 0x0601BAF1 RID: 113393 RVA: 0x008878CB File Offset: 0x00885ACB
	public ELoadingPhase LoadingPhase
	{
		get
		{
			return this.LoadingPhaseInternal;
		}
		set
		{
			this.LoadingPhaseInternal = value;
		}
	}

	// Token: 0x17002CB8 RID: 11448
	// (get) Token: 0x0601BAF2 RID: 113394 RVA: 0x008878D4 File Offset: 0x00885AD4
	public bool Loading
	{
		get
		{
			return this.LoadingPhaseInternal > ELoadingPhase.Finished;
		}
	}

	// Token: 0x17002CB9 RID: 11449
	// (get) Token: 0x0601BAF3 RID: 113395 RVA: 0x008878DF File Offset: 0x00885ADF
	// (set) Token: 0x0601BAF4 RID: 113396 RVA: 0x008878E7 File Offset: 0x00885AE7
	public bool HasGameModeData
	{
		get
		{
			return this.HasGameModeDataInternal;
		}
		set
		{
			this.HasGameModeDataInternal = value;
		}
	}

	// Token: 0x17002CBA RID: 11450
	// (get) Token: 0x0601BAF5 RID: 113397 RVA: 0x008878F0 File Offset: 0x00885AF0
	// (set) Token: 0x0601BAF6 RID: 113398 RVA: 0x008878F8 File Offset: 0x00885AF8
	public SceneMode? Mode
	{
		get
		{
			return this.ModeInternal;
		}
		set
		{
			this.ModeInternal = value;
		}
	}

	// Token: 0x17002CBB RID: 11451
	// (get) Token: 0x0601BAF7 RID: 113399 RVA: 0x00887901 File Offset: 0x00885B01
	// (set) Token: 0x0601BAF8 RID: 113400 RVA: 0x00887909 File Offset: 0x00885B09
	[Nullable(1)]
	public string MapPath
	{
		[NullableContext(1)]
		get
		{
			return this.MapPathInternal;
		}
		[NullableContext(1)]
		set
		{
			this.MapPathInternal = value;
		}
	}

	// Token: 0x17002CBC RID: 11452
	// (get) Token: 0x0601BAF9 RID: 113401 RVA: 0x00887912 File Offset: 0x00885B12
	[Nullable(1)]
	public string LastMapPath
	{
		[NullableContext(1)]
		get
		{
			return this.LastMapPathInternal;
		}
	}

	// Token: 0x0601BAFA RID: 113402 RVA: 0x0088791C File Offset: 0x00885B1C
	[NullableContext(1)]
	public unsafe bool AddLoadMapHandle(string handle)
	{
		if (this.LoadMapHandleMap == null)
		{
			this.LoadMapHandleMap = new Dictionary<string, int>();
		}
		int valueOrDefault = this.LoadMapHandleMap.GetValueOrDefault(handle, 0);
		if (valueOrDefault == 0)
		{
			this.LoadMapHandleMap[handle] = 1;
		}
		else
		{
			this.LoadMapHandleMap[handle] = valueOrDefault + 1;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.LFJW;
		string message = "添加LoadMapHandle";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("添加的Handle", handle);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Size", this.LoadMapHandleMap.Count);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return true;
	}

	// Token: 0x0601BAFB RID: 113403 RVA: 0x008879D0 File Offset: 0x00885BD0
	[NullableContext(1)]
	public unsafe bool RemoveLoadMapHandle(string handle)
	{
		Dictionary<string, int> loadMapHandleMap = this.LoadMapHandleMap;
		if (loadMapHandleMap == null || !loadMapHandleMap.ContainsKey(handle))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "删除LoadMapHandle失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Handle", handle);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "Size";
			Dictionary<string, int> loadMapHandleMap2 = this.LoadMapHandleMap;
			ptr = new ValueTuple<string, object>(item, (loadMapHandleMap2 != null) ? new int?(loadMapHandleMap2.Count) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		int num = this.LoadMapHandleMap[handle];
		num--;
		if (num == 0)
		{
			this.LoadMapHandleMap.Remove(handle);
		}
		else
		{
			this.LoadMapHandleMap[handle] = num;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.World;
		ELogAuthor author2 = ELogAuthor.LFJW;
		string message2 = "删除LoadMapHandle";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("删除的Handle", handle);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Size", this.LoadMapHandleMap.Count);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		return true;
	}

	// Token: 0x17002CBD RID: 11453
	// (get) Token: 0x0601BAFC RID: 113404 RVA: 0x00887AFE File Offset: 0x00885CFE
	public bool MapDone
	{
		get
		{
			return this.LoadMapHandleMap != null && this.LoadMapHandleMap.Count == 0;
		}
	}

	// Token: 0x17002CBE RID: 11454
	// (get) Token: 0x0601BAFD RID: 113405 RVA: 0x00887B18 File Offset: 0x00885D18
	// (set) Token: 0x0601BAFE RID: 113406 RVA: 0x00887B20 File Offset: 0x00885D20
	public bool NavMeshDone
	{
		get
		{
			return this.NavMeshDoneInternal;
		}
		set
		{
			this.NavMeshDoneInternal = value;
		}
	}

	// Token: 0x17002CBF RID: 11455
	// (get) Token: 0x0601BAFF RID: 113407 RVA: 0x00887B29 File Offset: 0x00885D29
	// (set) Token: 0x0601BB00 RID: 113408 RVA: 0x00887B31 File Offset: 0x00885D31
	public bool WorldDone
	{
		get
		{
			return this.WorldDoneInternal;
		}
		set
		{
			this.WorldDoneInternal = value;
		}
	}

	// Token: 0x17002CC0 RID: 11456
	// (get) Token: 0x0601BB01 RID: 113409 RVA: 0x00887B3A File Offset: 0x00885D3A
	// (set) Token: 0x0601BB02 RID: 113410 RVA: 0x00887B42 File Offset: 0x00885D42
	public bool WorldDoneAndLoadingClosed
	{
		get
		{
			return this.WorldDoneAndLoadingClosedInternal;
		}
		set
		{
			this.WorldDoneAndLoadingClosedInternal = value;
		}
	}

	// Token: 0x17002CC1 RID: 11457
	// (get) Token: 0x0601BB03 RID: 113411 RVA: 0x00887B4B File Offset: 0x00885D4B
	[Nullable(1)]
	public APlayerStart[] PlayerStarts
	{
		[NullableContext(1)]
		get
		{
			return this.PlayerStartsInternal.ToArray();
		}
	}

	// Token: 0x17002CC2 RID: 11458
	// (get) Token: 0x0601BB04 RID: 113412 RVA: 0x00887B58 File Offset: 0x00885D58
	// (set) Token: 0x0601BB05 RID: 113413 RVA: 0x00887B65 File Offset: 0x00885D65
	public AkiMapSource MapConfig
	{
		get
		{
			return this.MapConfigInternal.Value;
		}
		set
		{
			this.MapConfigInternal = new AkiMapSource?(value);
		}
	}

	// Token: 0x17002CC3 RID: 11459
	// (get) Token: 0x0601BB06 RID: 113414 RVA: 0x00887B73 File Offset: 0x00885D73
	public InstanceDungeon? InstanceDungeon
	{
		get
		{
			return this.InstanceDungeonInternal;
		}
	}

	// Token: 0x0601BB07 RID: 113415 RVA: 0x00887B7B File Offset: 0x00885D7B
	public void SetInstanceDungeon(int value)
	{
		this.InstanceDungeonInternal = ConfigInstanceDungeonById.GetConfig(value, true);
	}

	// Token: 0x17002CC4 RID: 11460
	// (get) Token: 0x0601BB08 RID: 113416 RVA: 0x00887B8A File Offset: 0x00885D8A
	// (set) Token: 0x0601BB09 RID: 113417 RVA: 0x00887B92 File Offset: 0x00885D92
	public int MapId
	{
		get
		{
			return this.MapIdInternal;
		}
		set
		{
			this.MapIdInternal = value;
		}
	}

	// Token: 0x17002CC5 RID: 11461
	// (get) Token: 0x0601BB0A RID: 113418 RVA: 0x00887B9B File Offset: 0x00885D9B
	// (set) Token: 0x0601BB0B RID: 113419 RVA: 0x00887BB7 File Offset: 0x00885DB7
	public InstanceType InstanceType
	{
		get
		{
			if (this.InstanceTypeInternal == null)
			{
				return InstanceType.NoneInstance;
			}
			return this.InstanceTypeInternal.Value;
		}
		set
		{
			this.InstanceTypeInternal = new InstanceType?(value);
		}
	}

	// Token: 0x17002CC6 RID: 11462
	// (get) Token: 0x0601BB0C RID: 113420 RVA: 0x00887BC5 File Offset: 0x00885DC5
	public InstanceType LastInstanceType
	{
		get
		{
			return this.LastInstanceTypeInternal;
		}
	}

	// Token: 0x17002CC7 RID: 11463
	// (get) Token: 0x0601BB0D RID: 113421 RVA: 0x00887BCD File Offset: 0x00885DCD
	// (set) Token: 0x0601BB0E RID: 113422 RVA: 0x00887BD5 File Offset: 0x00885DD5
	public bool IsMulti
	{
		get
		{
			return this.IsMultiInternal;
		}
		set
		{
			this.IsMultiInternal = value;
		}
	}

	// Token: 0x17002CC8 RID: 11464
	// (get) Token: 0x0601BB0F RID: 113423 RVA: 0x00887BDE File Offset: 0x00885DDE
	// (set) Token: 0x0601BB10 RID: 113424 RVA: 0x00887BE6 File Offset: 0x00885DE6
	public bool ChangeModeState
	{
		get
		{
			return this.ChangeModeStateInternal;
		}
		set
		{
			this.ChangeModeStateInternal = value;
		}
	}

	// Token: 0x17002CC9 RID: 11465
	// (get) Token: 0x0601BB11 RID: 113425 RVA: 0x00887BEF File Offset: 0x00885DEF
	// (set) Token: 0x0601BB12 RID: 113426 RVA: 0x00887BF7 File Offset: 0x00885DF7
	public bool PlayTravelMp4
	{
		get
		{
			return this.PlayTravelMp4Internal;
		}
		set
		{
			this.PlayTravelMp4Internal = value;
		}
	}

	// Token: 0x17002CCA RID: 11466
	// (get) Token: 0x0601BB13 RID: 113427 RVA: 0x00887C00 File Offset: 0x00885E00
	// (set) Token: 0x0601BB14 RID: 113428 RVA: 0x00887C08 File Offset: 0x00885E08
	public string TravelMp4Path
	{
		get
		{
			return this.TravelMp4PathInternal;
		}
		set
		{
			this.TravelMp4PathInternal = value;
		}
	}

	// Token: 0x17002CCB RID: 11467
	// (get) Token: 0x0601BB15 RID: 113429 RVA: 0x00887C11 File Offset: 0x00885E11
	// (set) Token: 0x0601BB16 RID: 113430 RVA: 0x00887C19 File Offset: 0x00885E19
	public bool UseShowCenterText
	{
		get
		{
			return this.UseShowCenterTextInternal;
		}
		set
		{
			this.UseShowCenterTextInternal = value;
		}
	}

	// Token: 0x17002CCC RID: 11468
	// (get) Token: 0x0601BB17 RID: 113431 RVA: 0x00887C22 File Offset: 0x00885E22
	// (set) Token: 0x0601BB18 RID: 113432 RVA: 0x00887C2A File Offset: 0x00885E2A
	public bool UseAsBlackScreen
	{
		get
		{
			return this.UseAsBlackScreenInternal;
		}
		set
		{
			this.UseAsBlackScreenInternal = value;
		}
	}

	// Token: 0x17002CCD RID: 11469
	// (get) Token: 0x0601BB19 RID: 113433 RVA: 0x00887C33 File Offset: 0x00885E33
	// (set) Token: 0x0601BB1A RID: 113434 RVA: 0x00887C3B File Offset: 0x00885E3B
	public EFadeInScreenShowType BlackScreenColor
	{
		get
		{
			return this.BlackScreenColorInternal;
		}
		set
		{
			this.BlackScreenColorInternal = value;
		}
	}

	// Token: 0x17002CCE RID: 11470
	// (get) Token: 0x0601BB1B RID: 113435 RVA: 0x00887C44 File Offset: 0x00885E44
	// (set) Token: 0x0601BB1C RID: 113436 RVA: 0x00887C4C File Offset: 0x00885E4C
	public bool TravelMp4Playing
	{
		get
		{
			return this.TravelMp4PlayingInternal;
		}
		set
		{
			this.TravelMp4PlayingInternal = value;
		}
	}

	// Token: 0x17002CCF RID: 11471
	// (get) Token: 0x0601BB1D RID: 113437 RVA: 0x00887C55 File Offset: 0x00885E55
	[Nullable(1)]
	public DataLayerSwitchContext SwitchDataLayerContext
	{
		[NullableContext(1)]
		get
		{
			return this.switchDataLayerContext;
		}
	}

	// Token: 0x17002CD0 RID: 11472
	// (get) Token: 0x0601BB1E RID: 113438 RVA: 0x00887C5D File Offset: 0x00885E5D
	public bool DataLayerSwitching
	{
		get
		{
			return this.switchDataLayerContext.DataLayerSwitching;
		}
	}

	// Token: 0x17002CD1 RID: 11473
	// (get) Token: 0x0601BB1F RID: 113439 RVA: 0x00887C6A File Offset: 0x00885E6A
	// (set) Token: 0x0601BB20 RID: 113440 RVA: 0x00887C72 File Offset: 0x00885E72
	public EMovieBackgroundType? Mp4FadeInScreenColor
	{
		get
		{
			return this.Mp4FadeInScreenColorInternal;
		}
		set
		{
			this.Mp4FadeInScreenColorInternal = value;
		}
	}

	// Token: 0x17002CD2 RID: 11474
	// (get) Token: 0x0601BB21 RID: 113441 RVA: 0x00887C7B File Offset: 0x00885E7B
	// (set) Token: 0x0601BB22 RID: 113442 RVA: 0x00887C83 File Offset: 0x00885E83
	public EMovieBackgroundType? Mp4FadeOutScreenColor
	{
		get
		{
			return this.Mp4FadeOutScreenColorInternal;
		}
		set
		{
			this.Mp4FadeOutScreenColorInternal = value;
		}
	}

	// Token: 0x17002CD3 RID: 11475
	// (get) Token: 0x0601BB23 RID: 113443 RVA: 0x00887C8C File Offset: 0x00885E8C
	// (set) Token: 0x0601BB24 RID: 113444 RVA: 0x00887C94 File Offset: 0x00885E94
	public bool NeedOpenBlackScreenWhenTeleportDungeon
	{
		get
		{
			return this.NeedOpenBlackScreenWhenTeleportDungeonInternal;
		}
		set
		{
			this.NeedOpenBlackScreenWhenTeleportDungeonInternal = value;
		}
	}

	// Token: 0x17002CD4 RID: 11476
	// (get) Token: 0x0601BB25 RID: 113445 RVA: 0x00887C9D File Offset: 0x00885E9D
	public CustomPromise<bool> ChangeSceneModePromise
	{
		get
		{
			return this.ChangeSceneModePromiseInternal;
		}
	}

	// Token: 0x17002CD5 RID: 11477
	// (get) Token: 0x0601BB26 RID: 113446 RVA: 0x00887CA5 File Offset: 0x00885EA5
	public CustomPromise<bool> ChangeSceneModeVoxelPromise
	{
		get
		{
			return this.ChangeSceneModeVoxelPromiseInternal;
		}
	}

	// Token: 0x17002CD6 RID: 11478
	// (get) Token: 0x0601BB27 RID: 113447 RVA: 0x00887CAD File Offset: 0x00885EAD
	public CustomPromise<bool> ChangeSceneModeStreamingPromise
	{
		get
		{
			return this.ChangeSceneModeStreamingPromiseInternal;
		}
	}

	// Token: 0x0601BB28 RID: 113448 RVA: 0x00887CB8 File Offset: 0x00885EB8
	public GameModeModel()
	{
		this.OpenLoadingProfiler = this.LoadWorldProfiler.CreateChild("打开Loading", false);
		this.OpenLevelProfiler = this.LoadWorldProfiler.CreateChild("加载主Level", false);
		this.PreloadProfiler = this.LoadWorldProfiler.CreateChild("Preload阶段", false);
		this.PreloadApplyMaterialParameterCollectionProfiler = this.PreloadProfiler.CreateChild("应用MPC", false);
		this.PreloadCommonAndEntityProfiler = this.PreloadProfiler.CreateChild("预加载公共资源、实体资源", false);
		this.PreloadControllerProfiler = this.PreloadProfiler.CreateChild("预加载Controller资源", false);
		this.PreloadCommonProfiler = this.PreloadCommonAndEntityProfiler.CreateChild("预加载公共资源", false);
		this.PreloadEntitiesProfiler = this.PreloadCommonAndEntityProfiler.CreateChild("预加载实体", false);
		this.LoadDataLayerAndSubLevelProfiler = this.LoadWorldProfiler.CreateChild("加载DataLayer、加载子关卡", false);
		this.LoadSubLevelProfiler = this.LoadDataLayerAndSubLevelProfiler.CreateChild("加载子Level", false);
		this.LoadDataLayerProfiler = this.LoadDataLayerAndSubLevelProfiler.CreateChild("加载DataLayer", false);
		this.CheckVoxelStreamingSourceProfiler = this.LoadWorldProfiler.CreateChild("等待体素流送", false);
		this.CheckStreamingSourceProfiler = this.LoadWorldProfiler.CreateChild("等待场景流送", false);
		this.CreateEntitiesProfiler = this.LoadWorldProfiler.CreateChild("创建实体", false);
		this.WaitRenderAssetsProfiler = this.LoadWorldProfiler.CreateChild("等待渲染资源", false);
		this.WorldDoneProfiler = this.LoadWorldProfiler.CreateChild("WorldDone", false);
		this.OpenBattleViewProfiler = this.WorldDoneProfiler.CreateChild("打开主界面(WorldDone阶段)", false);
		this.CloseLoadingProfiler = this.LoadWorldProfiler.CreateChild("关闭Loading界面", false);
		this.CloseLoadingPhaseOpenBattleViewProfiler = this.CloseLoadingProfiler.CreateChild("打开主界面(关闭Loading阶段)", false);
	}

	// Token: 0x0601BB29 RID: 113449 RVA: 0x00887F40 File Offset: 0x00886140
	[NullableContext(1)]
	public void AddPlayerStart(APlayerStart value)
	{
		this.PlayerStartsInternal.Add(value);
	}

	// Token: 0x0601BB2A RID: 113450 RVA: 0x00887F4E File Offset: 0x0088614E
	public void ClearPlayerStart()
	{
		this.PlayerStartsInternal.Clear();
	}

	// Token: 0x17002CD7 RID: 11479
	// (get) Token: 0x0601BB2B RID: 113451 RVA: 0x00887F5B File Offset: 0x0088615B
	public AActor VoxelStreamingSource
	{
		get
		{
			return this.VoxelStreamingSourceInternal;
		}
	}

	// Token: 0x17002CD8 RID: 11480
	// (get) Token: 0x0601BB2C RID: 113452 RVA: 0x00887F63 File Offset: 0x00886163
	public AActor StreamingSource
	{
		get
		{
			return this.StreamingSourceInternal;
		}
	}

	// Token: 0x17002CD9 RID: 11481
	// (get) Token: 0x0601BB2D RID: 113453 RVA: 0x00887F6B File Offset: 0x0088616B
	// (set) Token: 0x0601BB2E RID: 113454 RVA: 0x00887F73 File Offset: 0x00886173
	public bool UseWorldPartition
	{
		get
		{
			return this.UseWorldPartitionInternal;
		}
		set
		{
			this.UseWorldPartitionInternal = value;
		}
	}

	// Token: 0x17002CDA RID: 11482
	// (get) Token: 0x0601BB2F RID: 113455 RVA: 0x00887F7C File Offset: 0x0088617C
	// (set) Token: 0x0601BB30 RID: 113456 RVA: 0x00887F84 File Offset: 0x00886184
	public bool IsTeleport
	{
		get
		{
			return this.IsTeleportInternal;
		}
		set
		{
			this.IsTeleportInternal = value;
		}
	}

	// Token: 0x17002CDB RID: 11483
	// (get) Token: 0x0601BB31 RID: 113457 RVA: 0x00887F8D File Offset: 0x0088618D
	public FVectorDouble? BornLocation
	{
		get
		{
			return this.BornLocationInternal;
		}
	}

	// Token: 0x17002CDC RID: 11484
	// (get) Token: 0x0601BB32 RID: 113458 RVA: 0x00887F95 File Offset: 0x00886195
	public FRotator? BornRotator
	{
		get
		{
			return this.BornRotatorInternal;
		}
	}

	// Token: 0x17002CDD RID: 11485
	// (get) Token: 0x0601BB33 RID: 113459 RVA: 0x00887F9D File Offset: 0x0088619D
	public global::Vector RoleLocation
	{
		get
		{
			return this.RoleLocationInternal;
		}
	}

	// Token: 0x17002CDE RID: 11486
	// (get) Token: 0x0601BB34 RID: 113460 RVA: 0x00887FA5 File Offset: 0x008861A5
	// (set) Token: 0x0601BB35 RID: 113461 RVA: 0x00887FAD File Offset: 0x008861AD
	public TransitionWithSpineLoadingPb SpecialTransitionPb
	{
		get
		{
			return this.SpecialTransitionPbInternal;
		}
		set
		{
			this.SpecialTransitionPbInternal = value;
		}
	}

	// Token: 0x17002CDF RID: 11487
	// (get) Token: 0x0601BB36 RID: 113462 RVA: 0x00887FB6 File Offset: 0x008861B6
	// (set) Token: 0x0601BB37 RID: 113463 RVA: 0x00887FBE File Offset: 0x008861BE
	public TransitionPlayFlowPb PlayFlowPb
	{
		get
		{
			return this.PlayFlowPbInternal;
		}
		set
		{
			this.PlayFlowPbInternal = value;
		}
	}

	// Token: 0x0601BB38 RID: 113464 RVA: 0x00887FC8 File Offset: 0x008861C8
	[NullableContext(1)]
	public AActor CreateShapedStreamingSource(int sectorAngle = 100, float loadingRangeScale = 1f)
	{
		FStreamingSourceShape[] shapes = new FStreamingSourceShape[]
		{
			new FStreamingSourceShape
			{
				bUseGridLoadingRange = true,
				LoadingRangeScale = loadingRangeScale,
				bIsSector = true,
				SectorAngle = (float)sectorAngle
			}
		};
		return GameModeModel.CreateStreamingSource(MathUtils.Instance.DefaultTransformDouble, EStreamingSourcePriority.Normal, EStreamingSourceTargetBehavior.Include, null, shapes);
	}

	// Token: 0x0601BB39 RID: 113465 RVA: 0x00888018 File Offset: 0x00886218
	[NullableContext(1)]
	public static AActor CreateIndependentStreamingSource(FName[] targetGrids, float loadingRange, EStreamingSourcePriority priority)
	{
		FStreamingSourceShape[] shapes = new FStreamingSourceShape[]
		{
			new FStreamingSourceShape
			{
				LoadingRangeScale = 1f,
				Radius = loadingRange,
				SectorAngle = 360f
			}
		};
		AActor aactor = GameModeModel.CreateStreamingSource(FTransformDouble.Identity, priority, EStreamingSourceTargetBehavior.Include, targetGrids, shapes);
		if (aactor.IsValid())
		{
			UWorldPartitionStreamingSourceComponent uworldPartitionStreamingSourceComponent = aactor.GetComponentByClass(UWorldPartitionStreamingSourceComponent.StaticClass()) as UWorldPartitionStreamingSourceComponent;
			if (uworldPartitionStreamingSourceComponent != null && uworldPartitionStreamingSourceComponent.IsValid())
			{
				uworldPartitionStreamingSourceComponent.EnableStreamingSource();
			}
		}
		return aactor;
	}

	// Token: 0x0601BB3A RID: 113466 RVA: 0x00888090 File Offset: 0x00886290
	[NullableContext(1)]
	private static AActor CreateStreamingSource(FTransformDouble transform, EStreamingSourcePriority priority, EStreamingSourceTargetBehavior targetBehavior, [Nullable(2)] FName[] targetGrids = null, [Nullable(new byte[]
	{
		2,
		1
	})] FStreamingSourceShape[] shapes = null)
	{
		AActor aactor = ActorSystem.Instance.Get(AActor.StaticClass(), transform, null, true);
		aactor.AddComponentByClass(USceneComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName));
		aactor.D_K2_SetActorLocation(transform.GetLocation(), false, ref WorldGlobal.SweepHitResult, false);
		UWorldPartitionStreamingSourceComponent uworldPartitionStreamingSourceComponent = aactor.AddComponentByClass(UWorldPartitionStreamingSourceComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UWorldPartitionStreamingSourceComponent;
		uworldPartitionStreamingSourceComponent.Priority = priority;
		uworldPartitionStreamingSourceComponent.TargetBehavior = targetBehavior;
		if (targetGrids != null)
		{
			foreach (FName value in targetGrids)
			{
				uworldPartitionStreamingSourceComponent.TargetGrids.Add(value);
			}
		}
		if (shapes != null)
		{
			foreach (FStreamingSourceShape value2 in shapes)
			{
				uworldPartitionStreamingSourceComponent.Shapes.Add(value2);
			}
		}
		uworldPartitionStreamingSourceComponent.bStreamingSourceShouldBlockOnSlowStreaming = true;
		uworldPartitionStreamingSourceComponent.DisableStreamingSource();
		return aactor;
	}

	// Token: 0x0601BB3B RID: 113467 RVA: 0x00888190 File Offset: 0x00886390
	public unsafe void ScaleStreamingSource(EStreamingSourceScaleType type, float scale)
	{
		float num;
		if ((UKuroStaticLibrary.IsLowMemoryDevice() || type != EStreamingSourceScaleType.Plot) && (!this.StreamingSourceScalingTypes.TryGetValue(type, out num) || num != scale))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.GameMode;
			ELogAuthor author = ELogAuthor.XY;
			string message = "缩放流送源";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Scale", scale);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.StreamingSourceScalingTypes[type] = scale;
			this.UpdateStreamingSourceScale(false);
		}
	}

	// Token: 0x0601BB3C RID: 113468 RVA: 0x00888230 File Offset: 0x00886430
	public void CleanScaleStreamingSource(EStreamingSourceScaleType type)
	{
		if ((UKuroStaticLibrary.IsLowMemoryDevice() || type != EStreamingSourceScaleType.Plot) && this.StreamingSourceScalingTypes.Remove(type))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.GameMode;
			ELogAuthor author = ELogAuthor.XY;
			string message = "清理缩放流送源";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", type);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.UpdateStreamingSourceScale(true);
		}
	}

	// Token: 0x0601BB3D RID: 113469 RVA: 0x0088828C File Offset: 0x0088648C
	private float GetStreamingSourceScale()
	{
		float result = 1f;
		EStreamingSourceScaleType? estreamingSourceScaleType = null;
		foreach (KeyValuePair<EStreamingSourceScaleType, float> keyValuePair in this.StreamingSourceScalingTypes)
		{
			if (estreamingSourceScaleType == null || keyValuePair.Key <= estreamingSourceScaleType.Value)
			{
				result = keyValuePair.Value;
				estreamingSourceScaleType = new EStreamingSourceScaleType?(keyValuePair.Key);
			}
		}
		return result;
	}

	// Token: 0x0601BB3E RID: 113470 RVA: 0x00888318 File Offset: 0x00886518
	private void UpdateStreamingSourceScale(bool forceUpdate = false)
	{
		if (!forceUpdate && this.StreamingSourceScalingTypes.Count == 0)
		{
			return;
		}
		AActor streamingSourceInternal = this.StreamingSourceInternal;
		if (streamingSourceInternal != null && streamingSourceInternal.IsValid())
		{
			UWorldPartitionStreamingSourceComponent uworldPartitionStreamingSourceComponent = this.StreamingSourceInternal.GetComponentByClass(UWorldPartitionStreamingSourceComponent.StaticClass()) as UWorldPartitionStreamingSourceComponent;
			if (uworldPartitionStreamingSourceComponent != null && uworldPartitionStreamingSourceComponent.IsValid())
			{
				if (this.StreamingSourceScalingTypes.Count > 0)
				{
					float streamingSourceScale = this.GetStreamingSourceScale();
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.GameMode;
					ELogAuthor author = ELogAuthor.XY;
					string message = "更新流送源缩放";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Scale", streamingSourceScale);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					int num = uworldPartitionStreamingSourceComponent.Shapes.Num();
					FStreamingSourceShape fstreamingSourceShape = null;
					FStreamingSourceShape fstreamingSourceShape2 = null;
					if (num > 0)
					{
						fstreamingSourceShape = uworldPartitionStreamingSourceComponent.Shapes.Get(0);
					}
					if (num > 1)
					{
						fstreamingSourceShape2 = uworldPartitionStreamingSourceComponent.Shapes.Get(1);
					}
					if (fstreamingSourceShape == null)
					{
						fstreamingSourceShape = new FStreamingSourceShape
						{
							bUseGridLoadingRange = true,
							LoadingRangeScale = streamingSourceScale,
							SectorAngle = 360f
						};
						uworldPartitionStreamingSourceComponent.Shapes.Add(fstreamingSourceShape);
					}
					else
					{
						fstreamingSourceShape.LoadingRangeScale = streamingSourceScale;
					}
					if (fstreamingSourceShape2 == null)
					{
						fstreamingSourceShape2 = new FStreamingSourceShape
						{
							LoadingRangeScale = 1f,
							Radius = 7000f,
							SectorAngle = 360f
						};
						uworldPartitionStreamingSourceComponent.Shapes.Add(fstreamingSourceShape2);
						return;
					}
				}
				else
				{
					global::Log.Instance.Info(ELogModule.GameMode, ELogAuthor.XY, "重置流送源缩放", default(ReadOnlySpan<ValueTuple<string, object>>));
					uworldPartitionStreamingSourceComponent.Shapes.Empty(true);
				}
			}
		}
	}

	// Token: 0x0601BB3F RID: 113471 RVA: 0x00888498 File Offset: 0x00886698
	public unsafe void DisableHLODStreaming(EDisableHLODStreamingType type, int level = 0)
	{
		int num;
		if (!this.DisableHLODStreamingTypes.TryGetValue(type, out num) || num != level)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.GameMode;
			ELogAuthor author = ELogAuthor.XY;
			string message = "禁用流送HLOD";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Level", level);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.DisableHLODStreamingTypes[type] = level;
			this.UpdateHLODStreamingToggle(false);
		}
	}

	// Token: 0x0601BB40 RID: 113472 RVA: 0x0088852C File Offset: 0x0088672C
	public void EnableHLODStreaming(EDisableHLODStreamingType type)
	{
		if (this.DisableHLODStreamingTypes.Remove(type))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.GameMode;
			ELogAuthor author = ELogAuthor.XY;
			string message = "开启流送HLOD";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", type);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.UpdateHLODStreamingToggle(true);
		}
	}

	// Token: 0x0601BB41 RID: 113473 RVA: 0x0088857C File Offset: 0x0088677C
	private int GetHLODStreamingToggleLevel()
	{
		int num = 2;
		foreach (KeyValuePair<EDisableHLODStreamingType, int> keyValuePair in this.DisableHLODStreamingTypes)
		{
			if (keyValuePair.Value < num)
			{
				num = keyValuePair.Value;
			}
		}
		return num;
	}

	// Token: 0x0601BB42 RID: 113474 RVA: 0x008885E0 File Offset: 0x008867E0
	private void UpdateHLODStreamingToggle(bool forceUpdate = false)
	{
		if (!forceUpdate && this.DisableHLODStreamingTypes.Count == 0)
		{
			return;
		}
		AActor streamingSourceInternal = this.StreamingSourceInternal;
		if (streamingSourceInternal != null && streamingSourceInternal.IsValid())
		{
			UWorldPartitionStreamingSourceComponent uworldPartitionStreamingSourceComponent = this.StreamingSourceInternal.GetComponentByClass(UWorldPartitionStreamingSourceComponent.StaticClass()) as UWorldPartitionStreamingSourceComponent;
			if (uworldPartitionStreamingSourceComponent != null && uworldPartitionStreamingSourceComponent.IsValid())
			{
				HashSet<FName> hashSet = new HashSet<FName>();
				for (int i = 0; i < uworldPartitionStreamingSourceComponent.TargetGrids.Num(); i++)
				{
					hashSet.Add(FNameUtil.GetDynamicFName(uworldPartitionStreamingSourceComponent.TargetGrids.Get(i).ToString()).Value);
				}
				int hlodstreamingToggleLevel = this.GetHLODStreamingToggleLevel();
				if (hlodstreamingToggleLevel > 1)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.GameMode;
					ELogAuthor author = ELogAuthor.XY;
					string message = "重置HLOD流送";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Level", hlodstreamingToggleLevel);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					foreach (FName item in WorldDefine.firstHLODGridNames)
					{
						hashSet.Remove(item);
					}
					foreach (FName item2 in WorldDefine.secondHLODGridNames)
					{
						hashSet.Remove(item2);
					}
				}
				else
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.GameMode;
					ELogAuthor author2 = ELogAuthor.XY;
					string message2 = "更新HLOD流送";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Level", hlodstreamingToggleLevel);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					foreach (FName item3 in WorldDefine.secondHLODGridNames)
					{
						hashSet.Add(item3);
					}
					if (hlodstreamingToggleLevel == 1)
					{
						foreach (FName item4 in WorldDefine.firstHLODGridNames)
						{
							hashSet.Remove(item4);
						}
					}
					else
					{
						foreach (FName item5 in WorldDefine.firstHLODGridNames)
						{
							hashSet.Add(item5);
						}
					}
				}
				uworldPartitionStreamingSourceComponent.TargetGrids.Empty(true);
				foreach (FName value in hashSet)
				{
					uworldPartitionStreamingSourceComponent.TargetGrids.Add(value);
				}
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.GameMode;
				ELogAuthor author3 = ELogAuthor.XY;
				string message3 = "更新HLOD流送";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Enabled", this.DisableHLODStreamingTypes.Count == 0);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
		}
	}

	// Token: 0x0601BB43 RID: 113475 RVA: 0x00888884 File Offset: 0x00886A84
	public unsafe void InitStreamingSources()
	{
		FRotator value = this.BornRotator.Value;
		FVectorDouble value2 = this.BornLocation.Value;
		FVectorDouble fvectorDouble = new FVectorDouble(1.0, 1.0, 1.0);
		FVector fvector = fvectorDouble;
		FTransformDouble transform = new FTransformDouble(ref value, ref value2, ref fvector);
		FName[] array = new FName[]
		{
			WorldDefine.voxelGridName
		};
		AActor voxelStreamingSourceInternal = this.VoxelStreamingSourceInternal;
		if (voxelStreamingSourceInternal != null && voxelStreamingSourceInternal.IsValid())
		{
			AActor voxelStreamingSourceInternal2 = this.VoxelStreamingSourceInternal;
			if (voxelStreamingSourceInternal2 != null)
			{
				voxelStreamingSourceInternal2.D_K2_SetActorLocation(transform.GetLocation(), false, ref WorldGlobal.SweepHitResult, false);
			}
		}
		else
		{
			this.VoxelStreamingSourceInternal = GameModeModel.CreateStreamingSource(transform, EStreamingSourcePriority.High, EStreamingSourceTargetBehavior.Include, array, null);
		}
		if (UKuroStaticLibrary.IsLowMemoryDevice())
		{
			FName[] array2 = new FName[array.Length + WorldDefine.lowMemoryDeviceExcludeGridNames.Length];
			array.CopyTo(array2, 0);
			WorldDefine.lowMemoryDeviceExcludeGridNames.CopyTo(array2, array.Length);
			array = array2;
		}
		AActor streamingSourceInternal = this.StreamingSourceInternal;
		if (streamingSourceInternal != null && streamingSourceInternal.IsValid())
		{
			AActor streamingSourceInternal2 = this.StreamingSourceInternal;
			if (streamingSourceInternal2 != null)
			{
				streamingSourceInternal2.D_K2_SetActorLocation(transform.GetLocation(), false, ref WorldGlobal.SweepHitResult, false);
			}
		}
		else
		{
			this.StreamingSourceInternal = GameModeModel.CreateStreamingSource(transform, EStreamingSourcePriority.Normal, EStreamingSourceTargetBehavior.Exclude, array, null);
			this.StreamingSourceInternal.Tags.Add(this.PlayerStreamingSourceTag);
			this.UpdateStreamingSourceScale(false);
			this.UpdateHLODStreamingToggle(false);
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Level;
		ELogAuthor author = ELogAuthor.YZH;
		string message = "StreamingSource出生信息";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Location", this.BornLocation);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Rotation", this.BornRotator);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetGrids", string.Join<FName>(", ", array));
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0601BB44 RID: 113476 RVA: 0x00888A70 File Offset: 0x00886C70
	public void DisableStreamingSources()
	{
		AActor voxelStreamingSourceInternal = this.VoxelStreamingSourceInternal;
		if (voxelStreamingSourceInternal != null && voxelStreamingSourceInternal.IsValid())
		{
			UWorldPartitionStreamingSourceComponent uworldPartitionStreamingSourceComponent = this.VoxelStreamingSourceInternal.GetComponentByClass(UWorldPartitionStreamingSourceComponent.StaticClass()) as UWorldPartitionStreamingSourceComponent;
			if (uworldPartitionStreamingSourceComponent != null && uworldPartitionStreamingSourceComponent.IsValid())
			{
				uworldPartitionStreamingSourceComponent.DisableStreamingSource();
			}
		}
		AActor streamingSourceInternal = this.StreamingSourceInternal;
		if (streamingSourceInternal != null && streamingSourceInternal.IsValid())
		{
			UWorldPartitionStreamingSourceComponent uworldPartitionStreamingSourceComponent2 = this.StreamingSourceInternal.GetComponentByClass(UWorldPartitionStreamingSourceComponent.StaticClass()) as UWorldPartitionStreamingSourceComponent;
			if (uworldPartitionStreamingSourceComponent2 != null && uworldPartitionStreamingSourceComponent2.IsValid())
			{
				uworldPartitionStreamingSourceComponent2.DisableStreamingSource();
			}
		}
	}

	// Token: 0x0601BB45 RID: 113477 RVA: 0x00888B00 File Offset: 0x00886D00
	public bool AttachStreamingSourcesToActor(AActor actor)
	{
		if (!this.IndependentStreaming && actor != null)
		{
			AActor streamingSourceInternal = this.StreamingSourceInternal;
			if (streamingSourceInternal != null && streamingSourceInternal.IsValid())
			{
				AActor voxelStreamingSourceInternal = this.VoxelStreamingSourceInternal;
				if (voxelStreamingSourceInternal != null && voxelStreamingSourceInternal.IsValid())
				{
					this.StreamingSourceInternal.K2_AttachToActor(actor, FName.NAME_None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
					this.VoxelStreamingSourceInternal.K2_AttachToActor(actor, FName.NAME_None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0601BB46 RID: 113478 RVA: 0x00888B78 File Offset: 0x00886D78
	public void StartIndependentStreaming(FVectorDouble? location = null)
	{
		AActor streamingSourceInternal = this.StreamingSourceInternal;
		if (streamingSourceInternal != null && streamingSourceInternal.IsValid())
		{
			AActor voxelStreamingSourceInternal = this.VoxelStreamingSourceInternal;
			if (voxelStreamingSourceInternal != null && voxelStreamingSourceInternal.IsValid())
			{
				this.IndependentStreaming = true;
				AActor streamingSourceInternal2 = this.StreamingSourceInternal;
				if (streamingSourceInternal2 != null)
				{
					streamingSourceInternal2.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				}
				AActor voxelStreamingSourceInternal2 = this.VoxelStreamingSourceInternal;
				if (voxelStreamingSourceInternal2 != null)
				{
					voxelStreamingSourceInternal2.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				}
				if (location != null)
				{
					AActor streamingSourceInternal3 = this.StreamingSourceInternal;
					if (streamingSourceInternal3 != null)
					{
						streamingSourceInternal3.D_K2_SetActorLocation(location.Value, false, ref WorldGlobal.SweepHitResult, false);
					}
					AActor voxelStreamingSourceInternal3 = this.VoxelStreamingSourceInternal;
					if (voxelStreamingSourceInternal3 == null)
					{
						return;
					}
					voxelStreamingSourceInternal3.D_K2_SetActorLocation(location.Value, false, ref WorldGlobal.SweepHitResult, false);
				}
				return;
			}
		}
	}

	// Token: 0x0601BB47 RID: 113479 RVA: 0x00888C2C File Offset: 0x00886E2C
	public void DetachStreamingSourceFromActor()
	{
		AActor streamingSourceInternal = this.StreamingSourceInternal;
		if (streamingSourceInternal != null && streamingSourceInternal.IsValid())
		{
			AActor voxelStreamingSourceInternal = this.VoxelStreamingSourceInternal;
			if (voxelStreamingSourceInternal != null && voxelStreamingSourceInternal.IsValid())
			{
				this.StreamingSourceInternal.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				this.VoxelStreamingSourceInternal.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				return;
			}
		}
	}

	// Token: 0x0601BB48 RID: 113480 RVA: 0x00888C84 File Offset: 0x00886E84
	public void StopIndependentStreaming(AActor actor = null)
	{
		this.IndependentStreaming = false;
		this.AttachStreamingSourcesToActor(actor);
	}

	// Token: 0x0601BB49 RID: 113481 RVA: 0x00888C98 File Offset: 0x00886E98
	public void SetBornInfo(IVector bornLocation, IRotator bornRotator)
	{
		this.BornLocationInternal = ((bornLocation != null) ? new FVectorDouble?(new FVectorDouble(bornLocation.X, bornLocation.Y, bornLocation.Z)) : null);
		this.RoleLocationInternal = ((bornLocation != null) ? global::Vector.Create(bornLocation) : null);
		this.BornRotatorInternal = ((bornRotator != null) ? new FRotator?(new FRotator(bornRotator.Pitch, bornRotator.Yaw, bornRotator.Roll)) : null);
	}

	// Token: 0x0601BB4A RID: 113482 RVA: 0x00888D17 File Offset: 0x00886F17
	public void UpdateBornLocation(FVectorDouble location)
	{
		this.RoleLocationInternal.Set(location.X, location.Y, location.Z);
	}

	// Token: 0x0601BB4B RID: 113483 RVA: 0x00888D38 File Offset: 0x00886F38
	public void FlushTempDataLayers()
	{
		foreach (string item in this.TempDataLayer)
		{
			this.DataLayerSet.Add(item);
		}
	}

	// Token: 0x0601BB4C RID: 113484 RVA: 0x00888D94 File Offset: 0x00886F94
	[NullableContext(1)]
	public bool AddDataLayer(string path)
	{
		if (this.DataLayerSet.Contains(path))
		{
			return false;
		}
		this.DataLayerSet.Add(path);
		return true;
	}

	// Token: 0x0601BB4D RID: 113485 RVA: 0x00888DB4 File Offset: 0x00886FB4
	[NullableContext(1)]
	public bool RemoveDataLayer(string path)
	{
		if (!this.HasDataLayer(path))
		{
			return false;
		}
		this.DataLayerSet.Remove(path);
		return true;
	}

	// Token: 0x0601BB4E RID: 113486 RVA: 0x00888DCF File Offset: 0x00886FCF
	[NullableContext(1)]
	public bool HasDataLayer(string path)
	{
		return this.DataLayerSet.Contains(path);
	}

	// Token: 0x0601BB4F RID: 113487 RVA: 0x00888DDD File Offset: 0x00886FDD
	[NullableContext(1)]
	public HashSet<string> GetAllDataLayers()
	{
		return this.DataLayerSet;
	}

	// Token: 0x17002CE0 RID: 11488
	// (get) Token: 0x0601BB50 RID: 113488 RVA: 0x00888DE5 File Offset: 0x00886FE5
	public GameModePromise BeginLoadMapPromise
	{
		get
		{
			return this.BeginLoadMapPromiseInternal;
		}
	}

	// Token: 0x17002CE1 RID: 11489
	// (get) Token: 0x0601BB51 RID: 113489 RVA: 0x00888DED File Offset: 0x00886FED
	public GameModePromise AfterJoinSceneNotifyPromise
	{
		get
		{
			return this.AfterJoinSceneNotifyPromiseInternal;
		}
	}

	// Token: 0x17002CE2 RID: 11490
	// (get) Token: 0x0601BB52 RID: 113490 RVA: 0x00888DF5 File Offset: 0x00886FF5
	public GameModePromise OpenLevelPromise
	{
		get
		{
			return this.OpenLevelPromiseInternal;
		}
	}

	// Token: 0x17002CE3 RID: 11491
	// (get) Token: 0x0601BB53 RID: 113491 RVA: 0x00888DFD File Offset: 0x00886FFD
	public GameModePromise StreamingCompleted
	{
		get
		{
			return this.StreamingCompletedInternal;
		}
	}

	// Token: 0x17002CE4 RID: 11492
	// (get) Token: 0x0601BB54 RID: 113492 RVA: 0x00888E05 File Offset: 0x00887005
	public GameModePromise VoxelStreamingCompleted
	{
		get
		{
			return this.VoxelStreamingCompletedInternal;
		}
	}

	// Token: 0x17002CE5 RID: 11493
	// (get) Token: 0x0601BB55 RID: 113493 RVA: 0x00888E0D File Offset: 0x0088700D
	// (set) Token: 0x0601BB56 RID: 113494 RVA: 0x00888E15 File Offset: 0x00887015
	public GameModePromise LoadMultiFormationPromise
	{
		get
		{
			return this.LoadMultiFormationPromiseInternal;
		}
		set
		{
			this.LoadMultiFormationPromiseInternal = value;
		}
	}

	// Token: 0x17002CE6 RID: 11494
	// (get) Token: 0x0601BB57 RID: 113495 RVA: 0x00888E1E File Offset: 0x0088701E
	public GameModePromise PreloadPromise
	{
		get
		{
			return this.PreloadPromiseInternal;
		}
	}

	// Token: 0x17002CE7 RID: 11495
	// (get) Token: 0x0601BB58 RID: 113496 RVA: 0x00888E26 File Offset: 0x00887026
	public GameModePromise ApplyMaterialParameterCollectionPromise
	{
		get
		{
			return this.ApplyMaterialParameterCollectionPromiseInternal;
		}
	}

	// Token: 0x17002CE8 RID: 11496
	// (get) Token: 0x0601BB59 RID: 113497 RVA: 0x00888E2E File Offset: 0x0088702E
	public GameModePromise ChangeSceneModeEndNotifyPromise
	{
		get
		{
			return this.ChangeSceneModeEndNotifyPromiseInternal;
		}
	}

	// Token: 0x17002CE9 RID: 11497
	// (get) Token: 0x0601BB5A RID: 113498 RVA: 0x00888E36 File Offset: 0x00887036
	// (set) Token: 0x0601BB5B RID: 113499 RVA: 0x00888E3E File Offset: 0x0088703E
	public TimerHandle CheckStreamingCompletedTimerId
	{
		get
		{
			return this.CheckStreamingCompletedTimerIdInternal;
		}
		set
		{
			this.CheckStreamingCompletedTimerIdInternal = value;
		}
	}

	// Token: 0x17002CEA RID: 11498
	// (get) Token: 0x0601BB5C RID: 113500 RVA: 0x00888E47 File Offset: 0x00887047
	// (set) Token: 0x0601BB5D RID: 113501 RVA: 0x00888E4F File Offset: 0x0088704F
	public TimerHandle CheckRenderAssetsStreamingCompletedTimerId
	{
		get
		{
			return this.CheckRenderAssetsStreamingCompletedTimerIdInternal;
		}
		set
		{
			this.CheckRenderAssetsStreamingCompletedTimerIdInternal = value;
		}
	}

	// Token: 0x17002CEB RID: 11499
	// (get) Token: 0x0601BB5E RID: 113502 RVA: 0x00888E58 File Offset: 0x00887058
	// (set) Token: 0x0601BB5F RID: 113503 RVA: 0x00888E60 File Offset: 0x00887060
	public TimerHandle CheckRenderAssetsTimeoutId
	{
		get
		{
			return this.CheckRenderAssetsTimeoutIdInternal;
		}
		set
		{
			this.CheckRenderAssetsTimeoutIdInternal = value;
		}
	}

	// Token: 0x17002CEC RID: 11500
	// (get) Token: 0x0601BB60 RID: 113504 RVA: 0x00888E69 File Offset: 0x00887069
	public GameModePromise VideoStartPromise
	{
		get
		{
			return this.VideoStartPromiseInternal;
		}
	}

	// Token: 0x17002CED RID: 11501
	// (get) Token: 0x0601BB61 RID: 113505 RVA: 0x00888E71 File Offset: 0x00887071
	public GameModePromise OpenLoadingEnd
	{
		get
		{
			return this.OpenLoadingEndPromiseInternal;
		}
	}

	// Token: 0x17002CEE RID: 11502
	// (get) Token: 0x0601BB62 RID: 113506 RVA: 0x00888E79 File Offset: 0x00887079
	public GameModePromise PlayFlowEndPromise
	{
		get
		{
			return this.PlayFlowEndPromiseInternal;
		}
	}

	// Token: 0x17002CEF RID: 11503
	// (get) Token: 0x0601BB63 RID: 113507 RVA: 0x00888E81 File Offset: 0x00887081
	// (set) Token: 0x0601BB64 RID: 113508 RVA: 0x00888E89 File Offset: 0x00887089
	public bool RenderAssetDone
	{
		get
		{
			return this.RenderAssetDoneInternal;
		}
		set
		{
			this.RenderAssetDoneInternal = value;
		}
	}

	// Token: 0x17002CF0 RID: 11504
	// (get) Token: 0x0601BB65 RID: 113509 RVA: 0x00888E92 File Offset: 0x00887092
	// (set) Token: 0x0601BB66 RID: 113510 RVA: 0x00888E9C File Offset: 0x0088709C
	public unsafe ELoadMapMode LoadMapMode
	{
		get
		{
			return this.LoadMapModeInternal;
		}
		set
		{
			if (value >= ELoadMapMode.Max || value < ELoadMapMode.ClientTravel)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "f.副本.xlsx表AkiMapSource Sheet 填错LoadMapMode值";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("loadMapMode", value);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MapPath", this.MapPath);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.LoadMapModeInternal = ELoadMapMode.ClientTravel;
				return;
			}
			this.LoadMapModeInternal = value;
		}
	}

	// Token: 0x17002CF1 RID: 11505
	// (get) Token: 0x0601BB67 RID: 113511 RVA: 0x00888F1D File Offset: 0x0088711D
	// (set) Token: 0x0601BB68 RID: 113512 RVA: 0x00888F28 File Offset: 0x00887128
	public bool ForceClientTravel
	{
		get
		{
			return this.ForceClientTravelInternal;
		}
		set
		{
			bool forceClientTravelInternal = this.ForceClientTravelInternal;
			this.ForceClientTravelInternal = value;
			EventSystem.Instance.Emit<bool, bool>(EEventName.ForceClientTravelModify, forceClientTravelInternal, value);
		}
	}

	// Token: 0x17002CF2 RID: 11506
	// (get) Token: 0x0601BB69 RID: 113513 RVA: 0x00888F55 File Offset: 0x00887155
	[Nullable(1)]
	public Dictionary<string, HashSet<ULevelStreamingDynamic>> LoadMapControllerDynamicStreamingLevels
	{
		[NullableContext(1)]
		get
		{
			if (this.LoadMapControllerDynamicStreamingLevelsInternal == null)
			{
				this.LoadMapControllerDynamicStreamingLevelsInternal = new Dictionary<string, HashSet<ULevelStreamingDynamic>>();
			}
			return this.LoadMapControllerDynamicStreamingLevelsInternal;
		}
	}

	// Token: 0x0601BB6A RID: 113514 RVA: 0x00888F70 File Offset: 0x00887170
	public void ClearLoadMapControllerData()
	{
		if (this.LoadMapControllerDynamicStreamingLevelsInternal != null)
		{
			this.LoadMapControllerDynamicStreamingLevelsInternal.Clear();
		}
		this.LoadMapControllerEnableWorldPartition = false;
	}

	// Token: 0x0601BB6B RID: 113515 RVA: 0x00888F8C File Offset: 0x0088718C
	public void CreatePromise()
	{
		this.BeginLoadMapPromiseInternal = new GameModePromise();
		this.AfterJoinSceneNotifyPromiseInternal = new GameModePromise();
		this.OpenLevelPromiseInternal = new GameModePromise();
		this.StreamingCompletedInternal = new GameModePromise();
		this.VoxelStreamingCompletedInternal = new GameModePromise();
		this.PreloadPromiseInternal = new GameModePromise();
		this.VideoStartPromiseInternal = new GameModePromise();
		this.OpenLoadingEndPromiseInternal = new GameModePromise();
		this.ApplyMaterialParameterCollectionPromiseInternal = new GameModePromise();
		this.PlayFlowEndPromiseInternal = new GameModePromise();
	}

	// Token: 0x0601BB6C RID: 113516 RVA: 0x00889008 File Offset: 0x00887208
	public void ResetPromise()
	{
		this.BeginLoadMapPromiseInternal = null;
		this.AfterJoinSceneNotifyPromiseInternal = null;
		this.OpenLevelPromiseInternal = null;
		this.StreamingCompletedInternal = null;
		this.VoxelStreamingCompletedInternal = null;
		this.PreloadPromiseInternal = null;
		this.LoadMultiFormationPromiseInternal = null;
		this.VideoStartPromiseInternal = null;
		this.OpenLoadingEndPromiseInternal = null;
		this.ApplyMaterialParameterCollectionPromiseInternal = null;
		this.PlayFlowEndPromiseInternal = null;
	}

	// Token: 0x0601BB6D RID: 113517 RVA: 0x00889062 File Offset: 0x00887262
	public void CreateChangeModePromise()
	{
		this.ChangeSceneModeEndNotifyPromiseInternal = new GameModePromise();
		this.ChangeSceneModePromiseInternal = new CustomPromise<bool>();
		this.ChangeSceneModeVoxelPromiseInternal = new CustomPromise<bool>();
		this.ChangeSceneModeStreamingPromiseInternal = new CustomPromise<bool>();
	}

	// Token: 0x0601BB6E RID: 113518 RVA: 0x00889090 File Offset: 0x00887290
	public void ResetChangeModePromise()
	{
		this.ChangeSceneModeEndNotifyPromiseInternal = null;
		this.ChangeSceneModePromiseInternal = null;
		this.ChangeSceneModeVoxelPromiseInternal = null;
		this.ChangeSceneModeStreamingPromiseInternal = null;
	}

	// Token: 0x0601BB6F RID: 113519 RVA: 0x008890AE File Offset: 0x008872AE
	public void SkipChangeSceneModeWait()
	{
		CustomPromise<bool> changeSceneModePromiseInternal = this.ChangeSceneModePromiseInternal;
		if (changeSceneModePromiseInternal != null)
		{
			changeSceneModePromiseInternal.SetResult(true);
		}
		CustomPromise<bool> changeSceneModeVoxelPromiseInternal = this.ChangeSceneModeVoxelPromiseInternal;
		if (changeSceneModeVoxelPromiseInternal != null)
		{
			changeSceneModeVoxelPromiseInternal.SetResult(true);
		}
		CustomPromise<bool> changeSceneModeStreamingPromiseInternal = this.ChangeSceneModeStreamingPromiseInternal;
		if (changeSceneModeStreamingPromiseInternal == null)
		{
			return;
		}
		changeSceneModeStreamingPromiseInternal.SetResult(true);
	}

	// Token: 0x0601BB70 RID: 113520 RVA: 0x008890E8 File Offset: 0x008872E8
	protected override bool OnLeaveLevel()
	{
		this.TempDataLayer.Clear();
		foreach (string item in this.DataLayerSet)
		{
			this.TempDataLayer.Add(item);
		}
		this.DataLayerSet.Clear();
		this.MaterialParameterCollectionMap.Clear();
		if (this.CheckStreamingCompletedTimerId != null)
		{
			TimerSystem.Instance.Remove(this.CheckStreamingCompletedTimerId);
			this.CheckStreamingCompletedTimerId = null;
		}
		this.LoadMapHandleMap = null;
		this.NavMeshDoneInternal = false;
		this.WorldDoneInternal = false;
		this.WorldDoneAndLoadingClosedInternal = false;
		this.LastMapPathInternal = this.MapPathInternal;
		this.MapPathInternal = "";
		this.MapIdInternal = 0;
		this.IsMultiInternal = false;
		this.LastInstanceTypeInternal = this.InstanceTypeInternal.GetValueOrDefault();
		this.InstanceTypeInternal = new InstanceType?(InstanceType.NoneInstance);
		this.MapConfigInternal = null;
		this.InstanceDungeonInternal = null;
		this.UseWorldPartitionInternal = false;
		this.IsTeleportInternal = false;
		this.RenderAssetDone = false;
		this.ResetPromise();
		this.CheckStreamingCompletedTimerIdInternal = null;
		this.CheckRenderAssetsStreamingCompletedTimerIdInternal = null;
		this.CheckRenderAssetsTimeoutIdInternal = null;
		return true;
	}

	// Token: 0x0601BB71 RID: 113521 RVA: 0x00889228 File Offset: 0x00887428
	protected override bool OnChangeMode()
	{
		this.ResetPromise();
		return true;
	}

	// Token: 0x0601BB72 RID: 113522 RVA: 0x00889231 File Offset: 0x00887431
	public void SetCacheTimeDilationValue(float value)
	{
		this.CacheTimeDilationData = new TimeDilationDataImpl
		{
			TimeDilation = value
		};
	}

	// Token: 0x0601BB73 RID: 113523 RVA: 0x00889245 File Offset: 0x00887445
	public ITimeDilationData GetCacheTimeDilationValue()
	{
		return this.CacheTimeDilationData;
	}

	// Token: 0x0601BB74 RID: 113524 RVA: 0x0088924D File Offset: 0x0088744D
	public void ClearCacheTimeDilationValue()
	{
		this.CacheTimeDilationData = null;
	}

	// Token: 0x17002CF3 RID: 11507
	// (get) Token: 0x0601BB75 RID: 113525 RVA: 0x00889256 File Offset: 0x00887456
	[Nullable(1)]
	public static GameModeModel Instance
	{
		[NullableContext(1)]
		get
		{
			return GameModeModel._Instance;
		}
	}

	// Token: 0x0601BB76 RID: 113526 RVA: 0x0088925D File Offset: 0x0088745D
	[NullableContext(1)]
	public static GameModeModel GetOrCreateInstance()
	{
		if (GameModeModel._Instance == null)
		{
			GameModeModel.CreateInstance();
		}
		return GameModeModel._Instance;
	}

	// Token: 0x0601BB77 RID: 113527 RVA: 0x00889271 File Offset: 0x00887471
	public static bool CreateInstance()
	{
		if (GameModeModel._Instance != null)
		{
			return true;
		}
		GameModeModel._Instance = new GameModeModel();
		return true;
	}

	// Token: 0x0601BB78 RID: 113528 RVA: 0x00889287 File Offset: 0x00887487
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BB79 RID: 113529 RVA: 0x00889289 File Offset: 0x00887489
	public static void ResetStaticDefaultValue()
	{
		GameModeModel._Instance = null;
	}

	// Token: 0x0601BB7A RID: 113530 RVA: 0x00889291 File Offset: 0x00887491
	static GameModeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameModeModel.CreateStaticDefaultValue), new Action(GameModeModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EF10 RID: 61200
	public const ETimeDilationType PAUSE_TYPE = ETimeDilationType.PhantomBattleArena;

	// Token: 0x0400EF11 RID: 61201
	public bool IsSilentLogin;

	// Token: 0x0400EF12 RID: 61202
	private bool HasGameModeDataInternal;

	// Token: 0x0400EF13 RID: 61203
	private SceneMode? ModeInternal;

	// Token: 0x0400EF14 RID: 61204
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, int> LoadMapHandleMap;

	// Token: 0x0400EF15 RID: 61205
	private bool NavMeshDoneInternal;

	// Token: 0x0400EF16 RID: 61206
	private bool WorldDoneInternal;

	// Token: 0x0400EF17 RID: 61207
	private bool WorldDoneAndLoadingClosedInternal;

	// Token: 0x0400EF18 RID: 61208
	private bool ChangeModeStateInternal;

	// Token: 0x0400EF19 RID: 61209
	[Nullable(1)]
	private string MapPathInternal = "";

	// Token: 0x0400EF1A RID: 61210
	[Nullable(1)]
	private string LastMapPathInternal = "";

	// Token: 0x0400EF1B RID: 61211
	[Nullable(1)]
	private readonly List<APlayerStart> PlayerStartsInternal = new List<APlayerStart>();

	// Token: 0x0400EF1C RID: 61212
	private readonly FName PlayerStreamingSourceTag = FNameUtil.GetCheckDynamicFName("Player");

	// Token: 0x0400EF1D RID: 61213
	private AActor VoxelStreamingSourceInternal;

	// Token: 0x0400EF1E RID: 61214
	private AActor StreamingSourceInternal;

	// Token: 0x0400EF1F RID: 61215
	private AkiMapSource? MapConfigInternal;

	// Token: 0x0400EF20 RID: 61216
	private InstanceDungeon? InstanceDungeonInternal;

	// Token: 0x0400EF21 RID: 61217
	private int MapIdInternal;

	// Token: 0x0400EF22 RID: 61218
	private InstanceType? InstanceTypeInternal;

	// Token: 0x0400EF23 RID: 61219
	private InstanceType LastInstanceTypeInternal;

	// Token: 0x0400EF24 RID: 61220
	private bool IsMultiInternal;

	// Token: 0x0400EF25 RID: 61221
	private bool UseWorldPartitionInternal;

	// Token: 0x0400EF26 RID: 61222
	private bool IsTeleportInternal;

	// Token: 0x0400EF27 RID: 61223
	private bool PlayTravelMp4Internal;

	// Token: 0x0400EF28 RID: 61224
	private string TravelMp4PathInternal;

	// Token: 0x0400EF29 RID: 61225
	private bool TravelMp4PlayingInternal;

	// Token: 0x0400EF2A RID: 61226
	private bool UseShowCenterTextInternal;

	// Token: 0x0400EF2B RID: 61227
	private bool UseAsBlackScreenInternal;

	// Token: 0x0400EF2C RID: 61228
	private EFadeInScreenShowType BlackScreenColorInternal = EFadeInScreenShowType.Black;

	// Token: 0x0400EF2D RID: 61229
	public TransitionFlowPb ShowCenterTextFlow;

	// Token: 0x0400EF2E RID: 61230
	[Nullable(1)]
	private readonly DataLayerSwitchContext switchDataLayerContext = new DataLayerSwitchContext();

	// Token: 0x0400EF2F RID: 61231
	private EMovieBackgroundType? Mp4FadeInScreenColorInternal;

	// Token: 0x0400EF30 RID: 61232
	private EMovieBackgroundType? Mp4FadeOutScreenColorInternal;

	// Token: 0x0400EF31 RID: 61233
	private bool NeedOpenBlackScreenWhenTeleportDungeonInternal;

	// Token: 0x0400EF32 RID: 61234
	private CustomPromise<bool> ChangeSceneModePromiseInternal;

	// Token: 0x0400EF33 RID: 61235
	private CustomPromise<bool> ChangeSceneModeVoxelPromiseInternal;

	// Token: 0x0400EF34 RID: 61236
	private CustomPromise<bool> ChangeSceneModeStreamingPromiseInternal;

	// Token: 0x0400EF35 RID: 61237
	public bool ForceDisableGamePaused;

	// Token: 0x0400EF36 RID: 61238
	public bool PreAwakeEntityDuringLoad = true;

	// Token: 0x0400EF37 RID: 61239
	[Nullable(1)]
	public readonly HashSet<string> GamePausedReasons = new HashSet<string>();

	// Token: 0x0400EF38 RID: 61240
	[Nullable(1)]
	public readonly HashSet<string> DataLayerSet = new HashSet<string>();

	// Token: 0x0400EF39 RID: 61241
	[Nullable(1)]
	public readonly List<string> TempDataLayer = new List<string>();

	// Token: 0x0400EF3A RID: 61242
	[Nullable(1)]
	public readonly Dictionary<string, bool> MaterialParameterCollectionMap = new Dictionary<string, bool>();

	// Token: 0x0400EF3B RID: 61243
	[Nullable(1)]
	public readonly Dictionary<ETimeDilationType, float> TimeDilationMap = new Dictionary<ETimeDilationType, float>();

	// Token: 0x0400EF3C RID: 61244
	private SceneInformation JoinSceneInfoInternal;

	// Token: 0x0400EF3D RID: 61245
	private bool IndependentStreaming;

	// Token: 0x0400EF3E RID: 61246
	[Nullable(1)]
	private readonly Dictionary<EStreamingSourceScaleType, float> StreamingSourceScalingTypes = new Dictionary<EStreamingSourceScaleType, float>();

	// Token: 0x0400EF3F RID: 61247
	[Nullable(1)]
	private readonly Dictionary<EDisableHLODStreamingType, int> DisableHLODStreamingTypes = new Dictionary<EDisableHLODStreamingType, int>();

	// Token: 0x0400EF40 RID: 61248
	private TransitionWithSpineLoadingPb SpecialTransitionPbInternal;

	// Token: 0x0400EF41 RID: 61249
	private TransitionPlayFlowPb PlayFlowPbInternal;

	// Token: 0x0400EF42 RID: 61250
	private ELoadingPhase LoadingPhaseInternal;

	// Token: 0x0400EF43 RID: 61251
	public bool IsSameMapTraveling;

	// Token: 0x0400EF44 RID: 61252
	[Nullable(1)]
	public readonly LogProfiler LoadWorldProfiler = new LogProfiler("加载世界", false);

	// Token: 0x0400EF45 RID: 61253
	[Nullable(1)]
	public readonly LogProfiler OpenLoadingProfiler;

	// Token: 0x0400EF46 RID: 61254
	[Nullable(1)]
	public readonly LogProfiler OpenLevelProfiler;

	// Token: 0x0400EF47 RID: 61255
	[Nullable(1)]
	public readonly LogProfiler PreloadProfiler;

	// Token: 0x0400EF48 RID: 61256
	[Nullable(1)]
	public readonly LogProfiler PreloadApplyMaterialParameterCollectionProfiler;

	// Token: 0x0400EF49 RID: 61257
	[Nullable(1)]
	public readonly LogProfiler PreloadCommonAndEntityProfiler;

	// Token: 0x0400EF4A RID: 61258
	[Nullable(1)]
	public readonly LogProfiler PreloadControllerProfiler;

	// Token: 0x0400EF4B RID: 61259
	[Nullable(1)]
	public readonly LogProfiler PreloadCommonProfiler;

	// Token: 0x0400EF4C RID: 61260
	[Nullable(1)]
	public readonly LogProfiler PreloadEntitiesProfiler;

	// Token: 0x0400EF4D RID: 61261
	[Nullable(1)]
	public readonly LogProfiler PreloadDangoAbyssMonsterProfiler = new LogProfiler("子房间预加载团子深渊怪物实体", false);

	// Token: 0x0400EF4E RID: 61262
	[Nullable(1)]
	public readonly LogProfiler LoadDataLayerAndSubLevelProfiler;

	// Token: 0x0400EF4F RID: 61263
	[Nullable(1)]
	public readonly LogProfiler LoadSubLevelProfiler;

	// Token: 0x0400EF50 RID: 61264
	[Nullable(1)]
	public readonly LogProfiler LoadDataLayerProfiler;

	// Token: 0x0400EF51 RID: 61265
	[Nullable(1)]
	public readonly LogProfiler CheckVoxelStreamingSourceProfiler;

	// Token: 0x0400EF52 RID: 61266
	[Nullable(1)]
	public readonly LogProfiler CheckStreamingSourceProfiler;

	// Token: 0x0400EF53 RID: 61267
	[Nullable(1)]
	public readonly LogProfiler CreateEntitiesProfiler;

	// Token: 0x0400EF54 RID: 61268
	[Nullable(1)]
	public readonly LogProfiler WaitRenderAssetsProfiler;

	// Token: 0x0400EF55 RID: 61269
	[Nullable(1)]
	public readonly LogProfiler WorldDoneProfiler;

	// Token: 0x0400EF56 RID: 61270
	[Nullable(1)]
	public readonly LogProfiler OpenBattleViewProfiler;

	// Token: 0x0400EF57 RID: 61271
	[Nullable(1)]
	public readonly LogProfiler CloseLoadingProfiler;

	// Token: 0x0400EF58 RID: 61272
	[Nullable(1)]
	public readonly LogProfiler CloseLoadingPhaseOpenBattleViewProfiler;

	// Token: 0x0400EF59 RID: 61273
	private FVectorDouble? BornLocationInternal;

	// Token: 0x0400EF5A RID: 61274
	private FRotator? BornRotatorInternal;

	// Token: 0x0400EF5B RID: 61275
	private global::Vector RoleLocationInternal;

	// Token: 0x0400EF5C RID: 61276
	private GameModePromise BeginLoadMapPromiseInternal;

	// Token: 0x0400EF5D RID: 61277
	private GameModePromise AfterJoinSceneNotifyPromiseInternal;

	// Token: 0x0400EF5E RID: 61278
	private GameModePromise OpenLevelPromiseInternal;

	// Token: 0x0400EF5F RID: 61279
	private GameModePromise StreamingCompletedInternal;

	// Token: 0x0400EF60 RID: 61280
	private GameModePromise VoxelStreamingCompletedInternal;

	// Token: 0x0400EF61 RID: 61281
	private GameModePromise LoadMultiFormationPromiseInternal;

	// Token: 0x0400EF62 RID: 61282
	private GameModePromise PreloadPromiseInternal;

	// Token: 0x0400EF63 RID: 61283
	private GameModePromise ApplyMaterialParameterCollectionPromiseInternal;

	// Token: 0x0400EF64 RID: 61284
	private GameModePromise ChangeSceneModeEndNotifyPromiseInternal;

	// Token: 0x0400EF65 RID: 61285
	private TimerHandle CheckStreamingCompletedTimerIdInternal;

	// Token: 0x0400EF66 RID: 61286
	private TimerHandle CheckRenderAssetsStreamingCompletedTimerIdInternal;

	// Token: 0x0400EF67 RID: 61287
	private TimerHandle CheckRenderAssetsTimeoutIdInternal;

	// Token: 0x0400EF68 RID: 61288
	private GameModePromise VideoStartPromiseInternal;

	// Token: 0x0400EF69 RID: 61289
	private GameModePromise OpenLoadingEndPromiseInternal;

	// Token: 0x0400EF6A RID: 61290
	private GameModePromise PlayFlowEndPromiseInternal;

	// Token: 0x0400EF6B RID: 61291
	private bool RenderAssetDoneInternal;

	// Token: 0x0400EF6C RID: 61292
	public bool EnableLoadMapMode = true;

	// Token: 0x0400EF6D RID: 61293
	private ELoadMapMode LoadMapModeInternal;

	// Token: 0x0400EF6E RID: 61294
	private bool ForceClientTravelInternal;

	// Token: 0x0400EF6F RID: 61295
	public bool LoadMapControllerEnableWorldPartition;

	// Token: 0x0400EF70 RID: 61296
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<string, HashSet<ULevelStreamingDynamic>> LoadMapControllerDynamicStreamingLevelsInternal;

	// Token: 0x0400EF71 RID: 61297
	private ITimeDilationData CacheTimeDilationData;

	// Token: 0x0400EF72 RID: 61298
	private static GameModeModel _Instance;
}
