using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200430E RID: 17166
	public class IKuroSimpleCombatKillMonsterSystemConfigT
	{
		// Token: 0x17007595 RID: 30101
		// (get) Token: 0x06018242 RID: 98882 RVA: 0x00371B9A File Offset: 0x0036FD9A
		// (set) Token: 0x06018243 RID: 98883 RVA: 0x00371BA2 File Offset: 0x0036FDA2
		public EEnableSystemType Type { get; set; }

		// Token: 0x06018244 RID: 98884 RVA: 0x00371BAB File Offset: 0x0036FDAB
		public IKuroSimpleCombatKillMonsterSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
		}
	}
}
