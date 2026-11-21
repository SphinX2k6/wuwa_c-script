using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Audio;
using UnrealEngine;

// Token: 0x02000266 RID: 614
[NullableContext(1)]
public interface IEffectActorInfo
{
	// Token: 0x170005CE RID: 1486
	// (get) Token: 0x06002613 RID: 9747
	// (set) Token: 0x06002614 RID: 9748
	int ActorUid { get; set; }

	// Token: 0x170005CF RID: 1487
	// (get) Token: 0x06002615 RID: 9749
	// (set) Token: 0x06002616 RID: 9750
	AActor Actor { get; set; }

	// Token: 0x170005D0 RID: 1488
	// (get) Token: 0x06002617 RID: 9751
	// (set) Token: 0x06002618 RID: 9752
	UAkComponent AkComponent { get; set; }

	// Token: 0x170005D1 RID: 1489
	// (get) Token: 0x06002619 RID: 9753
	// (set) Token: 0x0600261A RID: 9754
	TArray<FVector> Locations { get; set; }

	// Token: 0x170005D2 RID: 1490
	// (get) Token: 0x0600261B RID: 9755
	// (set) Token: 0x0600261C RID: 9756
	HashSet<int> EffectUidList { get; set; }

	// Token: 0x170005D3 RID: 1491
	// (get) Token: 0x0600261D RID: 9757
	// (set) Token: 0x0600261E RID: 9758
	int AudioHandle { get; set; }

	// Token: 0x170005D4 RID: 1492
	// (get) Token: 0x0600261F RID: 9759
	// (set) Token: 0x06002620 RID: 9760
	IAudioInfo EffectModel { get; set; }

	// Token: 0x170005D5 RID: 1493
	// (get) Token: 0x06002621 RID: 9761
	// (set) Token: 0x06002622 RID: 9762
	ERoleAudioPriorityType? Priority { get; set; }
}
