using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AE2 RID: 15074
	public class ITargetLevelEntityT
	{
		// Token: 0x1700676B RID: 26475
		// (get) Token: 0x0601489C RID: 84124 RVA: 0x002FDD44 File Offset: 0x002FBF44
		// (set) Token: 0x0601489D RID: 84125 RVA: 0x002FDD4C File Offset: 0x002FBF4C
		public ETargetType Type { get; set; }

		// Token: 0x1700676C RID: 26476
		// (get) Token: 0x0601489E RID: 84126 RVA: 0x002FDD55 File Offset: 0x002FBF55
		// (set) Token: 0x0601489F RID: 84127 RVA: 0x002FDD5D File Offset: 0x002FBF5D
		public int Id { get; set; }

		// Token: 0x060148A0 RID: 84128 RVA: 0x002FDD66 File Offset: 0x002FBF66
		public ITargetLevelEntityT()
		{
			this.Type = ETargetType.Player;
			this.Id = 0;
		}
	}
}
