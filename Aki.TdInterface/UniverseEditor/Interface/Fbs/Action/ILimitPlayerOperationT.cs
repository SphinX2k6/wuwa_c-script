using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D4 RID: 28884
	public class ILimitPlayerOperationT
	{
		// Token: 0x1700D394 RID: 54164
		// (get) Token: 0x06032298 RID: 205464 RVA: 0x006C97F5 File Offset: 0x006C79F5
		// (set) Token: 0x06032299 RID: 205465 RVA: 0x006C97FD File Offset: 0x006C79FD
		public TLimitPlayOperationUnion Type { get; set; }

		// Token: 0x0603229A RID: 205466 RVA: 0x006C9806 File Offset: 0x006C7A06
		public ILimitPlayerOperationT()
		{
			this.Type = null;
		}
	}
}
