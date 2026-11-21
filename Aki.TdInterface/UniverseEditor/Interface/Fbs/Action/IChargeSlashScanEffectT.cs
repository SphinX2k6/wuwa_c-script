using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C7 RID: 27079
	public class IChargeSlashScanEffectT
	{
		// Token: 0x1700C742 RID: 51010
		// (get) Token: 0x0602E743 RID: 190275 RVA: 0x00656A70 File Offset: 0x00654C70
		// (set) Token: 0x0602E744 RID: 190276 RVA: 0x00656A78 File Offset: 0x00654C78
		public ESpecificScanType Type { get; set; }

		// Token: 0x1700C743 RID: 51011
		// (get) Token: 0x0602E745 RID: 190277 RVA: 0x00656A81 File Offset: 0x00654C81
		// (set) Token: 0x0602E746 RID: 190278 RVA: 0x00656A89 File Offset: 0x00654C89
		public int TriggerPosEntityId { get; set; }

		// Token: 0x0602E747 RID: 190279 RVA: 0x00656A92 File Offset: 0x00654C92
		public IChargeSlashScanEffectT()
		{
			this.Type = ESpecificScanType.None;
			this.TriggerPosEntityId = 0;
		}
	}
}
