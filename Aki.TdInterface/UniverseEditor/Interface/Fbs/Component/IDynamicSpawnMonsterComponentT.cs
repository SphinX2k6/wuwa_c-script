using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565F RID: 22111
	public class IDynamicSpawnMonsterComponentT
	{
		// Token: 0x17009EE9 RID: 40681
		// (get) Token: 0x06023585 RID: 144773 RVA: 0x004DCD79 File Offset: 0x004DAF79
		// (set) Token: 0x06023586 RID: 144774 RVA: 0x004DCD81 File Offset: 0x004DAF81
		public bool Disabled { get; set; }

		// Token: 0x17009EEA RID: 40682
		// (get) Token: 0x06023587 RID: 144775 RVA: 0x004DCD8A File Offset: 0x004DAF8A
		// (set) Token: 0x06023588 RID: 144776 RVA: 0x004DCD92 File Offset: 0x004DAF92
		public List<IConditionSpawnMonsterT> Group { get; set; }

		// Token: 0x17009EEB RID: 40683
		// (get) Token: 0x06023589 RID: 144777 RVA: 0x004DCD9B File Offset: 0x004DAF9B
		// (set) Token: 0x0602358A RID: 144778 RVA: 0x004DCDA3 File Offset: 0x004DAFA3
		public byte NullMask { get; set; }

		// Token: 0x0602358B RID: 144779 RVA: 0x004DCDAC File Offset: 0x004DAFAC
		public IDynamicSpawnMonsterComponentT()
		{
			this.Disabled = false;
			this.Group = null;
			this.NullMask = 0;
		}
	}
}
