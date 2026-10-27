using System;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EF1 RID: 24305
	public class ITagConfigT
	{
		// Token: 0x1700B5B7 RID: 46519
		// (get) Token: 0x06029BE6 RID: 170982 RVA: 0x005BA78E File Offset: 0x005B898E
		// (set) Token: 0x06029BE7 RID: 170983 RVA: 0x005BA796 File Offset: 0x005B8996
		public string Tag { get; set; }

		// Token: 0x1700B5B8 RID: 46520
		// (get) Token: 0x06029BE8 RID: 170984 RVA: 0x005BA79F File Offset: 0x005B899F
		// (set) Token: 0x06029BE9 RID: 170985 RVA: 0x005BA7A7 File Offset: 0x005B89A7
		public string Name { get; set; }

		// Token: 0x06029BEA RID: 170986 RVA: 0x005BA7B0 File Offset: 0x005B89B0
		public ITagConfigT()
		{
			this.Tag = null;
			this.Name = null;
		}
	}
}
