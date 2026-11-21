using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000721 RID: 1825
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCopyrightAttribute : Attribute
	{
		// Token: 0x06007860 RID: 30816 RVA: 0x0011E6C0 File Offset: 0x0011C8C0
		public AssemblyCopyrightAttribute(string copyright)
		{
			this.Copyright = copyright;
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06007861 RID: 30817 RVA: 0x0011E6CF File Offset: 0x0011C8CF
		public string Copyright { get; }
	}
}
