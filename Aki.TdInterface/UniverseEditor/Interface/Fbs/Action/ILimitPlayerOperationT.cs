using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A24 RID: 27172
	public class ILimitPlayerOperationT
	{
		// Token: 0x1700C994 RID: 51604
		// (get) Token: 0x0602F8D8 RID: 194776 RVA: 0x0067949D File Offset: 0x0067769D
		// (set) Token: 0x0602F8D9 RID: 194777 RVA: 0x006794A5 File Offset: 0x006776A5
		public TLimitPlayOperationUnion Type { get; set; }

		// Token: 0x0602F8DA RID: 194778 RVA: 0x006794AE File Offset: 0x006776AE
		public ILimitPlayerOperationT()
		{
			this.Type = null;
		}
	}
}
