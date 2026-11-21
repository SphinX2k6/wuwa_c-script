using System;

// Token: 0x0200009F RID: 159
[AttributeUsage(AttributeTargets.Class)]
public class ConfigAttribute : Attribute
{
	// Token: 0x170000AF RID: 175
	// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0001B7E6 File Offset: 0x000199E6
	// (set) Token: 0x060004F5 RID: 1269 RVA: 0x0001B7EE File Offset: 0x000199EE
	public int Priority { get; private set; }

	// Token: 0x060004F6 RID: 1270 RVA: 0x0001B7F7 File Offset: 0x000199F7
	public ConfigAttribute(int priority = 0)
	{
		this.Priority = priority;
	}
}
