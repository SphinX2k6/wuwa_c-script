using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C92 RID: 11410
[NullableContext(2)]
public interface IMaterialHandle
{
	// Token: 0x17002022 RID: 8226
	// (get) Token: 0x06017D88 RID: 97672
	// (set) Token: 0x06017D89 RID: 97673
	string EffectId { get; set; }

	// Token: 0x17002023 RID: 8227
	// (get) Token: 0x06017D8A RID: 97674
	// (set) Token: 0x06017D8B RID: 97675
	string EffectPath { get; set; }

	// Token: 0x17002024 RID: 8228
	// (get) Token: 0x06017D8C RID: 97676
	// (set) Token: 0x06017D8D RID: 97677
	int HandleId { get; set; }

	// Token: 0x17002025 RID: 8229
	// (get) Token: 0x06017D8E RID: 97678
	// (set) Token: 0x06017D8F RID: 97679
	int RenderingId { get; set; }

	// Token: 0x17002026 RID: 8230
	// (get) Token: 0x06017D90 RID: 97680
	// (set) Token: 0x06017D91 RID: 97681
	UObject MaterialAssetData { get; set; }

	// Token: 0x17002027 RID: 8231
	// (get) Token: 0x06017D92 RID: 97682
	// (set) Token: 0x06017D93 RID: 97683
	bool? WithAnimObject { get; set; }

	// Token: 0x17002028 RID: 8232
	// (get) Token: 0x06017D94 RID: 97684
	// (set) Token: 0x06017D95 RID: 97685
	USkeletalMeshComponent AnimMeshComp { get; set; }

	// Token: 0x17002029 RID: 8233
	// (get) Token: 0x06017D96 RID: 97686
	// (set) Token: 0x06017D97 RID: 97687
	bool? IsGroup { get; set; }
}
