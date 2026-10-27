using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003200 RID: 12800
[NullableContext(1)]
[Nullable(0)]
public class NpcVehicleInfo
{
	// Token: 0x0601B9C2 RID: 113090 RVA: 0x00794B48 File Offset: 0x00792D48
	public NpcVehicleInfo(int entityId, int seatCount)
	{
		this.VehicleEntityId = entityId;
		this.SeatCount = seatCount;
	}

	// Token: 0x0601B9C3 RID: 113091 RVA: 0x00794B6C File Offset: 0x00792D6C
	public List<int> RemoveInvalidNpcInfos()
	{
		List<int> list = new List<int>();
		for (int i = this.NpcSeatInfoList.Count - 1; i >= 0; i--)
		{
			int npcEntityId = this.NpcSeatInfoList[i].NpcEntityId;
			Entity entity = EntitySystem.Instance.Get(npcEntityId);
			if (entity == null || !entity.Active)
			{
				this.NpcSeatInfoList.RemoveAt(i);
				list.Add(npcEntityId);
			}
		}
		return list;
	}

	// Token: 0x0601B9C4 RID: 113092 RVA: 0x00794BD6 File Offset: 0x00792DD6
	public bool HasAvailableSeat()
	{
		return this.NpcSeatInfoList.Count < this.SeatCount;
	}

	// Token: 0x0601B9C5 RID: 113093 RVA: 0x00794BEC File Offset: 0x00792DEC
	public unsafe int? ReserveNpc(int npcEntityId)
	{
		NpcSeatInfo npcSeatInfo = this.GetNpcSeatInfo(npcEntityId);
		if (npcSeatInfo != null)
		{
			return new int?(npcSeatInfo.Seat);
		}
		int validSeat = this.GetValidSeat();
		if (validSeat == -1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[NpcVehicleInfo] 获取载具座位失败, 载具没有可用座位";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		this.NpcSeatInfoList.Add(new NpcSeatInfo(npcEntityId, validSeat));
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Vehicle;
		ELogAuthor author2 = ELogAuthor.ZJL;
		string message2 = "[NpcVehicleInfo] 注册NPC到载具成功";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Seat", validSeat);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		return new int?(validSeat);
	}

	// Token: 0x0601B9C6 RID: 113094 RVA: 0x00794CF4 File Offset: 0x00792EF4
	public unsafe int? UnregisterNpc(int npcEntityId)
	{
		int num = this.NpcSeatInfoList.FindIndex((NpcSeatInfo npcInfo) => npcInfo.NpcEntityId == npcEntityId);
		if (num == -1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[NpcVehicleInfo] 从载具注销NPC失败, NPC不在队列中";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		int seat = this.NpcSeatInfoList[num].Seat;
		this.NpcSeatInfoList.RemoveAt(num);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Vehicle;
		ELogAuthor author2 = ELogAuthor.ZJL;
		string message2 = "[NpcVehicleInfo] 从载具注销NPC成功";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Seat", seat);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		return new int?(seat);
	}

	// Token: 0x0601B9C7 RID: 113095 RVA: 0x00794E4C File Offset: 0x0079304C
	public unsafe bool SetNpcRideState(int npcEntityId, ENpcVehicleRideState state)
	{
		NpcSeatInfo npcSeatInfo = this.GetNpcSeatInfo(npcEntityId);
		if (npcSeatInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[NpcVehicleInfo] 设置NPC载具状态失败, NPC不在队列中";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("State", state);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		npcSeatInfo.RideState = state;
		return true;
	}

	// Token: 0x0601B9C8 RID: 113096 RVA: 0x00794EF3 File Offset: 0x007930F3
	public ENpcVehicleRideState GetNpcRideState(int npcEntityId)
	{
		NpcSeatInfo npcSeatInfo = this.GetNpcSeatInfo(npcEntityId);
		if (npcSeatInfo == null)
		{
			return ENpcVehicleRideState.None;
		}
		return npcSeatInfo.RideState;
	}

	// Token: 0x0601B9C9 RID: 113097 RVA: 0x00794F08 File Offset: 0x00793108
	public unsafe bool SetNpcTargetSplinePbDataId(int npcEntityId, int splinePbDataId)
	{
		NpcSeatInfo npcSeatInfo = this.GetNpcSeatInfo(npcEntityId);
		if (npcSeatInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[NpcVehicleInfo] 设置NPC目标样条PbDataId失败, NPC不在队列中";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", npcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SplinePbDataId", splinePbDataId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		npcSeatInfo.TargetSplinePbDataId = new int?(splinePbDataId);
		return true;
	}

	// Token: 0x0601B9CA RID: 113098 RVA: 0x00794FB4 File Offset: 0x007931B4
	public int? GetNpcTargetSplinePbDataId(int npcEntityId)
	{
		NpcSeatInfo npcSeatInfo = this.GetNpcSeatInfo(npcEntityId);
		if (npcSeatInfo == null)
		{
			return null;
		}
		return npcSeatInfo.TargetSplinePbDataId;
	}

	// Token: 0x0601B9CB RID: 113099 RVA: 0x00794FDC File Offset: 0x007931DC
	public int? GetSeatByNpc(int npcEntityId)
	{
		NpcSeatInfo npcSeatInfo = this.GetNpcSeatInfo(npcEntityId);
		if (npcSeatInfo == null)
		{
			return null;
		}
		return new int?(npcSeatInfo.Seat);
	}

	// Token: 0x0601B9CC RID: 113100 RVA: 0x00795008 File Offset: 0x00793208
	public int? GetNpcEntityIdBySplinePbDataId(int splinePbDataId)
	{
		if (splinePbDataId == 0)
		{
			return null;
		}
		NpcSeatInfo npcSeatInfo = this.NpcSeatInfoList.Find(delegate(NpcSeatInfo npcInfo)
		{
			int? targetSplinePbDataId = npcInfo.TargetSplinePbDataId;
			int splinePbDataId2 = splinePbDataId;
			return targetSplinePbDataId.GetValueOrDefault() == splinePbDataId2 & targetSplinePbDataId != null;
		});
		if (npcSeatInfo == null)
		{
			return null;
		}
		return new int?(npcSeatInfo.NpcEntityId);
	}

	// Token: 0x0601B9CD RID: 113101 RVA: 0x00795063 File Offset: 0x00793263
	public bool IsMovingToTarget()
	{
		return this.NpcSeatInfoList.Exists((NpcSeatInfo npcInfo) => npcInfo.RideState == ENpcVehicleRideState.MoveToTargetPoint);
	}

	// Token: 0x0601B9CE RID: 113102 RVA: 0x00795090 File Offset: 0x00793290
	public int? GetAvailableRouteNpcEntityId()
	{
		if (this.NpcSeatInfoList.Exists((NpcSeatInfo npcInfo) => npcInfo.RideState == ENpcVehicleRideState.WaitingToDismount))
		{
			return null;
		}
		NpcSeatInfo npcSeatInfo = this.NpcSeatInfoList.Find(delegate(NpcSeatInfo npcInfo)
		{
			if (npcInfo.RideState == ENpcVehicleRideState.OnVehicleWaiting && npcInfo.TargetSplinePbDataId != null)
			{
				int? targetSplinePbDataId = npcInfo.TargetSplinePbDataId;
				int num = 0;
				return targetSplinePbDataId.GetValueOrDefault() > num & targetSplinePbDataId != null;
			}
			return false;
		});
		if (npcSeatInfo == null)
		{
			return null;
		}
		return new int?(npcSeatInfo.NpcEntityId);
	}

	// Token: 0x0601B9CF RID: 113103 RVA: 0x00795118 File Offset: 0x00793318
	public void GetAllNpcEntityIds(List<int> outList)
	{
		outList.Clear();
		foreach (NpcSeatInfo npcSeatInfo in this.NpcSeatInfoList)
		{
			outList.Add(npcSeatInfo.NpcEntityId);
		}
	}

	// Token: 0x0601B9D0 RID: 113104 RVA: 0x00795178 File Offset: 0x00793378
	[NullableContext(2)]
	private NpcSeatInfo GetNpcSeatInfo(int npcEntityId)
	{
		return this.NpcSeatInfoList.Find((NpcSeatInfo npcInfo) => npcInfo.NpcEntityId == npcEntityId);
	}

	// Token: 0x0601B9D1 RID: 113105 RVA: 0x007951AC File Offset: 0x007933AC
	private int GetValidSeat()
	{
		if (!this.HasAvailableSeat())
		{
			return -1;
		}
		int seat;
		int seat2;
		for (seat = 0; seat < this.SeatCount; seat = seat2 + 1)
		{
			if (!this.NpcSeatInfoList.Exists((NpcSeatInfo npcInfo) => npcInfo.Seat == seat))
			{
				return seat;
			}
			seat2 = seat;
		}
		return -1;
	}

	// Token: 0x0400D920 RID: 55584
	public int VehicleEntityId;

	// Token: 0x0400D921 RID: 55585
	public int SeatCount;

	// Token: 0x0400D922 RID: 55586
	public readonly List<NpcSeatInfo> NpcSeatInfoList = new List<NpcSeatInfo>();
}
