using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Audio;

// Token: 0x0200026B RID: 619
[NullableContext(1)]
[Nullable(0)]
public class PendingEffectInfo : IPendingEffectInfo
{
	// Token: 0x170005E8 RID: 1512
	// (get) Token: 0x06002649 RID: 9801 RVA: 0x000E74D8 File Offset: 0x000E56D8
	// (set) Token: 0x0600264A RID: 9802 RVA: 0x000E74E0 File Offset: 0x000E56E0
	public IAudioInfo EffectModel { get; set; }

	// Token: 0x170005E9 RID: 1513
	// (get) Token: 0x0600264B RID: 9803 RVA: 0x000E74E9 File Offset: 0x000E56E9
	// (set) Token: 0x0600264C RID: 9804 RVA: 0x000E74F1 File Offset: 0x000E56F1
	public ERoleAudioPriorityType? Priority { get; set; }
}
