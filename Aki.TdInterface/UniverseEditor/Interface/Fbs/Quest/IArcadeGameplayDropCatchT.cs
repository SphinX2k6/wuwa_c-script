using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200411F RID: 16671
	public class IArcadeGameplayDropCatchT
	{
		// Token: 0x170070EB RID: 28907
		// (get) Token: 0x06016E0B RID: 93707 RVA: 0x00344488 File Offset: 0x00342688
		// (set) Token: 0x06016E0C RID: 93708 RVA: 0x00344490 File Offset: 0x00342690
		public EArcadeGameplayType Type { get; set; }

		// Token: 0x170070EC RID: 28908
		// (get) Token: 0x06016E0D RID: 93709 RVA: 0x00344499 File Offset: 0x00342699
		// (set) Token: 0x06016E0E RID: 93710 RVA: 0x003444A1 File Offset: 0x003426A1
		public int LevelId { get; set; }

		// Token: 0x06016E0F RID: 93711 RVA: 0x003444AA File Offset: 0x003426AA
		public IArcadeGameplayDropCatchT()
		{
			this.Type = EArcadeGameplayType.DropCatch;
			this.LevelId = 0;
		}
	}
}
