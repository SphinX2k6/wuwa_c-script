using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200072A RID: 1834
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyKeyNameAttribute : Attribute
	{
		// Token: 0x06007875 RID: 30837 RVA: 0x0011E79A File Offset: 0x0011C99A
		public AssemblyKeyNameAttribute(string keyName)
		{
			this.KeyName = keyName;
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06007876 RID: 30838 RVA: 0x0011E7A9 File Offset: 0x0011C9A9
		public string KeyName { get; }
	}
}
