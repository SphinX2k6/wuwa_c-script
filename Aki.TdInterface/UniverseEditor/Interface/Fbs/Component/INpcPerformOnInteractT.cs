using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD4 RID: 23508
	public class INpcPerformOnInteractT
	{
		// Token: 0x1700AC06 RID: 44038
		// (get) Token: 0x06026CFE RID: 158974 RVA: 0x00550AA9 File Offset: 0x0054ECA9
		// (set) Token: 0x06026CFF RID: 158975 RVA: 0x00550AB1 File Offset: 0x0054ECB1
		public string Montage { get; set; }

		// Token: 0x1700AC07 RID: 44039
		// (get) Token: 0x06026D00 RID: 158976 RVA: 0x00550ABA File Offset: 0x0054ECBA
		// (set) Token: 0x06026D01 RID: 158977 RVA: 0x00550AC2 File Offset: 0x0054ECC2
		public bool NotInterruptMontageWhenFinishedInteract { get; set; }

		// Token: 0x1700AC08 RID: 44040
		// (get) Token: 0x06026D02 RID: 158978 RVA: 0x00550ACB File Offset: 0x0054ECCB
		// (set) Token: 0x06026D03 RID: 158979 RVA: 0x00550AD3 File Offset: 0x0054ECD3
		public byte NullMask { get; set; }

		// Token: 0x06026D04 RID: 158980 RVA: 0x00550ADC File Offset: 0x0054ECDC
		public INpcPerformOnInteractT()
		{
			this.Montage = null;
			this.NotInterruptMontageWhenFinishedInteract = false;
			this.NullMask = 0;
		}
	}
}
