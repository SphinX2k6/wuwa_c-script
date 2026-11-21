using System;
using System.Runtime.CompilerServices;

// Token: 0x02002AB3 RID: 10931
[NullableContext(2)]
[Nullable(0)]
public class TaskInterruptOptions
{
	// Token: 0x0601BC2E RID: 113710 RVA: 0x0088B843 File Offset: 0x00889A43
	public TaskInterruptOptions(ETaskPriority priority = ETaskPriority.Normal, bool interruptible = false, Action onInterrupt = null)
	{
		this.Priority = priority;
		this.Interruptible = interruptible;
		this.OnInterrupt = onInterrupt;
	}

	// Token: 0x0400EFE8 RID: 61416
	public readonly ETaskPriority Priority;

	// Token: 0x0400EFE9 RID: 61417
	public readonly bool Interruptible;

	// Token: 0x0400EFEA RID: 61418
	public readonly Action OnInterrupt;
}
