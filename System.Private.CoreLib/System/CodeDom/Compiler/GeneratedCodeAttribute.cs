using System;
using System.Runtime.CompilerServices;

namespace System.CodeDom.Compiler
{
	// Token: 0x0200032D RID: 813
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
	public sealed class GeneratedCodeAttribute : Attribute
	{
		// Token: 0x06003A2F RID: 14895 RVA: 0x000C1692 File Offset: 0x000BF892
		public GeneratedCodeAttribute(string tool, string version)
		{
			this._tool = tool;
			this._version = version;
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06003A30 RID: 14896 RVA: 0x000C16A8 File Offset: 0x000BF8A8
		public string Tool
		{
			get
			{
				return this._tool;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06003A31 RID: 14897 RVA: 0x000C16B0 File Offset: 0x000BF8B0
		public string Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x04000BE6 RID: 3046
		private readonly string _tool;

		// Token: 0x04000BE7 RID: 3047
		private readonly string _version;
	}
}
