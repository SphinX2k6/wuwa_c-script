using System;

// Token: 0x0200009F RID: 159
[AttributeUsage(AttributeTargets.Class)]
public class ControllerAttribute : Attribute
{
	// Token: 0x1700009E RID: 158
	// (get) Token: 0x060004BB RID: 1211 RVA: 0x0001B13C File Offset: 0x0001933C
	// (set) Token: 0x060004BC RID: 1212 RVA: 0x0001B144 File Offset: 0x00019344
	public int Priority { get; private set; }

	// Token: 0x060004BD RID: 1213 RVA: 0x0001B14D File Offset: 0x0001934D
	public ControllerAttribute(int priority = 0)
	{
		this.Priority = priority;
	}
}
