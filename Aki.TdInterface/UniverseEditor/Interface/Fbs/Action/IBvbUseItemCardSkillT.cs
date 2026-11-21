using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068DB RID: 26843
	public class IBvbUseItemCardSkillT
	{
		// Token: 0x1700C545 RID: 50501
		// (get) Token: 0x0602DEF3 RID: 188147 RVA: 0x0064708D File Offset: 0x0064528D
		// (set) Token: 0x0602DEF4 RID: 188148 RVA: 0x00647095 File Offset: 0x00645295
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700C546 RID: 50502
		// (get) Token: 0x0602DEF5 RID: 188149 RVA: 0x0064709E File Offset: 0x0064529E
		// (set) Token: 0x0602DEF6 RID: 188150 RVA: 0x006470A6 File Offset: 0x006452A6
		public List<int> BoardPosIndexList { get; set; }

		// Token: 0x1700C547 RID: 50503
		// (get) Token: 0x0602DEF7 RID: 188151 RVA: 0x006470AF File Offset: 0x006452AF
		// (set) Token: 0x0602DEF8 RID: 188152 RVA: 0x006470B7 File Offset: 0x006452B7
		public byte NullMask { get; set; }

		// Token: 0x0602DEF9 RID: 188153 RVA: 0x006470C0 File Offset: 0x006452C0
		public IBvbUseItemCardSkillT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.BoardPosIndexList = null;
			this.NullMask = 0;
		}
	}
}
