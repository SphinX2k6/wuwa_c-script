using System;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02006534 RID: 25908
	public class ITagConfigT
	{
		// Token: 0x1700BF22 RID: 48930
		// (get) Token: 0x0602C29A RID: 180890 RVA: 0x00603C72 File Offset: 0x00601E72
		// (set) Token: 0x0602C29B RID: 180891 RVA: 0x00603C7A File Offset: 0x00601E7A
		public string Tag { get; set; }

		// Token: 0x1700BF23 RID: 48931
		// (get) Token: 0x0602C29C RID: 180892 RVA: 0x00603C83 File Offset: 0x00601E83
		// (set) Token: 0x0602C29D RID: 180893 RVA: 0x00603C8B File Offset: 0x00601E8B
		public string Name { get; set; }

		// Token: 0x0602C29E RID: 180894 RVA: 0x00603C94 File Offset: 0x00601E94
		public ITagConfigT()
		{
			this.Tag = null;
			this.Name = null;
		}
	}
}
