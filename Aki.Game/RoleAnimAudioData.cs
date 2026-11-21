using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D2A RID: 7466
[NullableContext(1)]
[Nullable(0)]
public class RoleAnimAudioData
{
	// Token: 0x06012843 RID: 75843 RVA: 0x0057902C File Offset: 0x0057722C
	public RoleAnimAudioData(bool canInterrupt, string audioPath)
	{
		this.CanInterrupt = canInterrupt;
		this.AudioPath = audioPath;
	}

	// Token: 0x0400A0DF RID: 41183
	public readonly bool CanInterrupt;

	// Token: 0x0400A0E0 RID: 41184
	public readonly string AudioPath;
}
