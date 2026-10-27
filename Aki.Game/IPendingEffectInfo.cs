using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Audio;

// Token: 0x02000266 RID: 614
[NullableContext(1)]
public interface IPendingEffectInfo
{
	// Token: 0x170005BF RID: 1471
	// (get) Token: 0x0600258E RID: 9614
	// (set) Token: 0x0600258F RID: 9615
	IAudioInfo EffectModel { get; set; }

	// Token: 0x170005C0 RID: 1472
	// (get) Token: 0x06002590 RID: 9616
	// (set) Token: 0x06002591 RID: 9617
	ERoleAudioPriorityType? Priority { get; set; }
}
