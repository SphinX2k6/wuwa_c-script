using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02002AA5 RID: 10917
[NullableContext(1)]
[Nullable(0)]
public class WorldModel : ModelBase
{
	// Token: 0x17002CFC RID: 11516
	// (get) Token: 0x0601BBE1 RID: 113633 RVA: 0x0088B0A2 File Offset: 0x008892A2
	// (set) Token: 0x0601BBE2 RID: 113634 RVA: 0x0088B0AE File Offset: 0x008892AE
	public FVector? ControlPlayerLastLocation
	{
		get
		{
			return WorldModel.Instance.ControlPlayerLastLocationInternal;
		}
		set
		{
			this.ControlPlayerLastLocationInternal = value;
		}
	}

	// Token: 0x0601BBE3 RID: 113635 RVA: 0x0088B0B8 File Offset: 0x008892B8
	public void UpdateWorldState(IDictionary<string, VarDefinePb> infos)
	{
		foreach (string key in infos.Keys)
		{
			VarDefinePb value = infos[key];
			this.WorldStateMapInternal[key] = value;
		}
	}

	// Token: 0x0601BBE4 RID: 113636 RVA: 0x0088B114 File Offset: 0x00889314
	[return: Nullable(2)]
	public string GetWorldStateString(string key)
	{
		VarDefinePb varDefinePb;
		if (!this.WorldStateMapInternal.TryGetValue(key, out varDefinePb))
		{
			return null;
		}
		if (varDefinePb.VarType != 2)
		{
			return null;
		}
		return varDefinePb.String;
	}

	// Token: 0x0601BBE5 RID: 113637 RVA: 0x0088B144 File Offset: 0x00889344
	public bool GetWorldStateBool(string key)
	{
		VarDefinePb varDefinePb;
		return this.WorldStateMapInternal.TryGetValue(key, out varDefinePb) && varDefinePb.VarType == 0 && varDefinePb.Boolean;
	}

	// Token: 0x0601BBE6 RID: 113638 RVA: 0x0088B174 File Offset: 0x00889374
	public float? GetWorldStateFloat(string key)
	{
		VarDefinePb varDefinePb;
		if (!this.WorldStateMapInternal.TryGetValue(key, out varDefinePb))
		{
			return null;
		}
		if (varDefinePb.VarType != 3)
		{
			return null;
		}
		return new float?(varDefinePb.Float);
	}

	// Token: 0x0601BBE7 RID: 113639 RVA: 0x0088B1BC File Offset: 0x008893BC
	public long? GetWorldStateLong(string key)
	{
		VarDefinePb varDefinePb;
		if (!this.WorldStateMapInternal.TryGetValue(key, out varDefinePb))
		{
			return null;
		}
		if (varDefinePb.VarType != 1)
		{
			return null;
		}
		return new long?(varDefinePb.Int);
	}

	// Token: 0x0601BBE8 RID: 113640 RVA: 0x0088B204 File Offset: 0x00889404
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public OneOf<bool, string, double> GetWorldState(string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			return default(OneOf<bool, string, double>);
		}
		VarDefinePb varDefinePb;
		if (!this.WorldStateMapInternal.TryGetValue(key, out varDefinePb))
		{
			return default(OneOf<bool, string, double>);
		}
		switch (varDefinePb.VarType)
		{
		case 0:
			return varDefinePb.Boolean;
		case 1:
			return (double)varDefinePb.Int;
		case 2:
			return varDefinePb.String;
		case 3:
			return (double)varDefinePb.Float;
		default:
			return default(OneOf<bool, string, double>);
		}
	}

	// Token: 0x0601BBE9 RID: 113641 RVA: 0x0088B297 File Offset: 0x00889497
	public bool GetMapDone()
	{
		return this.MapDone;
	}

	// Token: 0x0601BBEA RID: 113642 RVA: 0x0088B29F File Offset: 0x0088949F
	public void SetMapDone(bool value)
	{
		this.MapDone = value;
	}

	// Token: 0x0601BBEB RID: 113643 RVA: 0x0088B2A8 File Offset: 0x008894A8
	public void AddTsSimpleInteractItem(TsSimpleInteractBase item)
	{
		HashSet<TsSimpleInteractBase> hashSet;
		if (this.InteractMap.TryGetValue((long)item.TypeId, out hashSet))
		{
			hashSet.Add(item);
			return;
		}
		hashSet = new HashSet<TsSimpleInteractBase>();
		hashSet.Add(item);
		this.InteractMap[(long)item.TypeId] = hashSet;
	}

	// Token: 0x0601BBEC RID: 113644 RVA: 0x0088B2F8 File Offset: 0x008894F8
	public void RemoveTsSimpleInteractItem(TsSimpleInteractBase item)
	{
		HashSet<TsSimpleInteractBase> hashSet;
		if (this.InteractMap.TryGetValue((long)item.TypeId, out hashSet))
		{
			hashSet.Remove(item);
		}
	}

	// Token: 0x0601BBED RID: 113645 RVA: 0x0088B323 File Offset: 0x00889523
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<TsSimpleInteractBase> GetTsSimpleInteractItemById(long typeId)
	{
		return this.InteractMap.GetValueOrDefault(typeId);
	}

	// Token: 0x0601BBEE RID: 113646 RVA: 0x0088B331 File Offset: 0x00889531
	[NullableContext(2)]
	public void AddDestroyActor(long creatureDataId, int entityId, AActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			return;
		}
		this.DestroyActorQueue.Push(new ValueTuple<long, int, AActor>(creatureDataId, entityId, actor));
	}

	// Token: 0x0601BBEF RID: 113647 RVA: 0x0088B358 File Offset: 0x00889558
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<long, int, AActor>? PopDestroyActor()
	{
		if (this.DestroyActorQueue.Size == 0)
		{
			return null;
		}
		return new ValueTuple<long, int, AActor>?(this.DestroyActorQueue.Pop());
	}

	// Token: 0x0601BBF0 RID: 113648 RVA: 0x0088B38C File Offset: 0x0088958C
	public void AddIgnore(AActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			return;
		}
		if (this.ActorsToIgnoreSet.Contains(actor))
		{
			return;
		}
		this.ActorsToIgnoreSet.Add(actor);
	}

	// Token: 0x0601BBF1 RID: 113649 RVA: 0x0088B3BC File Offset: 0x008895BC
	[NullableContext(2)]
	public bool RemoveIgnore(AActor actor)
	{
		return actor != null && actor.IsValid() && this.ActorsToIgnoreSet.Remove(actor);
	}

	// Token: 0x0601BBF2 RID: 113650 RVA: 0x0088B3DD File Offset: 0x008895DD
	public void ClearIgnore()
	{
		this.ActorsToIgnoreSet.Clear();
	}

	// Token: 0x0601BBF3 RID: 113651 RVA: 0x0088B3EC File Offset: 0x008895EC
	public bool HandleEnvironmentUpdate(FKuroVoxelInfo info)
	{
		FKuroVoxelInfo cachedVoxelInfo = this.CachedVoxelInfo;
		this.CachedVoxelInfo = info;
		if (cachedVoxelInfo == null)
		{
			return true;
		}
		if (this.CachedVoxelInfo.EnvType != cachedVoxelInfo.EnvType)
		{
			this.CurEnvironmentTolerance = 0L;
		}
		else
		{
			this.CurEnvironmentTolerance += 1L;
		}
		return this.CurEnvironmentTolerance > 5L;
	}

	// Token: 0x0601BBF4 RID: 113652 RVA: 0x0088B448 File Offset: 0x00889648
	[NullableContext(2)]
	public FKuroVoxelInfo GetCachedVoxelInfo()
	{
		return this.CachedVoxelInfo;
	}

	// Token: 0x0601BBF5 RID: 113653 RVA: 0x0088B450 File Offset: 0x00889650
	public EStreamingHandleType ApplyEnvironmentUpdate()
	{
		EStreamingHandleType result = EStreamingHandleType.DoNothing;
		if (this.CachedVoxelInfo == null || this.CurEnvironmentInfo.IsEqual((long)((ulong)this.CachedVoxelInfo.EnvType)))
		{
			return result;
		}
		int envType = this.CurEnvironmentInfo.EnvType;
		if (envType > 1)
		{
			if (envType != 2)
			{
				if (envType == 255)
				{
					if (this.CachedVoxelInfo.EnvType == 2)
					{
						result = EStreamingHandleType.EnterEncloseSpace;
					}
					if (this.CachedVoxelInfo.EnvType == 0 || this.CachedVoxelInfo.EnvType == 1)
					{
						result = EStreamingHandleType.ImmediateEnter;
					}
				}
			}
			else
			{
				if (this.CachedVoxelInfo.EnvType == 255)
				{
					result = EStreamingHandleType.FinishExitEncloseSpace;
				}
				if (this.CachedVoxelInfo.EnvType == 0 || this.CachedVoxelInfo.EnvType == 1)
				{
					result = EStreamingHandleType.FinishEnterEncloseSpace;
				}
			}
		}
		else
		{
			if (this.CachedVoxelInfo.EnvType == 255)
			{
				result = EStreamingHandleType.ImmediateExit;
			}
			if (this.CachedVoxelInfo.EnvType == 2)
			{
				result = EStreamingHandleType.ExitEncloseSpace;
			}
		}
		this.CurEnvironmentInfo.SetInfo(this.CachedVoxelInfo);
		return result;
	}

	// Token: 0x17002CFD RID: 11517
	// (get) Token: 0x0601BBF6 RID: 113654 RVA: 0x0088B53F File Offset: 0x0088973F
	public static WorldModel Instance
	{
		get
		{
			return WorldModel._Instance;
		}
	}

	// Token: 0x0601BBF7 RID: 113655 RVA: 0x0088B546 File Offset: 0x00889746
	public static WorldModel GetOrCreateInstance()
	{
		if (WorldModel._Instance == null)
		{
			WorldModel.CreateInstance();
		}
		return WorldModel._Instance;
	}

	// Token: 0x0601BBF8 RID: 113656 RVA: 0x0088B55A File Offset: 0x0088975A
	public static bool CreateInstance()
	{
		if (WorldModel._Instance != null)
		{
			return true;
		}
		WorldModel._Instance = new WorldModel();
		return true;
	}

	// Token: 0x0601BBF9 RID: 113657 RVA: 0x0088B570 File Offset: 0x00889770
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BBFA RID: 113658 RVA: 0x0088B572 File Offset: 0x00889772
	public static void ResetStaticDefaultValue()
	{
		WorldModel._Instance = null;
	}

	// Token: 0x0601BBFB RID: 113659 RVA: 0x0088B57A File Offset: 0x0088977A
	static WorldModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldModel.CreateStaticDefaultValue), new Action(WorldModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EFC0 RID: 61376
	public const int VOXEL_ENV_REQUEST_INTERVAL = 1000;

	// Token: 0x0400EFC1 RID: 61377
	public const int DEFAULT_ENVIRONMENTTYPE = 255;

	// Token: 0x0400EFC2 RID: 61378
	public const int ENVIRONMENT_TOLERANCE = 5;

	// Token: 0x0400EFC3 RID: 61379
	public const int MOBILE_CSM_DISTANCE_INCAVE = 20000;

	// Token: 0x0400EFC4 RID: 61380
	public const int MOBILE_CSM_DISTANCE_OUTCAVE = 8000;

	// Token: 0x0400EFC5 RID: 61381
	public bool IsStandalone;

	// Token: 0x0400EFC6 RID: 61382
	public List<TickIntervalSchedulerBase> TickIntervalSchedulers = new List<TickIntervalSchedulerBase>();

	// Token: 0x0400EFC7 RID: 61383
	private FVector? ControlPlayerLastLocationInternal;

	// Token: 0x0400EFC8 RID: 61384
	private bool MapDone;

	// Token: 0x0400EFC9 RID: 61385
	private Dictionary<long, HashSet<TsSimpleInteractBase>> InteractMap = new Dictionary<long, HashSet<TsSimpleInteractBase>>();

	// Token: 0x0400EFCA RID: 61386
	public long ChangeSchedulerLastType;

	// Token: 0x0400EFCB RID: 61387
	public long ChangeSchedulerDeltaFrameCount;

	// Token: 0x0400EFCC RID: 61388
	public double CurrentSchedulerDelta;

	// Token: 0x0400EFCD RID: 61389
	private readonly Dictionary<string, VarDefinePb> WorldStateMapInternal = new Dictionary<string, VarDefinePb>();

	// Token: 0x0400EFCE RID: 61390
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public readonly Queue<ValueTuple<long, int, AActor>> DestroyActorQueue = new Queue<ValueTuple<long, int, AActor>>(4);

	// Token: 0x0400EFCF RID: 61391
	public readonly HashSet<AActor> ActorsToIgnoreSet = new HashSet<AActor>();

	// Token: 0x0400EFD0 RID: 61392
	public readonly WorldEnvironmentInfo CurEnvironmentInfo = new WorldEnvironmentInfo();

	// Token: 0x0400EFD1 RID: 61393
	[Nullable(2)]
	private FKuroVoxelInfo CachedVoxelInfo;

	// Token: 0x0400EFD2 RID: 61394
	private long CurEnvironmentTolerance;

	// Token: 0x0400EFD3 RID: 61395
	public bool IsEnableEnvironmentDetecting = true;

	// Token: 0x0400EFD4 RID: 61396
	[Nullable(2)]
	private static WorldModel _Instance;
}
