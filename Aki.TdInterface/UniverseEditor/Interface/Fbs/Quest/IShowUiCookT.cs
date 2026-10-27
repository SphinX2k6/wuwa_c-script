using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004125 RID: 16677
	public class IShowUiCookT
	{
		// Token: 0x1700761D RID: 30237
		// (get) Token: 0x060186F2 RID: 100082 RVA: 0x00386368 File Offset: 0x00384568
		// (set) Token: 0x060186F3 RID: 100083 RVA: 0x00386370 File Offset: 0x00384570
		public EShowUiType Type { get; set; }

		// Token: 0x1700761E RID: 30238
		// (get) Token: 0x060186F4 RID: 100084 RVA: 0x00386379 File Offset: 0x00384579
		// (set) Token: 0x060186F5 RID: 100085 RVA: 0x00386381 File Offset: 0x00384581
		public List<int> EntityIds { get; set; }

		// Token: 0x1700761F RID: 30239
		// (get) Token: 0x060186F6 RID: 100086 RVA: 0x0038638A File Offset: 0x0038458A
		// (set) Token: 0x060186F7 RID: 100087 RVA: 0x00386392 File Offset: 0x00384592
		public List<int> ProductIds { get; set; }

		// Token: 0x17007620 RID: 30240
		// (get) Token: 0x060186F8 RID: 100088 RVA: 0x0038639B File Offset: 0x0038459B
		// (set) Token: 0x060186F9 RID: 100089 RVA: 0x003863A3 File Offset: 0x003845A3
		public byte NullMask { get; set; }

		// Token: 0x060186FA RID: 100090 RVA: 0x003863AC File Offset: 0x003845AC
		public IShowUiCookT()
		{
			this.Type = EShowUiType.All;
			this.EntityIds = null;
			this.ProductIds = null;
			this.NullMask = 0;
		}
	}
}
