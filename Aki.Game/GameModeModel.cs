using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.DataLayerSwitch;
using UnrealEngine;

// Token: 0x02003524 RID: 13604
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class GameModeModel : ModelBase
{
	// Token: 0x1700291D RID: 10525
	// (get) Token: 0x0601DDC6 RID: 122310 RVA: 0x0085FC8F File Offset: 0x0085DE8F
	// (set) Token: 0x0601DDC7 RID: 122311 RVA: 0x0085FC97 File Offset: 0x0085DE97
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

	// Token: 0x1700291E RID: 10526
	// (get) Token: 0x0601DDC8 RID: 122312 RVA: 0x0085FCA0 File Offset: 0x0085DEA0
	// (set) Token: 0x0601DDC9 RID: 122313 RVA: 0x0085FCA8 File Offset: 0x0085DEA8
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

	// Token: 0x1700291F RID: 10527
	// (get) Token: 0x0601DDCA RID: 122314 RVA: 0x0085FCB1 File Offset: 0x0085DEB1
	public bool Loading
	{
		get
		{
			return this.LoadingPhaseInternal > ELoadingPhase.Finished;
		}
	}

	// Token: 0x17002920 RID: 10528
	// (get) Token: 0x0601DDCB RID: 122315 RVA: 0x0085FCBC File Offset: 0x0085DEBC
	// (set) Token: 0x0601DDCC RID: 122316 RVA: 0x0085FCC4 File Offset: 0x0085DEC4
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

	// Token: 0x17002921 RID: 10529
	// (get) Token: 0x0601DDCD RID: 122317 RVA: 0x0085FCCD File Offset: 0x0085DECD
	// (set) Token: 0x0601DDCE RID: 122318 RVA: 0x0085FCD5 File Offset: 0x0085DED5
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

	// Token: 0x17002922 RID: 10530
	// (get) Token: 0x0601DDCF RID: 122319 RVA: 0x0085FCDE File Offset: 0x0085DEDE
	// (set) Token: 0x0601DDD0 RID: 122320 RVA: 0x0085FCE6 File Offset: 0x0085DEE6
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

	// Token: 0x17002923 RID: 10531
	// (get) Token: 0x0601DDD1 RID: 122321 RVA: 0x0085FCEF File Offset: 0x0085DEEF
	[Nullable(1)]
	public string LastMapPath
	{
		[NullableContext(1)]
		get
		{
			return this.LastMapPathInternal;
		}
	}

	// Token: 0x0601DDD2 RID: 122322 RVA: 0x0085FCF8 File Offset: 0x0085DEF8
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

	// Token: 0x0601DDD3 RID: 122323 RVA: 0x0085FDAC File Offset: 0x0085DFAC
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

	// Token: 0x17002924 RID: 10532
	// (get) Token: 0x0601DDD4 RID: 122324 RVA: 0x0085FEDA File Offset: 0x0085E0DA
	public bool MapDone
	{
		get
		{
			return this.LoadMapHandleMap != null && this.LoadMapHandleMap.Count == 0;
		}
	}

	// Token: 0x17002925 RID: 10533
	// (get) Token: 0x0601DDD5 RID: 122325 RVA: 0x0085FEF4 File Offset: 0x0085E0F4
	// (set) Token: 0x0601DDD6 RID: 122326 RVA: 0x0085FEFC File Offset: 0x0085E0FC
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

	// Token: 0x17002926 RID: 10534
	// (get) Token: 0x0601DDD7 RID: 122327 RVA: 0x0085FF05 File Offset: 0x0085E105
	// (set) Token: 0x0601DDD8 RID: 122328 RVA: 0x0085FF0D File Offset: 0x0085E10D
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

	// Token: 0x17002927 RID: 10535
	// (get) Token: 0x0601DDD9 RID: 122329 RVA: 0x0085FF16 File Offset: 0x0085E116
	// (set) Token: 0x0601DDDA RID: 122330 RVA: 0x0085FF1E File Offset: 0x0085E11E
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

	// Token: 0x17002928 RID: 10536
	// (get) Token: 0x0601DDDB RID: 122331 RVA: 0x0085FF27 File Offset: 0x0085E127
	[Nullable(1)]
	public APlayerStart[] PlayerStarts
	{
		[NullableContext(1)]
		get
		{
			return this.PlayerStartsInternal.ToArray();
		}
	}

	// Token: 0x17002929 RID: 10537
	// (get) Token: 0x0601DDDC RID: 122332 RVA: 0x0085FF34 File Offset: 0x0085E134
	// (set) Token: 0x0601DDDD RID: 122333 RVA: 0x0085FF41 File Offset: 0x0085E141
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

	// Token: 0x1700292A RID: 10538
	// (get) Token: 0x0601DDDE RID: 122334 RVA: 0x0085FF4F File Offset: 0x0085E14F
	public InstanceDungeon? InstanceDungeon
	{
		get
		{
			return this.InstanceDungeonInternal;
		}
	}

	// Token: 0x0601DDDF RID: 122335 RVA: 0x0085FF57 File Offset: 0x0085E157
	public void SetInstanceDungeon(int value)
	{
		this.InstanceDungeonInternal = ConfigInstanceDungeonById.GetConfig(value, true);
	}

	// Token: 0x1700292B RID: 10539
	// (get) Token: 0x0601DDE0 RID: 122336 RVA: 0x0085FF66 File Offset: 0x0085E166
	// (set) Token: 0x0601DDE1 RID: 122337 RVA: 0x0085FF6E File Offset: 0x0085E16E
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

	// Token: 0x1700292C RID: 10540
	// (get) Token: 0x0601DDE2 RID: 122338 RVA: 0x0085FF77 File Offset: 0x0085E177
	// (set) Token: 0x0601DDE3 RID: 122339 RVA: 0x0085FF93 File Offset: 0x0085E193
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

	// Token: 0x1700292D RID: 10541
	// (get) Token: 0x0601DDE4 RID: 122340 RVA: 0x0085FFA1 File Offset: 0x0085E1A1
	public InstanceType LastInstanceType
	{
		get
		{
			return this.LastInstanceTypeInternal;
		}
	}

	// Token: 0x1700292E RID: 10542
	// (get) Token: 0x0601DDE5 RID: 122341 RVA: 0x0085FFA9 File Offset: 0x0085E1A9
	// (set) Token: 0x0601DDE6 RID: 122342 RVA: 0x0085FFB1 File Offset: 0x0085E1B1
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

	// Token: 0x1700292F RID: 10543
	// (get) Token: 0x0601DDE7 RID: 122343 RVA: 0x0085FFBA File Offset: 0x0085E1BA
	// (set) Token: 0x0601DDE8 RID: 122344 RVA: 0x0085FFC2 File Offset: 0x0085E1C2
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

	// Token: 0x17002930 RID: 10544
	// (get) Token: 0x0601DDE9 RID: 122345 RVA: 0x0085FFCB File Offset: 0x0085E1CB
	// (set) Token: 0x0601DDEA RID: 122346 RVA: 0x0085FFD3 File Offset: 0x0085E1D3
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

	// Token: 0x17002931 RID: 10545
	// (get) Token: 0x0601DDEB RID: 122347 RVA: 0x0085FFDC File Offset: 0x0085E1DC
	// (set) Token: 0x0601DDEC RID: 122348 RVA: 0x0085FFE4 File Offset: 0x0085E1E4
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

	// Token: 0x17002932 RID: 10546
	// (get) Token: 0x0601DDED RID: 122349 RVA: 0x0085FFED File Offset: 0x0085E1ED
	// (set) Token: 0x0601DDEE RID: 122350 RVA: 0x0085FFF5 File Offset: 0x0085E1F5
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

	// Token: 0x17002933 RID: 10547
	// (get) Token: 0x0601DDEF RID: 122351 RVA: 0x0085FFFE File Offset: 0x0085E1FE
	// (set) Token: 0x0601DDF0 RID: 122352 RVA: 0x00860006 File Offset: 0x0085E206
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

	// Token: 0x17002934 RID: 10548
	// (get) Token: 0x0601DDF1 RID: 122353 RVA: 0x0086000F File Offset: 0x0085E20F
	// (set) Token: 0x0601DDF2 RID: 122354 RVA: 0x00860017 File Offset: 0x0085E217
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

	// Token: 0x17002935 RID: 10549
	// (get) Token: 0x0601DDF3 RID: 122355 RVA: 0x00860020 File Offset: 0x0085E220
	// (set) Token: 0x0601DDF4 RID: 122356 RVA: 0x00860028 File Offset: 0x0085E228
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

	// Token: 0x17002936 RID: 10550
	// (get) Token: 0x0601DDF5 RID: 122357 RVA: 0x00860031 File Offset: 0x0085E231
	[Nullable(1)]
	public DataLayerSwitchContext SwitchDataLayerContext
	{
		[NullableContext(1)]
		get
		{
			return this.switchDataLayerContext;
		}
	}

	// Token: 0x17002937 RID: 10551
	// (get) Token: 0x0601DDF6 RID: 122358 RVA: 0x00860039 File Offset: 0x0085E239
	public bool DataLayerSwitching
	{
		get
		{
			return this.switchDataLayerContext.DataLayerSwitching;
		}
	}

	// Token: 0x17002938 RID: 10552
	// (get) Token: 0x0601DDF7 RID: 122359 RVA: 0x00860046 File Offset: 0x0085E246
	// (set) Token: 0x0601DDF8 RID: 122360 RVA: 0x0086004E File Offset: 0x0085E24E
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

	// Token: 0x17002939 RID: 10553
	// (get) Token: 0x0601DDF9 RID: 122361 RVA: 0x00860057 File Offset: 0x0085E257
	// (set) Token: 0x0601DDFA RID: 122362 RVA: 0x0086005F File Offset: 0x0085E25F
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

	// Token: 0x1700293A RID: 10554
	// (get) Token: 0x0601DDFB RID: 122363 RVA: 0x00860068 File Offset: 0x0085E268
	// (set) Token: 0x0601DDFC RID: 122364 RVA: 0x00860070 File Offset: 0x0085E270
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

	// Token: 0x1700293B RID: 10555
	// (get) Token: 0x0601DDFD RID: 122365 RVA: 0x00860079 File Offset: 0x0085E279
	public CustomPromise<bool> ChangeSceneModePromise
	{
		get
		{
			return this.ChangeSceneModePromiseInternal;
		}
	}

	// Token: 0x1700293C RID: 10556
	// (get) Token: 0x0601DDFE RID: 122366 RVA: 0x00860081 File Offset: 0x0085E281
	public CustomPromise<bool> ChangeSceneModeVoxelPromise
	{
		get
		{
			return this.ChangeSceneModeVoxelPromiseInternal;
		}
	}

	// Token: 0x1700293D RID: 10557
	// (get) Token: 0x0601DDFF RID: 122367 RVA: 0x00860089 File Offset: 0x0085E289
	public CustomPromise<bool> ChangeSceneModeStreamingPromise
	{
		get
		{
			return this.ChangeSceneModeStreamingPromiseInternal;
		}
	}

	// Token: 0x0601DE00 RID: 122368 RVA: 0x00860094 File Offset: 0x0085E294
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

	// Token: 0x0601DE01 RID: 122369 RVA: 0x0086031C File Offset: 0x0085E51C
	[NullableContext(1)]
	public void AddPlayerStart(APlayerStart value)
	{
		this.PlayerStartsInternal.Add(value);
	}

	// Token: 0x0601DE02 RID: 122370 RVA: 0x0086032A File Offset: 0x0085E52A
	public void ClearPlayerStart()
	{
		this.PlayerStartsInternal.Clear();
	}

	// Token: 0x1700293E RID: 10558
	// (get) Token: 0x0601DE03 RID: 122371 RVA: 0x00860337 File Offset: 0x0085E537
	public AActor VoxelStreamingSource
	{
		get
		{
			return this.VoxelStreamingSourceInternal;
		}
	}

	// Token: 0x1700293F RID: 10559
	// (get) Token: 0x0601DE04 RID: 122372 RVA: 0x0086033F File Offset: 0x0085E53F
	public AActor StreamingSource
	{
		get
		{
			return this.StreamingSourceInternal;
		}
	}

	// Token: 0x17002940 RID: 10560
	// (get) Token: 0x0601DE05 RID: 122373 RVA: 0x00860347 File Offset: 0x0085E547
	// (set) Token: 0x0601DE06 RID: 122374 RVA: 0x0086034F File Offset: 0x0085E54F
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

	// Token: 0x17002941 RID: 10561
	// (get) Token: 0x0601DE07 RID: 122375 RVA: 0x00860358 File Offset: 0x0085E558
	// (set) Token: 0x0601DE08 RID: 122376 RVA: 0x00860360 File Offset: 0x0085E560
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

	// Token: 0x17002942 RID: 10562
	// (get) Token: 0x0601DE09 RID: 122377 RVA: 0x00860369 File Offset: 0x0085E569
	public FVectorDouble? BornLocation
	{
		get
		{
			return this.BornLocationInternal;
		}
	}

	// Token: 0x17002943 RID: 10563
	// (get) Token: 0x0601DE0A RID: 122378 RVA: 0x00860371 File Offset: 0x0085E571
	public FRotator? BornRotator
	{
		get
		{
			return this.BornRotatorInternal;
		}
	}

	// Token: 0x17002944 RID: 10564
	// (get) Token: 0x0601DE0B RID: 122379 RVA: 0x00860379 File Offset: 0x0085E579
	public global::Vector RoleLocation
	{
		get
		{
			return this.RoleLocationInternal;
		}
	}

	// Token: 0x17002945 RID: 10565
	// (get) Token: 0x0601DE0C RID: 122380 RVA: 0x00860381 File Offset: 0x0085E581
	// (set) Token: 0x0601DE0D RID: 122381 RVA: 0x00860389 File Offset: 0x0085E589
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

	// Token: 0x17002946 RID: 10566
	// (get) Token: 0x0601DE0E RID: 122382 RVA: 0x00860392 File Offset: 0x0085E592
	// (set) Token: 0x0601DE0F RID: 122383 RVA: 0x0086039A File Offset: 0x0085E59A
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

	// Token: 0x0601DE10 RID: 122384 RVA: 0x008603A4 File Offset: 0x0085E5A4
	[NullableContext(1)]
	public AActor CreateShapedStreamingSource(int sectorAngle = 100, float loadingRangeScale = 1f)
	{
		FStreamingSourceShape[] shapes = new FStreamingSourceShape[]
		{
			new FStreamingSourceShape(true, loadingRangeScale, 0f, true, (float)sectorAngle, global::Vector.ZeroVector, global::Rotator.ZeroRotator)
		};
		return GameModeModel.CreateStreamingSource(MathUtils.Instance.DefaultTransformDouble, EStreamingSourcePriority.Normal, EStreamingSourceTargetBehavior.Include, null, shapes);
	}

	// Token: 0x0601DE11 RID: 122385 RVA: 0x008603EC File Offset: 0x0085E5EC
	[NullableContext(1)]
	public static AActor CreateIndependentStreamingSource(FName[] targetGrids, float loadingRange, EStreamingSourcePriority priority)
	{
		FStreamingSourceShape[] shapes = new FStreamingSourceShape[]
		{
			new FStreamingSourceShape(false, 1f, loadingRange, false, 360f, global::Vector.ZeroVector, global::Rotator.ZeroRotator)
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

	// Token: 0x0601DE12 RID: 122386 RVA: 0x00860460 File Offset: 0x0085E660
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

	// Token: 0x0601DE13 RID: 122387 RVA: 0x00860560 File Offset: 0x0085E760
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

	// Token: 0x0601DE14 RID: 122388 RVA: 0x00860600 File Offset: 0x0085E800
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

	// Token: 0x0601DE15 RID: 122389 RVA: 0x0086065C File Offset: 0x0085E85C
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

	// Token: 0x0601DE16 RID: 122390 RVA: 0x008606E8 File Offset: 0x0085E8E8
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
						fstreamingSourceShape = new FStreamingSourceShape(true, streamingSourceScale, 0f, false, 360f, global::Vector.ZeroVector, global::Rotator.ZeroRotator);
						uworldPartitionStreamingSourceComponent.Shapes.Add(fstreamingSourceShape);
					}
					else
					{
						fstreamingSourceShape.LoadingRangeScale = streamingSourceScale;
					}
					if (fstreamingSourceShape2 == null)
					{
						fstreamingSourceShape2 = new FStreamingSourceShape(false, 1f, 7000f, false, 360f, global::Vector.ZeroVector, global::Rotator.ZeroRotator);
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

	// Token: 0x0601DE17 RID: 122391 RVA: 0x00860860 File Offset: 0x0085EA60
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

	// Token: 0x0601DE18 RID: 122392 RVA: 0x008608F4 File Offset: 0x0085EAF4
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

	// Token: 0x0601DE19 RID: 122393 RVA: 0x00860944 File Offset: 0x0085EB44
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

	// Token: 0x0601DE1A RID: 122394 RVA: 0x008609A8 File Offset: 0x0085EBA8
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

	// Token: 0x0601DE1B RID: 122395 RVA: 0x00860C4C File Offset: 0x0085EE4C
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

	// Token: 0x0601DE1C RID: 122396 RVA: 0x00860E38 File Offset: 0x0085F038
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

	// Token: 0x0601DE1D RID: 122397 RVA: 0x00860EC8 File Offset: 0x0085F0C8
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

	// Token: 0x0601DE1E RID: 122398 RVA: 0x00860F40 File Offset: 0x0085F140
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

	// Token: 0x0601DE1F RID: 122399 RVA: 0x00860FF4 File Offset: 0x0085F1F4
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

	// Token: 0x0601DE20 RID: 122400 RVA: 0x0086104C File Offset: 0x0085F24C
	public void StopIndependentStreaming(AActor actor = null)
	{
		this.IndependentStreaming = false;
		this.AttachStreamingSourcesToActor(actor);
	}

	// Token: 0x0601DE21 RID: 122401 RVA: 0x00861060 File Offset: 0x0085F260
	public void SetBornInfo(IVector bornLocation, IRotator bornRotator)
	{
		this.BornLocationInternal = ((bornLocation != null) ? new FVectorDouble?(new FVectorDouble(bornLocation.X, bornLocation.Y, bornLocation.Z)) : null);
		this.RoleLocationInternal = ((bornLocation != null) ? global::Vector.Create(bornLocation) : null);
		this.BornRotatorInternal = ((bornRotator != null) ? new FRotator?(new FRotator(bornRotator.Pitch, bornRotator.Yaw, bornRotator.Roll)) : null);
	}

	// Token: 0x0601DE22 RID: 122402 RVA: 0x008610DF File Offset: 0x0085F2DF
	public void UpdateBornLocation(FVectorDouble location)
	{
		this.RoleLocationInternal.Set(location.X, location.Y, location.Z);
	}

	// Token: 0x0601DE23 RID: 122403 RVA: 0x00861100 File Offset: 0x0085F300
	public void FlushTempDataLayers()
	{
		foreach (string item in this.TempDataLayer)
		{
			this.DataLayerSet.Add(item);
		}
	}

	// Token: 0x0601DE24 RID: 122404 RVA: 0x0086115C File Offset: 0x0085F35C
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

	// Token: 0x0601DE25 RID: 122405 RVA: 0x0086117C File Offset: 0x0085F37C
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

	// Token: 0x0601DE26 RID: 122406 RVA: 0x00861197 File Offset: 0x0085F397
	[NullableContext(1)]
	public bool HasDataLayer(string path)
	{
		return this.DataLayerSet.Contains(path);
	}

	// Token: 0x0601DE27 RID: 122407 RVA: 0x008611A5 File Offset: 0x0085F3A5
	[NullableContext(1)]
	public HashSet<string> GetAllDataLayers()
	{
		return this.DataLayerSet;
	}

	// Token: 0x17002947 RID: 10567
	// (get) Token: 0x0601DE28 RID: 122408 RVA: 0x008611AD File Offset: 0x0085F3AD
	public GameModePromise BeginLoadMapPromise
	{
		get
		{
			return this.BeginLoadMapPromiseInternal;
		}
	}

	// Token: 0x17002948 RID: 10568
	// (get) Token: 0x0601DE29 RID: 122409 RVA: 0x008611B5 File Offset: 0x0085F3B5
	public GameModePromise AfterJoinSceneNotifyPromise
	{
		get
		{
			return this.AfterJoinSceneNotifyPromiseInternal;
		}
	}

	// Token: 0x17002949 RID: 10569
	// (get) Token: 0x0601DE2A RID: 122410 RVA: 0x008611BD File Offset: 0x0085F3BD
	public GameModePromise OpenLevelPromise
	{
		get
		{
			return this.OpenLevelPromiseInternal;
		}
	}

	// Token: 0x1700294A RID: 10570
	// (get) Token: 0x0601DE2B RID: 122411 RVA: 0x008611C5 File Offset: 0x0085F3C5
	public GameModePromise StreamingCompleted
	{
		get
		{
			return this.StreamingCompletedInternal;
		}
	}

	// Token: 0x1700294B RID: 10571
	// (get) Token: 0x0601DE2C RID: 122412 RVA: 0x008611CD File Offset: 0x0085F3CD
	public GameModePromise VoxelStreamingCompleted
	{
		get
		{
			return this.VoxelStreamingCompletedInternal;
		}
	}

	// Token: 0x1700294C RID: 10572
	// (get) Token: 0x0601DE2D RID: 122413 RVA: 0x008611D5 File Offset: 0x0085F3D5
	// (set) Token: 0x0601DE2E RID: 122414 RVA: 0x008611DD File Offset: 0x0085F3DD
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

	// Token: 0x1700294D RID: 10573
	// (get) Token: 0x0601DE2F RID: 122415 RVA: 0x008611E6 File Offset: 0x0085F3E6
	public GameModePromise PreloadPromise
	{
		get
		{
			return this.PreloadPromiseInternal;
		}
	}

	// Token: 0x1700294E RID: 10574
	// (get) Token: 0x0601DE30 RID: 122416 RVA: 0x008611EE File Offset: 0x0085F3EE
	public GameModePromise ApplyMaterialParameterCollectionPromise
	{
		get
		{
			return this.ApplyMaterialParameterCollectionPromiseInternal;
		}
	}

	// Token: 0x1700294F RID: 10575
	// (get) Token: 0x0601DE31 RID: 122417 RVA: 0x008611F6 File Offset: 0x0085F3F6
	public GameModePromise ChangeSceneModeEndNotifyPromise
	{
		get
		{
			return this.ChangeSceneModeEndNotifyPromiseInternal;
		}
	}

	// Token: 0x17002950 RID: 10576
	// (get) Token: 0x0601DE32 RID: 122418 RVA: 0x008611FE File Offset: 0x0085F3FE
	// (set) Token: 0x0601DE33 RID: 122419 RVA: 0x00861206 File Offset: 0x0085F406
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

	// Token: 0x17002951 RID: 10577
	// (get) Token: 0x0601DE34 RID: 122420 RVA: 0x0086120F File Offset: 0x0085F40F
	// (set) Token: 0x0601DE35 RID: 122421 RVA: 0x00861217 File Offset: 0x0085F417
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

	// Token: 0x17002952 RID: 10578
	// (get) Token: 0x0601DE36 RID: 122422 RVA: 0x00861220 File Offset: 0x0085F420
	// (set) Token: 0x0601DE37 RID: 122423 RVA: 0x00861228 File Offset: 0x0085F428
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

	// Token: 0x17002953 RID: 10579
	// (get) Token: 0x0601DE38 RID: 122424 RVA: 0x00861231 File Offset: 0x0085F431
	public GameModePromise VideoStartPromise
	{
		get
		{
			return this.VideoStartPromiseInternal;
		}
	}

	// Token: 0x17002954 RID: 10580
	// (get) Token: 0x0601DE39 RID: 122425 RVA: 0x00861239 File Offset: 0x0085F439
	public GameModePromise OpenLoadingEnd
	{
		get
		{
			return this.OpenLoadingEndPromiseInternal;
		}
	}

	// Token: 0x17002955 RID: 10581
	// (get) Token: 0x0601DE3A RID: 122426 RVA: 0x00861241 File Offset: 0x0085F441
	public GameModePromise PlayFlowEndPromise
	{
		get
		{
			return this.PlayFlowEndPromiseInternal;
		}
	}

	// Token: 0x17002956 RID: 10582
	// (get) Token: 0x0601DE3B RID: 122427 RVA: 0x00861249 File Offset: 0x0085F449
	// (set) Token: 0x0601DE3C RID: 122428 RVA: 0x00861251 File Offset: 0x0085F451
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

	// Token: 0x17002957 RID: 10583
	// (get) Token: 0x0601DE3D RID: 122429 RVA: 0x0086125A File Offset: 0x0085F45A
	// (set) Token: 0x0601DE3E RID: 122430 RVA: 0x00861264 File Offset: 0x0085F464
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

	// Token: 0x17002958 RID: 10584
	// (get) Token: 0x0601DE3F RID: 122431 RVA: 0x008612E5 File Offset: 0x0085F4E5
	// (set) Token: 0x0601DE40 RID: 122432 RVA: 0x008612F0 File Offset: 0x0085F4F0
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

	// Token: 0x17002959 RID: 10585
	// (get) Token: 0x0601DE41 RID: 122433 RVA: 0x0086131D File Offset: 0x0085F51D
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

	// Token: 0x0601DE42 RID: 122434 RVA: 0x00861338 File Offset: 0x0085F538
	public void ClearLoadMapControllerData()
	{
		if (this.LoadMapControllerDynamicStreamingLevelsInternal != null)
		{
			this.LoadMapControllerDynamicStreamingLevelsInternal.Clear();
		}
		this.LoadMapControllerEnableWorldPartition = false;
	}

	// Token: 0x0601DE43 RID: 122435 RVA: 0x00861354 File Offset: 0x0085F554
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

	// Token: 0x0601DE44 RID: 122436 RVA: 0x008613D0 File Offset: 0x0085F5D0
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

	// Token: 0x0601DE45 RID: 122437 RVA: 0x0086142A File Offset: 0x0085F62A
	public void CreateChangeModePromise()
	{
		this.ChangeSceneModeEndNotifyPromiseInternal = new GameModePromise();
		this.ChangeSceneModePromiseInternal = new CustomPromise<bool>();
		this.ChangeSceneModeVoxelPromiseInternal = new CustomPromise<bool>();
		this.ChangeSceneModeStreamingPromiseInternal = new CustomPromise<bool>();
	}

	// Token: 0x0601DE46 RID: 122438 RVA: 0x00861458 File Offset: 0x0085F658
	public void ResetChangeModePromise()
	{
		this.ChangeSceneModeEndNotifyPromiseInternal = null;
		this.ChangeSceneModePromiseInternal = null;
		this.ChangeSceneModeVoxelPromiseInternal = null;
		this.ChangeSceneModeStreamingPromiseInternal = null;
	}

	// Token: 0x0601DE47 RID: 122439 RVA: 0x00861476 File Offset: 0x0085F676
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

	// Token: 0x0601DE48 RID: 122440 RVA: 0x008614B0 File Offset: 0x0085F6B0
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

	// Token: 0x0601DE49 RID: 122441 RVA: 0x008615F0 File Offset: 0x0085F7F0
	protected override bool OnChangeMode()
	{
		this.ResetPromise();
		return true;
	}

	// Token: 0x0601DE4A RID: 122442 RVA: 0x008615F9 File Offset: 0x0085F7F9
	public void SetCacheTimeDilationValue(float value)
	{
		this.CacheTimeDilationData = new TimeDilationDataImpl
		{
			TimeDilation = value
		};
	}

	// Token: 0x0601DE4B RID: 122443 RVA: 0x0086160D File Offset: 0x0085F80D
	public ITimeDilationData GetCacheTimeDilationValue()
	{
		return this.CacheTimeDilationData;
	}

	// Token: 0x0601DE4C RID: 122444 RVA: 0x00861615 File Offset: 0x0085F815
	public void ClearCacheTimeDilationValue()
	{
		this.CacheTimeDilationData = null;
	}

	// Token: 0x1700295A RID: 10586
	// (get) Token: 0x0601DE4D RID: 122445 RVA: 0x0086161E File Offset: 0x0085F81E
	[Nullable(1)]
	public static GameModeModel Instance
	{
		[NullableContext(1)]
		get
		{
			return GameModeModel._Instance;
		}
	}

	// Token: 0x0601DE4E RID: 122446 RVA: 0x00861625 File Offset: 0x0085F825
	[NullableContext(1)]
	public static GameModeModel GetOrCreateInstance()
	{
		if (GameModeModel._Instance == null)
		{
			GameModeModel.CreateInstance();
		}
		return GameModeModel._Instance;
	}

	// Token: 0x0601DE4F RID: 122447 RVA: 0x00861639 File Offset: 0x0085F839
	public static bool CreateInstance()
	{
		if (GameModeModel._Instance != null)
		{
			return true;
		}
		GameModeModel._Instance = new GameModeModel();
		return true;
	}

	// Token: 0x0601DE50 RID: 122448 RVA: 0x0086164F File Offset: 0x0085F84F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DE51 RID: 122449 RVA: 0x00861651 File Offset: 0x0085F851
	public static void ResetStaticDefaultValue()
	{
		GameModeModel._Instance = null;
	}

	// Token: 0x0601DE52 RID: 122450 RVA: 0x00861659 File Offset: 0x0085F859
	static GameModeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameModeModel.CreateStaticDefaultValue), new Action(GameModeModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EA53 RID: 59987
	public const ETimeDilationType PAUSE_TYPE = ETimeDilationType.PhantomBattleArena;

	// Token: 0x0400EA54 RID: 59988
	public bool IsSilentLogin;

	// Token: 0x0400EA55 RID: 59989
	private bool HasGameModeDataInternal;

	// Token: 0x0400EA56 RID: 59990
	private SceneMode? ModeInternal;

	// Token: 0x0400EA57 RID: 59991
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, int> LoadMapHandleMap;

	// Token: 0x0400EA58 RID: 59992
	private bool NavMeshDoneInternal;

	// Token: 0x0400EA59 RID: 59993
	private bool WorldDoneInternal;

	// Token: 0x0400EA5A RID: 59994
	private bool WorldDoneAndLoadingClosedInternal;

	// Token: 0x0400EA5B RID: 59995
	private bool ChangeModeStateInternal;

	// Token: 0x0400EA5C RID: 59996
	[Nullable(1)]
	private string MapPathInternal = "";

	// Token: 0x0400EA5D RID: 59997
	[Nullable(1)]
	private string LastMapPathInternal = "";

	// Token: 0x0400EA5E RID: 59998
	[Nullable(1)]
	private readonly List<APlayerStart> PlayerStartsInternal = new List<APlayerStart>();

	// Token: 0x0400EA5F RID: 59999
	private readonly FName PlayerStreamingSourceTag = FNameUtil.GetCheckDynamicFName("Player");

	// Token: 0x0400EA60 RID: 60000
	private AActor VoxelStreamingSourceInternal;

	// Token: 0x0400EA61 RID: 60001
	private AActor StreamingSourceInternal;

	// Token: 0x0400EA62 RID: 60002
	private AkiMapSource? MapConfigInternal;

	// Token: 0x0400EA63 RID: 60003
	private InstanceDungeon? InstanceDungeonInternal;

	// Token: 0x0400EA64 RID: 60004
	private int MapIdInternal;

	// Token: 0x0400EA65 RID: 60005
	private InstanceType? InstanceTypeInternal;

	// Token: 0x0400EA66 RID: 60006
	private InstanceType LastInstanceTypeInternal;

	// Token: 0x0400EA67 RID: 60007
	private bool IsMultiInternal;

	// Token: 0x0400EA68 RID: 60008
	private bool UseWorldPartitionInternal;

	// Token: 0x0400EA69 RID: 60009
	private bool IsTeleportInternal;

	// Token: 0x0400EA6A RID: 60010
	private bool PlayTravelMp4Internal;

	// Token: 0x0400EA6B RID: 60011
	private string TravelMp4PathInternal;

	// Token: 0x0400EA6C RID: 60012
	private bool TravelMp4PlayingInternal;

	// Token: 0x0400EA6D RID: 60013
	private bool UseShowCenterTextInternal;

	// Token: 0x0400EA6E RID: 60014
	private bool UseAsBlackScreenInternal;

	// Token: 0x0400EA6F RID: 60015
	private EFadeInScreenShowType BlackScreenColorInternal = EFadeInScreenShowType.Black;

	// Token: 0x0400EA70 RID: 60016
	public TransitionFlowPb ShowCenterTextFlow;

	// Token: 0x0400EA71 RID: 60017
	[Nullable(1)]
	private readonly DataLayerSwitchContext switchDataLayerContext = new DataLayerSwitchContext();

	// Token: 0x0400EA72 RID: 60018
	private EMovieBackgroundType? Mp4FadeInScreenColorInternal;

	// Token: 0x0400EA73 RID: 60019
	private EMovieBackgroundType? Mp4FadeOutScreenColorInternal;

	// Token: 0x0400EA74 RID: 60020
	private bool NeedOpenBlackScreenWhenTeleportDungeonInternal;

	// Token: 0x0400EA75 RID: 60021
	private CustomPromise<bool> ChangeSceneModePromiseInternal;

	// Token: 0x0400EA76 RID: 60022
	private CustomPromise<bool> ChangeSceneModeVoxelPromiseInternal;

	// Token: 0x0400EA77 RID: 60023
	private CustomPromise<bool> ChangeSceneModeStreamingPromiseInternal;

	// Token: 0x0400EA78 RID: 60024
	public bool ForceDisableGamePaused;

	// Token: 0x0400EA79 RID: 60025
	public bool PreAwakeEntityDuringLoad = true;

	// Token: 0x0400EA7A RID: 60026
	[Nullable(1)]
	public readonly HashSet<string> GamePausedReasons = new HashSet<string>();

	// Token: 0x0400EA7B RID: 60027
	[Nullable(1)]
	public readonly HashSet<string> DataLayerSet = new HashSet<string>();

	// Token: 0x0400EA7C RID: 60028
	[Nullable(1)]
	public readonly List<string> TempDataLayer = new List<string>();

	// Token: 0x0400EA7D RID: 60029
	[Nullable(1)]
	public readonly Dictionary<string, bool> MaterialParameterCollectionMap = new Dictionary<string, bool>();

	// Token: 0x0400EA7E RID: 60030
	[Nullable(1)]
	public readonly Dictionary<ETimeDilationType, float> TimeDilationMap = new Dictionary<ETimeDilationType, float>();

	// Token: 0x0400EA7F RID: 60031
	private SceneInformation JoinSceneInfoInternal;

	// Token: 0x0400EA80 RID: 60032
	private bool IndependentStreaming;

	// Token: 0x0400EA81 RID: 60033
	[Nullable(1)]
	private readonly Dictionary<EStreamingSourceScaleType, float> StreamingSourceScalingTypes = new Dictionary<EStreamingSourceScaleType, float>();

	// Token: 0x0400EA82 RID: 60034
	[Nullable(1)]
	private readonly Dictionary<EDisableHLODStreamingType, int> DisableHLODStreamingTypes = new Dictionary<EDisableHLODStreamingType, int>();

	// Token: 0x0400EA83 RID: 60035
	private TransitionWithSpineLoadingPb SpecialTransitionPbInternal;

	// Token: 0x0400EA84 RID: 60036
	private TransitionPlayFlowPb PlayFlowPbInternal;

	// Token: 0x0400EA85 RID: 60037
	private ELoadingPhase LoadingPhaseInternal;

	// Token: 0x0400EA86 RID: 60038
	public bool IsSameMapTraveling;

	// Token: 0x0400EA87 RID: 60039
	[Nullable(1)]
	public readonly LogProfiler LoadWorldProfiler = new LogProfiler("加载世界", false);

	// Token: 0x0400EA88 RID: 60040
	[Nullable(1)]
	public readonly LogProfiler OpenLoadingProfiler;

	// Token: 0x0400EA89 RID: 60041
	[Nullable(1)]
	public readonly LogProfiler OpenLevelProfiler;

	// Token: 0x0400EA8A RID: 60042
	[Nullable(1)]
	public readonly LogProfiler PreloadProfiler;

	// Token: 0x0400EA8B RID: 60043
	[Nullable(1)]
	public readonly LogProfiler PreloadApplyMaterialParameterCollectionProfiler;

	// Token: 0x0400EA8C RID: 60044
	[Nullable(1)]
	public readonly LogProfiler PreloadCommonAndEntityProfiler;

	// Token: 0x0400EA8D RID: 60045
	[Nullable(1)]
	public readonly LogProfiler PreloadControllerProfiler;

	// Token: 0x0400EA8E RID: 60046
	[Nullable(1)]
	public readonly LogProfiler PreloadCommonProfiler;

	// Token: 0x0400EA8F RID: 60047
	[Nullable(1)]
	public readonly LogProfiler PreloadEntitiesProfiler;

	// Token: 0x0400EA90 RID: 60048
	[Nullable(1)]
	public readonly LogProfiler PreloadDangoAbyssMonsterProfiler = new LogProfiler("子房间预加载团子深渊怪物实体", false);

	// Token: 0x0400EA91 RID: 60049
	[Nullable(1)]
	public readonly LogProfiler LoadDataLayerAndSubLevelProfiler;

	// Token: 0x0400EA92 RID: 60050
	[Nullable(1)]
	public readonly LogProfiler LoadSubLevelProfiler;

	// Token: 0x0400EA93 RID: 60051
	[Nullable(1)]
	public readonly LogProfiler LoadDataLayerProfiler;

	// Token: 0x0400EA94 RID: 60052
	[Nullable(1)]
	public readonly LogProfiler CheckVoxelStreamingSourceProfiler;

	// Token: 0x0400EA95 RID: 60053
	[Nullable(1)]
	public readonly LogProfiler CheckStreamingSourceProfiler;

	// Token: 0x0400EA96 RID: 60054
	[Nullable(1)]
	public readonly LogProfiler CreateEntitiesProfiler;

	// Token: 0x0400EA97 RID: 60055
	[Nullable(1)]
	public readonly LogProfiler WaitRenderAssetsProfiler;

	// Token: 0x0400EA98 RID: 60056
	[Nullable(1)]
	public readonly LogProfiler WorldDoneProfiler;

	// Token: 0x0400EA99 RID: 60057
	[Nullable(1)]
	public readonly LogProfiler OpenBattleViewProfiler;

	// Token: 0x0400EA9A RID: 60058
	[Nullable(1)]
	public readonly LogProfiler CloseLoadingProfiler;

	// Token: 0x0400EA9B RID: 60059
	[Nullable(1)]
	public readonly LogProfiler CloseLoadingPhaseOpenBattleViewProfiler;

	// Token: 0x0400EA9C RID: 60060
	private FVectorDouble? BornLocationInternal;

	// Token: 0x0400EA9D RID: 60061
	private FRotator? BornRotatorInternal;

	// Token: 0x0400EA9E RID: 60062
	private global::Vector RoleLocationInternal;

	// Token: 0x0400EA9F RID: 60063
	private GameModePromise BeginLoadMapPromiseInternal;

	// Token: 0x0400EAA0 RID: 60064
	private GameModePromise AfterJoinSceneNotifyPromiseInternal;

	// Token: 0x0400EAA1 RID: 60065
	private GameModePromise OpenLevelPromiseInternal;

	// Token: 0x0400EAA2 RID: 60066
	private GameModePromise StreamingCompletedInternal;

	// Token: 0x0400EAA3 RID: 60067
	private GameModePromise VoxelStreamingCompletedInternal;

	// Token: 0x0400EAA4 RID: 60068
	private GameModePromise LoadMultiFormationPromiseInternal;

	// Token: 0x0400EAA5 RID: 60069
	private GameModePromise PreloadPromiseInternal;

	// Token: 0x0400EAA6 RID: 60070
	private GameModePromise ApplyMaterialParameterCollectionPromiseInternal;

	// Token: 0x0400EAA7 RID: 60071
	private GameModePromise ChangeSceneModeEndNotifyPromiseInternal;

	// Token: 0x0400EAA8 RID: 60072
	private TimerHandle CheckStreamingCompletedTimerIdInternal;

	// Token: 0x0400EAA9 RID: 60073
	private TimerHandle CheckRenderAssetsStreamingCompletedTimerIdInternal;

	// Token: 0x0400EAAA RID: 60074
	private TimerHandle CheckRenderAssetsTimeoutIdInternal;

	// Token: 0x0400EAAB RID: 60075
	private GameModePromise VideoStartPromiseInternal;

	// Token: 0x0400EAAC RID: 60076
	private GameModePromise OpenLoadingEndPromiseInternal;

	// Token: 0x0400EAAD RID: 60077
	private GameModePromise PlayFlowEndPromiseInternal;

	// Token: 0x0400EAAE RID: 60078
	private bool RenderAssetDoneInternal;

	// Token: 0x0400EAAF RID: 60079
	public bool EnableLoadMapMode = true;

	// Token: 0x0400EAB0 RID: 60080
	private ELoadMapMode LoadMapModeInternal;

	// Token: 0x0400EAB1 RID: 60081
	private bool ForceClientTravelInternal;

	// Token: 0x0400EAB2 RID: 60082
	public bool LoadMapControllerEnableWorldPartition;

	// Token: 0x0400EAB3 RID: 60083
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<string, HashSet<ULevelStreamingDynamic>> LoadMapControllerDynamicStreamingLevelsInternal;

	// Token: 0x0400EAB4 RID: 60084
	private ITimeDilationData CacheTimeDilationData;

	// Token: 0x0400EAB5 RID: 60085
	private static GameModeModel _Instance;
}
