using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CDD RID: 19677
	public class IEntityDeployConfigT
	{
		// Token: 0x17008C8A RID: 35978
		// (get) Token: 0x0601E645 RID: 124485 RVA: 0x00442192 File Offset: 0x00440392
		// (set) Token: 0x0601E646 RID: 124486 RVA: 0x0044219A File Offset: 0x0044039A
		public string Folder { get; set; }

		// Token: 0x17008C8B RID: 35979
		// (get) Token: 0x0601E647 RID: 124487 RVA: 0x004421A3 File Offset: 0x004403A3
		// (set) Token: 0x0601E648 RID: 124488 RVA: 0x004421AB File Offset: 0x004403AB
		public string SubFolder { get; set; }

		// Token: 0x0601E649 RID: 124489 RVA: 0x004421B4 File Offset: 0x004403B4
		public IEntityDeployConfigT()
		{
			this.Folder = null;
			this.SubFolder = null;
		}
	}
}
