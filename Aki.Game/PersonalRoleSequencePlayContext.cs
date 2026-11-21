using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using UnrealEngine;

// Token: 0x020018A3 RID: 6307
[NullableContext(1)]
[Nullable(0)]
public class PersonalRoleSequencePlayContext : IPersonalRoleSequencePlayContext
{
	// Token: 0x170017FE RID: 6142
	// (get) Token: 0x0600F96E RID: 63854 RVA: 0x0048EB44 File Offset: 0x0048CD44
	// (set) Token: 0x0600F96F RID: 63855 RVA: 0x0048EB4C File Offset: 0x0048CD4C
	public int RoleConfigId { get; set; }

	// Token: 0x170017FF RID: 6143
	// (get) Token: 0x0600F970 RID: 63856 RVA: 0x0048EB55 File Offset: 0x0048CD55
	// (set) Token: 0x0600F971 RID: 63857 RVA: 0x0048EB5D File Offset: 0x0048CD5D
	public ALevelSequenceActor SequenceActor { get; set; }

	// Token: 0x17001800 RID: 6144
	// (get) Token: 0x0600F972 RID: 63858 RVA: 0x0048EB66 File Offset: 0x0048CD66
	// (set) Token: 0x0600F973 RID: 63859 RVA: 0x0048EB6E File Offset: 0x0048CD6E
	public AActor SceneSequenceCamera { get; set; }

	// Token: 0x17001801 RID: 6145
	// (get) Token: 0x0600F974 RID: 63860 RVA: 0x0048EB77 File Offset: 0x0048CD77
	// (set) Token: 0x0600F975 RID: 63861 RVA: 0x0048EB7F File Offset: 0x0048CD7F
	public BP_UpdateInteract_C UpdateInteractBp { get; set; }
}
