using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004695 RID: 18069
	public class ITrapDefenseSystemConfigT
	{
		// Token: 0x17007E90 RID: 32400
		// (get) Token: 0x0601A882 RID: 108674 RVA: 0x003C6705 File Offset: 0x003C4905
		// (set) Token: 0x0601A883 RID: 108675 RVA: 0x003C670D File Offset: 0x003C490D
		public EEnableSystemType Type { get; set; }

		// Token: 0x17007E91 RID: 32401
		// (get) Token: 0x0601A884 RID: 108676 RVA: 0x003C6716 File Offset: 0x003C4916
		// (set) Token: 0x0601A885 RID: 108677 RVA: 0x003C671E File Offset: 0x003C491E
		public int TrapDefenseId { get; set; }

		// Token: 0x17007E92 RID: 32402
		// (get) Token: 0x0601A886 RID: 108678 RVA: 0x003C6727 File Offset: 0x003C4927
		// (set) Token: 0x0601A887 RID: 108679 RVA: 0x003C672F File Offset: 0x003C492F
		public List<ITrapDefenseSystemVarT> Vars { get; set; }

		// Token: 0x0601A888 RID: 108680 RVA: 0x003C6738 File Offset: 0x003C4938
		public ITrapDefenseSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.TrapDefenseId = 0;
			this.Vars = null;
		}
	}
}
