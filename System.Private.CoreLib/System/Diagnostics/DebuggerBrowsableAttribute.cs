using System;

namespace System.Diagnostics
{
	// Token: 0x02000882 RID: 2178
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class DebuggerBrowsableAttribute : Attribute
	{
		// Token: 0x06008939 RID: 35129 RVA: 0x0014DABD File Offset: 0x0014BCBD
		public DebuggerBrowsableAttribute(DebuggerBrowsableState state)
		{
			if (state < DebuggerBrowsableState.Never || state > DebuggerBrowsableState.RootHidden)
			{
				throw new ArgumentOutOfRangeException("state");
			}
			this.State = state;
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x0600893A RID: 35130 RVA: 0x0014DADF File Offset: 0x0014BCDF
		public DebuggerBrowsableState State { get; }
	}
}
