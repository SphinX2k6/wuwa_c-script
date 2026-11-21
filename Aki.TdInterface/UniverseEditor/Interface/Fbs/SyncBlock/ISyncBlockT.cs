using System;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F8A RID: 16266
	public class ISyncBlockT
	{
		// Token: 0x17006E16 RID: 28182
		// (get) Token: 0x060162BB RID: 90811 RVA: 0x0032DED2 File Offset: 0x0032C0D2
		// (set) Token: 0x060162BC RID: 90812 RVA: 0x0032DEDA File Offset: 0x0032C0DA
		public string Path { get; set; }

		// Token: 0x17006E17 RID: 28183
		// (get) Token: 0x060162BD RID: 90813 RVA: 0x0032DEE3 File Offset: 0x0032C0E3
		// (set) Token: 0x060162BE RID: 90814 RVA: 0x0032DEEB File Offset: 0x0032C0EB
		public string Data { get; set; }

		// Token: 0x060162BF RID: 90815 RVA: 0x0032DEF4 File Offset: 0x0032C0F4
		public ISyncBlockT()
		{
			this.Path = null;
			this.Data = null;
		}
	}
}
