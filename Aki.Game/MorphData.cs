using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using UnrealEngine;

// Token: 0x02002640 RID: 9792
[NullableContext(2)]
[Nullable(0)]
public class MorphData : IMorphData
{
	// Token: 0x1700266C RID: 9836
	// (get) Token: 0x06018724 RID: 100132 RVA: 0x007616B0 File Offset: 0x0075F8B0
	// (set) Token: 0x06018725 RID: 100133 RVA: 0x007616B8 File Offset: 0x0075F8B8
	public int ModelId { get; set; }

	// Token: 0x1700266D RID: 9837
	// (get) Token: 0x06018726 RID: 100134 RVA: 0x007616C1 File Offset: 0x0075F8C1
	// (set) Token: 0x06018727 RID: 100135 RVA: 0x007616C9 File Offset: 0x0075F8C9
	public USkeletalMesh SkeletalMesh { get; set; }

	// Token: 0x1700266E RID: 9838
	// (get) Token: 0x06018728 RID: 100136 RVA: 0x007616D2 File Offset: 0x0075F8D2
	// (set) Token: 0x06018729 RID: 100137 RVA: 0x007616DA File Offset: 0x0075F8DA
	public UClass AnimClass { get; set; }

	// Token: 0x1700266F RID: 9839
	// (get) Token: 0x0601872A RID: 100138 RVA: 0x007616E3 File Offset: 0x0075F8E3
	// (set) Token: 0x0601872B RID: 100139 RVA: 0x007616EB File Offset: 0x0075F8EB
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

	// Token: 0x17002670 RID: 9840
	// (get) Token: 0x0601872C RID: 100140 RVA: 0x007616F4 File Offset: 0x0075F8F4
	// (set) Token: 0x0601872D RID: 100141 RVA: 0x007616FC File Offset: 0x0075F8FC
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

	// Token: 0x17002671 RID: 9841
	// (get) Token: 0x0601872E RID: 100142 RVA: 0x00761705 File Offset: 0x0075F905
	// (set) Token: 0x0601872F RID: 100143 RVA: 0x0076170D File Offset: 0x0075F90D
	public FSoftClassPath InputComponentClass { get; set; }

	// Token: 0x17002672 RID: 9842
	// (get) Token: 0x06018730 RID: 100144 RVA: 0x00761716 File Offset: 0x0075F916
	// (set) Token: 0x06018731 RID: 100145 RVA: 0x0076171E File Offset: 0x0075F91E
	public UDataTable BaseMovementSetting { get; set; }

	// Token: 0x17002673 RID: 9843
	// (get) Token: 0x06018732 RID: 100146 RVA: 0x00761727 File Offset: 0x0075F927
	// (set) Token: 0x06018733 RID: 100147 RVA: 0x0076172F File Offset: 0x0075F92F
	public UDataTable CameraConfig { get; set; }

	// Token: 0x17002674 RID: 9844
	// (get) Token: 0x06018734 RID: 100148 RVA: 0x00761738 File Offset: 0x0075F938
	// (set) Token: 0x06018735 RID: 100149 RVA: 0x00761740 File Offset: 0x0075F940
	public BP_InputBase_C InputComponent { get; set; }

	// Token: 0x17002675 RID: 9845
	// (get) Token: 0x06018736 RID: 100150 RVA: 0x00761749 File Offset: 0x0075F949
	// (set) Token: 0x06018737 RID: 100151 RVA: 0x00761751 File Offset: 0x0075F951
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

	// Token: 0x17002676 RID: 9846
	// (get) Token: 0x06018738 RID: 100152 RVA: 0x0076175A File Offset: 0x0075F95A
	// (set) Token: 0x06018739 RID: 100153 RVA: 0x00761762 File Offset: 0x0075F962
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

	// Token: 0x17002677 RID: 9847
	// (get) Token: 0x0601873A RID: 100154 RVA: 0x0076176B File Offset: 0x0075F96B
	// (set) Token: 0x0601873B RID: 100155 RVA: 0x00761773 File Offset: 0x0075F973
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

	// Token: 0x17002678 RID: 9848
	// (get) Token: 0x0601873C RID: 100156 RVA: 0x0076177C File Offset: 0x0075F97C
	// (set) Token: 0x0601873D RID: 100157 RVA: 0x00761784 File Offset: 0x0075F984
	public Vector CenterActorLocationOffset { get; set; }
}
