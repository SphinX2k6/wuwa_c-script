using System;

// Token: 0x020000A1 RID: 161
[AttributeUsage(AttributeTargets.Class)]
public class ControllerAttribute : Attribute
{
	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x060004FC RID: 1276 RVA: 0x0001B824 File Offset: 0x00019A24
	// (set) Token: 0x060004FD RID: 1277 RVA: 0x0001B82C File Offset: 0x00019A2C
	public int Priority { get; private set; }

	// Token: 0x060004FE RID: 1278 RVA: 0x0001B835 File Offset: 0x00019A35
	public ControllerAttribute(int priority = 0)
	{
		this.Priority = priority;
	}
}
