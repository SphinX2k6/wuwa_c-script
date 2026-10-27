using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using UnrealEngine;

// Token: 0x020023BE RID: 9150
[NullableContext(1)]
[Nullable(0)]
public class PersonalRoleSequencePlayContext : IPersonalRoleSequencePlayContext
{
	// Token: 0x170017C4 RID: 6084
	// (get) Token: 0x060124BC RID: 74940 RVA: 0x00481660 File Offset: 0x0047F860
	// (set) Token: 0x060124BD RID: 74941 RVA: 0x00481668 File Offset: 0x0047F868
	public int RoleConfigId { get; set; }

	// Token: 0x170017C5 RID: 6085
	// (get) Token: 0x060124BE RID: 74942 RVA: 0x00481671 File Offset: 0x0047F871
	// (set) Token: 0x060124BF RID: 74943 RVA: 0x00481679 File Offset: 0x0047F879
	public ALevelSequenceActor SequenceActor { get; set; }

	// Token: 0x170017C6 RID: 6086
	// (get) Token: 0x060124C0 RID: 74944 RVA: 0x00481682 File Offset: 0x0047F882
	// (set) Token: 0x060124C1 RID: 74945 RVA: 0x0048168A File Offset: 0x0047F88A
	public AActor SceneSequenceCamera { get; set; }

	// Token: 0x170017C7 RID: 6087
	// (get) Token: 0x060124C2 RID: 74946 RVA: 0x00481693 File Offset: 0x0047F893
	// (set) Token: 0x060124C3 RID: 74947 RVA: 0x0048169B File Offset: 0x0047F89B
	public BP_UpdateInteract_C UpdateInteractBp { get; set; }
}
