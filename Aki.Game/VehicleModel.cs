using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020032F0 RID: 13040
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class VehicleModel : ModelBase
{
	// Token: 0x0601C614 RID: 116244 RVA: 0x007F1EC4 File Offset: 0x007F00C4
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

	// Token: 0x0601C615 RID: 116245 RVA: 0x007F1F74 File Offset: 0x007F0174
	protected override bool OnClear()
	{
		this.MaterialControllerHandles.Clear();
		return true;
	}

	// Token: 0x0601C616 RID: 116246 RVA: 0x007F1F84 File Offset: 0x007F0184
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

	// Token: 0x0601C617 RID: 116247 RVA: 0x007F21A4 File Offset: 0x007F03A4
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

	// Token: 0x0601C618 RID: 116248 RVA: 0x007F21FC File Offset: 0x007F03FC
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

	// Token: 0x0601C619 RID: 116249 RVA: 0x007F2364 File Offset: 0x007F0564
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

	// Token: 0x0601C61A RID: 116250 RVA: 0x007F2528 File Offset: 0x007F0728
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

	// Token: 0x0601C61B RID: 116251 RVA: 0x007F2638 File Offset: 0x007F0838
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

	// Token: 0x0601C61C RID: 116252 RVA: 0x007F26E0 File Offset: 0x007F08E0
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

	// Token: 0x0601C61D RID: 116253 RVA: 0x007F2744 File Offset: 0x007F0944
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

	// Token: 0x0601C61E RID: 116254 RVA: 0x007F280C File Offset: 0x007F0A0C
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

	// Token: 0x0601C61F RID: 116255 RVA: 0x007F28F8 File Offset: 0x007F0AF8
	public void PostUpdateAllVehicleEntityData()
	{
		foreach (EntityVehicleInfo context in this.PassengerVehicleMap.Values)
		{
			this.PostUpdateVehicleEntityData(context);
		}
	}

	// Token: 0x0601C620 RID: 116256 RVA: 0x007F2950 File Offset: 0x007F0B50
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

	// Token: 0x0601C621 RID: 116257 RVA: 0x007F29C0 File Offset: 0x007F0BC0
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

	// Token: 0x0601C622 RID: 116258 RVA: 0x007F2A34 File Offset: 0x007F0C34
	[NullableContext(2)]
	public ScenePlayerVehicleInfo GetPlayerVehicleData(int playerId)
	{
		return this.PlayerVehicleInfo.GetValueOrDefault(playerId);
	}

	// Token: 0x0601C623 RID: 116259 RVA: 0x007F2A44 File Offset: 0x007F0C44
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

	// Token: 0x0601C624 RID: 116260 RVA: 0x007F2AB4 File Offset: 0x007F0CB4
	[NullableContext(2)]
	public EntityVehicleInfo GetEntityVehicleData(long creatureId)
	{
		return this.PassengerVehicleMap.GetValueOrDefault(creatureId);
	}

	// Token: 0x0601C625 RID: 116261 RVA: 0x007F2AC4 File Offset: 0x007F0CC4
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

	// Token: 0x0601C626 RID: 116262 RVA: 0x007F2B6C File Offset: 0x007F0D6C
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

	// Token: 0x0601C627 RID: 116263 RVA: 0x007F2BA7 File Offset: 0x007F0DA7
	public void RemoveKeepDrivingInfo(int index)
	{
		Dictionary<int, KeepDrivingInfo> keepDrivingInfoList = this.KeepDrivingInfoList;
		if (keepDrivingInfoList != null && keepDrivingInfoList.ContainsKey(index))
		{
			this.KeepDrivingInfoList.Remove(index);
		}
	}

	// Token: 0x17002746 RID: 10054
	// (get) Token: 0x0601C628 RID: 116264 RVA: 0x007F2BCB File Offset: 0x007F0DCB
	public static VehicleModel Instance
	{
		get
		{
			return VehicleModel._Instance;
		}
	}

	// Token: 0x0601C629 RID: 116265 RVA: 0x007F2BD2 File Offset: 0x007F0DD2
	public static VehicleModel GetOrCreateInstance()
	{
		if (VehicleModel._Instance == null)
		{
			VehicleModel.CreateInstance();
		}
		return VehicleModel._Instance;
	}

	// Token: 0x0601C62A RID: 116266 RVA: 0x007F2BE6 File Offset: 0x007F0DE6
	public static bool CreateInstance()
	{
		if (VehicleModel._Instance != null)
		{
			return true;
		}
		VehicleModel._Instance = new VehicleModel();
		return true;
	}

	// Token: 0x0601C62B RID: 116267 RVA: 0x007F2BFC File Offset: 0x007F0DFC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601C62C RID: 116268 RVA: 0x007F2BFE File Offset: 0x007F0DFE
	public static void ResetStaticDefaultValue()
	{
		VehicleModel._Instance = null;
	}

	// Token: 0x0601C62D RID: 116269 RVA: 0x007F2C06 File Offset: 0x007F0E06
	static VehicleModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VehicleModel.CreateStaticDefaultValue), new Action(VehicleModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400E11F RID: 57631
	public Dictionary<int, ScenePlayerVehicleInfo> PlayerVehicleInfo = new Dictionary<int, ScenePlayerVehicleInfo>();

	// Token: 0x0400E120 RID: 57632
	public Dictionary<long, HashSet<int>> VehiclePlayerInfo = new Dictionary<long, HashSet<int>>();

	// Token: 0x0400E121 RID: 57633
	public Dictionary<long, EntityVehicleInfo> PassengerVehicleMap = new Dictionary<long, EntityVehicleInfo>();

	// Token: 0x0400E122 RID: 57634
	public Dictionary<long, Dictionary<long, EntityVehicleInfo>> VehiclePassengerMap = new Dictionary<long, Dictionary<long, EntityVehicleInfo>>();

	// Token: 0x0400E123 RID: 57635
	public bool IsReadyRiderSharing;

	// Token: 0x0400E124 RID: 57636
	public bool IsForbidRiderSharing;

	// Token: 0x0400E125 RID: 57637
	public Dictionary<int, VehicleRideSharingInfo> RideSharingInfoMap = new Dictionary<int, VehicleRideSharingInfo>();

	// Token: 0x0400E126 RID: 57638
	public HashSet<int> MaterialControllerHandles = new HashSet<int>();

	// Token: 0x0400E127 RID: 57639
	private int Uid;

	// Token: 0x0400E128 RID: 57640
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, KeepDrivingInfo> KeepDrivingInfoList;

	// Token: 0x0400E129 RID: 57641
	[Nullable(2)]
	private static VehicleModel _Instance;
}
