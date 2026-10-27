using System;

// Token: 0x020000A1 RID: 161
[AttributeUsage(AttributeTargets.Class)]
public class ModelAttribute : Attribute
{
	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0001B454 File Offset: 0x00019654
	// (set) Token: 0x060004DA RID: 1242 RVA: 0x0001B45C File Offset: 0x0001965C
	public int Priority { get; private set; }

	// Token: 0x060004DB RID: 1243 RVA: 0x0001B465 File Offset: 0x00019665
	public ModelAttribute(int priority = 0)
	{
		this.Priority = priority;
	}
}
