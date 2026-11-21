using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF9 RID: 28665
	public class IInformationViewConfigT
	{
		// Token: 0x1700D1F5 RID: 53749
		// (get) Token: 0x06031AC2 RID: 203458 RVA: 0x006BA5E4 File Offset: 0x006B87E4
		// (set) Token: 0x06031AC3 RID: 203459 RVA: 0x006BA5EC File Offset: 0x006B87EC
		public int InfoDisplayGroup { get; set; }

		// Token: 0x1700D1F6 RID: 53750
		// (get) Token: 0x06031AC4 RID: 203460 RVA: 0x006BA5F5 File Offset: 0x006B87F5
		// (set) Token: 0x06031AC5 RID: 203461 RVA: 0x006BA5FD File Offset: 0x006B87FD
		public byte NullMask { get; set; }

		// Token: 0x06031AC6 RID: 203462 RVA: 0x006BA606 File Offset: 0x006B8806
		public IInformationViewConfigT()
		{
			this.InfoDisplayGroup = 0;
			this.NullMask = 0;
		}
	}
}
