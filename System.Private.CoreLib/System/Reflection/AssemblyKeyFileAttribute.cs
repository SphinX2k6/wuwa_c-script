using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000729 RID: 1833
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyKeyFileAttribute : Attribute
	{
		// Token: 0x06007873 RID: 30835 RVA: 0x0011E783 File Offset: 0x0011C983
		public AssemblyKeyFileAttribute(string keyFile)
		{
			this.KeyFile = keyFile;
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06007874 RID: 30836 RVA: 0x0011E792 File Offset: 0x0011C992
		public string KeyFile { get; }
	}
}
