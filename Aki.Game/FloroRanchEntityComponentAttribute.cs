using System;

// Token: 0x02000FFD RID: 4093
[AttributeUsage(AttributeTargets.Class)]
public class FloroRanchEntityComponentAttribute : Attribute
{
	// Token: 0x1700116B RID: 4459
	// (get) Token: 0x0600A2D7 RID: 41687 RVA: 0x002FC7BD File Offset: 0x002FA9BD
	// (set) Token: 0x0600A2D8 RID: 41688 RVA: 0x002FC7C5 File Offset: 0x002FA9C5
	public EFloroRanchEntityComponent Type { get; private set; }

	// Token: 0x0600A2D9 RID: 41689 RVA: 0x002FC7CE File Offset: 0x002FA9CE
	public FloroRanchEntityComponentAttribute(EFloroRanchEntityComponent type)
	{
		type = this.Type;
	}
}
