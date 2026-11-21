using System;

namespace CSharpScript.Core.Utils.StaticVariableReset
{
	// Token: 0x02000007 RID: 7
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class StaticVariablePriorityAttribute : Attribute
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002195 File Offset: 0x00000395
		public StaticVariablePriorityAttribute(int priority = 0)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000021A4 File Offset: 0x000003A4
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000021AC File Offset: 0x000003AC
		public int Priority { get; private set; } = priority;
	}
}
