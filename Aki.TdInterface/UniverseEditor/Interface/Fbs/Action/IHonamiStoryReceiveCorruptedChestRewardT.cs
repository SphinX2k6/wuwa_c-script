using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE1 RID: 28641
	public class IHonamiStoryReceiveCorruptedChestRewardT
	{
		// Token: 0x1700D1C5 RID: 53701
		// (get) Token: 0x060319F0 RID: 203248 RVA: 0x006B8EB7 File Offset: 0x006B70B7
		// (set) Token: 0x060319F1 RID: 203249 RVA: 0x006B8EBF File Offset: 0x006B70BF
		public int Cost { get; set; }

		// Token: 0x1700D1C6 RID: 53702
		// (get) Token: 0x060319F2 RID: 203250 RVA: 0x006B8EC8 File Offset: 0x006B70C8
		// (set) Token: 0x060319F3 RID: 203251 RVA: 0x006B8ED0 File Offset: 0x006B70D0
		public int CostGroup { get; set; }

		// Token: 0x1700D1C7 RID: 53703
		// (get) Token: 0x060319F4 RID: 203252 RVA: 0x006B8ED9 File Offset: 0x006B70D9
		// (set) Token: 0x060319F5 RID: 203253 RVA: 0x006B8EE1 File Offset: 0x006B70E1
		public string ChangeSelfEntityStateAfterReceived { get; set; }

		// Token: 0x1700D1C8 RID: 53704
		// (get) Token: 0x060319F6 RID: 203254 RVA: 0x006B8EEA File Offset: 0x006B70EA
		// (set) Token: 0x060319F7 RID: 203255 RVA: 0x006B8EF2 File Offset: 0x006B70F2
		public byte NullMask { get; set; }

		// Token: 0x060319F8 RID: 203256 RVA: 0x006B8EFB File Offset: 0x006B70FB
		public IHonamiStoryReceiveCorruptedChestRewardT()
		{
			this.Cost = 0;
			this.CostGroup = 0;
			this.ChangeSelfEntityStateAfterReceived = null;
			this.NullMask = 0;
		}
	}
}
