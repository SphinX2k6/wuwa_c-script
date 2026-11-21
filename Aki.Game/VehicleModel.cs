using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002862 RID: 10338
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class VehicleModel : ModelBase
{
	// Token: 0x0601A2D9 RID: 107225 RVA: 0x008183F0 File Offset: 0x008165F0
	protected override bool OnChangeMode()
	{
		foreach (ScenePlayerVehicleInfo scenePlayerVehicleInfo in this.PlayerVehicleInfo.Values)
		{
			ScenePlayerVehicleInfo scenePlayerVehicleInfo2 = scenePlayerVehicleInfo.DeepCopy();
			scenePlayerVehicleInfo2.VehicleCreatureId = 0L;
			scenePlayerVehicleInfo2.ExitType = ELeaveVehicleType.StandUp;
			this.UpdatePlayerVehicleData(scenePlayerVehicleInfo2);
			this.PassengerVehicleMap.Remove(scenePlayerVehicleInfo2.EntityCreatureId);
		}
		this.PlayerVehicleInfo.Clear();
		this.VehiclePlayerInfo.Clear();
		this.RideSharingInfoMap.Clear();
		this.IsReadyRiderSharing = false;
		this.IsForbidRiderSharing = false;
		return true;
	}

	// Token: 0x0601A2DA RID: 107226 RVA: 0x008184A0 File Offset: 0x008166A0
	protected override bool OnClear()
	{
		this.MaterialControllerHandles.Clear();
		return true;
	}

	// Token: 0x0601A2DB RID: 107227 RVA: 0x008184B0 File Offset: 0x008166B0
	public unsafe void UpdateAllPlayerVehicleData(IReadOnlyList<ScenePlayerInformation> playerInfoList)
	{
		this.PlayerVehicleInfo.Clear();
		this.VehiclePlayerInfo.Clear();
		this.PostUpdateAllVehicleEntityData();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Vehicle;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[VehicleModel.UpdateAllPlayerVehicleData] 开始刷新全量载具数据";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayerNum", playerInfoList.Count);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (ScenePlayerInformation scenePlayerInformation in playerInfoList)
		{
			ScenePlayerVehicleInfo scenePlayerVehicleInfo = new ScenePlayerVehicleInfo();
			scenePlayerVehicleInfo.PlayerId = scenePlayerInformation.PlayerId;
			this.PlayerVehicleInfo[scenePlayerInformation.PlayerId] = scenePlayerVehicleInfo;
			if (scenePlayerInformation.VehicleInfoPb != null)
			{
				SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(scenePlayerVehicleInfo.PlayerId);
				long? num;
				if (teamPlayerData == null)
				{
					num = null;
				}
				else
				{
					SceneTeamGroup currentGroup = teamPlayerData.GetCurrentGroup();
					if (currentGroup == null)
					{
						num = null;
					}
					else
					{
						SceneTeamRole currentRole = currentGroup.GetCurrentRole();
						num = ((currentRole != null) ? new long?(currentRole.CreatureDataId) : null);
					}
				}
				long? num2 = num;
				if (num2 == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Vehicle;
					ELogAuthor author2 = ELogAuthor.YJX;
					string message2 = "[VehicleModel.UpdateAllPlayerVehicleData] 刷新载具全量数据时无法获取对应PlayerId的CreatureId";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", scenePlayerInformation.PlayerId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleId", MathUtils.Instance.LongToNumber(scenePlayerInformation.VehicleInfoPb.EntityId));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Seat", scenePlayerInformation.VehicleInfoPb.SeatId);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				else
				{
					scenePlayerVehicleInfo.EntityCreatureId = num2.Value;
					scenePlayerVehicleInfo.VehicleCreatureId = MathUtils.Instance.LongToNumber(scenePlayerInformation.VehicleInfoPb.EntityId);
					scenePlayerVehicleInfo.Seat = scenePlayerInformation.VehicleInfoPb.SeatId;
					this.UpdatePlayerVehicleData(scenePlayerVehicleInfo);
				}
			}
		}
	}

	// Token: 0x0601A2DC RID: 107228 RVA: 0x008186D0 File Offset: 0x008168D0
	public void AddOtherPlayerVehicleData(int playerId)
	{
		ScenePlayerVehicleInfo scenePlayerVehicleInfo = new ScenePlayerVehicleInfo();
		scenePlayerVehicleInfo.PlayerId = playerId;
		this.PlayerVehicleInfo[playerId] = scenePlayerVehicleInfo;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Vehicle;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[VehicleModel.AddOtherPlayerVehicleData] 添加玩家载具信息";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayerId", playerId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601A2DD RID: 107229 RVA: 0x00818728 File Offset: 0x00816928
	public unsafe void RemoveOtherPlayerVehicleData(int playerId)
	{
		ScenePlayerVehicleInfo scenePlayerVehicleInfo = null;
		this.PlayerVehicleInfo.TryGetValue(playerId, out scenePlayerVehicleInfo);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Vehicle;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[VehicleModel.RemoveOtherPlayerVehicleData] 移除玩家载具信息";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", (scenePlayerVehicleInfo != null) ? new int?(scenePlayerVehicleInfo.PlayerId) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlayerCreatureId", (scenePlayerVehicleInfo != null) ? new long?(scenePlayerVehicleInfo.EntityCreatureId) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("VehicleCreatureId", (scenePlayerVehicleInfo != null) ? new long?(scenePlayerVehicleInfo.VehicleCreatureId) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Seat", (scenePlayerVehicleInfo != null) ? new int?(scenePlayerVehicleInfo.Seat) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		if (scenePlayerVehicleInfo != null && scenePlayerVehicleInfo.VehicleCreatureId != 0L)
		{
			ScenePlayerVehicleInfo scenePlayerVehicleInfo2 = new ScenePlayerVehicleInfo();
			scenePlayerVehicleInfo2.PlayerId = scenePlayerVehicleInfo.PlayerId;
			scenePlayerVehicleInfo2.EntityCreatureId = scenePlayerVehicleInfo.EntityCreatureId;
			scenePlayerVehicleInfo2.VehicleCreatureId = 0L;
			scenePlayerVehicleInfo2.Seat = scenePlayerVehicleInfo.Seat;
			this.UpdatePlayerVehicleData(scenePlayerVehicleInfo);
		}
		this.PlayerVehicleInfo.Remove(playerId);
	}

	// Token: 0x0601A2DE RID: 107230 RVA: 0x00818890 File Offset: 0x00816A90
	public unsafe void UpdatePlayerVehicleData(ScenePlayerVehicleInfo context)
	{
		ScenePlayerVehicleInfo scenePlayerVehicleInfo = this.PlayerVehicleInfo.GetValueOrDefault(context.PlayerId);
		if (scenePlayerVehicleInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[VehicleModel] 没有数据默认不在船上";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", context.PlayerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Seat", context.Seat);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			scenePlayerVehicleInfo = new ScenePlayerVehicleInfo();
			scenePlayerVehicleInfo.PlayerId = context.PlayerId;
			scenePlayerVehicleInfo.EntityCreatureId = context.EntityCreatureId;
			scenePlayerVehicleInfo.VehicleCreatureId = 0L;
			scenePlayerVehicleInfo.Seat = context.Seat;
			this.PlayerVehicleInfo[context.PlayerId] = scenePlayerVehicleInfo;
		}
		bool flag = context.VehicleCreatureId != 0L;
		if (!flag)
		{
			context.VehicleCreatureId = scenePlayerVehicleInfo.VehicleCreatureId;
			context.Seat = -1;
		}
		if (!flag && scenePlayerVehicleInfo.VehicleCreatureId == 0L)
		{
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Vehicle;
		ELogAuthor author2 = ELogAuthor.YJX;
		string message2 = "[VehicleModel.UpdateVehicleData] 更新载具数据";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PlayerId", context.PlayerId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PlayerCreatureId", context.EntityCreatureId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("VehicleCreatureId", context.VehicleCreatureId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("Seat", context.Seat);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		this.UpdateVehiclePlayerInfo(context);
		this.UpdatePlayerVehicleInfo(context);
		this.UpdateEntityVehicleData(context);
	}

	// Token: 0x0601A2DF RID: 107231 RVA: 0x00818A54 File Offset: 0x00816C54
	private unsafe void UpdateVehiclePlayerInfo(ScenePlayerVehicleInfo context)
	{
		bool flag = context.Seat != -1;
		HashSet<int> hashSet = this.VehiclePlayerInfo.GetValueOrDefault(context.VehicleCreatureId);
		if (flag)
		{
			if (hashSet == null)
			{
				hashSet = new HashSet<int>();
				this.VehiclePlayerInfo[context.VehicleCreatureId] = hashSet;
			}
			hashSet.Add(context.PlayerId);
			return;
		}
		if (hashSet == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[VehicleModel.UpdateVehiclePlayerInfo] 更新载具数据失败，重复退出载具";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", context.PlayerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlayerCreatureId", context.EntityCreatureId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("VehicleCreatureId", context.VehicleCreatureId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		hashSet.Remove(context.PlayerId);
		if (hashSet.Count == 0)
		{
			this.VehiclePlayerInfo.Remove(context.VehicleCreatureId);
		}
	}

	// Token: 0x0601A2E0 RID: 107232 RVA: 0x00818B64 File Offset: 0x00816D64
	private void UpdatePlayerVehicleInfo(ScenePlayerVehicleInfo context)
	{
		bool flag = context.Seat != -1;
		ScenePlayerVehicleInfo scenePlayerVehicleInfo = this.PlayerVehicleInfo[context.PlayerId];
		if (flag && scenePlayerVehicleInfo.VehicleCreatureId != 0L && (scenePlayerVehicleInfo.EntityCreatureId != context.EntityCreatureId || scenePlayerVehicleInfo.VehicleCreatureId != context.VehicleCreatureId))
		{
			ScenePlayerVehicleInfo scenePlayerVehicleInfo2 = scenePlayerVehicleInfo.DeepCopy();
			scenePlayerVehicleInfo2.Seat = -1;
			scenePlayerVehicleInfo2.ExitType = ELeaveVehicleType.StandUp;
			this.UpdateVehiclePlayerInfo(scenePlayerVehicleInfo2);
		}
		scenePlayerVehicleInfo.EntityCreatureId = context.EntityCreatureId;
		scenePlayerVehicleInfo.VehicleCreatureId = (flag ? context.VehicleCreatureId : 0L);
		scenePlayerVehicleInfo.Seat = context.Seat;
		scenePlayerVehicleInfo.ExitType = context.ExitType;
	}

	// Token: 0x0601A2E1 RID: 107233 RVA: 0x00818C0C File Offset: 0x00816E0C
	public void UpdateEntityVehicleData(EntityVehicleInfo context)
	{
		long entityCreatureId = context.EntityCreatureId;
		EntityVehicleInfo valueOrDefault = this.PassengerVehicleMap.GetValueOrDefault(entityCreatureId);
		if (context.Seat == -1)
		{
			bool flag;
			if (valueOrDefault == null)
			{
				flag = true;
			}
			else
			{
				long vehicleCreatureId = valueOrDefault.VehicleCreatureId;
				flag = false;
			}
			if (flag || valueOrDefault.VehicleCreatureId == 0L)
			{
				return;
			}
			context.VehicleCreatureId = valueOrDefault.VehicleCreatureId;
		}
		this.UpdateVehicleEntityInfo(context);
		this.UpdateEntityVehicleInfo(context);
	}

	// Token: 0x0601A2E2 RID: 107234 RVA: 0x00818C70 File Offset: 0x00816E70
	public void UpdateEntityVehicleInfo(EntityVehicleInfo context)
	{
		bool flag = context.Seat != -1;
		EntityVehicleInfo entityVehicleInfo = this.PassengerVehicleMap.GetValueOrDefault(context.EntityCreatureId);
		if (entityVehicleInfo == null)
		{
			entityVehicleInfo = new EntityVehicleInfo();
			this.PassengerVehicleMap[context.EntityCreatureId] = entityVehicleInfo;
		}
		else if (flag && entityVehicleInfo.VehicleCreatureId != 0L && entityVehicleInfo.VehicleCreatureId != context.VehicleCreatureId)
		{
			EntityVehicleInfo entityVehicleInfo2 = entityVehicleInfo.DeepCopy();
			entityVehicleInfo2.Seat = -1;
			entityVehicleInfo2.ExitType = ELeaveVehicleType.StandUp;
			this.UpdateVehicleEntityInfo(entityVehicleInfo2);
		}
		entityVehicleInfo.EntityCreatureId = context.EntityCreatureId;
		entityVehicleInfo.VehicleCreatureId = (flag ? context.VehicleCreatureId : 0L);
		entityVehicleInfo.Seat = context.Seat;
		entityVehicleInfo.ExitType = context.ExitType;
		this.PassengerVehicleMap[context.EntityCreatureId] = context;
	}

	// Token: 0x0601A2E3 RID: 107235 RVA: 0x00818D38 File Offset: 0x00816F38
	public unsafe void UpdateVehicleEntityInfo(EntityVehicleInfo context)
	{
		bool flag = context.Seat != -1;
		Dictionary<long, EntityVehicleInfo> dictionary = this.VehiclePassengerMap.GetValueOrDefault(context.VehicleCreatureId);
		if (flag)
		{
			if (dictionary == null)
			{
				dictionary = new Dictionary<long, EntityVehicleInfo>();
				this.VehiclePassengerMap[context.VehicleCreatureId] = dictionary;
			}
			dictionary[context.EntityCreatureId] = context;
			return;
		}
		if (dictionary == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[VehicleModel.UpdateVehicleEntityInfo] 更新载具数据失败，重复退出载具";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityCreatureId", context.EntityCreatureId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleCreatureId", context.VehicleCreatureId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		dictionary.Remove(context.EntityCreatureId);
		if (dictionary.Count == 0)
		{
			this.VehiclePlayerInfo.Remove(context.VehicleCreatureId);
		}
	}

	// Token: 0x0601A2E4 RID: 107236 RVA: 0x00818E24 File Offset: 0x00817024
	public void PostUpdateAllVehicleEntityData()
	{
		foreach (EntityVehicleInfo context in this.PassengerVehicleMap.Values)
		{
			this.PostUpdateVehicleEntityData(context);
		}
	}

	// Token: 0x0601A2E5 RID: 107237 RVA: 0x00818E7C File Offset: 0x0081707C
	public void PostUpdateVehicleEntityData(EntityVehicleInfo context)
	{
		if (context.Seat != -1)
		{
			return;
		}
		Dictionary<long, EntityVehicleInfo> valueOrDefault = this.VehiclePassengerMap.GetValueOrDefault(context.VehicleCreatureId);
		if (valueOrDefault != null)
		{
			valueOrDefault.Remove(context.EntityCreatureId);
		}
		if (valueOrDefault == null || valueOrDefault.Count == 0)
		{
			this.VehiclePassengerMap.Remove(context.VehicleCreatureId);
		}
		this.PassengerVehicleMap.Remove(context.EntityCreatureId);
	}

	// Token: 0x0601A2E6 RID: 107238 RVA: 0x00818EEC File Offset: 0x008170EC
	public List<ScenePlayerVehicleInfo> GetVehiclePlayerData(long vehicleCreatureId)
	{
		List<ScenePlayerVehicleInfo> list = new List<ScenePlayerVehicleInfo>();
		HashSet<int> valueOrDefault = this.VehiclePlayerInfo.GetValueOrDefault(vehicleCreatureId);
		if (valueOrDefault == null)
		{
			return list;
		}
		foreach (int key in valueOrDefault)
		{
			list.Add(this.PlayerVehicleInfo[key]);
		}
		return list;
	}

	// Token: 0x0601A2E7 RID: 107239 RVA: 0x00818F60 File Offset: 0x00817160
	[NullableContext(2)]
	public ScenePlayerVehicleInfo GetPlayerVehicleData(int playerId)
	{
		return this.PlayerVehicleInfo.GetValueOrDefault(playerId);
	}

	// Token: 0x0601A2E8 RID: 107240 RVA: 0x00818F70 File Offset: 0x00817170
	public List<EntityVehicleInfo> GetVehicleEntityData(long creatureId)
	{
		List<EntityVehicleInfo> list = new List<EntityVehicleInfo>();
		Dictionary<long, EntityVehicleInfo> valueOrDefault = this.VehiclePassengerMap.GetValueOrDefault(creatureId);
		if (valueOrDefault == null)
		{
			return list;
		}
		foreach (KeyValuePair<long, EntityVehicleInfo> keyValuePair in valueOrDefault)
		{
			list.Add(keyValuePair.Value);
		}
		return list;
	}

	// Token: 0x0601A2E9 RID: 107241 RVA: 0x00818FE0 File Offset: 0x008171E0
	[NullableContext(2)]
	public EntityVehicleInfo GetEntityVehicleData(long creatureId)
	{
		return this.PassengerVehicleMap.GetValueOrDefault(creatureId);
	}

	// Token: 0x0601A2EA RID: 107242 RVA: 0x00818FF0 File Offset: 0x008171F0
	public void UpdateKeepDrivingInfo(float delta, VehicleMoveComponent moveComp)
	{
		if (this.KeepDrivingInfoList == null)
		{
			return;
		}
		foreach (KeyValuePair<int, KeepDrivingInfo> keyValuePair in this.KeepDrivingInfoList)
		{
			if ((keyValuePair.Value.CheckCondition == null || keyValuePair.Value.CheckCondition()) && keyValuePair.Value.UpdateDrivingInfo(delta, moveComp) && keyValuePair.Value.RunAction != null)
			{
				keyValuePair.Value.RunAction();
			}
		}
	}

	// Token: 0x0601A2EB RID: 107243 RVA: 0x00819098 File Offset: 0x00817298
	public int AddKeepDrivingInfo(KeepDrivingInfo info)
	{
		if (this.KeepDrivingInfoList == null)
		{
			this.KeepDrivingInfoList = new Dictionary<int, KeepDrivingInfo>();
		}
		this.Uid++;
		this.KeepDrivingInfoList[this.Uid] = info;
		return this.Uid;
	}

	// Token: 0x0601A2EC RID: 107244 RVA: 0x008190D3 File Offset: 0x008172D3
	public void RemoveKeepDrivingInfo(int index)
	{
		Dictionary<int, KeepDrivingInfo> keepDrivingInfoList = this.KeepDrivingInfoList;
		if (keepDrivingInfoList != null && keepDrivingInfoList.ContainsKey(index))
		{
			this.KeepDrivingInfoList.Remove(index);
		}
	}

	// Token: 0x17002AB7 RID: 10935
	// (get) Token: 0x0601A2ED RID: 107245 RVA: 0x008190F7 File Offset: 0x008172F7
	public static VehicleModel Instance
	{
		get
		{
			return VehicleModel._Instance;
		}
	}

	// Token: 0x0601A2EE RID: 107246 RVA: 0x008190FE File Offset: 0x008172FE
	public static VehicleModel GetOrCreateInstance()
	{
		if (VehicleModel._Instance == null)
		{
			VehicleModel.CreateInstance();
		}
		return VehicleModel._Instance;
	}

	// Token: 0x0601A2EF RID: 107247 RVA: 0x00819112 File Offset: 0x00817312
	public static bool CreateInstance()
	{
		if (VehicleModel._Instance != null)
		{
			return true;
		}
		VehicleModel._Instance = new VehicleModel();
		return true;
	}

	// Token: 0x0601A2F0 RID: 107248 RVA: 0x00819128 File Offset: 0x00817328
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601A2F1 RID: 107249 RVA: 0x0081912A File Offset: 0x0081732A
	public static void ResetStaticDefaultValue()
	{
		VehicleModel._Instance = null;
	}

	// Token: 0x0601A2F2 RID: 107250 RVA: 0x00819132 File Offset: 0x00817332
	static VehicleModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VehicleModel.CreateStaticDefaultValue), new Action(VehicleModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400E5CA RID: 58826
	public Dictionary<int, ScenePlayerVehicleInfo> PlayerVehicleInfo = new Dictionary<int, ScenePlayerVehicleInfo>();

	// Token: 0x0400E5CB RID: 58827
	public Dictionary<long, HashSet<int>> VehiclePlayerInfo = new Dictionary<long, HashSet<int>>();

	// Token: 0x0400E5CC RID: 58828
	public Dictionary<long, EntityVehicleInfo> PassengerVehicleMap = new Dictionary<long, EntityVehicleInfo>();

	// Token: 0x0400E5CD RID: 58829
	public Dictionary<long, Dictionary<long, EntityVehicleInfo>> VehiclePassengerMap = new Dictionary<long, Dictionary<long, EntityVehicleInfo>>();

	// Token: 0x0400E5CE RID: 58830
	public bool IsReadyRiderSharing;

	// Token: 0x0400E5CF RID: 58831
	public bool IsForbidRiderSharing;

	// Token: 0x0400E5D0 RID: 58832
	public Dictionary<int, VehicleRideSharingInfo> RideSharingInfoMap = new Dictionary<int, VehicleRideSharingInfo>();

	// Token: 0x0400E5D1 RID: 58833
	public HashSet<int> MaterialControllerHandles = new HashSet<int>();

	// Token: 0x0400E5D2 RID: 58834
	private int Uid;

	// Token: 0x0400E5D3 RID: 58835
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, KeepDrivingInfo> KeepDrivingInfoList;

	// Token: 0x0400E5D4 RID: 58836
	[Nullable(2)]
	private static VehicleModel _Instance;
}
