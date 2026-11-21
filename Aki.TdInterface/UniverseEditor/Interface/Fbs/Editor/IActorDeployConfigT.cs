using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C83 RID: 19587
	public class IActorDeployConfigT
	{
		// Token: 0x17008ABA RID: 35514
		// (get) Token: 0x0601E02A RID: 122922 RVA: 0x00434E6A File Offset: 0x0043306A
		// (set) Token: 0x0601E02B RID: 122923 RVA: 0x00434E72 File Offset: 0x00433072
		public string Folder { get; set; }

		// Token: 0x17008ABB RID: 35515
		// (get) Token: 0x0601E02C RID: 122924 RVA: 0x00434E7B File Offset: 0x0043307B
		// (set) Token: 0x0601E02D RID: 122925 RVA: 0x00434E83 File Offset: 0x00433083
		public string SubFolder { get; set; }

		// Token: 0x0601E02E RID: 122926 RVA: 0x00434E8C File Offset: 0x0043308C
		public IActorDeployConfigT()
		{
			this.Folder = null;
			this.SubFolder = null;
		}
	}
}
