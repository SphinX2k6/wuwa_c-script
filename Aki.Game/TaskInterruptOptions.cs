using System;
using System.Runtime.CompilerServices;

// Token: 0x0200353E RID: 13630
[NullableContext(2)]
[Nullable(0)]
public class TaskInterruptOptions
{
	// Token: 0x0601DF06 RID: 122630 RVA: 0x00863C0B File Offset: 0x00861E0B
	public TaskInterruptOptions(ETaskPriority priority = ETaskPriority.Normal, bool interruptible = false, Action onInterrupt = null)
	{
		this.Priority = priority;
		this.Interruptible = interruptible;
		this.OnInterrupt = onInterrupt;
	}

	// Token: 0x0400EB2B RID: 60203
	public readonly ETaskPriority Priority;

	// Token: 0x0400EB2C RID: 60204
	public readonly bool Interruptible;

	// Token: 0x0400EB2D RID: 60205
	public readonly Action OnInterrupt;
}
