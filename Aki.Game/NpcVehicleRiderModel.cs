using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002770 RID: 10096
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class NpcVehicleRiderModel : ModelBase
{
	// Token: 0x06019557 RID: 103767 RVA: 0x007BD85D File Offset: 0x007BBA5D
	protected override bool OnClear()
	{
		this.FreeVehicleSet.Clear();
		this.VehicleToNpcInfoMap.Clear();
		this.TmpNpcEntityIdList.Clear();
		return true;
	}

	// Token: 0x06019558 RID: 103768 RVA: 0x007BD881 File Offset: 0x007BBA81
	public void AddFreeVehicle(int vehicleEntityId, int seatCount)
	{
		this.RegisterVehicle(vehicleEntityId, seatCount);
	}

	// Token: 0x06019559 RID: 103769 RVA: 0x007BD88B File Offset: 0x007BBA8B
	public void RegisterVehicle(int vehicleEntityId, int seatCount)
	{
		if (vehicleEntityId == 0)
		{
			return;
		}
		this.CreateVehicleInfo(vehicleEntityId, seatCount).SeatCount = seatCount;
		this.RefreshVehicleFreeState(vehicleEntityId);
	}

	// Token: 0x0601955A RID: 103770 RVA: 0x007BD8A6 File Offset: 0x007BBAA6
	public void RemoveFreeVehicle(int vehicleEntityId)
	{
		this.RemoveVehicle(vehicleEntityId);
	}

	// Token: 0x0601955B RID: 103771 RVA: 0x007BD8B0 File Offset: 0x007BBAB0
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

	// Token: 0x0601955C RID: 103772 RVA: 0x007BD8EC File Offset: 0x007BBAEC
	private void AddFreeVehicleInternal(int vehicleEntityId)
	{
		if (this.FreeVehicleSet.Contains(vehicleEntityId))
		{
			return;
		}
		this.FreeVehicleSet.Add(vehicleEntityId);
	}

	// Token: 0x0601955D RID: 103773 RVA: 0x007BD90C File Offset: 0x007BBB0C
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

	// Token: 0x0601955E RID: 103774 RVA: 0x007BDB68 File Offset: 0x007BBD68
	public bool ReserveVehicle(int npcEntityId, int vehicleEntityId)
	{
		return this.TryReserveVehicleSeat(npcEntityId, vehicleEntityId) != null;
	}

	// Token: 0x0601955F RID: 103775 RVA: 0x007BDB88 File Offset: 0x007BBD88
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

	// Token: 0x06019560 RID: 103776 RVA: 0x007BDC98 File Offset: 0x007BBE98
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

	// Token: 0x06019561 RID: 103777 RVA: 0x007BDD88 File Offset: 0x007BBF88
	public int? GetRidingVehicle(int npcEntityId)
	{
		NpcVehicleInfo npcVehicleInfo = this.FindVehicleInfoByNpc(npcEntityId);
		if (npcVehicleInfo == null)
		{
			return null;
		}
		return new int?(npcVehicleInfo.VehicleEntityId);
	}

	// Token: 0x06019562 RID: 103778 RVA: 0x007BDDB4 File Offset: 0x007BBFB4
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

	// Token: 0x06019563 RID: 103779 RVA: 0x007BDE00 File Offset: 0x007BC000
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

	// Token: 0x06019564 RID: 103780 RVA: 0x007BDE4B File Offset: 0x007BC04B
	public ENpcVehicleRideState GetNpcVehicleRideState(int npcEntityId)
	{
		NpcVehicleInfo npcVehicleInfo = this.FindVehicleInfoByNpc(npcEntityId);
		if (npcVehicleInfo == null)
		{
			return ENpcVehicleRideState.None;
		}
		return npcVehicleInfo.GetNpcRideState(npcEntityId);
	}

	// Token: 0x06019565 RID: 103781 RVA: 0x007BDE60 File Offset: 0x007BC060
	public bool SetNpcTargetSplinePbDataId(int npcEntityId, int splinePbDataId)
	{
		NpcVehicleInfo npcVehicleInfo = this.FindVehicleInfoByNpc(npcEntityId);
		return npcVehicleInfo != null && npcVehicleInfo.SetNpcTargetSplinePbDataId(npcEntityId, splinePbDataId);
	}

	// Token: 0x06019566 RID: 103782 RVA: 0x007BDE78 File Offset: 0x007BC078
	public int? GetNpcTargetSplinePbDataId(int npcEntityId)
	{
		NpcVehicleInfo npcVehicleInfo = this.FindVehicleInfoByNpc(npcEntityId);
		if (npcVehicleInfo == null)
		{
			return null;
		}
		return npcVehicleInfo.GetNpcTargetSplinePbDataId(npcEntityId);
	}

	// Token: 0x06019567 RID: 103783 RVA: 0x007BDEA0 File Offset: 0x007BC0A0
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

	// Token: 0x06019568 RID: 103784 RVA: 0x007BDF24 File Offset: 0x007BC124
	public bool IsVehicleMovingToTarget(int vehicleEntityId)
	{
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		return valueOrDefault != null && valueOrDefault.IsMovingToTarget();
	}

	// Token: 0x06019569 RID: 103785 RVA: 0x007BDF40 File Offset: 0x007BC140
	public int? GetAvailableRouteNpc(int vehicleEntityId)
	{
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		if (valueOrDefault == null)
		{
			return null;
		}
		return valueOrDefault.GetAvailableRouteNpcEntityId();
	}

	// Token: 0x0601956A RID: 103786 RVA: 0x007BDF6C File Offset: 0x007BC16C
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

	// Token: 0x0601956B RID: 103787 RVA: 0x007BE110 File Offset: 0x007BC310
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

	// Token: 0x0601956C RID: 103788 RVA: 0x007BE1DC File Offset: 0x007BC3DC
	public void RefreshAllVehicleRuntimeInfo()
	{
		foreach (int vehicleEntityId in this.VehicleToNpcInfoMap.Keys)
		{
			this.RefreshVehicleRuntimeInfo(vehicleEntityId);
		}
	}

	// Token: 0x0601956D RID: 103789 RVA: 0x007BE234 File Offset: 0x007BC434
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

	// Token: 0x0601956E RID: 103790 RVA: 0x007BE268 File Offset: 0x007BC468
	private void RemoveFreeVehicleInternal(int vehicleEntityId)
	{
		this.FreeVehicleSet.Remove(vehicleEntityId);
	}

	// Token: 0x0601956F RID: 103791 RVA: 0x007BE278 File Offset: 0x007BC478
	public void GetCurrentFreeVehicleList(List<int> outList)
	{
		outList.Clear();
		foreach (int item in this.FreeVehicleSet)
		{
			outList.Add(item);
		}
	}

	// Token: 0x06019570 RID: 103792 RVA: 0x007BE2D4 File Offset: 0x007BC4D4
	public bool CheckVehicleIsFree(int vehicleEntityId)
	{
		NpcVehicleInfo valueOrDefault = this.VehicleToNpcInfoMap.GetValueOrDefault(vehicleEntityId);
		return valueOrDefault == null || valueOrDefault.HasAvailableSeat();
	}

	// Token: 0x06019571 RID: 103793 RVA: 0x007BE2FC File Offset: 0x007BC4FC
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

	// Token: 0x17002873 RID: 10355
	// (get) Token: 0x06019572 RID: 103794 RVA: 0x007BE368 File Offset: 0x007BC568
	public static NpcVehicleRiderModel Instance
	{
		get
		{
			return NpcVehicleRiderModel._Instance;
		}
	}

	// Token: 0x06019573 RID: 103795 RVA: 0x007BE36F File Offset: 0x007BC56F
	public static NpcVehicleRiderModel GetOrCreateInstance()
	{
		if (NpcVehicleRiderModel._Instance == null)
		{
			NpcVehicleRiderModel.CreateInstance();
		}
		return NpcVehicleRiderModel._Instance;
	}

	// Token: 0x06019574 RID: 103796 RVA: 0x007BE383 File Offset: 0x007BC583
	public static bool CreateInstance()
	{
		if (NpcVehicleRiderModel._Instance != null)
		{
			return true;
		}
		NpcVehicleRiderModel._Instance = new NpcVehicleRiderModel();
		return true;
	}

	// Token: 0x06019575 RID: 103797 RVA: 0x007BE399 File Offset: 0x007BC599
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06019576 RID: 103798 RVA: 0x007BE39B File Offset: 0x007BC59B
	public static void ResetStaticDefaultValue()
	{
		NpcVehicleRiderModel._Instance = null;
	}

	// Token: 0x06019577 RID: 103799 RVA: 0x007BE3A3 File Offset: 0x007BC5A3
	static NpcVehicleRiderModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NpcVehicleRiderModel.CreateStaticDefaultValue), new Action(NpcVehicleRiderModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400DDC1 RID: 56769
	private readonly HashSet<int> FreeVehicleSet = new HashSet<int>();

	// Token: 0x0400DDC2 RID: 56770
	private readonly Dictionary<int, NpcVehicleInfo> VehicleToNpcInfoMap = new Dictionary<int, NpcVehicleInfo>();

	// Token: 0x0400DDC3 RID: 56771
	private readonly List<int> TmpNpcEntityIdList = new List<int>();

	// Token: 0x0400DDC4 RID: 56772
	[Nullable(2)]
	private static NpcVehicleRiderModel _Instance;
}
