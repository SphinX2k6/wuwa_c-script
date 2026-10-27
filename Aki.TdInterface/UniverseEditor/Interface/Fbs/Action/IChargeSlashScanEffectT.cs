using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006356 RID: 25430
	public class IChargeSlashScanEffectT
	{
		// Token: 0x1700BDBA RID: 48570
		// (get) Token: 0x0602BFD9 RID: 180185 RVA: 0x0060B91C File Offset: 0x00609B1C
		// (set) Token: 0x0602BFDA RID: 180186 RVA: 0x0060B924 File Offset: 0x00609B24
		public ESpecificScanType Type { get; set; }

		// Token: 0x1700BDBB RID: 48571
		// (get) Token: 0x0602BFDB RID: 180187 RVA: 0x0060B92D File Offset: 0x00609B2D
		// (set) Token: 0x0602BFDC RID: 180188 RVA: 0x0060B935 File Offset: 0x00609B35
		public int TriggerPosEntityId { get; set; }

		// Token: 0x0602BFDD RID: 180189 RVA: 0x0060B93E File Offset: 0x00609B3E
		public IChargeSlashScanEffectT()
		{
			this.Type = ESpecificScanType.None;
			this.TriggerPosEntityId = 0;
		}
	}
}
