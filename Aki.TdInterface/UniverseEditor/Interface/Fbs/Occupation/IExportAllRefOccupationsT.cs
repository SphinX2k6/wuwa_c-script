using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200439C RID: 17308
	public class IExportAllRefOccupationsT
	{
		// Token: 0x17007A56 RID: 31318
		// (get) Token: 0x06019C25 RID: 105509 RVA: 0x003B01BE File Offset: 0x003AE3BE
		// (set) Token: 0x06019C26 RID: 105510 RVA: 0x003B01C6 File Offset: 0x003AE3C6
		public List<IQuestAllRefOccupationsT> Quest { get; set; }

		// Token: 0x17007A57 RID: 31319
		// (get) Token: 0x06019C27 RID: 105511 RVA: 0x003B01CF File Offset: 0x003AE3CF
		// (set) Token: 0x06019C28 RID: 105512 RVA: 0x003B01D7 File Offset: 0x003AE3D7
		public List<ILevelPlayAllRefOccupationsT> LevelPlay { get; set; }

		// Token: 0x06019C29 RID: 105513 RVA: 0x003B01E0 File Offset: 0x003AE3E0
		public IExportAllRefOccupationsT()
		{
			this.Quest = null;
			this.LevelPlay = null;
		}
	}
}
