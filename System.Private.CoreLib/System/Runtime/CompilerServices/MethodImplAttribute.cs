using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006B2 RID: 1714
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	public sealed class MethodImplAttribute : Attribute
	{
		// Token: 0x06007437 RID: 29751 RVA: 0x001151C3 File Offset: 0x001133C3
		public MethodImplAttribute(MethodImplOptions methodImplOptions)
		{
			this.Value = methodImplOptions;
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x001151C3 File Offset: 0x001133C3
		public MethodImplAttribute(short value)
		{
			this.Value = value;
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x00022817 File Offset: 0x00020A17
		public MethodImplAttribute()
		{
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x0600743A RID: 29754 RVA: 0x001151D2 File Offset: 0x001133D2
		public MethodImplOptions Value { get; }

		// Token: 0x040014C6 RID: 5318
		public MethodCodeType MethodCodeType;
	}
}
