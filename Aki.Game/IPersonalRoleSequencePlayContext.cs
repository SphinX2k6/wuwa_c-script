using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using UnrealEngine;

// Token: 0x020018A2 RID: 6306
[NullableContext(1)]
public interface IPersonalRoleSequencePlayContext
{
	// Token: 0x170017FA RID: 6138
	// (get) Token: 0x0600F966 RID: 63846
	// (set) Token: 0x0600F967 RID: 63847
	int RoleConfigId { get; set; }

	// Token: 0x170017FB RID: 6139
	// (get) Token: 0x0600F968 RID: 63848
	// (set) Token: 0x0600F969 RID: 63849
	ALevelSequenceActor SequenceActor { get; set; }

	// Token: 0x170017FC RID: 6140
	// (get) Token: 0x0600F96A RID: 63850
	// (set) Token: 0x0600F96B RID: 63851
	AActor SceneSequenceCamera { get; set; }

	// Token: 0x170017FD RID: 6141
	// (get) Token: 0x0600F96C RID: 63852
	// (set) Token: 0x0600F96D RID: 63853
	BP_UpdateInteract_C UpdateInteractBp { get; set; }
}
