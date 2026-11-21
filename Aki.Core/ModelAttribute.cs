using System;

// Token: 0x020000A3 RID: 163
[AttributeUsage(AttributeTargets.Class)]
public class ModelAttribute : Attribute
{
	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x0600051A RID: 1306 RVA: 0x0001BB3C File Offset: 0x00019D3C
	// (set) Token: 0x0600051B RID: 1307 RVA: 0x0001BB44 File Offset: 0x00019D44
	public int Priority { get; private set; }

	// Token: 0x0600051C RID: 1308 RVA: 0x0001BB4D File Offset: 0x00019D4D
	public ModelAttribute(int priority = 0)
	{
		this.Priority = priority;
	}
}
