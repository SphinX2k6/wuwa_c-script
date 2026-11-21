using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Audio;

// Token: 0x0200026A RID: 618
[NullableContext(1)]
public interface IPendingEffectInfo
{
	// Token: 0x170005E6 RID: 1510
	// (get) Token: 0x06002645 RID: 9797
	// (set) Token: 0x06002646 RID: 9798
	IAudioInfo EffectModel { get; set; }

	// Token: 0x170005E7 RID: 1511
	// (get) Token: 0x06002647 RID: 9799
	// (set) Token: 0x06002648 RID: 9800
	ERoleAudioPriorityType? Priority { get; set; }
}
