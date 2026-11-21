using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200566E RID: 22126
	public class IEditCustomAoiComponentT
	{
		// Token: 0x17009F16 RID: 40726
		// (get) Token: 0x06023628 RID: 144936 RVA: 0x004DE285 File Offset: 0x004DC485
		// (set) Token: 0x06023629 RID: 144937 RVA: 0x004DE28D File Offset: 0x004DC48D
		public bool Disabled { get; set; }

		// Token: 0x17009F17 RID: 40727
		// (get) Token: 0x0602362A RID: 144938 RVA: 0x004DE296 File Offset: 0x004DC496
		// (set) Token: 0x0602362B RID: 144939 RVA: 0x004DE29E File Offset: 0x004DC49E
		public List<int> Entities { get; set; }

		// Token: 0x17009F18 RID: 40728
		// (get) Token: 0x0602362C RID: 144940 RVA: 0x004DE2A7 File Offset: 0x004DC4A7
		// (set) Token: 0x0602362D RID: 144941 RVA: 0x004DE2AF File Offset: 0x004DC4AF
		public byte NullMask { get; set; }

		// Token: 0x0602362E RID: 144942 RVA: 0x004DE2B8 File Offset: 0x004DC4B8
		public IEditCustomAoiComponentT()
		{
			this.Disabled = false;
			this.Entities = null;
			this.NullMask = 0;
		}
	}
}
