using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007B0 RID: 1968
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeLocalBuilder : LocalBuilder
	{
		// Token: 0x06007DB8 RID: 32184 RVA: 0x00128E4B File Offset: 0x0012704B
		[DynamicDependency("name")]
		internal RuntimeLocalBuilder(Type t, ILGenerator ilgen)
		{
			this.type = t;
			this.ilgen = ilgen;
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06007DB9 RID: 32185 RVA: 0x00128E61 File Offset: 0x00127061
		public override Type LocalType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06007DBA RID: 32186 RVA: 0x00128E69 File Offset: 0x00127069
		public override bool IsPinned
		{
			get
			{
				return this.is_pinned;
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06007DBB RID: 32187 RVA: 0x00128E71 File Offset: 0x00127071
		public override int LocalIndex
		{
			get
			{
				return (int)this.position;
			}
		}

		// Token: 0x0400180C RID: 6156
		internal Type type;

		// Token: 0x0400180D RID: 6157
		internal bool is_pinned;

		// Token: 0x0400180E RID: 6158
		internal ushort position;

		// Token: 0x0400180F RID: 6159
		private string name;

		// Token: 0x04001810 RID: 6160
		internal ILGenerator ilgen;

		// Token: 0x04001811 RID: 6161
		private int startOffset;

		// Token: 0x04001812 RID: 6162
		private int endOffset;
	}
}
