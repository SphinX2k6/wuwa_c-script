using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006A5 RID: 1701
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
	public sealed class InlineArrayAttribute : Attribute
	{
		// Token: 0x06007410 RID: 29712 RVA: 0x00114920 File Offset: 0x00112B20
		public InlineArrayAttribute(int length)
		{
			this.Length = length;
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06007411 RID: 29713 RVA: 0x0011492F File Offset: 0x00112B2F
		public int Length { get; }
	}
}
