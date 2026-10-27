using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200352F RID: 13615
public class WorldEnvironmentInfo
{
	// Token: 0x1700295F RID: 10591
	// (get) Token: 0x0601DEAD RID: 122541 RVA: 0x0086324F File Offset: 0x0086144F
	public global::EDataLayerType DataLayerType
	{
		get
		{
			return this.DataLayer;
		}
	}

	// Token: 0x17002960 RID: 10592
	// (get) Token: 0x0601DEAE RID: 122542 RVA: 0x00863257 File Offset: 0x00861457
	public ESubDataLayerType SubDataLayerType
	{
		get
		{
			return this.SubDataLayer;
		}
	}

	// Token: 0x17002961 RID: 10593
	// (get) Token: 0x0601DEAF RID: 122543 RVA: 0x0086325F File Offset: 0x0086145F
	// (set) Token: 0x0601DEB0 RID: 122544 RVA: 0x00863267 File Offset: 0x00861467
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

	// Token: 0x0601DEB1 RID: 122545 RVA: 0x00863280 File Offset: 0x00861480
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

	// Token: 0x0601DEB2 RID: 122546 RVA: 0x008632F8 File Offset: 0x008614F8
	public bool IsEqual(long type)
	{
		return (long)this.Type == type;
	}

	// Token: 0x0601DEB3 RID: 122547 RVA: 0x00863304 File Offset: 0x00861504
	public bool IsEnCloseEnvironment()
	{
		return (long)this.Type == 0L || (long)this.Type == 1L;
	}

	// Token: 0x17002962 RID: 10594
	// (get) Token: 0x0601DEB4 RID: 122548 RVA: 0x0086331C File Offset: 0x0086151C
	public int EnvType
	{
		get
		{
			return this.Type;
		}
	}

	// Token: 0x0601DEB5 RID: 122549 RVA: 0x00863324 File Offset: 0x00861524
	[NullableContext(1)]
	public void SetInfo(FKuroVoxelInfo info)
	{
		switch (info.EnvType)
		{
		case 0:
			this.DataLayer = global::EDataLayerType.Cave;
			this.SubDataLayer = ESubDataLayerType.Cave;
			this.GlobalCaveMode = EActorCavernMode.ActorCavernMode_Inside;
			break;
		case 1:
			this.DataLayer = global::EDataLayerType.Room;
			this.SubDataLayer = ESubDataLayerType.Room;
			this.GlobalCaveMode = EActorCavernMode.ActorCavernMode_Inside;
			break;
		case 2:
			this.DataLayer = global::EDataLayerType.Cave;
			this.SubDataLayer = ESubDataLayerType.Cave;
			this.GlobalCaveMode = EActorCavernMode.ActorCavernMode_IntermediateZone;
			break;
		default:
			this.GlobalCaveMode = EActorCavernMode.ActorCavernMode_Outside;
			break;
		}
		this.Type = (int)info.EnvType;
	}

	// Token: 0x0601DEB6 RID: 122550 RVA: 0x008633A4 File Offset: 0x008615A4
	public void ResetInfo()
	{
		this.Type = 255;
		UKuroGameBudgetAllocatorCSharpInterface.SetGlobalCavernMode(EActorCavernMode.ActorCavernMode_Outside);
		UWorld world = GlobalData.World;
		if (world == null || !world.IsValid())
		{
			return;
		}
		FName? dynamicFName = FNameUtil.GetDynamicFName(global::EDataLayerType.Cave.ToEnumString());
		FName? dynamicFName2 = FNameUtil.GetDynamicFName(ESubDataLayerType.Cave.ToEnumString());
		WorldController.Instance.ChangeCaveOrRoomDatalayer(world, dynamicFName, dynamicFName2, false);
	}

	// Token: 0x0400EAFD RID: 60157
	private int Type = 255;

	// Token: 0x0400EAFE RID: 60158
	private global::EDataLayerType DataLayer;

	// Token: 0x0400EAFF RID: 60159
	private ESubDataLayerType SubDataLayer;

	// Token: 0x0400EB00 RID: 60160
	private EActorCavernMode GlobalCaveModeInternal = EActorCavernMode.ActorCavernMode_Outside;

	// Token: 0x0400EB01 RID: 60161
	public EActorCavernMode ServerCaveMode = EActorCavernMode.ActorCavernMode_Outside;

	// Token: 0x0400EB02 RID: 60162
	private double LastUpdateTime;
}
