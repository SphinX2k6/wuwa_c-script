using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B0 RID: 28848
	public class ISetWeatherT
	{
		// Token: 0x1700D64C RID: 54860
		// (get) Token: 0x06033167 RID: 209255 RVA: 0x006E3E69 File Offset: 0x006E2069
		// (set) Token: 0x06033168 RID: 209256 RVA: 0x006E3E71 File Offset: 0x006E2071
		public int WeatherId { get; set; }

		// Token: 0x1700D64D RID: 54861
		// (get) Token: 0x06033169 RID: 209257 RVA: 0x006E3E7A File Offset: 0x006E207A
		// (set) Token: 0x0603316A RID: 209258 RVA: 0x006E3E82 File Offset: 0x006E2082
		public List<int> AreaIds { get; set; }

		// Token: 0x1700D64E RID: 54862
		// (get) Token: 0x0603316B RID: 209259 RVA: 0x006E3E8B File Offset: 0x006E208B
		// (set) Token: 0x0603316C RID: 209260 RVA: 0x006E3E93 File Offset: 0x006E2093
		public byte NullMask { get; set; }

		// Token: 0x0603316D RID: 209261 RVA: 0x006E3E9C File Offset: 0x006E209C
		public ISetWeatherT()
		{
			this.WeatherId = 0;
			this.AreaIds = null;
			this.NullMask = 0;
		}
	}
}
