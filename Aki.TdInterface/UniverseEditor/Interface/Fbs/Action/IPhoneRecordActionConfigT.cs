using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200741F RID: 29727
	public class IPhoneRecordActionConfigT
	{
		// Token: 0x1700DA5E RID: 55902
		// (get) Token: 0x06034032 RID: 213042 RVA: 0x0070289E File Offset: 0x00700A9E
		// (set) Token: 0x06034033 RID: 213043 RVA: 0x007028A6 File Offset: 0x00700AA6
		public int PhoneMessageId { get; set; }

		// Token: 0x1700DA5F RID: 55903
		// (get) Token: 0x06034034 RID: 213044 RVA: 0x007028AF File Offset: 0x00700AAF
		// (set) Token: 0x06034035 RID: 213045 RVA: 0x007028B7 File Offset: 0x00700AB7
		public int DialogProgress { get; set; }

		// Token: 0x1700DA60 RID: 55904
		// (get) Token: 0x06034036 RID: 213046 RVA: 0x007028C0 File Offset: 0x00700AC0
		// (set) Token: 0x06034037 RID: 213047 RVA: 0x007028C8 File Offset: 0x00700AC8
		public byte NullMask { get; set; }

		// Token: 0x06034038 RID: 213048 RVA: 0x007028D1 File Offset: 0x00700AD1
		public IPhoneRecordActionConfigT()
		{
			this.PhoneMessageId = 0;
			this.DialogProgress = 0;
			this.NullMask = 0;
		}
	}
}
