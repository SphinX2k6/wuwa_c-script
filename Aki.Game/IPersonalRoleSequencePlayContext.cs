using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using UnrealEngine;

// Token: 0x020023BD RID: 9149
[NullableContext(1)]
public interface IPersonalRoleSequencePlayContext
{
	// Token: 0x170017C0 RID: 6080
	// (get) Token: 0x060124B4 RID: 74932
	// (set) Token: 0x060124B5 RID: 74933
	int RoleConfigId { get; set; }

	// Token: 0x170017C1 RID: 6081
	// (get) Token: 0x060124B6 RID: 74934
	// (set) Token: 0x060124B7 RID: 74935
	ALevelSequenceActor SequenceActor { get; set; }

	// Token: 0x170017C2 RID: 6082
	// (get) Token: 0x060124B8 RID: 74936
	// (set) Token: 0x060124B9 RID: 74937
	AActor SceneSequenceCamera { get; set; }

	// Token: 0x170017C3 RID: 6083
	// (get) Token: 0x060124BA RID: 74938
	// (set) Token: 0x060124BB RID: 74939
	BP_UpdateInteract_C UpdateInteractBp { get; set; }
}
