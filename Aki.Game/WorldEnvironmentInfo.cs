using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02002AA4 RID: 10916
public class WorldEnvironmentInfo
{
	// Token: 0x17002CF8 RID: 11512
	// (get) Token: 0x0601BBD5 RID: 113621 RVA: 0x0088AE87 File Offset: 0x00889087
	public EDataLayerType DataLayerType
	{
		get
		{
			return this.DataLayer;
		}
	}

	// Token: 0x17002CF9 RID: 11513
	// (get) Token: 0x0601BBD6 RID: 113622 RVA: 0x0088AE8F File Offset: 0x0088908F
	public ESubDataLayerType SubDataLayerType
	{
		get
		{
			return this.SubDataLayer;
		}
	}

	// Token: 0x17002CFA RID: 11514
	// (get) Token: 0x0601BBD7 RID: 113623 RVA: 0x0088AE97 File Offset: 0x00889097
	// (set) Token: 0x0601BBD8 RID: 113624 RVA: 0x0088AE9F File Offset: 0x0088909F
	public EActorCavernMode GlobalCaveMode
	{
		get
		{
			return this.GlobalCaveModeInternal;
		}
		private set
		{
			if (this.GlobalCaveModeInternal == value)
			{
				return;
			}
			this.GlobalCaveModeInternal = value;
			this.RequestUpdateVoxelEnv();
		}
	}

	// Token: 0x0601BBD9 RID: 113625 RVA: 0x0088AEB8 File Offset: 0x008890B8
	public void RequestUpdateVoxelEnv()
	{
		if (this.GlobalCaveModeInternal == this.ServerCaveMode)
		{
			return;
		}
		if (Time.Instance.Now - this.LastUpdateTime < 1000.0)
		{
			return;
		}
		PlayerVoxelEnvRequest playerVoxelEnvRequest = PlayerVoxelEnvRequest.Create();
		playerVoxelEnvRequest.VoxelEnv = (int)this.GlobalCaveModeInternal;
		Net.Instance.Call(ERequestMessageId.PlayerVoxelEnvRequest, playerVoxelEnvRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PlayerVoxelEnvResponse playerVoxelEnvResponse = (PlayerVoxelEnvResponse)msg;
			if (playerVoxelEnvResponse == null)
			{
				return;
			}
			if (playerVoxelEnvResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(playerVoxelEnvResponse.ErrorCode, EResponseMessageId.PlayerVoxelEnvResponse, null, true, true);
				return;
			}
			this.ServerCaveMode = (EActorCavernMode)playerVoxelEnvResponse.VoxelEnv;
		}, 0);
		this.LastUpdateTime = Time.Instance.Now;
	}

	// Token: 0x0601BBDA RID: 113626 RVA: 0x0088AF30 File Offset: 0x00889130
	public bool IsEqual(long type)
	{
		return (long)this.Type == type;
	}

	// Token: 0x0601BBDB RID: 113627 RVA: 0x0088AF3C File Offset: 0x0088913C
	public bool IsEnCloseEnvironment()
	{
		return (long)this.Type == 0L || (long)this.Type == 1L;
	}

	// Token: 0x17002CFB RID: 11515
	// (get) Token: 0x0601BBDC RID: 113628 RVA: 0x0088AF54 File Offset: 0x00889154
	public int EnvType
	{
		get
		{
			return this.Type;
		}
	}

	// Token: 0x0601BBDD RID: 113629 RVA: 0x0088AF5C File Offset: 0x0088915C
	[NullableContext(1)]
	public void SetInfo(FKuroVoxelInfo info)
	{
		switch (info.EnvType)
		{
		case 0:
			this.DataLayer = EDataLayerType.Cave;
			this.SubDataLayer = ESubDataLayerType.Cave;
			this.GlobalCaveMode = EActorCavernMode.ActorCavernMode_Inside;
			break;
		case 1:
			this.DataLayer = EDataLayerType.Room;
			this.SubDataLayer = ESubDataLayerType.Room;
			this.GlobalCaveMode = EActorCavernMode.ActorCavernMode_Inside;
			break;
		case 2:
			this.DataLayer = EDataLayerType.Cave;
			this.SubDataLayer = ESubDataLayerType.Cave;
			this.GlobalCaveMode = EActorCavernMode.ActorCavernMode_IntermediateZone;
			break;
		default:
			this.GlobalCaveMode = EActorCavernMode.ActorCavernMode_Outside;
			break;
		}
		this.Type = (int)info.EnvType;
	}

	// Token: 0x0601BBDE RID: 113630 RVA: 0x0088AFDC File Offset: 0x008891DC
	public void ResetInfo()
	{
		this.Type = 255;
		UKuroGameBudgetAllocatorCSharpInterface.SetGlobalCavernMode(EActorCavernMode.ActorCavernMode_Outside);
		UWorld world = GlobalData.World;
		if (world == null || !world.IsValid())
		{
			return;
		}
		FName? dynamicFName = FNameUtil.GetDynamicFName(EDataLayerType.Cave.ToEnumString());
		FName? dynamicFName2 = FNameUtil.GetDynamicFName(ESubDataLayerType.Cave.ToEnumString());
		WorldController.Instance.ChangeCaveOrRoomDatalayer(world, dynamicFName, dynamicFName2, false);
	}

	// Token: 0x0400EFBA RID: 61370
	private int Type = 255;

	// Token: 0x0400EFBB RID: 61371
	private EDataLayerType DataLayer;

	// Token: 0x0400EFBC RID: 61372
	private ESubDataLayerType SubDataLayer;

	// Token: 0x0400EFBD RID: 61373
	private EActorCavernMode GlobalCaveModeInternal = EActorCavernMode.ActorCavernMode_Outside;

	// Token: 0x0400EFBE RID: 61374
	public EActorCavernMode ServerCaveMode = EActorCavernMode.ActorCavernMode_Outside;

	// Token: 0x0400EFBF RID: 61375
	private double LastUpdateTime;
}
