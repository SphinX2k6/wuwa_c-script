using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002FB5 RID: 12213
[NullableContext(2)]
public interface IGameplayCueEffectOverride
{
	// Token: 0x170023B3 RID: 9139
	// (get) Token: 0x06019E37 RID: 106039
	// (set) Token: 0x06019E38 RID: 106040
	string SocketName { get; set; }

	// Token: 0x170023B4 RID: 9140
	// (get) Token: 0x06019E39 RID: 106041
	// (set) Token: 0x06019E3A RID: 106042
	FVector? RelativePosition { get; set; }

	// Token: 0x170023B5 RID: 9141
	// (get) Token: 0x06019E3B RID: 106043
	// (set) Token: 0x06019E3C RID: 106044
	FVector? RelativeRotation { get; set; }

	// Token: 0x170023B6 RID: 9142
	// (get) Token: 0x06019E3D RID: 106045
	// (set) Token: 0x06019E3E RID: 106046
	FVector? Scale { get; set; }
}
