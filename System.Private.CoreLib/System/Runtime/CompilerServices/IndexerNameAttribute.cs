using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200069F RID: 1695
	[AttributeUsage(AttributeTargets.Property, Inherited = true)]
	public sealed class IndexerNameAttribute : Attribute
	{
		// Token: 0x06007407 RID: 29703 RVA: 0x00022817 File Offset: 0x00020A17
		[NullableContext(1)]
		public IndexerNameAttribute(string indexerName)
		{
		}
	}
}
