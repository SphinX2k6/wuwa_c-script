using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Audio;
using UnrealEngine;

// Token: 0x02000267 RID: 615
[NullableContext(1)]
[Nullable(0)]
public class EffectActorInfo : IEffectActorInfo
{
	// Token: 0x170005D6 RID: 1494
	// (get) Token: 0x06002623 RID: 9763 RVA: 0x000E73FC File Offset: 0x000E55FC
	// (set) Token: 0x06002624 RID: 9764 RVA: 0x000E7404 File Offset: 0x000E5604
	public int ActorUid { get; set; }

	// Token: 0x170005D7 RID: 1495
	// (get) Token: 0x06002625 RID: 9765 RVA: 0x000E740D File Offset: 0x000E560D
	// (set) Token: 0x06002626 RID: 9766 RVA: 0x000E7415 File Offset: 0x000E5615
	public AActor Actor { get; set; }

	// Token: 0x170005D8 RID: 1496
	// (get) Token: 0x06002627 RID: 9767 RVA: 0x000E741E File Offset: 0x000E561E
	// (set) Token: 0x06002628 RID: 9768 RVA: 0x000E7426 File Offset: 0x000E5626
	public UAkComponent AkComponent { get; set; }

	// Token: 0x170005D9 RID: 1497
	// (get) Token: 0x06002629 RID: 9769 RVA: 0x000E742F File Offset: 0x000E562F
	// (set) Token: 0x0600262A RID: 9770 RVA: 0x000E7437 File Offset: 0x000E5637
	public TArray<FVector> Locations { get; set; }

	// Token: 0x170005DA RID: 1498
	// (get) Token: 0x0600262B RID: 9771 RVA: 0x000E7440 File Offset: 0x000E5640
	// (set) Token: 0x0600262C RID: 9772 RVA: 0x000E7448 File Offset: 0x000E5648
	public HashSet<int> EffectUidList { get; set; }

	// Token: 0x170005DB RID: 1499
	// (get) Token: 0x0600262D RID: 9773 RVA: 0x000E7451 File Offset: 0x000E5651
	// (set) Token: 0x0600262E RID: 9774 RVA: 0x000E7459 File Offset: 0x000E5659
	public int AudioHandle { get; set; }

	// Token: 0x170005DC RID: 1500
	// (get) Token: 0x0600262F RID: 9775 RVA: 0x000E7462 File Offset: 0x000E5662
	// (set) Token: 0x06002630 RID: 9776 RVA: 0x000E746A File Offset: 0x000E566A
	public IAudioInfo EffectModel { get; set; }

	// Token: 0x170005DD RID: 1501
	// (get) Token: 0x06002631 RID: 9777 RVA: 0x000E7473 File Offset: 0x000E5673
	// (set) Token: 0x06002632 RID: 9778 RVA: 0x000E747B File Offset: 0x000E567B
	public ERoleAudioPriorityType? Priority { get; set; }
}
