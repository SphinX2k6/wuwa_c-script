using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061EC RID: 25068
	public class IBattleSettlementT
	{
		// Token: 0x1700BAE5 RID: 47845
		// (get) Token: 0x0602B35F RID: 176991 RVA: 0x005F4670 File Offset: 0x005F2870
		// (set) Token: 0x0602B360 RID: 176992 RVA: 0x005F4678 File Offset: 0x005F2878
		public EDynamicSettlementType Type { get; set; }

		// Token: 0x1700BAE6 RID: 47846
		// (get) Token: 0x0602B361 RID: 176993 RVA: 0x005F4681 File Offset: 0x005F2881
		// (set) Token: 0x0602B362 RID: 176994 RVA: 0x005F4689 File Offset: 0x005F2889
		public int GamePlayCue { get; set; }

		// Token: 0x1700BAE7 RID: 47847
		// (get) Token: 0x0602B363 RID: 176995 RVA: 0x005F4692 File Offset: 0x005F2892
		// (set) Token: 0x0602B364 RID: 176996 RVA: 0x005F469A File Offset: 0x005F289A
		public EBattleSettlementBgmType BgmType { get; set; }

		// Token: 0x1700BAE8 RID: 47848
		// (get) Token: 0x0602B365 RID: 176997 RVA: 0x005F46A3 File Offset: 0x005F28A3
		// (set) Token: 0x0602B366 RID: 176998 RVA: 0x005F46AB File Offset: 0x005F28AB
		public byte NullMask { get; set; }

		// Token: 0x0602B367 RID: 176999 RVA: 0x005F46B4 File Offset: 0x005F28B4
		public IBattleSettlementT()
		{
			this.Type = EDynamicSettlementType.Battle;
			this.GamePlayCue = 0;
			this.BgmType = EBattleSettlementBgmType.BattleSoundWave;
			this.NullMask = 0;
		}
	}
}
