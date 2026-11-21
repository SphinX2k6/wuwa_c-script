using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006797 RID: 26519
	public class IAddOrSubAlertValueChangeSpeedT
	{
		// Token: 0x1700C0D4 RID: 49364
		// (get) Token: 0x0602CF8E RID: 184206 RVA: 0x0062583C File Offset: 0x00623A3C
		// (set) Token: 0x0602CF8F RID: 184207 RVA: 0x00625844 File Offset: 0x00623A44
		public EValueChangeType Type { get; set; }

		// Token: 0x1700C0D5 RID: 49365
		// (get) Token: 0x0602CF90 RID: 184208 RVA: 0x0062584D File Offset: 0x00623A4D
		// (set) Token: 0x0602CF91 RID: 184209 RVA: 0x00625855 File Offset: 0x00623A55
		public float DeltaValue { get; set; }

		// Token: 0x0602CF92 RID: 184210 RVA: 0x0062585E File Offset: 0x00623A5E
		public IAddOrSubAlertValueChangeSpeedT()
		{
			this.Type = EValueChangeType.AddOrSub;
			this.DeltaValue = 0f;
		}
	}
}
