using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B2 RID: 16818
	public class ITargetBattleAttributeT
	{
		// Token: 0x17007748 RID: 30536
		// (get) Token: 0x06018C3C RID: 101436 RVA: 0x00390B22 File Offset: 0x0038ED22
		// (set) Token: 0x06018C3D RID: 101437 RVA: 0x00390B2A File Offset: 0x0038ED2A
		public ETargetBattleAttribute Type { get; set; }

		// Token: 0x06018C3E RID: 101438 RVA: 0x00390B33 File Offset: 0x0038ED33
		public ITargetBattleAttributeT()
		{
			this.Type = ETargetBattleAttribute.Player;
		}
	}
}
