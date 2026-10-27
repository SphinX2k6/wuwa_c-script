using System;

// Token: 0x02001B3E RID: 6974
[AttributeUsage(AttributeTargets.Class)]
public class FloroRanchEntityComponentAttribute : Attribute
{
	// Token: 0x17001146 RID: 4422
	// (get) Token: 0x0600CEC6 RID: 52934 RVA: 0x002F16DD File Offset: 0x002EF8DD
	// (set) Token: 0x0600CEC7 RID: 52935 RVA: 0x002F16E5 File Offset: 0x002EF8E5
	public EFloroRanchEntityComponent Type { get; private set; }

	// Token: 0x0600CEC8 RID: 52936 RVA: 0x002F16EE File Offset: 0x002EF8EE
	public FloroRanchEntityComponentAttribute(EFloroRanchEntityComponent type)
	{
		type = this.Type;
	}
}
