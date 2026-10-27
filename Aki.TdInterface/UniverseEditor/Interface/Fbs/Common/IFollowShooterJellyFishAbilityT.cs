using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DB3 RID: 23987
	public class IFollowShooterJellyFishAbilityT
	{
		// Token: 0x1700B39F RID: 45983
		// (get) Token: 0x060290EC RID: 168172 RVA: 0x005A3297 File Offset: 0x005A1497
		// (set) Token: 0x060290ED RID: 168173 RVA: 0x005A329F File Offset: 0x005A149F
		public EFollowShooterType Type { get; set; }

		// Token: 0x1700B3A0 RID: 45984
		// (get) Token: 0x060290EE RID: 168174 RVA: 0x005A32A8 File Offset: 0x005A14A8
		// (set) Token: 0x060290EF RID: 168175 RVA: 0x005A32B0 File Offset: 0x005A14B0
		public List<EJellyFishAbilityType> Abilities { get; set; }

		// Token: 0x060290F0 RID: 168176 RVA: 0x005A32B9 File Offset: 0x005A14B9
		public IFollowShooterJellyFishAbilityT()
		{
			this.Type = EFollowShooterType.JellyFish;
			this.Abilities = null;
		}
	}
}
