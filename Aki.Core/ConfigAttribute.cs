using System;

// Token: 0x0200009D RID: 157
[AttributeUsage(AttributeTargets.Class)]
public class ConfigAttribute : Attribute
{
	// Token: 0x1700009D RID: 157
	// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0001B0FE File Offset: 0x000192FE
	// (set) Token: 0x060004B4 RID: 1204 RVA: 0x0001B106 File Offset: 0x00019306
	public int Priority { get; private set; }

	// Token: 0x060004B5 RID: 1205 RVA: 0x0001B10F File Offset: 0x0001930F
	public ConfigAttribute(int priority = 0)
	{
		this.Priority = priority;
	}
}
