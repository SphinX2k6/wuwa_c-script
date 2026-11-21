using System;
using System.Runtime.CompilerServices;

namespace System.Runtime
{
	// Token: 0x02000505 RID: 1285
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class TargetedPatchingOptOutAttribute : Attribute
	{
		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06004842 RID: 18498 RVA: 0x000F0AB7 File Offset: 0x000EECB7
		public string Reason { get; }

		// Token: 0x06004843 RID: 18499 RVA: 0x000F0ABF File Offset: 0x000EECBF
		public TargetedPatchingOptOutAttribute(string reason)
		{
			this.Reason = reason;
		}
	}
}
