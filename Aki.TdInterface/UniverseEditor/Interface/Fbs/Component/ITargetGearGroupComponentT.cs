using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A29 RID: 23081
	public class ITargetGearGroupComponentT
	{
		// Token: 0x1700AD97 RID: 44439
		// (get) Token: 0x06027396 RID: 160662 RVA: 0x005659BC File Offset: 0x00563BBC
		// (set) Token: 0x06027397 RID: 160663 RVA: 0x005659C4 File Offset: 0x00563BC4
		public bool Disabled { get; set; }

		// Token: 0x1700AD98 RID: 44440
		// (get) Token: 0x06027398 RID: 160664 RVA: 0x005659CD File Offset: 0x00563BCD
		// (set) Token: 0x06027399 RID: 160665 RVA: 0x005659D5 File Offset: 0x00563BD5
		public string Type { get; set; }

		// Token: 0x1700AD99 RID: 44441
		// (get) Token: 0x0602739A RID: 160666 RVA: 0x005659DE File Offset: 0x00563BDE
		// (set) Token: 0x0602739B RID: 160667 RVA: 0x005659E6 File Offset: 0x00563BE6
		public List<ITargetGearGroupConfigT> GroupConfigs { get; set; }

		// Token: 0x1700AD9A RID: 44442
		// (get) Token: 0x0602739C RID: 160668 RVA: 0x005659EF File Offset: 0x00563BEF
		// (set) Token: 0x0602739D RID: 160669 RVA: 0x005659F7 File Offset: 0x00563BF7
		public byte NullMask { get; set; }

		// Token: 0x0602739E RID: 160670 RVA: 0x00565A00 File Offset: 0x00563C00
		public ITargetGearGroupComponentT()
		{
			this.Disabled = false;
			this.Type = null;
			this.GroupConfigs = null;
			this.NullMask = 0;
		}
	}
}
