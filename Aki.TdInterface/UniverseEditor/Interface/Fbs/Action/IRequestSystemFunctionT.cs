using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7A RID: 28282
	public class IRequestSystemFunctionT
	{
		// Token: 0x1700D2A8 RID: 53928
		// (get) Token: 0x06031FCF RID: 204751 RVA: 0x006C31F1 File Offset: 0x006C13F1
		// (set) Token: 0x06031FD0 RID: 204752 RVA: 0x006C31F9 File Offset: 0x006C13F9
		public IBuyGoodsT SystemFunction { get; set; }

		// Token: 0x06031FD1 RID: 204753 RVA: 0x006C3202 File Offset: 0x006C1402
		public IRequestSystemFunctionT()
		{
			this.SystemFunction = null;
		}
	}
}
