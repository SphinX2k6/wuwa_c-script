using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001436 RID: 5174
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class IdlePerformModel : ModelBase
{
	// Token: 0x0600CDDB RID: 52699 RVA: 0x003D410B File Offset: 0x003D230B
	public void AccumulateIdleTime(float delta)
	{
		if (delta <= 0f)
		{
			return;
		}
		this.IdleTimeInternal += delta;
	}

	// Token: 0x0600CDDC RID: 52700 RVA: 0x003D4124 File Offset: 0x003D2324
	public void ResetIdleTime()
	{
		this.IdleTimeInternal = 0f;
	}

	// Token: 0x0600CDDD RID: 52701 RVA: 0x003D4131 File Offset: 0x003D2331
	public float GetIdleTime()
	{
		return this.IdleTimeInternal;
	}

	// Token: 0x0600CDDE RID: 52702 RVA: 0x003D4139 File Offset: 0x003D2339
	public bool IsIdle()
	{
		return this.IdleTimeInternal > 0f;
	}

	// Token: 0x0600CDDF RID: 52703 RVA: 0x003D4148 File Offset: 0x003D2348
	protected override bool OnInit()
	{
		this.IdleTimeInternal = 0f;
		this.GazeAwarenessDataMap.Clear();
		this.AiNoMoveDataMap.Clear();
		this.AiSearchWanderPointDataMap.Clear();
		return true;
	}

	// Token: 0x0600CDE0 RID: 52704 RVA: 0x003D4177 File Offset: 0x003D2377
	protected override bool OnClear()
	{
		this.IdleTimeInternal = 0f;
		this.GazeAwarenessDataMap.Clear();
		this.AiNoMoveDataMap.Clear();
		this.AiSearchWanderPointDataMap.Clear();
		return true;
	}

	// Token: 0x0600CDE1 RID: 52705 RVA: 0x003D41A6 File Offset: 0x003D23A6
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

	// Token: 0x0600CDE2 RID: 52706 RVA: 0x003D41CC File Offset: 0x003D23CC
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

	// Token: 0x0600CDE3 RID: 52707 RVA: 0x003D424C File Offset: 0x003D244C
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

	// Token: 0x0600CDE4 RID: 52708 RVA: 0x003D42C0 File Offset: 0x003D24C0
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

	// Token: 0x0600CDE5 RID: 52709 RVA: 0x003D4330 File Offset: 0x003D2530
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

	// Token: 0x0600CDE6 RID: 52710 RVA: 0x003D4390 File Offset: 0x003D2590
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

	// Token: 0x0600CDE7 RID: 52711 RVA: 0x003D4448 File Offset: 0x003D2648
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

	// Token: 0x0600CDE8 RID: 52712 RVA: 0x003D4484 File Offset: 0x003D2684
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

	// Token: 0x0600CDE9 RID: 52713 RVA: 0x003D44D4 File Offset: 0x003D26D4
	public bool CheckAiNoMoveTime(int entityId, float timeMs, EAiNoMoveResetCondition resetConditionMask = EAiNoMoveResetCondition.None)
	{
		AiNoMoveData orCreateAiNoMoveData = this.GetOrCreateAiNoMoveData(entityId);
		orCreateAiNoMoveData.UpdateResetConditionMask(resetConditionMask);
		return orCreateAiNoMoveData.GetNoMoveTime() >= (double)timeMs;
	}

	// Token: 0x0600CDEA RID: 52714 RVA: 0x003D44F0 File Offset: 0x003D26F0
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

	// Token: 0x0600CDEB RID: 52715 RVA: 0x003D45E4 File Offset: 0x003D27E4
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

	// Token: 0x0600CDEC RID: 52716 RVA: 0x003D461C File Offset: 0x003D281C
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

	// Token: 0x0600CDED RID: 52717 RVA: 0x003D466C File Offset: 0x003D286C
	public bool HasAiSearchedWanderPointId(int entityId, int wanderPointId)
	{
		AiSearchWanderPointData aiSearchWanderPointData;
		return this.AiSearchWanderPointDataMap.TryGetValue(entityId, out aiSearchWanderPointData) && aiSearchWanderPointData.HasSearchedWanderPointId(wanderPointId);
	}

	// Token: 0x17001364 RID: 4964
	// (get) Token: 0x0600CDEE RID: 52718 RVA: 0x003D4692 File Offset: 0x003D2892
	public static IdlePerformModel Instance
	{
		get
		{
			return IdlePerformModel._Instance;
		}
	}

	// Token: 0x0600CDEF RID: 52719 RVA: 0x003D4699 File Offset: 0x003D2899
	public static IdlePerformModel GetOrCreateInstance()
	{
		if (IdlePerformModel._Instance == null)
		{
			IdlePerformModel.CreateInstance();
		}
		return IdlePerformModel._Instance;
	}

	// Token: 0x0600CDF0 RID: 52720 RVA: 0x003D46AD File Offset: 0x003D28AD
	public static bool CreateInstance()
	{
		if (IdlePerformModel._Instance != null)
		{
			return true;
		}
		IdlePerformModel._Instance = new IdlePerformModel();
		return true;
	}

	// Token: 0x0600CDF1 RID: 52721 RVA: 0x003D46C3 File Offset: 0x003D28C3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CDF2 RID: 52722 RVA: 0x003D46C5 File Offset: 0x003D28C5
	public static void ResetStaticDefaultValue()
	{
		IdlePerformModel._Instance = null;
	}

	// Token: 0x0600CDF3 RID: 52723 RVA: 0x003D46CD File Offset: 0x003D28CD
	static IdlePerformModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(IdlePerformModel.CreateStaticDefaultValue), new Action(IdlePerformModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007553 RID: 30035
	private float IdleTimeInternal;

	// Token: 0x04007554 RID: 30036
	private Dictionary<int, IdleGazeAwarenessData> GazeAwarenessDataMap = new Dictionary<int, IdleGazeAwarenessData>();

	// Token: 0x04007555 RID: 30037
	private Dictionary<int, AiNoMoveData> AiNoMoveDataMap = new Dictionary<int, AiNoMoveData>();

	// Token: 0x04007556 RID: 30038
	private Dictionary<int, AiSearchWanderPointData> AiSearchWanderPointDataMap = new Dictionary<int, AiSearchWanderPointData>();

	// Token: 0x04007557 RID: 30039
	[Nullable(2)]
	private static IdlePerformModel _Instance;
}
