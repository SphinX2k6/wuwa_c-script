using System;
using System.Runtime.CompilerServices;

// Token: 0x02000074 RID: 116
[NullableContext(1)]
[Nullable(0)]
public class TickComponentInfo
{
	// Token: 0x0600035F RID: 863 RVA: 0x00013F86 File Offset: 0x00012186
	public TickComponentInfo(EntityComponent component, int index, int priority)
	{
		this.Component = component;
		this.Index = index;
		this.Priority = priority;
	}

	// Token: 0x0400035F RID: 863
	public readonly EntityComponent Component;

	// Token: 0x04000360 RID: 864
	public readonly int Index;

	// Token: 0x04000361 RID: 865
	public readonly int Priority;
}
