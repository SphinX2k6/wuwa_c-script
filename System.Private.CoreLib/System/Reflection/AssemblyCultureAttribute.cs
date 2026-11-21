using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000722 RID: 1826
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCultureAttribute : Attribute
	{
		// Token: 0x06007862 RID: 30818 RVA: 0x0011E6D7 File Offset: 0x0011C8D7
		public AssemblyCultureAttribute(string culture)
		{
			this.Culture = culture;
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06007863 RID: 30819 RVA: 0x0011E6E6 File Offset: 0x0011C8E6
		public string Culture { get; }
	}
}
