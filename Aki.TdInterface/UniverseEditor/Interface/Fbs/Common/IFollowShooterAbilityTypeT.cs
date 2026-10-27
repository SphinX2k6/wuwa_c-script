using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DAD RID: 23981
	public class IFollowShooterAbilityTypeT
	{
		// Token: 0x1700B399 RID: 45977
		// (get) Token: 0x060290C4 RID: 168132 RVA: 0x005A2E36 File Offset: 0x005A1036
		// (set) Token: 0x060290C5 RID: 168133 RVA: 0x005A2E3E File Offset: 0x005A103E
		public EFollowShooterType Type { get; set; }

		// Token: 0x060290C6 RID: 168134 RVA: 0x005A2E47 File Offset: 0x005A1047
		public IFollowShooterAbilityTypeT()
		{
			this.Type = EFollowShooterType.JellyFish;
		}
	}
}
