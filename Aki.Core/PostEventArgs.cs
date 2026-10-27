using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200001D RID: 29
[NullableContext(2)]
[Nullable(0)]
public struct PostEventArgs
{
	// Token: 0x040000A5 RID: 165
	public ECallbackMask? CallbackMask;

	// Token: 0x040000A6 RID: 166
	public Action<EAkCallbackType, UAkCallbackInfo> CallbackHandler;

	// Token: 0x040000A7 RID: 167
	public string ExternalSourceName;

	// Token: 0x040000A8 RID: 168
	public string ExternalSourceMediaName;

	// Token: 0x040000A9 RID: 169
	public bool? StopWhenOwnerDestroyed;
}
