using System;
using System.Runtime.CompilerServices;

// Token: 0x02000073 RID: 115
[NullableContext(1)]
[Nullable(0)]
public class TickComponentInfo
{
	// Token: 0x06000326 RID: 806 RVA: 0x0001322A File Offset: 0x0001142A
	public TickComponentInfo(EntityComponent component, int index, int priority)
	{
		this.Component = component;
		this.Index = index;
		this.Priority = priority;
	}

	// Token: 0x04000347 RID: 839
	public readonly EntityComponent Component;

	// Token: 0x04000348 RID: 840
	public readonly int Index;

	// Token: 0x04000349 RID: 841
	public readonly int Priority;
}
