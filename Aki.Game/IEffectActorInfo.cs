using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Audio;
using UnrealEngine;

// Token: 0x02000262 RID: 610
[NullableContext(1)]
public interface IEffectActorInfo
{
	// Token: 0x170005A7 RID: 1447
	// (get) Token: 0x0600255C RID: 9564
	// (set) Token: 0x0600255D RID: 9565
	int ActorUid { get; set; }

	// Token: 0x170005A8 RID: 1448
	// (get) Token: 0x0600255E RID: 9566
	// (set) Token: 0x0600255F RID: 9567
	AActor Actor { get; set; }

	// Token: 0x170005A9 RID: 1449
	// (get) Token: 0x06002560 RID: 9568
	// (set) Token: 0x06002561 RID: 9569
	UAkComponent AkComponent { get; set; }

	// Token: 0x170005AA RID: 1450
	// (get) Token: 0x06002562 RID: 9570
	// (set) Token: 0x06002563 RID: 9571
	TArray<FVector> Locations { get; set; }

	// Token: 0x170005AB RID: 1451
	// (get) Token: 0x06002564 RID: 9572
	// (set) Token: 0x06002565 RID: 9573
	HashSet<int> EffectUidList { get; set; }

	// Token: 0x170005AC RID: 1452
	// (get) Token: 0x06002566 RID: 9574
	// (set) Token: 0x06002567 RID: 9575
	int AudioHandle { get; set; }

	// Token: 0x170005AD RID: 1453
	// (get) Token: 0x06002568 RID: 9576
	// (set) Token: 0x06002569 RID: 9577
	IAudioInfo EffectModel { get; set; }

	// Token: 0x170005AE RID: 1454
	// (get) Token: 0x0600256A RID: 9578
	// (set) Token: 0x0600256B RID: 9579
	ERoleAudioPriorityType? Priority { get; set; }
}
