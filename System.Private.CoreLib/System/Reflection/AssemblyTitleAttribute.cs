using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000731 RID: 1841
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyTitleAttribute : Attribute
	{
		// Token: 0x06007886 RID: 30854 RVA: 0x0011E96B File Offset: 0x0011CB6B
		public AssemblyTitleAttribute(string title)
		{
			this.Title = title;
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06007887 RID: 30855 RVA: 0x0011E97A File Offset: 0x0011CB7A
		public string Title { get; }
	}
}
