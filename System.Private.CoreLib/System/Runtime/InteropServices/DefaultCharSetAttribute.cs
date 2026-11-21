using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005C6 RID: 1478
	[AttributeUsage(AttributeTargets.Module, Inherited = false)]
	public sealed class DefaultCharSetAttribute : Attribute
	{
		// Token: 0x0600700E RID: 28686 RVA: 0x0010D98F File Offset: 0x0010BB8F
		public DefaultCharSetAttribute(CharSet charSet)
		{
			this.CharSet = charSet;
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x0600700F RID: 28687 RVA: 0x0010D99E File Offset: 0x0010BB9E
		public CharSet CharSet { get; }
	}
}
