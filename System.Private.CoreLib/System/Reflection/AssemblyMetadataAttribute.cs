using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200072B RID: 1835
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class AssemblyMetadataAttribute : Attribute
	{
		// Token: 0x06007877 RID: 30839 RVA: 0x0011E7B1 File Offset: 0x0011C9B1
		public AssemblyMetadataAttribute(string key, [Nullable(2)] string value)
		{
			this.Key = key;
			this.Value = value;
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06007878 RID: 30840 RVA: 0x0011E7C7 File Offset: 0x0011C9C7
		public string Key { get; }

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06007879 RID: 30841 RVA: 0x0011E7CF File Offset: 0x0011C9CF
		[Nullable(2)]
		public string Value { [NullableContext(2)] get; }
	}
}
