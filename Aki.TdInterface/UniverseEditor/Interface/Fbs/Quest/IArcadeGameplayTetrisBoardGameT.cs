using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004122 RID: 16674
	public class IArcadeGameplayTetrisBoardGameT
	{
		// Token: 0x170070F0 RID: 28912
		// (get) Token: 0x06016E21 RID: 93729 RVA: 0x00344688 File Offset: 0x00342888
		// (set) Token: 0x06016E22 RID: 93730 RVA: 0x00344690 File Offset: 0x00342890
		public EArcadeGameplayType Type { get; set; }

		// Token: 0x170070F1 RID: 28913
		// (get) Token: 0x06016E23 RID: 93731 RVA: 0x00344699 File Offset: 0x00342899
		// (set) Token: 0x06016E24 RID: 93732 RVA: 0x003446A1 File Offset: 0x003428A1
		public int LevelId { get; set; }

		// Token: 0x06016E25 RID: 93733 RVA: 0x003446AA File Offset: 0x003428AA
		public IArcadeGameplayTetrisBoardGameT()
		{
			this.Type = EArcadeGameplayType.DropCatch;
			this.LevelId = 0;
		}
	}
}
