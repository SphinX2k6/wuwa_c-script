using System;

namespace System.Reflection.Emit
{
	// Token: 0x020007AA RID: 1962
	internal struct ILExceptionInfo
	{
		// Token: 0x06007D7B RID: 32123 RVA: 0x001276BC File Offset: 0x001258BC
		internal void AddCatch(Type extype, int offset)
		{
			this.End(offset);
			this.add_block(offset);
			int num = this.handlers.Length - 1;
			this.handlers[num].type = 0;
			this.handlers[num].start = offset;
			this.handlers[num].extype = extype;
		}

		// Token: 0x06007D7C RID: 32124 RVA: 0x00127718 File Offset: 0x00125918
		internal void AddFinally(int offset)
		{
			this.End(offset);
			this.add_block(offset);
			int num = this.handlers.Length - 1;
			this.handlers[num].type = 2;
			this.handlers[num].start = offset;
			this.handlers[num].extype = null;
		}

		// Token: 0x06007D7D RID: 32125 RVA: 0x00127774 File Offset: 0x00125974
		internal void AddFault(int offset)
		{
			this.End(offset);
			this.add_block(offset);
			int num = this.handlers.Length - 1;
			this.handlers[num].type = 4;
			this.handlers[num].start = offset;
			this.handlers[num].extype = null;
		}

		// Token: 0x06007D7E RID: 32126 RVA: 0x001277D0 File Offset: 0x001259D0
		internal void AddFilter(int offset)
		{
			this.End(offset);
			this.add_block(offset);
			int num = this.handlers.Length - 1;
			this.handlers[num].type = -1;
			this.handlers[num].extype = null;
			this.handlers[num].filter_offset = offset;
		}

		// Token: 0x06007D7F RID: 32127 RVA: 0x0012782C File Offset: 0x00125A2C
		internal void End(int offset)
		{
			if (this.handlers == null)
			{
				return;
			}
			int num = this.handlers.Length - 1;
			if (num >= 0)
			{
				this.handlers[num].len = offset - this.handlers[num].start;
			}
		}

		// Token: 0x06007D80 RID: 32128 RVA: 0x00127875 File Offset: 0x00125A75
		internal int LastClauseType()
		{
			if (this.handlers != null)
			{
				return this.handlers[this.handlers.Length - 1].type;
			}
			return 0;
		}

		// Token: 0x06007D81 RID: 32129 RVA: 0x0012789C File Offset: 0x00125A9C
		internal void PatchFilterClause(int start)
		{
			if (this.handlers != null && this.handlers.Length != 0)
			{
				this.handlers[this.handlers.Length - 1].start = start;
				this.handlers[this.handlers.Length - 1].type = 1;
			}
		}

		// Token: 0x06007D82 RID: 32130 RVA: 0x001278F0 File Offset: 0x00125AF0
		private void add_block(int offset)
		{
			if (this.handlers != null)
			{
				int num = this.handlers.Length;
				ILExceptionBlock[] destinationArray = new ILExceptionBlock[num + 1];
				Array.Copy(this.handlers, destinationArray, num);
				this.handlers = destinationArray;
				this.handlers[num].len = offset - this.handlers[num].start;
				return;
			}
			this.handlers = new ILExceptionBlock[1];
			this.len = offset - this.start;
		}

		// Token: 0x040017F3 RID: 6131
		internal ILExceptionBlock[] handlers;

		// Token: 0x040017F4 RID: 6132
		internal int start;

		// Token: 0x040017F5 RID: 6133
		internal int len;

		// Token: 0x040017F6 RID: 6134
		internal Label end;
	}
}
