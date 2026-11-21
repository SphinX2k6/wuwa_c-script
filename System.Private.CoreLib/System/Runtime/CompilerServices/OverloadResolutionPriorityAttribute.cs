using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006C1 RID: 1729
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
	public sealed class OverloadResolutionPriorityAttribute : Attribute
	{
		// Token: 0x06007474 RID: 29812 RVA: 0x0011577F File Offset: 0x0011397F
		public OverloadResolutionPriorityAttribute(int priority)
		{
			this.Priority = priority;
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06007475 RID: 29813 RVA: 0x0011578E File Offset: 0x0011398E
		public int Priority { get; }
	}
}
