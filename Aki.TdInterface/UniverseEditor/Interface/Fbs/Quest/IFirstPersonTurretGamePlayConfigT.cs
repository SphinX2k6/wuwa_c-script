using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E55 RID: 15957
	public class IFirstPersonTurretGamePlayConfigT
	{
		// Token: 0x17006EAA RID: 28330
		// (get) Token: 0x0601675D RID: 91997 RVA: 0x0033F53A File Offset: 0x0033D73A
		// (set) Token: 0x0601675E RID: 91998 RVA: 0x0033F542 File Offset: 0x0033D742
		public ESpecialGamePlayConfigType Type { get; set; }

		// Token: 0x0601675F RID: 91999 RVA: 0x0033F54B File Offset: 0x0033D74B
		public IFirstPersonTurretGamePlayConfigT()
		{
			this.Type = ESpecialGamePlayConfigType.Stalking;
		}
	}
}
