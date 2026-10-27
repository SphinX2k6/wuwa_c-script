using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Audio;
using UnrealEngine;

// Token: 0x02000263 RID: 611
[NullableContext(1)]
[Nullable(0)]
public class EffectActorInfo : IEffectActorInfo
{
	// Token: 0x170005AF RID: 1455
	// (get) Token: 0x0600256C RID: 9580 RVA: 0x000E1060 File Offset: 0x000DF260
	// (set) Token: 0x0600256D RID: 9581 RVA: 0x000E1068 File Offset: 0x000DF268
	public int ActorUid { get; set; }

	// Token: 0x170005B0 RID: 1456
	// (get) Token: 0x0600256E RID: 9582 RVA: 0x000E1071 File Offset: 0x000DF271
	// (set) Token: 0x0600256F RID: 9583 RVA: 0x000E1079 File Offset: 0x000DF279
	public AActor Actor { get; set; }

	// Token: 0x170005B1 RID: 1457
	// (get) Token: 0x06002570 RID: 9584 RVA: 0x000E1082 File Offset: 0x000DF282
	// (set) Token: 0x06002571 RID: 9585 RVA: 0x000E108A File Offset: 0x000DF28A
	public UAkComponent AkComponent { get; set; }

	// Token: 0x170005B2 RID: 1458
	// (get) Token: 0x06002572 RID: 9586 RVA: 0x000E1093 File Offset: 0x000DF293
	// (set) Token: 0x06002573 RID: 9587 RVA: 0x000E109B File Offset: 0x000DF29B
	public TArray<FVector> Locations { get; set; }

	// Token: 0x170005B3 RID: 1459
	// (get) Token: 0x06002574 RID: 9588 RVA: 0x000E10A4 File Offset: 0x000DF2A4
	// (set) Token: 0x06002575 RID: 9589 RVA: 0x000E10AC File Offset: 0x000DF2AC
	public HashSet<int> EffectUidList { get; set; }

	// Token: 0x170005B4 RID: 1460
	// (get) Token: 0x06002576 RID: 9590 RVA: 0x000E10B5 File Offset: 0x000DF2B5
	// (set) Token: 0x06002577 RID: 9591 RVA: 0x000E10BD File Offset: 0x000DF2BD
	public int AudioHandle { get; set; }

	// Token: 0x170005B5 RID: 1461
	// (get) Token: 0x06002578 RID: 9592 RVA: 0x000E10C6 File Offset: 0x000DF2C6
	// (set) Token: 0x06002579 RID: 9593 RVA: 0x000E10CE File Offset: 0x000DF2CE
	public IAudioInfo EffectModel { get; set; }

	// Token: 0x170005B6 RID: 1462
	// (get) Token: 0x0600257A RID: 9594 RVA: 0x000E10D7 File Offset: 0x000DF2D7
	// (set) Token: 0x0600257B RID: 9595 RVA: 0x000E10DF File Offset: 0x000DF2DF
	public ERoleAudioPriorityType? Priority { get; set; }
}
