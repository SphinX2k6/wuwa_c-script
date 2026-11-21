using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000660 RID: 1632
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class AccessedThroughPropertyAttribute : Attribute
	{
		// Token: 0x0600731F RID: 29471 RVA: 0x00112626 File Offset: 0x00110826
		public AccessedThroughPropertyAttribute(string propertyName)
		{
			this.PropertyName = propertyName;
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06007320 RID: 29472 RVA: 0x00112635 File Offset: 0x00110835
		public string PropertyName { get; }
	}
}
