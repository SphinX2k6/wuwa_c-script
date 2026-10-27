using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F74 RID: 8052
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class IdlePerformModel : ModelBase
{
	// Token: 0x0600F9BC RID: 63932 RVA: 0x003C861F File Offset: 0x003C681F
	public void AccumulateIdleTime(float delta)
	{
		if (delta <= 0f)
		{
			return;
		}
		this.IdleTimeInternal += delta;
	}

	// Token: 0x0600F9BD RID: 63933 RVA: 0x003C8638 File Offset: 0x003C6838
	public void ResetIdleTime()
	{
		this.IdleTimeInternal = 0f;
	}

	// Token: 0x0600F9BE RID: 63934 RVA: 0x003C8645 File Offset: 0x003C6845
	public float GetIdleTime()
	{
		return this.IdleTimeInternal;
	}

	// Token: 0x0600F9BF RID: 63935 RVA: 0x003C864D File Offset: 0x003C684D
	public bool IsIdle()
	{
		return this.IdleTimeInternal > 0f;
	}

	// Token: 0x0600F9C0 RID: 63936 RVA: 0x003C865C File Offset: 0x003C685C
	protected override bool OnInit()
	{
		this.IdleTimeInternal = 0f;
		this.GazeAwarenessDataMap.Clear();
		this.AiNoMoveDataMap.Clear();
		this.AiSearchWanderPointDataMap.Clear();
		return true;
	}

	// Token: 0x0600F9C1 RID: 63937 RVA: 0x003C868B File Offset: 0x003C688B
	protected override bool OnClear()
	{
		this.IdleTimeInternal = 0f;
		this.GazeAwarenessDataMap.Clear();
		this.AiNoMoveDataMap.Clear();
		this.AiSearchWanderPointDataMap.Clear();
		return true;
	}

	// Token: 0x0600F9C2 RID: 63938 RVA: 0x003C86BA File Offset: 0x003C68BA
	public void OnTick(float delta)
	{
		if (delta <= 0f)
		{
			return;
		}
		this.AccumulateIdleTime(delta);
		this.AccumulatePlayerGazeTime(delta);
		this.TickAiNoMoveData();
		this.TickAiSearchWanderPointData();
	}

	// Token: 0x0600F9C3 RID: 63939 RVA: 0x003C86E0 File Offset: 0x003C68E0
	public void StartGazeAwarenessCheckByEntityId(int entityId, float awarenessAngle, float awarenessDistance, float awarenessHeight, float playerGazeAngle, bool enableDebugDraw = false)
	{
		if (this.GazeAwarenessDataMap.ContainsKey(entityId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.ZJL;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[IdlePerform] 已经存在 EntityId=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
			defaultInterpolatedStringHandler.AppendLiteral(" 的注视感知数据，无法重复添加");
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		IdleGazeAwarenessData value = new IdleGazeAwarenessData(entityId, awarenessAngle, awarenessDistance, awarenessHeight, playerGazeAngle, enableDebugDraw);
		this.GazeAwarenessDataMap[entityId] = value;
	}

	// Token: 0x0600F9C4 RID: 63940 RVA: 0x003C8760 File Offset: 0x003C6960
	public void StopGazeAwarenessCheckByEntityId(int entityId)
	{
		if (!this.GazeAwarenessDataMap.ContainsKey(entityId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.ZJL;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[IdlePerform] 不存在 EntityId=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
			defaultInterpolatedStringHandler.AppendLiteral(" 的注视感知数据，无法移除");
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.GazeAwarenessDataMap.Remove(entityId);
	}

	// Token: 0x0600F9C5 RID: 63941 RVA: 0x003C87D4 File Offset: 0x003C69D4
	public bool CheckGazeAwarenessByEntityId(int entityId, float time)
	{
		IdleGazeAwarenessData idleGazeAwarenessData;
		if (!this.GazeAwarenessDataMap.TryGetValue(entityId, out idleGazeAwarenessData))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.ZJL;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[IdlePerform] 不存在 EntityId=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
			defaultInterpolatedStringHandler.AppendLiteral(" 的注视感知数据，无法检查");
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return idleGazeAwarenessData.CheckPlayerGazeTime(time);
	}

	// Token: 0x0600F9C6 RID: 63942 RVA: 0x003C8844 File Offset: 0x003C6A44
	public void AccumulatePlayerGazeTime(float delta)
	{
		if (delta <= 0f)
		{
			return;
		}
		foreach (IdleGazeAwarenessData idleGazeAwarenessData in this.GazeAwarenessDataMap.Values)
		{
			idleGazeAwarenessData.Tick(delta);
		}
	}

	// Token: 0x0600F9C7 RID: 63943 RVA: 0x003C88A4 File Offset: 0x003C6AA4
	public void TickAiNoMoveData()
	{
		List<int> list = null;
		foreach (AiNoMoveData aiNoMoveData in this.AiNoMoveDataMap.Values)
		{
			if (!aiNoMoveData.Tick())
			{
				if (list == null)
				{
					list = new List<int>();
				}
				list.Add(aiNoMoveData.EntityId);
			}
		}
		if (list != null)
		{
			foreach (int key in list)
			{
				this.AiNoMoveDataMap.Remove(key);
			}
		}
	}

	// Token: 0x0600F9C8 RID: 63944 RVA: 0x003C895C File Offset: 0x003C6B5C
	internal AiNoMoveData GetOrCreateAiNoMoveData(int entityId)
	{
		AiNoMoveData aiNoMoveData;
		if (!this.AiNoMoveDataMap.TryGetValue(entityId, out aiNoMoveData))
		{
			aiNoMoveData = new AiNoMoveData(entityId);
			this.AiNoMoveDataMap[entityId] = aiNoMoveData;
			aiNoMoveData.Tick();
		}
		return aiNoMoveData;
	}

	// Token: 0x0600F9C9 RID: 63945 RVA: 0x003C8998 File Offset: 0x003C6B98
	public void ResetAiNoMoveTime(int entityId)
	{
		AiNoMoveData aiNoMoveData;
		if (!this.AiNoMoveDataMap.TryGetValue(entityId, out aiNoMoveData))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[IdlePerform] AI无移动数据，无法重置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		aiNoMoveData.ResetTime();
	}

	// Token: 0x0600F9CA RID: 63946 RVA: 0x003C89E8 File Offset: 0x003C6BE8
	public bool CheckAiNoMoveTime(int entityId, float timeMs, EAiNoMoveResetCondition resetConditionMask = EAiNoMoveResetCondition.None)
	{
		AiNoMoveData orCreateAiNoMoveData = this.GetOrCreateAiNoMoveData(entityId);
		orCreateAiNoMoveData.UpdateResetConditionMask(resetConditionMask);
		return orCreateAiNoMoveData.GetNoMoveTime() >= (double)timeMs;
	}

	// Token: 0x0600F9CB RID: 63947 RVA: 0x003C8A04 File Offset: 0x003C6C04
	public void TickAiSearchWanderPointData()
	{
		List<int> list = null;
		foreach (int num in this.AiSearchWanderPointDataMap.Keys)
		{
			Entity entity = EntitySystem.Instance.Get(num);
			if (entity == null || !entity.Valid)
			{
				if (list == null)
				{
					list = new List<int>();
				}
				list.Add(num);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[IdlePerform] AI搜索漫游点数据，实体已失效，移除数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", num);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		if (list != null)
		{
			foreach (int key in list)
			{
				this.AiSearchWanderPointDataMap.Remove(key);
			}
		}
	}

	// Token: 0x0600F9CC RID: 63948 RVA: 0x003C8AF8 File Offset: 0x003C6CF8
	public void AddAiSearchedWanderPointId(int entityId, int wanderPointId)
	{
		AiSearchWanderPointData aiSearchWanderPointData;
		if (!this.AiSearchWanderPointDataMap.TryGetValue(entityId, out aiSearchWanderPointData))
		{
			aiSearchWanderPointData = new AiSearchWanderPointData();
			this.AiSearchWanderPointDataMap[entityId] = aiSearchWanderPointData;
		}
		aiSearchWanderPointData.AddSearchedWanderPointId(wanderPointId);
	}

	// Token: 0x0600F9CD RID: 63949 RVA: 0x003C8B30 File Offset: 0x003C6D30
	public void ClearAiSearchedWanderPointIdSet(int entityId)
	{
		AiSearchWanderPointData aiSearchWanderPointData;
		if (!this.AiSearchWanderPointDataMap.TryGetValue(entityId, out aiSearchWanderPointData))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[IdlePerform] AI搜索漫游点数据，实体不存在，无法清空数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		aiSearchWanderPointData.ClearSearchedWanderPointIdSet();
	}

	// Token: 0x0600F9CE RID: 63950 RVA: 0x003C8B80 File Offset: 0x003C6D80
	public bool HasAiSearchedWanderPointId(int entityId, int wanderPointId)
	{
		AiSearchWanderPointData aiSearchWanderPointData;
		return this.AiSearchWanderPointDataMap.TryGetValue(entityId, out aiSearchWanderPointData) && aiSearchWanderPointData.HasSearchedWanderPointId(wanderPointId);
	}

	// Token: 0x1700133A RID: 4922
	// (get) Token: 0x0600F9CF RID: 63951 RVA: 0x003C8BA6 File Offset: 0x003C6DA6
	public static IdlePerformModel Instance
	{
		get
		{
			return IdlePerformModel._Instance;
		}
	}

	// Token: 0x0600F9D0 RID: 63952 RVA: 0x003C8BAD File Offset: 0x003C6DAD
	public static IdlePerformModel GetOrCreateInstance()
	{
		if (IdlePerformModel._Instance == null)
		{
			IdlePerformModel.CreateInstance();
		}
		return IdlePerformModel._Instance;
	}

	// Token: 0x0600F9D1 RID: 63953 RVA: 0x003C8BC1 File Offset: 0x003C6DC1
	public static bool CreateInstance()
	{
		if (IdlePerformModel._Instance != null)
		{
			return true;
		}
		IdlePerformModel._Instance = new IdlePerformModel();
		return true;
	}

	// Token: 0x0600F9D2 RID: 63954 RVA: 0x003C8BD7 File Offset: 0x003C6DD7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F9D3 RID: 63955 RVA: 0x003C8BD9 File Offset: 0x003C6DD9
	public static void ResetStaticDefaultValue()
	{
		IdlePerformModel._Instance = null;
	}

	// Token: 0x0600F9D4 RID: 63956 RVA: 0x003C8BE1 File Offset: 0x003C6DE1
	static IdlePerformModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(IdlePerformModel.CreateStaticDefaultValue), new Action(IdlePerformModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007472 RID: 29810
	private float IdleTimeInternal;

	// Token: 0x04007473 RID: 29811
	private Dictionary<int, IdleGazeAwarenessData> GazeAwarenessDataMap = new Dictionary<int, IdleGazeAwarenessData>();

	// Token: 0x04007474 RID: 29812
	private Dictionary<int, AiNoMoveData> AiNoMoveDataMap = new Dictionary<int, AiNoMoveData>();

	// Token: 0x04007475 RID: 29813
	private Dictionary<int, AiSearchWanderPointData> AiSearchWanderPointDataMap = new Dictionary<int, AiSearchWanderPointData>();

	// Token: 0x04007476 RID: 29814
	[Nullable(2)]
	private static IdlePerformModel _Instance;
}
