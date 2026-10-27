using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C56 RID: 19542
	public class IMonsterBuffContainerT
	{
		// Token: 0x17008DFE RID: 36350
		// (get) Token: 0x0601EFCF RID: 126927 RVA: 0x00455878 File Offset: 0x00453A78
		// (set) Token: 0x0601EFD0 RID: 126928 RVA: 0x00455880 File Offset: 0x00453A80
		public ETargetBuffContainer Type { get; set; }

		// Token: 0x17008DFF RID: 36351
		// (get) Token: 0x0601EFD1 RID: 126929 RVA: 0x00455889 File Offset: 0x00453A89
		// (set) Token: 0x0601EFD2 RID: 126930 RVA: 0x00455891 File Offset: 0x00453A91
		public int MonsterEntityId { get; set; }

		// Token: 0x0601EFD3 RID: 126931 RVA: 0x0045589A File Offset: 0x00453A9A
		public IMonsterBuffContainerT()
		{
			this.Type = ETargetBuffContainer.Monster;
			this.MonsterEntityId = 0;
		}
	}
}
