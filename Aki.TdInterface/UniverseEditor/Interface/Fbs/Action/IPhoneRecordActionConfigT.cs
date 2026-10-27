using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA9 RID: 27817
	public class IPhoneRecordActionConfigT
	{
		// Token: 0x1700CF21 RID: 53025
		// (get) Token: 0x0603105B RID: 200795 RVA: 0x006A766A File Offset: 0x006A586A
		// (set) Token: 0x0603105C RID: 200796 RVA: 0x006A7672 File Offset: 0x006A5872
		public int PhoneMessageId { get; set; }

		// Token: 0x1700CF22 RID: 53026
		// (get) Token: 0x0603105D RID: 200797 RVA: 0x006A767B File Offset: 0x006A587B
		// (set) Token: 0x0603105E RID: 200798 RVA: 0x006A7683 File Offset: 0x006A5883
		public int DialogProgress { get; set; }

		// Token: 0x1700CF23 RID: 53027
		// (get) Token: 0x0603105F RID: 200799 RVA: 0x006A768C File Offset: 0x006A588C
		// (set) Token: 0x06031060 RID: 200800 RVA: 0x006A7694 File Offset: 0x006A5894
		public byte NullMask { get; set; }

		// Token: 0x06031061 RID: 200801 RVA: 0x006A769D File Offset: 0x006A589D
		public IPhoneRecordActionConfigT()
		{
			this.PhoneMessageId = 0;
			this.DialogProgress = 0;
			this.NullMask = 0;
		}
	}
}
