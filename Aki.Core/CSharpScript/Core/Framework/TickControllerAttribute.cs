using System;

namespace CSharpScript.Core.Framework
{
	// Token: 0x0200013B RID: 315
	[AttributeUsage(AttributeTargets.Class)]
	public class TickControllerAttribute : Attribute
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x000358DD File Offset: 0x00033ADD
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x000358E5 File Offset: 0x00033AE5
		public int Priority { get; private set; }

		// Token: 0x06000B58 RID: 2904 RVA: 0x000358EE File Offset: 0x00033AEE
		public TickControllerAttribute(int priority = 0)
		{
			this.Priority = priority;
		}
	}
}
