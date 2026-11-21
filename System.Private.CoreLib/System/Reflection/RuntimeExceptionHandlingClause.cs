using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x02000719 RID: 1817
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeExceptionHandlingClause : ExceptionHandlingClause
	{
		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06007835 RID: 30773 RVA: 0x0011E0EB File Offset: 0x0011C2EB
		public override ExceptionHandlingClauseOptions Flags
		{
			get
			{
				return this.flags;
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06007836 RID: 30774 RVA: 0x0011E0F3 File Offset: 0x0011C2F3
		public override int TryOffset
		{
			get
			{
				return this.try_offset;
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06007837 RID: 30775 RVA: 0x0011E0FB File Offset: 0x0011C2FB
		public override int TryLength
		{
			get
			{
				return this.try_length;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06007838 RID: 30776 RVA: 0x0011E103 File Offset: 0x0011C303
		public override int HandlerOffset
		{
			get
			{
				return this.handler_offset;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06007839 RID: 30777 RVA: 0x0011E10B File Offset: 0x0011C30B
		public override int HandlerLength
		{
			get
			{
				return this.handler_length;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x0600783A RID: 30778 RVA: 0x0011E113 File Offset: 0x0011C313
		public override int FilterOffset
		{
			get
			{
				return this.filter_offset;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x0600783B RID: 30779 RVA: 0x0011E11B File Offset: 0x0011C31B
		public override Type CatchType
		{
			get
			{
				return this.catch_type;
			}
		}

		// Token: 0x040015D3 RID: 5587
		internal Type catch_type;

		// Token: 0x040015D4 RID: 5588
		internal int filter_offset;

		// Token: 0x040015D5 RID: 5589
		internal ExceptionHandlingClauseOptions flags;

		// Token: 0x040015D6 RID: 5590
		internal int try_offset;

		// Token: 0x040015D7 RID: 5591
		internal int try_length;

		// Token: 0x040015D8 RID: 5592
		internal int handler_offset;

		// Token: 0x040015D9 RID: 5593
		internal int handler_length;
	}
}
