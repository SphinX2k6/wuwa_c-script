using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200692E RID: 26926
	public class IHonamiStoryReceiveCorruptedChestRewardT
	{
		// Token: 0x1700C7C2 RID: 51138
		// (get) Token: 0x0602F020 RID: 192544 RVA: 0x006689CF File Offset: 0x00666BCF
		// (set) Token: 0x0602F021 RID: 192545 RVA: 0x006689D7 File Offset: 0x00666BD7
		public int Cost { get; set; }

		// Token: 0x1700C7C3 RID: 51139
		// (get) Token: 0x0602F022 RID: 192546 RVA: 0x006689E0 File Offset: 0x00666BE0
		// (set) Token: 0x0602F023 RID: 192547 RVA: 0x006689E8 File Offset: 0x00666BE8
		public int CostGroup { get; set; }

		// Token: 0x1700C7C4 RID: 51140
		// (get) Token: 0x0602F024 RID: 192548 RVA: 0x006689F1 File Offset: 0x00666BF1
		// (set) Token: 0x0602F025 RID: 192549 RVA: 0x006689F9 File Offset: 0x00666BF9
		public string ChangeSelfEntityStateAfterReceived { get; set; }

		// Token: 0x1700C7C5 RID: 51141
		// (get) Token: 0x0602F026 RID: 192550 RVA: 0x00668A02 File Offset: 0x00666C02
		// (set) Token: 0x0602F027 RID: 192551 RVA: 0x00668A0A File Offset: 0x00666C0A
		public byte NullMask { get; set; }

		// Token: 0x0602F028 RID: 192552 RVA: 0x00668A13 File Offset: 0x00666C13
		public IHonamiStoryReceiveCorruptedChestRewardT()
		{
			this.Cost = 0;
			this.CostGroup = 0;
			this.ChangeSelfEntityStateAfterReceived = null;
			this.NullMask = 0;
		}
	}
}
