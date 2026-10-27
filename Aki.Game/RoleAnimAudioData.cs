using System;
using System.Runtime.CompilerServices;

// Token: 0x020027AF RID: 10159
[NullableContext(1)]
[Nullable(0)]
public class RoleAnimAudioData
{
	// Token: 0x06014E44 RID: 85572 RVA: 0x0054E304 File Offset: 0x0054C504
	public RoleAnimAudioData(bool canInterrupt, string audioPath)
	{
		this.CanInterrupt = canInterrupt;
		this.AudioPath = audioPath;
	}

	// Token: 0x04009CFC RID: 40188
	public readonly bool CanInterrupt;

	// Token: 0x04009CFD RID: 40189
	public readonly string AudioPath;
}
