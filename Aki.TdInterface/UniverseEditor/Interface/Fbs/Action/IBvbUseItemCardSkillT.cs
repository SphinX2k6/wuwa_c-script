using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200626A RID: 25194
	public class IBvbUseItemCardSkillT
	{
		// Token: 0x1700BBBD RID: 48061
		// (get) Token: 0x0602B792 RID: 178066 RVA: 0x005FC285 File Offset: 0x005FA485
		// (set) Token: 0x0602B793 RID: 178067 RVA: 0x005FC28D File Offset: 0x005FA48D
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700BBBE RID: 48062
		// (get) Token: 0x0602B794 RID: 178068 RVA: 0x005FC296 File Offset: 0x005FA496
		// (set) Token: 0x0602B795 RID: 178069 RVA: 0x005FC29E File Offset: 0x005FA49E
		public List<int> BoardPosIndexList { get; set; }

		// Token: 0x1700BBBF RID: 48063
		// (get) Token: 0x0602B796 RID: 178070 RVA: 0x005FC2A7 File Offset: 0x005FA4A7
		// (set) Token: 0x0602B797 RID: 178071 RVA: 0x005FC2AF File Offset: 0x005FA4AF
		public byte NullMask { get; set; }

		// Token: 0x0602B798 RID: 178072 RVA: 0x005FC2B8 File Offset: 0x005FA4B8
		public IBvbUseItemCardSkillT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.BoardPosIndexList = null;
			this.NullMask = 0;
		}
	}
}
