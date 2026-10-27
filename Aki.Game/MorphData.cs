using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using UnrealEngine;

// Token: 0x020030E8 RID: 12520
[NullableContext(2)]
[Nullable(0)]
public class MorphData : IMorphData
{
	// Token: 0x170024E2 RID: 9442
	// (get) Token: 0x0601AD08 RID: 109832 RVA: 0x0073BC74 File Offset: 0x00739E74
	// (set) Token: 0x0601AD09 RID: 109833 RVA: 0x0073BC7C File Offset: 0x00739E7C
	public int ModelId { get; set; }

	// Token: 0x170024E3 RID: 9443
	// (get) Token: 0x0601AD0A RID: 109834 RVA: 0x0073BC85 File Offset: 0x00739E85
	// (set) Token: 0x0601AD0B RID: 109835 RVA: 0x0073BC8D File Offset: 0x00739E8D
	public USkeletalMesh SkeletalMesh { get; set; }

	// Token: 0x170024E4 RID: 9444
	// (get) Token: 0x0601AD0C RID: 109836 RVA: 0x0073BC96 File Offset: 0x00739E96
	// (set) Token: 0x0601AD0D RID: 109837 RVA: 0x0073BC9E File Offset: 0x00739E9E
	public UClass AnimClass { get; set; }

	// Token: 0x170024E5 RID: 9445
	// (get) Token: 0x0601AD0E RID: 109838 RVA: 0x0073BCA7 File Offset: 0x00739EA7
	// (set) Token: 0x0601AD0F RID: 109839 RVA: 0x0073BCAF File Offset: 0x00739EAF
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TSoftObjectPtr<UDataTable> DtBaseMovementSetting { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170024E6 RID: 9446
	// (get) Token: 0x0601AD10 RID: 109840 RVA: 0x0073BCB8 File Offset: 0x00739EB8
	// (set) Token: 0x0601AD11 RID: 109841 RVA: 0x0073BCC0 File Offset: 0x00739EC0
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TSoftObjectPtr<UDataTable> DtCameraConfig { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170024E7 RID: 9447
	// (get) Token: 0x0601AD12 RID: 109842 RVA: 0x0073BCC9 File Offset: 0x00739EC9
	// (set) Token: 0x0601AD13 RID: 109843 RVA: 0x0073BCD1 File Offset: 0x00739ED1
	public FSoftClassPath InputComponentClass { get; set; }

	// Token: 0x170024E8 RID: 9448
	// (get) Token: 0x0601AD14 RID: 109844 RVA: 0x0073BCDA File Offset: 0x00739EDA
	// (set) Token: 0x0601AD15 RID: 109845 RVA: 0x0073BCE2 File Offset: 0x00739EE2
	public UDataTable BaseMovementSetting { get; set; }

	// Token: 0x170024E9 RID: 9449
	// (get) Token: 0x0601AD16 RID: 109846 RVA: 0x0073BCEB File Offset: 0x00739EEB
	// (set) Token: 0x0601AD17 RID: 109847 RVA: 0x0073BCF3 File Offset: 0x00739EF3
	public UDataTable CameraConfig { get; set; }

	// Token: 0x170024EA RID: 9450
	// (get) Token: 0x0601AD18 RID: 109848 RVA: 0x0073BCFC File Offset: 0x00739EFC
	// (set) Token: 0x0601AD19 RID: 109849 RVA: 0x0073BD04 File Offset: 0x00739F04
	public BP_InputBase_C InputComponent { get; set; }

	// Token: 0x170024EB RID: 9451
	// (get) Token: 0x0601AD1A RID: 109850 RVA: 0x0073BD0D File Offset: 0x00739F0D
	// (set) Token: 0x0601AD1B RID: 109851 RVA: 0x0073BD15 File Offset: 0x00739F15
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public Dictionary<string, Dictionary<string, float>> ComponentFloatParams { [return: Nullable(new byte[]
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

	// Token: 0x170024EC RID: 9452
	// (get) Token: 0x0601AD1C RID: 109852 RVA: 0x0073BD1E File Offset: 0x00739F1E
	// (set) Token: 0x0601AD1D RID: 109853 RVA: 0x0073BD26 File Offset: 0x00739F26
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})]
	public Dictionary<string, Dictionary<string, Vector>> ComponentVectorParams { [return: Nullable(new byte[]
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

	// Token: 0x170024ED RID: 9453
	// (get) Token: 0x0601AD1E RID: 109854 RVA: 0x0073BD2F File Offset: 0x00739F2F
	// (set) Token: 0x0601AD1F RID: 109855 RVA: 0x0073BD37 File Offset: 0x00739F37
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})]
	public Dictionary<string, Dictionary<string, string>> ComponentStringParams { [return: Nullable(new byte[]
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

	// Token: 0x170024EE RID: 9454
	// (get) Token: 0x0601AD20 RID: 109856 RVA: 0x0073BD40 File Offset: 0x00739F40
	// (set) Token: 0x0601AD21 RID: 109857 RVA: 0x0073BD48 File Offset: 0x00739F48
	public Vector CenterActorLocationOffset { get; set; }
}
