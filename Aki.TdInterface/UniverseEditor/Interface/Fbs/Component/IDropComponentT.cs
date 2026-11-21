using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005626 RID: 22054
	public class IDropComponentT
	{
		// Token: 0x17009E5F RID: 40543
		// (get) Token: 0x0602335D RID: 144221 RVA: 0x004D89A8 File Offset: 0x004D6BA8
		// (set) Token: 0x0602335E RID: 144222 RVA: 0x004D89B0 File Offset: 0x004D6BB0
		public bool Disabled { get; set; }

		// Token: 0x17009E60 RID: 40544
		// (get) Token: 0x0602335F RID: 144223 RVA: 0x004D89B9 File Offset: 0x004D6BB9
		// (set) Token: 0x06023360 RID: 144224 RVA: 0x004D89C1 File Offset: 0x004D6BC1
		public byte NullMask { get; set; }

		// Token: 0x06023361 RID: 144225 RVA: 0x004D89CA File Offset: 0x004D6BCA
		public IDropComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
