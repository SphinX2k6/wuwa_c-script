using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using UnrealEngine;

// Token: 0x0200263F RID: 9791
[NullableContext(2)]
public interface IMorphData
{
	// Token: 0x1700265F RID: 9823
	// (get) Token: 0x0601870A RID: 100106
	// (set) Token: 0x0601870B RID: 100107
	int ModelId { get; set; }

	// Token: 0x17002660 RID: 9824
	// (get) Token: 0x0601870C RID: 100108
	// (set) Token: 0x0601870D RID: 100109
	USkeletalMesh SkeletalMesh { get; set; }

	// Token: 0x17002661 RID: 9825
	// (get) Token: 0x0601870E RID: 100110
	// (set) Token: 0x0601870F RID: 100111
	UClass AnimClass { get; set; }

	// Token: 0x17002662 RID: 9826
	// (get) Token: 0x06018710 RID: 100112
	// (set) Token: 0x06018711 RID: 100113
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

	// Token: 0x17002663 RID: 9827
	// (get) Token: 0x06018712 RID: 100114
	// (set) Token: 0x06018713 RID: 100115
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

	// Token: 0x17002664 RID: 9828
	// (get) Token: 0x06018714 RID: 100116
	// (set) Token: 0x06018715 RID: 100117
	FSoftClassPath InputComponentClass { get; set; }

	// Token: 0x17002665 RID: 9829
	// (get) Token: 0x06018716 RID: 100118
	// (set) Token: 0x06018717 RID: 100119
	UDataTable BaseMovementSetting { get; set; }

	// Token: 0x17002666 RID: 9830
	// (get) Token: 0x06018718 RID: 100120
	// (set) Token: 0x06018719 RID: 100121
	UDataTable CameraConfig { get; set; }

	// Token: 0x17002667 RID: 9831
	// (get) Token: 0x0601871A RID: 100122
	// (set) Token: 0x0601871B RID: 100123
	BP_InputBase_C InputComponent { get; set; }

	// Token: 0x17002668 RID: 9832
	// (get) Token: 0x0601871C RID: 100124
	// (set) Token: 0x0601871D RID: 100125
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

	// Token: 0x17002669 RID: 9833
	// (get) Token: 0x0601871E RID: 100126
	// (set) Token: 0x0601871F RID: 100127
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

	// Token: 0x1700266A RID: 9834
	// (get) Token: 0x06018720 RID: 100128
	// (set) Token: 0x06018721 RID: 100129
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

	// Token: 0x1700266B RID: 9835
	// (get) Token: 0x06018722 RID: 100130
	// (set) Token: 0x06018723 RID: 100131
	Vector CenterActorLocationOffset { get; set; }
}
