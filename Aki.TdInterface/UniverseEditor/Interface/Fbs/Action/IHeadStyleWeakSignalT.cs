using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068DA RID: 26842
	public class IHeadStyleWeakSignalT
	{
		// Token: 0x1700C726 RID: 50982
		// (get) Token: 0x0602ED12 RID: 191762 RVA: 0x006634D6 File Offset: 0x006616D6
		// (set) Token: 0x0602ED13 RID: 191763 RVA: 0x006634DE File Offset: 0x006616DE
		public EHeadStyle Type { get; set; }

		// Token: 0x0602ED14 RID: 191764 RVA: 0x006634E7 File Offset: 0x006616E7
		public IHeadStyleWeakSignalT()
		{
			this.Type = EHeadStyle.Normal;
		}
	}
}
