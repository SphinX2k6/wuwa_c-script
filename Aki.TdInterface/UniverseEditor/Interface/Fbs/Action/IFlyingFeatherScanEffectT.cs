using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EBB RID: 28347
	public class IFlyingFeatherScanEffectT
	{
		// Token: 0x1700CFF0 RID: 53232
		// (get) Token: 0x060310B7 RID: 200887 RVA: 0x006A6B7C File Offset: 0x006A4D7C
		// (set) Token: 0x060310B8 RID: 200888 RVA: 0x006A6B84 File Offset: 0x006A4D84
		public ESpecificScanType Type { get; set; }

		// Token: 0x1700CFF1 RID: 53233
		// (get) Token: 0x060310B9 RID: 200889 RVA: 0x006A6B8D File Offset: 0x006A4D8D
		// (set) Token: 0x060310BA RID: 200890 RVA: 0x006A6B95 File Offset: 0x006A4D95
		public int TriggerPosEntityId { get; set; }

		// Token: 0x060310BB RID: 200891 RVA: 0x006A6B9E File Offset: 0x006A4D9E
		public IFlyingFeatherScanEffectT()
		{
			this.Type = ESpecificScanType.None;
			this.TriggerPosEntityId = 0;
		}
	}
}
