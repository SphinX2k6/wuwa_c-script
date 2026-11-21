using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x0200070A RID: 1802
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeLocalVariableInfo : LocalVariableInfo
	{
		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06007738 RID: 30520 RVA: 0x0011BC64 File Offset: 0x00119E64
		public override bool IsPinned
		{
			get
			{
				return this.is_pinned;
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06007739 RID: 30521 RVA: 0x0011BC6C File Offset: 0x00119E6C
		public override int LocalIndex
		{
			get
			{
				return (int)this.position;
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x0600773A RID: 30522 RVA: 0x0011BC74 File Offset: 0x00119E74
		public override Type LocalType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x04001584 RID: 5508
		internal Type type;

		// Token: 0x04001585 RID: 5509
		internal bool is_pinned;

		// Token: 0x04001586 RID: 5510
		internal ushort position;
	}
}
