using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02003530 RID: 13616
[NullableContext(1)]
[Nullable(0)]
public class WorldModel : ModelBase
{
	// Token: 0x17002963 RID: 10595
	// (get) Token: 0x0601DEB9 RID: 122553 RVA: 0x0086346A File Offset: 0x0086166A
	// (set) Token: 0x0601DEBA RID: 122554 RVA: 0x00863476 File Offset: 0x00861676
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

	// Token: 0x0601DEBB RID: 122555 RVA: 0x00863480 File Offset: 0x00861680
	public void UpdateWorldState(IDictionary<string, VarDefinePb> infos)
	{
		foreach (string key in infos.Keys)
		{
			VarDefinePb value = infos[key];
			this.WorldStateMapInternal[key] = value;
		}
	}

	// Token: 0x0601DEBC RID: 122556 RVA: 0x008634DC File Offset: 0x008616DC
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

	// Token: 0x0601DEBD RID: 122557 RVA: 0x0086350C File Offset: 0x0086170C
	public bool GetWorldStateBool(string key)
	{
		VarDefinePb varDefinePb;
		return this.WorldStateMapInternal.TryGetValue(key, out varDefinePb) && varDefinePb.VarType == 0 && varDefinePb.Boolean;
	}

	// Token: 0x0601DEBE RID: 122558 RVA: 0x0086353C File Offset: 0x0086173C
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

	// Token: 0x0601DEBF RID: 122559 RVA: 0x00863584 File Offset: 0x00861784
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

	// Token: 0x0601DEC0 RID: 122560 RVA: 0x008635CC File Offset: 0x008617CC
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

	// Token: 0x0601DEC1 RID: 122561 RVA: 0x0086365F File Offset: 0x0086185F
	public bool GetMapDone()
	{
		return this.MapDone;
	}

	// Token: 0x0601DEC2 RID: 122562 RVA: 0x00863667 File Offset: 0x00861867
	public void SetMapDone(bool value)
	{
		this.MapDone = value;
	}

	// Token: 0x0601DEC3 RID: 122563 RVA: 0x00863670 File Offset: 0x00861870
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

	// Token: 0x0601DEC4 RID: 122564 RVA: 0x008636C0 File Offset: 0x008618C0
	public void RemoveTsSimpleInteractItem(TsSimpleInteractBase item)
	{
		HashSet<TsSimpleInteractBase> hashSet;
		if (this.InteractMap.TryGetValue((long)item.TypeId, out hashSet))
		{
			hashSet.Remove(item);
		}
	}

	// Token: 0x0601DEC5 RID: 122565 RVA: 0x008636EB File Offset: 0x008618EB
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<TsSimpleInteractBase> GetTsSimpleInteractItemById(long typeId)
	{
		return this.InteractMap.GetValueOrDefault(typeId);
	}

	// Token: 0x0601DEC6 RID: 122566 RVA: 0x008636F9 File Offset: 0x008618F9
	[NullableContext(2)]
	public void AddDestroyActor(long creatureDataId, int entityId, AActor actor)
	{
		if (actor == null || !actor.IsValid())
		{
			return;
		}
		this.DestroyActorQueue.Push(new ValueTuple<long, int, AActor>(creatureDataId, entityId, actor));
	}

	// Token: 0x0601DEC7 RID: 122567 RVA: 0x00863720 File Offset: 0x00861920
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

	// Token: 0x0601DEC8 RID: 122568 RVA: 0x00863754 File Offset: 0x00861954
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

	// Token: 0x0601DEC9 RID: 122569 RVA: 0x00863784 File Offset: 0x00861984
	[NullableContext(2)]
	public bool RemoveIgnore(AActor actor)
	{
		return actor != null && actor.IsValid() && this.ActorsToIgnoreSet.Remove(actor);
	}

	// Token: 0x0601DECA RID: 122570 RVA: 0x008637A5 File Offset: 0x008619A5
	public void ClearIgnore()
	{
		this.ActorsToIgnoreSet.Clear();
	}

	// Token: 0x0601DECB RID: 122571 RVA: 0x008637B4 File Offset: 0x008619B4
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

	// Token: 0x0601DECC RID: 122572 RVA: 0x00863810 File Offset: 0x00861A10
	[NullableContext(2)]
	public FKuroVoxelInfo GetCachedVoxelInfo()
	{
		return this.CachedVoxelInfo;
	}

	// Token: 0x0601DECD RID: 122573 RVA: 0x00863818 File Offset: 0x00861A18
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

	// Token: 0x17002964 RID: 10596
	// (get) Token: 0x0601DECE RID: 122574 RVA: 0x00863907 File Offset: 0x00861B07
	public static WorldModel Instance
	{
		get
		{
			return WorldModel._Instance;
		}
	}

	// Token: 0x0601DECF RID: 122575 RVA: 0x0086390E File Offset: 0x00861B0E
	public static WorldModel GetOrCreateInstance()
	{
		if (WorldModel._Instance == null)
		{
			WorldModel.CreateInstance();
		}
		return WorldModel._Instance;
	}

	// Token: 0x0601DED0 RID: 122576 RVA: 0x00863922 File Offset: 0x00861B22
	public static bool CreateInstance()
	{
		if (WorldModel._Instance != null)
		{
			return true;
		}
		WorldModel._Instance = new WorldModel();
		return true;
	}

	// Token: 0x0601DED1 RID: 122577 RVA: 0x00863938 File Offset: 0x00861B38
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DED2 RID: 122578 RVA: 0x0086393A File Offset: 0x00861B3A
	public static void ResetStaticDefaultValue()
	{
		WorldModel._Instance = null;
	}

	// Token: 0x0601DED3 RID: 122579 RVA: 0x00863942 File Offset: 0x00861B42
	static WorldModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldModel.CreateStaticDefaultValue), new Action(WorldModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EB03 RID: 60163
	public const int VOXEL_ENV_REQUEST_INTERVAL = 1000;

	// Token: 0x0400EB04 RID: 60164
	public const int DEFAULT_ENVIRONMENTTYPE = 255;

	// Token: 0x0400EB05 RID: 60165
	public const int ENVIRONMENT_TOLERANCE = 5;

	// Token: 0x0400EB06 RID: 60166
	public const int MOBILE_CSM_DISTANCE_INCAVE = 20000;

	// Token: 0x0400EB07 RID: 60167
	public const int MOBILE_CSM_DISTANCE_OUTCAVE = 8000;

	// Token: 0x0400EB08 RID: 60168
	public bool IsStandalone;

	// Token: 0x0400EB09 RID: 60169
	public List<TickIntervalSchedulerBase> TickIntervalSchedulers = new List<TickIntervalSchedulerBase>();

	// Token: 0x0400EB0A RID: 60170
	private FVector? ControlPlayerLastLocationInternal;

	// Token: 0x0400EB0B RID: 60171
	private bool MapDone;

	// Token: 0x0400EB0C RID: 60172
	private Dictionary<long, HashSet<TsSimpleInteractBase>> InteractMap = new Dictionary<long, HashSet<TsSimpleInteractBase>>();

	// Token: 0x0400EB0D RID: 60173
	public long ChangeSchedulerLastType;

	// Token: 0x0400EB0E RID: 60174
	public long ChangeSchedulerDeltaFrameCount;

	// Token: 0x0400EB0F RID: 60175
	public double CurrentSchedulerDelta;

	// Token: 0x0400EB10 RID: 60176
	private readonly Dictionary<string, VarDefinePb> WorldStateMapInternal = new Dictionary<string, VarDefinePb>();

	// Token: 0x0400EB11 RID: 60177
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public readonly Queue<ValueTuple<long, int, AActor>> DestroyActorQueue = new Queue<ValueTuple<long, int, AActor>>(4);

	// Token: 0x0400EB12 RID: 60178
	public readonly HashSet<AActor> ActorsToIgnoreSet = new HashSet<AActor>();

	// Token: 0x0400EB13 RID: 60179
	public readonly WorldEnvironmentInfo CurEnvironmentInfo = new WorldEnvironmentInfo();

	// Token: 0x0400EB14 RID: 60180
	[Nullable(2)]
	private FKuroVoxelInfo CachedVoxelInfo;

	// Token: 0x0400EB15 RID: 60181
	private long CurEnvironmentTolerance;

	// Token: 0x0400EB16 RID: 60182
	public bool IsEnableEnvironmentDetecting = true;

	// Token: 0x0400EB17 RID: 60183
	[Nullable(2)]
	private static WorldModel _Instance;
}
