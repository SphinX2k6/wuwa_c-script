using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003201 RID: 12801
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class NpcVehicleRiderModel : ModelBase
{
	// Token: 0x0601B9D2 RID: 113106 RVA: 0x00795211 File Offset: 0x00793411
	protected override bool OnClear()
	{
		this.FreeVehicleSet.Clear();
		this.VehicleToNpcInfoMap.Clear();
		this.TmpNpcEntityIdList.Clear();
		return true;
	}

	// Token: 0x0601B9D3 RID: 113107 RVA: 0x00795235 File Offset: 0x00793435
	public void AddFreeVehicle(int vehicleEntityId, int seatCount)
	{
		this.RegisterVehicle(vehicleEntityId, seatCount);
	}

	// Token: 0x0601B9D4 RID: 113108 RVA: 0x0079523F File Offset: 0x0079343F
	public void RegisterVehicle(int vehicleEntityId, int seatCount)
	{
		if (vehicleEntityId == 0)
		{
			return;
		}
		this.CreateVehicleInfo(vehicleEntityId, seatCount).SeatCount = seatCount;
		this.RefreshVehicleFreeState(vehicleEntityId);
	}

	// Token: 0x0601B9D5 RID: 113109 RVA: 0x0079525A File Offset: 0x0079345A
	public void RemoveFreeVehicle(int vehicleEntityId)
	{
		this.RemoveVehicle(vehicleEntityId);
	}

	// Token: 0x0601B9D6 RID: 113110 RVA: 0x00795264 File Offset: 0x00793464
	private NpcVehicleInfo CreateVehicleInfo(int vehicleEntityId, int seatCount)
	{
		NpcVehicleInfo npcVehicleInfo = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		if (npcVehicleInfo == null)
		{
			npcVehicleInfo = new NpcVehicleInfo(vehicleEntityId, seatCount);
			this.VehicleToNpcInfoMap[vehicleEntityId] = npcVehicleInfo;
		}
		else
		{
			npcVehicleInfo.SeatCount = seatCount;
		}
		return npcVehicleInfo;
	}

	// Token: 0x0601B9D7 RID: 113111 RVA: 0x007952A0 File Offset: 0x007934A0
	private void AddFreeVehicleInternal(int vehicleEntityId)
	{
		if (this.FreeVehicleSet.Contains(vehicleEntityId))
		{
			return;
		}
		this.FreeVehicleSet.Add(vehicleEntityId);
	}

	// Token: 0x0601B9D8 RID: 113112 RVA: 0x007952C0 File Offset: 0x007934C0
	public unsafe int? TryReserveVehicleSeat(int npcEntityId, int vehicleEntityId)
	{
		if (npcEntityId == 0 || vehicleEntityId == 0)
		{
			return null;
		}
		int? ridingVehicle = this.GetRidingVehicle(npcEntityId);
		if (ridingVehicle != null)
		{
			int? num = ridingVehicle;
			if (!(num.GetValueOrDefault() == vehicleEntityId & num != null))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Vehicle;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[NpcVehicleRiderModel] NPC在已经预占或乘坐一个载具的情况下, 尝试预占另一个载具";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OldVehicleEntityId", ridingVehicle);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NewVehicleEntityId", vehicleEntityId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return null;
			}
		}
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		if (valueOrDefault == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[NpcVehicleRiderModel] 预占载具失败, 载具未注册";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("VehicleEntityId", vehicleEntityId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return null;
		}
		int? num2 = valueOrDefault.ReserveNpc(npcEntityId);
		if (num2 == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Vehicle;
			ELogAuthor author3 = ELogAuthor.ZJL;
			string message3 = "[NpcVehicleRiderModel] 预占载具失败, 载具没有可用座位但仍Free状态, 可能数据异常";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("VehicleEntityId", vehicleEntityId);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			this.RefreshVehicleFreeState(vehicleEntityId);
			return null;
		}
		this.RefreshVehicleFreeState(vehicleEntityId);
		Log instance4 = Log.Instance;
		ELogModule module4 = ELogModule.Vehicle;
		ELogAuthor author4 = ELogAuthor.ZJL;
		string message4 = "[NpcVehicleRiderModel] 预占NPC与载具座位成功";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("VehicleEntityId", vehicleEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("Seat", num2);
		instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
		return num2;
	}

	// Token: 0x0601B9D9 RID: 113113 RVA: 0x0079551C File Offset: 0x0079371C
	public bool ReserveVehicle(int npcEntityId, int vehicleEntityId)
	{
		return this.TryReserveVehicleSeat(npcEntityId, vehicleEntityId) != null;
	}

	// Token: 0x0601B9DA RID: 113114 RVA: 0x0079553C File Offset: 0x0079373C
	public unsafe int? ReleaseVehicle(int npcEntityId, int vehicleEntityId = 0)
	{
		NpcVehicleInfo npcVehicleInfo = (vehicleEntityId != 0) ? this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId) : this.FindVehicleInfoByNpc(npcEntityId);
		if (npcVehicleInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[NpcVehicleRiderModel] 释放载具失败, NPC没有预占或乘坐任何载具";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		int? num = npcVehicleInfo.UnregisterNpc(npcEntityId);
		if (num == null)
		{
			return null;
		}
		this.RefreshVehicleFreeState(npcVehicleInfo.VehicleEntityId);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Vehicle;
		ELogAuthor author2 = ELogAuthor.ZJL;
		string message2 = "[NpcVehicleRiderModel] 解绑NPC与载具成功";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", npcVehicleInfo.VehicleEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Seat", num);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		return num;
	}

	// Token: 0x0601B9DB RID: 113115 RVA: 0x0079564C File Offset: 0x0079384C
	public unsafe List<int> RemoveVehicle(int vehicleEntityId)
	{
		List<int> list = new List<int>();
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		if (valueOrDefault != null)
		{
			valueOrDefault.GetAllNpcEntityIds(this.TmpNpcEntityIdList);
			foreach (int num in this.TmpNpcEntityIdList)
			{
				list.Add(num);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Vehicle;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[NpcVehicleRiderModel] 移除载具，自动解绑NPC";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", vehicleEntityId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		this.VehicleToNpcInfoMap.Remove(vehicleEntityId);
		this.RemoveFreeVehicleInternal(vehicleEntityId);
		return list;
	}

	// Token: 0x0601B9DC RID: 113116 RVA: 0x0079573C File Offset: 0x0079393C
	public int? GetRidingVehicle(int npcEntityId)
	{
		NpcVehicleInfo npcVehicleInfo = this.FindVehicleInfoByNpc(npcEntityId);
		if (npcVehicleInfo == null)
		{
			return null;
		}
		return new int?(npcVehicleInfo.VehicleEntityId);
	}

	// Token: 0x0601B9DD RID: 113117 RVA: 0x00795768 File Offset: 0x00793968
	public int? GetRideSeat(int npcEntityId, int vehicleEntityId = 0)
	{
		if (vehicleEntityId != 0)
		{
			NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
			if (valueOrDefault == null)
			{
				return null;
			}
			return valueOrDefault.GetSeatByNpc(npcEntityId);
		}
		else
		{
			NpcVehicleInfo npcVehicleInfo = this.FindVehicleInfoByNpc(npcEntityId);
			if (npcVehicleInfo == null)
			{
				return null;
			}
			return npcVehicleInfo.GetSeatByNpc(npcEntityId);
		}
	}

	// Token: 0x0601B9DE RID: 113118 RVA: 0x007957B4 File Offset: 0x007939B4
	public bool SetNpcVehicleRideState(int npcEntityId, ENpcVehicleRideState state)
	{
		if (state == ENpcVehicleRideState.None)
		{
			return this.ReleaseVehicle(npcEntityId, 0) != null;
		}
		NpcVehicleInfo npcVehicleInfo = this.FindVehicleInfoByNpc(npcEntityId);
		if (npcVehicleInfo == null || !npcVehicleInfo.SetNpcRideState(npcEntityId, state))
		{
			return false;
		}
		this.RefreshVehicleFreeState(npcVehicleInfo.VehicleEntityId);
		return true;
	}

	// Token: 0x0601B9DF RID: 113119 RVA: 0x007957FF File Offset: 0x007939FF
	public ENpcVehicleRideState GetNpcVehicleRideState(int npcEntityId)
	{
		NpcVehicleInfo npcVehicleInfo = this.FindVehicleInfoByNpc(npcEntityId);
		if (npcVehicleInfo == null)
		{
			return ENpcVehicleRideState.None;
		}
		return npcVehicleInfo.GetNpcRideState(npcEntityId);
	}

	// Token: 0x0601B9E0 RID: 113120 RVA: 0x00795814 File Offset: 0x00793A14
	public bool SetNpcTargetSplinePbDataId(int npcEntityId, int splinePbDataId)
	{
		NpcVehicleInfo npcVehicleInfo = this.FindVehicleInfoByNpc(npcEntityId);
		return npcVehicleInfo != null && npcVehicleInfo.SetNpcTargetSplinePbDataId(npcEntityId, splinePbDataId);
	}

	// Token: 0x0601B9E1 RID: 113121 RVA: 0x0079582C File Offset: 0x00793A2C
	public int? GetNpcTargetSplinePbDataId(int npcEntityId)
	{
		NpcVehicleInfo npcVehicleInfo = this.FindVehicleInfoByNpc(npcEntityId);
		if (npcVehicleInfo == null)
		{
			return null;
		}
		return npcVehicleInfo.GetNpcTargetSplinePbDataId(npcEntityId);
	}

	// Token: 0x0601B9E2 RID: 113122 RVA: 0x00795854 File Offset: 0x00793A54
	public bool GetVehicleIsWaitingNpc(int vehicleEntityId, int checkState)
	{
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		if (valueOrDefault == null)
		{
			return false;
		}
		foreach (NpcSeatInfo npcSeatInfo in valueOrDefault.NpcSeatInfoList)
		{
			if (npcSeatInfo.RideState == ENpcVehicleRideState.MoveToVehicle && checkState == 0)
			{
				return true;
			}
			if (npcSeatInfo.RideState == ENpcVehicleRideState.WaitingToDismount && checkState == 1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601B9E3 RID: 113123 RVA: 0x007958D8 File Offset: 0x00793AD8
	public bool IsVehicleMovingToTarget(int vehicleEntityId)
	{
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		return valueOrDefault != null && valueOrDefault.IsMovingToTarget();
	}

	// Token: 0x0601B9E4 RID: 113124 RVA: 0x007958F4 File Offset: 0x00793AF4
	public int? GetAvailableRouteNpc(int vehicleEntityId)
	{
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		if (valueOrDefault == null)
		{
			return null;
		}
		return valueOrDefault.GetAvailableRouteNpcEntityId();
	}

	// Token: 0x0601B9E5 RID: 113125 RVA: 0x00795920 File Offset: 0x00793B20
	public unsafe int? ActivateNpcRouteBySpline(int vehicleEntityId, int splinePbDataId)
	{
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		if (valueOrDefault == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[NpcVehicleRiderModel] 激活样条路线失败, 载具未注册";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("VehicleEntityId", vehicleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplinePbDataId", splinePbDataId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		int? npcEntityIdBySplinePbDataId = valueOrDefault.GetNpcEntityIdBySplinePbDataId(splinePbDataId);
		if (npcEntityIdBySplinePbDataId == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[NpcVehicleRiderModel] 激活样条路线失败, 该样条在载具上无对应乘客";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("VehicleEntityId", vehicleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SplinePbDataId", splinePbDataId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return null;
		}
		if (!valueOrDefault.SetNpcRideState(npcEntityIdBySplinePbDataId.Value, ENpcVehicleRideState.MoveToTargetPoint))
		{
			return null;
		}
		this.RefreshVehicleFreeState(vehicleEntityId);
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.Vehicle;
		ELogAuthor author3 = ELogAuthor.ZJL;
		string message3 = "[NpcVehicleRiderModel] 激活样条路线, NPC进入前往目标点状态";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityIdBySplinePbDataId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("VehicleEntityId", vehicleEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("SplinePbDataId", splinePbDataId);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
		return npcEntityIdBySplinePbDataId;
	}

	// Token: 0x0601B9E6 RID: 113126 RVA: 0x00795AC4 File Offset: 0x00793CC4
	public unsafe void RefreshVehicleRuntimeInfo(int vehicleEntityId)
	{
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		if (valueOrDefault == null)
		{
			this.RemoveFreeVehicleInternal(vehicleEntityId);
			return;
		}
		foreach (int num in valueOrDefault.RemoveInvalidNpcInfos())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[NpcVehicleRiderModel] 刷新载具时移除失效NPC占位";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", vehicleEntityId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.RefreshVehicleFreeState(vehicleEntityId);
	}

	// Token: 0x0601B9E7 RID: 113127 RVA: 0x00795B90 File Offset: 0x00793D90
	public void RefreshAllVehicleRuntimeInfo()
	{
		foreach (int vehicleEntityId in this.VehicleToNpcInfoMap.Keys)
		{
			this.RefreshVehicleRuntimeInfo(vehicleEntityId);
		}
	}

	// Token: 0x0601B9E8 RID: 113128 RVA: 0x00795BE8 File Offset: 0x00793DE8
	private void RefreshVehicleFreeState(int vehicleEntityId)
	{
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		if (valueOrDefault == null || !valueOrDefault.HasAvailableSeat())
		{
			this.RemoveFreeVehicleInternal(vehicleEntityId);
			return;
		}
		this.AddFreeVehicleInternal(vehicleEntityId);
	}

	// Token: 0x0601B9E9 RID: 113129 RVA: 0x00795C1C File Offset: 0x00793E1C
	private void RemoveFreeVehicleInternal(int vehicleEntityId)
	{
		this.FreeVehicleSet.Remove(vehicleEntityId);
	}

	// Token: 0x0601B9EA RID: 113130 RVA: 0x00795C2C File Offset: 0x00793E2C
	public void GetCurrentFreeVehicleList(List<int> outList)
	{
		outList.Clear();
		foreach (int item in this.FreeVehicleSet)
		{
			outList.Add(item);
		}
	}

	// Token: 0x0601B9EB RID: 113131 RVA: 0x00795C88 File Offset: 0x00793E88
	public bool CheckVehicleIsFree(int vehicleEntityId)
	{
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		return valueOrDefault == null || valueOrDefault.HasAvailableSeat();
	}

	// Token: 0x0601B9EC RID: 113132 RVA: 0x00795CB0 File Offset: 0x00793EB0
	[NullableContext(2)]
	private NpcVehicleInfo FindVehicleInfoByNpc(int npcEntityId)
	{
		foreach (NpcVehicleInfo npcVehicleInfo in this.VehicleToNpcInfoMap.Values)
		{
			if (npcVehicleInfo.GetSeatByNpc(npcEntityId) != null)
			{
				return npcVehicleInfo;
			}
		}
		return null;
	}

	// Token: 0x17002632 RID: 9778
	// (get) Token: 0x0601B9ED RID: 113133 RVA: 0x00795D1C File Offset: 0x00793F1C
	public static NpcVehicleRiderModel Instance
	{
		get
		{
			return NpcVehicleRiderModel._Instance;
		}
	}

	// Token: 0x0601B9EE RID: 113134 RVA: 0x00795D23 File Offset: 0x00793F23
	public static NpcVehicleRiderModel GetOrCreateInstance()
	{
		if (NpcVehicleRiderModel._Instance == null)
		{
			NpcVehicleRiderModel.CreateInstance();
		}
		return NpcVehicleRiderModel._Instance;
	}

	// Token: 0x0601B9EF RID: 113135 RVA: 0x00795D37 File Offset: 0x00793F37
	public static bool CreateInstance()
	{
		if (NpcVehicleRiderModel._Instance != null)
		{
			return true;
		}
		NpcVehicleRiderModel._Instance = new NpcVehicleRiderModel();
		return true;
	}

	// Token: 0x0601B9F0 RID: 113136 RVA: 0x00795D4D File Offset: 0x00793F4D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B9F1 RID: 113137 RVA: 0x00795D4F File Offset: 0x00793F4F
	public static void ResetStaticDefaultValue()
	{
		NpcVehicleRiderModel._Instance = null;
	}

	// Token: 0x0601B9F2 RID: 113138 RVA: 0x00795D57 File Offset: 0x00793F57
	static NpcVehicleRiderModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NpcVehicleRiderModel.CreateStaticDefaultValue), new Action(NpcVehicleRiderModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400D923 RID: 55587
	private readonly HashSet<int> FreeVehicleSet = new HashSet<int>();

	// Token: 0x0400D924 RID: 55588
	private readonly Dictionary<int, NpcVehicleInfo> VehicleToNpcInfoMap = new Dictionary<int, NpcVehicleInfo>();

	// Token: 0x0400D925 RID: 55589
	private readonly List<int> TmpNpcEntityIdList = new List<int>();

	// Token: 0x0400D926 RID: 55590
	[Nullable(2)]
	private static NpcVehicleRiderModel _Instance;
}
