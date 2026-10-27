using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006443 RID: 25667
	public class ICloseUiGameT
	{
		// Token: 0x1700BF1C RID: 48924
		// (get) Token: 0x0602C6CE RID: 181966 RVA: 0x0061835E File Offset: 0x0061655E
		// (set) Token: 0x0602C6CF RID: 181967 RVA: 0x00618366 File Offset: 0x00616566
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x0602C6D0 RID: 181968 RVA: 0x0061836F File Offset: 0x0061656F
		public ICloseUiGameT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
