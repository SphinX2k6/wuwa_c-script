using System;
using System.Runtime.CompilerServices;

// Token: 0x0200009C RID: 156
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventHandleEntry
{
	// Token: 0x060004CD RID: 1229 RVA: 0x0001AE7F File Offset: 0x0001907F
	public EventHandleEntry(Delegate handle, EHandleType handleType)
	{
		ArgumentNullException.ThrowIfNull(handle, "handle");
		this.Handle = handle;
		this.HandleType = handleType;
	}

	// Token: 0x0400041C RID: 1052
	public readonly Delegate Handle;

	// Token: 0x0400041D RID: 1053
	public readonly EHandleType HandleType;
}
