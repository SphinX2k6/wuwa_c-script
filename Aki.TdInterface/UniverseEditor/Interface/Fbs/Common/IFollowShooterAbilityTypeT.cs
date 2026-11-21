using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063EA RID: 25578
	public class IFollowShooterAbilityTypeT
	{
		// Token: 0x1700BCFF RID: 48383
		// (get) Token: 0x0602B74E RID: 177998 RVA: 0x005EBB66 File Offset: 0x005E9D66
		// (set) Token: 0x0602B74F RID: 177999 RVA: 0x005EBB6E File Offset: 0x005E9D6E
		public EFollowShooterType Type { get; set; }

		// Token: 0x0602B750 RID: 178000 RVA: 0x005EBB77 File Offset: 0x005E9D77
		public IFollowShooterAbilityTypeT()
		{
			this.Type = EFollowShooterType.JellyFish;
		}
	}
}
