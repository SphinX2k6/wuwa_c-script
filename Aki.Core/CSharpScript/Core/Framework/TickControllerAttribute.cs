using System;

namespace CSharpScript.Core.Framework
{
	// Token: 0x02000136 RID: 310
	[AttributeUsage(AttributeTargets.Class)]
	public class TickControllerAttribute : Attribute
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00034D4B File Offset: 0x00032F4B
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00034D53 File Offset: 0x00032F53
		public int Priority { get; private set; }

		// Token: 0x06000AFB RID: 2811 RVA: 0x00034D5C File Offset: 0x00032F5C
		public TickControllerAttribute(int priority = 0)
		{
			this.Priority = priority;
		}
	}
}
