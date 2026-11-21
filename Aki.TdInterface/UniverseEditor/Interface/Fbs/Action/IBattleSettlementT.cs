using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200685A RID: 26714
	public class IBattleSettlementT
	{
		// Token: 0x1700C468 RID: 50280
		// (get) Token: 0x0602DAA6 RID: 187046 RVA: 0x0063F0E4 File Offset: 0x0063D2E4
		// (set) Token: 0x0602DAA7 RID: 187047 RVA: 0x0063F0EC File Offset: 0x0063D2EC
		public EDynamicSettlementType Type { get; set; }

		// Token: 0x1700C469 RID: 50281
		// (get) Token: 0x0602DAA8 RID: 187048 RVA: 0x0063F0F5 File Offset: 0x0063D2F5
		// (set) Token: 0x0602DAA9 RID: 187049 RVA: 0x0063F0FD File Offset: 0x0063D2FD
		public int GamePlayCue { get; set; }

		// Token: 0x1700C46A RID: 50282
		// (get) Token: 0x0602DAAA RID: 187050 RVA: 0x0063F106 File Offset: 0x0063D306
		// (set) Token: 0x0602DAAB RID: 187051 RVA: 0x0063F10E File Offset: 0x0063D30E
		public EBattleSettlementBgmType BgmType { get; set; }

		// Token: 0x1700C46B RID: 50283
		// (get) Token: 0x0602DAAC RID: 187052 RVA: 0x0063F117 File Offset: 0x0063D317
		// (set) Token: 0x0602DAAD RID: 187053 RVA: 0x0063F11F File Offset: 0x0063D31F
		public byte NullMask { get; set; }

		// Token: 0x0602DAAE RID: 187054 RVA: 0x0063F128 File Offset: 0x0063D328
		public IBattleSettlementT()
		{
			this.Type = EDynamicSettlementType.Battle;
			this.GamePlayCue = 0;
			this.BgmType = EBattleSettlementBgmType.BattleSoundWave;
			this.NullMask = 0;
		}
	}
}
