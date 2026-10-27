using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200705F RID: 28767
	public class ISetRegionConfigT
	{
		// Token: 0x1700D5D7 RID: 54743
		// (get) Token: 0x06032F04 RID: 208644 RVA: 0x006DF58E File Offset: 0x006DD78E
		// (set) Token: 0x06032F05 RID: 208645 RVA: 0x006DF596 File Offset: 0x006DD796
		public ERegionConfigType Type { get; set; }

		// Token: 0x06032F06 RID: 208646 RVA: 0x006DF59F File Offset: 0x006DD79F
		public ISetRegionConfigT()
		{
			this.Type = ERegionConfigType.Mpc;
		}
	}
}
