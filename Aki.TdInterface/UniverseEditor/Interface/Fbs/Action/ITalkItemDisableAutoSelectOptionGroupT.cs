using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AB3 RID: 31411
	public class ITalkItemDisableAutoSelectOptionGroupT
	{
		// Token: 0x1700E873 RID: 59507
		// (get) Token: 0x06037E3D RID: 228925 RVA: 0x00781101 File Offset: 0x0077F301
		// (set) Token: 0x06037E3E RID: 228926 RVA: 0x00781109 File Offset: 0x0077F309
		public string TextKey { get; set; }

		// Token: 0x1700E874 RID: 59508
		// (get) Token: 0x06037E3F RID: 228927 RVA: 0x00781112 File Offset: 0x0077F312
		// (set) Token: 0x06037E40 RID: 228928 RVA: 0x0078111A File Offset: 0x0077F31A
		public int IconId { get; set; }

		// Token: 0x1700E875 RID: 59509
		// (get) Token: 0x06037E41 RID: 228929 RVA: 0x00781123 File Offset: 0x0077F323
		// (set) Token: 0x06037E42 RID: 228930 RVA: 0x0078112B File Offset: 0x0077F32B
		public byte NullMask { get; set; }

		// Token: 0x06037E43 RID: 228931 RVA: 0x00781134 File Offset: 0x0077F334
		public ITalkItemDisableAutoSelectOptionGroupT()
		{
			this.TextKey = null;
			this.IconId = 0;
			this.NullMask = 0;
		}
	}
}
