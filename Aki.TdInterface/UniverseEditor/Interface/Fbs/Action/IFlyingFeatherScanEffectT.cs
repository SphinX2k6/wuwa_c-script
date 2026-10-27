using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006835 RID: 26677
	public class IFlyingFeatherScanEffectT
	{
		// Token: 0x1700C62C RID: 50732
		// (get) Token: 0x0602E82F RID: 190511 RVA: 0x00658C3C File Offset: 0x00656E3C
		// (set) Token: 0x0602E830 RID: 190512 RVA: 0x00658C44 File Offset: 0x00656E44
		public ESpecificScanType Type { get; set; }

		// Token: 0x1700C62D RID: 50733
		// (get) Token: 0x0602E831 RID: 190513 RVA: 0x00658C4D File Offset: 0x00656E4D
		// (set) Token: 0x0602E832 RID: 190514 RVA: 0x00658C55 File Offset: 0x00656E55
		public int TriggerPosEntityId { get; set; }

		// Token: 0x0602E833 RID: 190515 RVA: 0x00658C5E File Offset: 0x00656E5E
		public IFlyingFeatherScanEffectT()
		{
			this.Type = ESpecificScanType.None;
			this.TriggerPosEntityId = 0;
		}
	}
}
