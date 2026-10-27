using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F0 RID: 21488
	public class IIndependentSystemRewardComponentT
	{
		// Token: 0x17009E26 RID: 40486
		// (get) Token: 0x060234A1 RID: 144545 RVA: 0x004E2D45 File Offset: 0x004E0F45
		// (set) Token: 0x060234A2 RID: 144546 RVA: 0x004E2D4D File Offset: 0x004E0F4D
		public bool Disabled { get; set; }

		// Token: 0x17009E27 RID: 40487
		// (get) Token: 0x060234A3 RID: 144547 RVA: 0x004E2D56 File Offset: 0x004E0F56
		// (set) Token: 0x060234A4 RID: 144548 RVA: 0x004E2D5E File Offset: 0x004E0F5E
		public IDarkTideIndependentSystemRewardT RewardType { get; set; }

		// Token: 0x17009E28 RID: 40488
		// (get) Token: 0x060234A5 RID: 144549 RVA: 0x004E2D67 File Offset: 0x004E0F67
		// (set) Token: 0x060234A6 RID: 144550 RVA: 0x004E2D6F File Offset: 0x004E0F6F
		public byte NullMask { get; set; }

		// Token: 0x060234A7 RID: 144551 RVA: 0x004E2D78 File Offset: 0x004E0F78
		public IIndependentSystemRewardComponentT()
		{
			this.Disabled = false;
			this.RewardType = null;
			this.NullMask = 0;
		}
	}
}
