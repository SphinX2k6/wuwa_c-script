using System;
using System.Runtime.CompilerServices;

// Token: 0x0200009A RID: 154
[NullableContext(1)]
[Nullable(0)]
public readonly struct EventHandleEntry
{
	// Token: 0x0600048C RID: 1164 RVA: 0x0001A71B File Offset: 0x0001891B
	public EventHandleEntry(Delegate handle, EHandleType handleType)
	{
		ArgumentNullException.ThrowIfNull(handle, "handle");
		this.Handle = handle;
		this.HandleType = handleType;
	}

	// Token: 0x0400040E RID: 1038
	public readonly Delegate Handle;

	// Token: 0x0400040F RID: 1039
	public readonly EHandleType HandleType;
}
