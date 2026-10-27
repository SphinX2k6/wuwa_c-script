using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using UnrealEngine;

// Token: 0x020030E7 RID: 12519
[NullableContext(2)]
public interface IMorphData
{
	// Token: 0x170024D5 RID: 9429
	// (get) Token: 0x0601ACEE RID: 109806
	// (set) Token: 0x0601ACEF RID: 109807
	int ModelId { get; set; }

	// Token: 0x170024D6 RID: 9430
	// (get) Token: 0x0601ACF0 RID: 109808
	// (set) Token: 0x0601ACF1 RID: 109809
	USkeletalMesh SkeletalMesh { get; set; }

	// Token: 0x170024D7 RID: 9431
	// (get) Token: 0x0601ACF2 RID: 109810
	// (set) Token: 0x0601ACF3 RID: 109811
	UClass AnimClass { get; set; }

	// Token: 0x170024D8 RID: 9432
	// (get) Token: 0x0601ACF4 RID: 109812
	// (set) Token: 0x0601ACF5 RID: 109813
	[Nullable(new byte[]
	{
		2,
		1
	})]
	TSoftObjectPtr<UDataTable> DtBaseMovementSetting { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170024D9 RID: 9433
	// (get) Token: 0x0601ACF6 RID: 109814
	// (set) Token: 0x0601ACF7 RID: 109815
	[Nullable(new byte[]
	{
		2,
		1
	})]
	TSoftObjectPtr<UDataTable> DtCameraConfig { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170024DA RID: 9434
	// (get) Token: 0x0601ACF8 RID: 109816
	// (set) Token: 0x0601ACF9 RID: 109817
	FSoftClassPath InputComponentClass { get; set; }

	// Token: 0x170024DB RID: 9435
	// (get) Token: 0x0601ACFA RID: 109818
	// (set) Token: 0x0601ACFB RID: 109819
	UDataTable BaseMovementSetting { get; set; }

	// Token: 0x170024DC RID: 9436
	// (get) Token: 0x0601ACFC RID: 109820
	// (set) Token: 0x0601ACFD RID: 109821
	UDataTable CameraConfig { get; set; }

	// Token: 0x170024DD RID: 9437
	// (get) Token: 0x0601ACFE RID: 109822
	// (set) Token: 0x0601ACFF RID: 109823
	BP_InputBase_C InputComponent { get; set; }

	// Token: 0x170024DE RID: 9438
	// (get) Token: 0x0601AD00 RID: 109824
	// (set) Token: 0x0601AD01 RID: 109825
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	Dictionary<string, Dictionary<string, float>> ComponentFloatParams { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x170024DF RID: 9439
	// (get) Token: 0x0601AD02 RID: 109826
	// (set) Token: 0x0601AD03 RID: 109827
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})]
	Dictionary<string, Dictionary<string, Vector>> ComponentVectorParams { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})] set; }

	// Token: 0x170024E0 RID: 9440
	// (get) Token: 0x0601AD04 RID: 109828
	// (set) Token: 0x0601AD05 RID: 109829
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})]
	Dictionary<string, Dictionary<string, string>> ComponentStringParams { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})] set; }

	// Token: 0x170024E1 RID: 9441
	// (get) Token: 0x0601AD06 RID: 109830
	// (set) Token: 0x0601AD07 RID: 109831
	Vector CenterActorLocationOffset { get; set; }
}
