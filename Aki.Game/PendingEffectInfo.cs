using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Audio;

// Token: 0x02000267 RID: 615
[NullableContext(1)]
[Nullable(0)]
public class PendingEffectInfo : IPendingEffectInfo
{
	// Token: 0x170005C1 RID: 1473
	// (get) Token: 0x06002592 RID: 9618 RVA: 0x000E113C File Offset: 0x000DF33C
	// (set) Token: 0x06002593 RID: 9619 RVA: 0x000E1144 File Offset: 0x000DF344
	public IAudioInfo EffectModel { get; set; }

	// Token: 0x170005C2 RID: 1474
	// (get) Token: 0x06002594 RID: 9620 RVA: 0x000E114D File Offset: 0x000DF34D
	// (set) Token: 0x06002595 RID: 9621 RVA: 0x000E1155 File Offset: 0x000DF355
	public ERoleAudioPriorityType? Priority { get; set; }
}
